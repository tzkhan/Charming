namespace Charming
{
    using System.Collections.Generic;

    public class ResourceGroupDeploymentTemplate : ITemplate
    {
        public string Schema { get; set; } = Constants.DeploymentTemplateSchema;

        public string ContentVersion { get; set; } = Constants.DefaultContentVersion;

        public IList<IResource> Resources { get; } = new List<IResource>();

        public IList<Output> Outputs { get; } = new List<Output>();
    }
}
