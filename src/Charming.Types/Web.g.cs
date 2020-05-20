namespace Charming.Types.Web
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class Certificate : Resource<CertificateProperties>
    {
        public Certificate() => (Type, ApiVersion) = ("Microsoft.Web/certificates", "2019-08-01");
        public Certificate(string name) : this() => Name = name;
        public Certificate(string name, Location location) : this() => (Name, Location) = (name, location);

        public Certificate WithProperties(Action<CertificateProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class CertificateProperties : PropertyBase
    {

        public IList<string> HostNames { get; set; }

        public IList<string> PfxBlob { get; set; }

        public string Password { get; set; }

        public string KeyVaultId { get; set; }

        public string KeyVaultSecretName { get; set; }

        public string ServerFarmId { get; set; }

        public string CanonicalName { get; set; }
    }

    public class ConnectionGateway : Resource<ConnectionGatewayProperties>
    {
        public ConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/connectionGateways", "2016-06-01");
        public ConnectionGateway(string name) : this() => Name = name;
        public ConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public ConnectionGateway WithProperties(Action<ConnectionGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ConnectionGatewayProperties : PropertyBase
    {

        private ConnectionGatewayInstallationInfo _connectionGatewayInstallation;
        public ConnectionGatewayInstallationInfo ConnectionGatewayInstallation
        {
            get => _connectionGatewayInstallation = Get(_connectionGatewayInstallation);
            set => _connectionGatewayInstallation = value;
        }

        public IList<string> ContactInformation { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string MachineName { get; set; }

        public object Status { get; set; }

        public string BackendUri { get; set; }
    }

    public class ConnectionGatewayInstallationInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }

        public string Name { get; set; }
    }

    public class Connection : Resource<ConnectionProperties>
    {
        public Connection() => (Type, ApiVersion) = ("Microsoft.Web/connections", "2016-06-01");
        public Connection(string name) : this() => Name = name;
        public Connection(string name, Location location) : this() => (Name, Location) = (name, location);

        public Connection WithProperties(Action<ConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ConnectionProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public IList<StatuseInfo> Statuses { get; set; }

        public object ParameterValues { get; set; }

        public object CustomParameterValues { get; set; }

        public object NonSecretParameterValues { get; set; }

        private ApiInfo _api;
        public ApiInfo Api
        {
            get => _api = Get(_api);
            set => _api = value;
        }

        public IList<TestLinkInfo> TestLinks { get; set; }
    }

    public class StatuseInfo : PropertyBase
    {

        public string Status { get; set; }

        public string Target { get; set; }

        private ErrorInfo _error;
        public ErrorInfo Error
        {
            get => _error = Get(_error);
            set => _error = value;
        }
    }

    public class ErrorInfo : PropertyBase
    {

        public string Location { get; set; }

        public object Tags { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class PropertiesInfo : PropertyBase
    {

        public string Code { get; set; }

        public string Message { get; set; }
    }

    public class ApiInfo : PropertyBase
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

    public class TestLinkInfo : PropertyBase
    {

        public string RequestUri { get; set; }

        public string Method { get; set; }
    }

    public class CustomApi : Resource<CustomApiProperties>
    {
        public CustomApi() => (Type, ApiVersion) = ("Microsoft.Web/customApis", "2016-06-01");
        public CustomApi(string name) : this() => Name = name;
        public CustomApi(string name, Location location) : this() => (Name, Location) = (name, location);

        public CustomApi WithProperties(Action<CustomApiProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class CustomApiProperties : PropertyBase
    {

        public object ConnectionParameters { get; set; }

        public IList<string> RuntimeUrls { get; set; }

        public IList<string> Capabilities { get; set; }

        public object Swagger { get; set; }

        public string BrandColor { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public string IconUri { get; set; }

        private BackendServiceInfo _backendService;
        public BackendServiceInfo BackendService
        {
            get => _backendService = Get(_backendService);
            set => _backendService = value;
        }

        private ApiDefinitionsInfo _apiDefinitions;
        public ApiDefinitionsInfo ApiDefinitions
        {
            get => _apiDefinitions = Get(_apiDefinitions);
            set => _apiDefinitions = value;
        }

        public string ApiType { get; set; }

        private WsdlDefinitionInfo _wsdlDefinition;
        public WsdlDefinitionInfo WsdlDefinition
        {
            get => _wsdlDefinition = Get(_wsdlDefinition);
            set => _wsdlDefinition = value;
        }
    }

    public class BackendServiceInfo : PropertyBase
    {

        public string ServiceUrl { get; set; }
    }

    public class ApiDefinitionsInfo : PropertyBase
    {

        public string OriginalSwaggerUrl { get; set; }

        public string ModifiedSwaggerUrl { get; set; }
    }

    public class WsdlDefinitionInfo : PropertyBase
    {

        public string Url { get; set; }

        public string Content { get; set; }

        private ServiceInfo _service;
        public ServiceInfo Service
        {
            get => _service = Get(_service);
            set => _service = value;
        }

        public string ImportMethod { get; set; }
    }

    public class ServiceInfo : PropertyBase
    {

        public string QualifiedName { get; set; }

        public IList<string> EndpointQualifiedNames { get; set; }
    }

    public class HostingEnvironmentWorkerPool : Resource<HostingEnvironmentWorkerPoolProperties>
    {
        public HostingEnvironmentWorkerPool() => (Type, ApiVersion) = ("Microsoft.Web/hostingEnvironments/workerPools", "2019-08-01");
        public HostingEnvironmentWorkerPool(string name) : this() => Name = name;
        public HostingEnvironmentWorkerPool(string name, Location location) : this() => (Name, Location) = (name, location);

        public HostingEnvironmentWorkerPool WithProperties(Action<HostingEnvironmentWorkerPoolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class HostingEnvironmentWorkerPoolProperties : PropertyBase
    {

        public int? WorkerSizeId { get; set; }

        public string ComputeMode { get; set; }

        public string WorkerSize { get; set; }

        public int? WorkerCount { get; set; }
    }

    public class SkuCapacityInfo : PropertyBase
    {

        public int? Minimum { get; set; }

        public int? Maximum { get; set; }

        public int? Default { get; set; }

        public string ScaleType { get; set; }
    }

    public class CapabilityInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }

        public string Reason { get; set; }
    }

    public class HostingEnvironment : Resource<HostingEnvironmentProperties>
    {
        public HostingEnvironment() => (Type, ApiVersion) = ("Microsoft.Web/hostingEnvironments", "2019-08-01");
        public HostingEnvironment(string name) : this() => Name = name;
        public HostingEnvironment(string name, Location location) : this() => (Name, Location) = (name, location);

        public HostingEnvironment WithProperties(Action<HostingEnvironmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class HostingEnvironmentProperties : PropertyBase
    {

        public string Name { get; set; }

        public string Location { get; set; }

        public string VnetName { get; set; }

        public string VnetResourceGroupName { get; set; }

        public string VnetSubnetName { get; set; }

        private VirtualNetworkInfo _virtualNetwork;
        public VirtualNetworkInfo VirtualNetwork
        {
            get => _virtualNetwork = Get(_virtualNetwork);
            set => _virtualNetwork = value;
        }

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

    public class VirtualNetworkInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Subnet { get; set; }
    }

    public class WorkerPoolInfo : PropertyBase
    {

        public int? WorkerSizeId { get; set; }

        public string ComputeMode { get; set; }

        public string WorkerSize { get; set; }

        public int? WorkerCount { get; set; }
    }

    public class NetworkAccessControlListInfo : PropertyBase
    {

        public string Action { get; set; }

        public string Description { get; set; }

        public int? Order { get; set; }

        public string RemoteSubnet { get; set; }
    }

    public class ClusterSettingInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }
    }

    public class ServerfarmVirtualNetworkConnectionGateway : Resource<ServerfarmVirtualNetworkConnectionGatewayProperties>
    {
        public ServerfarmVirtualNetworkConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/serverfarms/virtualNetworkConnections/gateways", "2019-08-01");
        public ServerfarmVirtualNetworkConnectionGateway(string name) : this() => Name = name;
        public ServerfarmVirtualNetworkConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerfarmVirtualNetworkConnectionGateway WithProperties(Action<ServerfarmVirtualNetworkConnectionGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerfarmVirtualNetworkConnectionGatewayProperties : PropertyBase
    {

        public string VnetName { get; set; }

        public string VpnPackageUri { get; set; }
    }

    public class ServerfarmVirtualNetworkConnectionRoute : Resource<ServerfarmVirtualNetworkConnectionRouteProperties>
    {
        public ServerfarmVirtualNetworkConnectionRoute() => (Type, ApiVersion) = ("Microsoft.Web/serverfarms/virtualNetworkConnections/routes", "2019-08-01");
        public ServerfarmVirtualNetworkConnectionRoute(string name) : this() => Name = name;
        public ServerfarmVirtualNetworkConnectionRoute(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServerfarmVirtualNetworkConnectionRoute WithProperties(Action<ServerfarmVirtualNetworkConnectionRouteProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerfarmVirtualNetworkConnectionRouteProperties : PropertyBase
    {

        public string StartAddress { get; set; }

        public string EndAddress { get; set; }

        public string RouteType { get; set; }
    }

    public class Serverfarm : Resource<ServerfarmProperties>
    {
        public Serverfarm() => (Type, ApiVersion) = ("Microsoft.Web/serverfarms", "2019-08-01");
        public Serverfarm(string name) : this() => Name = name;
        public Serverfarm(string name, Location location) : this() => (Name, Location) = (name, location);

        public Serverfarm WithProperties(Action<ServerfarmProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerfarmProperties : PropertyBase
    {

        public string WorkerTierName { get; set; }

        private HostingEnvironmentProfileInfo _hostingEnvironmentProfile;
        public HostingEnvironmentProfileInfo HostingEnvironmentProfile
        {
            get => _hostingEnvironmentProfile = Get(_hostingEnvironmentProfile);
            set => _hostingEnvironmentProfile = value;
        }

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

    public class HostingEnvironmentProfileInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class SiteConfig : Resource<SiteConfigProperties>
    {
        public SiteConfig() => (Type, ApiVersion) = ("Microsoft.Web/sites/config", "2019-08-01");
        public SiteConfig(string name) : this() => Name = name;
        public SiteConfig(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteConfig WithProperties(Action<SiteConfigProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteConfigProperties : PropertyBase
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

        private ExperimentsInfo _experiments;
        public ExperimentsInfo Experiments
        {
            get => _experiments = Get(_experiments);
            set => _experiments = value;
        }

        private LimitsInfo _limits;
        public LimitsInfo Limits
        {
            get => _limits = Get(_limits);
            set => _limits = value;
        }

        public bool? AutoHealEnabled { get; set; }

        private AutoHealRulesInfo _autoHealRules;
        public AutoHealRulesInfo AutoHealRules
        {
            get => _autoHealRules = Get(_autoHealRules);
            set => _autoHealRules = value;
        }

        public string TracingOptions { get; set; }

        public string VnetName { get; set; }

        private CorsInfo _cors;
        public CorsInfo Cors
        {
            get => _cors = Get(_cors);
            set => _cors = value;
        }

        private PushInfo _push;
        public PushInfo Push
        {
            get => _push = Get(_push);
            set => _push = value;
        }

        private ApiDefinitionInfo _apiDefinition;
        public ApiDefinitionInfo ApiDefinition
        {
            get => _apiDefinition = Get(_apiDefinition);
            set => _apiDefinition = value;
        }

        private ApiManagementConfigInfo _apiManagementConfig;
        public ApiManagementConfigInfo ApiManagementConfig
        {
            get => _apiManagementConfig = Get(_apiManagementConfig);
            set => _apiManagementConfig = value;
        }

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

    public class AppSettingInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }
    }

    public class ConnectionStringInfo : PropertyBase
    {

        public string Name { get; set; }

        public string ConnectionString { get; set; }

        public string Type { get; set; }
    }

    public class HandlerMappingInfo : PropertyBase
    {

        public string Extension { get; set; }

        public string ScriptProcessor { get; set; }

        public string Arguments { get; set; }
    }

    public class VirtualApplicationInfo : PropertyBase
    {

        public string VirtualPath { get; set; }

        public string PhysicalPath { get; set; }

        public bool? PreloadEnabled { get; set; }

        public IList<VirtualDirectoryInfo> VirtualDirectories { get; set; }
    }

    public class VirtualDirectoryInfo : PropertyBase
    {

        public string VirtualPath { get; set; }

        public string PhysicalPath { get; set; }
    }

    public class ExperimentsInfo : PropertyBase
    {

        public IList<RampUpRuleInfo> RampUpRules { get; set; }
    }

    public class RampUpRuleInfo : PropertyBase
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

    public class LimitsInfo : PropertyBase
    {

        public string MaxPercentageCpu { get; set; }

        public int? MaxMemoryInMb { get; set; }

        public int? MaxDiskSizeInMb { get; set; }
    }

    public class AutoHealRulesInfo : PropertyBase
    {

        private TriggersInfo _triggers;
        public TriggersInfo Triggers
        {
            get => _triggers = Get(_triggers);
            set => _triggers = value;
        }

        private ActionsInfo _actions;
        public ActionsInfo Actions
        {
            get => _actions = Get(_actions);
            set => _actions = value;
        }
    }

    public class TriggersInfo : PropertyBase
    {

        private RequestsInfo _requests;
        public RequestsInfo Requests
        {
            get => _requests = Get(_requests);
            set => _requests = value;
        }

        public int? PrivateBytesInKB { get; set; }

        public IList<StatusCodeInfo> StatusCodes { get; set; }

        private SlowRequestsInfo _slowRequests;
        public SlowRequestsInfo SlowRequests
        {
            get => _slowRequests = Get(_slowRequests);
            set => _slowRequests = value;
        }
    }

    public class RequestsInfo : PropertyBase
    {

        public int? Count { get; set; }

        public string TimeInterval { get; set; }
    }

    public class StatusCodeInfo : PropertyBase
    {

        public int? Status { get; set; }

        public int? SubStatus { get; set; }

        public int? Win32Status { get; set; }

        public int? Count { get; set; }

        public string TimeInterval { get; set; }
    }

    public class SlowRequestsInfo : PropertyBase
    {

        public string TimeTaken { get; set; }

        public int? Count { get; set; }

        public string TimeInterval { get; set; }
    }

    public class ActionsInfo : PropertyBase
    {

        public string ActionType { get; set; }

        private CustomActionInfo _customAction;
        public CustomActionInfo CustomAction
        {
            get => _customAction = Get(_customAction);
            set => _customAction = value;
        }

        public string MinProcessExecutionTime { get; set; }
    }

    public class CustomActionInfo : PropertyBase
    {

        public string Exe { get; set; }

        public string Parameters { get; set; }
    }

    public class CorsInfo : PropertyBase
    {

        public IList<string> AllowedOrigins { get; set; }

        public bool? SupportCredentials { get; set; }
    }

    public class PushInfo : PropertyBase
    {

        public string Kind { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class ApiDefinitionInfo : PropertyBase
    {

        public string Url { get; set; }
    }

    public class ApiManagementConfigInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class IpSecurityRestrictionInfo : PropertyBase
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

    public class ScmIpSecurityRestrictionInfo : PropertyBase
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

    public class SiteDeployment : Resource<SiteDeploymentProperties>
    {
        public SiteDeployment() => (Type, ApiVersion) = ("Microsoft.Web/sites/deployments", "2019-08-01");
        public SiteDeployment(string name) : this() => Name = name;
        public SiteDeployment(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteDeployment WithProperties(Action<SiteDeploymentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteDeploymentProperties : PropertyBase
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

    public class SiteDomainOwnershipIdentifier : Resource<SiteDomainOwnershipIdentifierProperties>
    {
        public SiteDomainOwnershipIdentifier() => (Type, ApiVersion) = ("Microsoft.Web/sites/domainOwnershipIdentifiers", "2019-08-01");
        public SiteDomainOwnershipIdentifier(string name) : this() => Name = name;
        public SiteDomainOwnershipIdentifier(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteDomainOwnershipIdentifier WithProperties(Action<SiteDomainOwnershipIdentifierProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteDomainOwnershipIdentifierProperties : PropertyBase
    {

        public string Id { get; set; }
    }

    public class SiteFunction : Resource<SiteFunctionProperties>
    {
        public SiteFunction() => (Type, ApiVersion) = ("Microsoft.Web/sites/functions", "2019-08-01");
        public SiteFunction(string name) : this() => Name = name;
        public SiteFunction(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteFunction WithProperties(Action<SiteFunctionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteFunctionProperties : PropertyBase
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

    public class SiteHostNameBinding : Resource<SiteHostNameBindingProperties>
    {
        public SiteHostNameBinding() => (Type, ApiVersion) = ("Microsoft.Web/sites/hostNameBindings", "2019-08-01");
        public SiteHostNameBinding(string name) : this() => Name = name;
        public SiteHostNameBinding(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteHostNameBinding WithProperties(Action<SiteHostNameBindingProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteHostNameBindingProperties : PropertyBase
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

    public class SiteHybridconnection : Resource<SiteHybridconnectionProperties>
    {
        public SiteHybridconnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/hybridconnection", "2019-08-01");
        public SiteHybridconnection(string name) : this() => Name = name;
        public SiteHybridconnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteHybridconnection WithProperties(Action<SiteHybridconnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteHybridconnectionProperties : PropertyBase
    {

        public string EntityName { get; set; }

        public string EntityConnectionString { get; set; }

        public string ResourceType { get; set; }

        public string ResourceConnectionString { get; set; }

        public string Hostname { get; set; }

        public int? Port { get; set; }

        public string BiztalkUri { get; set; }
    }

    public class SiteHybridConnectionNamespaceRelay : Resource<SiteHybridConnectionNamespaceRelayProperties>
    {
        public SiteHybridConnectionNamespaceRelay() => (Type, ApiVersion) = ("Microsoft.Web/sites/hybridConnectionNamespaces/relays", "2019-08-01");
        public SiteHybridConnectionNamespaceRelay(string name) : this() => Name = name;
        public SiteHybridConnectionNamespaceRelay(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteHybridConnectionNamespaceRelay WithProperties(Action<SiteHybridConnectionNamespaceRelayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteHybridConnectionNamespaceRelayProperties : PropertyBase
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

    public class SitePremieraddon : Resource<SitePremieraddonProperties>
    {
        public SitePremieraddon() => (Type, ApiVersion) = ("Microsoft.Web/sites/premieraddons", "2019-08-01");
        public SitePremieraddon(string name) : this() => Name = name;
        public SitePremieraddon(string name, Location location) : this() => (Name, Location) = (name, location);

        public SitePremieraddon WithProperties(Action<SitePremieraddonProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SitePremieraddonProperties : PropertyBase
    {

        public string Sku { get; set; }

        public string Product { get; set; }

        public string Vendor { get; set; }

        public string MarketplacePublisher { get; set; }

        public string MarketplaceOffer { get; set; }
    }

    public class SitePublicCertificate : Resource<SitePublicCertificateProperties>
    {
        public SitePublicCertificate() => (Type, ApiVersion) = ("Microsoft.Web/sites/publicCertificates", "2019-08-01");
        public SitePublicCertificate(string name) : this() => Name = name;
        public SitePublicCertificate(string name, Location location) : this() => (Name, Location) = (name, location);

        public SitePublicCertificate WithProperties(Action<SitePublicCertificateProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SitePublicCertificateProperties : PropertyBase
    {

        public IList<string> Blob { get; set; }

        public string PublicCertificateLocation { get; set; }
    }

    public class SiteSlotConfig : Resource<SiteSlotConfigProperties>
    {
        public SiteSlotConfig() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/config", "2019-08-01");
        public SiteSlotConfig(string name) : this() => Name = name;
        public SiteSlotConfig(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotConfig WithProperties(Action<SiteSlotConfigProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotConfigProperties : PropertyBase
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

        private ExperimentsInfo _experiments;
        public ExperimentsInfo Experiments
        {
            get => _experiments = Get(_experiments);
            set => _experiments = value;
        }

        private LimitsInfo _limits;
        public LimitsInfo Limits
        {
            get => _limits = Get(_limits);
            set => _limits = value;
        }

        public bool? AutoHealEnabled { get; set; }

        private AutoHealRulesInfo _autoHealRules;
        public AutoHealRulesInfo AutoHealRules
        {
            get => _autoHealRules = Get(_autoHealRules);
            set => _autoHealRules = value;
        }

        public string TracingOptions { get; set; }

        public string VnetName { get; set; }

        private CorsInfo _cors;
        public CorsInfo Cors
        {
            get => _cors = Get(_cors);
            set => _cors = value;
        }

        private PushInfo _push;
        public PushInfo Push
        {
            get => _push = Get(_push);
            set => _push = value;
        }

        private ApiDefinitionInfo _apiDefinition;
        public ApiDefinitionInfo ApiDefinition
        {
            get => _apiDefinition = Get(_apiDefinition);
            set => _apiDefinition = value;
        }

        private ApiManagementConfigInfo _apiManagementConfig;
        public ApiManagementConfigInfo ApiManagementConfig
        {
            get => _apiManagementConfig = Get(_apiManagementConfig);
            set => _apiManagementConfig = value;
        }

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

    public class SiteSlotDeployment : Resource<SiteSlotDeploymentProperties>
    {
        public SiteSlotDeployment() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/deployments", "2019-08-01");
        public SiteSlotDeployment(string name) : this() => Name = name;
        public SiteSlotDeployment(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotDeployment WithProperties(Action<SiteSlotDeploymentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotDeploymentProperties : PropertyBase
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

    public class SiteSlotDomainOwnershipIdentifier : Resource<SiteSlotDomainOwnershipIdentifierProperties>
    {
        public SiteSlotDomainOwnershipIdentifier() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/domainOwnershipIdentifiers", "2019-08-01");
        public SiteSlotDomainOwnershipIdentifier(string name) : this() => Name = name;
        public SiteSlotDomainOwnershipIdentifier(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotDomainOwnershipIdentifier WithProperties(Action<SiteSlotDomainOwnershipIdentifierProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotDomainOwnershipIdentifierProperties : PropertyBase
    {

        public string Id { get; set; }
    }

    public class SiteSlotFunction : Resource<SiteSlotFunctionProperties>
    {
        public SiteSlotFunction() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/functions", "2019-08-01");
        public SiteSlotFunction(string name) : this() => Name = name;
        public SiteSlotFunction(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotFunction WithProperties(Action<SiteSlotFunctionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotFunctionProperties : PropertyBase
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

    public class SiteSlotHostNameBinding : Resource<SiteSlotHostNameBindingProperties>
    {
        public SiteSlotHostNameBinding() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/hostNameBindings", "2019-08-01");
        public SiteSlotHostNameBinding(string name) : this() => Name = name;
        public SiteSlotHostNameBinding(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotHostNameBinding WithProperties(Action<SiteSlotHostNameBindingProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotHostNameBindingProperties : PropertyBase
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

    public class SiteSlotHybridconnection : Resource<SiteSlotHybridconnectionProperties>
    {
        public SiteSlotHybridconnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/hybridconnection", "2019-08-01");
        public SiteSlotHybridconnection(string name) : this() => Name = name;
        public SiteSlotHybridconnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotHybridconnection WithProperties(Action<SiteSlotHybridconnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotHybridconnectionProperties : PropertyBase
    {

        public string EntityName { get; set; }

        public string EntityConnectionString { get; set; }

        public string ResourceType { get; set; }

        public string ResourceConnectionString { get; set; }

        public string Hostname { get; set; }

        public int? Port { get; set; }

        public string BiztalkUri { get; set; }
    }

    public class SiteSlotHybridConnectionNamespaceRelay : Resource<SiteSlotHybridConnectionNamespaceRelayProperties>
    {
        public SiteSlotHybridConnectionNamespaceRelay() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/hybridConnectionNamespaces/relays", "2019-08-01");
        public SiteSlotHybridConnectionNamespaceRelay(string name) : this() => Name = name;
        public SiteSlotHybridConnectionNamespaceRelay(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotHybridConnectionNamespaceRelay WithProperties(Action<SiteSlotHybridConnectionNamespaceRelayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotHybridConnectionNamespaceRelayProperties : PropertyBase
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

    public class SiteSlotPremieraddon : Resource<SiteSlotPremieraddonProperties>
    {
        public SiteSlotPremieraddon() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/premieraddons", "2019-08-01");
        public SiteSlotPremieraddon(string name) : this() => Name = name;
        public SiteSlotPremieraddon(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotPremieraddon WithProperties(Action<SiteSlotPremieraddonProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotPremieraddonProperties : PropertyBase
    {

        public string Sku { get; set; }

        public string Product { get; set; }

        public string Vendor { get; set; }

        public string MarketplacePublisher { get; set; }

        public string MarketplaceOffer { get; set; }
    }

    public class SiteSlotPublicCertificate : Resource<SiteSlotPublicCertificateProperties>
    {
        public SiteSlotPublicCertificate() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/publicCertificates", "2019-08-01");
        public SiteSlotPublicCertificate(string name) : this() => Name = name;
        public SiteSlotPublicCertificate(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotPublicCertificate WithProperties(Action<SiteSlotPublicCertificateProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotPublicCertificateProperties : PropertyBase
    {

        public IList<string> Blob { get; set; }

        public string PublicCertificateLocation { get; set; }
    }

    public class SiteSlotSourcecontrol : Resource<SiteSlotSourcecontrolProperties>
    {
        public SiteSlotSourcecontrol() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/sourcecontrols", "2019-08-01");
        public SiteSlotSourcecontrol(string name) : this() => Name = name;
        public SiteSlotSourcecontrol(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotSourcecontrol WithProperties(Action<SiteSlotSourcecontrolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotSourcecontrolProperties : PropertyBase
    {

        public string RepoUrl { get; set; }

        public string Branch { get; set; }

        public bool? IsManualIntegration { get; set; }

        public bool? DeploymentRollbackEnabled { get; set; }

        public bool? IsMercurial { get; set; }
    }

    public class SiteSlotVirtualNetworkConnectionGateway : Resource<SiteSlotVirtualNetworkConnectionGatewayProperties>
    {
        public SiteSlotVirtualNetworkConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/virtualNetworkConnections/gateways", "2019-08-01");
        public SiteSlotVirtualNetworkConnectionGateway(string name) : this() => Name = name;
        public SiteSlotVirtualNetworkConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotVirtualNetworkConnectionGateway WithProperties(Action<SiteSlotVirtualNetworkConnectionGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotVirtualNetworkConnectionGatewayProperties : PropertyBase
    {

        public string VnetName { get; set; }

        public string VpnPackageUri { get; set; }
    }

    public class SiteSlotVirtualNetworkConnection : Resource<SiteSlotVirtualNetworkConnectionProperties>
    {
        public SiteSlotVirtualNetworkConnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots/virtualNetworkConnections", "2019-08-01");
        public SiteSlotVirtualNetworkConnection(string name) : this() => Name = name;
        public SiteSlotVirtualNetworkConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSlotVirtualNetworkConnection WithProperties(Action<SiteSlotVirtualNetworkConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotVirtualNetworkConnectionProperties : PropertyBase
    {

        public string VnetResourceId { get; set; }

        public string CertBlob { get; set; }

        public string DnsServers { get; set; }

        public bool? IsSwift { get; set; }
    }

    public class SiteSlot : Resource<SiteSlotProperties>
    {
        public SiteSlot() => (Type, ApiVersion) = ("Microsoft.Web/sites/slots", "2019-08-01");
        public SiteSlot(string name) : this() => Name = name;
        public SiteSlot(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public SiteSlot WithProperties(Action<SiteSlotProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSlotProperties : PropertyBase
    {

        public bool? Enabled { get; set; }

        public IList<HostNameSslStateInfo> HostNameSslStates { get; set; }

        public string ServerFarmId { get; set; }

        public bool? Reserved { get; set; }

        public bool? IsXenon { get; set; }

        public bool? HyperV { get; set; }

        private SiteConfigInfo _siteConfig;
        public SiteConfigInfo SiteConfig
        {
            get => _siteConfig = Get(_siteConfig);
            set => _siteConfig = value;
        }

        public bool? ScmSiteAlsoStopped { get; set; }

        private HostingEnvironmentProfileInfo _hostingEnvironmentProfile;
        public HostingEnvironmentProfileInfo HostingEnvironmentProfile
        {
            get => _hostingEnvironmentProfile = Get(_hostingEnvironmentProfile);
            set => _hostingEnvironmentProfile = value;
        }

        public bool? ClientAffinityEnabled { get; set; }

        public bool? ClientCertEnabled { get; set; }

        public string ClientCertExclusionPaths { get; set; }

        public bool? HostNamesDisabled { get; set; }

        public int? ContainerSize { get; set; }

        public int? DailyMemoryTimeQuota { get; set; }

        private CloningInfoInfo _cloningInfo;
        public CloningInfoInfo CloningInfo
        {
            get => _cloningInfo = Get(_cloningInfo);
            set => _cloningInfo = value;
        }

        public bool? HttpsOnly { get; set; }

        public string RedundancyMode { get; set; }
    }

    public class HostNameSslStateInfo : PropertyBase
    {

        public string Name { get; set; }

        public string SslState { get; set; }

        public string VirtualIP { get; set; }

        public string Thumbprint { get; set; }

        public bool? ToUpdate { get; set; }

        public string HostType { get; set; }
    }

    public class SiteConfigInfo : PropertyBase
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

        private ExperimentsInfo _experiments;
        public ExperimentsInfo Experiments
        {
            get => _experiments = Get(_experiments);
            set => _experiments = value;
        }

        private LimitsInfo _limits;
        public LimitsInfo Limits
        {
            get => _limits = Get(_limits);
            set => _limits = value;
        }

        public bool? AutoHealEnabled { get; set; }

        private AutoHealRulesInfo _autoHealRules;
        public AutoHealRulesInfo AutoHealRules
        {
            get => _autoHealRules = Get(_autoHealRules);
            set => _autoHealRules = value;
        }

        public string TracingOptions { get; set; }

        public string VnetName { get; set; }

        private CorsInfo _cors;
        public CorsInfo Cors
        {
            get => _cors = Get(_cors);
            set => _cors = value;
        }

        private PushInfo _push;
        public PushInfo Push
        {
            get => _push = Get(_push);
            set => _push = value;
        }

        private ApiDefinitionInfo _apiDefinition;
        public ApiDefinitionInfo ApiDefinition
        {
            get => _apiDefinition = Get(_apiDefinition);
            set => _apiDefinition = value;
        }

        private ApiManagementConfigInfo _apiManagementConfig;
        public ApiManagementConfigInfo ApiManagementConfig
        {
            get => _apiManagementConfig = Get(_apiManagementConfig);
            set => _apiManagementConfig = value;
        }

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

    public class CloningInfoInfo : PropertyBase
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

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }

        public object UserAssignedIdentities { get; set; }
    }

    public class SiteSourcecontrol : Resource<SiteSourcecontrolProperties>
    {
        public SiteSourcecontrol() => (Type, ApiVersion) = ("Microsoft.Web/sites/sourcecontrols", "2019-08-01");
        public SiteSourcecontrol(string name) : this() => Name = name;
        public SiteSourcecontrol(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteSourcecontrol WithProperties(Action<SiteSourcecontrolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteSourcecontrolProperties : PropertyBase
    {

        public string RepoUrl { get; set; }

        public string Branch { get; set; }

        public bool? IsManualIntegration { get; set; }

        public bool? DeploymentRollbackEnabled { get; set; }

        public bool? IsMercurial { get; set; }
    }

    public class SiteVirtualNetworkConnectionGateway : Resource<SiteVirtualNetworkConnectionGatewayProperties>
    {
        public SiteVirtualNetworkConnectionGateway() => (Type, ApiVersion) = ("Microsoft.Web/sites/virtualNetworkConnections/gateways", "2019-08-01");
        public SiteVirtualNetworkConnectionGateway(string name) : this() => Name = name;
        public SiteVirtualNetworkConnectionGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteVirtualNetworkConnectionGateway WithProperties(Action<SiteVirtualNetworkConnectionGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteVirtualNetworkConnectionGatewayProperties : PropertyBase
    {

        public string VnetName { get; set; }

        public string VpnPackageUri { get; set; }
    }

    public class SiteVirtualNetworkConnection : Resource<SiteVirtualNetworkConnectionProperties>
    {
        public SiteVirtualNetworkConnection() => (Type, ApiVersion) = ("Microsoft.Web/sites/virtualNetworkConnections", "2019-08-01");
        public SiteVirtualNetworkConnection(string name) : this() => Name = name;
        public SiteVirtualNetworkConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public SiteVirtualNetworkConnection WithProperties(Action<SiteVirtualNetworkConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteVirtualNetworkConnectionProperties : PropertyBase
    {

        public string VnetResourceId { get; set; }

        public string CertBlob { get; set; }

        public string DnsServers { get; set; }

        public bool? IsSwift { get; set; }
    }

    public class Site : Resource<SiteProperties>
    {
        public Site() => (Type, ApiVersion) = ("Microsoft.Web/sites", "2019-08-01");
        public Site(string name) : this() => Name = name;
        public Site(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public Site WithProperties(Action<SiteProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SiteProperties : PropertyBase
    {

        public bool? Enabled { get; set; }

        public IList<HostNameSslStateInfo> HostNameSslStates { get; set; }

        public string ServerFarmId { get; set; }

        public bool? Reserved { get; set; }

        public bool? IsXenon { get; set; }

        public bool? HyperV { get; set; }

        private SiteConfigInfo _siteConfig;
        public SiteConfigInfo SiteConfig
        {
            get => _siteConfig = Get(_siteConfig);
            set => _siteConfig = value;
        }

        public bool? ScmSiteAlsoStopped { get; set; }

        private HostingEnvironmentProfileInfo _hostingEnvironmentProfile;
        public HostingEnvironmentProfileInfo HostingEnvironmentProfile
        {
            get => _hostingEnvironmentProfile = Get(_hostingEnvironmentProfile);
            set => _hostingEnvironmentProfile = value;
        }

        public bool? ClientAffinityEnabled { get; set; }

        public bool? ClientCertEnabled { get; set; }

        public string ClientCertExclusionPaths { get; set; }

        public bool? HostNamesDisabled { get; set; }

        public int? ContainerSize { get; set; }

        public int? DailyMemoryTimeQuota { get; set; }

        private CloningInfoInfo _cloningInfo;
        public CloningInfoInfo CloningInfo
        {
            get => _cloningInfo = Get(_cloningInfo);
            set => _cloningInfo = value;
        }

        public bool? HttpsOnly { get; set; }

        public string RedundancyMode { get; set; }
    }

    public class Sourcecontrol : Resource<SourcecontrolProperties>
    {
        public Sourcecontrol() => (Type, ApiVersion) = ("Microsoft.Web/sourcecontrols", "2019-08-01");
        public Sourcecontrol(string name) : this() => Name = name;
        public Sourcecontrol(string name, Location location) : this() => (Name, Location) = (name, location);

        public Sourcecontrol WithProperties(Action<SourcecontrolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SourcecontrolProperties : PropertyBase
    {

        public string Token { get; set; }

        public string TokenSecret { get; set; }

        public string RefreshToken { get; set; }

        public string ExpirationTime { get; set; }
    }
}
