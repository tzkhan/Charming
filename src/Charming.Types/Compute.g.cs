namespace Charming.Types.Compute
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class AvailabilitySet : Resource<AvailabilitySetProperties>
    {
        public AvailabilitySet() => (Type, ApiVersion) = ("Microsoft.Compute/availabilitySets", "2019-12-01");
        public AvailabilitySet(string name) : this() => Name = name;
        public AvailabilitySet(string name, Location location) : this() => (Name, Location) = (name, location);

        public AvailabilitySet WithProperties(Action<AvailabilitySetProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AvailabilitySetProperties : PropertyBase
    {

        public int? PlatformUpdateDomainCount { get; set; }

        public int? PlatformFaultDomainCount { get; set; }

        public IList<VirtualMachineInfo> VirtualMachines { get; set; }

        private ProximityPlacementGroupInfo _proximityPlacementGroup;
        public ProximityPlacementGroupInfo ProximityPlacementGroup
        {
            get => _proximityPlacementGroup = Get(_proximityPlacementGroup);
            set => _proximityPlacementGroup = value;
        }
    }

    public class VirtualMachineInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ProximityPlacementGroupInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class DiskEncryptionSet : Resource<DiskEncryptionSetProperties>
    {
        public DiskEncryptionSet() => (Type, ApiVersion) = ("Microsoft.Compute/diskEncryptionSets", "2019-11-01");
        public DiskEncryptionSet(string name) : this() => Name = name;
        public DiskEncryptionSet(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public DiskEncryptionSet WithProperties(Action<DiskEncryptionSetProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }
    }

    public class DiskEncryptionSetProperties : PropertyBase
    {

        private ActiveKeyInfo _activeKey;
        public ActiveKeyInfo ActiveKey
        {
            get => _activeKey = Get(_activeKey);
            set => _activeKey = value;
        }
    }

    public class ActiveKeyInfo : PropertyBase
    {

        private SourceVaultInfo _sourceVault;
        public SourceVaultInfo SourceVault
        {
            get => _sourceVault = Get(_sourceVault);
            set => _sourceVault = value;
        }

        public string KeyUrl { get; set; }
    }

    public class SourceVaultInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class Disk : Resource<DiskProperties>
    {
        public Disk() => (Type, ApiVersion) = ("Microsoft.Compute/disks", "2019-11-01");
        public Disk(string name) : this() => Name = name;
        public Disk(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public Disk WithProperties(Action<DiskProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DiskProperties : PropertyBase
    {

        public string OsType { get; set; }

        public string HyperVGeneration { get; set; }

        private CreationDataInfo _creationData;
        public CreationDataInfo CreationData
        {
            get => _creationData = Get(_creationData);
            set => _creationData = value;
        }

        public int? DiskSizeGB { get; set; }

        private EncryptionSettingsCollectionInfo _encryptionSettingsCollection;
        public EncryptionSettingsCollectionInfo EncryptionSettingsCollection
        {
            get => _encryptionSettingsCollection = Get(_encryptionSettingsCollection);
            set => _encryptionSettingsCollection = value;
        }

        public int? DiskIOPSReadWrite { get; set; }

        public int? DiskMBpsReadWrite { get; set; }

        public int? DiskIOPSReadOnly { get; set; }

        public int? DiskMBpsReadOnly { get; set; }

        private EncryptionInfo _encryption;
        public EncryptionInfo Encryption
        {
            get => _encryption = Get(_encryption);
            set => _encryption = value;
        }

        public int? MaxShares { get; set; }
    }

    public class CreationDataInfo : PropertyBase
    {

        public string CreateOption { get; set; }

        public string StorageAccountId { get; set; }

        private ImageReferenceInfo _imageReference;
        public ImageReferenceInfo ImageReference
        {
            get => _imageReference = Get(_imageReference);
            set => _imageReference = value;
        }

        private GalleryImageReferenceInfo _galleryImageReference;
        public GalleryImageReferenceInfo GalleryImageReference
        {
            get => _galleryImageReference = Get(_galleryImageReference);
            set => _galleryImageReference = value;
        }

        public string SourceUri { get; set; }

        public string SourceResourceId { get; set; }

        public int? UploadSizeBytes { get; set; }
    }

    public class ImageReferenceInfo : PropertyBase
    {

        public string Id { get; set; }

        public int? Lun { get; set; }
    }

    public class GalleryImageReferenceInfo : PropertyBase
    {

        public string Id { get; set; }

        public int? Lun { get; set; }
    }

    public class EncryptionSettingsCollectionInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public IList<EncryptionSettingInfo> EncryptionSettings { get; set; }

        public string EncryptionSettingsVersion { get; set; }
    }

    public class EncryptionSettingInfo : PropertyBase
    {

        private DiskEncryptionKeyInfo _diskEncryptionKey;
        public DiskEncryptionKeyInfo DiskEncryptionKey
        {
            get => _diskEncryptionKey = Get(_diskEncryptionKey);
            set => _diskEncryptionKey = value;
        }

        private KeyEncryptionKeyInfo _keyEncryptionKey;
        public KeyEncryptionKeyInfo KeyEncryptionKey
        {
            get => _keyEncryptionKey = Get(_keyEncryptionKey);
            set => _keyEncryptionKey = value;
        }
    }

    public class DiskEncryptionKeyInfo : PropertyBase
    {

        private SourceVaultInfo _sourceVault;
        public SourceVaultInfo SourceVault
        {
            get => _sourceVault = Get(_sourceVault);
            set => _sourceVault = value;
        }

        public string SecretUrl { get; set; }
    }

    public class KeyEncryptionKeyInfo : PropertyBase
    {

        private SourceVaultInfo _sourceVault;
        public SourceVaultInfo SourceVault
        {
            get => _sourceVault = Get(_sourceVault);
            set => _sourceVault = value;
        }

        public string KeyUrl { get; set; }
    }

    public class EncryptionInfo : PropertyBase
    {

        public string DiskEncryptionSetId { get; set; }

        public string Type { get; set; }
    }

    public class GalleryApplicationVersion : Resource<GalleryApplicationVersionProperties>
    {
        public GalleryApplicationVersion() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/applications/versions", "2019-12-01");
        public GalleryApplicationVersion(string name) : this() => Name = name;
        public GalleryApplicationVersion(string name, Location location) : this() => (Name, Location) = (name, location);

        public GalleryApplicationVersion WithProperties(Action<GalleryApplicationVersionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class GalleryApplicationVersionProperties : PropertyBase
    {

        private PublishingProfileInfo _publishingProfile;
        public PublishingProfileInfo PublishingProfile
        {
            get => _publishingProfile = Get(_publishingProfile);
            set => _publishingProfile = value;
        }
    }

    public class PublishingProfileInfo : PropertyBase
    {

        public IList<TargetRegionInfo> TargetRegions { get; set; }

        public int? ReplicaCount { get; set; }

        public bool? ExcludeFromLatest { get; set; }

        public string EndOfLifeDate { get; set; }

        public string StorageAccountType { get; set; }

        private SourceInfo _source;
        public SourceInfo Source
        {
            get => _source = Get(_source);
            set => _source = value;
        }

        public string ContentType { get; set; }

        public bool? EnableHealthCheck { get; set; }
    }

    public class TargetRegionInfo : PropertyBase
    {

        public string Name { get; set; }

        public int? RegionalReplicaCount { get; set; }

        public string StorageAccountType { get; set; }

        private EncryptionInfo _encryption;
        public EncryptionInfo Encryption
        {
            get => _encryption = Get(_encryption);
            set => _encryption = value;
        }
    }

    public class OsDiskImageInfo : PropertyBase
    {

        public string DiskEncryptionSetId { get; set; }
    }

    public class DataDiskImageInfo : PropertyBase
    {

        public string DiskEncryptionSetId { get; set; }

        public int? Lun { get; set; }
    }

    public class SourceInfo : PropertyBase
    {

        public string FileName { get; set; }

        public string MediaLink { get; set; }
    }

    public class GalleryApplication : Resource<GalleryApplicationProperties>
    {
        public GalleryApplication() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/applications", "2019-12-01");
        public GalleryApplication(string name) : this() => Name = name;
        public GalleryApplication(string name, Location location) : this() => (Name, Location) = (name, location);

        public GalleryApplication WithProperties(Action<GalleryApplicationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class GalleryApplicationProperties : PropertyBase
    {

        public string Description { get; set; }

        public string Eula { get; set; }

        public string PrivacyStatementUri { get; set; }

        public string ReleaseNoteUri { get; set; }

        public string EndOfLifeDate { get; set; }

        public string SupportedOSType { get; set; }
    }

    public class GalleryImageVersion : Resource<GalleryImageVersionProperties>
    {
        public GalleryImageVersion() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/images/versions", "2019-12-01");
        public GalleryImageVersion(string name) : this() => Name = name;
        public GalleryImageVersion(string name, Location location) : this() => (Name, Location) = (name, location);

        public GalleryImageVersion WithProperties(Action<GalleryImageVersionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class GalleryImageVersionProperties : PropertyBase
    {

        private PublishingProfileInfo _publishingProfile;
        public PublishingProfileInfo PublishingProfile
        {
            get => _publishingProfile = Get(_publishingProfile);
            set => _publishingProfile = value;
        }

        private StorageProfileInfo _storageProfile;
        public StorageProfileInfo StorageProfile
        {
            get => _storageProfile = Get(_storageProfile);
            set => _storageProfile = value;
        }
    }

    public class StorageProfileInfo : PropertyBase
    {

        private SourceInfo _source;
        public SourceInfo Source
        {
            get => _source = Get(_source);
            set => _source = value;
        }

        private StorageProfileOsDiskImageInfo _osDiskImage;
        public StorageProfileOsDiskImageInfo OsDiskImage
        {
            get => _osDiskImage = Get(_osDiskImage);
            set => _osDiskImage = value;
        }

        public IList<StorageProfileDataDiskImageInfo> DataDiskImages { get; set; }
    }

    public class StorageProfileOsDiskImageInfo : PropertyBase
    {

        public string HostCaching { get; set; }

        private SourceInfo _source;
        public SourceInfo Source
        {
            get => _source = Get(_source);
            set => _source = value;
        }
    }

    public class StorageProfileDataDiskImageInfo : PropertyBase
    {

        public string HostCaching { get; set; }

        private SourceInfo _source;
        public SourceInfo Source
        {
            get => _source = Get(_source);
            set => _source = value;
        }

        public int? Lun { get; set; }
    }

    public class GalleryImage : Resource<GalleryImageProperties>
    {
        public GalleryImage() => (Type, ApiVersion) = ("Microsoft.Compute/galleries/images", "2019-12-01");
        public GalleryImage(string name) : this() => Name = name;
        public GalleryImage(string name, Location location) : this() => (Name, Location) = (name, location);

        public GalleryImage WithProperties(Action<GalleryImageProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class GalleryImageProperties : PropertyBase
    {

        public string Description { get; set; }

        public string Eula { get; set; }

        public string PrivacyStatementUri { get; set; }

        public string ReleaseNoteUri { get; set; }

        public string OsType { get; set; }

        public string OsState { get; set; }

        public string HyperVGeneration { get; set; }

        public string EndOfLifeDate { get; set; }

        private IdentifierInfo _identifier;
        public IdentifierInfo Identifier
        {
            get => _identifier = Get(_identifier);
            set => _identifier = value;
        }

        private RecommendedInfo _recommended;
        public RecommendedInfo Recommended
        {
            get => _recommended = Get(_recommended);
            set => _recommended = value;
        }

        private DisallowedInfo _disallowed;
        public DisallowedInfo Disallowed
        {
            get => _disallowed = Get(_disallowed);
            set => _disallowed = value;
        }

        private PurchasePlanInfo _purchasePlan;
        public PurchasePlanInfo PurchasePlan
        {
            get => _purchasePlan = Get(_purchasePlan);
            set => _purchasePlan = value;
        }
    }

    public class IdentifierInfo : PropertyBase
    {

        public string Publisher { get; set; }

        public string Offer { get; set; }

        public string Sku { get; set; }
    }

    public class RecommendedInfo : PropertyBase
    {

        private VCPUsInfo _vCPUs;
        public VCPUsInfo VCPUs
        {
            get => _vCPUs = Get(_vCPUs);
            set => _vCPUs = value;
        }

        private MemoryInfo _memory;
        public MemoryInfo Memory
        {
            get => _memory = Get(_memory);
            set => _memory = value;
        }
    }

    public class VCPUsInfo : PropertyBase
    {

        public int? Min { get; set; }

        public int? Max { get; set; }
    }

    public class MemoryInfo : PropertyBase
    {

        public int? Min { get; set; }

        public int? Max { get; set; }
    }

    public class DisallowedInfo : PropertyBase
    {

        public IList<string> DiskTypes { get; set; }
    }

    public class PurchasePlanInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Product { get; set; }
    }

    public class Gallery : Resource<GalleryProperties>
    {
        public Gallery() => (Type, ApiVersion) = ("Microsoft.Compute/galleries", "2019-12-01");
        public Gallery(string name) : this() => Name = name;
        public Gallery(string name, Location location) : this() => (Name, Location) = (name, location);

        public Gallery WithProperties(Action<GalleryProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class GalleryProperties : PropertyBase
    {

        public string Description { get; set; }

        public object Identifier { get; set; }
    }

    public class HostGroupHost : Resource<HostGroupHostProperties>
    {
        public HostGroupHost() => (Type, ApiVersion) = ("Microsoft.Compute/hostGroups/hosts", "2019-12-01");
        public HostGroupHost(string name) : this() => Name = name;
        public HostGroupHost(string name, Location location) : this() => (Name, Location) = (name, location);

        public HostGroupHost WithProperties(Action<HostGroupHostProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class HostGroupHostProperties : PropertyBase
    {

        public int? PlatformFaultDomain { get; set; }

        public bool? AutoReplaceOnFailure { get; set; }

        public string LicenseType { get; set; }
    }

    public class HostGroup : Resource<HostGroupProperties>
    {
        public HostGroup() => (Type, ApiVersion) = ("Microsoft.Compute/hostGroups", "2019-12-01");
        public HostGroup(string name) : this() => Name = name;
        public HostGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public HostGroup WithProperties(Action<HostGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class HostGroupProperties : PropertyBase
    {

        public int? PlatformFaultDomainCount { get; set; }
    }

    public class Image : Resource<ImageProperties>
    {
        public Image() => (Type, ApiVersion) = ("Microsoft.Compute/images", "2019-12-01");
        public Image(string name) : this() => Name = name;
        public Image(string name, Location location) : this() => (Name, Location) = (name, location);

        public Image WithProperties(Action<ImageProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ImageProperties : PropertyBase
    {

        private SourceVirtualMachineInfo _sourceVirtualMachine;
        public SourceVirtualMachineInfo SourceVirtualMachine
        {
            get => _sourceVirtualMachine = Get(_sourceVirtualMachine);
            set => _sourceVirtualMachine = value;
        }

        private StorageProfileInfo _storageProfile;
        public StorageProfileInfo StorageProfile
        {
            get => _storageProfile = Get(_storageProfile);
            set => _storageProfile = value;
        }

        public string HyperVGeneration { get; set; }
    }

    public class SourceVirtualMachineInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class OsDiskInfo : PropertyBase
    {

        private SnapshotInfo _snapshot;
        public SnapshotInfo Snapshot
        {
            get => _snapshot = Get(_snapshot);
            set => _snapshot = value;
        }

        private ManagedDiskInfo _managedDisk;
        public ManagedDiskInfo ManagedDisk
        {
            get => _managedDisk = Get(_managedDisk);
            set => _managedDisk = value;
        }

        public string BlobUri { get; set; }

        public string Caching { get; set; }

        public int? DiskSizeGB { get; set; }

        public string StorageAccountType { get; set; }

        private DiskEncryptionSetInfo _diskEncryptionSet;
        public DiskEncryptionSetInfo DiskEncryptionSet
        {
            get => _diskEncryptionSet = Get(_diskEncryptionSet);
            set => _diskEncryptionSet = value;
        }

        public string OsType { get; set; }

        public string OsState { get; set; }
    }

    public class SnapshotInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ManagedDiskInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class DiskEncryptionSetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class DataDiskInfo : PropertyBase
    {

        private SnapshotInfo _snapshot;
        public SnapshotInfo Snapshot
        {
            get => _snapshot = Get(_snapshot);
            set => _snapshot = value;
        }

        private ManagedDiskInfo _managedDisk;
        public ManagedDiskInfo ManagedDisk
        {
            get => _managedDisk = Get(_managedDisk);
            set => _managedDisk = value;
        }

        public string BlobUri { get; set; }

        public string Caching { get; set; }

        public int? DiskSizeGB { get; set; }

        public string StorageAccountType { get; set; }

        private DiskEncryptionSetInfo _diskEncryptionSet;
        public DiskEncryptionSetInfo DiskEncryptionSet
        {
            get => _diskEncryptionSet = Get(_diskEncryptionSet);
            set => _diskEncryptionSet = value;
        }

        public int? Lun { get; set; }
    }

    public class ProximityPlacementGroup : Resource<ProximityPlacementGroupProperties>
    {
        public ProximityPlacementGroup() => (Type, ApiVersion) = ("Microsoft.Compute/proximityPlacementGroups", "2019-12-01");
        public ProximityPlacementGroup(string name) : this() => Name = name;
        public ProximityPlacementGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public ProximityPlacementGroup WithProperties(Action<ProximityPlacementGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ProximityPlacementGroupProperties : PropertyBase
    {

        public string ProximityPlacementGroupType { get; set; }

        private ColocationStatusInfo _colocationStatus;
        public ColocationStatusInfo ColocationStatus
        {
            get => _colocationStatus = Get(_colocationStatus);
            set => _colocationStatus = value;
        }
    }

    public class ColocationStatusInfo : PropertyBase
    {

        public string Code { get; set; }

        public string Level { get; set; }

        public string DisplayStatus { get; set; }

        public string Message { get; set; }

        public string Time { get; set; }
    }

    public class Snapshot : Resource<SnapshotProperties>
    {
        public Snapshot() => (Type, ApiVersion) = ("Microsoft.Compute/snapshots", "2019-11-01");
        public Snapshot(string name) : this() => Name = name;
        public Snapshot(string name, Location location) : this() => (Name, Location) = (name, location);

        public Snapshot WithProperties(Action<SnapshotProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SnapshotProperties : PropertyBase
    {

        public string OsType { get; set; }

        public string HyperVGeneration { get; set; }

        private CreationDataInfo _creationData;
        public CreationDataInfo CreationData
        {
            get => _creationData = Get(_creationData);
            set => _creationData = value;
        }

        public int? DiskSizeGB { get; set; }

        private EncryptionSettingsCollectionInfo _encryptionSettingsCollection;
        public EncryptionSettingsCollectionInfo EncryptionSettingsCollection
        {
            get => _encryptionSettingsCollection = Get(_encryptionSettingsCollection);
            set => _encryptionSettingsCollection = value;
        }

        public bool? Incremental { get; set; }

        private EncryptionInfo _encryption;
        public EncryptionInfo Encryption
        {
            get => _encryption = Get(_encryption);
            set => _encryption = value;
        }
    }

    public class SshPublicKey : Resource<SshPublicKeyProperties>
    {
        public SshPublicKey() => (Type, ApiVersion) = ("Microsoft.Compute/sshPublicKeys", "2019-12-01");
        public SshPublicKey(string name) : this() => Name = name;
        public SshPublicKey(string name, Location location) : this() => (Name, Location) = (name, location);

        public SshPublicKey WithProperties(Action<SshPublicKeyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SshPublicKeyProperties : PropertyBase
    {

        public string PublicKey { get; set; }
    }

    public class VirtualMachineExtension : Resource<VirtualMachineExtensionProperties>
    {
        public VirtualMachineExtension() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachines/extensions", "2019-12-01");
        public VirtualMachineExtension(string name) : this() => Name = name;
        public VirtualMachineExtension(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualMachineExtension WithProperties(Action<VirtualMachineExtensionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualMachineExtensionProperties : PropertyBase
    {

        public string Publisher { get; set; }

        public string Type { get; set; }

        public string TypeHandlerVersion { get; set; }

        public bool? AutoUpgradeMinorVersion { get; set; }

        public object Settings { get; set; }

        public object ProtectedSettings { get; set; }

        private InstanceViewInfo _instanceView;
        public InstanceViewInfo InstanceView
        {
            get => _instanceView = Get(_instanceView);
            set => _instanceView = value;
        }
    }

    public class InstanceViewInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Type { get; set; }

        public string TypeHandlerVersion { get; set; }

        public IList<SubstatuseInfo> Substatuses { get; set; }

        public IList<StatuseInfo> Statuses { get; set; }
    }

    public class SubstatuseInfo : PropertyBase
    {

        public string Code { get; set; }

        public string Level { get; set; }

        public string DisplayStatus { get; set; }

        public string Message { get; set; }

        public string Time { get; set; }
    }

    public class StatuseInfo : PropertyBase
    {

        public string Code { get; set; }

        public string Level { get; set; }

        public string DisplayStatus { get; set; }

        public string Message { get; set; }

        public string Time { get; set; }
    }

    public class VirtualMachine : Resource<VirtualMachineProperties>
    {
        public VirtualMachine() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachines", "2019-12-01");
        public VirtualMachine(string name) : this() => Name = name;
        public VirtualMachine(string name, Location location) : this() => (Name, Location) = (name, location);

        public PlanInfo Plan { get; set; }

        public IdentityInfo Identity { get; set; }

        public IList<string> Zones { get; set; }

        public VirtualMachine WithProperties(Action<VirtualMachineProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PlanInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Product { get; set; }

        public string PromotionCode { get; set; }
    }

    public class VirtualMachineProperties : PropertyBase
    {

        private HardwareProfileInfo _hardwareProfile;
        public HardwareProfileInfo HardwareProfile
        {
            get => _hardwareProfile = Get(_hardwareProfile);
            set => _hardwareProfile = value;
        }

        private StorageProfileInfo _storageProfile;
        public StorageProfileInfo StorageProfile
        {
            get => _storageProfile = Get(_storageProfile);
            set => _storageProfile = value;
        }

        private AdditionalCapabilitiesInfo _additionalCapabilities;
        public AdditionalCapabilitiesInfo AdditionalCapabilities
        {
            get => _additionalCapabilities = Get(_additionalCapabilities);
            set => _additionalCapabilities = value;
        }

        private OsProfileInfo _osProfile;
        public OsProfileInfo OsProfile
        {
            get => _osProfile = Get(_osProfile);
            set => _osProfile = value;
        }

        private NetworkProfileInfo _networkProfile;
        public NetworkProfileInfo NetworkProfile
        {
            get => _networkProfile = Get(_networkProfile);
            set => _networkProfile = value;
        }

        private DiagnosticsProfileInfo _diagnosticsProfile;
        public DiagnosticsProfileInfo DiagnosticsProfile
        {
            get => _diagnosticsProfile = Get(_diagnosticsProfile);
            set => _diagnosticsProfile = value;
        }

        private AvailabilitySetInfo _availabilitySet;
        public AvailabilitySetInfo AvailabilitySet
        {
            get => _availabilitySet = Get(_availabilitySet);
            set => _availabilitySet = value;
        }

        private VirtualMachineScaleSetInfo _virtualMachineScaleSet;
        public VirtualMachineScaleSetInfo VirtualMachineScaleSet
        {
            get => _virtualMachineScaleSet = Get(_virtualMachineScaleSet);
            set => _virtualMachineScaleSet = value;
        }

        private ProximityPlacementGroupInfo _proximityPlacementGroup;
        public ProximityPlacementGroupInfo ProximityPlacementGroup
        {
            get => _proximityPlacementGroup = Get(_proximityPlacementGroup);
            set => _proximityPlacementGroup = value;
        }

        public string Priority { get; set; }

        public string EvictionPolicy { get; set; }

        private BillingProfileInfo _billingProfile;
        public BillingProfileInfo BillingProfile
        {
            get => _billingProfile = Get(_billingProfile);
            set => _billingProfile = value;
        }

        private HostInfo _host;
        public HostInfo Host
        {
            get => _host = Get(_host);
            set => _host = value;
        }

        public string LicenseType { get; set; }
    }

    public class HardwareProfileInfo : PropertyBase
    {

        public string VmSize { get; set; }
    }

    public class EncryptionSettingsInfo : PropertyBase
    {

        private DiskEncryptionKeyInfo _diskEncryptionKey;
        public DiskEncryptionKeyInfo DiskEncryptionKey
        {
            get => _diskEncryptionKey = Get(_diskEncryptionKey);
            set => _diskEncryptionKey = value;
        }

        private KeyEncryptionKeyInfo _keyEncryptionKey;
        public KeyEncryptionKeyInfo KeyEncryptionKey
        {
            get => _keyEncryptionKey = Get(_keyEncryptionKey);
            set => _keyEncryptionKey = value;
        }

        public bool? Enabled { get; set; }
    }

    public class VhdInfo : PropertyBase
    {

        public string Uri { get; set; }
    }

    public class ImageInfo : PropertyBase
    {

        public string Uri { get; set; }
    }

    public class DiffDiskSettingsInfo : PropertyBase
    {

        public string Option { get; set; }

        public string Placement { get; set; }
    }

    public class DataDiskManagedDiskInfo : PropertyBase
    {

        public string Id { get; set; }

        public string StorageAccountType { get; set; }

        private DiskEncryptionSetInfo _diskEncryptionSet;
        public DiskEncryptionSetInfo DiskEncryptionSet
        {
            get => _diskEncryptionSet = Get(_diskEncryptionSet);
            set => _diskEncryptionSet = value;
        }
    }

    public class AdditionalCapabilitiesInfo : PropertyBase
    {

        public bool? UltraSSDEnabled { get; set; }
    }

    public class OsProfileInfo : PropertyBase
    {

        public string ComputerName { get; set; }

        public string AdminUsername { get; set; }

        public string AdminPassword { get; set; }

        public string CustomData { get; set; }

        private WindowsConfigurationInfo _windowsConfiguration;
        public WindowsConfigurationInfo WindowsConfiguration
        {
            get => _windowsConfiguration = Get(_windowsConfiguration);
            set => _windowsConfiguration = value;
        }

        private LinuxConfigurationInfo _linuxConfiguration;
        public LinuxConfigurationInfo LinuxConfiguration
        {
            get => _linuxConfiguration = Get(_linuxConfiguration);
            set => _linuxConfiguration = value;
        }

        public IList<SecretInfo> Secrets { get; set; }

        public bool? AllowExtensionOperations { get; set; }

        public bool? RequireGuestProvisionSignal { get; set; }
    }

    public class WindowsConfigurationInfo : PropertyBase
    {

        public bool? ProvisionVMAgent { get; set; }

        public bool? EnableAutomaticUpdates { get; set; }

        public string TimeZone { get; set; }

        public IList<AdditionalUnattendContentInfo> AdditionalUnattendContent { get; set; }

        private WinRMInfo _winRM;
        public WinRMInfo WinRM
        {
            get => _winRM = Get(_winRM);
            set => _winRM = value;
        }
    }

    public class AdditionalUnattendContentInfo : PropertyBase
    {

        public string PassName { get; set; }

        public string ComponentName { get; set; }

        public string SettingName { get; set; }

        public string Content { get; set; }
    }

    public class WinRMInfo : PropertyBase
    {

        public IList<ListenerInfo> Listeners { get; set; }
    }

    public class ListenerInfo : PropertyBase
    {

        public string Protocol { get; set; }

        public string CertificateUrl { get; set; }
    }

    public class LinuxConfigurationInfo : PropertyBase
    {

        public bool? DisablePasswordAuthentication { get; set; }

        private SshInfo _ssh;
        public SshInfo Ssh
        {
            get => _ssh = Get(_ssh);
            set => _ssh = value;
        }

        public bool? ProvisionVMAgent { get; set; }
    }

    public class SshInfo : PropertyBase
    {

        public IList<PublicKeyInfo> PublicKeys { get; set; }
    }

    public class PublicKeyInfo : PropertyBase
    {

        public string Path { get; set; }

        public string KeyData { get; set; }
    }

    public class SecretInfo : PropertyBase
    {

        private SourceVaultInfo _sourceVault;
        public SourceVaultInfo SourceVault
        {
            get => _sourceVault = Get(_sourceVault);
            set => _sourceVault = value;
        }

        public IList<VaultCertificateInfo> VaultCertificates { get; set; }
    }

    public class VaultCertificateInfo : PropertyBase
    {

        public string CertificateUrl { get; set; }

        public string CertificateStore { get; set; }
    }

    public class NetworkProfileInfo : PropertyBase
    {

        public IList<NetworkInterfaceInfo> NetworkInterfaces { get; set; }
    }

    public class NetworkInterfaceInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class PropertiesInfo : PropertyBase
    {

        public bool? Primary { get; set; }
    }

    public class DiagnosticsProfileInfo : PropertyBase
    {

        private BootDiagnosticsInfo _bootDiagnostics;
        public BootDiagnosticsInfo BootDiagnostics
        {
            get => _bootDiagnostics = Get(_bootDiagnostics);
            set => _bootDiagnostics = value;
        }
    }

    public class BootDiagnosticsInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string StorageUri { get; set; }
    }

    public class AvailabilitySetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VirtualMachineScaleSetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class BillingProfileInfo : PropertyBase
    {

        public string MaxPrice { get; set; }
    }

    public class HostInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VirtualMachineScaleSetExtension : Resource<VirtualMachineScaleSetExtensionProperties>
    {
        public VirtualMachineScaleSetExtension() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets/extensions", "2019-12-01");
        public VirtualMachineScaleSetExtension(string name) : this() => Name = name;
        public VirtualMachineScaleSetExtension(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualMachineScaleSetExtension WithProperties(Action<VirtualMachineScaleSetExtensionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualMachineScaleSetExtensionProperties : PropertyBase
    {

        public string Publisher { get; set; }

        public string Type { get; set; }

        public string TypeHandlerVersion { get; set; }

        public bool? AutoUpgradeMinorVersion { get; set; }

        public object Settings { get; set; }

        public object ProtectedSettings { get; set; }

        public IList<string> ProvisionAfterExtensions { get; set; }
    }

    public class VirtualMachineScaleSetVirtualMachineExtension : Resource<VirtualMachineScaleSetVirtualMachineExtensionProperties>
    {
        public VirtualMachineScaleSetVirtualMachineExtension() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets/virtualMachines/extensions", "2019-12-01");
        public VirtualMachineScaleSetVirtualMachineExtension(string name) : this() => Name = name;
        public VirtualMachineScaleSetVirtualMachineExtension(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualMachineScaleSetVirtualMachineExtension WithProperties(Action<VirtualMachineScaleSetVirtualMachineExtensionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualMachineScaleSetVirtualMachineExtensionProperties : PropertyBase
    {

        public string Publisher { get; set; }

        public string Type { get; set; }

        public string TypeHandlerVersion { get; set; }

        public bool? AutoUpgradeMinorVersion { get; set; }

        public object Settings { get; set; }

        public object ProtectedSettings { get; set; }

        private InstanceViewInfo _instanceView;
        public InstanceViewInfo InstanceView
        {
            get => _instanceView = Get(_instanceView);
            set => _instanceView = value;
        }
    }

    public class VirtualMachineScaleSetVirtualmachine : Resource<VirtualMachineScaleSetVirtualmachineProperties>
    {
        public VirtualMachineScaleSetVirtualmachine() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets/virtualmachines", "2019-12-01");
        public VirtualMachineScaleSetVirtualmachine(string name) : this() => Name = name;
        public VirtualMachineScaleSetVirtualmachine(string name, Location location) : this() => (Name, Location) = (name, location);

        public PlanInfo Plan { get; set; }

        public VirtualMachineScaleSetVirtualmachine WithProperties(Action<VirtualMachineScaleSetVirtualmachineProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualMachineScaleSetVirtualmachineProperties : PropertyBase
    {

        private HardwareProfileInfo _hardwareProfile;
        public HardwareProfileInfo HardwareProfile
        {
            get => _hardwareProfile = Get(_hardwareProfile);
            set => _hardwareProfile = value;
        }

        private StorageProfileInfo _storageProfile;
        public StorageProfileInfo StorageProfile
        {
            get => _storageProfile = Get(_storageProfile);
            set => _storageProfile = value;
        }

        private AdditionalCapabilitiesInfo _additionalCapabilities;
        public AdditionalCapabilitiesInfo AdditionalCapabilities
        {
            get => _additionalCapabilities = Get(_additionalCapabilities);
            set => _additionalCapabilities = value;
        }

        private OsProfileInfo _osProfile;
        public OsProfileInfo OsProfile
        {
            get => _osProfile = Get(_osProfile);
            set => _osProfile = value;
        }

        private NetworkProfileInfo _networkProfile;
        public NetworkProfileInfo NetworkProfile
        {
            get => _networkProfile = Get(_networkProfile);
            set => _networkProfile = value;
        }

        private NetworkProfileConfigurationInfo _networkProfileConfiguration;
        public NetworkProfileConfigurationInfo NetworkProfileConfiguration
        {
            get => _networkProfileConfiguration = Get(_networkProfileConfiguration);
            set => _networkProfileConfiguration = value;
        }

        private DiagnosticsProfileInfo _diagnosticsProfile;
        public DiagnosticsProfileInfo DiagnosticsProfile
        {
            get => _diagnosticsProfile = Get(_diagnosticsProfile);
            set => _diagnosticsProfile = value;
        }

        private AvailabilitySetInfo _availabilitySet;
        public AvailabilitySetInfo AvailabilitySet
        {
            get => _availabilitySet = Get(_availabilitySet);
            set => _availabilitySet = value;
        }

        public string LicenseType { get; set; }

        private ProtectionPolicyInfo _protectionPolicy;
        public ProtectionPolicyInfo ProtectionPolicy
        {
            get => _protectionPolicy = Get(_protectionPolicy);
            set => _protectionPolicy = value;
        }
    }

    public class NetworkProfileConfigurationInfo : PropertyBase
    {

        public IList<NetworkInterfaceConfigurationInfo> NetworkInterfaceConfigurations { get; set; }
    }

    public class NetworkInterfaceConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Name { get; set; }

        private NetworkInterfaceConfigurationPropertiesInfo _properties;
        public NetworkInterfaceConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class NetworkInterfaceConfigurationPropertiesInfo : PropertyBase
    {

        public bool? Primary { get; set; }

        public bool? EnableAcceleratedNetworking { get; set; }

        private NetworkSecurityGroupInfo _networkSecurityGroup;
        public NetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private DnsSettingsInfo _dnsSettings;
        public DnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        public IList<IpConfigurationInfo> IpConfigurations { get; set; }

        public bool? EnableIPForwarding { get; set; }
    }

    public class NetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class DnsSettingsInfo : PropertyBase
    {

        public IList<string> DnsServers { get; set; }
    }

    public class IpConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Name { get; set; }

        private IpConfigurationPropertiesInfo _properties;
        public IpConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class IpConfigurationPropertiesInfo : PropertyBase
    {

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        public bool? Primary { get; set; }

        private PublicIPAddressConfigurationInfo _publicIPAddressConfiguration;
        public PublicIPAddressConfigurationInfo PublicIPAddressConfiguration
        {
            get => _publicIPAddressConfiguration = Get(_publicIPAddressConfiguration);
            set => _publicIPAddressConfiguration = value;
        }

        public string PrivateIPAddressVersion { get; set; }

        public IList<ApplicationGatewayBackendAddressPoolInfo> ApplicationGatewayBackendAddressPools { get; set; }

        public IList<ApplicationSecurityGroupInfo> ApplicationSecurityGroups { get; set; }

        public IList<LoadBalancerBackendAddressPoolInfo> LoadBalancerBackendAddressPools { get; set; }

        public IList<LoadBalancerInboundNatPoolInfo> LoadBalancerInboundNatPools { get; set; }
    }

    public class SubnetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PublicIPAddressConfigurationInfo : PropertyBase
    {

        public string Name { get; set; }

        private PublicIPAddressConfigurationPropertiesInfo _properties;
        public PublicIPAddressConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class PublicIPAddressConfigurationPropertiesInfo : PropertyBase
    {

        public int? IdleTimeoutInMinutes { get; set; }

        private PublicIPAddressConfigurationPropertiesDnsSettingsInfo _dnsSettings;
        public PublicIPAddressConfigurationPropertiesDnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        public IList<IpTagInfo> IpTags { get; set; }

        private PublicIPPrefixInfo _publicIPPrefix;
        public PublicIPPrefixInfo PublicIPPrefix
        {
            get => _publicIPPrefix = Get(_publicIPPrefix);
            set => _publicIPPrefix = value;
        }

        public string PublicIPAddressVersion { get; set; }
    }

    public class PublicIPAddressConfigurationPropertiesDnsSettingsInfo : PropertyBase
    {

        public string DomainNameLabel { get; set; }
    }

    public class IpTagInfo : PropertyBase
    {

        public string IpTagType { get; set; }

        public string Tag { get; set; }
    }

    public class PublicIPPrefixInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ApplicationGatewayBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class LoadBalancerBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class LoadBalancerInboundNatPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ProtectionPolicyInfo : PropertyBase
    {

        public bool? ProtectFromScaleIn { get; set; }

        public bool? ProtectFromScaleSetActions { get; set; }
    }

    public class VirtualMachineScaleSet : Resource<VirtualMachineScaleSetProperties>
    {
        public VirtualMachineScaleSet() => (Type, ApiVersion) = ("Microsoft.Compute/virtualMachineScaleSets", "2019-12-01");
        public VirtualMachineScaleSet(string name) : this() => Name = name;
        public VirtualMachineScaleSet(string name, Location location) : this() => (Name, Location) = (name, location);

        public PlanInfo Plan { get; set; }

        public IdentityInfo Identity { get; set; }

        public IList<string> Zones { get; set; }

        public VirtualMachineScaleSet WithProperties(Action<VirtualMachineScaleSetProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualMachineScaleSetProperties : PropertyBase
    {

        private UpgradePolicyInfo _upgradePolicy;
        public UpgradePolicyInfo UpgradePolicy
        {
            get => _upgradePolicy = Get(_upgradePolicy);
            set => _upgradePolicy = value;
        }

        private AutomaticRepairsPolicyInfo _automaticRepairsPolicy;
        public AutomaticRepairsPolicyInfo AutomaticRepairsPolicy
        {
            get => _automaticRepairsPolicy = Get(_automaticRepairsPolicy);
            set => _automaticRepairsPolicy = value;
        }

        private VirtualMachineProfileInfo _virtualMachineProfile;
        public VirtualMachineProfileInfo VirtualMachineProfile
        {
            get => _virtualMachineProfile = Get(_virtualMachineProfile);
            set => _virtualMachineProfile = value;
        }

        public bool? Overprovision { get; set; }

        public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

        public bool? SinglePlacementGroup { get; set; }

        public bool? ZoneBalance { get; set; }

        public int? PlatformFaultDomainCount { get; set; }

        private ProximityPlacementGroupInfo _proximityPlacementGroup;
        public ProximityPlacementGroupInfo ProximityPlacementGroup
        {
            get => _proximityPlacementGroup = Get(_proximityPlacementGroup);
            set => _proximityPlacementGroup = value;
        }

        private AdditionalCapabilitiesInfo _additionalCapabilities;
        public AdditionalCapabilitiesInfo AdditionalCapabilities
        {
            get => _additionalCapabilities = Get(_additionalCapabilities);
            set => _additionalCapabilities = value;
        }

        private ScaleInPolicyInfo _scaleInPolicy;
        public ScaleInPolicyInfo ScaleInPolicy
        {
            get => _scaleInPolicy = Get(_scaleInPolicy);
            set => _scaleInPolicy = value;
        }
    }

    public class UpgradePolicyInfo : PropertyBase
    {

        public string Mode { get; set; }

        private RollingUpgradePolicyInfo _rollingUpgradePolicy;
        public RollingUpgradePolicyInfo RollingUpgradePolicy
        {
            get => _rollingUpgradePolicy = Get(_rollingUpgradePolicy);
            set => _rollingUpgradePolicy = value;
        }

        private AutomaticOSUpgradePolicyInfo _automaticOSUpgradePolicy;
        public AutomaticOSUpgradePolicyInfo AutomaticOSUpgradePolicy
        {
            get => _automaticOSUpgradePolicy = Get(_automaticOSUpgradePolicy);
            set => _automaticOSUpgradePolicy = value;
        }
    }

    public class RollingUpgradePolicyInfo : PropertyBase
    {

        public int? MaxBatchInstancePercent { get; set; }

        public int? MaxUnhealthyInstancePercent { get; set; }

        public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

        public string PauseTimeBetweenBatches { get; set; }
    }

    public class AutomaticOSUpgradePolicyInfo : PropertyBase
    {

        public bool? EnableAutomaticOSUpgrade { get; set; }

        public bool? DisableAutomaticRollback { get; set; }
    }

    public class AutomaticRepairsPolicyInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string GracePeriod { get; set; }
    }

    public class VirtualMachineProfileInfo : PropertyBase
    {

        private OsProfileInfo _osProfile;
        public OsProfileInfo OsProfile
        {
            get => _osProfile = Get(_osProfile);
            set => _osProfile = value;
        }

        private StorageProfileInfo _storageProfile;
        public StorageProfileInfo StorageProfile
        {
            get => _storageProfile = Get(_storageProfile);
            set => _storageProfile = value;
        }

        private NetworkProfileInfo _networkProfile;
        public NetworkProfileInfo NetworkProfile
        {
            get => _networkProfile = Get(_networkProfile);
            set => _networkProfile = value;
        }

        private DiagnosticsProfileInfo _diagnosticsProfile;
        public DiagnosticsProfileInfo DiagnosticsProfile
        {
            get => _diagnosticsProfile = Get(_diagnosticsProfile);
            set => _diagnosticsProfile = value;
        }

        private ExtensionProfileInfo _extensionProfile;
        public ExtensionProfileInfo ExtensionProfile
        {
            get => _extensionProfile = Get(_extensionProfile);
            set => _extensionProfile = value;
        }

        public string LicenseType { get; set; }

        public string Priority { get; set; }

        public string EvictionPolicy { get; set; }

        private BillingProfileInfo _billingProfile;
        public BillingProfileInfo BillingProfile
        {
            get => _billingProfile = Get(_billingProfile);
            set => _billingProfile = value;
        }

        private ScheduledEventsProfileInfo _scheduledEventsProfile;
        public ScheduledEventsProfileInfo ScheduledEventsProfile
        {
            get => _scheduledEventsProfile = Get(_scheduledEventsProfile);
            set => _scheduledEventsProfile = value;
        }
    }

    public class HealthProbeInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ExtensionProfileInfo : PropertyBase
    {

        public IList<ExtensionInfo> Extensions { get; set; }
    }

    public class ExtensionInfo : PropertyBase
    {

        public string Name { get; set; }

        private ExtensionPropertiesInfo _properties;
        public ExtensionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class ExtensionPropertiesInfo : PropertyBase
    {

        public string Publisher { get; set; }

        public string Type { get; set; }

        public string TypeHandlerVersion { get; set; }

        public bool? AutoUpgradeMinorVersion { get; set; }

        public object Settings { get; set; }

        public object ProtectedSettings { get; set; }

        public IList<string> ProvisionAfterExtensions { get; set; }
    }

    public class ScheduledEventsProfileInfo : PropertyBase
    {

        private TerminateNotificationProfileInfo _terminateNotificationProfile;
        public TerminateNotificationProfileInfo TerminateNotificationProfile
        {
            get => _terminateNotificationProfile = Get(_terminateNotificationProfile);
            set => _terminateNotificationProfile = value;
        }
    }

    public class TerminateNotificationProfileInfo : PropertyBase
    {

        public string NotBeforeTimeout { get; set; }

        public bool? Enable { get; set; }
    }

    public class ScaleInPolicyInfo : PropertyBase
    {

        public IList<string> Rules { get; set; }
    }
}
