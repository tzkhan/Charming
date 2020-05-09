namespace Charming
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents an ARM template.
    /// </summary>
    public interface ITemplate
    {
        /// <summary>
        /// Gets or sets the location of the json schema file
        /// that describes the version of the template language.
        /// <see cref="Constants"/> defines some of the latest
        /// schema locations.
        /// </summary>
        string Schema { get; set; }

        /// <summary>
        /// Gets or sets the version of the template. Any value can be set.
        /// Use <see cref="Constants.DefaultContentVersion"/> for a default value.
        /// </summary>
        string ContentVersion { get; set; }

        /// <summary>
        /// Gets a list of resources that represent resource types
        /// which will be created or updated during a deployment.
        /// </summary>
        IList<Resource> Resources { get; }

        /// <summary>
        /// Gets a list of outputs that represent values that are
        /// returned after deployment.
        /// </summary>
        IList<Output> Outputs { get; }

        /// <summary>
        /// Generates json for this template.
        /// </summary>
        /// <returns>Returns the generated json for this template.</returns>
        string ToJson();

        /// <summary>
        /// Generates json for this template.
        /// </summary>
        /// <param name="options">Various settings to control serialization of the template.</param>
        /// <returns>Returns the generated json for this template.</returns>
        string ToJson(SerializerOptions options);
    }
}
