namespace Charming.Types.ServiceBus
{
    using Charming;

    public class NamespaceTopic : Resource<NamespaceTopic.PropertyCollection>
    {
        public NamespaceTopic() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics", "2017-04-01");

        public partial class PropertyCollection
        {
            public string DefaultMessageTimeToLive { get; set; }
            public int? MaxSizeInMegabytes { get; set; }
            public bool? RequiresDuplicateDetection { get; set; }
            public string DuplicateDetectionHistoryTimeWindow { get; set; }
            public bool? EnableBatchedOperations { get; set; }
            public string Status { get; set; }
            public bool? SupportOrdering { get; set; }
            public string AutoDeleteOnIdle { get; set; }
            public bool? EnablePartitioning { get; set; }
            public bool? EnableExpress { get; set; }
        }
    }
}
