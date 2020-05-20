namespace Charming.Types.Storage
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class StorageAccountBlobServiceContainerImmutabilityPolicy : Resource<StorageAccountBlobServiceContainerImmutabilityPolicyProperties>
    {
        public StorageAccountBlobServiceContainerImmutabilityPolicy() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices/containers/immutabilityPolicies", "2019-06-01");
        public StorageAccountBlobServiceContainerImmutabilityPolicy(string name) : this() => Name = name;
        public StorageAccountBlobServiceContainerImmutabilityPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountBlobServiceContainerImmutabilityPolicy WithProperties(Action<StorageAccountBlobServiceContainerImmutabilityPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountBlobServiceContainerImmutabilityPolicyProperties : PropertyBase
    {

        public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

        public bool? AllowProtectedAppendWrites { get; set; }
    }

    public class StorageAccountBlobServiceContainer : Resource<StorageAccountBlobServiceContainerProperties>
    {
        public StorageAccountBlobServiceContainer() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices/containers", "2019-06-01");
        public StorageAccountBlobServiceContainer(string name) : this() => Name = name;
        public StorageAccountBlobServiceContainer(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountBlobServiceContainer WithProperties(Action<StorageAccountBlobServiceContainerProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountBlobServiceContainerProperties : PropertyBase
    {

        public string PublicAccess { get; set; }

        public object Metadata { get; set; }
    }

    public class StorageAccountBlobService : Resource<StorageAccountBlobServiceProperties>
    {
        public StorageAccountBlobService() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices", "2019-06-01");
        public StorageAccountBlobService(string name) : this() => Name = name;
        public StorageAccountBlobService(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountBlobService WithProperties(Action<StorageAccountBlobServiceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountBlobServiceProperties : PropertyBase
    {

        private CorsInfo _cors;
        public CorsInfo Cors
        {
            get => _cors = Get(_cors);
            set => _cors = value;
        }

        public string DefaultServiceVersion { get; set; }

        private DeleteRetentionPolicyInfo _deleteRetentionPolicy;
        public DeleteRetentionPolicyInfo DeleteRetentionPolicy
        {
            get => _deleteRetentionPolicy = Get(_deleteRetentionPolicy);
            set => _deleteRetentionPolicy = value;
        }

        public bool? IsVersioningEnabled { get; set; }

        public bool? AutomaticSnapshotPolicyEnabled { get; set; }

        private ChangeFeedInfo _changeFeed;
        public ChangeFeedInfo ChangeFeed
        {
            get => _changeFeed = Get(_changeFeed);
            set => _changeFeed = value;
        }

        private RestorePolicyInfo _restorePolicy;
        public RestorePolicyInfo RestorePolicy
        {
            get => _restorePolicy = Get(_restorePolicy);
            set => _restorePolicy = value;
        }

        private ContainerDeleteRetentionPolicyInfo _containerDeleteRetentionPolicy;
        public ContainerDeleteRetentionPolicyInfo ContainerDeleteRetentionPolicy
        {
            get => _containerDeleteRetentionPolicy = Get(_containerDeleteRetentionPolicy);
            set => _containerDeleteRetentionPolicy = value;
        }
    }

    public class CorsInfo : PropertyBase
    {

        public IList<CorsRuleInfo> CorsRules { get; set; }
    }

    public class CorsRuleInfo : PropertyBase
    {

        public IList<string> AllowedOrigins { get; set; }

        public IList<string> AllowedMethods { get; set; }

        public int? MaxAgeInSeconds { get; set; }

        public IList<string> ExposedHeaders { get; set; }

        public IList<string> AllowedHeaders { get; set; }
    }

    public class DeleteRetentionPolicyInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public int? Days { get; set; }
    }

    public class ChangeFeedInfo : PropertyBase
    {

        public bool? Enabled { get; set; }
    }

    public class RestorePolicyInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public int? Days { get; set; }
    }

    public class ContainerDeleteRetentionPolicyInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public int? Days { get; set; }
    }

    public class StorageAccountEncryptionScope : Resource<StorageAccountEncryptionScopeProperties>
    {
        public StorageAccountEncryptionScope() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/encryptionScopes", "2019-06-01");
        public StorageAccountEncryptionScope(string name) : this() => Name = name;
        public StorageAccountEncryptionScope(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountEncryptionScope WithProperties(Action<StorageAccountEncryptionScopeProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountEncryptionScopeProperties : PropertyBase
    {

        public string Source { get; set; }

        public string State { get; set; }

        private KeyVaultPropertiesInfo _keyVaultProperties;
        public KeyVaultPropertiesInfo KeyVaultProperties
        {
            get => _keyVaultProperties = Get(_keyVaultProperties);
            set => _keyVaultProperties = value;
        }
    }

    public class KeyVaultPropertiesInfo : PropertyBase
    {

        public string KeyUri { get; set; }
    }

    public class StorageAccountFileServiceShare : Resource<StorageAccountFileServiceShareProperties>
    {
        public StorageAccountFileServiceShare() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/fileServices/shares", "2019-06-01");
        public StorageAccountFileServiceShare(string name) : this() => Name = name;
        public StorageAccountFileServiceShare(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountFileServiceShare WithProperties(Action<StorageAccountFileServiceShareProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountFileServiceShareProperties : PropertyBase
    {

        public object Metadata { get; set; }

        public int? ShareQuota { get; set; }
    }

    public class StorageAccountFileService : Resource<StorageAccountFileServiceProperties>
    {
        public StorageAccountFileService() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/fileServices", "2019-06-01");
        public StorageAccountFileService(string name) : this() => Name = name;
        public StorageAccountFileService(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountFileService WithProperties(Action<StorageAccountFileServiceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountFileServiceProperties : PropertyBase
    {

        private CorsInfo _cors;
        public CorsInfo Cors
        {
            get => _cors = Get(_cors);
            set => _cors = value;
        }

        private ShareDeleteRetentionPolicyInfo _shareDeleteRetentionPolicy;
        public ShareDeleteRetentionPolicyInfo ShareDeleteRetentionPolicy
        {
            get => _shareDeleteRetentionPolicy = Get(_shareDeleteRetentionPolicy);
            set => _shareDeleteRetentionPolicy = value;
        }
    }

    public class ShareDeleteRetentionPolicyInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public int? Days { get; set; }
    }

    public class StorageAccountManagementPolicy : Resource<StorageAccountManagementPolicyProperties>
    {
        public StorageAccountManagementPolicy() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/managementPolicies", "2019-06-01");
        public StorageAccountManagementPolicy(string name) : this() => Name = name;
        public StorageAccountManagementPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountManagementPolicy WithProperties(Action<StorageAccountManagementPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountManagementPolicyProperties : PropertyBase
    {

        private PolicyInfo _policy;
        public PolicyInfo Policy
        {
            get => _policy = Get(_policy);
            set => _policy = value;
        }
    }

    public class PolicyInfo : PropertyBase
    {

        public IList<RuleInfo> Rules { get; set; }
    }

    public class RuleInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        private DefinitionInfo _definition;
        public DefinitionInfo Definition
        {
            get => _definition = Get(_definition);
            set => _definition = value;
        }
    }

    public class DefinitionInfo : PropertyBase
    {

        private ActionsInfo _actions;
        public ActionsInfo Actions
        {
            get => _actions = Get(_actions);
            set => _actions = value;
        }

        private FiltersInfo _filters;
        public FiltersInfo Filters
        {
            get => _filters = Get(_filters);
            set => _filters = value;
        }
    }

    public class ActionsInfo : PropertyBase
    {

        private BaseBlobInfo _baseBlob;
        public BaseBlobInfo BaseBlob
        {
            get => _baseBlob = Get(_baseBlob);
            set => _baseBlob = value;
        }

        private SnapshotInfo _snapshot;
        public SnapshotInfo Snapshot
        {
            get => _snapshot = Get(_snapshot);
            set => _snapshot = value;
        }
    }

    public class BaseBlobInfo : PropertyBase
    {

        private TierToCoolInfo _tierToCool;
        public TierToCoolInfo TierToCool
        {
            get => _tierToCool = Get(_tierToCool);
            set => _tierToCool = value;
        }

        private TierToArchiveInfo _tierToArchive;
        public TierToArchiveInfo TierToArchive
        {
            get => _tierToArchive = Get(_tierToArchive);
            set => _tierToArchive = value;
        }

        private DeleteInfo _delete;
        public DeleteInfo Delete
        {
            get => _delete = Get(_delete);
            set => _delete = value;
        }
    }

    public class TierToCoolInfo : PropertyBase
    {

        public string DaysAfterModificationGreaterThan { get; set; }
    }

    public class TierToArchiveInfo : PropertyBase
    {

        public string DaysAfterModificationGreaterThan { get; set; }
    }

    public class DeleteInfo : PropertyBase
    {

        public string DaysAfterModificationGreaterThan { get; set; }
    }

    public class SnapshotInfo : PropertyBase
    {

        private SnapshotDeleteInfo _delete;
        public SnapshotDeleteInfo Delete
        {
            get => _delete = Get(_delete);
            set => _delete = value;
        }
    }

    public class SnapshotDeleteInfo : PropertyBase
    {

        public string DaysAfterCreationGreaterThan { get; set; }
    }

    public class FiltersInfo : PropertyBase
    {

        public IList<string> PrefixMatch { get; set; }

        public IList<string> BlobTypes { get; set; }
    }

    public class StorageAccountPrivateEndpointConnection : Resource<StorageAccountPrivateEndpointConnectionProperties>
    {
        public StorageAccountPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/privateEndpointConnections", "2019-06-01");
        public StorageAccountPrivateEndpointConnection(string name) : this() => Name = name;
        public StorageAccountPrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public StorageAccountPrivateEndpointConnection WithProperties(Action<StorageAccountPrivateEndpointConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class StorageAccountPrivateEndpointConnectionProperties : PropertyBase
    {

        public object PrivateEndpoint { get; set; }

        private PrivateLinkServiceConnectionStateInfo _privateLinkServiceConnectionState;
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState
        {
            get => _privateLinkServiceConnectionState = Get(_privateLinkServiceConnectionState);
            set => _privateLinkServiceConnectionState = value;
        }
    }

    public class PrivateLinkServiceConnectionStateInfo : PropertyBase
    {

        public string Status { get; set; }

        public string Description { get; set; }

        public string ActionRequired { get; set; }
    }

    public class StorageAccount : Resource<StorageAccountProperties>
    {
        public StorageAccount() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts", "2019-06-01");
        public StorageAccount(string name) : this() => Name = name;
        public StorageAccount(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public StorageAccount WithProperties(Action<StorageAccountProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }
    }

    public class StorageAccountProperties : PropertyBase
    {

        private CustomDomainInfo _customDomain;
        public CustomDomainInfo CustomDomain
        {
            get => _customDomain = Get(_customDomain);
            set => _customDomain = value;
        }

        private EncryptionInfo _encryption;
        public EncryptionInfo Encryption
        {
            get => _encryption = Get(_encryption);
            set => _encryption = value;
        }

        private NetworkAclsInfo _networkAcls;
        public NetworkAclsInfo NetworkAcls
        {
            get => _networkAcls = Get(_networkAcls);
            set => _networkAcls = value;
        }

        public string AccessTier { get; set; }

        private AzureFilesIdentityBasedAuthenticationInfo _azureFilesIdentityBasedAuthentication;
        public AzureFilesIdentityBasedAuthenticationInfo AzureFilesIdentityBasedAuthentication
        {
            get => _azureFilesIdentityBasedAuthentication = Get(_azureFilesIdentityBasedAuthentication);
            set => _azureFilesIdentityBasedAuthentication = value;
        }

        public bool? SupportsHttpsTrafficOnly { get; set; }

        public bool? IsHnsEnabled { get; set; }

        public string LargeFileSharesState { get; set; }

        private RoutingPreferenceInfo _routingPreference;
        public RoutingPreferenceInfo RoutingPreference
        {
            get => _routingPreference = Get(_routingPreference);
            set => _routingPreference = value;
        }
    }

    public class CustomDomainInfo : PropertyBase
    {

        public string Name { get; set; }

        public bool? UseSubDomainName { get; set; }
    }

    public class EncryptionInfo : PropertyBase
    {

        private ServicesInfo _services;
        public ServicesInfo Services
        {
            get => _services = Get(_services);
            set => _services = value;
        }

        public string KeySource { get; set; }

        private KeyvaultpropertiesInfo _keyvaultproperties;
        public KeyvaultpropertiesInfo Keyvaultproperties
        {
            get => _keyvaultproperties = Get(_keyvaultproperties);
            set => _keyvaultproperties = value;
        }
    }

    public class ServicesInfo : PropertyBase
    {

        private BlobInfo _blob;
        public BlobInfo Blob
        {
            get => _blob = Get(_blob);
            set => _blob = value;
        }

        private FileInfo _file;
        public FileInfo File
        {
            get => _file = Get(_file);
            set => _file = value;
        }

        private TableInfo _table;
        public TableInfo Table
        {
            get => _table = Get(_table);
            set => _table = value;
        }

        private QueueInfo _queue;
        public QueueInfo Queue
        {
            get => _queue = Get(_queue);
            set => _queue = value;
        }
    }

    public class BlobInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string KeyType { get; set; }
    }

    public class FileInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string KeyType { get; set; }
    }

    public class TableInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string KeyType { get; set; }
    }

    public class QueueInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string KeyType { get; set; }
    }

    public class KeyvaultpropertiesInfo : PropertyBase
    {

        public string Keyname { get; set; }

        public string Keyversion { get; set; }

        public string Keyvaulturi { get; set; }
    }

    public class NetworkAclsInfo : PropertyBase
    {

        public string Bypass { get; set; }

        public IList<VirtualNetworkRuleInfo> VirtualNetworkRules { get; set; }

        public IList<IpRuleInfo> IpRules { get; set; }

        public string DefaultAction { get; set; }
    }

    public class VirtualNetworkRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Action { get; set; }

        public string State { get; set; }
    }

    public class IpRuleInfo : PropertyBase
    {

        public string Value { get; set; }

        public string Action { get; set; }
    }

    public class AzureFilesIdentityBasedAuthenticationInfo : PropertyBase
    {

        public string DirectoryServiceOptions { get; set; }

        private ActiveDirectoryPropertiesInfo _activeDirectoryProperties;
        public ActiveDirectoryPropertiesInfo ActiveDirectoryProperties
        {
            get => _activeDirectoryProperties = Get(_activeDirectoryProperties);
            set => _activeDirectoryProperties = value;
        }
    }

    public class ActiveDirectoryPropertiesInfo : PropertyBase
    {

        public string DomainName { get; set; }

        public string NetBiosDomainName { get; set; }

        public string ForestName { get; set; }

        public string DomainGuid { get; set; }

        public string DomainSid { get; set; }

        public string AzureStorageSid { get; set; }
    }

    public class RoutingPreferenceInfo : PropertyBase
    {

        public string RoutingChoice { get; set; }

        public bool? PublishMicrosoftEndpoints { get; set; }

        public bool? PublishInternetEndpoints { get; set; }
    }
}
