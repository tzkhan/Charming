namespace Charming.Types.Resources
{
    using Charming;

    public class Deployment : Resource<Deployment.PropertyCollection>
    {
        public Deployment() => (Type, ApiVersion) = ("Microsoft.Resources/deployments", "2019-10-01");

        public string SubscriptionId { get; set; }

        public string ResourceGroup { get; set; }

        public partial class PropertyCollection
        {
            public ITemplate Template { get; set; }
            public TemplateLinkInfo TemplateLink { get; set; }
            public object Parameters { get; set; }
            public ParametersLinkInfo ParametersLink { get; set; }
            public string Mode { get; set; }
            public DebugSettingInfo DebugSetting { get; set; }
            public OnErrorDeploymentInfo OnErrorDeployment { get; set; }
        }

        public partial class TemplateLinkInfo
        {
            public string Uri { get; set; }
            public string ContentVersion { get; set; }
        }

        public partial class ParametersLinkInfo
        {
            public string Uri { get; set; }
            public string ContentVersion { get; set; }
        }

        public partial class DebugSettingInfo
        {
            public string DetailLevel { get; set; }
        }

        public partial class OnErrorDeploymentInfo
        {
            public string Type { get; set; }
            public string DeploymentName { get; set; }
        }
    }
}
