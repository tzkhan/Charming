#pragma warning disable SA1402
namespace Charming
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents an Azure resource type.
    /// </summary>
    public abstract class Resource
    {
        /// <summary>
        /// Gets or sets the type of the resource.
        /// Should be in the form: 'resource-provider-namespace/resource-type-name'.
        /// </summary>
        public string Type { get; protected set; } = string.Empty;

        /// <summary>
        /// Gets or sets the version of the REST API to use for creating the resource.
        /// See https://docs.microsoft.com/en-us/azure/templates/ for available values.
        /// </summary>
        public string ApiVersion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the resource. It must follow URI component restrictions
        /// defined in RFC3986. Fully qualify the name of a child resource if it's not
        /// being nested under a parent resource. For more details, see
        /// https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/child-resource-name-type.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets an Azure region for the resource to be deployed to.
        /// </summary>
        public Location? Location { get; set; }

        /// <summary>
        /// Gets a list of resources that must be deployed before the current resource
        /// is deployed.
        /// </summary>
        public IList<Resource> DependsOn { get; } = new List<Resource>();

        /// <summary>
        /// Gets or sets the SKU values that some resources allow to be defined.
        /// </summary>
        public Sku? Sku { get; set; }

        /// <summary>
        /// Gets or sets the kind of resource that some resources allow to be defined.
        /// </summary>
        public string? Kind { get; set; }

        /// <summary>
        /// Gets a list of tags associated with this resource.
        /// </summary>
        public IDictionary<string, string> Tags { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets a list of child resources.
        /// </summary>
        public IList<Resource> Resources { get; } = new List<Resource>();

        /// <summary>
        /// Gets or sets the parent resource if applicable.
        /// </summary>
        internal Resource? Parent { get; set; }
    }

    /// <summary>
    /// Represents an Azure resource type.
    /// </summary>
    /// <typeparam name="TProperties">Represents resource specific configuration values.</typeparam>
    public abstract class Resource<TProperties> : Resource
        where TProperties : new()
    {
        /// <summary>
        /// Gets or sets the resource specific configuration values.
        /// </summary>
        public TProperties Properties { get; set; } = new TProperties();
    }
}
