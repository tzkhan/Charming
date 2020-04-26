namespace Charming
{
    public class ResourceGroupFunction : IFunction
    {
        private static readonly string _template = "resourceGroup()";

        public string Id { get; } = $"{_template}.id";

        public string Name { get; } = $"{_template}.name";

        public string Type { get; } = $"{_template}.type";

        public string Location { get; } = $"{_template}.location";

        public string ManagedBy { get; } = $"{_template}.managedBy";

        public string Tags { get; } = $"{_template}.tags";

        public string Invoke() => _template;

        public override string ToString() => _template;
    }
}
