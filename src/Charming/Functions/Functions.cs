namespace Charming
{
    using System.Collections.Generic;

    public static class Functions
    {
        private static readonly ResourceGroupFunction _resourceGroup = new ResourceGroupFunction();
        private static readonly SubscriptionFunction _subscription = new SubscriptionFunction();

        public static string Reference(
            string resource,
            string? apiVersion = default,
            bool full = default,
            bool enquoteResource = true)
        {
            if (string.IsNullOrWhiteSpace(resource))
            {
                return string.Empty;
            }

            var resourceArg = enquoteResource ? $"'{resource}'" : resource;
            var apiVersionArg = string.IsNullOrWhiteSpace(apiVersion) ? string.Empty : $", '{apiVersion}'";
            var fullArg = full ? ", 'Full'" : string.Empty;

            return $"reference({resourceArg}{apiVersionArg}{fullArg})";
        }

        public static string ResourceId(IResource resource, params string[] segments)
        {
            return ResourceId(null, null, resource, segments);
        }

        public static string ResourceId(string resourceGroupName, IResource resource, params string[] segments)
        {
            return ResourceId(null, resourceGroupName, resource, segments);
        }

        public static string ResourceId(string? subscriptionId, string? resourceGroupName, IResource resource, params string[] segments)
        {
            if (resource == null)
            {
                return string.Empty;
            }

            var args = new List<string>();

            if (!string.IsNullOrWhiteSpace(subscriptionId))
            {
                args.Add($"'{subscriptionId}'");
            }

            if (!string.IsNullOrWhiteSpace(resourceGroupName))
            {
                args.Add($"'{resourceGroupName}'");
            }

            args.Add($"'{resource.Type}'");
            args.Add($"'{resource.Name}'");

            if (segments?.Length > 0)
            {
                foreach (var segment in segments)
                {
                    args.Add($"'{segment}'");
                }
            }

            return $"resourceId({string.Join(", ", args)})";
        }

        public static ResourceGroupFunction ResourceGroup() => _resourceGroup;

        public static SubscriptionFunction Subscription() => _subscription;

        public static string Box(this string functionCall) => $"[{functionCall}]";

        public static string Box(this IFunction function) => $"[{function}]";
    }
}
