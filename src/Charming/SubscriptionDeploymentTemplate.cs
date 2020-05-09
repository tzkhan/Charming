namespace Charming
{
    /// <summary>
    /// Represents a subscription scoped deployment template.
    /// </summary>
    public class SubscriptionDeploymentTemplate : Template
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDeploymentTemplate"/> class.
        /// Sets the <see cref="ITemplate.Schema"/> and <see cref="ITemplate.ContentVersion"/>
        /// to default values.
        /// </summary>
        public SubscriptionDeploymentTemplate()
        {
            Schema = Constants.SubscriptionDeploymentTemplateSchema;
            ContentVersion = Constants.DefaultContentVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDeploymentTemplate"/> class.
        /// Sets the <see cref="ITemplate.ContentVersion"/> to a default value.
        /// </summary>
        /// <param name="schema">Schema location describing the json used.</param>
        public SubscriptionDeploymentTemplate(string schema) =>
            (Schema, ContentVersion) = (schema, Constants.DefaultContentVersion);

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDeploymentTemplate"/> class.
        /// </summary>
        /// <param name="schema">Schema location describing the json used.</param>
        /// <param name="contentVersion">Version of the template.</param>
        public SubscriptionDeploymentTemplate(string schema, string contentVersion) =>
            (Schema, ContentVersion) = (schema, contentVersion);
    }
}
