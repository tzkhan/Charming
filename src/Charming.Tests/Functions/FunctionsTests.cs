namespace Charming.Tests.Functions
{
    using FluentAssertions;
    using Xunit;
    using static Charming.Functions;

    public class FunctionsTests
    {
        private const string resourceType = "type";

        private class TestFunction : IFunction
        {
            public string Invoke() => "testFunction()";
        }

        private class TestResource : Resource
        {
            public TestResource() => Type = resourceType;
        }

        [Fact]
        public void Reference_WithResource_ShouldReturnCorrectlyFormattedFunctionString()
        {
            // Arrange
            const string name = "name";
            var resource = new TestResource { Name = name };

            // Act
            var result = Reference(resource);

            // Assert
            result.Should().Be($"reference('{name}')");
        }

        [Fact]
        public void ReferenceFull_ShouldReturnCorrectlyFormattedFunctionString()
        {
            // Arrange
            const string name = "name";
            const string apiVersion = "apiVersion";
            var resource = new TestResource { Name = name, ApiVersion = apiVersion };

            // Act
            var result = ReferenceFull(resource);

            // Assert
            result.Should().Be($"reference('{name}', '{apiVersion}', 'Full')");
        }

        [Theory]
        [InlineData(null, null, false, false, "")]
        [InlineData(null, null, false, true, "")]
        [InlineData(null, null, true, false, "")]
        [InlineData(null, null, true, true, "")]
        [InlineData(null, "apiVersion", false, false, "")]
        [InlineData(null, "apiVersion", false, true, "")]
        [InlineData(null, "apiVersion", true, false, "")]
        [InlineData(null, "apiVersion", true, true, "")]
        [InlineData("resource", null, false, false, "reference(resource)")]
        [InlineData("resource", null, false, true, "reference('resource')")]
        [InlineData("resource", null, true, false, "reference(resource, 'Full')")]
        [InlineData("resource", null, true, true, "reference('resource', 'Full')")]
        [InlineData("resource", "apiVersion", false, false, "reference(resource, 'apiVersion')")]
        [InlineData("resource", "apiVersion", false, true, "reference('resource', 'apiVersion')")]
        [InlineData("resource", "apiVersion", true, false, "reference(resource, 'apiVersion', 'Full')")]
        [InlineData("resource", "apiVersion", true, true, "reference('resource', 'apiVersion', 'Full')")]
        public void Reference_ShouldReturnCorrectlyFormattedFunctionString(
            string resource,
            string apiVersion,
            bool full,
            bool enquoteResource,
            string expected)
        {
            // Act
            var result = Reference(resource, apiVersion, full, enquoteResource);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, null, "resourceId('type', 'name')")]
        [InlineData(null, null, "segment", "resourceId('type', 'name', 'segment')")]
        [InlineData(null, "resourceGroupName", null, "resourceId('resourceGroupName', 'type', 'name')")]
        [InlineData(null, "resourceGroupName", "segment", "resourceId('resourceGroupName', 'type', 'name', 'segment')")]
        [InlineData("subcriptionId", null, null, "resourceId('subcriptionId', 'type', 'name')")]
        [InlineData("subcriptionId", null, "segment", "resourceId('subcriptionId', 'type', 'name', 'segment')")]
        [InlineData("subcriptionId", "resourceGroupName", null, "resourceId('subcriptionId', 'resourceGroupName', 'type', 'name')")]
        [InlineData("subcriptionId", "resourceGroupName", "segment", "resourceId('subcriptionId', 'resourceGroupName', 'type', 'name', 'segment')")]
        public void ResourceId_ShouldReturnCorrectlyFormattedFunctionString(
            string subscriptionId,
            string resourceGroupName,
            string segment,
            string expected)
        {
            // Arrange
            const string name = "name";
            var resource = new TestResource { Name = name };

            // Act
            var result = ResourceId(subscriptionId, resourceGroupName, resource, segment);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void ResourceId_ShouldReturnEmptyStringWhenNullResourcePassed()
        {
            // Act
            var result = ResourceId("", "", null, null);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact]
        public void ResourceGroup_ShouldReturnCorrectlyFormattedFunctionString()
        {
            // Act
            var result = ResourceGroup();

            // Assert
            result.Invoke().Should().Be("resourceGroup()");
            result.ToString().Should().Be("resourceGroup()");
            result.Id.Should().Be("resourceGroup().id");
            result.Name.Should().Be("resourceGroup().name");
            result.Type.Should().Be("resourceGroup().type");
            result.Location.Should().Be("resourceGroup().location");
            result.ManagedBy.Should().Be("resourceGroup().managedBy");
            result.Tags.Should().Be("resourceGroup().tags");
        }

        [Fact]
        public void Subscription_ShouldReturnCorrectlyFormattedFunctionString()
        {
            // Act
            var result = Subscription();

            // Assert
            result.Invoke().Should().Be("subscription()");
            result.ToString().Should().Be("subscription()");
            result.Id.Should().Be("subscription().id");
            result.DisplayName.Should().Be("subscription().displayName");
            result.SubscriptionId.Should().Be("subscription().subscriptionId");
            result.TenantId.Should().Be("subscription().tenantId");
        }

        [Fact]
        public void Box_WithString_ShouldReturnStringEnclosedWithSquareBraces()
        {
            // Act
            var result = "functionCall()".Box();

            // Assert
            result.Should().Be("[functionCall()]");
        }

        [Fact]
        public void Box_WithFunction_ShouldReturnFunctionCallEnclosedWithSquareBraces()
        {
            // Act
            var result = new TestFunction().Invoke().Box();

            // Assert
            result.Should().Be("[testFunction()]");
        }
    }
}
