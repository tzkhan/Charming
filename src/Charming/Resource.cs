namespace Charming
{
    using System.Collections.Generic;

    public abstract class Resource<TPropertyCollection> : IResource
        where TPropertyCollection : new()
    {
        public string Id { get => $"[resourceId('{Type}/', '{Name}')]"; }

        public string? Condition { get; set; }

        public string Type { get; protected set; }

        public string ApiVersion { get; protected set; }

        public string Name { get; set; }

        public Location Location { get; set; }

        public IList<IResource> DependsOn { get; } = new List<IResource>();

        public Sku Sku { get; set; }

        public string Kind { get; set; }

        public IDictionary<string, string> Tags { get; } = new Dictionary<string, string>();

        public TPropertyCollection Properties { get; set; } = new TPropertyCollection();

        public IList<IResource> Resources { get; } = new List<IResource>();
    }
}
