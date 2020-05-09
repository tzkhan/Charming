namespace Charming.Tests.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Xunit;

    public class TemplateExtensionsTests
    {
        private class TestTemplate : Template { }
        private class TestResource : Resource { }

        [Fact]
        public void AddArrayOutput_WithParamsValues_ShouldAddArrayOutputValueContainingListOfStringOutputValuesToOutputsProperty()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var value = "value";

            // Act
            template.AddArrayOutput(key, value);

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<ArrayOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<ArrayOutputValue>().Value.Should().BeOfType<List<OutputValue>>();
            template.Outputs.First()
                .Value.As<ArrayOutputValue>()
                .Value.First().As<StringOutputValue>()
                .Value.Should().Be(value);

            Assert.Equal(value, ((StringOutputValue)((ArrayOutputValue)template.Outputs[0].Value).Value[0]).Value);
        }

        [Fact]
        public void AddArrayOutput_WithListOfValues_ShouldAddArrayOutputValueContainingListOfStringOutputValuesToOutputsProperty()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var value = "value";

            // Act
            template.AddArrayOutput(key, new List<string> { value });

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<ArrayOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<ArrayOutputValue>().Value.Should().BeOfType<List<OutputValue>>();
            template.Outputs.First()
                .Value.As<ArrayOutputValue>()
                .Value.First().As<StringOutputValue>()
                .Value.Should().Be(value);
        }

        [Fact]
        public void AddArrayOutput_WithListOfValueMappings_ShouldAddArrayOutputValueContainingListOfObjectOutputValuesToOutputsProperty()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var nestedKey = "nestedKey";
            var nestedValue = "nestedValue";
            var mapping = new Dictionary<string, string> { { nestedKey, nestedValue} };

            // Act
            template.AddArrayOutput(key, new[] { mapping });

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<ArrayOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<ArrayOutputValue>().Value.Should().BeOfType<List<OutputValue>>();
            template.Outputs.First()
                .Value.As<ArrayOutputValue>()
                .Value.First().As<ObjectOutputValue>()
                .Value[nestedKey].As<StringOutputValue>()
                .Value.Should().Be(nestedValue);
        }

        [Fact]
        public void AddObjectOutput_WithStringValue_ShouldAddStringOutputValueToOutputsProperty()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var value = "value";

            // Act
            template.AddObjectOutput(key, value);

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<StringOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().IsObject.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().IsSecure.Should().BeFalse();
            template.Outputs.First().Value.As<StringOutputValue>().Value.Should().Be(value);
        }

        [Fact]
        public void AddSecureObjectOutput_WithStringValue_ShouldAddStringOutputValueToOutputsPropertyAndSetIsSecureToTrue()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var value = "value";

            // Act
            template.AddSecureObjectOutput(key, value);

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<StringOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().IsObject.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().IsSecure.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().Value.Should().Be(value);
        }

        [Fact]
        public void AddObjectOutput_WithValueMapping_ShouldAddObjectOutputValueWithNestedStringOutputValueToOutputsProperty()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var nestedKey = "nestedKey";
            var nestedValue = "nestedValue";
            var mapping = new Dictionary<string, string> { { nestedKey, nestedValue } };

            // Act
            template.AddObjectOutput(key, mapping);

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<ObjectOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<ObjectOutputValue>().IsSecure.Should().BeFalse();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].Should().BeOfType<StringOutputValue>();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].As<StringOutputValue>().IsObject.Should().BeFalse();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].As<StringOutputValue>().IsSecure.Should().BeFalse();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].As<StringOutputValue>().Value.Should().Be(nestedValue);
        }

        [Fact]
        public void AddSecureObjectOutput_WithValueMapping_ShouldAddObjectOutputValueWithNestedStringOutputValueToOutputsPropertyAndSetIsSecureToTrue()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var nestedKey = "nestedKey";
            var nestedValue = "nestedValue";
            var mapping = new Dictionary<string, string> { { nestedKey, nestedValue } };

            // Act
            template.AddSecureObjectOutput(key, mapping);

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<ObjectOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<ObjectOutputValue>().IsSecure.Should().BeTrue();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].Should().BeOfType<StringOutputValue>();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].As<StringOutputValue>().IsObject.Should().BeFalse();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].As<StringOutputValue>().IsSecure.Should().BeFalse();
            template.Outputs.First().Value.As<ObjectOutputValue>().Value[nestedKey].As<StringOutputValue>().Value.Should().Be(nestedValue);
        }

        [Fact]
        public void AddStringOutput_ShouldAddStringOutputValueToOutputsProperty()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var value = "value";

            // Act
            template.AddStringOutput(key, value);

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<StringOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().IsObject.Should().BeFalse();
            template.Outputs.First().Value.As<StringOutputValue>().IsSecure.Should().BeFalse();
            template.Outputs.First().Value.As<StringOutputValue>().Value.Should().Be(value);
        }

        [Fact]
        public void AddSecureStringOutput_ShouldAddStringOutputValueToOutputsPropertyAndSetIsSecureToTrue()
        {
            // Arrange
            var template = new TestTemplate();
            var key = "key";
            var value = "value";

            // Act
            template.AddSecureStringOutput(key, value);

            // Assert
            template.Outputs.Should().HaveCount(1);
            template.Outputs.First().Key.Should().Be(key);
            template.Outputs.First().Value.Should().BeOfType<StringOutputValue>();
            template.Outputs.First().Value.HasValue.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().IsObject.Should().BeFalse();
            template.Outputs.First().Value.As<StringOutputValue>().IsSecure.Should().BeTrue();
            template.Outputs.First().Value.As<StringOutputValue>().Value.Should().Be(value);
        }

        [Fact]
        public void WithResources_WithParamsResources_ShouldAddResourceToResourcesPropertyAndReturnTemplate()
        {
            // Arrange
            var template = new TestTemplate();
            var resource = new TestResource();

            // Act
            var result = template.WithResources(resource);

            // Assert
            result.Should().BeSameAs(template);
            result.Resources.Should().HaveCount(1);
            result.Resources.First().Should().BeSameAs(resource);
        }

        [Fact]
        public void WithResources_WithListOfResources_ShouldAddResourceToResourcesPropertyAndReturnTemplate()
        {
            // Arrange
            var template = new TestTemplate();
            var resource = new TestResource();

            // Act
            var result = template.WithResources(new List<Resource> { resource });

            // Assert
            result.Should().BeSameAs(template);
            result.Resources.Should().HaveCount(1);
            result.Resources.First().Should().BeSameAs(resource);
        }

        [Fact]
        public void WithResources_ShouldReturnTemplateWithoutAddingToResourcesProperty_WhenNullPassed()
        {
            // Arrange
            var template = new TestTemplate();

            // Act
            var result = template.WithResources(null);

            // Assert
            result.Should().BeSameAs(template);
            result.Resources.Should().BeEmpty();
        }

        [Fact]
        public void WithOutputs_WithParamsOutputs_ShouldAddOutputsToOutputsPropertyAndReturnTemplate()
        {
            // Arrange
            var template = new TestTemplate();
            var output = Output.String("key", "value");

            // Act
            var result = template.WithOutputs(output);

            // Assert
            result.Should().BeSameAs(template);
            result.Outputs.Should().HaveCount(1);
            result.Outputs.First().Should().BeSameAs(output);
        }

        [Fact]
        public void WithOutputs_WithListOfOutputs_ShouldAddOutputsToOutputsPropertyAndReturnTemplate()
        {
            // Arrange
            var template = new TestTemplate();
            var output = Output.String("key", "value");

            // Act
            var result = template.WithOutputs(new List<Output> { output });

            // Assert
            result.Should().BeSameAs(template);
            result.Outputs.Should().HaveCount(1);
            result.Outputs.First().Should().BeSameAs(output);
        }

        [Fact]
        public void WithOutputs_ShouldReturnTemplateWithoutAddingToOutputsProperty_WhenNullPassed()
        {
            // Arrange
            var template = new TestTemplate();

            // Act
            var result = template.WithOutputs(null);

            // Assert
            result.Should().BeSameAs(template);
            result.Outputs.Should().BeEmpty();
        }
    }
}
