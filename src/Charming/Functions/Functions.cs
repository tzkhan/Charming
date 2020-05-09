namespace Charming
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains a set of helper methods that facilitate building a function call string.
    /// </summary>
    public static class Functions
    {
        private static readonly ResourceGroupFunction _resourceGroup = new ResourceGroupFunction();
        private static readonly SubscriptionFunction _subscription = new SubscriptionFunction();

        /// <summary>
        /// Generates a string representing a <c>reference()</c> function call.
        /// </summary>
        /// <param name="resource">Resource that should be referenced.</param>
        /// <returns>A string representing a <c>reference()</c> function call.</returns>
        public static string Reference(Resource resource) =>
            Reference(resource.Name, null, false, true);

        /// <summary>
        /// Generates a string representing a <c>reference()</c> function call.
        /// Also includes the <c>ApiVersion</c> and <c>Full</c> parameters in the function call.
        /// </summary>
        /// <param name="resource">Resource that should be referenced.</param>
        /// <returns>A string representing a <c>reference()</c> function call.</returns>
        public static string ReferenceFull(Resource resource) =>
            Reference(resource.Name, resource.ApiVersion, true, true);

        /// <summary>
        /// Generates a string representing a <c>reference()</c> function call.
        /// </summary>
        /// <param name="resource">Name of the resource that should be referenced.</param>
        /// <param name="enquoteResource">
        /// Indicates whether to wrap the resource name parameter value with single quotes.
        /// This should be set to <c>false</c> if using the <c>resourceId()</c> function to reference a resource name.
        /// </param>
        /// <returns>A string representing a <c>reference()</c> function call.</returns>
        public static string Reference(string resource, bool enquoteResource = true) =>
            Reference(resource, null, false, enquoteResource);

        /// <summary>
        /// Generates a string representing a <c>reference()</c> function call.
        /// </summary>
        /// <param name="resource">Name of the resource that should be referenced.</param>
        /// <param name="apiVersion">The ApiVersion of the resource being deployed.</param>
        /// <param name="full">
        /// Indicates whether to include the <c>Full</c> parameter in the function call.
        /// This should be set to <c>true</c> if <c>ApiVersion</c> is passed.
        /// </param>
        /// <param name="enquoteResource">
        /// Indicates whether to wrap the resource name parameter value with single quotes.
        /// This should be set to <c>false</c> if using the <c>resourceId()</c> function to reference a resource name.
        /// </param>
        /// <returns>A string representing a <c>reference()</c> function call.</returns>
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
            var apiVersionArg = !string.IsNullOrWhiteSpace(apiVersion) ? $", '{apiVersion}'" : string.Empty;
            var fullArg = full ? ", 'Full'" : string.Empty;

            return $"reference({resourceArg}{apiVersionArg}{fullArg})";
        }

        /// <summary>
        /// Generates a string representing a <c>resourceId()</c> function call.
        /// </summary>
        /// <param name="resource">Resource to get the unique identifier for.</param>
        /// <param name="segments">Additional names in case of referencing a child resource.</param>
        /// <returns>A string representing a <c>resourceId()</c> function call.</returns>
        public static string ResourceId(Resource resource, params string[] segments) =>
            ResourceId(null, null, resource, segments);

        /// <summary>
        /// Generates a string representing a <c>resourceId()</c> function call.
        /// </summary>
        /// <param name="resourceGroupName">
        /// Name of the resource group that the resource is in if it is different to the current one.
        /// </param>
        /// <param name="resource">Resource to get the unique identifier for.</param>
        /// <param name="segments">Additional names in case of referencing a child resource.</param>
        /// <returns>A string representing a <c>resourceId()</c> function call.</returns>
        public static string ResourceId(string resourceGroupName, Resource resource, params string[] segments) =>
            ResourceId(null, resourceGroupName, resource, segments);

        /// <summary>
        /// Generates a string representing a <c>resourceId()</c> function call.
        /// </summary>
        /// <param name="subscriptionId">
        /// Identifier of the subscription that the resource is in if it is different to the current one.
        /// </param>
        /// <param name="resourceGroupName">
        /// Name of the resource group that the resource is in if it is different to the current one.
        /// </param>
        /// <param name="resource">Resource to get the unique identifier for.</param>
        /// <param name="segments">Additional names in case of referencing a child resource.</param>
        /// <returns>A string representing a <c>resourceId()</c> function call.</returns>
        public static string ResourceId(
            string? subscriptionId,
            string? resourceGroupName,
            Resource resource,
            params string[] segments)
        {
            if (resource is null)
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
                    if (!string.IsNullOrWhiteSpace(segment))
                    {
                        args.Add($"'{segment}'");
                    }
                }
            }

            return $"resourceId({string.Join(", ", args)})";
        }

        /// <summary>
        /// Generates a string representing a <c>resourceGroup()</c> function call.
        /// </summary>
        /// <returns>
        /// An object representing the object that a <c>resourceGroup()</c> function call would return.
        /// Call <see cref="ResourceGroupFunction.Invoke"/> or <c>ToString()</c> to use the function call as it is.
        /// </returns>
        public static ResourceGroupFunction ResourceGroup() => _resourceGroup;

        /// <summary>
        /// Generates a string representing a <c>subscription()</c> function call.
        /// </summary>
        /// <returns>
        /// An object representing the object that a <c>subscription()</c> function call would return.
        /// Call <see cref="SubscriptionFunction.Invoke"/> or <c>ToString()</c> to use the function call as it is.
        /// </returns>
        public static SubscriptionFunction Subscription() => _subscription;

        /// <summary>
        /// Encloses a template function call with square brackets.
        /// </summary>
        /// <param name="functionCall">Represents a template function call.</param>
        /// <returns>Function call string enclosed within square brackets.</returns>
        public static string Box(this string functionCall) => $"[{functionCall}]";

        /// <summary>
        /// Encloses a template function call with square brackets.
        /// </summary>
        /// <param name="function">Represents a template function call.</param>
        /// <returns>Function call string enclosed within square brackets.</returns>
        public static string Box(this IFunction function) => $"[{function.Invoke()}]";
    }
}
