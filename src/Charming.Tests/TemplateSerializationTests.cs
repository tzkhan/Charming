namespace Charming.Tests
{
    using System.Collections.Generic;
    using Xunit;

    public class TemplateSerializationTests : TemplateSerializationBase
    {
        private readonly SerializerOptions _options = new SerializerOptions { Indent = false };

        [Fact]
        public void EmptyTemplate()
        {
            // Arrange
            var template = new TestTemplate();

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithoutProperties()
        {
            // Arrange
            var template = new TestTemplate()
                .WithResources(new TestResourceWithoutProperties());

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """"
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithEmptyProperties()
        {
            // Arrange
            var template = new TestTemplate()
                .WithResources(new TestResourceWithEmptyProperties());

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {
                  }
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithPropertiesSetter()
        {
            // Arrange
            var resource = new Types.Resources.Deployment()
                .WithProperties(x =>
                {
                    x.Mode = DeploymentMode.Complete;
                    x.TemplateLink.Uri = "value";
                });

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {
                    ""mode"": ""Complete"",
                    ""templateLink"": {
                      ""uri"": ""value""
                    }
                  },
                }
              ],
              ""outputs"": {}
            }";

            expected = expected
                .Replace("{DefaultResourceType}", resource.Type)
                .Replace("{DefaultApiVersion}", resource.ApiVersion);

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithProperties()
        {
            // Arrange
            var resource = new TestResource
            {
                Properties = new TestProperties
                {
                    BoolProp = true,
                    InfoProp = new TestInfo
                    {
                        BoolProp = true,
                        IntProp = 0,
                        StringProp = "value",
                    },
                    IntProp = 0,
                    ListStringProp = new List<string> { "value1", "value2" },
                    ListInfoProp = new List<TestInfo>
                    {
                        new TestInfo { StringProp = "value1" },
                        new TestInfo { StringProp = "value2" },
                    },
                    StringProp = "value",
                },
            };

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {
                    ""boolProp"": true,
                    ""infoProp"": {
                      ""boolProp"": true,
                      ""intProp"": 0,
                      ""stringProp"": ""value""
                    },
                    ""intProp"": 0,
                    ""listStringProp"": [
                      ""value1"",
                      ""value2""
                    ],
                    ""listInfoProp"": [
                      {
                        ""stringProp"": ""value1""
                      },
                      {
                        ""stringProp"": ""value2""
                      }
                    ],
                    ""stringProp"": ""value""
                  },
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithPropertiesWithTemplate()
        {
            // Arrange
            var resource = new TestResource
            {
                Properties = new TestProperties
                {
                    TemplateProp = new TestTemplate()
                        .WithResources(new TestResource()),
                },
            };

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {
                    ""templateProp"": {
                      ""$schema"":""{DefaultTemplateSchema}"",
                      ""contentVersion"":""{DefaultContentVersion}"",
                      ""resources"": [
                        {
                          ""type"": ""{DefaultResourceType}"",
                          ""apiVersion"": ""{DefaultApiVersion}"",
                          ""name"": """",
                          ""properties"": {}
                        }
                      ],
                      ""outputs"": {}
                    }
                  },
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithPropertiesWithTemplateLoop()
        {
            // Arrange
            var resource = new TestResource();
            resource.Properties = new TestProperties
            {
                TemplateProp = new TestTemplate()
                    .WithResources(resource),
            };

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {
                    ""templateProp"": {
                      ""$schema"":""{DefaultTemplateSchema}"",
                      ""contentVersion"":""{DefaultContentVersion}"",
                      ""resources"": [],
                      ""outputs"": {}
                    }
                  },
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithPropertiesWithParameters()
        {
            // Arrange
            var resource = new TestResource
            {
                Properties = new TestProperties
                {
                    ParametersProp = new List<Parameter>
                    {
                        new Parameter { Name = "param1", Value = "value1" },
                        new Parameter { Name = "param2", Value = "value2" },
                    },
                },
            };

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {
                    ""parametersProp"": {
                      ""param1"": {
                        ""value"": ""value1""
                      },
                      ""param2"": {
                        ""value"": ""value2""
                      }
                    }
                  },
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithPropertiesWithEnums()
        {
            // Arrange
            var template = new TestTemplate()
                .WithResources(new TestResourceWithPropertiesWithEnums());

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {
                    ""enumNonNullProp"": ""Option1""
                  }
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithLocalPropertiesSet()
        {
            // Arrange
            var resource = new TestResource("name", Location.UKSouth)
            {
                Kind = "kind",
                Sku = new Sku { Name = "name" },
            };

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": ""name"",
                  ""location"": ""uksouth"",
                  ""kind"": ""kind"",
                  ""sku"": {
                    ""name"": ""name"",
                  },
                  ""properties"": {}
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithDependencies()
        {
            // Arrange
            var dependency1 = new TestResource("dependency1");
            var dependency2 = new TestResource("dependency2");

            var resource = new TestResource()
                .WithDependencies(new[] { dependency1, dependency2 });

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""dependsOn"": [
                    ""[resourceId('{DefaultResourceType}', 'dependency1')]"",
                    ""[resourceId('{DefaultResourceType}', 'dependency2')]""
                  ],
                  ""properties"": {}
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithChildResources()
        {
            // Arrange
            var childResource1 = new TestChildResource("childResource1");
            var childResource2 = new TestChildResource("childResource2");

            var resource = new TestResource()
                .WithResources(new[] { childResource1, childResource2 });

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""properties"": {},
                  ""resources"": [
                    {
                      ""type"": ""{DefaultChildResourceTypeWithoutNamespace}"",
                      ""apiVersion"": ""{DefaultApiVersion}"",
                      ""name"": ""childResource1"",
                      ""properties"": {}
                    },
                    {
                      ""type"": ""{DefaultChildResourceTypeWithoutNamespace}"",
                      ""apiVersion"": ""{DefaultApiVersion}"",
                      ""name"": ""childResource2"",
                      ""properties"": {}
                    }
                  ]
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithTags()
        {
            // Arrange
            var tags = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" },
            };

            var resource = new TestResource()
                .WithTags(tags);

            var template = new TestTemplate()
                .WithResources(resource);

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [
                {
                  ""type"": ""{DefaultResourceType}"",
                  ""apiVersion"": ""{DefaultApiVersion}"",
                  ""name"": """",
                  ""tags"": {
                    ""key1"": ""value1"",
                    ""key2"": ""value2""
                  },
                  ""properties"": {}
                }
              ],
              ""outputs"": {}
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithArrayOfStringOutput()
        {
            // Arrange
            var template = new TestTemplate()
                .WithOutputs(Output.Array("key", "value1", "value2"));

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [],
              ""outputs"": {
                ""key"": {
                  ""type"": ""array"",
                  ""value"": [
                    ""value1"",
                    ""value2""
                  ]
                }
              }
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithArrayOfObjectOutput()
        {
            // Arrange
            var mappings = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string> { { "key1", "value1" } },
                new Dictionary<string, string> { { "key2", "value2" } },
            };

            var template = new TestTemplate()
                .WithOutputs(Output.Array("key", mappings));

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [],
              ""outputs"": {
                ""key"": {
                  ""type"": ""array"",
                  ""value"": [
                    {
                      ""key1"": ""value1""
                    },
                    {
                      ""key2"": ""value2""
                    }
                  ]
                }
              }
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithStringObjectOutput()
        {
            // Arrange
            var template = new TestTemplate()
                .WithOutputs(Output.Object("key1", "value1", isSecure: false))
                .WithOutputs(Output.Object("key2", "value2", isSecure: true));

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [],
              ""outputs"": {
                ""key1"": {
                  ""type"": ""object"",
                  ""value"": ""value1""
                },
                ""key2"": {
                  ""type"": ""secureobject"",
                  ""value"": ""value2""
                }
              }
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithObjectOutput()
        {
            // Arrange
            var mapping = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" },
            };

            var template = new TestTemplate()
                .WithOutputs(Output.Object("key1", mapping, isSecure: false))
                .WithOutputs(Output.Object("key2", mapping, isSecure: true));

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [],
              ""outputs"": {
                ""key1"": {
                  ""type"": ""object"",
                  ""value"": {
                    ""key1"": ""value1"",
                    ""key2"": ""value2""
                  }
                },
                ""key2"": {
                  ""type"": ""secureobject"",
                  ""value"": {
                    ""key1"": ""value1"",
                    ""key2"": ""value2""
                  }
                }
              }
            }";

            JsonShouldBeEquivalent(expected, result);
        }

        [Fact]
        public void ResourceWithStringOutput()
        {
            // Arrange
            var template = new TestTemplate()
                .WithOutputs(Output.String("key1", "value1", isSecure: false))
                .WithOutputs(Output.String("key2", "value2", isSecure: true));

            // Act
            var result = template.ToJson(_options);

            // Assert
            var expected = @"{
              ""$schema"":""{DefaultTemplateSchema}"",
              ""contentVersion"":""{DefaultContentVersion}"",
              ""resources"": [],
              ""outputs"": {
                ""key1"": {
                  ""type"": ""string"",
                  ""value"": ""value1""
                },
                ""key2"": {
                  ""type"": ""securestring"",
                  ""value"": ""value2""
                }
              }
            }";

            JsonShouldBeEquivalent(expected, result);
        }
    }
}
