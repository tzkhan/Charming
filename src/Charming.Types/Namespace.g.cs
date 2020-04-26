namespace Charming.Types.ServiceBus
{
    using Charming;

    public class Namespace : Resource<Namespace.PropertyCollection>
    {
        public Namespace() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces", "2017-04-01");

        public partial class SkuInfo
        {
            public string Name { get; set; }
            public string Tier { get; set; }
            public int? Capacity { get; set; }
        }

        public partial class PropertyCollection
        {
        }
    }
}
