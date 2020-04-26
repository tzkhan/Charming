namespace Charming
{
    using System.Collections.Generic;

    public interface IResource
    {
        string Id { get; }

        string Condition { get; set; }

        string Type { get; }

        string ApiVersion { get; }

        string Name { get; set; }

        Location Location { get; set; }

        IList<IResource> DependsOn { get; }

        Sku Sku { get; set; }

        string Kind { get; set; }

        IDictionary<string, string> Tags { get; }

        IList<IResource> Resources { get; }
    }
}
