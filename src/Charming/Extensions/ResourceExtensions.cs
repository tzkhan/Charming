namespace Charming
{
    using System.Collections.Generic;

    public static class ResourceExtensions
    {
        public static void AddDependencies(this IResource resource, IList<IResource> dependencies) =>
            AddCollection(dependencies, resource?.DependsOn);

        public static void AddResources(this IResource resource, IList<IResource> resources) =>
            AddCollection(resources, resource?.Resources);

        public static void AddTags(this IResource resource, IDictionary<string, string> tags) =>
            AddCollection(tags, resource?.Tags);

        private static void AddCollection<T>(ICollection<T> source, ICollection<T> destination)
        {
            if (source?.Count == 0)
            {
                return;
            }

            foreach (var item in source)
            {
                destination.Add(item);
            }
        }
    }
}
