namespace Charming.Types.Storage
{
    using Charming;
    using System.Collections.Generic;

    public partial class StorageAccountBlobServiceContainerImmutabilityPolicy : Resource<StorageAccountBlobServiceContainerImmutabilityPolicyProperties>
    {
        public StorageAccountBlobServiceContainerImmutabilityPolicy() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices/containers/immutabilityPolicies", "2019-06-01");
        public StorageAccountBlobServiceContainerImmutabilityPolicy(string name) : this() => Name = name;
        public StorageAccountBlobServiceContainerImmutabilityPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountBlobServiceContainerImmutabilityPolicyProperties
    {
        public int? ImmutabilityPeriodSinceCreationInDays { get; set; }
        public bool? AllowProtectedAppendWrites { get; set; }
    }

    public partial class StorageAccountBlobServiceContainer : Resource<StorageAccountBlobServiceContainerProperties>
    {
        public StorageAccountBlobServiceContainer() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices/containers", "2019-06-01");
        public StorageAccountBlobServiceContainer(string name) : this() => Name = name;
        public StorageAccountBlobServiceContainer(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountBlobServiceContainerProperties
    {
        public string PublicAccess { get; set; }
        public object Metadata { get; set; }
    }

    public partial class StorageAccountBlobService : Resource<StorageAccountBlobServiceProperties>
    {
        public StorageAccountBlobService() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices", "2019-06-01");
        public StorageAccountBlobService(string name) : this() => Name = name;
        public StorageAccountBlobService(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountBlobServiceProperties
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

    public partial class StorageAccountEncryptionScope : Resource<StorageAccountEncryptionScopeProperties>
    {
        public StorageAccountEncryptionScope() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/encryptionScopes", "2019-06-01");
        public StorageAccountEncryptionScope(string name) : this() => Name = name;
        public StorageAccountEncryptionScope(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountEncryptionScopeProperties
    {
        public string Source { get; set; }
        public string State { get; set; }
        public KeyVaultPropertiesInfo KeyVaultProperties { get; set; }
    }

    public partial class KeyVaultPropertiesInfo
    {
        public string KeyUri { get; set; }
    }

    public partial class StorageAccountFileServiceShare : Resource<StorageAccountFileServiceShareProperties>
    {
        public StorageAccountFileServiceShare() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/fileServices/shares", "2019-06-01");
        public StorageAccountFileServiceShare(string name) : this() => Name = name;
        public StorageAccountFileServiceShare(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountFileServiceShareProperties
    {
        public object Metadata { get; set; }
        public int? ShareQuota { get; set; }
    }

    public partial class StorageAccountFileService : Resource<StorageAccountFileServiceProperties>
    {
        public StorageAccountFileService() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/fileServices", "2019-06-01");
        public StorageAccountFileService(string name) : this() => Name = name;
        public StorageAccountFileService(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountFileServiceProperties
    {
        public CorsInfo Cors { get; set; }
        public ShareDeleteRetentionPolicyInfo ShareDeleteRetentionPolicy { get; set; }
    }

    public partial class ShareDeleteRetentionPolicyInfo
    {
        public bool? Enabled { get; set; }
        public int? Days { get; set; }
    }

    public partial class StorageAccountManagementPolicy : Resource<StorageAccountManagementPolicyProperties>
    {
        public StorageAccountManagementPolicy() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/managementPolicies", "2019-06-01");
        public StorageAccountManagementPolicy(string name) : this() => Name = name;
        public StorageAccountManagementPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountManagementPolicyProperties
    {
        public PolicyInfo Policy { get; set; }
    }

    public partial class PolicyInfo
    {
        public IList<RuleInfo> Rules { get; set; }
    }

    public partial class RuleInfo
    {
        public bool? Enabled { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DefinitionInfo Definition { get; set; }
    }

    public partial class DefinitionInfo
    {
        public ActionsInfo Actions { get; set; }
        public FiltersInfo Filters { get; set; }
    }

    public partial class ActionsInfo
    {
        public BaseBlobInfo BaseBlob { get; set; }
        public SnapshotInfo Snapshot { get; set; }
    }

    public partial class BaseBlobInfo
    {
        public TierToCoolInfo TierToCool { get; set; }
        public TierToArchiveInfo TierToArchive { get; set; }
        public DeleteInfo Delete { get; set; }
    }

    public partial class TierToCoolInfo
    {
        public string DaysAfterModificationGreaterThan { get; set; }
    }

    public partial class TierToArchiveInfo
    {
        public string DaysAfterModificationGreaterThan { get; set; }
    }

    public partial class DeleteInfo
    {
        public string DaysAfterModificationGreaterThan { get; set; }
    }

    public partial class SnapshotInfo
    {
        public SnapshotDeleteInfo Delete { get; set; }
    }

    public partial class SnapshotDeleteInfo
    {
        public string DaysAfterCreationGreaterThan { get; set; }
    }

    public partial class FiltersInfo
    {
        public IList<string> PrefixMatch { get; set; }
        public IList<string> BlobTypes { get; set; }
    }

    public partial class StorageAccountPrivateEndpointConnection : Resource<StorageAccountPrivateEndpointConnectionProperties>
    {
        public StorageAccountPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/privateEndpointConnections", "2019-06-01");
        public StorageAccountPrivateEndpointConnection(string name) : this() => Name = name;
        public StorageAccountPrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class StorageAccountPrivateEndpointConnectionProperties
    {
        public object PrivateEndpoint { get; set; }
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState { get; set; }
    }

    public partial class PrivateLinkServiceConnectionStateInfo
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public string ActionRequired { get; set; }
    }

    public partial class StorageAccount : Resource<StorageAccountProperties>
    {
        public StorageAccount() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts", "2019-06-01");
        public StorageAccount(string name) : this() => Name = name;
        public StorageAccount(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class IdentityInfo
    {
        public string Type { get; set; }
    }

    public partial class StorageAccountProperties
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
