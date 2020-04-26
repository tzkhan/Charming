namespace Charming
{
    public class SubscriptionFunction : IFunction
    {
        private static readonly string _template = "subscription()";

        public string Id { get; } = $"{_template}.id";

        public string DisplayName { get; } = $"{_template}.displayName";

        public string SubscriptionId { get; } = $"{_template}.subscriptionId";

        public string TenantId { get; } = $"{_template}.tenantId";

        public string Invoke() => _template;

        public override string ToString() => _template;
    }
}
