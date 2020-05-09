namespace Charming
{
    /// <summary>
    /// Represents a resource group scoped deployment template.
    /// </summary>
    public class ResourceGroupDeploymentTemplate : Template
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupDeploymentTemplate"/> class.
        /// Sets the <see cref="ITemplate.Schema"/> and <see cref="ITemplate.ContentVersion"/>
        /// to default values.
        /// </summary>
        public ResourceGroupDeploymentTemplate()
        {
            Schema = Constants.DeploymentTemplateSchema;
            ContentVersion = Constants.DefaultContentVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupDeploymentTemplate"/> class.
        /// Sets the <see cref="ITemplate.ContentVersion"/> to a default value.
        /// </summary>
        /// <param name="schema">Schema location describing the json used.</param>
        public ResourceGroupDeploymentTemplate(string schema) =>
            (Schema, ContentVersion) = (schema, Constants.DefaultContentVersion);

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceGroupDeploymentTemplate"/> class.
        /// </summary>
        /// <param name="schema">Schema location describing the json used.</param>
        /// <param name="contentVersion">Version of the template.</param>
        public ResourceGroupDeploymentTemplate(string schema, string contentVersion) =>
            (Schema, ContentVersion) = (schema, contentVersion);
    }
}
