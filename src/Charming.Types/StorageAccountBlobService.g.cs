namespace Charming.Types.Storage
{
    using Charming;
    using System.Collections.Generic;

    public class StorageAccountBlobService : Resource<StorageAccountBlobService.PropertyCollection>
    {
        public StorageAccountBlobService() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices", "2019-06-01");

        public partial class PropertyCollection
        {
            public CorsInfo Cors { get; set; }
            public string DefaultServiceVersion { get; set; }
            public DeleteRetentionPolicyInfo DeleteRetentionPolicy { get; set; }
            public bool? IsVersioningEnabled { get; set; }
            public bool? AutomaticSnapshotPolicyEnabled { get; set; }
            public ChangeFeedInfo ChangeFeed { get; set; }
            public RestorePolicyInfo RestorePolicy { get; set; }
            public ContainerDeleteRetentionPolicyInfo ContainerDeleteRetentionPolicy { get; set; }
        }

        public partial class CorsInfo
        {
            public IList<CorsRuleInfo> CorsRules { get; set; }
        }

        public partial class CorsRuleInfo
        {
            public IList<string> AllowedOrigins { get; set; }
            public IList<string> AllowedMethods { get; set; }
            public int? MaxAgeInSeconds { get; set; }
            public IList<string> ExposedHeaders { get; set; }
            public IList<string> AllowedHeaders { get; set; }
        }

        public partial class DeleteRetentionPolicyInfo
        {
            public bool? Enabled { get; set; }
            public int? Days { get; set; }
        }

        public partial class ChangeFeedInfo
        {
            public bool? Enabled { get; set; }
        }

        public partial class RestorePolicyInfo
        {
            public bool? Enabled { get; set; }
            public int? Days { get; set; }
        }

        public partial class ContainerDeleteRetentionPolicyInfo
        {
            public bool? Enabled { get; set; }
            public int? Days { get; set; }
        }
    }
}
