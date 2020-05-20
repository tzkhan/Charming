namespace Charming.Types.Sql
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class InstancePool : Resource<InstancePoolProperties>
    {
        public InstancePool() => (Type, ApiVersion) = ("Microsoft.Sql/instancePools", "2018-06-01-preview");
        public InstancePool(string name) : this() => Name = name;
        public InstancePool(string name, Location location) : this() => (Name, Location) = (name, location);

        public InstancePool WithProperties(Action<InstancePoolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class InstancePoolProperties : PropertyBase
    {

        public string SubnetId { get; set; }

        public int? VCores { get; set; }

        public string LicenseType { get; set; }
    }

    public class LocationInstanceFailoverGroup : Resource<LocationInstanceFailoverGroupProperties>
    {
        public LocationInstanceFailoverGroup() => (Type, ApiVersion) = ("Microsoft.Sql/locations/instanceFailoverGroups", "2017-10-01-preview");
        public LocationInstanceFailoverGroup(string name) : this() => Name = name;
        public LocationInstanceFailoverGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public LocationInstanceFailoverGroup WithProperties(Action<LocationInstanceFailoverGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class LocationInstanceFailoverGroupProperties : PropertyBase
    {

        private ReadWriteEndpointInfo _readWriteEndpoint;
        public ReadWriteEndpointInfo ReadWriteEndpoint
        {
            get => _readWriteEndpoint = Get(_readWriteEndpoint);
            set => _readWriteEndpoint = value;
        }

        private ReadOnlyEndpointInfo _readOnlyEndpoint;
        public ReadOnlyEndpointInfo ReadOnlyEndpoint
        {
            get => _readOnlyEndpoint = Get(_readOnlyEndpoint);
            set => _readOnlyEndpoint = value;
        }

        public IList<PartnerRegionInfo> PartnerRegions { get; set; }

        public IList<ManagedInstancePairInfo> ManagedInstancePairs { get; set; }
    }

    public class ReadWriteEndpointInfo : PropertyBase
    {

        public string FailoverPolicy { get; set; }

        public int? FailoverWithDataLossGracePeriodMinutes { get; set; }
    }

    public class ReadOnlyEndpointInfo : PropertyBase
    {

        public string FailoverPolicy { get; set; }
    }

    public class PartnerRegionInfo : PropertyBase
    {

        public string Location { get; set; }
    }

    public class ManagedInstancePairInfo : PropertyBase
    {

        public string PrimaryManagedInstanceId { get; set; }

        public string PartnerManagedInstanceId { get; set; }
    }

    public class ManagedInstanceAdministrator : Resource<ManagedInstanceAdministratorProperties>
    {
        public ManagedInstanceAdministrator() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/administrators", "2017-03-01-preview");
        public ManagedInstanceAdministrator(string name) : this() => Name = name;
        public ManagedInstanceAdministrator(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceAdministrator WithProperties(Action<ManagedInstanceAdministratorProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceAdministratorProperties : PropertyBase
    {

        public string AdministratorType { get; set; }

        public string Login { get; set; }

        public string Sid { get; set; }

        public string TenantId { get; set; }
    }

    public class ManagedInstanceDatabaseBackupLongTermRetentionPolicy : Resource<ManagedInstanceDatabaseBackupLongTermRetentionPolicyProperties>
    {
        public ManagedInstanceDatabaseBackupLongTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/backupLongTermRetentionPolicies", "2018-06-01-preview");
        public ManagedInstanceDatabaseBackupLongTermRetentionPolicy(string name) : this() => Name = name;
        public ManagedInstanceDatabaseBackupLongTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceDatabaseBackupLongTermRetentionPolicy WithProperties(Action<ManagedInstanceDatabaseBackupLongTermRetentionPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceDatabaseBackupLongTermRetentionPolicyProperties : PropertyBase
    {

        public string WeeklyRetention { get; set; }

        public string MonthlyRetention { get; set; }

        public string YearlyRetention { get; set; }

        public int? WeekOfYear { get; set; }
    }

    public class ManagedInstanceDatabaseBackupShortTermRetentionPolicy : Resource<ManagedInstanceDatabaseBackupShortTermRetentionPolicyProperties>
    {
        public ManagedInstanceDatabaseBackupShortTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/backupShortTermRetentionPolicies", "2017-03-01-preview");
        public ManagedInstanceDatabaseBackupShortTermRetentionPolicy(string name) : this() => Name = name;
        public ManagedInstanceDatabaseBackupShortTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceDatabaseBackupShortTermRetentionPolicy WithProperties(Action<ManagedInstanceDatabaseBackupShortTermRetentionPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceDatabaseBackupShortTermRetentionPolicyProperties : PropertyBase
    {

        public int? RetentionDays { get; set; }
    }

    public class ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel : Resource<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelProperties>
    {
        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/schemas/tables/columns/sensitivityLabels", "2018-06-01-preview");
        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(string name) : this() => Name = name;
        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel WithProperties(Action<ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceDatabaseSchemaTableColumnSensitivityLabelProperties : PropertyBase
    {

        public string LabelName { get; set; }

        public string LabelId { get; set; }

        public string InformationType { get; set; }

        public string InformationTypeId { get; set; }

        public string Rank { get; set; }
    }

    public class ManagedInstanceDatabaseSecurityAlertPolicy : Resource<ManagedInstanceDatabaseSecurityAlertPolicyProperties>
    {
        public ManagedInstanceDatabaseSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/securityAlertPolicies", "2017-03-01-preview");
        public ManagedInstanceDatabaseSecurityAlertPolicy(string name) : this() => Name = name;
        public ManagedInstanceDatabaseSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceDatabaseSecurityAlertPolicy WithProperties(Action<ManagedInstanceDatabaseSecurityAlertPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceDatabaseSecurityAlertPolicyProperties : PropertyBase
    {

        public string State { get; set; }

        public IList<string> DisabledAlerts { get; set; }

        public IList<string> EmailAddresses { get; set; }

        public bool? EmailAccountAdmins { get; set; }

        public string StorageEndpoint { get; set; }

        public string StorageAccountAccessKey { get; set; }

        public int? RetentionDays { get; set; }
    }

    public class ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline : Resource<ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaselineProperties>
    {
        public ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/vulnerabilityAssessments/rules/baselines", "2017-10-01-preview");
        public ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline(string name) : this() => Name = name;
        public ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaseline WithProperties(Action<ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaselineProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceDatabaseVulnerabilityAssessmentRuleBaselineProperties : PropertyBase
    {

        public IList<BaselineResultInfo> BaselineResults { get; set; }
    }

    public class BaselineResultInfo : PropertyBase
    {

        public IList<string> Result { get; set; }
    }

    public class ManagedInstanceDatabaseVulnerabilityAssessment : Resource<ManagedInstanceDatabaseVulnerabilityAssessmentProperties>
    {
        public ManagedInstanceDatabaseVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases/vulnerabilityAssessments", "2017-10-01-preview");
        public ManagedInstanceDatabaseVulnerabilityAssessment(string name) : this() => Name = name;
        public ManagedInstanceDatabaseVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceDatabaseVulnerabilityAssessment WithProperties(Action<ManagedInstanceDatabaseVulnerabilityAssessmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceDatabaseVulnerabilityAssessmentProperties : PropertyBase
    {

        public string StorageContainerPath { get; set; }

        public string StorageContainerSasKey { get; set; }

        public string StorageAccountAccessKey { get; set; }

        private RecurringScansInfo _recurringScans;
        public RecurringScansInfo RecurringScans
        {
            get => _recurringScans = Get(_recurringScans);
            set => _recurringScans = value;
        }
    }

    public class RecurringScansInfo : PropertyBase
    {

        public bool? IsEnabled { get; set; }

        public bool? EmailSubscriptionAdmins { get; set; }

        public IList<string> Emails { get; set; }
    }

    public class ManagedInstanceDatabase : Resource<ManagedInstanceDatabaseProperties>
    {
        public ManagedInstanceDatabase() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/databases", "2019-06-01-preview");
        public ManagedInstanceDatabase(string name) : this() => Name = name;
        public ManagedInstanceDatabase(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceDatabase WithProperties(Action<ManagedInstanceDatabaseProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceDatabaseProperties : PropertyBase
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

    public class ManagedInstanceEncryptionProtector : Resource<ManagedInstanceEncryptionProtectorProperties>
    {
        public ManagedInstanceEncryptionProtector() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/encryptionProtector", "2017-10-01-preview");
        public ManagedInstanceEncryptionProtector(string name) : this() => Name = name;
        public ManagedInstanceEncryptionProtector(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceEncryptionProtector WithProperties(Action<ManagedInstanceEncryptionProtectorProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceEncryptionProtectorProperties : PropertyBase
    {

        public string ServerKeyName { get; set; }

        public string ServerKeyType { get; set; }
    }

    public class ManagedInstanceKey : Resource<ManagedInstanceKeyProperties>
    {
        public ManagedInstanceKey() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/keys", "2017-10-01-preview");
        public ManagedInstanceKey(string name) : this() => Name = name;
        public ManagedInstanceKey(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceKey WithProperties(Action<ManagedInstanceKeyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceKeyProperties : PropertyBase
    {

        public string ServerKeyType { get; set; }

        public string Uri { get; set; }
    }

    public class ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy : Resource<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyProperties>
    {
        public ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/restorableDroppedDatabases/backupShortTermRetentionPolicies", "2017-03-01-preview");
        public ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(string name) : this() => Name = name;
        public ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy WithProperties(Action<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyProperties : PropertyBase
    {

        public int? RetentionDays { get; set; }
    }

    public class ManagedInstanceSecurityAlertPolicy : Resource<ManagedInstanceSecurityAlertPolicyProperties>
    {
        public ManagedInstanceSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/securityAlertPolicies", "2017-03-01-preview");
        public ManagedInstanceSecurityAlertPolicy(string name) : this() => Name = name;
        public ManagedInstanceSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceSecurityAlertPolicy WithProperties(Action<ManagedInstanceSecurityAlertPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceSecurityAlertPolicyProperties : PropertyBase
    {

        public string State { get; set; }

        public IList<string> DisabledAlerts { get; set; }

        public IList<string> EmailAddresses { get; set; }

        public bool? EmailAccountAdmins { get; set; }

        public string StorageEndpoint { get; set; }

        public string StorageAccountAccessKey { get; set; }

        public int? RetentionDays { get; set; }
    }

    public class ManagedInstanceVulnerabilityAssessment : Resource<ManagedInstanceVulnerabilityAssessmentProperties>
    {
        public ManagedInstanceVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances/vulnerabilityAssessments", "2018-06-01-preview");
        public ManagedInstanceVulnerabilityAssessment(string name) : this() => Name = name;
        public ManagedInstanceVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);

        public ManagedInstanceVulnerabilityAssessment WithProperties(Action<ManagedInstanceVulnerabilityAssessmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ManagedInstanceVulnerabilityAssessmentProperties : PropertyBase
    {

        public string StorageContainerPath { get; set; }

        public string StorageContainerSasKey { get; set; }

        public string StorageAccountAccessKey { get; set; }

        private RecurringScansInfo _recurringScans;
        public RecurringScansInfo RecurringScans
        {
            get => _recurringScans = Get(_recurringScans);
            set => _recurringScans = value;
        }
    }

    public class ManagedInstance : Resource<ManagedInstanceProperties>
    {
        public ManagedInstance() => (Type, ApiVersion) = ("Microsoft.Sql/managedInstances", "2018-06-01-preview");
        public ManagedInstance(string name) : this() => Name = name;
        public ManagedInstance(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public ManagedInstance WithProperties(Action<ManagedInstanceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }
    }

    public class ManagedInstanceProperties : PropertyBase
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

    public class ServerAdministrator : Resource<ServerAdministratorProperties>
    {
        public ServerAdministrator() => (Type, ApiVersion) = ("Microsoft.Sql/servers/administrators", "2019-06-01-preview");
        public ServerAdministrator(string name) : this() => Name = name;
        public ServerAdministrator(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerAdministrator WithProperties(Action<ServerAdministratorProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerAdministratorProperties : PropertyBase
    {

        public string AdministratorType { get; set; }

        public string Login { get; set; }

        public string Sid { get; set; }

        public string TenantId { get; set; }

        public bool? AzureADOnlyAuthentication { get; set; }
    }

    public class ServerAuditingSetting : Resource<ServerAuditingSettingProperties>
    {
        public ServerAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/auditingSettings", "2017-03-01-preview");
        public ServerAuditingSetting(string name) : this() => Name = name;
        public ServerAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerAuditingSetting WithProperties(Action<ServerAuditingSettingProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerAuditingSettingProperties : PropertyBase
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

    public class ServerBackupLongTermRetentionVault : Resource<ServerBackupLongTermRetentionVaultProperties>
    {
        public ServerBackupLongTermRetentionVault() => (Type, ApiVersion) = ("Microsoft.Sql/servers/backupLongTermRetentionVaults", "2014-04-01");
        public ServerBackupLongTermRetentionVault(string name) : this() => Name = name;
        public ServerBackupLongTermRetentionVault(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerBackupLongTermRetentionVault WithProperties(Action<ServerBackupLongTermRetentionVaultProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerBackupLongTermRetentionVaultProperties : PropertyBase
    {

        public string RecoveryServicesVaultResourceId { get; set; }
    }

    public class ServerCommunicationLink : Resource<ServerCommunicationLinkProperties>
    {
        public ServerCommunicationLink() => (Type, ApiVersion) = ("Microsoft.Sql/servers/communicationLinks", "2014-04-01");
        public ServerCommunicationLink(string name) : this() => Name = name;
        public ServerCommunicationLink(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerCommunicationLink WithProperties(Action<ServerCommunicationLinkProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerCommunicationLinkProperties : PropertyBase
    {

        public string PartnerServer { get; set; }
    }

    public class ServerConnectionPolicy : Resource<ServerConnectionPolicyProperties>
    {
        public ServerConnectionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/connectionPolicies", "2014-04-01");
        public ServerConnectionPolicy(string name) : this() => Name = name;
        public ServerConnectionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerConnectionPolicy WithProperties(Action<ServerConnectionPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerConnectionPolicyProperties : PropertyBase
    {

        public string ConnectionType { get; set; }
    }

    public class ServerDatabaseAuditingSetting : Resource<ServerDatabaseAuditingSettingProperties>
    {
        public ServerDatabaseAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/auditingSettings", "2017-03-01-preview");
        public ServerDatabaseAuditingSetting(string name) : this() => Name = name;
        public ServerDatabaseAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseAuditingSetting WithProperties(Action<ServerDatabaseAuditingSettingProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseAuditingSettingProperties : PropertyBase
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

    public class ServerDatabaseBackupLongTermRetentionPolicy : Resource<ServerDatabaseBackupLongTermRetentionPolicyProperties>
    {
        public ServerDatabaseBackupLongTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/backupLongTermRetentionPolicies", "2017-03-01-preview");
        public ServerDatabaseBackupLongTermRetentionPolicy(string name) : this() => Name = name;
        public ServerDatabaseBackupLongTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseBackupLongTermRetentionPolicy WithProperties(Action<ServerDatabaseBackupLongTermRetentionPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseBackupLongTermRetentionPolicyProperties : PropertyBase
    {

        public string WeeklyRetention { get; set; }

        public string MonthlyRetention { get; set; }

        public string YearlyRetention { get; set; }

        public int? WeekOfYear { get; set; }
    }

    public class ServerDatabaseBackupShortTermRetentionPolicy : Resource<ServerDatabaseBackupShortTermRetentionPolicyProperties>
    {
        public ServerDatabaseBackupShortTermRetentionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/backupShortTermRetentionPolicies", "2017-10-01-preview");
        public ServerDatabaseBackupShortTermRetentionPolicy(string name) : this() => Name = name;
        public ServerDatabaseBackupShortTermRetentionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseBackupShortTermRetentionPolicy WithProperties(Action<ServerDatabaseBackupShortTermRetentionPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseBackupShortTermRetentionPolicyProperties : PropertyBase
    {

        public int? RetentionDays { get; set; }
    }

    public class ServerDatabaseConnectionPolicy : Resource<ServerDatabaseConnectionPolicyProperties>
    {
        public ServerDatabaseConnectionPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/connectionPolicies", "2014-04-01");
        public ServerDatabaseConnectionPolicy(string name) : this() => Name = name;
        public ServerDatabaseConnectionPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseConnectionPolicy WithProperties(Action<ServerDatabaseConnectionPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseConnectionPolicyProperties : PropertyBase
    {

        public string SecurityEnabledAccess { get; set; }

        public string ProxyDnsName { get; set; }

        public string ProxyPort { get; set; }

        public string Visibility { get; set; }

        public string UseServerDefault { get; set; }

        public string RedirectionState { get; set; }

        public string State { get; set; }
    }

    public class ServerDatabaseDataMaskingPolicyRule : Resource<ServerDatabaseDataMaskingPolicyRuleProperties>
    {
        public ServerDatabaseDataMaskingPolicyRule() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/dataMaskingPolicies/rules", "2014-04-01");
        public ServerDatabaseDataMaskingPolicyRule(string name) : this() => Name = name;
        public ServerDatabaseDataMaskingPolicyRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseDataMaskingPolicyRule WithProperties(Action<ServerDatabaseDataMaskingPolicyRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseDataMaskingPolicyRuleProperties : PropertyBase
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

    public class ServerDatabaseDataMaskingPolicy : Resource<ServerDatabaseDataMaskingPolicyProperties>
    {
        public ServerDatabaseDataMaskingPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/dataMaskingPolicies", "2014-04-01");
        public ServerDatabaseDataMaskingPolicy(string name) : this() => Name = name;
        public ServerDatabaseDataMaskingPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseDataMaskingPolicy WithProperties(Action<ServerDatabaseDataMaskingPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseDataMaskingPolicyProperties : PropertyBase
    {

        public string DataMaskingState { get; set; }

        public string ExemptPrincipals { get; set; }
    }

    public class ServerDatabaseExtendedAuditingSetting : Resource<ServerDatabaseExtendedAuditingSettingProperties>
    {
        public ServerDatabaseExtendedAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/extendedAuditingSettings", "2017-03-01-preview");
        public ServerDatabaseExtendedAuditingSetting(string name) : this() => Name = name;
        public ServerDatabaseExtendedAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseExtendedAuditingSetting WithProperties(Action<ServerDatabaseExtendedAuditingSettingProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseExtendedAuditingSettingProperties : PropertyBase
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

    public class ServerDatabaseExtension : Resource<ServerDatabaseExtensionProperties>
    {
        public ServerDatabaseExtension() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/extensions", "2014-04-01");
        public ServerDatabaseExtension(string name) : this() => Name = name;
        public ServerDatabaseExtension(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseExtension WithProperties(Action<ServerDatabaseExtensionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseExtensionProperties : PropertyBase
    {

        public string StorageKeyType { get; set; }

        public string StorageKey { get; set; }

        public string StorageUri { get; set; }

        public string AdministratorLogin { get; set; }

        public string AdministratorLoginPassword { get; set; }

        public string AuthenticationType { get; set; }

        public string OperationMode { get; set; }
    }

    public class ServerDatabaseGeoBackupPolicy : Resource<ServerDatabaseGeoBackupPolicyProperties>
    {
        public ServerDatabaseGeoBackupPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/geoBackupPolicies", "2014-04-01");
        public ServerDatabaseGeoBackupPolicy(string name) : this() => Name = name;
        public ServerDatabaseGeoBackupPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseGeoBackupPolicy WithProperties(Action<ServerDatabaseGeoBackupPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseGeoBackupPolicyProperties : PropertyBase
    {

        public string State { get; set; }
    }

    public class ServerDatabaseSchemaTableColumnSensitivityLabel : Resource<ServerDatabaseSchemaTableColumnSensitivityLabelProperties>
    {
        public ServerDatabaseSchemaTableColumnSensitivityLabel() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/schemas/tables/columns/sensitivityLabels", "2017-03-01-preview");
        public ServerDatabaseSchemaTableColumnSensitivityLabel(string name) : this() => Name = name;
        public ServerDatabaseSchemaTableColumnSensitivityLabel(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseSchemaTableColumnSensitivityLabel WithProperties(Action<ServerDatabaseSchemaTableColumnSensitivityLabelProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseSchemaTableColumnSensitivityLabelProperties : PropertyBase
    {

        public string LabelName { get; set; }

        public string LabelId { get; set; }

        public string InformationType { get; set; }

        public string InformationTypeId { get; set; }

        public string Rank { get; set; }
    }

    public class ServerDatabaseSecurityAlertPolicy : Resource<ServerDatabaseSecurityAlertPolicyProperties>
    {
        public ServerDatabaseSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/securityAlertPolicies", "2018-06-01-preview");
        public ServerDatabaseSecurityAlertPolicy(string name) : this() => Name = name;
        public ServerDatabaseSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseSecurityAlertPolicy WithProperties(Action<ServerDatabaseSecurityAlertPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseSecurityAlertPolicyProperties : PropertyBase
    {

        public string State { get; set; }

        public IList<string> DisabledAlerts { get; set; }

        public IList<string> EmailAddresses { get; set; }

        public bool? EmailAccountAdmins { get; set; }

        public string StorageEndpoint { get; set; }

        public string StorageAccountAccessKey { get; set; }

        public int? RetentionDays { get; set; }
    }

    public class ServerDatabaseSyncGroupSyncMember : Resource<ServerDatabaseSyncGroupSyncMemberProperties>
    {
        public ServerDatabaseSyncGroupSyncMember() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/syncGroups/syncMembers", "2015-05-01-preview");
        public ServerDatabaseSyncGroupSyncMember(string name) : this() => Name = name;
        public ServerDatabaseSyncGroupSyncMember(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseSyncGroupSyncMember WithProperties(Action<ServerDatabaseSyncGroupSyncMemberProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseSyncGroupSyncMemberProperties : PropertyBase
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

    public class ServerDatabaseSyncGroup : Resource<ServerDatabaseSyncGroupProperties>
    {
        public ServerDatabaseSyncGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/syncGroups", "2015-05-01-preview");
        public ServerDatabaseSyncGroup(string name) : this() => Name = name;
        public ServerDatabaseSyncGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseSyncGroup WithProperties(Action<ServerDatabaseSyncGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseSyncGroupProperties : PropertyBase
    {

        public int? Interval { get; set; }

        public string ConflictResolutionPolicy { get; set; }

        public string SyncDatabaseId { get; set; }

        public string HubDatabaseUserName { get; set; }

        public string HubDatabasePassword { get; set; }

        private SchemaInfo _schema;
        public SchemaInfo Schema
        {
            get => _schema = Get(_schema);
            set => _schema = value;
        }
    }

    public class SchemaInfo : PropertyBase
    {

        public IList<TableInfo> Tables { get; set; }

        public string MasterSyncMemberName { get; set; }
    }

    public class TableInfo : PropertyBase
    {

        public IList<ColumnInfo> Columns { get; set; }

        public string QuotedName { get; set; }
    }

    public class ColumnInfo : PropertyBase
    {

        public string QuotedName { get; set; }

        public string DataSize { get; set; }

        public string DataType { get; set; }
    }

    public class ServerDatabaseTransparentDataEncryption : Resource<ServerDatabaseTransparentDataEncryptionProperties>
    {
        public ServerDatabaseTransparentDataEncryption() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/transparentDataEncryption", "2014-04-01");
        public ServerDatabaseTransparentDataEncryption(string name) : this() => Name = name;
        public ServerDatabaseTransparentDataEncryption(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseTransparentDataEncryption WithProperties(Action<ServerDatabaseTransparentDataEncryptionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseTransparentDataEncryptionProperties : PropertyBase
    {

        public string Status { get; set; }
    }

    public class ServerDatabaseVulnerabilityAssessmentRuleBaseline : Resource<ServerDatabaseVulnerabilityAssessmentRuleBaselineProperties>
    {
        public ServerDatabaseVulnerabilityAssessmentRuleBaseline() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/vulnerabilityAssessments/rules/baselines", "2017-03-01-preview");
        public ServerDatabaseVulnerabilityAssessmentRuleBaseline(string name) : this() => Name = name;
        public ServerDatabaseVulnerabilityAssessmentRuleBaseline(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseVulnerabilityAssessmentRuleBaseline WithProperties(Action<ServerDatabaseVulnerabilityAssessmentRuleBaselineProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseVulnerabilityAssessmentRuleBaselineProperties : PropertyBase
    {

        public IList<BaselineResultInfo> BaselineResults { get; set; }
    }

    public class ServerDatabaseVulnerabilityAssessment : Resource<ServerDatabaseVulnerabilityAssessmentProperties>
    {
        public ServerDatabaseVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/vulnerabilityAssessments", "2017-03-01-preview");
        public ServerDatabaseVulnerabilityAssessment(string name) : this() => Name = name;
        public ServerDatabaseVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseVulnerabilityAssessment WithProperties(Action<ServerDatabaseVulnerabilityAssessmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseVulnerabilityAssessmentProperties : PropertyBase
    {

        public string StorageContainerPath { get; set; }

        public string StorageContainerSasKey { get; set; }

        public string StorageAccountAccessKey { get; set; }

        private RecurringScansInfo _recurringScans;
        public RecurringScansInfo RecurringScans
        {
            get => _recurringScans = Get(_recurringScans);
            set => _recurringScans = value;
        }
    }

    public class ServerDatabaseWorkloadGroupWorkloadClassifier : Resource<ServerDatabaseWorkloadGroupWorkloadClassifierProperties>
    {
        public ServerDatabaseWorkloadGroupWorkloadClassifier() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/workloadGroups/workloadClassifiers", "2019-06-01-preview");
        public ServerDatabaseWorkloadGroupWorkloadClassifier(string name) : this() => Name = name;
        public ServerDatabaseWorkloadGroupWorkloadClassifier(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseWorkloadGroupWorkloadClassifier WithProperties(Action<ServerDatabaseWorkloadGroupWorkloadClassifierProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseWorkloadGroupWorkloadClassifierProperties : PropertyBase
    {

        public string MemberName { get; set; }

        public string Label { get; set; }

        public string Context { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Importance { get; set; }
    }

    public class ServerDatabaseWorkloadGroup : Resource<ServerDatabaseWorkloadGroupProperties>
    {
        public ServerDatabaseWorkloadGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases/workloadGroups", "2019-06-01-preview");
        public ServerDatabaseWorkloadGroup(string name) : this() => Name = name;
        public ServerDatabaseWorkloadGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabaseWorkloadGroup WithProperties(Action<ServerDatabaseWorkloadGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseWorkloadGroupProperties : PropertyBase
    {

        public int? MinResourcePercent { get; set; }

        public int? MaxResourcePercent { get; set; }

        public string MinResourcePercentPerRequest { get; set; }

        public string MaxResourcePercentPerRequest { get; set; }

        public string Importance { get; set; }

        public int? QueryExecutionTimeout { get; set; }
    }

    public class ServerDatabase : Resource<ServerDatabaseProperties>
    {
        public ServerDatabase() => (Type, ApiVersion) = ("Microsoft.Sql/servers/databases", "2019-06-01-preview");
        public ServerDatabase(string name) : this() => Name = name;
        public ServerDatabase(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerDatabase WithProperties(Action<ServerDatabaseProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerDatabaseProperties : PropertyBase
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

    public class ServerElasticPool : Resource<ServerElasticPoolProperties>
    {
        public ServerElasticPool() => (Type, ApiVersion) = ("Microsoft.Sql/servers/elasticPools", "2017-10-01-preview");
        public ServerElasticPool(string name) : this() => Name = name;
        public ServerElasticPool(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerElasticPool WithProperties(Action<ServerElasticPoolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerElasticPoolProperties : PropertyBase
    {

        public int? MaxSizeBytes { get; set; }

        private PerDatabaseSettingsInfo _perDatabaseSettings;
        public PerDatabaseSettingsInfo PerDatabaseSettings
        {
            get => _perDatabaseSettings = Get(_perDatabaseSettings);
            set => _perDatabaseSettings = value;
        }

        public bool? ZoneRedundant { get; set; }

        public string LicenseType { get; set; }
    }

    public class PerDatabaseSettingsInfo : PropertyBase
    {

        public string MinCapacity { get; set; }

        public string MaxCapacity { get; set; }
    }

    public class ServerEncryptionProtector : Resource<ServerEncryptionProtectorProperties>
    {
        public ServerEncryptionProtector() => (Type, ApiVersion) = ("Microsoft.Sql/servers/encryptionProtector", "2015-05-01-preview");
        public ServerEncryptionProtector(string name) : this() => Name = name;
        public ServerEncryptionProtector(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerEncryptionProtector WithProperties(Action<ServerEncryptionProtectorProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerEncryptionProtectorProperties : PropertyBase
    {

        public string ServerKeyName { get; set; }

        public string ServerKeyType { get; set; }
    }

    public class ServerExtendedAuditingSetting : Resource<ServerExtendedAuditingSettingProperties>
    {
        public ServerExtendedAuditingSetting() => (Type, ApiVersion) = ("Microsoft.Sql/servers/extendedAuditingSettings", "2017-03-01-preview");
        public ServerExtendedAuditingSetting(string name) : this() => Name = name;
        public ServerExtendedAuditingSetting(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerExtendedAuditingSetting WithProperties(Action<ServerExtendedAuditingSettingProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerExtendedAuditingSettingProperties : PropertyBase
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

    public class ServerFailoverGroup : Resource<ServerFailoverGroupProperties>
    {
        public ServerFailoverGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/failoverGroups", "2015-05-01-preview");
        public ServerFailoverGroup(string name) : this() => Name = name;
        public ServerFailoverGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerFailoverGroup WithProperties(Action<ServerFailoverGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerFailoverGroupProperties : PropertyBase
    {

        private ReadWriteEndpointInfo _readWriteEndpoint;
        public ReadWriteEndpointInfo ReadWriteEndpoint
        {
            get => _readWriteEndpoint = Get(_readWriteEndpoint);
            set => _readWriteEndpoint = value;
        }

        private ReadOnlyEndpointInfo _readOnlyEndpoint;
        public ReadOnlyEndpointInfo ReadOnlyEndpoint
        {
            get => _readOnlyEndpoint = Get(_readOnlyEndpoint);
            set => _readOnlyEndpoint = value;
        }

        public IList<PartnerServerInfo> PartnerServers { get; set; }

        public IList<string> Databases { get; set; }
    }

    public class PartnerServerInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ServerFirewallRule : Resource<ServerFirewallRuleProperties>
    {
        public ServerFirewallRule() => (Type, ApiVersion) = ("Microsoft.Sql/servers/firewallRules", "2015-05-01-preview");
        public ServerFirewallRule(string name) : this() => Name = name;
        public ServerFirewallRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerFirewallRule WithProperties(Action<ServerFirewallRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerFirewallRuleProperties : PropertyBase
    {

        public string StartIpAddress { get; set; }

        public string EndIpAddress { get; set; }
    }

    public class ServerJobAgentCredential : Resource<ServerJobAgentCredentialProperties>
    {
        public ServerJobAgentCredential() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/credentials", "2017-03-01-preview");
        public ServerJobAgentCredential(string name) : this() => Name = name;
        public ServerJobAgentCredential(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerJobAgentCredential WithProperties(Action<ServerJobAgentCredentialProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerJobAgentCredentialProperties : PropertyBase
    {

        public string Username { get; set; }

        public string Password { get; set; }
    }

    public class ServerJobAgentJobStep : Resource<ServerJobAgentJobStepProperties>
    {
        public ServerJobAgentJobStep() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/jobs/steps", "2017-03-01-preview");
        public ServerJobAgentJobStep(string name) : this() => Name = name;
        public ServerJobAgentJobStep(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerJobAgentJobStep WithProperties(Action<ServerJobAgentJobStepProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerJobAgentJobStepProperties : PropertyBase
    {

        public int? StepId { get; set; }

        public string TargetGroup { get; set; }

        public string Credential { get; set; }

        private ActionInfo _action;
        public ActionInfo Action
        {
            get => _action = Get(_action);
            set => _action = value;
        }

        private OutputInfo _output;
        public OutputInfo Output
        {
            get => _output = Get(_output);
            set => _output = value;
        }

        private ExecutionOptionsInfo _executionOptions;
        public ExecutionOptionsInfo ExecutionOptions
        {
            get => _executionOptions = Get(_executionOptions);
            set => _executionOptions = value;
        }
    }

    public class ActionInfo : PropertyBase
    {

        public string Type { get; set; }

        public string Source { get; set; }

        public string Value { get; set; }
    }

    public class OutputInfo : PropertyBase
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

    public class ExecutionOptionsInfo : PropertyBase
    {

        public int? TimeoutSeconds { get; set; }

        public int? RetryAttempts { get; set; }

        public int? InitialRetryIntervalSeconds { get; set; }

        public int? MaximumRetryIntervalSeconds { get; set; }

        public string RetryIntervalBackoffMultiplier { get; set; }
    }

    public class ServerJobAgentJob : Resource<ServerJobAgentJobProperties>
    {
        public ServerJobAgentJob() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/jobs", "2017-03-01-preview");
        public ServerJobAgentJob(string name) : this() => Name = name;
        public ServerJobAgentJob(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerJobAgentJob WithProperties(Action<ServerJobAgentJobProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerJobAgentJobProperties : PropertyBase
    {

        public string Description { get; set; }

        private ScheduleInfo _schedule;
        public ScheduleInfo Schedule
        {
            get => _schedule = Get(_schedule);
            set => _schedule = value;
        }
    }

    public class ScheduleInfo : PropertyBase
    {

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Type { get; set; }

        public bool? Enabled { get; set; }

        public string Interval { get; set; }
    }

    public class ServerJobAgentTargetGroup : Resource<ServerJobAgentTargetGroupProperties>
    {
        public ServerJobAgentTargetGroup() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents/targetGroups", "2017-03-01-preview");
        public ServerJobAgentTargetGroup(string name) : this() => Name = name;
        public ServerJobAgentTargetGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerJobAgentTargetGroup WithProperties(Action<ServerJobAgentTargetGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerJobAgentTargetGroupProperties : PropertyBase
    {

        public IList<MemberInfo> Members { get; set; }
    }

    public class MemberInfo : PropertyBase
    {

        public string MembershipType { get; set; }

        public string Type { get; set; }

        public string ServerName { get; set; }

        public string DatabaseName { get; set; }

        public string ElasticPoolName { get; set; }

        public string ShardMapName { get; set; }

        public string RefreshCredential { get; set; }
    }

    public class ServerJobAgent : Resource<ServerJobAgentProperties>
    {
        public ServerJobAgent() => (Type, ApiVersion) = ("Microsoft.Sql/servers/jobAgents", "2017-03-01-preview");
        public ServerJobAgent(string name) : this() => Name = name;
        public ServerJobAgent(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerJobAgent WithProperties(Action<ServerJobAgentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerJobAgentProperties : PropertyBase
    {

        public string DatabaseId { get; set; }
    }

    public class ServerKey : Resource<ServerKeyProperties>
    {
        public ServerKey() => (Type, ApiVersion) = ("Microsoft.Sql/servers/keys", "2015-05-01-preview");
        public ServerKey(string name) : this() => Name = name;
        public ServerKey(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerKey WithProperties(Action<ServerKeyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerKeyProperties : PropertyBase
    {

        public string ServerKeyType { get; set; }

        public string Uri { get; set; }

        public string Thumbprint { get; set; }

        public string CreationDate { get; set; }
    }

    public class ServerPrivateEndpointConnection : Resource<ServerPrivateEndpointConnectionProperties>
    {
        public ServerPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.Sql/servers/privateEndpointConnections", "2018-06-01-preview");
        public ServerPrivateEndpointConnection(string name) : this() => Name = name;
        public ServerPrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerPrivateEndpointConnection WithProperties(Action<ServerPrivateEndpointConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerPrivateEndpointConnectionProperties : PropertyBase
    {

        private PrivateEndpointInfo _privateEndpoint;
        public PrivateEndpointInfo PrivateEndpoint
        {
            get => _privateEndpoint = Get(_privateEndpoint);
            set => _privateEndpoint = value;
        }

        private PrivateLinkServiceConnectionStateInfo _privateLinkServiceConnectionState;
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState
        {
            get => _privateLinkServiceConnectionState = Get(_privateLinkServiceConnectionState);
            set => _privateLinkServiceConnectionState = value;
        }
    }

    public class PrivateEndpointInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PrivateLinkServiceConnectionStateInfo : PropertyBase
    {

        public string Status { get; set; }

        public string Description { get; set; }
    }

    public class ServerSecurityAlertPolicy : Resource<ServerSecurityAlertPolicyProperties>
    {
        public ServerSecurityAlertPolicy() => (Type, ApiVersion) = ("Microsoft.Sql/servers/securityAlertPolicies", "2017-03-01-preview");
        public ServerSecurityAlertPolicy(string name) : this() => Name = name;
        public ServerSecurityAlertPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerSecurityAlertPolicy WithProperties(Action<ServerSecurityAlertPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerSecurityAlertPolicyProperties : PropertyBase
    {

        public string State { get; set; }

        public IList<string> DisabledAlerts { get; set; }

        public IList<string> EmailAddresses { get; set; }

        public bool? EmailAccountAdmins { get; set; }

        public string StorageEndpoint { get; set; }

        public string StorageAccountAccessKey { get; set; }

        public int? RetentionDays { get; set; }
    }

    public class ServerSyncAgent : Resource<ServerSyncAgentProperties>
    {
        public ServerSyncAgent() => (Type, ApiVersion) = ("Microsoft.Sql/servers/syncAgents", "2015-05-01-preview");
        public ServerSyncAgent(string name) : this() => Name = name;
        public ServerSyncAgent(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerSyncAgent WithProperties(Action<ServerSyncAgentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerSyncAgentProperties : PropertyBase
    {

        public string SyncDatabaseId { get; set; }
    }

    public class ServerVirtualNetworkRule : Resource<ServerVirtualNetworkRuleProperties>
    {
        public ServerVirtualNetworkRule() => (Type, ApiVersion) = ("Microsoft.Sql/servers/virtualNetworkRules", "2015-05-01-preview");
        public ServerVirtualNetworkRule(string name) : this() => Name = name;
        public ServerVirtualNetworkRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerVirtualNetworkRule WithProperties(Action<ServerVirtualNetworkRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerVirtualNetworkRuleProperties : PropertyBase
    {

        public string VirtualNetworkSubnetId { get; set; }

        public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
    }

    public class ServerVulnerabilityAssessment : Resource<ServerVulnerabilityAssessmentProperties>
    {
        public ServerVulnerabilityAssessment() => (Type, ApiVersion) = ("Microsoft.Sql/servers/vulnerabilityAssessments", "2018-06-01-preview");
        public ServerVulnerabilityAssessment(string name) : this() => Name = name;
        public ServerVulnerabilityAssessment(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerVulnerabilityAssessment WithProperties(Action<ServerVulnerabilityAssessmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerVulnerabilityAssessmentProperties : PropertyBase
    {

        public string StorageContainerPath { get; set; }

        public string StorageContainerSasKey { get; set; }

        public string StorageAccountAccessKey { get; set; }

        private RecurringScansInfo _recurringScans;
        public RecurringScansInfo RecurringScans
        {
            get => _recurringScans = Get(_recurringScans);
            set => _recurringScans = value;
        }
    }

    public class Server : Resource<ServerProperties>
    {
        public Server() => (Type, ApiVersion) = ("Microsoft.Sql/servers", "2019-06-01-preview");
        public Server(string name) : this() => Name = name;
        public Server(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public Server WithProperties(Action<ServerProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerProperties : PropertyBase
    {

        public string AdministratorLogin { get; set; }

        public string AdministratorLoginPassword { get; set; }

        public string Version { get; set; }

        public string MinimalTlsVersion { get; set; }

        public string PublicNetworkAccess { get; set; }
    }
}
