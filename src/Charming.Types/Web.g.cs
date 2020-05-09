namespace Charming.Types.Web
{
    using Charming;
    using System.Collections.Generic;

    public partial class Certificate : Resource<CertificateProperties>
    {
        public Certificate() => (Type, ApiVersion) = ("Microsoft.Web/certificates", "2019-08-01");
        public Certificate(string name) : this() => Name = name;
        public Certificate(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class CertificateProperties
    {
        public IList<string> HostNames { get; set; }
        public IList<string> PfxBlob { get; set; }
        public string Password { get; set; }
        public string KeyVaultId { get; set; }
        public string KeyVaultSecretName { get; set; }
        public string ServerFarmId { get; set; }
        public string CanonicalName { get; set; }
    }

    public partial class ConnectionGateway : Resource<ConnectionGatewayProperties>
    {
        public ConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/connectionGateways", "2016-06-01");
        public ConnectionGateway(string name) : this() => Name = name;
        public ConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ConnectionGatewayProperties
    {
        public ConnectionGatewayInstallationInfo ConnectionGatewayInstallation { get; set; }
        public IList<string> ContactInformation { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string MachineName { get; set; }
        public object Status { get; set; }
        public string BackendUri { get; set; }
    }

    public partial class ConnectionGatewayInstallationInfo
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
    }

    public partial class Connection : Resource<ConnectionProperties>
    {
        public Connection() => (Type, ApiVersion) = ("Microsoft.Web/connections", "2016-06-01");
        public Connection(string name) : this() => Name = name;
        public Connection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ConnectionProperties
    {
        public string DisplayName { get; set; }
        public IList<StatuseInfo> Statuses { get; set; }
        public object ParameterValues { get; set; }
        public object CustomParameterValues { get; set; }
        public object NonSecretParameterValues { get; set; }
        public ApiInfo Api { get; set; }
        public IList<TestLinkInfo> TestLinks { get; set; }
    }

    public partial class StatuseInfo
    {
        public string Status { get; set; }
        public string Target { get; set; }
        public ErrorInfo Error { get; set; }
    }

    public partial class ErrorInfo
    {
        public string Location { get; set; }
        public object Tags { get; set; }
        public PropertiesInfo Properties { get; set; }
    }

    public partial class PropertiesInfo
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }

    public partial class ApiInfo
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public object Swagger { get; set; }
        public string BrandColor { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string IconUri { get; set; }
        public string Name { get; set; }
    }

    public partial class TestLinkInfo
    {
        public string RequestUri { get; set; }
        public string Method { get; set; }
    }

    public partial class CustomApi : Resource<CustomApiProperties>
    {
        public CustomApi() => (Type, ApiVersion) = ("Microsoft.Web/customApis", "2016-06-01");
        public CustomApi(string name) : this() => Name = name;
        public CustomApi(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class CustomApiProperties
    {
        public object ConnectionParameters { get; set; }
        public IList<string> RuntimeUrls { get; set; }
        public IList<string> Capabilities { get; set; }
        public object Swagger { get; set; }
        public string BrandColor { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string IconUri { get; set; }
        public BackendServiceInfo BackendService { get; set; }
        public ApiDefinitionsInfo ApiDefinitions { get; set; }
        public string ApiType { get; set; }
        public WsdlDefinitionInfo WsdlDefinition { get; set; }
    }

    public partial class BackendServiceInfo
    {
        public string ServiceUrl { get; set; }
    }

    public partial class ApiDefinitionsInfo
    {
        public string OriginalSwaggerUrl { get; set; }
        public string ModifiedSwaggerUrl { get; set; }
    }

    public partial class WsdlDefinitionInfo
    {
        public string Url { get; set; }
        public string Content { get; set; }
        public ServiceInfo Service { get; set; }
        public string ImportMethod { get; set; }
    }

    public partial class ServiceInfo
    {
        public string QualifiedName { get; set; }
        public IList<string> EndpointQualifiedNames { get; set; }
    }

    public partial class HostingEnvironmentWorkerPool : Resource<HostingEnvironmentWorkerPoolProperties>
    {
        public HostingEnvironmentWorkerPool() => (Type, ApiVersion) = ("Microsoft.Web/hostingEnvironments/workerPools", "2019-08-01");
        public HostingEnvironmentWorkerPool(string name) : this() => Name = name;
        public HostingEnvironmentWorkerPool(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class HostingEnvironmentWorkerPoolProperties
    {
        public int? WorkerSizeId { get; set; }
        public string ComputeMode { get; set; }
        public string WorkerSize { get; set; }
        public int? WorkerCount { get; set; }
    }

    public partial class SkuCapacityInfo
    {
        public int? Minimum { get; set; }
        public int? Maximum { get; set; }
        public int? Default { get; set; }
        public string ScaleType { get; set; }
    }

    public partial class CapabilityInfo
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Reason { get; set; }
    }

    public partial class HostingEnvironment : Resource<HostingEnvironmentProperties>
    {
        public HostingEnvironment() => (Type, ApiVersion) = ("Microsoft.Web/hostingEnvironments", "2019-08-01");
        public HostingEnvironment(string name) : this() => Name = name;
        public HostingEnvironment(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class HostingEnvironmentProperties
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string VnetName { get; set; }
        public string VnetResourceGroupName { get; set; }
        public string VnetSubnetName { get; set; }
        public VirtualNetworkInfo VirtualNetwork { get; set; }
        public string InternalLoadBalancingMode { get; set; }
        public string MultiSize { get; set; }
        public int? MultiRoleCount { get; set; }
        public IList<WorkerPoolInfo> WorkerPools { get; set; }
        public int? IpsslAddressCount { get; set; }
        public string DnsSuffix { get; set; }
        public IList<NetworkAccessControlListInfo> NetworkAccessControlList { get; set; }
        public int? FrontEndScaleFactor { get; set; }
        public string ApiManagementAccountId { get; set; }
        public bool? Suspended { get; set; }
        public bool? DynamicCacheEnabled { get; set; }
        public IList<ClusterSettingInfo> ClusterSettings { get; set; }
        public IList<string> UserWhitelistedIpRanges { get; set; }
        public bool? HasLinuxWorkers { get; set; }
        public string SslCertKeyVaultId { get; set; }
        public string SslCertKeyVaultSecretName { get; set; }
    }

    public partial class VirtualNetworkInfo
    {
        public string Id { get; set; }
        public string Subnet { get; set; }
    }

    public partial class WorkerPoolInfo
    {
        public int? WorkerSizeId { get; set; }
        public string ComputeMode { get; set; }
        public string WorkerSize { get; set; }
        public int? WorkerCount { get; set; }
    }

    public partial class NetworkAccessControlListInfo
    {
        public string Action { get; set; }
        public string Description { get; set; }
        public int? Order { get; set; }
        public string RemoteSubnet { get; set; }
    }

    public partial class ClusterSettingInfo
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public partial class ServerfarmVirtualNetworkConnectionGateway : Resource<ServerfarmVirtualNetworkConnectionGatewayProperties>
    {
        public ServerfarmVirtualNetworkConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/serverfarms/virtualNetworkConnections/gateways", "2019-08-01");
        public ServerfarmVirtualNetworkConnectionGateway(string name) : this() => Name = name;
        public ServerfarmVirtualNetworkConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerfarmVirtualNetworkConnectionGatewayProperties
    {
        public string VnetName { get; set; }
        public string VpnPackageUri { get; set; }
    }

    public partial class ServerfarmVirtualNetworkConnectionRoute : Resource<ServerfarmVirtualNetworkConnectionRouteProperties>
    {
        public ServerfarmVirtualNetworkConnectionRoute() => (Type, ApiVersion) = ("Microsoft.Web/serverfarms/virtualNetworkConnections/routes", "2019-08-01");
        public ServerfarmVirtualNetworkConnectionRoute(string name) : this() => Name = name;
        public ServerfarmVirtualNetworkConnectionRoute(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerfarmVirtualNetworkConnectionRouteProperties
    {
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public string RouteType { get; set; }
    }

    public partial class Serverfarm : Resource<ServerfarmProperties>
    {
        public Serverfarm() => (Type, ApiVersion) = ("Microsoft.Web/serverfarms", "2019-08-01");
        public Serverfarm(string name) : this() => Name = name;
        public Serverfarm(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServerfarmProperties
    {
        public string WorkerTierName { get; set; }
        public HostingEnvironmentProfileInfo HostingEnvironmentProfile { get; set; }
        public bool? PerSiteScaling { get; set; }
        public int? MaximumElasticWorkerCount { get; set; }
        public bool? IsSpot { get; set; }
        public string SpotExpirationTime { get; set; }
        public string FreeOfferExpirationTime { get; set; }
        public bool? Reserved { get; set; }
        public bool? IsXenon { get; set; }
        public bool? HyperV { get; set; }
        public int? TargetWorkerCount { get; set; }
        public int? TargetWorkerSizeId { get; set; }
    }

    public partial class HostingEnvironmentProfileInfo
    {
        public string Id { get; set; }
    }

    public partial class SiteConfig : Resource<SiteConfigProperties>
    {
        public SiteConfig() => (Type, ApiVersion) = ("Microsoft.Web/sites/config", "2019-08-01");
        public SiteConfig(string name) : this() => Name = name;
        public SiteConfig(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteConfigProperties
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

    public partial class SiteDeployment : Resource<SiteDeploymentProperties>
    {
        public SiteDeployment() => (Type, ApiVersion) = ("Microsoft.Web/sites/deployments", "2019-08-01");
        public SiteDeployment(string name) : this() => Name = name;
        public SiteDeployment(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteDeploymentProperties
    {
        public int? Status { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public string Deployer { get; set; }
        public string Author_email { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }
        public bool? Active { get; set; }
        public string Details { get; set; }
    }

    public partial class SiteDomainOwnershipIdentifier : Resource<SiteDomainOwnershipIdentifierProperties>
    {
        public SiteDomainOwnershipIdentifier() => (Type, ApiVersion) = ("Microsoft.Web/sites/domainOwnershipIdentifiers", "2019-08-01");
        public SiteDomainOwnershipIdentifier(string name) : this() => Name = name;
        public SiteDomainOwnershipIdentifier(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteDomainOwnershipIdentifierProperties
    {
        public string Id { get; set; }
    }

    public partial class SiteFunction : Resource<SiteFunctionProperties>
    {
        public SiteFunction() => (Type, ApiVersion) = ("Microsoft.Web/sites/functions", "2019-08-01");
        public SiteFunction(string name) : this() => Name = name;
        public SiteFunction(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteFunctionProperties
    {
        public string Function_app_id { get; set; }
        public string Script_root_path_href { get; set; }
        public string Script_href { get; set; }
        public string Config_href { get; set; }
        public string Test_data_href { get; set; }
        public string Secrets_file_href { get; set; }
        public string Href { get; set; }
        public object Config { get; set; }
        public object Files { get; set; }
        public string Test_data { get; set; }
        public string Invoke_url_template { get; set; }
        public string Language { get; set; }
        public bool? IsDisabled { get; set; }
    }

    public partial class SiteHostNameBinding : Resource<SiteHostNameBindingProperties>
    {
        public SiteHostNameBinding() => (Type, ApiVersion) = ("Microsoft.Web/sites/hostNameBindings", "2019-08-01");
        public SiteHostNameBinding(string name) : this() => Name = name;
        public SiteHostNameBinding(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteHostNameBindingProperties
    {
        public string SiteName { get; set; }
        public string DomainId { get; set; }
        public string AzureResourceName { get; set; }
        public string AzureResourceType { get; set; }
        public string CustomHostNameDnsRecordType { get; set; }
        public string HostNameType { get; set; }
        public string SslState { get; set; }
        public string Thumbprint { get; set; }
    }

    public partial class SiteHybridconnection : Resource<SiteHybridconnectionProperties>
    {
        public SiteHybridconnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/hybridconnection", "2019-08-01");
        public SiteHybridconnection(string name) : this() => Name = name;
        public SiteHybridconnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteHybridconnectionProperties
    {
        public string EntityName { get; set; }
        public string EntityConnectionString { get; set; }
        public string ResourceType { get; set; }
        public string ResourceConnectionString { get; set; }
        public string Hostname { get; set; }
        public int? Port { get; set; }
        public string BiztalkUri { get; set; }
    }

    public partial class SiteHybridConnectionNamespaceRelay : Resource<SiteHybridConnectionNamespaceRelayProperties>
    {
        public SiteHybridConnectionNamespaceRelay() => (Type, ApiVersion) = ("Microsoft.Web/sites/hybridConnectionNamespaces/relays", "2019-08-01");
        public SiteHybridConnectionNamespaceRelay(string name) : this() => Name = name;
        public SiteHybridConnectionNamespaceRelay(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteHybridConnectionNamespaceRelayProperties
    {
        public string ServiceBusNamespace { get; set; }
        public string RelayName { get; set; }
        public string RelayArmUri { get; set; }
        public string Hostname { get; set; }
        public int? Port { get; set; }
        public string SendKeyName { get; set; }
        public string SendKeyValue { get; set; }
        public string ServiceBusSuffix { get; set; }
    }

    public partial class SitePremieraddon : Resource<SitePremieraddonProperties>
    {
        public SitePremieraddon() => (Type, ApiVersion) = ("Microsoft.Web/sites/premieraddons", "2019-08-01");
        public SitePremieraddon(string name) : this() => Name = name;
        public SitePremieraddon(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SitePremieraddonProperties
    {
        public string Sku { get; set; }
        public string Product { get; set; }
        public string Vendor { get; set; }
        public string MarketplacePublisher { get; set; }
        public string MarketplaceOffer { get; set; }
    }

    public partial class SitePublicCertificate : Resource<SitePublicCertificateProperties>
    {
        public SitePublicCertificate() => (Type, ApiVersion) = ("Microsoft.Web/sites/publicCertificates", "2019-08-01");
        public SitePublicCertificate(string name) : this() => Name = name;
        public SitePublicCertificate(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SitePublicCertificateProperties
    {
        public IList<string> Blob { get; set; }
        public string PublicCertificateLocation { get; set; }
    }

    public partial class SiteSlotConfig : Resource<SiteSlotConfigProperties>
    {
        public SiteSlotConfig() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/config", "2019-08-01");
        public SiteSlotConfig(string name) : this() => Name = name;
        public SiteSlotConfig(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotConfigProperties
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

    public partial class SiteSlotDeployment : Resource<SiteSlotDeploymentProperties>
    {
        public SiteSlotDeployment() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/deployments", "2019-08-01");
        public SiteSlotDeployment(string name) : this() => Name = name;
        public SiteSlotDeployment(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotDeploymentProperties
    {
        public int? Status { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public string Deployer { get; set; }
        public string Author_email { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }
        public bool? Active { get; set; }
        public string Details { get; set; }
    }

    public partial class SiteSlotDomainOwnershipIdentifier : Resource<SiteSlotDomainOwnershipIdentifierProperties>
    {
        public SiteSlotDomainOwnershipIdentifier() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/domainOwnershipIdentifiers", "2019-08-01");
        public SiteSlotDomainOwnershipIdentifier(string name) : this() => Name = name;
        public SiteSlotDomainOwnershipIdentifier(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotDomainOwnershipIdentifierProperties
    {
        public string Id { get; set; }
    }

    public partial class SiteSlotFunction : Resource<SiteSlotFunctionProperties>
    {
        public SiteSlotFunction() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/functions", "2019-08-01");
        public SiteSlotFunction(string name) : this() => Name = name;
        public SiteSlotFunction(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotFunctionProperties
    {
        public string Function_app_id { get; set; }
        public string Script_root_path_href { get; set; }
        public string Script_href { get; set; }
        public string Config_href { get; set; }
        public string Test_data_href { get; set; }
        public string Secrets_file_href { get; set; }
        public string Href { get; set; }
        public object Config { get; set; }
        public object Files { get; set; }
        public string Test_data { get; set; }
        public string Invoke_url_template { get; set; }
        public string Language { get; set; }
        public bool? IsDisabled { get; set; }
    }

    public partial class SiteSlotHostNameBinding : Resource<SiteSlotHostNameBindingProperties>
    {
        public SiteSlotHostNameBinding() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/hostNameBindings", "2019-08-01");
        public SiteSlotHostNameBinding(string name) : this() => Name = name;
        public SiteSlotHostNameBinding(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotHostNameBindingProperties
    {
        public string SiteName { get; set; }
        public string DomainId { get; set; }
        public string AzureResourceName { get; set; }
        public string AzureResourceType { get; set; }
        public string CustomHostNameDnsRecordType { get; set; }
        public string HostNameType { get; set; }
        public string SslState { get; set; }
        public string Thumbprint { get; set; }
    }

    public partial class SiteSlotHybridconnection : Resource<SiteSlotHybridconnectionProperties>
    {
        public SiteSlotHybridconnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/hybridconnection", "2019-08-01");
        public SiteSlotHybridconnection(string name) : this() => Name = name;
        public SiteSlotHybridconnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotHybridconnectionProperties
    {
        public string EntityName { get; set; }
        public string EntityConnectionString { get; set; }
        public string ResourceType { get; set; }
        public string ResourceConnectionString { get; set; }
        public string Hostname { get; set; }
        public int? Port { get; set; }
        public string BiztalkUri { get; set; }
    }

    public partial class SiteSlotHybridConnectionNamespaceRelay : Resource<SiteSlotHybridConnectionNamespaceRelayProperties>
    {
        public SiteSlotHybridConnectionNamespaceRelay() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays", "2019-08-01");
        public SiteSlotHybridConnectionNamespaceRelay(string name) : this() => Name = name;
        public SiteSlotHybridConnectionNamespaceRelay(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotHybridConnectionNamespaceRelayProperties
    {
        public string ServiceBusNamespace { get; set; }
        public string RelayName { get; set; }
        public string RelayArmUri { get; set; }
        public string Hostname { get; set; }
        public int? Port { get; set; }
        public string SendKeyName { get; set; }
        public string SendKeyValue { get; set; }
        public string ServiceBusSuffix { get; set; }
    }

    public partial class SiteSlotPremieraddon : Resource<SiteSlotPremieraddonProperties>
    {
        public SiteSlotPremieraddon() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/premieraddons", "2019-08-01");
        public SiteSlotPremieraddon(string name) : this() => Name = name;
        public SiteSlotPremieraddon(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotPremieraddonProperties
    {
        public string Sku { get; set; }
        public string Product { get; set; }
        public string Vendor { get; set; }
        public string MarketplacePublisher { get; set; }
        public string MarketplaceOffer { get; set; }
    }

    public partial class SiteSlotPublicCertificate : Resource<SiteSlotPublicCertificateProperties>
    {
        public SiteSlotPublicCertificate() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/publicCertificates", "2019-08-01");
        public SiteSlotPublicCertificate(string name) : this() => Name = name;
        public SiteSlotPublicCertificate(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotPublicCertificateProperties
    {
        public IList<string> Blob { get; set; }
        public string PublicCertificateLocation { get; set; }
    }

    public partial class SiteSlotSourcecontrol : Resource<SiteSlotSourcecontrolProperties>
    {
        public SiteSlotSourcecontrol() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/sourcecontrols", "2019-08-01");
        public SiteSlotSourcecontrol(string name) : this() => Name = name;
        public SiteSlotSourcecontrol(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotSourcecontrolProperties
    {
        public string RepoUrl { get; set; }
        public string Branch { get; set; }
        public bool? IsManualIntegration { get; set; }
        public bool? DeploymentRollbackEnabled { get; set; }
        public bool? IsMercurial { get; set; }
    }

    public partial class SiteSlotVirtualNetworkConnectionGateway : Resource<SiteSlotVirtualNetworkConnectionGatewayProperties>
    {
        public SiteSlotVirtualNetworkConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/virtualNetworkConnections/gateways", "2019-08-01");
        public SiteSlotVirtualNetworkConnectionGateway(string name) : this() => Name = name;
        public SiteSlotVirtualNetworkConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotVirtualNetworkConnectionGatewayProperties
    {
        public string VnetName { get; set; }
        public string VpnPackageUri { get; set; }
    }

    public partial class SiteSlotVirtualNetworkConnection : Resource<SiteSlotVirtualNetworkConnectionProperties>
    {
        public SiteSlotVirtualNetworkConnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/virtualNetworkConnections", "2019-08-01");
        public SiteSlotVirtualNetworkConnection(string name) : this() => Name = name;
        public SiteSlotVirtualNetworkConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSlotVirtualNetworkConnectionProperties
    {
        public string VnetResourceId { get; set; }
        public string CertBlob { get; set; }
        public string DnsServers { get; set; }
        public bool? IsSwift { get; set; }
    }

    public partial class SiteSlot : Resource<SiteSlotProperties>
    {
        public SiteSlot() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots", "2019-08-01");
        public SiteSlot(string name) : this() => Name = name;
        public SiteSlot(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class SiteSlotProperties
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

    public partial class SiteSourcecontrol : Resource<SiteSourcecontrolProperties>
    {
        public SiteSourcecontrol() => (Type, ApiVersion) = ("Microsoft.Web/sites/sourcecontrols", "2019-08-01");
        public SiteSourcecontrol(string name) : this() => Name = name;
        public SiteSourcecontrol(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteSourcecontrolProperties
    {
        public string RepoUrl { get; set; }
        public string Branch { get; set; }
        public bool? IsManualIntegration { get; set; }
        public bool? DeploymentRollbackEnabled { get; set; }
        public bool? IsMercurial { get; set; }
    }

    public partial class SiteVirtualNetworkConnectionGateway : Resource<SiteVirtualNetworkConnectionGatewayProperties>
    {
        public SiteVirtualNetworkConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/sites/virtualNetworkConnections/gateways", "2019-08-01");
        public SiteVirtualNetworkConnectionGateway(string name) : this() => Name = name;
        public SiteVirtualNetworkConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteVirtualNetworkConnectionGatewayProperties
    {
        public string VnetName { get; set; }
        public string VpnPackageUri { get; set; }
    }

    public partial class SiteVirtualNetworkConnection : Resource<SiteVirtualNetworkConnectionProperties>
    {
        public SiteVirtualNetworkConnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/virtualNetworkConnections", "2019-08-01");
        public SiteVirtualNetworkConnection(string name) : this() => Name = name;
        public SiteVirtualNetworkConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SiteVirtualNetworkConnectionProperties
    {
        public string VnetResourceId { get; set; }
        public string CertBlob { get; set; }
        public string DnsServers { get; set; }
        public bool? IsSwift { get; set; }
    }

    public partial class Site : Resource<SiteProperties>
    {
        public Site() => (Type, ApiVersion) = ("Microsoft.Web/sites", "2019-08-01");
        public Site(string name) : this() => Name = name;
        public Site(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class SiteProperties
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

    public partial class Sourcecontrol : Resource<SourcecontrolProperties>
    {
        public Sourcecontrol() => (Type, ApiVersion) = ("Microsoft.Web/sourcecontrols", "2019-08-01");
        public Sourcecontrol(string name) : this() => Name = name;
        public Sourcecontrol(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SourcecontrolProperties
    {
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        public string RefreshToken { get; set; }
        public string ExpirationTime { get; set; }
    }
}
