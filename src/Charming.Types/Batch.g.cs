namespace Charming.Types.Batch
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class BatchAccountApplicationVersion : Resource<BatchAccountApplicationVersionProperties>
    {
        public BatchAccountApplicationVersion() => (Type, ApiVersion) = ("Microsoft.Batch/batchAccounts/applications/versions", "2020-03-01");
        public BatchAccountApplicationVersion(string name) : this() => Name = name;
        public BatchAccountApplicationVersion(string name, Location location) : this() => (Name, Location) = (name, location);

        public BatchAccountApplicationVersion WithProperties(Action<BatchAccountApplicationVersionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BatchAccountApplicationVersionProperties : PropertyBase
    {
    }

    public class BatchAccountApplication : Resource<BatchAccountApplicationProperties>
    {
        public BatchAccountApplication() => (Type, ApiVersion) = ("Microsoft.Batch/batchAccounts/applications", "2020-03-01");
        public BatchAccountApplication(string name) : this() => Name = name;
        public BatchAccountApplication(string name, Location location) : this() => (Name, Location) = (name, location);

        public BatchAccountApplication WithProperties(Action<BatchAccountApplicationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BatchAccountApplicationProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public bool? AllowUpdates { get; set; }

        public string DefaultVersion { get; set; }
    }

    public class BatchAccountCertificate : Resource<BatchAccountCertificateProperties>
    {
        public BatchAccountCertificate() => (Type, ApiVersion) = ("Microsoft.Batch/batchAccounts/certificates", "2020-03-01");
        public BatchAccountCertificate(string name) : this() => Name = name;
        public BatchAccountCertificate(string name, Location location) : this() => (Name, Location) = (name, location);

        public BatchAccountCertificate WithProperties(Action<BatchAccountCertificateProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BatchAccountCertificateProperties : PropertyBase
    {

        public string ThumbprintAlgorithm { get; set; }

        public string Thumbprint { get; set; }

        public string Format { get; set; }

        public string Data { get; set; }

        public string Password { get; set; }
    }

    public class BatchAccountPool : Resource<BatchAccountPoolProperties>
    {
        public BatchAccountPool() => (Type, ApiVersion) = ("Microsoft.Batch/batchAccounts/pools", "2020-03-01");
        public BatchAccountPool(string name) : this() => Name = name;
        public BatchAccountPool(string name, Location location) : this() => (Name, Location) = (name, location);

        public BatchAccountPool WithProperties(Action<BatchAccountPoolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BatchAccountPoolProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public string VmSize { get; set; }

        private DeploymentConfigurationInfo _deploymentConfiguration;
        public DeploymentConfigurationInfo DeploymentConfiguration
        {
            get => _deploymentConfiguration = Get(_deploymentConfiguration);
            set => _deploymentConfiguration = value;
        }

        private ScaleSettingsInfo _scaleSettings;
        public ScaleSettingsInfo ScaleSettings
        {
            get => _scaleSettings = Get(_scaleSettings);
            set => _scaleSettings = value;
        }

        public string InterNodeCommunication { get; set; }

        private NetworkConfigurationInfo _networkConfiguration;
        public NetworkConfigurationInfo NetworkConfiguration
        {
            get => _networkConfiguration = Get(_networkConfiguration);
            set => _networkConfiguration = value;
        }

        public int? MaxTasksPerNode { get; set; }

        private TaskSchedulingPolicyInfo _taskSchedulingPolicy;
        public TaskSchedulingPolicyInfo TaskSchedulingPolicy
        {
            get => _taskSchedulingPolicy = Get(_taskSchedulingPolicy);
            set => _taskSchedulingPolicy = value;
        }

        public IList<UserAccountInfo> UserAccounts { get; set; }

        public IList<MetadataInfo> Metadata { get; set; }

        private StartTaskInfo _startTask;
        public StartTaskInfo StartTask
        {
            get => _startTask = Get(_startTask);
            set => _startTask = value;
        }

        public IList<CertificateInfo> Certificates { get; set; }

        public IList<ApplicationPackageInfo> ApplicationPackages { get; set; }

        public IList<string> ApplicationLicenses { get; set; }

        public IList<MountConfigurationInfo> MountConfiguration { get; set; }
    }

    public class DeploymentConfigurationInfo : PropertyBase
    {

        private CloudServiceConfigurationInfo _cloudServiceConfiguration;
        public CloudServiceConfigurationInfo CloudServiceConfiguration
        {
            get => _cloudServiceConfiguration = Get(_cloudServiceConfiguration);
            set => _cloudServiceConfiguration = value;
        }

        private VirtualMachineConfigurationInfo _virtualMachineConfiguration;
        public VirtualMachineConfigurationInfo VirtualMachineConfiguration
        {
            get => _virtualMachineConfiguration = Get(_virtualMachineConfiguration);
            set => _virtualMachineConfiguration = value;
        }
    }

    public class CloudServiceConfigurationInfo : PropertyBase
    {

        public string OsFamily { get; set; }

        public string OsVersion { get; set; }
    }

    public class VirtualMachineConfigurationInfo : PropertyBase
    {

        private ImageReferenceInfo _imageReference;
        public ImageReferenceInfo ImageReference
        {
            get => _imageReference = Get(_imageReference);
            set => _imageReference = value;
        }

        public string NodeAgentSkuId { get; set; }

        private WindowsConfigurationInfo _windowsConfiguration;
        public WindowsConfigurationInfo WindowsConfiguration
        {
            get => _windowsConfiguration = Get(_windowsConfiguration);
            set => _windowsConfiguration = value;
        }

        public IList<DataDiskInfo> DataDisks { get; set; }

        public string LicenseType { get; set; }

        private ContainerConfigurationInfo _containerConfiguration;
        public ContainerConfigurationInfo ContainerConfiguration
        {
            get => _containerConfiguration = Get(_containerConfiguration);
            set => _containerConfiguration = value;
        }

        private DiskEncryptionConfigurationInfo _diskEncryptionConfiguration;
        public DiskEncryptionConfigurationInfo DiskEncryptionConfiguration
        {
            get => _diskEncryptionConfiguration = Get(_diskEncryptionConfiguration);
            set => _diskEncryptionConfiguration = value;
        }
    }

    public class ImageReferenceInfo : PropertyBase
    {

        public string Publisher { get; set; }

        public string Offer { get; set; }

        public string Sku { get; set; }

        public string Version { get; set; }

        public string Id { get; set; }
    }

    public class WindowsConfigurationInfo : PropertyBase
    {

        public bool? EnableAutomaticUpdates { get; set; }
    }

    public class DataDiskInfo : PropertyBase
    {

        public int? Lun { get; set; }

        public string Caching { get; set; }

        public int? DiskSizeGB { get; set; }

        public string StorageAccountType { get; set; }
    }

    public class ContainerConfigurationInfo : PropertyBase
    {

        public string Type { get; set; }

        public IList<string> ContainerImageNames { get; set; }

        public IList<ContainerRegistryInfo> ContainerRegistries { get; set; }
    }

    public class ContainerRegistryInfo : PropertyBase
    {

        public string RegistryServer { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }

    public class DiskEncryptionConfigurationInfo : PropertyBase
    {

        public IList<string> Targets { get; set; }
    }

    public class ScaleSettingsInfo : PropertyBase
    {

        private FixedScaleInfo _fixedScale;
        public FixedScaleInfo FixedScale
        {
            get => _fixedScale = Get(_fixedScale);
            set => _fixedScale = value;
        }

        private AutoScaleInfo _autoScale;
        public AutoScaleInfo AutoScale
        {
            get => _autoScale = Get(_autoScale);
            set => _autoScale = value;
        }
    }

    public class FixedScaleInfo : PropertyBase
    {

        public string ResizeTimeout { get; set; }

        public int? TargetDedicatedNodes { get; set; }

        public int? TargetLowPriorityNodes { get; set; }

        public string NodeDeallocationOption { get; set; }
    }

    public class AutoScaleInfo : PropertyBase
    {

        public string Formula { get; set; }

        public string EvaluationInterval { get; set; }
    }

    public class NetworkConfigurationInfo : PropertyBase
    {

        public string SubnetId { get; set; }

        private EndpointConfigurationInfo _endpointConfiguration;
        public EndpointConfigurationInfo EndpointConfiguration
        {
            get => _endpointConfiguration = Get(_endpointConfiguration);
            set => _endpointConfiguration = value;
        }

        private PublicIPAddressConfigurationInfo _publicIPAddressConfiguration;
        public PublicIPAddressConfigurationInfo PublicIPAddressConfiguration
        {
            get => _publicIPAddressConfiguration = Get(_publicIPAddressConfiguration);
            set => _publicIPAddressConfiguration = value;
        }
    }

    public class EndpointConfigurationInfo : PropertyBase
    {

        public IList<InboundNatPoolInfo> InboundNatPools { get; set; }
    }

    public class InboundNatPoolInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Protocol { get; set; }

        public int? BackendPort { get; set; }

        public int? FrontendPortRangeStart { get; set; }

        public int? FrontendPortRangeEnd { get; set; }

        public IList<NetworkSecurityGroupRuleInfo> NetworkSecurityGroupRules { get; set; }
    }

    public class NetworkSecurityGroupRuleInfo : PropertyBase
    {

        public int? Priority { get; set; }

        public string Access { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourcePortRanges { get; set; }
    }

    public class PublicIPAddressConfigurationInfo : PropertyBase
    {

        public string Provision { get; set; }

        public IList<string> IpAddressIds { get; set; }
    }

    public class TaskSchedulingPolicyInfo : PropertyBase
    {

        public string NodeFillType { get; set; }
    }

    public class UserAccountInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Password { get; set; }

        public string ElevationLevel { get; set; }

        private LinuxUserConfigurationInfo _linuxUserConfiguration;
        public LinuxUserConfigurationInfo LinuxUserConfiguration
        {
            get => _linuxUserConfiguration = Get(_linuxUserConfiguration);
            set => _linuxUserConfiguration = value;
        }

        private WindowsUserConfigurationInfo _windowsUserConfiguration;
        public WindowsUserConfigurationInfo WindowsUserConfiguration
        {
            get => _windowsUserConfiguration = Get(_windowsUserConfiguration);
            set => _windowsUserConfiguration = value;
        }
    }

    public class LinuxUserConfigurationInfo : PropertyBase
    {

        public int? Uid { get; set; }

        public int? Gid { get; set; }

        public string SshPrivateKey { get; set; }
    }

    public class WindowsUserConfigurationInfo : PropertyBase
    {

        public string LoginMode { get; set; }
    }

    public class MetadataInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }
    }

    public class StartTaskInfo : PropertyBase
    {

        public string CommandLine { get; set; }

        public IList<ResourceFileInfo> ResourceFiles { get; set; }

        public IList<EnvironmentSettingInfo> EnvironmentSettings { get; set; }

        private UserIdentityInfo _userIdentity;
        public UserIdentityInfo UserIdentity
        {
            get => _userIdentity = Get(_userIdentity);
            set => _userIdentity = value;
        }

        public int? MaxTaskRetryCount { get; set; }

        public bool? WaitForSuccess { get; set; }

        private ContainerSettingsInfo _containerSettings;
        public ContainerSettingsInfo ContainerSettings
        {
            get => _containerSettings = Get(_containerSettings);
            set => _containerSettings = value;
        }
    }

    public class ResourceFileInfo : PropertyBase
    {

        public string AutoStorageContainerName { get; set; }

        public string StorageContainerUrl { get; set; }

        public string HttpUrl { get; set; }

        public string BlobPrefix { get; set; }

        public string FilePath { get; set; }

        public string FileMode { get; set; }
    }

    public class EnvironmentSettingInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }
    }

    public class UserIdentityInfo : PropertyBase
    {

        public string UserName { get; set; }

        private AutoUserInfo _autoUser;
        public AutoUserInfo AutoUser
        {
            get => _autoUser = Get(_autoUser);
            set => _autoUser = value;
        }
    }

    public class AutoUserInfo : PropertyBase
    {

        public string Scope { get; set; }

        public string ElevationLevel { get; set; }
    }

    public class ContainerSettingsInfo : PropertyBase
    {

        public string ContainerRunOptions { get; set; }

        public string ImageName { get; set; }

        private RegistryInfo _registry;
        public RegistryInfo Registry
        {
            get => _registry = Get(_registry);
            set => _registry = value;
        }

        public string WorkingDirectory { get; set; }
    }

    public class RegistryInfo : PropertyBase
    {

        public string RegistryServer { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }

    public class CertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        public string StoreLocation { get; set; }

        public string StoreName { get; set; }

        public IList<string> Visibility { get; set; }
    }

    public class ApplicationPackageInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Version { get; set; }
    }

    public class MountConfigurationInfo : PropertyBase
    {

        private AzureBlobFileSystemConfigurationInfo _azureBlobFileSystemConfiguration;
        public AzureBlobFileSystemConfigurationInfo AzureBlobFileSystemConfiguration
        {
            get => _azureBlobFileSystemConfiguration = Get(_azureBlobFileSystemConfiguration);
            set => _azureBlobFileSystemConfiguration = value;
        }

        private NfsMountConfigurationInfo _nfsMountConfiguration;
        public NfsMountConfigurationInfo NfsMountConfiguration
        {
            get => _nfsMountConfiguration = Get(_nfsMountConfiguration);
            set => _nfsMountConfiguration = value;
        }

        private CifsMountConfigurationInfo _cifsMountConfiguration;
        public CifsMountConfigurationInfo CifsMountConfiguration
        {
            get => _cifsMountConfiguration = Get(_cifsMountConfiguration);
            set => _cifsMountConfiguration = value;
        }

        private AzureFileShareConfigurationInfo _azureFileShareConfiguration;
        public AzureFileShareConfigurationInfo AzureFileShareConfiguration
        {
            get => _azureFileShareConfiguration = Get(_azureFileShareConfiguration);
            set => _azureFileShareConfiguration = value;
        }
    }

    public class AzureBlobFileSystemConfigurationInfo : PropertyBase
    {

        public string AccountName { get; set; }

        public string ContainerName { get; set; }

        public string AccountKey { get; set; }

        public string SasKey { get; set; }

        public string BlobfuseOptions { get; set; }

        public string RelativeMountPath { get; set; }
    }

    public class NfsMountConfigurationInfo : PropertyBase
    {

        public string Source { get; set; }

        public string RelativeMountPath { get; set; }

        public string MountOptions { get; set; }
    }

    public class CifsMountConfigurationInfo : PropertyBase
    {

        public string Username { get; set; }

        public string Source { get; set; }

        public string RelativeMountPath { get; set; }

        public string MountOptions { get; set; }

        public string Password { get; set; }
    }

    public class AzureFileShareConfigurationInfo : PropertyBase
    {

        public string AccountName { get; set; }

        public string AzureFileUrl { get; set; }

        public string AccountKey { get; set; }

        public string RelativeMountPath { get; set; }

        public string MountOptions { get; set; }
    }

    public class BatchAccount : Resource<BatchAccountProperties>
    {
        public BatchAccount() => (Type, ApiVersion) = ("Microsoft.Batch/batchAccounts", "2020-03-01");
        public BatchAccount(string name) : this() => Name = name;
        public BatchAccount(string name, Location location) : this() => (Name, Location) = (name, location);

        public BatchAccount WithProperties(Action<BatchAccountProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BatchAccountProperties : PropertyBase
    {

        private AutoStorageInfo _autoStorage;
        public AutoStorageInfo AutoStorage
        {
            get => _autoStorage = Get(_autoStorage);
            set => _autoStorage = value;
        }

        public string PoolAllocationMode { get; set; }

        private KeyVaultReferenceInfo _keyVaultReference;
        public KeyVaultReferenceInfo KeyVaultReference
        {
            get => _keyVaultReference = Get(_keyVaultReference);
            set => _keyVaultReference = value;
        }

        public string PublicNetworkAccess { get; set; }

        private EncryptionInfo _encryption;
        public EncryptionInfo Encryption
        {
            get => _encryption = Get(_encryption);
            set => _encryption = value;
        }
    }

    public class AutoStorageInfo : PropertyBase
    {

        public string StorageAccountId { get; set; }
    }

    public class KeyVaultReferenceInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Url { get; set; }
    }

    public class EncryptionInfo : PropertyBase
    {

        public string KeySource { get; set; }

        private KeyVaultPropertiesInfo _keyVaultProperties;
        public KeyVaultPropertiesInfo KeyVaultProperties
        {
            get => _keyVaultProperties = Get(_keyVaultProperties);
            set => _keyVaultProperties = value;
        }
    }

    public class KeyVaultPropertiesInfo : PropertyBase
    {

        public string KeyIdentifier { get; set; }
    }
}
