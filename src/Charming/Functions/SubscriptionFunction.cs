namespace Charming
{
    /// <summary>
    /// Object that represents the <c>subscription()</c> function call.
    /// </summary>
    public sealed class SubscriptionFunction : IFunction
    {
        private const string _template = "subscription()";

        /// <summary>
        /// Gets the generated function call string including the <c>id</c> property.
        /// </summary>
        public string Id { get; } = $"{_template}.id";

        /// <summary>
        /// Gets the generated function call string including the <c>displayName</c> property.
        /// </summary>
        public string DisplayName { get; } = $"{_template}.displayName";

        /// <summary>
        /// Gets the generated function call string including the <c>subscriptionId</c> property.
        /// </summary>
        public string SubscriptionId { get; } = $"{_template}.subscriptionId";

        /// <summary>
        /// Gets the generated function call string including the <c>tenantId</c> property.
        /// </summary>
        public string TenantId { get; } = $"{_template}.tenantId";

        /// <summary>
        /// Generates a string representing the <c>subscription()</c> function call.
        /// </summary>
        /// <returns>A string representing the <c>subscription()</c> function call.</returns>
        public string Invoke() => _template;

        /// <summary>
        /// Generates a string representing the <c>subscription()</c> function call.
        /// </summary>
        /// <returns>A string representing the <c>subscription()</c> function call.</returns>
        public override string ToString() => _template;
    }
}
