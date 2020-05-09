namespace Charming.Internal
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;

    internal class TemplateContractResolver : DefaultContractResolver
    {
        private readonly Dictionary<Type, JsonConverter> _objectConverterMapping = new Dictionary<Type, JsonConverter>();
        private readonly Dictionary<Type, HashSet<string>> _ignoreMapping = new Dictionary<Type, HashSet<string>>();
        private readonly Dictionary<Type, HashSet<string>> _emptyAllowedEnumerableMapping = new Dictionary<Type, HashSet<string>>();
        private readonly Dictionary<(Type, string), string> _renameMapping = new Dictionary<(Type, string), string>();
        private readonly Dictionary<(Type, string), JsonConverter> _propertyConverterMapping = new Dictionary<(Type, string), JsonConverter>();
        private readonly Dictionary<(Type, string), IValueProvider> _propertyValueProviderMapping = new Dictionary<(Type, string), IValueProvider>();

        private TemplateContractResolver()
        {
            NamingStrategy = new CamelCaseNamingStrategy
            {
                ProcessDictionaryKeys = true,
                OverrideSpecifiedNames = true,
            };

            _objectConverterMapping.Add(typeof(Enum), new StringEnumConverter());
            _objectConverterMapping.Add(typeof(IList<Parameter>), new ParametersConverter());

            _emptyAllowedEnumerableMapping.Add(typeof(ITemplate), new HashSet<string> { "resources", "outputs" });

            _renameMapping.Add((typeof(ITemplate), "schema"), "$schema");

            _propertyConverterMapping.Add((typeof(Resource), "dependsOn"), new DependsOnConverter());
            _propertyConverterMapping.Add((typeof(Resource), "location"), new StringEnumConverter(new LowerCaseNamingStrategy()));
            _propertyConverterMapping.Add((typeof(ITemplate), "outputs"), new OutputsConverter());

            _propertyValueProviderMapping.Add((typeof(Resource), "type"), new ResourceTypeValueProvider());
        }

        internal static TemplateContractResolver Instance { get; } = new TemplateContractResolver();

        protected override JsonContract CreateContract(Type objectType)
        {
            var contract = base.CreateContract(objectType);

            if (ObjectHasConverter(objectType, out var converter))
            {
                contract.Converter = converter;
            }

            return contract;
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            if (property.DeclaringType is null
                || property.PropertyName is null
                || property.PropertyType is null)
            {
                return property;
            }

            if (ShouldIgnoreProperty(property.DeclaringType, property.PropertyName))
            {
                property.Ignored = true;
                property.ShouldSerialize = _ => false;

                return property;
            }

            if (IsEnumerable(property.PropertyType)
                && ShouldCheckPropertyForSerializing(property.DeclaringType, property.PropertyName))
            {
                property.ShouldSerialize = x => IsEnumerableInstanceEmpty(x, member.Name);
            }

            if (PropertyHasConverter(property.DeclaringType, property.PropertyName, out var converter))
            {
                property.Converter = converter;
            }

            if (PropertyHasValueProvider(property.DeclaringType, property.PropertyName, out var valueProvider))
            {
                property.ValueProvider = valueProvider;
            }

            if (ShouldRenameProperty(property.DeclaringType, property.PropertyName, out var newName))
            {
                property.PropertyName = newName;
            }

            return property;
        }

        private bool ObjectHasConverter(Type objectType, out JsonConverter? converter) =>
            _objectConverterMapping.TryGetValueForAssignableType(objectType, out converter);

        private bool ShouldIgnoreProperty(Type declaringType, string propertyName) =>
            _ignoreMapping.TryGetValueForAssignableType(declaringType, out var value) && value!.Contains(propertyName);

        private bool IsEnumerable(Type propertyType) =>
            typeof(string) != propertyType && typeof(IEnumerable).IsAssignableFrom(propertyType);

        private bool ShouldCheckPropertyForSerializing(Type declaringType, string propertyName) =>
            !(_emptyAllowedEnumerableMapping.TryGetValueForAssignableType(declaringType, out var value) && value!.Contains(propertyName));

        private bool IsEnumerableInstanceEmpty(object instance, string propertyName) =>
            (instance?.GetType().GetProperty(propertyName).GetValue(instance) as IEnumerable)?.GetEnumerator().MoveNext() ?? false;

        private bool ShouldRenameProperty(Type declaringType, string oldName, out string? newName) =>
            _renameMapping.TryGetValueForAssignableType((declaringType, oldName), out newName);

        private bool PropertyHasConverter(Type declaringType, string propertyName, out JsonConverter? converter) =>
            _propertyConverterMapping.TryGetValueForAssignableType((declaringType, propertyName), out converter);

        private bool PropertyHasValueProvider(Type declaringType, string propertyName, out IValueProvider? valueProvider) =>
            _propertyValueProviderMapping.TryGetValueForAssignableType((declaringType, propertyName), out valueProvider);
    }
}
