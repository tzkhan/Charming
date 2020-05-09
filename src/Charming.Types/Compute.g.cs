namespace Charming.Types.Compute
{
    using Charming;
    using System.Collections.Generic;

    public partial class AvailabilitySet : Resource<AvailabilitySetProperties>
    {
        public AvailabilitySet() => (Type, ApiVersion) = ("Microsoft.Compute/availabilitySets", "2019-12-01");
        public AvailabilitySet(string name) : this() => Name = name;
        public AvailabilitySet(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class AvailabilitySetProperties
    {
        public int? PlatformUpdateDomainCount { get; set; }
        public int? PlatformFaultDomainCount { get; set; }
        public IList<VirtualMachineInfo> VirtualMachines { get; set; }
        public ProximityPlacementGroupInfo ProximityPlacementGroup { get; set; }
    }

    public partial class VirtualMachineInfo
    {
        public string Id { get; set; }
    }

    public partial class ProximityPlacementGroupInfo
    {
        public string Id { get; set; }
    }

    public partial class DiskEncryptionSet : Resource<DiskEncryptionSetProperties>
    {
        public DiskEncryptionSet() => (Type, ApiVersion) = ("Microsoft.Compute/diskEncryptionSets", "2019-11-01");
        public DiskEncryptionSet(string name) : this() => Name = name;
        public DiskEncryptionSet(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class IdentityInfo
    {
        public string Type { get; set; }
    }

    public partial class DiskEncryptionSetProperties
    {
        public ActiveKeyInfo ActiveKey { get; set; }
    }

    public partial class ActiveKeyInfo
    {
        public SourceVaultInfo SourceVault { get; set; }
        public string KeyUrl { get; set; }
    }

    public partial class SourceVaultInfo
    {
        public string Id { get; set; }
    }

    public partial class Disk : Resource<DiskProperties>
    {
        public Disk() => (Type, ApiVersion) = ("Microsoft.Compute/disks", "2019-11-01");
        public Disk(string name) : this() => Name = name;
        public Disk(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }
    }

    public partial class DiskProperties
    {
        public string OsType { get; set; }
        public string HyperVGeneration { get; set; }
        public CreationDataInfo CreationData { get; set; }
        public int? DiskSizeGB { get; set; }
        public EncryptionSettingsCollectionInfo EncryptionSettingsCollection { get; set; }
        public int? DiskIOPSReadWrite { get; set; }
        public int? DiskMBpsReadWrite { get; set; }
        public int? DiskIOPSReadOnly { get; set; }
        public int? DiskMBpsReadOnly { get; set; }
        public EncryptionInfo Encryption { get; set; }
        public int? MaxShares { get; set; }
    }

    public partial class CreationDataInfo
    {
        public string CreateOption { get; set; }
        public string StorageAccountId { get; set; }
        public ImageReferenceInfo ImageReference { get; set; }
        public GalleryImageReferenceInfo GalleryImageReference { get; set; }
        public string SourceUri { get; set; }
        public string SourceResourceId { get; set; }
        public int? UploadSizeBytes { get; set; }
    }

    public partial class ImageReferenceInfo
    {
        public string Id { get; set; }
        public int? Lun { get; set; }
    }

    public partial class GalleryImageReferenceInfo
    {
        public string Id { get; set; }
        public int? Lun { get; set; }
    }

    public partial class EncryptionSettingsCollectionInfo
    {
        public bool? Enabled { get; set; }
        public IList<EncryptionSettingInfo> EncryptionSettings { get; set; }
        public string EncryptionSettingsVersion { get; set; }
    }

    public partial class EncryptionSettingInfo
    {
        public DiskEncryptionKeyInfo DiskEncryptionKey { get; set; }
        public KeyEncryptionKeyInfo KeyEncryptionKey { get; set; }
    }

    public partial class DiskEncryptionKeyInfo
    {
        public SourceVaultInfo SourceVault { get; set; }
        public string SecretUrl { get; set; }
    }

    public partial class KeyEncryptionKeyInfo
    {
        public SourceVaultInfo SourceVault { get; set; }
        public string KeyUrl { get; set; }
    }

    public partial class EncryptionInfo
    {
        public string DiskEncryptionSetId { get; set; }
        public string Type { get; set; }
    }

    public partial class GalleryApplicationVersion : Resource<GalleryApplicationVersionProperties>
    {
        public GalleryApplicationVersion() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/applications/versions", "2019-12-01");
        public GalleryApplicationVersion(string name) : this() => Name = name;
        public GalleryApplicationVersion(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class GalleryApplicationVersionProperties
    {
        public PublishingProfileInfo PublishingProfile { get; set; }
    }

    public partial class PublishingProfileInfo
    {
        public IList<TargetRegionInfo> TargetRegions { get; set; }
        public int? ReplicaCount { get; set; }
        public bool? ExcludeFromLatest { get; set; }
        public string EndOfLifeDate { get; set; }
        public string StorageAccountType { get; set; }
        public SourceInfo Source { get; set; }
        public string ContentType { get; set; }
        public bool? EnableHealthCheck { get; set; }
    }

    public partial class TargetRegionInfo
    {
        public string Name { get; set; }
        public int? RegionalReplicaCount { get; set; }
        public string StorageAccountType { get; set; }
        public EncryptionInfo Encryption { get; set; }
    }

    public partial class OsDiskImageInfo
    {
        public string DiskEncryptionSetId { get; set; }
    }

    public partial class DataDiskImageInfo
    {
        public string DiskEncryptionSetId { get; set; }
        public int? Lun { get; set; }
    }

    public partial class SourceInfo
    {
        public string FileName { get; set; }
        public string MediaLink { get; set; }
    }

    public partial class GalleryApplication : Resource<GalleryApplicationProperties>
    {
        public GalleryApplication() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/applications", "2019-12-01");
        public GalleryApplication(string name) : this() => Name = name;
        public GalleryApplication(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class GalleryApplicationProperties
    {
        public string Description { get; set; }
        public string Eula { get; set; }
        public string PrivacyStatementUri { get; set; }
        public string ReleaseNoteUri { get; set; }
        public string EndOfLifeDate { get; set; }
        public string SupportedOSType { get; set; }
    }

    public partial class GalleryImageVersion : Resource<GalleryImageVersionProperties>
    {
        public GalleryImageVersion() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/images/versions", "2019-12-01");
        public GalleryImageVersion(string name) : this() => Name = name;
        public GalleryImageVersion(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class GalleryImageVersionProperties
    {
        public PublishingProfileInfo PublishingProfile { get; set; }
        public StorageProfileInfo StorageProfile { get; set; }
    }

    public partial class StorageProfileInfo
    {
        public SourceInfo Source { get; set; }
        public StorageProfileOsDiskImageInfo OsDiskImage { get; set; }
        public IList<StorageProfileDataDiskImageInfo> DataDiskImages { get; set; }
    }

    public partial class StorageProfileOsDiskImageInfo
    {
        public string HostCaching { get; set; }
        public SourceInfo Source { get; set; }
    }

    public partial class StorageProfileDataDiskImageInfo
    {
        public string HostCaching { get; set; }
        public SourceInfo Source { get; set; }
        public int? Lun { get; set; }
    }

    public partial class GalleryImage : Resource<GalleryImageProperties>
    {
        public GalleryImage() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/images", "2019-12-01");
        public GalleryImage(string name) : this() => Name = name;
        public GalleryImage(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class GalleryImageProperties
    {
        public string Description { get; set; }
        public string Eula { get; set; }
        public string PrivacyStatementUri { get; set; }
        public string ReleaseNoteUri { get; set; }
        public string OsType { get; set; }
        public string OsState { get; set; }
        public string HyperVGeneration { get; set; }
        public string EndOfLifeDate { get; set; }
        public IdentifierInfo Identifier { get; set; }
        public RecommendedInfo Recommended { get; set; }
        public DisallowedInfo Disallowed { get; set; }
        public PurchasePlanInfo PurchasePlan { get; set; }
    }

    public partial class IdentifierInfo
    {
        public string Publisher { get; set; }
        public string Offer { get; set; }
        public string Sku { get; set; }
    }

    public partial class RecommendedInfo
    {
        public VCPUsInfo VCPUs { get; set; }
        public MemoryInfo Memory { get; set; }
    }

    public partial class VCPUsInfo
    {
        public int? Min { get; set; }
        public int? Max { get; set; }
    }

    public partial class MemoryInfo
    {
        public int? Min { get; set; }
        public int? Max { get; set; }
    }

    public partial class DisallowedInfo
    {
        public IList<string> DiskTypes { get; set; }
    }

    public partial class PurchasePlanInfo
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Product { get; set; }
    }

    public partial class Gallery : Resource<GalleryProperties>
    {
        public Gallery() => (Type, ApiVersion) = ("Microsoft.Compute/galleries", "2019-12-01");
        public Gallery(string name) : this() => Name = name;
        public Gallery(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class GalleryProperties
    {
        public string Description { get; set; }
        public object Identifier { get; set; }
    }

    public partial class HostGroupHost : Resource<HostGroupHostProperties>
    {
        public HostGroupHost() => (Type, ApiVersion) = ("Microsoft.Compute/hostGroups/hosts", "2019-12-01");
        public HostGroupHost(string name) : this() => Name = name;
        public HostGroupHost(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class HostGroupHostProperties
    {
        public int? PlatformFaultDomain { get; set; }
        public bool? AutoReplaceOnFailure { get; set; }
        public string LicenseType { get; set; }
    }

    public partial class HostGroup : Resource<HostGroupProperties>
    {
        public HostGroup() => (Type, ApiVersion) = ("Microsoft.Compute/hostGroups", "2019-12-01");
        public HostGroup(string name) : this() => Name = name;
        public HostGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }
    }

    public partial class HostGroupProperties
    {
        public int? PlatformFaultDomainCount { get; set; }
    }

    public partial class Image : Resource<ImageProperties>
    {
        public Image() => (Type, ApiVersion) = ("Microsoft.Compute/images", "2019-12-01");
        public Image(string name) : this() => Name = name;
        public Image(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ImageProperties
    {
        public SourceVirtualMachineInfo SourceVirtualMachine { get; set; }
        public StorageProfileInfo StorageProfile { get; set; }
        public string HyperVGeneration { get; set; }
    }

    public partial class SourceVirtualMachineInfo
    {
        public string Id { get; set; }
    }

    public partial class OsDiskInfo
    {
        public SnapshotInfo Snapshot { get; set; }
        public ManagedDiskInfo ManagedDisk { get; set; }
        public string BlobUri { get; set; }
        public string Caching { get; set; }
        public int? DiskSizeGB { get; set; }
        public string StorageAccountType { get; set; }
        public DiskEncryptionSetInfo DiskEncryptionSet { get; set; }
        public string OsType { get; set; }
        public string OsState { get; set; }
    }

    public partial class SnapshotInfo
    {
        public string Id { get; set; }
    }

    public partial class ManagedDiskInfo
    {
        public string Id { get; set; }
    }

    public partial class DiskEncryptionSetInfo
    {
        public string Id { get; set; }
    }

    public partial class DataDiskInfo
    {
        public SnapshotInfo Snapshot { get; set; }
        public ManagedDiskInfo ManagedDisk { get; set; }
        public string BlobUri { get; set; }
        public string Caching { get; set; }
        public int? DiskSizeGB { get; set; }
        public string StorageAccountType { get; set; }
        public DiskEncryptionSetInfo DiskEncryptionSet { get; set; }
        public int? Lun { get; set; }
    }

    public partial class ProximityPlacementGroup : Resource<ProximityPlacementGroupProperties>
    {
        public ProximityPlacementGroup() => (Type, ApiVersion) = ("Microsoft.Compute/proximityPlacementGroups", "2019-12-01");
        public ProximityPlacementGroup(string name) : this() => Name = name;
        public ProximityPlacementGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ProximityPlacementGroupProperties
    {
        public string ProximityPlacementGroupType { get; set; }
        public ColocationStatusInfo ColocationStatus { get; set; }
    }

    public partial class ColocationStatusInfo
    {
        public string Code { get; set; }
        public string Level { get; set; }
        public string DisplayStatus { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
    }

    public partial class Snapshot : Resource<SnapshotProperties>
    {
        public Snapshot() => (Type, ApiVersion) = ("Microsoft.Compute/snapshots", "2019-11-01");
        public Snapshot(string name) : this() => Name = name;
        public Snapshot(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SnapshotProperties
    {
        public string OsType { get; set; }
        public string HyperVGeneration { get; set; }
        public CreationDataInfo CreationData { get; set; }
        public int? DiskSizeGB { get; set; }
        public EncryptionSettingsCollectionInfo EncryptionSettingsCollection { get; set; }
        public bool? Incremental { get; set; }
        public EncryptionInfo Encryption { get; set; }
    }

    public partial class SshPublicKey : Resource<SshPublicKeyProperties>
    {
        public SshPublicKey() => (Type, ApiVersion) = ("Microsoft.Compute/sshPublicKeys", "2019-12-01");
        public SshPublicKey(string name) : this() => Name = name;
        public SshPublicKey(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SshPublicKeyProperties
    {
        public string PublicKey { get; set; }
    }

    public partial class VirtualMachineExtension : Resource<VirtualMachineExtensionProperties>
    {
        public VirtualMachineExtension() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachines/extensions", "2019-12-01");
        public VirtualMachineExtension(string name) : this() => Name = name;
        public VirtualMachineExtension(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualMachineExtensionProperties
    {
        public string Publisher { get; set; }
        public string Type { get; set; }
        public string TypeHandlerVersion { get; set; }
        public bool? AutoUpgradeMinorVersion { get; set; }
        public object Settings { get; set; }
        public object ProtectedSettings { get; set; }
        public InstanceViewInfo InstanceView { get; set; }
    }

    public partial class InstanceViewInfo
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string TypeHandlerVersion { get; set; }
        public IList<SubstatuseInfo> Substatuses { get; set; }
        public IList<StatuseInfo> Statuses { get; set; }
    }

    public partial class SubstatuseInfo
    {
        public string Code { get; set; }
        public string Level { get; set; }
        public string DisplayStatus { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
    }

    public partial class StatuseInfo
    {
        public string Code { get; set; }
        public string Level { get; set; }
        public string DisplayStatus { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
    }

    public partial class VirtualMachine : Resource<VirtualMachineProperties>
    {
        public VirtualMachine() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachines", "2019-12-01");
        public VirtualMachine(string name) : this() => Name = name;
        public VirtualMachine(string name, Location location) : this() => (Name, Location) = (name, location);

        public PlanInfo Plan { get; set; }

        public IdentityInfo Identity { get; set; }

        public IList<string> Zones { get; set; }
    }

    public partial class PlanInfo
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Product { get; set; }
        public string PromotionCode { get; set; }
    }

    public partial class VirtualMachineProperties
    {
        public HardwareProfileInfo HardwareProfile { get; set; }
        public StorageProfileInfo StorageProfile { get; set; }
        public AdditionalCapabilitiesInfo AdditionalCapabilities { get; set; }
        public OsProfileInfo OsProfile { get; set; }
        public NetworkProfileInfo NetworkProfile { get; set; }
        public DiagnosticsProfileInfo DiagnosticsProfile { get; set; }
        public AvailabilitySetInfo AvailabilitySet { get; set; }
        public VirtualMachineScaleSetInfo VirtualMachineScaleSet { get; set; }
        public ProximityPlacementGroupInfo ProximityPlacementGroup { get; set; }
        public string Priority { get; set; }
        public string EvictionPolicy { get; set; }
        public BillingProfileInfo BillingProfile { get; set; }
        public HostInfo Host { get; set; }
        public string LicenseType { get; set; }
    }

    public partial class HardwareProfileInfo
    {
        public string VmSize { get; set; }
    }

    public partial class EncryptionSettingsInfo
    {
        public DiskEncryptionKeyInfo DiskEncryptionKey { get; set; }
        public KeyEncryptionKeyInfo KeyEncryptionKey { get; set; }
        public bool? Enabled { get; set; }
    }

    public partial class VhdInfo
    {
        public string Uri { get; set; }
    }

    public partial class ImageInfo
    {
        public string Uri { get; set; }
    }

    public partial class DiffDiskSettingsInfo
    {
        public string Option { get; set; }
        public string Placement { get; set; }
    }

    public partial class DataDiskManagedDiskInfo
    {
        public string Id { get; set; }
        public string StorageAccountType { get; set; }
        public DiskEncryptionSetInfo DiskEncryptionSet { get; set; }
    }

    public partial class AdditionalCapabilitiesInfo
    {
        public bool? UltraSSDEnabled { get; set; }
    }

    public partial class OsProfileInfo
    {
        public string ComputerName { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public string CustomData { get; set; }
        public WindowsConfigurationInfo WindowsConfiguration { get; set; }
        public LinuxConfigurationInfo LinuxConfiguration { get; set; }
        public IList<SecretInfo> Secrets { get; set; }
        public bool? AllowExtensionOperations { get; set; }
        public bool? RequireGuestProvisionSignal { get; set; }
    }

    public partial class WindowsConfigurationInfo
    {
        public bool? ProvisionVMAgent { get; set; }
        public bool? EnableAutomaticUpdates { get; set; }
        public string TimeZone { get; set; }
        public IList<AdditionalUnattendContentInfo> AdditionalUnattendContent { get; set; }
        public WinRMInfo WinRM { get; set; }
    }

    public partial class AdditionalUnattendContentInfo
    {
        public string PassName { get; set; }
        public string ComponentName { get; set; }
        public string SettingName { get; set; }
        public string Content { get; set; }
    }

    public partial class WinRMInfo
    {
        public IList<ListenerInfo> Listeners { get; set; }
    }

    public partial class ListenerInfo
    {
        public string Protocol { get; set; }
        public string CertificateUrl { get; set; }
    }

    public partial class LinuxConfigurationInfo
    {
        public bool? DisablePasswordAuthentication { get; set; }
        public SshInfo Ssh { get; set; }
        public bool? ProvisionVMAgent { get; set; }
    }

    public partial class SshInfo
    {
        public IList<PublicKeyInfo> PublicKeys { get; set; }
    }

    public partial class PublicKeyInfo
    {
        public string Path { get; set; }
        public string KeyData { get; set; }
    }

    public partial class SecretInfo
    {
        public SourceVaultInfo SourceVault { get; set; }
        public IList<VaultCertificateInfo> VaultCertificates { get; set; }
    }

    public partial class VaultCertificateInfo
    {
        public string CertificateUrl { get; set; }
        public string CertificateStore { get; set; }
    }

    public partial class NetworkProfileInfo
    {
        public IList<NetworkInterfaceInfo> NetworkInterfaces { get; set; }
    }

    public partial class NetworkInterfaceInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
    }

    public partial class PropertiesInfo
    {
        public bool? Primary { get; set; }
    }

    public partial class DiagnosticsProfileInfo
    {
        public BootDiagnosticsInfo BootDiagnostics { get; set; }
    }

    public partial class BootDiagnosticsInfo
    {
        public bool? Enabled { get; set; }
        public string StorageUri { get; set; }
    }

    public partial class AvailabilitySetInfo
    {
        public string Id { get; set; }
    }

    public partial class VirtualMachineScaleSetInfo
    {
        public string Id { get; set; }
    }

    public partial class BillingProfileInfo
    {
        public string MaxPrice { get; set; }
    }

    public partial class HostInfo
    {
        public string Id { get; set; }
    }

    public partial class VirtualMachineScaleSetExtension : Resource<VirtualMachineScaleSetExtensionProperties>
    {
        public VirtualMachineScaleSetExtension() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets/extensions", "2019-12-01");
        public VirtualMachineScaleSetExtension(string name) : this() => Name = name;
        public VirtualMachineScaleSetExtension(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualMachineScaleSetExtensionProperties
    {
        public string Publisher { get; set; }
        public string Type { get; set; }
        public string TypeHandlerVersion { get; set; }
        public bool? AutoUpgradeMinorVersion { get; set; }
        public object Settings { get; set; }
        public object ProtectedSettings { get; set; }
        public IList<string> ProvisionAfterExtensions { get; set; }
    }

    public partial class VirtualMachineScaleSetVirtualMachineExtension : Resource<VirtualMachineScaleSetVirtualMachineExtensionProperties>
    {
        public VirtualMachineScaleSetVirtualMachineExtension() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets/virtualMachines/extensions", "2019-12-01");
        public VirtualMachineScaleSetVirtualMachineExtension(string name) : this() => Name = name;
        public VirtualMachineScaleSetVirtualMachineExtension(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualMachineScaleSetVirtualMachineExtensionProperties
    {
        public string Publisher { get; set; }
        public string Type { get; set; }
        public string TypeHandlerVersion { get; set; }
        public bool? AutoUpgradeMinorVersion { get; set; }
        public object Settings { get; set; }
        public object ProtectedSettings { get; set; }
        public InstanceViewInfo InstanceView { get; set; }
    }

    public partial class VirtualMachineScaleSetVirtualmachine : Resource<VirtualMachineScaleSetVirtualmachineProperties>
    {
        public VirtualMachineScaleSetVirtualmachine() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets/virtualmachines", "2019-12-01");
        public VirtualMachineScaleSetVirtualmachine(string name) : this() => Name = name;
        public VirtualMachineScaleSetVirtualmachine(string name, Location location) : this() => (Name, Location) = (name, location);

        public PlanInfo Plan { get; set; }
    }

    public partial class VirtualMachineScaleSetVirtualmachineProperties
    {
        public HardwareProfileInfo HardwareProfile { get; set; }
        public StorageProfileInfo StorageProfile { get; set; }
        public AdditionalCapabilitiesInfo AdditionalCapabilities { get; set; }
        public OsProfileInfo OsProfile { get; set; }
        public NetworkProfileInfo NetworkProfile { get; set; }
        public NetworkProfileConfigurationInfo NetworkProfileConfiguration { get; set; }
        public DiagnosticsProfileInfo DiagnosticsProfile { get; set; }
        public AvailabilitySetInfo AvailabilitySet { get; set; }
        public string LicenseType { get; set; }
        public ProtectionPolicyInfo ProtectionPolicy { get; set; }
    }

    public partial class NetworkProfileConfigurationInfo
    {
        public IList<NetworkInterfaceConfigurationInfo> NetworkInterfaceConfigurations { get; set; }
    }

    public partial class NetworkInterfaceConfigurationInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public NetworkInterfaceConfigurationPropertiesInfo Properties { get; set; }
    }

    public partial class NetworkInterfaceConfigurationPropertiesInfo
    {
        public bool? Primary { get; set; }
        public bool? EnableAcceleratedNetworking { get; set; }
        public NetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public DnsSettingsInfo DnsSettings { get; set; }
        public IList<IpConfigurationInfo> IpConfigurations { get; set; }
        public bool? EnableIPForwarding { get; set; }
    }

    public partial class NetworkSecurityGroupInfo
    {
        public string Id { get; set; }
    }

    public partial class DnsSettingsInfo
    {
        public IList<string> DnsServers { get; set; }
    }

    public partial class IpConfigurationInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IpConfigurationPropertiesInfo Properties { get; set; }
    }

    public partial class IpConfigurationPropertiesInfo
    {
        public SubnetInfo Subnet { get; set; }
        public bool? Primary { get; set; }
        public PublicIPAddressConfigurationInfo PublicIPAddressConfiguration { get; set; }
        public string PrivateIPAddressVersion { get; set; }
        public IList<ApplicationGatewayBackendAddressPoolInfo> ApplicationGatewayBackendAddressPools { get; set; }
        public IList<ApplicationSecurityGroupInfo> ApplicationSecurityGroups { get; set; }
        public IList<LoadBalancerBackendAddressPoolInfo> LoadBalancerBackendAddressPools { get; set; }
        public IList<LoadBalancerInboundNatPoolInfo> LoadBalancerInboundNatPools { get; set; }
    }

    public partial class SubnetInfo
    {
        public string Id { get; set; }
    }

    public partial class PublicIPAddressConfigurationInfo
    {
        public string Name { get; set; }
        public PublicIPAddressConfigurationPropertiesInfo Properties { get; set; }
    }

    public partial class PublicIPAddressConfigurationPropertiesInfo
    {
        public int? IdleTimeoutInMinutes { get; set; }
        public PublicIPAddressConfigurationPropertiesDnsSettingsInfo DnsSettings { get; set; }
        public IList<IpTagInfo> IpTags { get; set; }
        public PublicIPPrefixInfo PublicIPPrefix { get; set; }
        public string PublicIPAddressVersion { get; set; }
    }

    public partial class PublicIPAddressConfigurationPropertiesDnsSettingsInfo
    {
        public string DomainNameLabel { get; set; }
    }

    public partial class IpTagInfo
    {
        public string IpTagType { get; set; }
        public string Tag { get; set; }
    }

    public partial class PublicIPPrefixInfo
    {
        public string Id { get; set; }
    }

    public partial class ApplicationGatewayBackendAddressPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class ApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
    }

    public partial class LoadBalancerBackendAddressPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class LoadBalancerInboundNatPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class ProtectionPolicyInfo
    {
        public bool? ProtectFromScaleIn { get; set; }
        public bool? ProtectFromScaleSetActions { get; set; }
    }

    public partial class VirtualMachineScaleSet : Resource<VirtualMachineScaleSetProperties>
    {
        public VirtualMachineScaleSet() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets", "2019-12-01");
        public VirtualMachineScaleSet(string name) : this() => Name = name;
        public VirtualMachineScaleSet(string name, Location location) : this() => (Name, Location) = (name, location);

        public PlanInfo Plan { get; set; }

        public IdentityInfo Identity { get; set; }

        public IList<string> Zones { get; set; }
    }

    public partial class VirtualMachineScaleSetProperties
    {
        public UpgradePolicyInfo UpgradePolicy { get; set; }
        public AutomaticRepairsPolicyInfo AutomaticRepairsPolicy { get; set; }
        public VirtualMachineProfileInfo VirtualMachineProfile { get; set; }
        public bool? Overprovision { get; set; }
        public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }
        public bool? SinglePlacementGroup { get; set; }
        public bool? ZoneBalance { get; set; }
        public int? PlatformFaultDomainCount { get; set; }
        public ProximityPlacementGroupInfo ProximityPlacementGroup { get; set; }
        public AdditionalCapabilitiesInfo AdditionalCapabilities { get; set; }
        public ScaleInPolicyInfo ScaleInPolicy { get; set; }
    }

    public partial class UpgradePolicyInfo
    {
        public string Mode { get; set; }
        public RollingUpgradePolicyInfo RollingUpgradePolicy { get; set; }
        public AutomaticOSUpgradePolicyInfo AutomaticOSUpgradePolicy { get; set; }
    }

    public partial class RollingUpgradePolicyInfo
    {
        public int? MaxBatchInstancePercent { get; set; }
        public int? MaxUnhealthyInstancePercent { get; set; }
        public int? MaxUnhealthyUpgradedInstancePercent { get; set; }
        public string PauseTimeBetweenBatches { get; set; }
    }

    public partial class AutomaticOSUpgradePolicyInfo
    {
        public bool? EnableAutomaticOSUpgrade { get; set; }
        public bool? DisableAutomaticRollback { get; set; }
    }

    public partial class AutomaticRepairsPolicyInfo
    {
        public bool? Enabled { get; set; }
        public string GracePeriod { get; set; }
    }

    public partial class VirtualMachineProfileInfo
    {
        public OsProfileInfo OsProfile { get; set; }
        public StorageProfileInfo StorageProfile { get; set; }
        public NetworkProfileInfo NetworkProfile { get; set; }
        public DiagnosticsProfileInfo DiagnosticsProfile { get; set; }
        public ExtensionProfileInfo ExtensionProfile { get; set; }
        public string LicenseType { get; set; }
        public string Priority { get; set; }
        public string EvictionPolicy { get; set; }
        public BillingProfileInfo BillingProfile { get; set; }
        public ScheduledEventsProfileInfo ScheduledEventsProfile { get; set; }
    }

    public partial class HealthProbeInfo
    {
        public string Id { get; set; }
    }

    public partial class ExtensionProfileInfo
    {
        public IList<ExtensionInfo> Extensions { get; set; }
    }

    public partial class ExtensionInfo
    {
        public string Name { get; set; }
        public ExtensionPropertiesInfo Properties { get; set; }
    }

    public partial class ExtensionPropertiesInfo
    {
        public string Publisher { get; set; }
        public string Type { get; set; }
        public string TypeHandlerVersion { get; set; }
        public bool? AutoUpgradeMinorVersion { get; set; }
        public object Settings { get; set; }
        public object ProtectedSettings { get; set; }
        public IList<string> ProvisionAfterExtensions { get; set; }
    }

    public partial class ScheduledEventsProfileInfo
    {
        public TerminateNotificationProfileInfo TerminateNotificationProfile { get; set; }
    }

    public partial class TerminateNotificationProfileInfo
    {
        public string NotBeforeTimeout { get; set; }
        public bool? Enable { get; set; }
    }

    public partial class ScaleInPolicyInfo
    {
        public IList<string> Rules { get; set; }
    }
}
