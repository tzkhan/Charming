namespace Charming.Tests
{
    using Charming.Types.Resources;
    using FluentAssertions;
    using Xunit;

    public class PropertiesSetterTests
    {
        [Fact]
        public void NullAndAssignmentTests()
        {
            const string value = "value";
            var resource = new Deployment();

            resource.Properties.Mode.Should().Be(DeploymentMode.Incremental);
            resource.Properties.DebugSetting.Should().BeNull();
            resource.Properties.ParametersLink.Should().BeNull();
            resource.Properties.TemplateLink.Should().BeNull();
            resource.Properties.Template.Should().BeNull();

            resource.WithProperties(x =>
            {
                x.Mode = DeploymentMode.Complete;
                var temp = x.DebugSetting;
                x.TemplateLink.Uri = value;
            });

            resource.Properties.Mode.Should().Be(DeploymentMode.Complete);
            resource.Properties.DebugSetting.Should().NotBeNull();
            resource.Properties.ParametersLink.Should().BeNull();
            resource.Properties.TemplateLink.Should().NotBeNull();
            resource.Properties.TemplateLink.Uri.Should().Be(value);
            resource.Properties.Template.Should().BeNull();
        }
    }
}
