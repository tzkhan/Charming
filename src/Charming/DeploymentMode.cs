namespace Charming
{
    /// <summary>
    /// Specifies the deployment mode to use for a given template.
    /// For details go to: https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/deployment-modes.
    /// </summary>
    public enum DeploymentMode
    {
        /// <summary>
        /// In Incremental mode, existing resources that are not specified in the template are left unchanged.
        /// </summary>
        Incremental,

        /// <summary>
        /// In Complete mode, existing resources that are not specified in the template are deleted.
        /// </summary>
        Complete,
    }
}
