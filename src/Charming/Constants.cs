namespace Charming
{
    /// <summary>
    /// Contains constants typically used within a template.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Default value for the <see cref="Template.ContentVersion"/> property in a template.
        /// </summary>
        public const string DefaultContentVersion = "1.0.0.0";

        /// <summary>
        /// Location of the json schema file that describes a resource group scoped deployment template.
        /// </summary>
        public const string DeploymentTemplateSchema = "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#";

        /// <summary>
        /// Location of the json schema file that describes a subcription scoped deployment template.
        /// </summary>
        public const string SubscriptionDeploymentTemplateSchema = "https://schema.management.azure.com/schemas/2018-05-01/subscriptionDeploymentTemplate.json#";
    }
}
