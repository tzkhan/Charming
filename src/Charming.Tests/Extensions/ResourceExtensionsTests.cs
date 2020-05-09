namespace Charming.Tests.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Xunit;

    public class ResourceExtensionsTests
    {
        private class TestResource : Resource { }

        [Fact]
        public void AddDependencies_ShouldAddResourcesToDependsOnProperty()
        {
            // Arrange
            var resource = new TestResource();
            var dependency = new TestResource();

            // Act
            resource.AddDependencies(new[] { dependency });

            // Assert
            resource.DependsOn.Should().HaveCount(1);
            resource.DependsOn.First().Should().BeSameAs(dependency);
        }

        [Fact]
        public void AddDependencies_ShouldNotAddResourcesToDependsOnProperty_WhenNullPassed()
        {
            // Arrange
            var resource = new TestResource();

            // Act
            resource.AddDependencies(null);

            // Assert
            resource.DependsOn.Should().BeEmpty();
        }

        [Fact]
        public void AddResources_ShouldAddResourcesToResourcesProperty()
        {
            // Arrange
            var resource = new TestResource();
            var childResource = new TestResource();

            // Act
            resource.AddResources(new[] { childResource });

            // Assert
            resource.Resources.Should().HaveCount(1);
            resource.Resources.First().Should().BeSameAs(childResource);
        }

        [Fact]
        public void AddResources_ShouldNotAddResourcesToResourcesProperty_WhenNullPassed()
        {
            // Arrange
            var resource = new TestResource();

            // Act
            resource.AddResources(null);

            // Assert
            resource.Resources.Should().BeEmpty();
        }

        [Fact]
        public void AddTags_ShouldAddTagsToTagsProperty()
        {
            // Arrange
            var resource = new TestResource();
            var key = "key";
            var value = "value";
            var tags = new Dictionary<string, string> { { key, value } };

            // Act
            resource.AddTags(tags);

            // Assert
            resource.Tags.Should().HaveCount(1);
            resource.Tags.Should().ContainKey(key);
            resource.Tags.First().Value.Should().Be(value);
        }

        [Fact]
        public void AddTags_ShouldNotAddTagsToTagsProperty_WhenNullPassed()
        {
            // Arrange
            var resource = new TestResource();

            // Act
            resource.AddTags(null);

            // Assert
            resource.Tags.Should().BeEmpty();
        }

        [Fact]
        public void WithDependencies_WithParamsResources_ShouldAddResourceToResourcesPropertyAndReturnTemplate()
        {
            // Arrange
            var resource = new TestResource();
            var dependency = new TestResource();

            // Act
            var result = resource.WithDependencies(dependency);

            // Assert
            result.Should().BeSameAs(resource);
            result.DependsOn.Should().HaveCount(1);
            result.DependsOn.First().Should().BeSameAs(dependency);
        }

        [Fact]
        public void WithDependencies_WithListOfResources_ShouldAddResourceToDependsOnPropertyAndReturnResource()
        {
            // Arrange
            var resource = new TestResource();
            var dependency = new TestResource();

            // Act
            var result = resource.WithDependencies(new List<Resource> { dependency });

            // Assert
            result.Should().BeSameAs(resource);
            result.DependsOn.Should().HaveCount(1);
            result.DependsOn.First().Should().BeSameAs(dependency);
        }

        [Fact]
        public void WithDependencies_ShouldReturnResourceWithoutAddingResourcesToDependsOnProperty_WhenNullPassed()
        {
            // Arrange
            var resource = new TestResource();

            // Act
            var result = resource.WithDependencies(null);

            // Assert
            result.Should().BeSameAs(resource);
            result.DependsOn.Should().BeEmpty();
        }

        [Fact]
        public void WithResources_WithParamsResources_ShouldAddResourceToResourcesPropertyAndReturnResource()
        {
            // Arrange
            var resource = new TestResource();
            var childResource = new TestResource();

            // Act
            var result = resource.WithResources(childResource);

            // Assert
            result.Should().BeSameAs(resource);
            result.Resources.Should().HaveCount(1);
            result.Resources.First().Should().BeSameAs(childResource);
        }

        [Fact]
        public void WithResources_WithListOfResources_ShouldAddResourceToResourcesPropertyAndReturnResource()
        {
            // Arrange
            var resource = new TestResource();
            var childResource = new TestResource();

            // Act
            var result = resource.WithResources(new List<Resource> { childResource });

            // Assert
            result.Should().BeSameAs(resource);
            result.Resources.Should().HaveCount(1);
            result.Resources.First().Should().BeSameAs(childResource);
        }

        [Fact]
        public void WithResources_ShouldReturnResourceWithoutAddingResourcesToResourcesProperty_WhenNullPassed()
        {
            // Arrange
            var resource = new TestResource();

            // Act
            var result = resource.WithResources(null);

            // Assert
            result.Should().BeSameAs(resource);
            result.Resources.Should().BeEmpty();
        }

        [Fact]
        public void WithTags_ShouldAddTagsToTagsPropertyAndReturnResource()
        {
            // Arrange
            var resource = new TestResource();
            var key = "key";
            var value = "value";
            var tags = new Dictionary<string, string> { { key, value } };

            // Act
            var result = resource.WithTags(tags);

            // Assert
            result.Should().BeSameAs(resource);
            result.Tags.Should().HaveCount(1);
            result.Tags.Should().ContainKey(key);
            result.Tags.First().Value.Should().Be(value);
        }

        [Fact]
        public void WithTags_ShouldReturnResourceWithoutAddingTagsToTagsProperty_WhenNullPassed()
        {
            // Arrange
            var resource = new TestResource();

            // Act
            var result = resource.WithTags(null);

            // Assert
            result.Should().BeSameAs(resource);
            result.Tags.Should().BeEmpty();
        }
    }
}
