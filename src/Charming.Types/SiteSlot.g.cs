namespace Charming.Types.Web
{
    using Charming;
    using System.Collections.Generic;

    public class SiteSlot : Resource<SiteSlot.PropertyCollection>
    {
        public SiteSlot() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots", "2019-08-01");

        public IdentityInfo Identity { get; set; }

        public partial class PropertyCollection
        {
            public bool? Enabled { get; set; }
            public IList<HostNameSslStateInfo> HostNameSslStates { get; set; }
            public string ServerFarmId { get; set; }
            public bool? Reserved { get; set; }
            public bool? IsXenon { get; set; }
            public bool? HyperV { get; set; }
            public SiteConfigInfo SiteConfig { get; set; }
            public bool? ScmSiteAlsoStopped { get; set; }
            public HostingEnvironmentProfileInfo HostingEnvironmentProfile { get; set; }
            public bool? ClientAffinityEnabled { get; set; }
            public bool? ClientCertEnabled { get; set; }
            public string ClientCertExclusionPaths { get; set; }
            public bool? HostNamesDisabled { get; set; }
            public int? ContainerSize { get; set; }
            public int? DailyMemoryTimeQuota { get; set; }
            public CloningInfoInfo CloningInfo { get; set; }
            public bool? HttpsOnly { get; set; }
            public string RedundancyMode { get; set; }
        }

        public partial class HostNameSslStateInfo
        {
            public string Name { get; set; }
            public string SslState { get; set; }
            public string VirtualIP { get; set; }
            public string Thumbprint { get; set; }
            public bool? ToUpdate { get; set; }
            public string HostType { get; set; }
        }

        public partial class SiteConfigInfo
        {
            public int? NumberOfWorkers { get; set; }
            public IList<string> DefaultDocuments { get; set; }
            public string NetFrameworkVersion { get; set; }
            public string PhpVersion { get; set; }
            public string PythonVersion { get; set; }
            public string NodeVersion { get; set; }
            public string LinuxFxVersion { get; set; }
            public string WindowsFxVersion { get; set; }
            public bool? RequestTracingEnabled { get; set; }
            public string RequestTracingExpirationTime { get; set; }
            public bool? RemoteDebuggingEnabled { get; set; }
            public string RemoteDebuggingVersion { get; set; }
            public bool? HttpLoggingEnabled { get; set; }
            public int? LogsDirectorySizeLimit { get; set; }
            public bool? DetailedErrorLoggingEnabled { get; set; }
            public string PublishingUsername { get; set; }
            public IList<AppSettingInfo> AppSettings { get; set; }
            public IList<ConnectionStringInfo> ConnectionStrings { get; set; }
            public IList<HandlerMappingInfo> HandlerMappings { get; set; }
            public string DocumentRoot { get; set; }
            public string ScmType { get; set; }
            public bool? Use32BitWorkerProcess { get; set; }
            public bool? WebSocketsEnabled { get; set; }
            public bool? AlwaysOn { get; set; }
            public string JavaVersion { get; set; }
            public string JavaContainer { get; set; }
            public string JavaContainerVersion { get; set; }
            public string AppCommandLine { get; set; }
            public string ManagedPipelineMode { get; set; }
            public IList<VirtualApplicationInfo> VirtualApplications { get; set; }
            public string LoadBalancing { get; set; }
            public ExperimentsInfo Experiments { get; set; }
            public LimitsInfo Limits { get; set; }
            public bool? AutoHealEnabled { get; set; }
            public AutoHealRulesInfo AutoHealRules { get; set; }
            public string TracingOptions { get; set; }
            public string VnetName { get; set; }
            public CorsInfo Cors { get; set; }
            public PushInfo Push { get; set; }
            public ApiDefinitionInfo ApiDefinition { get; set; }
            public ApiManagementConfigInfo ApiManagementConfig { get; set; }
            public string AutoSwapSlotName { get; set; }
            public bool? LocalMySqlEnabled { get; set; }
            public int? ManagedServiceIdentityId { get; set; }
            public int? XManagedServiceIdentityId { get; set; }
            public IList<IpSecurityRestrictionInfo> IpSecurityRestrictions { get; set; }
            public IList<ScmIpSecurityRestrictionInfo> ScmIpSecurityRestrictions { get; set; }
            public bool? ScmIpSecurityRestrictionsUseMain { get; set; }
            public bool? Http20Enabled { get; set; }
            public string MinTlsVersion { get; set; }
            public string FtpsState { get; set; }
            public int? PreWarmedInstanceCount { get; set; }
            public string HealthCheckPath { get; set; }
        }

        public partial class AppSettingInfo
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public partial class ConnectionStringInfo
        {
            public string Name { get; set; }
            public string ConnectionString { get; set; }
            public string Type { get; set; }
        }

        public partial class HandlerMappingInfo
        {
            public string Extension { get; set; }
            public string ScriptProcessor { get; set; }
            public string Arguments { get; set; }
        }

        public partial class VirtualApplicationInfo
        {
            public string VirtualPath { get; set; }
            public string PhysicalPath { get; set; }
            public bool? PreloadEnabled { get; set; }
            public IList<VirtualDirectoryInfo> VirtualDirectories { get; set; }
        }

        public partial class VirtualDirectoryInfo
        {
            public string VirtualPath { get; set; }
            public string PhysicalPath { get; set; }
        }

        public partial class ExperimentsInfo
        {
            public IList<RampUpRuleInfo> RampUpRules { get; set; }
        }

        public partial class RampUpRuleInfo
        {
            public string ActionHostName { get; set; }
            public string ReroutePercentage { get; set; }
            public string ChangeStep { get; set; }
            public int? ChangeIntervalInMinutes { get; set; }
            public string MinReroutePercentage { get; set; }
            public string MaxReroutePercentage { get; set; }
            public string ChangeDecisionCallbackUrl { get; set; }
            public string Name { get; set; }
        }

        public partial class LimitsInfo
        {
            public string MaxPercentageCpu { get; set; }
            public int? MaxMemoryInMb { get; set; }
            public int? MaxDiskSizeInMb { get; set; }
        }

        public partial class AutoHealRulesInfo
        {
            public TriggersInfo Triggers { get; set; }
            public ActionsInfo Actions { get; set; }
        }

        public partial class TriggersInfo
        {
            public RequestsInfo Requests { get; set; }
            public int? PrivateBytesInKB { get; set; }
            public IList<StatusCodeInfo> StatusCodes { get; set; }
            public SlowRequestsInfo SlowRequests { get; set; }
        }

        public partial class RequestsInfo
        {
            public int? Count { get; set; }
            public string TimeInterval { get; set; }
        }

        public partial class StatusCodeInfo
        {
            public int? Status { get; set; }
            public int? SubStatus { get; set; }
            public int? Win32Status { get; set; }
            public int? Count { get; set; }
            public string TimeInterval { get; set; }
        }

        public partial class SlowRequestsInfo
        {
            public string TimeTaken { get; set; }
            public int? Count { get; set; }
            public string TimeInterval { get; set; }
        }

        public partial class ActionsInfo
        {
            public string ActionType { get; set; }
            public CustomActionInfo CustomAction { get; set; }
            public string MinProcessExecutionTime { get; set; }
        }

        public partial class CustomActionInfo
        {
            public string Exe { get; set; }
            public string Parameters { get; set; }
        }

        public partial class CorsInfo
        {
            public IList<string> AllowedOrigins { get; set; }
            public bool? SupportCredentials { get; set; }
        }

        public partial class PushInfo
        {
            public string Kind { get; set; }
            public PropertiesInfo Properties { get; set; }
        }

        public partial class PropertiesInfo
        {
            public bool? IsPushEnabled { get; set; }
            public string TagWhitelistJson { get; set; }
            public string TagsRequiringAuth { get; set; }
            public string DynamicTagsJson { get; set; }
        }

        public partial class ApiDefinitionInfo
        {
            public string Url { get; set; }
        }

        public partial class ApiManagementConfigInfo
        {
            public string Id { get; set; }
        }

        public partial class IpSecurityRestrictionInfo
        {
            public string IpAddress { get; set; }
            public string SubnetMask { get; set; }
            public string VnetSubnetResourceId { get; set; }
            public string Action { get; set; }
            public string Tag { get; set; }
            public int? Priority { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public partial class ScmIpSecurityRestrictionInfo
        {
            public string IpAddress { get; set; }
            public string SubnetMask { get; set; }
            public string VnetSubnetResourceId { get; set; }
            public string Action { get; set; }
            public string Tag { get; set; }
            public int? Priority { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public partial class HostingEnvironmentProfileInfo
        {
            public string Id { get; set; }
        }

        public partial class CloningInfoInfo
        {
            public string CorrelationId { get; set; }
            public bool? Overwrite { get; set; }
            public bool? CloneCustomHostNames { get; set; }
            public bool? CloneSourceControl { get; set; }
            public string SourceWebAppId { get; set; }
            public string SourceWebAppLocation { get; set; }
            public string HostingEnvironment { get; set; }
            public object AppSettingsOverrides { get; set; }
            public bool? ConfigureLoadBalancing { get; set; }
            public string TrafficManagerProfileId { get; set; }
            public string TrafficManagerProfileName { get; set; }
        }

        public partial class IdentityInfo
        {
            public string Type { get; set; }
            public object UserAssignedIdentities { get; set; }
        }
    }
}
