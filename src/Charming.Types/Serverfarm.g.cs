namespace Charming.Types.Web
{
    using Charming;
    using System.Collections.Generic;

    public class Serverfarm : Resource<Serverfarm.PropertyCollection>
    {
        public Serverfarm() => (Type, ApiVersion) = ("Microsoft.Web/serverfarms", "2019-08-01");

        public partial class PropertyCollection
        {
            public string WorkerTierName { get; set; }
            public HostingEnvironmentProfileInfo HostingEnvironmentProfile { get; set; }
            public bool? PerSiteScaling { get; set; }
            public int? MaximumElasticWorkerCount { get; set; }
            public bool? IsSpot { get; set; }
            public string SpotExpirationTime { get; set; }
            public string FreeOfferExpirationTime { get; set; }
            public bool? Reserved { get; set; }
            public bool? IsXenon { get; set; }
            public bool? HyperV { get; set; }
            public int? TargetWorkerCount { get; set; }
            public int? TargetWorkerSizeId { get; set; }
        }

        public partial class HostingEnvironmentProfileInfo
        {
            public string Id { get; set; }
        }

        public partial class SkuInfo
        {
            public string Name { get; set; }
            public string Tier { get; set; }
            public string Size { get; set; }
            public string Family { get; set; }
            public int? Capacity { get; set; }
            public SkuCapacityInfo SkuCapacity { get; set; }
            public IList<string> Locations { get; set; }
            public IList<CapabilityInfo> Capabilities { get; set; }
        }

        public partial class SkuCapacityInfo
        {
            public int? Minimum { get; set; }
            public int? Maximum { get; set; }
            public int? Default { get; set; }
            public string ScaleType { get; set; }
        }

        public partial class CapabilityInfo
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public string Reason { get; set; }
        }
    }
}
