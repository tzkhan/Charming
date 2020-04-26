namespace Charming.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;

    internal class TemplateContractResolver : DefaultContractResolver
    {
        private readonly Dictionary<Type, JsonConverter> _objectConverterMapping = new Dictionary<Type, JsonConverter>();
        private readonly Dictionary<Type, HashSet<string>> _ignoreMapping = new Dictionary<Type, HashSet<string>>();
        private readonly Dictionary<(Type, string), string> _renameMapping = new Dictionary<(Type, string), string>();
        private readonly Dictionary<(Type, string), JsonConverter> _propertyConverterMapping = new Dictionary<(Type, string), JsonConverter>();

        private TemplateContractResolver()
        {
            NamingStrategy = new CamelCaseNamingStrategy
            {
                ProcessDictionaryKeys = true,
                OverrideSpecifiedNames = true,
            };

            Initialise();
        }

        internal static TemplateContractResolver Instance { get; } = new TemplateContractResolver();

        protected override JsonContract CreateContract(Type objectType)
        {
            var contract = base.CreateContract(objectType);

            if (ObjectHasConverter(objectType, out JsonConverter converter))
            {
                contract.Converter = converter;
            }

            return contract;
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            if (ShouldIgnoreProperty(property.DeclaringType, property.PropertyName))
            {
                property.Ignored = true;
                property.ShouldSerialize = x => false;

                return property;
            }

            if (ShouldRenameProperty(property.DeclaringType, property.PropertyName, out string newName))
            {
                property.PropertyName = newName;
            }

            if (PropertyHasConverter(property.DeclaringType, property.PropertyName, out JsonConverter converter))
            {
                property.Converter = converter;
            }

            return property;
        }

        private void Initialise()
        {
            _objectConverterMapping.Add(typeof(DeploymentMode), new StringEnumConverter());

            _ignoreMapping.Add(typeof(IResource), new HashSet<string> { "id" });
            _ignoreMapping.Add(typeof(ITemplate), new HashSet<string> { "filePath" });

            _renameMapping.Add((typeof(ITemplate), "schema"), "$schema");

            _propertyConverterMapping.Add((typeof(IResource), "dependsOn"), new DependsOnConverter());
            _propertyConverterMapping.Add((typeof(IResource), "location"), new StringEnumConverter(new LowerCaseNamingStrategy()));
            _propertyConverterMapping.Add((typeof(ITemplate), "outputs"), new OutputsConverter());
        }

        private bool ObjectHasConverter(Type type, out JsonConverter converter) =>
            _objectConverterMapping.TryGetValueForAssignableType(type, out converter);

        private bool ShouldIgnoreProperty(Type type, string name) =>
            _ignoreMapping.TryGetValueForAssignableType(type, out var value) && value.Contains(name);

        private bool ShouldRenameProperty(Type type, string oldName, out string newName) =>
            _renameMapping.TryGetValueForAssignableType((type, oldName), out newName);

        private bool PropertyHasConverter(Type type, string name, out JsonConverter converter) =>
            _propertyConverterMapping.TryGetValueForAssignableType((type, name), out converter);
    }
}
