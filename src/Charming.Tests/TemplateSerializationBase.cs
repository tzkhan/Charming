namespace Charming.Tests
{
    using System.Collections.Generic;
    using FluentAssertions;
    using FluentAssertions.Json;
    using Newtonsoft.Json.Linq;
    using static Constants;

    public abstract class TemplateSerializationBase
    {
        protected const string DefaultTemplateSchema = "schema";
        protected const string DefaultResourceType = "namespace/type";
        protected const string DefaultChildResourceType = "namespace/type/childType";
        protected const string DefaultChildResourceTypeWithoutNamespace = "childType";
        protected const string DefaultApiVersion = "apiVersion";

        protected string ReplaceDefaults(string json) =>
            json
            .Replace("{DefaultTemplateSchema}", DefaultTemplateSchema)
            .Replace("{DefaultContentVersion}", DefaultContentVersion)
            .Replace("{DefaultResourceType}", DefaultResourceType)
            .Replace("{DefaultChildResourceType}", DefaultChildResourceType)
            .Replace("{DefaultChildResourceTypeWithoutNamespace}", DefaultChildResourceTypeWithoutNamespace)
            .Replace("{DefaultApiVersion}", DefaultApiVersion);

        protected void JsonShouldBeEquivalent(string expected, string actual) =>
            JObject.Parse(actual).Should().BeEquivalentTo(JObject.Parse(ReplaceDefaults(expected)));

        protected class TestTemplate : Template
        {
            public TestTemplate() => (Schema, ContentVersion) = (DefaultTemplateSchema, DefaultContentVersion);
        }

        protected class TestResourceWithoutProperties : Resource
        {
            public TestResourceWithoutProperties() => (Type, ApiVersion) = (DefaultResourceType, DefaultApiVersion);
        }

        protected class TestResourceWithEmptyProperties : Resource<TestPropertiesEmpty>
        {
            public TestResourceWithEmptyProperties() => (Type, ApiVersion) = (DefaultResourceType, DefaultApiVersion);
        }

        protected class TestPropertiesEmpty { }

        protected class TestResourceWithPropertiesWithEnums : Resource<TestPropertiesWithEnums>
        {
            public TestResourceWithPropertiesWithEnums() => (Type, ApiVersion) = (DefaultResourceType, DefaultApiVersion);
        }

        protected class TestPropertiesWithEnums
        {
            public TestEnum? EnumProp { get; set; }
            public TestEnum EnumNonNullProp { get; set; }
        }

        protected enum TestEnum { Option1, Option2, }

        protected class TestResource : Resource<TestProperties>
        {
            public TestResource() => (Type, ApiVersion) = (DefaultResourceType, DefaultApiVersion);
            public TestResource(string name) : this() => Name = name;
            public TestResource(string name, Location location) : this() => (Name, Location) = (name, location);
        }

        protected class TestChildResource : Resource<TestProperties>
        {
            public TestChildResource() => (Type, ApiVersion) = (DefaultChildResourceType, DefaultApiVersion);
            public TestChildResource(string name) : this() => Name = name;
        }

        protected class TestProperties
        {
            public bool? BoolProp { get; set; }
            public TestInfo InfoProp { get; set; }
            public int? IntProp { get; set; }
            public IList<string> ListStringProp { get; set; }
            public IList<TestInfo> ListInfoProp { get; set; }
            public string StringProp { get; set; }
            public ITemplate TemplateProp { get; set; }
            public IList<Parameter> ParametersProp { get; set; }
        }

        protected class TestInfo
        {
            public bool? BoolProp { get; set; }
            public int? IntProp { get; set; }
            public string StringProp { get; set; }
        }
    }
}
