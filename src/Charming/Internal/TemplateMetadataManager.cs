namespace Charming.Internal
{
    using System.Collections.Generic;

    internal static class TemplateMetadataManager
    {
        public static void SetMetadata(ITemplate template)
        {
            SetResourceMetadata(template.Resources, null);
        }

        private static void SetResourceMetadata(IEnumerable<Resource> resources, Resource? parent)
        {
            foreach (var resource in resources)
            {
                resource.Parent = parent;

                SetResourceMetadata(resource.Resources, resource);
            }
        }
    }
}
