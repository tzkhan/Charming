namespace Charming.Types.Storage
{
    using Charming;
    using System.Collections.Generic;

    public class StorageAccount : Resource<StorageAccount.PropertyCollection>
    {
        public StorageAccount() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts", "2019-06-01");

        public IdentityInfo Identity { get; set; }

        public partial class SkuInfo
        {
            public string Name { get; set; }
            public string Tier { get; set; }
        }

        public partial class IdentityInfo
        {
            public string Type { get; set; }
        }

        public partial class PropertyCollection
        {
            public CustomDomainInfo CustomDomain { get; set; }
            public EncryptionInfo Encryption { get; set; }
            public NetworkAclsInfo NetworkAcls { get; set; }
            public string AccessTier { get; set; }
            public AzureFilesIdentityBasedAuthenticationInfo AzureFilesIdentityBasedAuthentication { get; set; }
            public bool? SupportsHttpsTrafficOnly { get; set; }
            public bool? IsHnsEnabled { get; set; }
            public string LargeFileSharesState { get; set; }
            public RoutingPreferenceInfo RoutingPreference { get; set; }
        }

        public partial class CustomDomainInfo
        {
            public string Name { get; set; }
            public bool? UseSubDomainName { get; set; }
        }

        public partial class EncryptionInfo
        {
            public ServicesInfo Services { get; set; }
            public string KeySource { get; set; }
            public KeyvaultpropertiesInfo Keyvaultproperties { get; set; }
        }

        public partial class ServicesInfo
        {
            public BlobInfo Blob { get; set; }
            public FileInfo File { get; set; }
            public TableInfo Table { get; set; }
            public QueueInfo Queue { get; set; }
        }

        public partial class BlobInfo
        {
            public bool? Enabled { get; set; }
            public string KeyType { get; set; }
        }

        public partial class FileInfo
        {
            public bool? Enabled { get; set; }
            public string KeyType { get; set; }
        }

        public partial class TableInfo
        {
            public bool? Enabled { get; set; }
            public string KeyType { get; set; }
        }

        public partial class QueueInfo
        {
            public bool? Enabled { get; set; }
            public string KeyType { get; set; }
        }

        public partial class KeyvaultpropertiesInfo
        {
            public string Keyname { get; set; }
            public string Keyversion { get; set; }
            public string Keyvaulturi { get; set; }
        }

        public partial class NetworkAclsInfo
        {
            public string Bypass { get; set; }
            public IList<VirtualNetworkRuleInfo> VirtualNetworkRules { get; set; }
            public IList<IpRuleInfo> IpRules { get; set; }
            public string DefaultAction { get; set; }
        }

        public partial class VirtualNetworkRuleInfo
        {
            public string Id { get; set; }
            public string Action { get; set; }
            public string State { get; set; }
        }

        public partial class IpRuleInfo
        {
            public string Value { get; set; }
            public string Action { get; set; }
        }

        public partial class AzureFilesIdentityBasedAuthenticationInfo
        {
            public string DirectoryServiceOptions { get; set; }
            public ActiveDirectoryPropertiesInfo ActiveDirectoryProperties { get; set; }
        }

        public partial class ActiveDirectoryPropertiesInfo
        {
            public string DomainName { get; set; }
            public string NetBiosDomainName { get; set; }
            public string ForestName { get; set; }
            public string DomainGuid { get; set; }
            public string DomainSid { get; set; }
            public string AzureStorageSid { get; set; }
        }

        public partial class RoutingPreferenceInfo
        {
            public string RoutingChoice { get; set; }
            public bool? PublishMicrosoftEndpoints { get; set; }
            public bool? PublishInternetEndpoints { get; set; }
        }
    }
}
