namespace Charming.Types.DocumentDB
{
    using Charming;
    using System.Collections.Generic;

    public class DatabaseAccount : Resource<DatabaseAccount.PropertyCollection>
    {
        public DatabaseAccount() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts", "2020-03-01");

        public partial class PropertyCollection
        {
            public ConsistencyPolicyInfo ConsistencyPolicy { get; set; }
            public IList<LocationInfo> Locations { get; set; }
            public string DatabaseAccountOfferType { get; set; }
            public string IpRangeFilter { get; set; }
            public bool? IsVirtualNetworkFilterEnabled { get; set; }
            public bool? EnableAutomaticFailover { get; set; }
            public IList<CapabilityInfo> Capabilities { get; set; }
            public IList<VirtualNetworkRuleInfo> VirtualNetworkRules { get; set; }
            public bool? EnableMultipleWriteLocations { get; set; }
            public bool? EnableCassandraConnector { get; set; }
            public string ConnectorOffer { get; set; }
            public bool? DisableKeyBasedMetadataWriteAccess { get; set; }
            public string KeyVaultKeyUri { get; set; }
            public string PublicNetworkAccess { get; set; }
        }

        public partial class ConsistencyPolicyInfo
        {
            public string DefaultConsistencyLevel { get; set; }
            public int? MaxStalenessPrefix { get; set; }
            public int? MaxIntervalInSeconds { get; set; }
        }

        public partial class LocationInfo
        {
            public string LocationName { get; set; }
            public int? FailoverPriority { get; set; }
            public bool? IsZoneRedundant { get; set; }
        }

        public partial class CapabilityInfo
        {
            public string Name { get; set; }
        }

        public partial class VirtualNetworkRuleInfo
        {
            public string Id { get; set; }
            public bool? IgnoreMissingVNetServiceEndpoint { get; set; }
        }
    }
}
