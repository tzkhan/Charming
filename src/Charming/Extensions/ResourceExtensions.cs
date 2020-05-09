namespace Charming
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Charming.Internal;

    /// <summary>
    /// Convenience extension methods to allow easy adding
    /// of items to some of the <see cref="Resource"/> properties.
    /// </summary>
    [DebuggerNonUserCode]
    public static class ResourceExtensions
    {
        /// <summary>
        /// Adds a sequence of resources to <see cref="Resource.DependsOn"/>.
        /// </summary>
        /// <param name="resource">Cuurent resource.</param>
        /// <param name="dependencies">Resources to add as dependencies.</param>
        public static void AddDependencies(this Resource resource, IEnumerable<Resource> dependencies) =>
            resource.DependsOn.AddEnumerable(dependencies);

        /// <summary>
        /// Adds a sequence of resources to <see cref="Resource.Resources"/>.
        /// </summary>
        /// <param name="resource">Current resource.</param>
        /// <param name="resources">Child resources to add to the current resource.</param>
        public static void AddResources(this Resource resource, IEnumerable<Resource> resources) =>
            resource.Resources.AddEnumerable(resources);

        /// <summary>
        /// Adds a dictionary of tag key values to <see cref="Resource.Tags"/>.
        /// </summary>
        /// <param name="resource">Current resource.</param>
        /// <param name="tags">Tags to add to the current resource.</param>
        public static void AddTags(this Resource resource, IDictionary<string, string> tags) =>
            resource.Tags.AddEnumerable(tags);

        /// <summary>
        /// Adds a sequence of resources to <see cref="Resource.DependsOn"/>.
        /// </summary>
        /// <typeparam name="TResource">A type representing a resource.</typeparam>
        /// <param name="resource">Cuurent resource.</param>
        /// <param name="dependencies">Resources to add as dependencies.</param>
        /// <returns>Returns the current resource for chaining.</returns>
        public static TResource WithDependencies<TResource>(this TResource resource, IEnumerable<Resource> dependencies)
            where TResource : Resource =>
            resource.WithEnumerable(resource.DependsOn, dependencies);

        /// <summary>
        /// Adds a sequence of resources to <see cref="Resource.Resources"/>.
        /// </summary>
        /// <typeparam name="TResource">A type representing a resource.</typeparam>
        /// <param name="resource">Current resource.</param>
        /// <param name="resources">Child resources to add to the current resource.</param>
        /// <returns>Returns the current resource for chaining.</returns>
        public static TResource WithResources<TResource>(this TResource resource, IEnumerable<Resource> resources)
            where TResource : Resource =>
            resource.WithEnumerable(resource.Resources, resources);

        /// <summary>
        /// Adds a dictionary of tag key values to <see cref="Resource.Tags"/>.
        /// </summary>
        /// <typeparam name="TResource">A type representing a resource.</typeparam>
        /// <param name="resource">Current resource.</param>
        /// <param name="tags">Tags to add to the current resource.</param>
        /// <returns>Returns the current resource for chaining.</returns>
        public static TResource WithTags<TResource>(this TResource resource, IDictionary<string, string> tags)
            where TResource : Resource =>
            resource.WithEnumerable(resource.Tags, tags);

        private static TResource WithEnumerable<TResource, T>(
            this TResource resource,
            ICollection<T> collection,
            IEnumerable<T> enumerable)
            where TResource : Resource
        {
            collection.AddEnumerable(enumerable);
            return resource;
        }
    }
}
