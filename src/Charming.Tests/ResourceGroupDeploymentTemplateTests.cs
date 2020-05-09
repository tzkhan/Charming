namespace Charming.Tests
{
    using FluentAssertions;
    using Xunit;

    public class ResourceGroupDeploymentTemplateTests
    {
        [Fact]
        public void DefaultCtor_ShouldSetSchemaAndContentVersion()
        {
            // Act
            var result = new ResourceGroupDeploymentTemplate();

            // Assert
            result.Schema.Should().Be(Constants.DeploymentTemplateSchema);
            result.ContentVersion.Should().Be(Constants.DefaultContentVersion);
        }
    }
}
