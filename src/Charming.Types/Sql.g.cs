namespace Charming.Types.Sql
{
    using Charming;
    using System.Collections.Generic;

    public partial class InstancePool : Resource<InstancePoolProperties>
    {
        public InstancePool() => (Type, ApiVersion) = ("Microsoft.Sql/instancePools", "2018-06-01-preview");
        public InstancePool(string name) : this() => Name = name;
        public InstancePool(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class InstancePoolProperties
    {
        public string SubnetId { get; set; }
        public int? VCores { get; set; }
        public string LicenseType { get; set; }
    }

    public partial class LocationInstanceFailoverGroup : Resource<LocationInstanceFailoverGroupProperties>
    {
        public LocationInstanceFailoverGroup() => (Type, ApiVersion) = ("Microsoft.Sql/locations/instanceFailoverGroups", "2017-10-01-preview");
        public LocationInstanceFailoverGroup(string name) : this() => Name = name;
        public LocationInstanceFailoverGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class LocationInstanceFailoverGroupProperties
    {
        public ReadWriteEndpointInfo ReadWriteEndpoint { get; set; }
        public ReadOnlyEndpointInfo ReadOnlyEndpoint { get; set; }
        public IList<PartnerRegionInfo> PartnerRegions { get; set; }
        public IList<ManagedInstancePairInfo> ManagedInstancePairs { get; set; }
    }

    public partial class ReadWriteEndpointInfo
    {
        public string FailoverPolicy { get; set; }
        public int? FailoverWithDataLossGracePeriodMinutes { get; set; }
    }

    public partial class ReadOnlyEndpointInfo
    {
        public string FailoverPolicy { get; set; }
    }

    public partial class PartnerRegionInfo
    {
        public string Location { get; set; }
    }

    public partial class ManagedInstancePairInfo
    {
        public string PrimaryManagedInstanceId { get; set; }
        public string PartnerManagedInstanceId { get; set; }
    }

    public partial class ManagedInstanceAdministrator : Resource<ManagedInstanceAdministratorProperties>
    {
        public ManagedInstanceAdministrator() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/administrators", "2017-03-01-preview");
        public ManagedInstanceAdministrator(string name) : this() => Name = name;
        public ManagedInstanceAdministrator(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceAdministratorProperties
    {
        public string AdministratorType { get; set; }
        public string Login { get; set; }
        public string Sid { get; set; }
        public string TenantId { get; set; }
    }

    public partial class ManagedInstanceDatabaseBackupLongTermRetentionPolicy : Resource<ManagedInstanceDatabaseBackupLongTermRetentionPolicyProperties>
    {
        public ManagedInstanceDatabaseBackupLongTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/backupLongTermRetentionPolicies", "2018-06-01-preview");
        public ManagedInstanceDatabaseBackupLongTermRetentionPolicy(string name) : this() => Name = name;
        public ManagedInstanceDatabaseBackupLongTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceDatabaseBackupLongTermRetentionPolicyProperties
    {
        public string WeeklyRetention { get; set; }
        public string MonthlyRetention { get; set; }
        public string YearlyRetention { get; set; }
        public int? WeekOfYear { get; set; }
    }

    public partial class ManagedInstanceDatabaseBackupShortTermRetentionPolicy : Resource<ManagedInstanceDatabaseBackupShortTermRetentionPolicyProperties>
    {
        public ManagedInstanceDatabaseBackupShortTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/backupShortTermRetentionPolicies", "2017-03-01-preview");
        public ManagedInstanceDatabaseBackupShortTermRetentionPolicy(string name) : this() => Name = name;
        public ManagedInstanceDatabaseBackupShortTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceDatabaseBackupShortTermRetentionPolicyProperties
    {
        public int? RetentionDays { get; set; }
    }

    public partial class ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel : Resource<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelProperties>
    {
        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/schemas/tables/columns/sensitivityLabels", "2018-06-01-preview");
        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(string name) : this() => Name = name;
        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelProperties
    {
        public string LabelName { get; set; }
        public string LabelId { get; set; }
        public string InformationType { get; set; }
        public string InformationTypeId { get; set; }
        public string Rank { get; set; }
    }

    public partial class ManagedInstanceDatabaseSecurityAlertPolicy : Resource<ManagedInstanceDatabaseSecurityAlertPolicyProperties>
    {
        public ManagedInstanceDatabaseSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/securityAlertPolicies", "2017-03-01-preview");
        public ManagedInstanceDatabaseSecurityAlertPolicy(string name) : this() => Name = name;
        public ManagedInstanceDatabaseSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceDatabaseSecurityAlertPolicyProperties
    {
        public string State { get; set; }
        public IList<string> DisabledAlerts { get; set; }
        public IList<string> EmailAddresses { get; set; }
        public bool? EmailAccountAdmins { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
    }

    public partial class ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline : Resource<ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaselineProperties>
    {
        public ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/vulnerabilityAssessments/rules/baselines", "2017-10-01-preview");
        public ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline(string name) : this() => Name = name;
        public ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaselineProperties
    {
        public IList<BaselineResultInfo> BaselineResults { get; set; }
    }

    public partial class BaselineResultInfo
    {
        public IList<string> Result { get; set; }
    }

    public partial class ManagedInstanceDatabaseVulnerabilityAssessment : Resource<ManagedInstanceDatabaseVulnerabilityAssessmentProperties>
    {
        public ManagedInstanceDatabaseVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/vulnerabilityAssessments", "2017-10-01-preview");
        public ManagedInstanceDatabaseVulnerabilityAssessment(string name) : this() => Name = name;
        public ManagedInstanceDatabaseVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceDatabaseVulnerabilityAssessmentProperties
    {
        public string StorageContainerPath { get; set; }
        public string StorageContainerSasKey { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public RecurringScansInfo RecurringScans { get; set; }
    }

    public partial class RecurringScansInfo
    {
        public bool? IsEnabled { get; set; }
        public bool? EmailSubscriptionAdmins { get; set; }
        public IList<string> Emails { get; set; }
    }

    public partial class ManagedInstanceDatabase : Resource<ManagedInstanceDatabaseProperties>
    {
        public ManagedInstanceDatabase() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases", "2019-06-01-preview");
        public ManagedInstanceDatabase(string name) : this() => Name = name;
        public ManagedInstanceDatabase(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceDatabaseProperties
    {
        public string Collation { get; set; }
        public string RestorePointInTime { get; set; }
        public string CatalogCollation { get; set; }
        public string CreateMode { get; set; }
        public string StorageContainerUri { get; set; }
        public string SourceDatabaseId { get; set; }
        public string RestorableDroppedDatabaseId { get; set; }
        public string StorageContainerSasToken { get; set; }
        public string RecoverableDatabaseId { get; set; }
        public string LongTermRetentionBackupResourceId { get; set; }
    }

    public partial class ManagedInstanceEncryptionProtector : Resource<ManagedInstanceEncryptionProtectorProperties>
    {
        public ManagedInstanceEncryptionProtector() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/encryptionProtector", "2017-10-01-preview");
        public ManagedInstanceEncryptionProtector(string name) : this() => Name = name;
        public ManagedInstanceEncryptionProtector(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceEncryptionProtectorProperties
    {
        public string ServerKeyName { get; set; }
        public string ServerKeyType { get; set; }
    }

    public partial class ManagedInstanceKey : Resource<ManagedInstanceKeyProperties>
    {
        public ManagedInstanceKey() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/keys", "2017-10-01-preview");
        public ManagedInstanceKey(string name) : this() => Name = name;
        public ManagedInstanceKey(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceKeyProperties
    {
        public string ServerKeyType { get; set; }
        public string Uri { get; set; }
    }

    public partial class ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy : Resource<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyProperties>
    {
        public ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/restorableDroppedDatabases/backupShortTermRetentionPolicies", "2017-03-01-preview");
        public ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(string name) : this() => Name = name;
        public ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyProperties
    {
        public int? RetentionDays { get; set; }
    }

    public partial class ManagedInstanceSecurityAlertPolicy : Resource<ManagedInstanceSecurityAlertPolicyProperties>
    {
        public ManagedInstanceSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/securityAlertPolicies", "2017-03-01-preview");
        public ManagedInstanceSecurityAlertPolicy(string name) : this() => Name = name;
        public ManagedInstanceSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceSecurityAlertPolicyProperties
    {
        public string State { get; set; }
        public IList<string> DisabledAlerts { get; set; }
        public IList<string> EmailAddresses { get; set; }
        public bool? EmailAccountAdmins { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
    }

    public partial class ManagedInstanceVulnerabilityAssessment : Resource<ManagedInstanceVulnerabilityAssessmentProperties>
    {
        public ManagedInstanceVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/vulnerabilityAssessments", "2018-06-01-preview");
        public ManagedInstanceVulnerabilityAssessment(string name) : this() => Name = name;
        public ManagedInstanceVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ManagedInstanceVulnerabilityAssessmentProperties
    {
        public string StorageContainerPath { get; set; }
        public string StorageContainerSasKey { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public RecurringScansInfo RecurringScans { get; set; }
    }

    public partial class ManagedInstance : Resource<ManagedInstanceProperties>
    {
        public ManagedInstance() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances", "2018-06-01-preview");
        public ManagedInstance(string name) : this() => Name = name;
        public ManagedInstance(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class IdentityInfo
    {
        public string Type { get; set; }
    }

    public partial class ManagedInstanceProperties
    {
        public string ManagedInstanceCreateMode { get; set; }
        public string AdministratorLogin { get; set; }
        public string AdministratorLoginPassword { get; set; }
        public string SubnetId { get; set; }
        public string LicenseType { get; set; }
        public int? VCores { get; set; }
        public int? StorageSizeInGB { get; set; }
        public string Collation { get; set; }
        public string DnsZonePartner { get; set; }
        public bool? PublicDataEndpointEnabled { get; set; }
        public string SourceManagedInstanceId { get; set; }
        public string RestorePointInTime { get; set; }
        public string ProxyOverride { get; set; }
        public string TimezoneId { get; set; }
        public string InstancePoolId { get; set; }
        public string MinimalTlsVersion { get; set; }
    }

    public partial class ServerAdministrator : Resource<ServerAdministratorProperties>
    {
        public ServerAdministrator() => (Type, ApiVersion) = ("Microsoft.Sql/servers/administrators", "2019-06-01-preview");
        public ServerAdministrator(string name) : this() => Name = name;
        public ServerAdministrator(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerAdministratorProperties
    {
        public string AdministratorType { get; set; }
        public string Login { get; set; }
        public string Sid { get; set; }
        public string TenantId { get; set; }
        public bool? AzureADOnlyAuthentication { get; set; }
    }

    public partial class ServerAuditingSetting : Resource<ServerAuditingSettingProperties>
    {
        public ServerAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/auditingSettings", "2017-03-01-preview");
        public ServerAuditingSetting(string name) : this() => Name = name;
        public ServerAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerAuditingSettingProperties
    {
        public string State { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
        public IList<string> AuditActionsAndGroups { get; set; }
        public string StorageAccountSubscriptionId { get; set; }
        public bool? IsStorageSecondaryKeyInUse { get; set; }
        public bool? IsAzureMonitorTargetEnabled { get; set; }
        public int? QueueDelayMs { get; set; }
    }

    public partial class ServerBackupLongTermRetentionVault : Resource<ServerBackupLongTermRetentionVaultProperties>
    {
        public ServerBackupLongTermRetentionVault() => (Type, ApiVersion) = ("Microsoft.Sql/servers/backupLongTermRetentionVaults", "2014-04-01");
        public ServerBackupLongTermRetentionVault(string name) : this() => Name = name;
        public ServerBackupLongTermRetentionVault(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerBackupLongTermRetentionVaultProperties
    {
        public string RecoveryServicesVaultResourceId { get; set; }
    }

    public partial class ServerCommunicationLink : Resource<ServerCommunicationLinkProperties>
    {
        public ServerCommunicationLink() => (Type, ApiVersion) = ("Microsoft.Sql/servers/communicationLinks", "2014-04-01");
        public ServerCommunicationLink(string name) : this() => Name = name;
        public ServerCommunicationLink(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerCommunicationLinkProperties
    {
        public string PartnerServer { get; set; }
    }

    public partial class ServerConnectionPolicy : Resource<ServerConnectionPolicyProperties>
    {
        public ServerConnectionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/connectionPolicies", "2014-04-01");
        public ServerConnectionPolicy(string name) : this() => Name = name;
        public ServerConnectionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerConnectionPolicyProperties
    {
        public string ConnectionType { get; set; }
    }

    public partial class ServerDatabaseAuditingSetting : Resource<ServerDatabaseAuditingSettingProperties>
    {
        public ServerDatabaseAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/auditingSettings", "2017-03-01-preview");
        public ServerDatabaseAuditingSetting(string name) : this() => Name = name;
        public ServerDatabaseAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseAuditingSettingProperties
    {
        public string State { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
        public IList<string> AuditActionsAndGroups { get; set; }
        public string StorageAccountSubscriptionId { get; set; }
        public bool? IsStorageSecondaryKeyInUse { get; set; }
        public bool? IsAzureMonitorTargetEnabled { get; set; }
        public int? QueueDelayMs { get; set; }
    }

    public partial class ServerDatabaseBackupLongTermRetentionPolicy : Resource<ServerDatabaseBackupLongTermRetentionPolicyProperties>
    {
        public ServerDatabaseBackupLongTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/backupLongTermRetentionPolicies", "2017-03-01-preview");
        public ServerDatabaseBackupLongTermRetentionPolicy(string name) : this() => Name = name;
        public ServerDatabaseBackupLongTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseBackupLongTermRetentionPolicyProperties
    {
        public string WeeklyRetention { get; set; }
        public string MonthlyRetention { get; set; }
        public string YearlyRetention { get; set; }
        public int? WeekOfYear { get; set; }
    }

    public partial class ServerDatabaseBackupShortTermRetentionPolicy : Resource<ServerDatabaseBackupShortTermRetentionPolicyProperties>
    {
        public ServerDatabaseBackupShortTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/backupShortTermRetentionPolicies", "2017-10-01-preview");
        public ServerDatabaseBackupShortTermRetentionPolicy(string name) : this() => Name = name;
        public ServerDatabaseBackupShortTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseBackupShortTermRetentionPolicyProperties
    {
        public int? RetentionDays { get; set; }
    }

    public partial class ServerDatabaseConnectionPolicy : Resource<ServerDatabaseConnectionPolicyProperties>
    {
        public ServerDatabaseConnectionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/connectionPolicies", "2014-04-01");
        public ServerDatabaseConnectionPolicy(string name) : this() => Name = name;
        public ServerDatabaseConnectionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseConnectionPolicyProperties
    {
        public string SecurityEnabledAccess { get; set; }
        public string ProxyDnsName { get; set; }
        public string ProxyPort { get; set; }
        public string Visibility { get; set; }
        public string UseServerDefault { get; set; }
        public string RedirectionState { get; set; }
        public string State { get; set; }
    }

    public partial class ServerDatabaseDataMaskingPolicyRule : Resource<ServerDatabaseDataMaskingPolicyRuleProperties>
    {
        public ServerDatabaseDataMaskingPolicyRule() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/dataMaskingPolicies/rules", "2014-04-01");
        public ServerDatabaseDataMaskingPolicyRule(string name) : this() => Name = name;
        public ServerDatabaseDataMaskingPolicyRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseDataMaskingPolicyRuleProperties
    {
        public string AliasName { get; set; }
        public string RuleState { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string MaskingFunction { get; set; }
        public string NumberFrom { get; set; }
        public string NumberTo { get; set; }
        public string PrefixSize { get; set; }
        public string SuffixSize { get; set; }
        public string ReplacementString { get; set; }
    }

    public partial class ServerDatabaseDataMaskingPolicy : Resource<ServerDatabaseDataMaskingPolicyProperties>
    {
        public ServerDatabaseDataMaskingPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/dataMaskingPolicies", "2014-04-01");
        public ServerDatabaseDataMaskingPolicy(string name) : this() => Name = name;
        public ServerDatabaseDataMaskingPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseDataMaskingPolicyProperties
    {
        public string DataMaskingState { get; set; }
        public string ExemptPrincipals { get; set; }
    }

    public partial class ServerDatabaseExtendedAuditingSetting : Resource<ServerDatabaseExtendedAuditingSettingProperties>
    {
        public ServerDatabaseExtendedAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/extendedAuditingSettings", "2017-03-01-preview");
        public ServerDatabaseExtendedAuditingSetting(string name) : this() => Name = name;
        public ServerDatabaseExtendedAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseExtendedAuditingSettingProperties
    {
        public string PredicateExpression { get; set; }
        public string State { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
        public IList<string> AuditActionsAndGroups { get; set; }
        public string StorageAccountSubscriptionId { get; set; }
        public bool? IsStorageSecondaryKeyInUse { get; set; }
        public bool? IsAzureMonitorTargetEnabled { get; set; }
        public int? QueueDelayMs { get; set; }
    }

    public partial class ServerDatabaseExtension : Resource<ServerDatabaseExtensionProperties>
    {
        public ServerDatabaseExtension() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/extensions", "2014-04-01");
        public ServerDatabaseExtension(string name) : this() => Name = name;
        public ServerDatabaseExtension(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseExtensionProperties
    {
        public string StorageKeyType { get; set; }
        public string StorageKey { get; set; }
        public string StorageUri { get; set; }
        public string AdministratorLogin { get; set; }
        public string AdministratorLoginPassword { get; set; }
        public string AuthenticationType { get; set; }
        public string OperationMode { get; set; }
    }

    public partial class ServerDatabaseGeoBackupPolicy : Resource<ServerDatabaseGeoBackupPolicyProperties>
    {
        public ServerDatabaseGeoBackupPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/geoBackupPolicies", "2014-04-01");
        public ServerDatabaseGeoBackupPolicy(string name) : this() => Name = name;
        public ServerDatabaseGeoBackupPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseGeoBackupPolicyProperties
    {
        public string State { get; set; }
    }

    public partial class ServerDatabaseSchemaTableColumnSensitivityLabel : Resource<ServerDatabaseSchemaTableColumnSensitivityLabelProperties>
    {
        public ServerDatabaseSchemaTableColumnSensitivityLabel() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/schemas/tables/columns/sensitivityLabels", "2017-03-01-preview");
        public ServerDatabaseSchemaTableColumnSensitivityLabel(string name) : this() => Name = name;
        public ServerDatabaseSchemaTableColumnSensitivityLabel(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseSchemaTableColumnSensitivityLabelProperties
    {
        public string LabelName { get; set; }
        public string LabelId { get; set; }
        public string InformationType { get; set; }
        public string InformationTypeId { get; set; }
        public string Rank { get; set; }
    }

    public partial class ServerDatabaseSecurityAlertPolicy : Resource<ServerDatabaseSecurityAlertPolicyProperties>
    {
        public ServerDatabaseSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/securityAlertPolicies", "2018-06-01-preview");
        public ServerDatabaseSecurityAlertPolicy(string name) : this() => Name = name;
        public ServerDatabaseSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseSecurityAlertPolicyProperties
    {
        public string State { get; set; }
        public IList<string> DisabledAlerts { get; set; }
        public IList<string> EmailAddresses { get; set; }
        public bool? EmailAccountAdmins { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
    }

    public partial class ServerDatabaseSyncGroupSyncMember : Resource<ServerDatabaseSyncGroupSyncMemberProperties>
    {
        public ServerDatabaseSyncGroupSyncMember() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/syncGroups/syncMembers", "2015-05-01-preview");
        public ServerDatabaseSyncGroupSyncMember(string name) : this() => Name = name;
        public ServerDatabaseSyncGroupSyncMember(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseSyncGroupSyncMemberProperties
    {
        public string DatabaseType { get; set; }
        public string SyncAgentId { get; set; }
        public string SqlServerDatabaseId { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SyncDirection { get; set; }
    }

    public partial class ServerDatabaseSyncGroup : Resource<ServerDatabaseSyncGroupProperties>
    {
        public ServerDatabaseSyncGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/syncGroups", "2015-05-01-preview");
        public ServerDatabaseSyncGroup(string name) : this() => Name = name;
        public ServerDatabaseSyncGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseSyncGroupProperties
    {
        public int? Interval { get; set; }
        public string ConflictResolutionPolicy { get; set; }
        public string SyncDatabaseId { get; set; }
        public string HubDatabaseUserName { get; set; }
        public string HubDatabasePassword { get; set; }
        public SchemaInfo Schema { get; set; }
    }

    public partial class SchemaInfo
    {
        public IList<TableInfo> Tables { get; set; }
        public string MasterSyncMemberName { get; set; }
    }

    public partial class TableInfo
    {
        public IList<ColumnInfo> Columns { get; set; }
        public string QuotedName { get; set; }
    }

    public partial class ColumnInfo
    {
        public string QuotedName { get; set; }
        public string DataSize { get; set; }
        public string DataType { get; set; }
    }

    public partial class ServerDatabaseTransparentDataEncryption : Resource<ServerDatabaseTransparentDataEncryptionProperties>
    {
        public ServerDatabaseTransparentDataEncryption() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/transparentDataEncryption", "2014-04-01");
        public ServerDatabaseTransparentDataEncryption(string name) : this() => Name = name;
        public ServerDatabaseTransparentDataEncryption(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseTransparentDataEncryptionProperties
    {
        public string Status { get; set; }
    }

    public partial class ServerDatabaseVulnerabilityAssessmentRuleBaseline : Resource<ServerDatabaseVulnerabilityAssessmentRuleBaselineProperties>
    {
        public ServerDatabaseVulnerabilityAssessmentRuleBaseline() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/vulnerabilityAssessments/rules/baselines", "2017-03-01-preview");
        public ServerDatabaseVulnerabilityAssessmentRuleBaseline(string name) : this() => Name = name;
        public ServerDatabaseVulnerabilityAssessmentRuleBaseline(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseVulnerabilityAssessmentRuleBaselineProperties
    {
        public IList<BaselineResultInfo> BaselineResults { get; set; }
    }

    public partial class ServerDatabaseVulnerabilityAssessment : Resource<ServerDatabaseVulnerabilityAssessmentProperties>
    {
        public ServerDatabaseVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/vulnerabilityAssessments", "2017-03-01-preview");
        public ServerDatabaseVulnerabilityAssessment(string name) : this() => Name = name;
        public ServerDatabaseVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseVulnerabilityAssessmentProperties
    {
        public string StorageContainerPath { get; set; }
        public string StorageContainerSasKey { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public RecurringScansInfo RecurringScans { get; set; }
    }

    public partial class ServerDatabaseWorkloadGroupWorkloadClassifier : Resource<ServerDatabaseWorkloadGroupWorkloadClassifierProperties>
    {
        public ServerDatabaseWorkloadGroupWorkloadClassifier() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/workloadGroups/workloadClassifiers", "2019-06-01-preview");
        public ServerDatabaseWorkloadGroupWorkloadClassifier(string name) : this() => Name = name;
        public ServerDatabaseWorkloadGroupWorkloadClassifier(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseWorkloadGroupWorkloadClassifierProperties
    {
        public string MemberName { get; set; }
        public string Label { get; set; }
        public string Context { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Importance { get; set; }
    }

    public partial class ServerDatabaseWorkloadGroup : Resource<ServerDatabaseWorkloadGroupProperties>
    {
        public ServerDatabaseWorkloadGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/workloadGroups", "2019-06-01-preview");
        public ServerDatabaseWorkloadGroup(string name) : this() => Name = name;
        public ServerDatabaseWorkloadGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseWorkloadGroupProperties
    {
        public int? MinResourcePercent { get; set; }
        public int? MaxResourcePercent { get; set; }
        public string MinResourcePercentPerRequest { get; set; }
        public string MaxResourcePercentPerRequest { get; set; }
        public string Importance { get; set; }
        public int? QueryExecutionTimeout { get; set; }
    }

    public partial class ServerDatabase : Resource<ServerDatabaseProperties>
    {
        public ServerDatabase() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases", "2019-06-01-preview");
        public ServerDatabase(string name) : this() => Name = name;
        public ServerDatabase(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerDatabaseProperties
    {
        public string CreateMode { get; set; }
        public string Collation { get; set; }
        public int? MaxSizeBytes { get; set; }
        public string SampleName { get; set; }
        public string ElasticPoolId { get; set; }
        public string SourceDatabaseId { get; set; }
        public string RestorePointInTime { get; set; }
        public string SourceDatabaseDeletionDate { get; set; }
        public string RecoveryServicesRecoveryPointId { get; set; }
        public string LongTermRetentionBackupResourceId { get; set; }
        public string RecoverableDatabaseId { get; set; }
        public string RestorableDroppedDatabaseId { get; set; }
        public string CatalogCollation { get; set; }
        public bool? ZoneRedundant { get; set; }
        public string LicenseType { get; set; }
        public string ReadScale { get; set; }
        public int? ReadReplicaCount { get; set; }
        public int? AutoPauseDelay { get; set; }
        public string StorageAccountType { get; set; }
        public string MinCapacity { get; set; }
    }

    public partial class ServerElasticPool : Resource<ServerElasticPoolProperties>
    {
        public ServerElasticPool() => (Type, ApiVersion) = ("Microsoft.Sql/servers/elasticPools", "2017-10-01-preview");
        public ServerElasticPool(string name) : this() => Name = name;
        public ServerElasticPool(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerElasticPoolProperties
    {
        public int? MaxSizeBytes { get; set; }
        public PerDatabaseSettingsInfo PerDatabaseSettings { get; set; }
        public bool? ZoneRedundant { get; set; }
        public string LicenseType { get; set; }
    }

    public partial class PerDatabaseSettingsInfo
    {
        public string MinCapacity { get; set; }
        public string MaxCapacity { get; set; }
    }

    public partial class ServerEncryptionProtector : Resource<ServerEncryptionProtectorProperties>
    {
        public ServerEncryptionProtector() => (Type, ApiVersion) = ("Microsoft.Sql/servers/encryptionProtector", "2015-05-01-preview");
        public ServerEncryptionProtector(string name) : this() => Name = name;
        public ServerEncryptionProtector(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerEncryptionProtectorProperties
    {
        public string ServerKeyName { get; set; }
        public string ServerKeyType { get; set; }
    }

    public partial class ServerExtendedAuditingSetting : Resource<ServerExtendedAuditingSettingProperties>
    {
        public ServerExtendedAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/extendedAuditingSettings", "2017-03-01-preview");
        public ServerExtendedAuditingSetting(string name) : this() => Name = name;
        public ServerExtendedAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerExtendedAuditingSettingProperties
    {
        public string PredicateExpression { get; set; }
        public string State { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
        public IList<string> AuditActionsAndGroups { get; set; }
        public string StorageAccountSubscriptionId { get; set; }
        public bool? IsStorageSecondaryKeyInUse { get; set; }
        public bool? IsAzureMonitorTargetEnabled { get; set; }
        public int? QueueDelayMs { get; set; }
    }

    public partial class ServerFailoverGroup : Resource<ServerFailoverGroupProperties>
    {
        public ServerFailoverGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/failoverGroups", "2015-05-01-preview");
        public ServerFailoverGroup(string name) : this() => Name = name;
        public ServerFailoverGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerFailoverGroupProperties
    {
        public ReadWriteEndpointInfo ReadWriteEndpoint { get; set; }
        public ReadOnlyEndpointInfo ReadOnlyEndpoint { get; set; }
        public IList<PartnerServerInfo> PartnerServers { get; set; }
        public IList<string> Databases { get; set; }
    }

    public partial class PartnerServerInfo
    {
        public string Id { get; set; }
    }

    public partial class ServerFirewallRule : Resource<ServerFirewallRuleProperties>
    {
        public ServerFirewallRule() => (Type, ApiVersion) = ("Microsoft.Sql/servers/firewallRules", "2015-05-01-preview");
        public ServerFirewallRule(string name) : this() => Name = name;
        public ServerFirewallRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerFirewallRuleProperties
    {
        public string StartIpAddress { get; set; }
        public string EndIpAddress { get; set; }
    }

    public partial class ServerJobAgentCredential : Resource<ServerJobAgentCredentialProperties>
    {
        public ServerJobAgentCredential() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/credentials", "2017-03-01-preview");
        public ServerJobAgentCredential(string name) : this() => Name = name;
        public ServerJobAgentCredential(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerJobAgentCredentialProperties
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public partial class ServerJobAgentJobStep : Resource<ServerJobAgentJobStepProperties>
    {
        public ServerJobAgentJobStep() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/jobs/steps", "2017-03-01-preview");
        public ServerJobAgentJobStep(string name) : this() => Name = name;
        public ServerJobAgentJobStep(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerJobAgentJobStepProperties
    {
        public int? StepId { get; set; }
        public string TargetGroup { get; set; }
        public string Credential { get; set; }
        public ActionInfo Action { get; set; }
        public OutputInfo Output { get; set; }
        public ExecutionOptionsInfo ExecutionOptions { get; set; }
    }

    public partial class ActionInfo
    {
        public string Type { get; set; }
        public string Source { get; set; }
        public string Value { get; set; }
    }

    public partial class OutputInfo
    {
        public string Type { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroupName { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string Credential { get; set; }
    }

    public partial class ExecutionOptionsInfo
    {
        public int? TimeoutSeconds { get; set; }
        public int? RetryAttempts { get; set; }
        public int? InitialRetryIntervalSeconds { get; set; }
        public int? MaximumRetryIntervalSeconds { get; set; }
        public string RetryIntervalBackoffMultiplier { get; set; }
    }

    public partial class ServerJobAgentJob : Resource<ServerJobAgentJobProperties>
    {
        public ServerJobAgentJob() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/jobs", "2017-03-01-preview");
        public ServerJobAgentJob(string name) : this() => Name = name;
        public ServerJobAgentJob(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerJobAgentJobProperties
    {
        public string Description { get; set; }
        public ScheduleInfo Schedule { get; set; }
    }

    public partial class ScheduleInfo
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Type { get; set; }
        public bool? Enabled { get; set; }
        public string Interval { get; set; }
    }

    public partial class ServerJobAgentTargetGroup : Resource<ServerJobAgentTargetGroupProperties>
    {
        public ServerJobAgentTargetGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/targetGroups", "2017-03-01-preview");
        public ServerJobAgentTargetGroup(string name) : this() => Name = name;
        public ServerJobAgentTargetGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerJobAgentTargetGroupProperties
    {
        public IList<MemberInfo> Members { get; set; }
    }

    public partial class MemberInfo
    {
        public string MembershipType { get; set; }
        public string Type { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string ElasticPoolName { get; set; }
        public string ShardMapName { get; set; }
        public string RefreshCredential { get; set; }
    }

    public partial class ServerJobAgent : Resource<ServerJobAgentProperties>
    {
        public ServerJobAgent() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents", "2017-03-01-preview");
        public ServerJobAgent(string name) : this() => Name = name;
        public ServerJobAgent(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerJobAgentProperties
    {
        public string DatabaseId { get; set; }
    }

    public partial class ServerKey : Resource<ServerKeyProperties>
    {
        public ServerKey() => (Type, ApiVersion) = ("Microsoft.Sql/servers/keys", "2015-05-01-preview");
        public ServerKey(string name) : this() => Name = name;
        public ServerKey(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerKeyProperties
    {
        public string ServerKeyType { get; set; }
        public string Uri { get; set; }
        public string Thumbprint { get; set; }
        public string CreationDate { get; set; }
    }

    public partial class ServerPrivateEndpointConnection : Resource<ServerPrivateEndpointConnectionProperties>
    {
        public ServerPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.Sql/servers/privateEndpointConnections", "2018-06-01-preview");
        public ServerPrivateEndpointConnection(string name) : this() => Name = name;
        public ServerPrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerPrivateEndpointConnectionProperties
    {
        public PrivateEndpointInfo PrivateEndpoint { get; set; }
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState { get; set; }
    }

    public partial class PrivateEndpointInfo
    {
        public string Id { get; set; }
    }

    public partial class PrivateLinkServiceConnectionStateInfo
    {
        public string Status { get; set; }
        public string Description { get; set; }
    }

    public partial class ServerSecurityAlertPolicy : Resource<ServerSecurityAlertPolicyProperties>
    {
        public ServerSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/securityAlertPolicies", "2017-03-01-preview");
        public ServerSecurityAlertPolicy(string name) : this() => Name = name;
        public ServerSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerSecurityAlertPolicyProperties
    {
        public string State { get; set; }
        public IList<string> DisabledAlerts { get; set; }
        public IList<string> EmailAddresses { get; set; }
        public bool? EmailAccountAdmins { get; set; }
        public string StorageEndpoint { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public int? RetentionDays { get; set; }
    }

    public partial class ServerSyncAgent : Resource<ServerSyncAgentProperties>
    {
        public ServerSyncAgent() => (Type, ApiVersion) = ("Microsoft.Sql/servers/syncAgents", "2015-05-01-preview");
        public ServerSyncAgent(string name) : this() => Name = name;
        public ServerSyncAgent(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerSyncAgentProperties
    {
        public string SyncDatabaseId { get; set; }
    }

    public partial class ServerVirtualNetworkRule : Resource<ServerVirtualNetworkRuleProperties>
    {
        public ServerVirtualNetworkRule() => (Type, ApiVersion) = ("Microsoft.Sql/servers/virtualNetworkRules", "2015-05-01-preview");
        public ServerVirtualNetworkRule(string name) : this() => Name = name;
        public ServerVirtualNetworkRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerVirtualNetworkRuleProperties
    {
        public string VirtualNetworkSubnetId { get; set; }
        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
    }

    public partial class ServerVulnerabilityAssessment : Resource<ServerVulnerabilityAssessmentProperties>
    {
        public ServerVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/servers/vulnerabilityAssessments", "2018-06-01-preview");
        public ServerVulnerabilityAssessment(string name) : this() => Name = name;
        public ServerVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerVulnerabilityAssessmentProperties
    {
        public string StorageContainerPath { get; set; }
        public string StorageContainerSasKey { get; set; }
        public string StorageAccountAccessKey { get; set; }
        public RecurringScansInfo RecurringScans { get; set; }
    }

    public partial class Server : Resource<ServerProperties>
    {
        public Server() => (Type, ApiVersion) = ("Microsoft.Sql/servers", "2019-06-01-preview");
        public Server(string name) : this() => Name = name;
        public Server(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class ServerProperties
    {
        public string AdministratorLogin { get; set; }
        public string AdministratorLoginPassword { get; set; }
        public string Version { get; set; }
        public string MinimalTlsVersion { get; set; }
        public string PublicNetworkAccess { get; set; }
    }
}
