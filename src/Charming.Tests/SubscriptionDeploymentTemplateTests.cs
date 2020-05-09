namespace Charming.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SubscriptionDeploymentTemplateTests
    {
        [Fact]
        public void SubscriptionDeploymentTemplate_ShouldSetSchemaAndContentVersion_WhenInstantiatedWithDefaultCtor()
        {
            // Act
            var result = new SubscriptionDeploymentTemplate();

            // Assert
            result.Schema.Should().Be(Constants.SubscriptionDeploymentTemplateSchema);
            result.ContentVersion.Should().Be(Constants.DefaultContentVersion);
        }
    }
}
