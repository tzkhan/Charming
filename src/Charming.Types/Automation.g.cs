namespace Charming.Types.Automation
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class AutomationAccountCertificate : Resource<AutomationAccountCertificateProperties>
    {
        public AutomationAccountCertificate() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/certificates", "2015-10-31");
        public AutomationAccountCertificate(string name) : this() => Name = name;
        public AutomationAccountCertificate(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountCertificate WithProperties(Action<AutomationAccountCertificateProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountCertificateProperties : PropertyBase
    {

        public string Base64Value { get; set; }

        public string Description { get; set; }

        public string Thumbprint { get; set; }

        public bool? IsExportable { get; set; }
    }

    public class AutomationAccountCompilationjob : Resource<AutomationAccountCompilationjobProperties>
    {
        public AutomationAccountCompilationjob() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/compilationjobs", "2018-01-15");
        public AutomationAccountCompilationjob(string name) : this() => Name = name;
        public AutomationAccountCompilationjob(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountCompilationjob WithProperties(Action<AutomationAccountCompilationjobProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountCompilationjobProperties : PropertyBase
    {

        private ConfigurationInfo _configuration;
        public ConfigurationInfo Configuration
        {
            get => _configuration = Get(_configuration);
            set => _configuration = value;
        }

        public object Parameters { get; set; }

        public bool? IncrementNodeConfigurationBuild { get; set; }
    }

    public class ConfigurationInfo : PropertyBase
    {

        public string Name { get; set; }
    }

    public class AutomationAccountConfiguration : Resource<AutomationAccountConfigurationProperties>
    {
        public AutomationAccountConfiguration() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/configurations", "2015-10-31");
        public AutomationAccountConfiguration(string name) : this() => Name = name;
        public AutomationAccountConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountConfiguration WithProperties(Action<AutomationAccountConfigurationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountConfigurationProperties : PropertyBase
    {

        public bool? LogVerbose { get; set; }

        public bool? LogProgress { get; set; }

        private SourceInfo _source;
        public SourceInfo Source
        {
            get => _source = Get(_source);
            set => _source = value;
        }

        public object Parameters { get; set; }

        public string Description { get; set; }
    }

    public class SourceInfo : PropertyBase
    {

        private HashInfo _hash;
        public HashInfo Hash
        {
            get => _hash = Get(_hash);
            set => _hash = value;
        }

        public string Type { get; set; }

        public string Value { get; set; }

        public string Version { get; set; }
    }

    public class HashInfo : PropertyBase
    {

        public string Algorithm { get; set; }

        public string Value { get; set; }
    }

    public class AutomationAccountConnection : Resource<AutomationAccountConnectionProperties>
    {
        public AutomationAccountConnection() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/connections", "2015-10-31");
        public AutomationAccountConnection(string name) : this() => Name = name;
        public AutomationAccountConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountConnection WithProperties(Action<AutomationAccountConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountConnectionProperties : PropertyBase
    {

        public string Description { get; set; }

        private ConnectionTypeInfo _connectionType;
        public ConnectionTypeInfo ConnectionType
        {
            get => _connectionType = Get(_connectionType);
            set => _connectionType = value;
        }

        public object FieldDefinitionValues { get; set; }
    }

    public class ConnectionTypeInfo : PropertyBase
    {

        public string Name { get; set; }
    }

    public class AutomationAccountConnectionType : Resource<AutomationAccountConnectionTypeProperties>
    {
        public AutomationAccountConnectionType() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/connectionTypes", "2015-10-31");
        public AutomationAccountConnectionType(string name) : this() => Name = name;
        public AutomationAccountConnectionType(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountConnectionType WithProperties(Action<AutomationAccountConnectionTypeProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountConnectionTypeProperties : PropertyBase
    {

        public bool? IsGlobal { get; set; }

        public object FieldDefinitions { get; set; }
    }

    public class AutomationAccountCredential : Resource<AutomationAccountCredentialProperties>
    {
        public AutomationAccountCredential() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/credentials", "2015-10-31");
        public AutomationAccountCredential(string name) : this() => Name = name;
        public AutomationAccountCredential(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountCredential WithProperties(Action<AutomationAccountCredentialProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountCredentialProperties : PropertyBase
    {

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Description { get; set; }
    }

    public class AutomationAccountJob : Resource<AutomationAccountJobProperties>
    {
        public AutomationAccountJob() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/jobs", "2017-05-15-preview");
        public AutomationAccountJob(string name) : this() => Name = name;
        public AutomationAccountJob(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountJob WithProperties(Action<AutomationAccountJobProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountJobProperties : PropertyBase
    {

        private RunbookInfo _runbook;
        public RunbookInfo Runbook
        {
            get => _runbook = Get(_runbook);
            set => _runbook = value;
        }

        public object Parameters { get; set; }

        public string RunOn { get; set; }
    }

    public class RunbookInfo : PropertyBase
    {

        public string Name { get; set; }
    }

    public class AutomationAccountJobSchedule : Resource<AutomationAccountJobScheduleProperties>
    {
        public AutomationAccountJobSchedule() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/jobSchedules", "2015-10-31");
        public AutomationAccountJobSchedule(string name) : this() => Name = name;
        public AutomationAccountJobSchedule(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountJobSchedule WithProperties(Action<AutomationAccountJobScheduleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountJobScheduleProperties : PropertyBase
    {

        private ScheduleInfo _schedule;
        public ScheduleInfo Schedule
        {
            get => _schedule = Get(_schedule);
            set => _schedule = value;
        }

        private RunbookInfo _runbook;
        public RunbookInfo Runbook
        {
            get => _runbook = Get(_runbook);
            set => _runbook = value;
        }

        public string RunOn { get; set; }

        public object Parameters { get; set; }
    }

    public class ScheduleInfo : PropertyBase
    {

        public string Name { get; set; }
    }

    public class AutomationAccountModule : Resource<AutomationAccountModuleProperties>
    {
        public AutomationAccountModule() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/modules", "2015-10-31");
        public AutomationAccountModule(string name) : this() => Name = name;
        public AutomationAccountModule(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountModule WithProperties(Action<AutomationAccountModuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountModuleProperties : PropertyBase
    {

        private ContentLinkInfo _contentLink;
        public ContentLinkInfo ContentLink
        {
            get => _contentLink = Get(_contentLink);
            set => _contentLink = value;
        }
    }

    public class ContentLinkInfo : PropertyBase
    {

        public string Uri { get; set; }

        private ContentHashInfo _contentHash;
        public ContentHashInfo ContentHash
        {
            get => _contentHash = Get(_contentHash);
            set => _contentHash = value;
        }

        public string Version { get; set; }
    }

    public class ContentHashInfo : PropertyBase
    {

        public string Algorithm { get; set; }

        public string Value { get; set; }
    }

    public class AutomationAccountNodeConfiguration : Resource<AutomationAccountNodeConfigurationProperties>
    {
        public AutomationAccountNodeConfiguration() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/nodeConfigurations", "2018-01-15");
        public AutomationAccountNodeConfiguration(string name) : this() => Name = name;
        public AutomationAccountNodeConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountNodeConfiguration WithProperties(Action<AutomationAccountNodeConfigurationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountNodeConfigurationProperties : PropertyBase
    {

        private SourceInfo _source;
        public SourceInfo Source
        {
            get => _source = Get(_source);
            set => _source = value;
        }

        private ConfigurationInfo _configuration;
        public ConfigurationInfo Configuration
        {
            get => _configuration = Get(_configuration);
            set => _configuration = value;
        }

        public bool? IncrementNodeConfigurationBuild { get; set; }
    }

    public class AutomationAccountPrivateEndpointConnection : Resource<AutomationAccountPrivateEndpointConnectionProperties>
    {
        public AutomationAccountPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/privateEndpointConnections", "2020-01-13-preview");
        public AutomationAccountPrivateEndpointConnection(string name) : this() => Name = name;
        public AutomationAccountPrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountPrivateEndpointConnection WithProperties(Action<AutomationAccountPrivateEndpointConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountPrivateEndpointConnectionProperties : PropertyBase
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

    public class AutomationAccountPython2Package : Resource<AutomationAccountPython2PackageProperties>
    {
        public AutomationAccountPython2Package() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/python2Packages", "2018-06-30");
        public AutomationAccountPython2Package(string name) : this() => Name = name;
        public AutomationAccountPython2Package(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountPython2Package WithProperties(Action<AutomationAccountPython2PackageProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountPython2PackageProperties : PropertyBase
    {

        private ContentLinkInfo _contentLink;
        public ContentLinkInfo ContentLink
        {
            get => _contentLink = Get(_contentLink);
            set => _contentLink = value;
        }
    }

    public class AutomationAccountRunbook : Resource<AutomationAccountRunbookProperties>
    {
        public AutomationAccountRunbook() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/runbooks", "2018-06-30");
        public AutomationAccountRunbook(string name) : this() => Name = name;
        public AutomationAccountRunbook(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountRunbook WithProperties(Action<AutomationAccountRunbookProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountRunbookProperties : PropertyBase
    {

        public bool? LogVerbose { get; set; }

        public bool? LogProgress { get; set; }

        public string RunbookType { get; set; }

        private DraftInfo _draft;
        public DraftInfo Draft
        {
            get => _draft = Get(_draft);
            set => _draft = value;
        }

        private PublishContentLinkInfo _publishContentLink;
        public PublishContentLinkInfo PublishContentLink
        {
            get => _publishContentLink = Get(_publishContentLink);
            set => _publishContentLink = value;
        }

        public string Description { get; set; }

        public int? LogActivityTrace { get; set; }
    }

    public class DraftInfo : PropertyBase
    {

        public bool? InEdit { get; set; }

        private DraftContentLinkInfo _draftContentLink;
        public DraftContentLinkInfo DraftContentLink
        {
            get => _draftContentLink = Get(_draftContentLink);
            set => _draftContentLink = value;
        }

        public string CreationTime { get; set; }

        public string LastModifiedTime { get; set; }

        public object Parameters { get; set; }

        public IList<string> OutputTypes { get; set; }
    }

    public class DraftContentLinkInfo : PropertyBase
    {

        public string Uri { get; set; }

        private ContentHashInfo _contentHash;
        public ContentHashInfo ContentHash
        {
            get => _contentHash = Get(_contentHash);
            set => _contentHash = value;
        }

        public string Version { get; set; }
    }

    public class PublishContentLinkInfo : PropertyBase
    {

        public string Uri { get; set; }

        private ContentHashInfo _contentHash;
        public ContentHashInfo ContentHash
        {
            get => _contentHash = Get(_contentHash);
            set => _contentHash = value;
        }

        public string Version { get; set; }
    }

    public class AutomationAccountSchedule : Resource<AutomationAccountScheduleProperties>
    {
        public AutomationAccountSchedule() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/schedules", "2015-10-31");
        public AutomationAccountSchedule(string name) : this() => Name = name;
        public AutomationAccountSchedule(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountSchedule WithProperties(Action<AutomationAccountScheduleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountScheduleProperties : PropertyBase
    {

        public string Description { get; set; }

        public string StartTime { get; set; }

        public string ExpiryTime { get; set; }

        public object Interval { get; set; }

        public string Frequency { get; set; }

        public string TimeZone { get; set; }

        private AdvancedScheduleInfo _advancedSchedule;
        public AdvancedScheduleInfo AdvancedSchedule
        {
            get => _advancedSchedule = Get(_advancedSchedule);
            set => _advancedSchedule = value;
        }
    }

    public class AdvancedScheduleInfo : PropertyBase
    {

        public IList<string> WeekDays { get; set; }

        public IList<string> MonthDays { get; set; }

        public IList<MonthlyOccurrenceInfo> MonthlyOccurrences { get; set; }
    }

    public class MonthlyOccurrenceInfo : PropertyBase
    {

        public int? Occurrence { get; set; }

        public string Day { get; set; }
    }

    public class AutomationAccountSoftwareUpdateConfiguration : Resource<AutomationAccountSoftwareUpdateConfigurationProperties>
    {
        public AutomationAccountSoftwareUpdateConfiguration() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/softwareUpdateConfigurations", "2017-05-15-preview");
        public AutomationAccountSoftwareUpdateConfiguration(string name) : this() => Name = name;
        public AutomationAccountSoftwareUpdateConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountSoftwareUpdateConfiguration WithProperties(Action<AutomationAccountSoftwareUpdateConfigurationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountSoftwareUpdateConfigurationProperties : PropertyBase
    {

        private UpdateConfigurationInfo _updateConfiguration;
        public UpdateConfigurationInfo UpdateConfiguration
        {
            get => _updateConfiguration = Get(_updateConfiguration);
            set => _updateConfiguration = value;
        }

        private ScheduleInfoInfo _scheduleInfo;
        public ScheduleInfoInfo ScheduleInfo
        {
            get => _scheduleInfo = Get(_scheduleInfo);
            set => _scheduleInfo = value;
        }

        private ErrorInfo _error;
        public ErrorInfo Error
        {
            get => _error = Get(_error);
            set => _error = value;
        }

        private TasksInfo _tasks;
        public TasksInfo Tasks
        {
            get => _tasks = Get(_tasks);
            set => _tasks = value;
        }
    }

    public class UpdateConfigurationInfo : PropertyBase
    {

        public string OperatingSystem { get; set; }

        private WindowsInfo _windows;
        public WindowsInfo Windows
        {
            get => _windows = Get(_windows);
            set => _windows = value;
        }

        private LinuxInfo _linux;
        public LinuxInfo Linux
        {
            get => _linux = Get(_linux);
            set => _linux = value;
        }

        public string Duration { get; set; }

        public IList<string> AzureVirtualMachines { get; set; }

        public IList<string> NonAzureComputerNames { get; set; }

        private TargetsInfo _targets;
        public TargetsInfo Targets
        {
            get => _targets = Get(_targets);
            set => _targets = value;
        }
    }

    public class WindowsInfo : PropertyBase
    {

        public string IncludedUpdateClassifications { get; set; }

        public IList<string> ExcludedKbNumbers { get; set; }

        public IList<string> IncludedKbNumbers { get; set; }

        public string RebootSetting { get; set; }
    }

    public class LinuxInfo : PropertyBase
    {

        public string IncludedPackageClassifications { get; set; }

        public IList<string> ExcludedPackageNameMasks { get; set; }

        public IList<string> IncludedPackageNameMasks { get; set; }

        public string RebootSetting { get; set; }
    }

    public class TargetsInfo : PropertyBase
    {

        public IList<AzureQueryInfo> AzureQueries { get; set; }

        public IList<NonAzureQueryInfo> NonAzureQueries { get; set; }
    }

    public class AzureQueryInfo : PropertyBase
    {

        public IList<string> Scope { get; set; }

        public IList<string> Locations { get; set; }

        private TagSettingsInfo _tagSettings;
        public TagSettingsInfo TagSettings
        {
            get => _tagSettings = Get(_tagSettings);
            set => _tagSettings = value;
        }
    }

    public class TagSettingsInfo : PropertyBase
    {

        public object Tags { get; set; }

        public string FilterOperator { get; set; }
    }

    public class NonAzureQueryInfo : PropertyBase
    {

        public string FunctionAlias { get; set; }

        public string WorkspaceId { get; set; }
    }

    public class ScheduleInfoInfo : PropertyBase
    {

        public string StartTime { get; set; }

        public string ExpiryTime { get; set; }

        public string ExpiryTimeOffsetMinutes { get; set; }

        public bool? IsEnabled { get; set; }

        public string NextRun { get; set; }

        public string NextRunOffsetMinutes { get; set; }

        public int? Interval { get; set; }

        public string Frequency { get; set; }

        public string TimeZone { get; set; }

        private AdvancedScheduleInfo _advancedSchedule;
        public AdvancedScheduleInfo AdvancedSchedule
        {
            get => _advancedSchedule = Get(_advancedSchedule);
            set => _advancedSchedule = value;
        }

        public string CreationTime { get; set; }

        public string LastModifiedTime { get; set; }

        public string Description { get; set; }
    }

    public class ErrorInfo : PropertyBase
    {

        public string Code { get; set; }

        public string Message { get; set; }
    }

    public class TasksInfo : PropertyBase
    {

        private PreTaskInfo _preTask;
        public PreTaskInfo PreTask
        {
            get => _preTask = Get(_preTask);
            set => _preTask = value;
        }

        private PostTaskInfo _postTask;
        public PostTaskInfo PostTask
        {
            get => _postTask = Get(_postTask);
            set => _postTask = value;
        }
    }

    public class PreTaskInfo : PropertyBase
    {

        public object Parameters { get; set; }

        public string Source { get; set; }
    }

    public class PostTaskInfo : PropertyBase
    {

        public object Parameters { get; set; }

        public string Source { get; set; }
    }

    public class AutomationAccountSourceControlSourceControlSyncJob : Resource<AutomationAccountSourceControlSourceControlSyncJobProperties>
    {
        public AutomationAccountSourceControlSourceControlSyncJob() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/sourceControls/sourceControlSyncJobs", "2017-05-15-preview");
        public AutomationAccountSourceControlSourceControlSyncJob(string name) : this() => Name = name;
        public AutomationAccountSourceControlSourceControlSyncJob(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountSourceControlSourceControlSyncJob WithProperties(Action<AutomationAccountSourceControlSourceControlSyncJobProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountSourceControlSourceControlSyncJobProperties : PropertyBase
    {

        public string CommitId { get; set; }
    }

    public class AutomationAccountSourceControl : Resource<AutomationAccountSourceControlProperties>
    {
        public AutomationAccountSourceControl() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/sourceControls", "2017-05-15-preview");
        public AutomationAccountSourceControl(string name) : this() => Name = name;
        public AutomationAccountSourceControl(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountSourceControl WithProperties(Action<AutomationAccountSourceControlProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountSourceControlProperties : PropertyBase
    {

        public string RepoUrl { get; set; }

        public string Branch { get; set; }

        public string FolderPath { get; set; }

        public bool? AutoSync { get; set; }

        public bool? PublishRunbook { get; set; }

        public string SourceType { get; set; }

        private SecurityTokenInfo _securityToken;
        public SecurityTokenInfo SecurityToken
        {
            get => _securityToken = Get(_securityToken);
            set => _securityToken = value;
        }

        public string Description { get; set; }
    }

    public class SecurityTokenInfo : PropertyBase
    {

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public string TokenType { get; set; }
    }

    public class AutomationAccountVariable : Resource<AutomationAccountVariableProperties>
    {
        public AutomationAccountVariable() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/variables", "2015-10-31");
        public AutomationAccountVariable(string name) : this() => Name = name;
        public AutomationAccountVariable(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountVariable WithProperties(Action<AutomationAccountVariableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountVariableProperties : PropertyBase
    {

        public string Value { get; set; }

        public string Description { get; set; }

        public bool? IsEncrypted { get; set; }
    }

    public class AutomationAccountWatcher : Resource<AutomationAccountWatcherProperties>
    {
        public AutomationAccountWatcher() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/watchers", "2015-10-31");
        public AutomationAccountWatcher(string name) : this() => Name = name;
        public AutomationAccountWatcher(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountWatcher WithProperties(Action<AutomationAccountWatcherProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountWatcherProperties : PropertyBase
    {

        public int? ExecutionFrequencyInSeconds { get; set; }

        public string ScriptName { get; set; }

        public object ScriptParameters { get; set; }

        public string ScriptRunOn { get; set; }

        public string Description { get; set; }
    }

    public class AutomationAccountWebhook : Resource<AutomationAccountWebhookProperties>
    {
        public AutomationAccountWebhook() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts/webhooks", "2015-10-31");
        public AutomationAccountWebhook(string name) : this() => Name = name;
        public AutomationAccountWebhook(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccountWebhook WithProperties(Action<AutomationAccountWebhookProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountWebhookProperties : PropertyBase
    {

        public bool? IsEnabled { get; set; }

        public string Uri { get; set; }

        public string ExpiryTime { get; set; }

        public object Parameters { get; set; }

        private RunbookInfo _runbook;
        public RunbookInfo Runbook
        {
            get => _runbook = Get(_runbook);
            set => _runbook = value;
        }

        public string RunOn { get; set; }
    }

    public class AutomationAccount : Resource<AutomationAccountProperties>
    {
        public AutomationAccount() => (Type, ApiVersion) = ("Microsoft.Automation/automationAccounts", "2015-10-31");
        public AutomationAccount(string name) : this() => Name = name;
        public AutomationAccount(string name, Location location) : this() => (Name, Location) = (name, location);

        public AutomationAccount WithProperties(Action<AutomationAccountProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AutomationAccountProperties : PropertyBase
    {

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }
    }

    public class SkuInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Family { get; set; }

        public int? Capacity { get; set; }
    }
}
