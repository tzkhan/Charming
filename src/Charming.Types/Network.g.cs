namespace Charming.Types.Network
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class ApplicationGateway : Resource<ApplicationGatewayProperties>
    {
        public ApplicationGateway() => (Type, ApiVersion) = ("Microsoft.Network/applicationGateways", "2020-04-01");
        public ApplicationGateway(string name) : this() => Name = name;
        public ApplicationGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public IdentityInfo Identity { get; set; }

        public ApplicationGateway WithProperties(Action<ApplicationGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ApplicationGatewayProperties : PropertyBase
    {

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        private SslPolicyInfo _sslPolicy;
        public SslPolicyInfo SslPolicy
        {
            get => _sslPolicy = Get(_sslPolicy);
            set => _sslPolicy = value;
        }

        public IList<GatewayIPConfigurationInfo> GatewayIPConfigurations { get; set; }

        public IList<AuthenticationCertificateInfo> AuthenticationCertificates { get; set; }

        public IList<TrustedRootCertificateInfo> TrustedRootCertificates { get; set; }

        public IList<SslCertificateInfo> SslCertificates { get; set; }

        public IList<FrontendIPConfigurationInfo> FrontendIPConfigurations { get; set; }

        public IList<FrontendPortInfo> FrontendPorts { get; set; }

        public IList<ProbeInfo> Probes { get; set; }

        public IList<BackendAddressPoolInfo> BackendAddressPools { get; set; }

        public IList<BackendHttpSettingsCollectionInfo> BackendHttpSettingsCollection { get; set; }

        public IList<HttpListenerInfo> HttpListeners { get; set; }

        public IList<UrlPathMapInfo> UrlPathMaps { get; set; }

        public IList<RequestRoutingRuleInfo> RequestRoutingRules { get; set; }

        public IList<PropertiesRewriteRuleSetInfo> RewriteRuleSets { get; set; }

        public IList<PropertiesRedirectConfigurationInfo> RedirectConfigurations { get; set; }

        private WebApplicationFirewallConfigurationInfo _webApplicationFirewallConfiguration;
        public WebApplicationFirewallConfigurationInfo WebApplicationFirewallConfiguration
        {
            get => _webApplicationFirewallConfiguration = Get(_webApplicationFirewallConfiguration);
            set => _webApplicationFirewallConfiguration = value;
        }

        private FirewallPolicyInfo _firewallPolicy;
        public FirewallPolicyInfo FirewallPolicy
        {
            get => _firewallPolicy = Get(_firewallPolicy);
            set => _firewallPolicy = value;
        }

        public bool? EnableHttp2 { get; set; }

        public bool? EnableFips { get; set; }

        private AutoscaleConfigurationInfo _autoscaleConfiguration;
        public AutoscaleConfigurationInfo AutoscaleConfiguration
        {
            get => _autoscaleConfiguration = Get(_autoscaleConfiguration);
            set => _autoscaleConfiguration = value;
        }

        public IList<CustomErrorConfigurationInfo> CustomErrorConfigurations { get; set; }

        public bool? ForceFirewallPolicyAssociation { get; set; }
    }

    public class SkuInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Tier { get; set; }

        public int? Capacity { get; set; }
    }

    public class SslPolicyInfo : PropertyBase
    {

        public IList<string> DisabledSslProtocols { get; set; }

        public string PolicyType { get; set; }

        public string PolicyName { get; set; }

        public IList<string> CipherSuites { get; set; }

        public string MinProtocolVersion { get; set; }
    }

    public class GatewayIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesInfo : PropertyBase
    {

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }
    }

    public class SubnetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class AuthenticationCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private AuthenticationCertificatePropertiesInfo _properties;
        public AuthenticationCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class AuthenticationCertificatePropertiesInfo : PropertyBase
    {

        public string Data { get; set; }
    }

    public class TrustedRootCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private TrustedRootCertificatePropertiesInfo _properties;
        public TrustedRootCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class TrustedRootCertificatePropertiesInfo : PropertyBase
    {

        public string Data { get; set; }

        public string KeyVaultSecretId { get; set; }
    }

    public class SslCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private SslCertificatePropertiesInfo _properties;
        public SslCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class SslCertificatePropertiesInfo : PropertyBase
    {

        public string Data { get; set; }

        public string Password { get; set; }

        public string KeyVaultSecretId { get; set; }
    }

    public class FrontendIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private FrontendIPConfigurationPropertiesInfo _properties;
        public FrontendIPConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class FrontendIPConfigurationPropertiesInfo : PropertyBase
    {

        public string PrivateIPAddress { get; set; }

        public string PrivateIPAllocationMethod { get; set; }

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        private PublicIPAddressInfo _publicIPAddress;
        public PublicIPAddressInfo PublicIPAddress
        {
            get => _publicIPAddress = Get(_publicIPAddress);
            set => _publicIPAddress = value;
        }
    }

    public class PublicIPAddressInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class FrontendPortInfo : PropertyBase
    {

        public string Id { get; set; }

        private FrontendPortPropertiesInfo _properties;
        public FrontendPortPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class FrontendPortPropertiesInfo : PropertyBase
    {

        public int? Port { get; set; }
    }

    public class ProbeInfo : PropertyBase
    {

        public string Id { get; set; }

        private ProbePropertiesInfo _properties;
        public ProbePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ProbePropertiesInfo : PropertyBase
    {

        public string Protocol { get; set; }

        public string Host { get; set; }

        public string Path { get; set; }

        public int? Interval { get; set; }

        public int? Timeout { get; set; }

        public int? UnhealthyThreshold { get; set; }

        public bool? PickHostNameFromBackendHttpSettings { get; set; }

        public int? MinServers { get; set; }

        private MatchInfo _match;
        public MatchInfo Match
        {
            get => _match = Get(_match);
            set => _match = value;
        }

        public int? Port { get; set; }
    }

    public class MatchInfo : PropertyBase
    {

        public string Body { get; set; }

        public IList<string> StatusCodes { get; set; }
    }

    public class BackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }

        private BackendAddressPoolPropertiesInfo _properties;
        public BackendAddressPoolPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class BackendAddressPoolPropertiesInfo : PropertyBase
    {

        public IList<BackendAddresseInfo> BackendAddresses { get; set; }
    }

    public class BackendAddresseInfo : PropertyBase
    {

        public string Fqdn { get; set; }

        public string IpAddress { get; set; }
    }

    public class BackendHttpSettingsCollectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private BackendHttpSettingsCollectionPropertiesInfo _properties;
        public BackendHttpSettingsCollectionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class BackendHttpSettingsCollectionPropertiesInfo : PropertyBase
    {

        public int? Port { get; set; }

        public string Protocol { get; set; }

        public string CookieBasedAffinity { get; set; }

        public int? RequestTimeout { get; set; }

        private BackendHttpSettingsCollectionPropertiesProbeInfo _probe;
        public BackendHttpSettingsCollectionPropertiesProbeInfo Probe
        {
            get => _probe = Get(_probe);
            set => _probe = value;
        }

        public IList<BackendHttpSettingsCollectionPropertiesAuthenticationCertificateInfo> AuthenticationCertificates { get; set; }

        public IList<BackendHttpSettingsCollectionPropertiesTrustedRootCertificateInfo> TrustedRootCertificates { get; set; }

        private ConnectionDrainingInfo _connectionDraining;
        public ConnectionDrainingInfo ConnectionDraining
        {
            get => _connectionDraining = Get(_connectionDraining);
            set => _connectionDraining = value;
        }

        public string HostName { get; set; }

        public bool? PickHostNameFromBackendAddress { get; set; }

        public string AffinityCookieName { get; set; }

        public bool? ProbeEnabled { get; set; }

        public string Path { get; set; }
    }

    public class BackendHttpSettingsCollectionPropertiesProbeInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class BackendHttpSettingsCollectionPropertiesAuthenticationCertificateInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class BackendHttpSettingsCollectionPropertiesTrustedRootCertificateInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ConnectionDrainingInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public int? DrainTimeoutInSec { get; set; }
    }

    public class HttpListenerInfo : PropertyBase
    {

        public string Id { get; set; }

        private HttpListenerPropertiesInfo _properties;
        public HttpListenerPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class HttpListenerPropertiesInfo : PropertyBase
    {

        private HttpListenerPropertiesFrontendIPConfigurationInfo _frontendIPConfiguration;
        public HttpListenerPropertiesFrontendIPConfigurationInfo FrontendIPConfiguration
        {
            get => _frontendIPConfiguration = Get(_frontendIPConfiguration);
            set => _frontendIPConfiguration = value;
        }

        private HttpListenerPropertiesFrontendPortInfo _frontendPort;
        public HttpListenerPropertiesFrontendPortInfo FrontendPort
        {
            get => _frontendPort = Get(_frontendPort);
            set => _frontendPort = value;
        }

        public string Protocol { get; set; }

        public string HostName { get; set; }

        private HttpListenerPropertiesSslCertificateInfo _sslCertificate;
        public HttpListenerPropertiesSslCertificateInfo SslCertificate
        {
            get => _sslCertificate = Get(_sslCertificate);
            set => _sslCertificate = value;
        }

        public bool? RequireServerNameIndication { get; set; }

        public IList<CustomErrorConfigurationInfo> CustomErrorConfigurations { get; set; }

        private FirewallPolicyInfo _firewallPolicy;
        public FirewallPolicyInfo FirewallPolicy
        {
            get => _firewallPolicy = Get(_firewallPolicy);
            set => _firewallPolicy = value;
        }

        public IList<string> HostNames { get; set; }
    }

    public class HttpListenerPropertiesFrontendIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class HttpListenerPropertiesFrontendPortInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class HttpListenerPropertiesSslCertificateInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class CustomErrorConfigurationInfo : PropertyBase
    {

        public string StatusCode { get; set; }

        public string CustomErrorPageUrl { get; set; }
    }

    public class FirewallPolicyInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class UrlPathMapInfo : PropertyBase
    {

        public string Id { get; set; }

        private UrlPathMapPropertiesInfo _properties;
        public UrlPathMapPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class UrlPathMapPropertiesInfo : PropertyBase
    {

        private DefaultBackendAddressPoolInfo _defaultBackendAddressPool;
        public DefaultBackendAddressPoolInfo DefaultBackendAddressPool
        {
            get => _defaultBackendAddressPool = Get(_defaultBackendAddressPool);
            set => _defaultBackendAddressPool = value;
        }

        private DefaultBackendHttpSettingsInfo _defaultBackendHttpSettings;
        public DefaultBackendHttpSettingsInfo DefaultBackendHttpSettings
        {
            get => _defaultBackendHttpSettings = Get(_defaultBackendHttpSettings);
            set => _defaultBackendHttpSettings = value;
        }

        private DefaultRewriteRuleSetInfo _defaultRewriteRuleSet;
        public DefaultRewriteRuleSetInfo DefaultRewriteRuleSet
        {
            get => _defaultRewriteRuleSet = Get(_defaultRewriteRuleSet);
            set => _defaultRewriteRuleSet = value;
        }

        private DefaultRedirectConfigurationInfo _defaultRedirectConfiguration;
        public DefaultRedirectConfigurationInfo DefaultRedirectConfiguration
        {
            get => _defaultRedirectConfiguration = Get(_defaultRedirectConfiguration);
            set => _defaultRedirectConfiguration = value;
        }

        public IList<PathRuleInfo> PathRules { get; set; }
    }

    public class DefaultBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class DefaultBackendHttpSettingsInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class DefaultRewriteRuleSetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class DefaultRedirectConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PathRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private PathRulePropertiesInfo _properties;
        public PathRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PathRulePropertiesInfo : PropertyBase
    {

        public IList<string> Paths { get; set; }

        private PathRulePropertiesBackendAddressPoolInfo _backendAddressPool;
        public PathRulePropertiesBackendAddressPoolInfo BackendAddressPool
        {
            get => _backendAddressPool = Get(_backendAddressPool);
            set => _backendAddressPool = value;
        }

        private BackendHttpSettingsInfo _backendHttpSettings;
        public BackendHttpSettingsInfo BackendHttpSettings
        {
            get => _backendHttpSettings = Get(_backendHttpSettings);
            set => _backendHttpSettings = value;
        }

        private RedirectConfigurationInfo _redirectConfiguration;
        public RedirectConfigurationInfo RedirectConfiguration
        {
            get => _redirectConfiguration = Get(_redirectConfiguration);
            set => _redirectConfiguration = value;
        }

        private RewriteRuleSetInfo _rewriteRuleSet;
        public RewriteRuleSetInfo RewriteRuleSet
        {
            get => _rewriteRuleSet = Get(_rewriteRuleSet);
            set => _rewriteRuleSet = value;
        }

        private FirewallPolicyInfo _firewallPolicy;
        public FirewallPolicyInfo FirewallPolicy
        {
            get => _firewallPolicy = Get(_firewallPolicy);
            set => _firewallPolicy = value;
        }
    }

    public class PathRulePropertiesBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class BackendHttpSettingsInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class RedirectConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class RewriteRuleSetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class RequestRoutingRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private RequestRoutingRulePropertiesInfo _properties;
        public RequestRoutingRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class RequestRoutingRulePropertiesInfo : PropertyBase
    {

        public string RuleType { get; set; }

        public int? Priority { get; set; }

        private RequestRoutingRulePropertiesBackendAddressPoolInfo _backendAddressPool;
        public RequestRoutingRulePropertiesBackendAddressPoolInfo BackendAddressPool
        {
            get => _backendAddressPool = Get(_backendAddressPool);
            set => _backendAddressPool = value;
        }

        private BackendHttpSettingsInfo _backendHttpSettings;
        public BackendHttpSettingsInfo BackendHttpSettings
        {
            get => _backendHttpSettings = Get(_backendHttpSettings);
            set => _backendHttpSettings = value;
        }

        private RequestRoutingRulePropertiesHttpListenerInfo _httpListener;
        public RequestRoutingRulePropertiesHttpListenerInfo HttpListener
        {
            get => _httpListener = Get(_httpListener);
            set => _httpListener = value;
        }

        private RequestRoutingRulePropertiesUrlPathMapInfo _urlPathMap;
        public RequestRoutingRulePropertiesUrlPathMapInfo UrlPathMap
        {
            get => _urlPathMap = Get(_urlPathMap);
            set => _urlPathMap = value;
        }

        private RewriteRuleSetInfo _rewriteRuleSet;
        public RewriteRuleSetInfo RewriteRuleSet
        {
            get => _rewriteRuleSet = Get(_rewriteRuleSet);
            set => _rewriteRuleSet = value;
        }

        private RedirectConfigurationInfo _redirectConfiguration;
        public RedirectConfigurationInfo RedirectConfiguration
        {
            get => _redirectConfiguration = Get(_redirectConfiguration);
            set => _redirectConfiguration = value;
        }
    }

    public class RequestRoutingRulePropertiesBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class RequestRoutingRulePropertiesHttpListenerInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class RequestRoutingRulePropertiesUrlPathMapInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PropertiesRewriteRuleSetInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesRewriteRuleSetPropertiesInfo _properties;
        public PropertiesRewriteRuleSetPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesRewriteRuleSetPropertiesInfo : PropertyBase
    {

        public IList<RewriteRuleInfo> RewriteRules { get; set; }
    }

    public class RewriteRuleInfo : PropertyBase
    {

        public string Name { get; set; }

        public int? RuleSequence { get; set; }

        public IList<ConditionInfo> Conditions { get; set; }

        private ActionSetInfo _actionSet;
        public ActionSetInfo ActionSet
        {
            get => _actionSet = Get(_actionSet);
            set => _actionSet = value;
        }
    }

    public class ConditionInfo : PropertyBase
    {

        public string Variable { get; set; }

        public string Pattern { get; set; }

        public bool? IgnoreCase { get; set; }

        public bool? Negate { get; set; }
    }

    public class ActionSetInfo : PropertyBase
    {

        public IList<RequestHeaderConfigurationInfo> RequestHeaderConfigurations { get; set; }

        public IList<ResponseHeaderConfigurationInfo> ResponseHeaderConfigurations { get; set; }

        private UrlConfigurationInfo _urlConfiguration;
        public UrlConfigurationInfo UrlConfiguration
        {
            get => _urlConfiguration = Get(_urlConfiguration);
            set => _urlConfiguration = value;
        }
    }

    public class RequestHeaderConfigurationInfo : PropertyBase
    {

        public string HeaderName { get; set; }

        public string HeaderValue { get; set; }
    }

    public class ResponseHeaderConfigurationInfo : PropertyBase
    {

        public string HeaderName { get; set; }

        public string HeaderValue { get; set; }
    }

    public class UrlConfigurationInfo : PropertyBase
    {

        public string ModifiedPath { get; set; }

        public string ModifiedQueryString { get; set; }

        public bool? Reroute { get; set; }
    }

    public class PropertiesRedirectConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesRedirectConfigurationPropertiesInfo _properties;
        public PropertiesRedirectConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesRedirectConfigurationPropertiesInfo : PropertyBase
    {

        public string RedirectType { get; set; }

        private TargetListenerInfo _targetListener;
        public TargetListenerInfo TargetListener
        {
            get => _targetListener = Get(_targetListener);
            set => _targetListener = value;
        }

        public string TargetUrl { get; set; }

        public bool? IncludePath { get; set; }

        public bool? IncludeQueryString { get; set; }

        public IList<PropertiesRedirectConfigurationPropertiesRequestRoutingRuleInfo> RequestRoutingRules { get; set; }

        public IList<PropertiesRedirectConfigurationPropertiesUrlPathMapInfo> UrlPathMaps { get; set; }

        public IList<PropertiesRedirectConfigurationPropertiesPathRuleInfo> PathRules { get; set; }
    }

    public class TargetListenerInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PropertiesRedirectConfigurationPropertiesRequestRoutingRuleInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PropertiesRedirectConfigurationPropertiesUrlPathMapInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PropertiesRedirectConfigurationPropertiesPathRuleInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class WebApplicationFirewallConfigurationInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string FirewallMode { get; set; }

        public string RuleSetType { get; set; }

        public string RuleSetVersion { get; set; }

        public IList<DisabledRuleGroupInfo> DisabledRuleGroups { get; set; }

        public bool? RequestBodyCheck { get; set; }

        public int? MaxRequestBodySize { get; set; }

        public int? MaxRequestBodySizeInKb { get; set; }

        public int? FileUploadLimitInMb { get; set; }

        public IList<ExclusionInfo> Exclusions { get; set; }
    }

    public class DisabledRuleGroupInfo : PropertyBase
    {

        public string RuleGroupName { get; set; }

        public IList<string> Rules { get; set; }
    }

    public class ExclusionInfo : PropertyBase
    {

        public string MatchVariable { get; set; }

        public string SelectorMatchOperator { get; set; }

        public string Selector { get; set; }
    }

    public class AutoscaleConfigurationInfo : PropertyBase
    {

        public int? MinCapacity { get; set; }

        public int? MaxCapacity { get; set; }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }

        public object UserAssignedIdentities { get; set; }
    }

    public class ApplicationGatewayWebApplicationFirewallPolicy : Resource<ApplicationGatewayWebApplicationFirewallPolicyProperties>
    {
        public ApplicationGatewayWebApplicationFirewallPolicy() => (Type, ApiVersion) = ("Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies", "2020-04-01");
        public ApplicationGatewayWebApplicationFirewallPolicy(string name) : this() => Name = name;
        public ApplicationGatewayWebApplicationFirewallPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ApplicationGatewayWebApplicationFirewallPolicy WithProperties(Action<ApplicationGatewayWebApplicationFirewallPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ApplicationGatewayWebApplicationFirewallPolicyProperties : PropertyBase
    {

        private PolicySettingsInfo _policySettings;
        public PolicySettingsInfo PolicySettings
        {
            get => _policySettings = Get(_policySettings);
            set => _policySettings = value;
        }

        public IList<CustomRuleInfo> CustomRules { get; set; }

        private ManagedRulesInfo _managedRules;
        public ManagedRulesInfo ManagedRules
        {
            get => _managedRules = Get(_managedRules);
            set => _managedRules = value;
        }
    }

    public class PolicySettingsInfo : PropertyBase
    {

        public string State { get; set; }

        public string Mode { get; set; }

        public bool? RequestBodyCheck { get; set; }

        public int? MaxRequestBodySizeInKb { get; set; }

        public int? FileUploadLimitInMb { get; set; }
    }

    public class CustomRuleInfo : PropertyBase
    {

        public string Name { get; set; }

        public int? Priority { get; set; }

        public string RuleType { get; set; }

        public IList<MatchConditionInfo> MatchConditions { get; set; }

        public string Action { get; set; }
    }

    public class MatchConditionInfo : PropertyBase
    {

        public IList<MatchVariableInfo> MatchVariables { get; set; }

        public string Operator { get; set; }

        public bool? NegationConditon { get; set; }

        public IList<string> MatchValues { get; set; }

        public IList<string> Transforms { get; set; }
    }

    public class MatchVariableInfo : PropertyBase
    {

        public string VariableName { get; set; }

        public string Selector { get; set; }
    }

    public class ManagedRulesInfo : PropertyBase
    {

        public IList<ExclusionInfo> Exclusions { get; set; }

        public IList<ManagedRuleSetInfo> ManagedRuleSets { get; set; }
    }

    public class ManagedRuleSetInfo : PropertyBase
    {

        public string RuleSetType { get; set; }

        public string RuleSetVersion { get; set; }

        public IList<RuleGroupOverrideInfo> RuleGroupOverrides { get; set; }
    }

    public class RuleGroupOverrideInfo : PropertyBase
    {

        public string RuleGroupName { get; set; }

        public IList<RuleInfo> Rules { get; set; }
    }

    public class RuleInfo : PropertyBase
    {

        public string RuleId { get; set; }

        public string State { get; set; }
    }

    public class ApplicationSecurityGroup : Resource<ApplicationSecurityGroupProperties>
    {
        public ApplicationSecurityGroup() => (Type, ApiVersion) = ("Microsoft.Network/applicationSecurityGroups", "2020-04-01");
        public ApplicationSecurityGroup(string name) : this() => Name = name;
        public ApplicationSecurityGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public ApplicationSecurityGroup WithProperties(Action<ApplicationSecurityGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ApplicationSecurityGroupProperties : PropertyBase
    {
    }

    public class AzureFirewall : Resource<AzureFirewallProperties>
    {
        public AzureFirewall() => (Type, ApiVersion) = ("Microsoft.Network/azureFirewalls", "2020-04-01");
        public AzureFirewall(string name) : this() => Name = name;
        public AzureFirewall(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public AzureFirewall WithProperties(Action<AzureFirewallProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class AzureFirewallProperties : PropertyBase
    {

        public IList<ApplicationRuleCollectionInfo> ApplicationRuleCollections { get; set; }

        public IList<NatRuleCollectionInfo> NatRuleCollections { get; set; }

        public IList<NetworkRuleCollectionInfo> NetworkRuleCollections { get; set; }

        public IList<IpConfigurationInfo> IpConfigurations { get; set; }

        private ManagementIpConfigurationInfo _managementIpConfiguration;
        public ManagementIpConfigurationInfo ManagementIpConfiguration
        {
            get => _managementIpConfiguration = Get(_managementIpConfiguration);
            set => _managementIpConfiguration = value;
        }

        public string ThreatIntelMode { get; set; }

        private VirtualHubInfo _virtualHub;
        public VirtualHubInfo VirtualHub
        {
            get => _virtualHub = Get(_virtualHub);
            set => _virtualHub = value;
        }

        private FirewallPolicyInfo _firewallPolicy;
        public FirewallPolicyInfo FirewallPolicy
        {
            get => _firewallPolicy = Get(_firewallPolicy);
            set => _firewallPolicy = value;
        }

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        public object AdditionalProperties { get; set; }
    }

    public class ApplicationRuleCollectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ActionInfo : PropertyBase
    {

        public string Type { get; set; }
    }

    public class ProtocolInfo : PropertyBase
    {

        public string ProtocolType { get; set; }

        public int? Port { get; set; }
    }

    public class NatRuleCollectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private NatRuleCollectionPropertiesInfo _properties;
        public NatRuleCollectionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NatRuleCollectionPropertiesInfo : PropertyBase
    {

        public int? Priority { get; set; }

        private ActionInfo _action;
        public ActionInfo Action
        {
            get => _action = Get(_action);
            set => _action = value;
        }

        public IList<NatRuleCollectionPropertiesRuleInfo> Rules { get; set; }
    }

    public class NatRuleCollectionPropertiesRuleInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<string> SourceAddresses { get; set; }

        public IList<string> DestinationAddresses { get; set; }

        public IList<string> DestinationPorts { get; set; }

        public IList<string> Protocols { get; set; }

        public string TranslatedAddress { get; set; }

        public string TranslatedPort { get; set; }

        public string TranslatedFqdn { get; set; }

        public IList<string> SourceIpGroups { get; set; }
    }

    public class NetworkRuleCollectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private NetworkRuleCollectionPropertiesInfo _properties;
        public NetworkRuleCollectionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NetworkRuleCollectionPropertiesInfo : PropertyBase
    {

        public int? Priority { get; set; }

        private ActionInfo _action;
        public ActionInfo Action
        {
            get => _action = Get(_action);
            set => _action = value;
        }

        public IList<NetworkRuleCollectionPropertiesRuleInfo> Rules { get; set; }
    }

    public class NetworkRuleCollectionPropertiesRuleInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<string> Protocols { get; set; }

        public IList<string> SourceAddresses { get; set; }

        public IList<string> DestinationAddresses { get; set; }

        public IList<string> DestinationPorts { get; set; }

        public IList<string> DestinationFqdns { get; set; }

        public IList<string> SourceIpGroups { get; set; }

        public IList<string> DestinationIpGroups { get; set; }
    }

    public class IpConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private IpConfigurationPropertiesInfo _properties;
        public IpConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class IpConfigurationPropertiesInfo : PropertyBase
    {

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        private PublicIPAddressInfo _publicIPAddress;
        public PublicIPAddressInfo PublicIPAddress
        {
            get => _publicIPAddress = Get(_publicIPAddress);
            set => _publicIPAddress = value;
        }
    }

    public class ManagementIpConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private ManagementIpConfigurationPropertiesInfo _properties;
        public ManagementIpConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ManagementIpConfigurationPropertiesInfo : PropertyBase
    {

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        private PublicIPAddressInfo _publicIPAddress;
        public PublicIPAddressInfo PublicIPAddress
        {
            get => _publicIPAddress = Get(_publicIPAddress);
            set => _publicIPAddress = value;
        }
    }

    public class VirtualHubInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class BastionHost : Resource<BastionHostProperties>
    {
        public BastionHost() => (Type, ApiVersion) = ("Microsoft.Network/bastionHosts", "2020-04-01");
        public BastionHost(string name) : this() => Name = name;
        public BastionHost(string name, Location location) : this() => (Name, Location) = (name, location);

        public BastionHost WithProperties(Action<BastionHostProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BastionHostProperties : PropertyBase
    {

        public IList<IpConfigurationInfo> IpConfigurations { get; set; }

        public string DnsName { get; set; }
    }

    public class Connection : Resource<ConnectionProperties>
    {
        public Connection() => (Type, ApiVersion) = ("Microsoft.Network/connections", "2020-04-01");
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

        public string AuthorizationKey { get; set; }

        private VirtualNetworkGateway1Info _virtualNetworkGateway1;
        public VirtualNetworkGateway1Info VirtualNetworkGateway1
        {
            get => _virtualNetworkGateway1 = Get(_virtualNetworkGateway1);
            set => _virtualNetworkGateway1 = value;
        }

        private VirtualNetworkGateway2Info _virtualNetworkGateway2;
        public VirtualNetworkGateway2Info VirtualNetworkGateway2
        {
            get => _virtualNetworkGateway2 = Get(_virtualNetworkGateway2);
            set => _virtualNetworkGateway2 = value;
        }

        private LocalNetworkGateway2Info _localNetworkGateway2;
        public LocalNetworkGateway2Info LocalNetworkGateway2
        {
            get => _localNetworkGateway2 = Get(_localNetworkGateway2);
            set => _localNetworkGateway2 = value;
        }

        public string ConnectionType { get; set; }

        public string ConnectionProtocol { get; set; }

        public int? RoutingWeight { get; set; }

        public int? DpdTimeoutSeconds { get; set; }

        public string SharedKey { get; set; }

        private PeerInfo _peer;
        public PeerInfo Peer
        {
            get => _peer = Get(_peer);
            set => _peer = value;
        }

        public bool? EnableBgp { get; set; }

        public bool? UseLocalAzureIpAddress { get; set; }

        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        public IList<IpsecPolicyInfo> IpsecPolicies { get; set; }

        public IList<TrafficSelectorPolicyInfo> TrafficSelectorPolicies { get; set; }

        public bool? ExpressRouteGatewayBypass { get; set; }
    }

    public class VirtualNetworkGateway1Info : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class GatewayDefaultSiteInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VpnClientConfigurationInfo : PropertyBase
    {

        private VpnClientAddressPoolInfo _vpnClientAddressPool;
        public VpnClientAddressPoolInfo VpnClientAddressPool
        {
            get => _vpnClientAddressPool = Get(_vpnClientAddressPool);
            set => _vpnClientAddressPool = value;
        }

        public IList<VpnClientRootCertificateInfo> VpnClientRootCertificates { get; set; }

        public IList<VpnClientRevokedCertificateInfo> VpnClientRevokedCertificates { get; set; }

        public IList<string> VpnClientProtocols { get; set; }

        public IList<VpnClientIpsecPolicyInfo> VpnClientIpsecPolicies { get; set; }

        public string RadiusServerAddress { get; set; }

        public string RadiusServerSecret { get; set; }

        public IList<RadiusServerInfo> RadiusServers { get; set; }

        public string AadTenant { get; set; }

        public string AadAudience { get; set; }

        public string AadIssuer { get; set; }
    }

    public class VpnClientAddressPoolInfo : PropertyBase
    {

        public IList<string> AddressPrefixes { get; set; }
    }

    public class VpnClientRootCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private VpnClientRootCertificatePropertiesInfo _properties;
        public VpnClientRootCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VpnClientRootCertificatePropertiesInfo : PropertyBase
    {

        public string PublicCertData { get; set; }
    }

    public class VpnClientRevokedCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private VpnClientRevokedCertificatePropertiesInfo _properties;
        public VpnClientRevokedCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VpnClientRevokedCertificatePropertiesInfo : PropertyBase
    {

        public string Thumbprint { get; set; }
    }

    public class VpnClientIpsecPolicyInfo : PropertyBase
    {

        public int? SaLifeTimeSeconds { get; set; }

        public int? SaDataSizeKilobytes { get; set; }

        public string IpsecEncryption { get; set; }

        public string IpsecIntegrity { get; set; }

        public string IkeEncryption { get; set; }

        public string IkeIntegrity { get; set; }

        public string DhGroup { get; set; }

        public string PfsGroup { get; set; }
    }

    public class RadiusServerInfo : PropertyBase
    {

        public string RadiusServerAddress { get; set; }

        public int? RadiusServerScore { get; set; }

        public string RadiusServerSecret { get; set; }
    }

    public class BgpSettingsInfo : PropertyBase
    {

        public int? Asn { get; set; }

        public string BgpPeeringAddress { get; set; }

        public int? PeerWeight { get; set; }

        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public class BgpPeeringAddresseInfo : PropertyBase
    {

        public string IpconfigurationId { get; set; }

        public IList<string> CustomBgpIpAddresses { get; set; }
    }

    public class CustomRoutesInfo : PropertyBase
    {

        public IList<string> AddressPrefixes { get; set; }
    }

    public class VirtualNetworkGateway2Info : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private VirtualNetworkGateway2PropertiesInfo _properties;
        public VirtualNetworkGateway2PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class VirtualNetworkGateway2PropertiesInfo : PropertyBase
    {

        public IList<VirtualNetworkGateway2PropertiesIpConfigurationInfo> IpConfigurations { get; set; }

        public string GatewayType { get; set; }

        public string VpnType { get; set; }

        public string VpnGatewayGeneration { get; set; }

        public bool? EnableBgp { get; set; }

        public bool? EnablePrivateIpAddress { get; set; }

        public bool? ActiveActive { get; set; }

        private GatewayDefaultSiteInfo _gatewayDefaultSite;
        public GatewayDefaultSiteInfo GatewayDefaultSite
        {
            get => _gatewayDefaultSite = Get(_gatewayDefaultSite);
            set => _gatewayDefaultSite = value;
        }

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        private VirtualNetworkGateway2PropertiesVpnClientConfigurationInfo _vpnClientConfiguration;
        public VirtualNetworkGateway2PropertiesVpnClientConfigurationInfo VpnClientConfiguration
        {
            get => _vpnClientConfiguration = Get(_vpnClientConfiguration);
            set => _vpnClientConfiguration = value;
        }

        private VirtualNetworkGateway2PropertiesBgpSettingsInfo _bgpSettings;
        public VirtualNetworkGateway2PropertiesBgpSettingsInfo BgpSettings
        {
            get => _bgpSettings = Get(_bgpSettings);
            set => _bgpSettings = value;
        }

        private CustomRoutesInfo _customRoutes;
        public CustomRoutesInfo CustomRoutes
        {
            get => _customRoutes = Get(_customRoutes);
            set => _customRoutes = value;
        }

        public bool? EnableDnsForwarding { get; set; }
    }

    public class VirtualNetworkGateway2PropertiesIpConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkGateway2PropertiesIpConfigurationPropertiesInfo _properties;
        public VirtualNetworkGateway2PropertiesIpConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkGateway2PropertiesIpConfigurationPropertiesInfo : PropertyBase
    {

        public string PrivateIPAllocationMethod { get; set; }

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        private PublicIPAddressInfo _publicIPAddress;
        public PublicIPAddressInfo PublicIPAddress
        {
            get => _publicIPAddress = Get(_publicIPAddress);
            set => _publicIPAddress = value;
        }
    }

    public class VirtualNetworkGateway2PropertiesVpnClientConfigurationInfo : PropertyBase
    {

        private VpnClientAddressPoolInfo _vpnClientAddressPool;
        public VpnClientAddressPoolInfo VpnClientAddressPool
        {
            get => _vpnClientAddressPool = Get(_vpnClientAddressPool);
            set => _vpnClientAddressPool = value;
        }

        public IList<VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificateInfo> VpnClientRootCertificates { get; set; }

        public IList<VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificateInfo> VpnClientRevokedCertificates { get; set; }

        public IList<string> VpnClientProtocols { get; set; }

        public IList<VpnClientIpsecPolicyInfo> VpnClientIpsecPolicies { get; set; }

        public string RadiusServerAddress { get; set; }

        public string RadiusServerSecret { get; set; }

        public IList<RadiusServerInfo> RadiusServers { get; set; }

        public string AadTenant { get; set; }

        public string AadAudience { get; set; }

        public string AadIssuer { get; set; }
    }

    public class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificatePropertiesInfo _properties;
        public VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificatePropertiesInfo : PropertyBase
    {

        public string PublicCertData { get; set; }
    }

    public class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificatePropertiesInfo _properties;
        public VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificatePropertiesInfo : PropertyBase
    {

        public string Thumbprint { get; set; }
    }

    public class VirtualNetworkGateway2PropertiesBgpSettingsInfo : PropertyBase
    {

        public int? Asn { get; set; }

        public string BgpPeeringAddress { get; set; }

        public int? PeerWeight { get; set; }

        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public class LocalNetworkGateway2Info : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private LocalNetworkGateway2PropertiesInfo _properties;
        public LocalNetworkGateway2PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class LocalNetworkGateway2PropertiesInfo : PropertyBase
    {

        private LocalNetworkAddressSpaceInfo _localNetworkAddressSpace;
        public LocalNetworkAddressSpaceInfo LocalNetworkAddressSpace
        {
            get => _localNetworkAddressSpace = Get(_localNetworkAddressSpace);
            set => _localNetworkAddressSpace = value;
        }

        public string GatewayIpAddress { get; set; }

        public string Fqdn { get; set; }

        private LocalNetworkGateway2PropertiesBgpSettingsInfo _bgpSettings;
        public LocalNetworkGateway2PropertiesBgpSettingsInfo BgpSettings
        {
            get => _bgpSettings = Get(_bgpSettings);
            set => _bgpSettings = value;
        }
    }

    public class LocalNetworkAddressSpaceInfo : PropertyBase
    {

        public IList<string> AddressPrefixes { get; set; }
    }

    public class LocalNetworkGateway2PropertiesBgpSettingsInfo : PropertyBase
    {

        public int? Asn { get; set; }

        public string BgpPeeringAddress { get; set; }

        public int? PeerWeight { get; set; }

        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public class PeerInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class IpsecPolicyInfo : PropertyBase
    {

        public int? SaLifeTimeSeconds { get; set; }

        public int? SaDataSizeKilobytes { get; set; }

        public string IpsecEncryption { get; set; }

        public string IpsecIntegrity { get; set; }

        public string IkeEncryption { get; set; }

        public string IkeIntegrity { get; set; }

        public string DhGroup { get; set; }

        public string PfsGroup { get; set; }
    }

    public class TrafficSelectorPolicyInfo : PropertyBase
    {

        public IList<string> LocalAddressRanges { get; set; }

        public IList<string> RemoteAddressRanges { get; set; }
    }

    public class DdosCustomPolicy : Resource<DdosCustomPolicyProperties>
    {
        public DdosCustomPolicy() => (Type, ApiVersion) = ("Microsoft.Network/ddosCustomPolicies", "2020-04-01");
        public DdosCustomPolicy(string name) : this() => Name = name;
        public DdosCustomPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public DdosCustomPolicy WithProperties(Action<DdosCustomPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DdosCustomPolicyProperties : PropertyBase
    {

        public IList<ProtocolCustomSettingInfo> ProtocolCustomSettings { get; set; }
    }

    public class ProtocolCustomSettingInfo : PropertyBase
    {

        public string Protocol { get; set; }

        public string TriggerRateOverride { get; set; }

        public string SourceRateOverride { get; set; }

        public string TriggerSensitivityOverride { get; set; }
    }

    public class DdosProtectionPlan : Resource<DdosProtectionPlanProperties>
    {
        public DdosProtectionPlan() => (Type, ApiVersion) = ("Microsoft.Network/ddosProtectionPlans", "2020-04-01");
        public DdosProtectionPlan(string name) : this() => Name = name;
        public DdosProtectionPlan(string name, Location location) : this() => (Name, Location) = (name, location);

        public DdosProtectionPlan WithProperties(Action<DdosProtectionPlanProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DdosProtectionPlanProperties : PropertyBase
    {
    }

    public class ExpressRouteCircuitAuthorization : Resource<ExpressRouteCircuitAuthorizationProperties>
    {
        public ExpressRouteCircuitAuthorization() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits/authorizations", "2020-04-01");
        public ExpressRouteCircuitAuthorization(string name) : this() => Name = name;
        public ExpressRouteCircuitAuthorization(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteCircuitAuthorization WithProperties(Action<ExpressRouteCircuitAuthorizationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteCircuitAuthorizationProperties : PropertyBase
    {

        public string AuthorizationKey { get; set; }

        public string AuthorizationUseStatus { get; set; }
    }

    public class ExpressRouteCircuitPeeringConnection : Resource<ExpressRouteCircuitPeeringConnectionProperties>
    {
        public ExpressRouteCircuitPeeringConnection() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits/peerings/connections", "2020-04-01");
        public ExpressRouteCircuitPeeringConnection(string name) : this() => Name = name;
        public ExpressRouteCircuitPeeringConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteCircuitPeeringConnection WithProperties(Action<ExpressRouteCircuitPeeringConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteCircuitPeeringConnectionProperties : PropertyBase
    {

        private ExpressRouteCircuitPeeringInfo _expressRouteCircuitPeering;
        public ExpressRouteCircuitPeeringInfo ExpressRouteCircuitPeering
        {
            get => _expressRouteCircuitPeering = Get(_expressRouteCircuitPeering);
            set => _expressRouteCircuitPeering = value;
        }

        private PeerExpressRouteCircuitPeeringInfo _peerExpressRouteCircuitPeering;
        public PeerExpressRouteCircuitPeeringInfo PeerExpressRouteCircuitPeering
        {
            get => _peerExpressRouteCircuitPeering = Get(_peerExpressRouteCircuitPeering);
            set => _peerExpressRouteCircuitPeering = value;
        }

        public string AddressPrefix { get; set; }

        public string AuthorizationKey { get; set; }

        private Ipv6CircuitConnectionConfigInfo _ipv6CircuitConnectionConfig;
        public Ipv6CircuitConnectionConfigInfo Ipv6CircuitConnectionConfig
        {
            get => _ipv6CircuitConnectionConfig = Get(_ipv6CircuitConnectionConfig);
            set => _ipv6CircuitConnectionConfig = value;
        }

        public string CircuitConnectionStatus { get; set; }
    }

    public class ExpressRouteCircuitPeeringInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PeerExpressRouteCircuitPeeringInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class Ipv6CircuitConnectionConfigInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }
    }

    public class ExpressRouteCircuitPeering : Resource<ExpressRouteCircuitPeeringProperties>
    {
        public ExpressRouteCircuitPeering() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits/peerings", "2020-04-01");
        public ExpressRouteCircuitPeering(string name) : this() => Name = name;
        public ExpressRouteCircuitPeering(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteCircuitPeering WithProperties(Action<ExpressRouteCircuitPeeringProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteCircuitPeeringProperties : PropertyBase
    {

        public string PeeringType { get; set; }

        public string State { get; set; }

        public int? AzureASN { get; set; }

        public int? PeerASN { get; set; }

        public string PrimaryPeerAddressPrefix { get; set; }

        public string SecondaryPeerAddressPrefix { get; set; }

        public string PrimaryAzurePort { get; set; }

        public string SecondaryAzurePort { get; set; }

        public string SharedKey { get; set; }

        public int? VlanId { get; set; }

        private MicrosoftPeeringConfigInfo _microsoftPeeringConfig;
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig
        {
            get => _microsoftPeeringConfig = Get(_microsoftPeeringConfig);
            set => _microsoftPeeringConfig = value;
        }

        private StatsInfo _stats;
        public StatsInfo Stats
        {
            get => _stats = Get(_stats);
            set => _stats = value;
        }

        private RouteFilterInfo _routeFilter;
        public RouteFilterInfo RouteFilter
        {
            get => _routeFilter = Get(_routeFilter);
            set => _routeFilter = value;
        }

        private Ipv6PeeringConfigInfo _ipv6PeeringConfig;
        public Ipv6PeeringConfigInfo Ipv6PeeringConfig
        {
            get => _ipv6PeeringConfig = Get(_ipv6PeeringConfig);
            set => _ipv6PeeringConfig = value;
        }

        public object ExpressRouteConnection { get; set; }

        public IList<ConnectionInfo> Connections { get; set; }
    }

    public class MicrosoftPeeringConfigInfo : PropertyBase
    {

        public IList<string> AdvertisedPublicPrefixes { get; set; }

        public IList<string> AdvertisedCommunities { get; set; }

        public int? LegacyMode { get; set; }

        public int? CustomerASN { get; set; }

        public string RoutingRegistryName { get; set; }
    }

    public class StatsInfo : PropertyBase
    {

        public int? PrimarybytesIn { get; set; }

        public int? PrimarybytesOut { get; set; }

        public int? SecondarybytesIn { get; set; }

        public int? SecondarybytesOut { get; set; }
    }

    public class RouteFilterInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class Ipv6PeeringConfigInfo : PropertyBase
    {

        public string PrimaryPeerAddressPrefix { get; set; }

        public string SecondaryPeerAddressPrefix { get; set; }

        private MicrosoftPeeringConfigInfo _microsoftPeeringConfig;
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig
        {
            get => _microsoftPeeringConfig = Get(_microsoftPeeringConfig);
            set => _microsoftPeeringConfig = value;
        }

        private RouteFilterInfo _routeFilter;
        public RouteFilterInfo RouteFilter
        {
            get => _routeFilter = Get(_routeFilter);
            set => _routeFilter = value;
        }

        public string State { get; set; }
    }

    public class ConnectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ExpressRouteCircuit : Resource<ExpressRouteCircuitProperties>
    {
        public ExpressRouteCircuit() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits", "2020-04-01");
        public ExpressRouteCircuit(string name) : this() => Name = name;
        public ExpressRouteCircuit(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteCircuit WithProperties(Action<ExpressRouteCircuitProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteCircuitProperties : PropertyBase
    {

        public bool? AllowClassicOperations { get; set; }

        public IList<AuthorizationInfo> Authorizations { get; set; }

        public IList<PeeringInfo> Peerings { get; set; }

        public string ServiceKey { get; set; }

        public string ServiceProviderNotes { get; set; }

        private ServiceProviderPropertiesInfo _serviceProviderProperties;
        public ServiceProviderPropertiesInfo ServiceProviderProperties
        {
            get => _serviceProviderProperties = Get(_serviceProviderProperties);
            set => _serviceProviderProperties = value;
        }

        private ExpressRoutePortInfo _expressRoutePort;
        public ExpressRoutePortInfo ExpressRoutePort
        {
            get => _expressRoutePort = Get(_expressRoutePort);
            set => _expressRoutePort = value;
        }

        public string BandwidthInGbps { get; set; }

        public bool? GlobalReachEnabled { get; set; }
    }

    public class AuthorizationInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PeeringInfo : PropertyBase
    {

        public string Id { get; set; }

        private PeeringPropertiesInfo _properties;
        public PeeringPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PeeringPropertiesInfo : PropertyBase
    {

        public string PeeringType { get; set; }

        public string State { get; set; }

        public int? AzureASN { get; set; }

        public int? PeerASN { get; set; }

        public string PrimaryPeerAddressPrefix { get; set; }

        public string SecondaryPeerAddressPrefix { get; set; }

        public string PrimaryAzurePort { get; set; }

        public string SecondaryAzurePort { get; set; }

        public string SharedKey { get; set; }

        public int? VlanId { get; set; }

        private MicrosoftPeeringConfigInfo _microsoftPeeringConfig;
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig
        {
            get => _microsoftPeeringConfig = Get(_microsoftPeeringConfig);
            set => _microsoftPeeringConfig = value;
        }

        private StatsInfo _stats;
        public StatsInfo Stats
        {
            get => _stats = Get(_stats);
            set => _stats = value;
        }

        private RouteFilterInfo _routeFilter;
        public RouteFilterInfo RouteFilter
        {
            get => _routeFilter = Get(_routeFilter);
            set => _routeFilter = value;
        }

        private Ipv6PeeringConfigInfo _ipv6PeeringConfig;
        public Ipv6PeeringConfigInfo Ipv6PeeringConfig
        {
            get => _ipv6PeeringConfig = Get(_ipv6PeeringConfig);
            set => _ipv6PeeringConfig = value;
        }

        public object ExpressRouteConnection { get; set; }

        public IList<ConnectionInfo> Connections { get; set; }
    }

    public class ConnectionPropertiesInfo : PropertyBase
    {

        private ExpressRouteCircuitPeeringInfo _expressRouteCircuitPeering;
        public ExpressRouteCircuitPeeringInfo ExpressRouteCircuitPeering
        {
            get => _expressRouteCircuitPeering = Get(_expressRouteCircuitPeering);
            set => _expressRouteCircuitPeering = value;
        }

        private PeerExpressRouteCircuitPeeringInfo _peerExpressRouteCircuitPeering;
        public PeerExpressRouteCircuitPeeringInfo PeerExpressRouteCircuitPeering
        {
            get => _peerExpressRouteCircuitPeering = Get(_peerExpressRouteCircuitPeering);
            set => _peerExpressRouteCircuitPeering = value;
        }

        public string AddressPrefix { get; set; }

        public string AuthorizationKey { get; set; }

        private Ipv6CircuitConnectionConfigInfo _ipv6CircuitConnectionConfig;
        public Ipv6CircuitConnectionConfigInfo Ipv6CircuitConnectionConfig
        {
            get => _ipv6CircuitConnectionConfig = Get(_ipv6CircuitConnectionConfig);
            set => _ipv6CircuitConnectionConfig = value;
        }

        public string CircuitConnectionStatus { get; set; }
    }

    public class ServiceProviderPropertiesInfo : PropertyBase
    {

        public string ServiceProviderName { get; set; }

        public string PeeringLocation { get; set; }

        public int? BandwidthInMbps { get; set; }
    }

    public class ExpressRoutePortInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ExpressRouteCrossConnectionPeering : Resource<ExpressRouteCrossConnectionPeeringProperties>
    {
        public ExpressRouteCrossConnectionPeering() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCrossConnections/peerings", "2020-04-01");
        public ExpressRouteCrossConnectionPeering(string name) : this() => Name = name;
        public ExpressRouteCrossConnectionPeering(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteCrossConnectionPeering WithProperties(Action<ExpressRouteCrossConnectionPeeringProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteCrossConnectionPeeringProperties : PropertyBase
    {

        public string PeeringType { get; set; }

        public string State { get; set; }

        public int? PeerASN { get; set; }

        public string PrimaryPeerAddressPrefix { get; set; }

        public string SecondaryPeerAddressPrefix { get; set; }

        public string SharedKey { get; set; }

        public int? VlanId { get; set; }

        private MicrosoftPeeringConfigInfo _microsoftPeeringConfig;
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig
        {
            get => _microsoftPeeringConfig = Get(_microsoftPeeringConfig);
            set => _microsoftPeeringConfig = value;
        }

        private Ipv6PeeringConfigInfo _ipv6PeeringConfig;
        public Ipv6PeeringConfigInfo Ipv6PeeringConfig
        {
            get => _ipv6PeeringConfig = Get(_ipv6PeeringConfig);
            set => _ipv6PeeringConfig = value;
        }
    }

    public class ExpressRouteCrossConnection : Resource<ExpressRouteCrossConnectionProperties>
    {
        public ExpressRouteCrossConnection() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCrossConnections", "2020-04-01");
        public ExpressRouteCrossConnection(string name) : this() => Name = name;
        public ExpressRouteCrossConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteCrossConnection WithProperties(Action<ExpressRouteCrossConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteCrossConnectionProperties : PropertyBase
    {

        public string PeeringLocation { get; set; }

        public int? BandwidthInMbps { get; set; }

        private ExpressRouteCircuitInfo _expressRouteCircuit;
        public ExpressRouteCircuitInfo ExpressRouteCircuit
        {
            get => _expressRouteCircuit = Get(_expressRouteCircuit);
            set => _expressRouteCircuit = value;
        }

        public string ServiceProviderNotes { get; set; }

        public IList<PeeringInfo> Peerings { get; set; }
    }

    public class ExpressRouteCircuitInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ExpressRouteGatewayExpressRouteConnection : Resource<ExpressRouteGatewayExpressRouteConnectionProperties>
    {
        public ExpressRouteGatewayExpressRouteConnection() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteGateways/expressRouteConnections", "2020-04-01");
        public ExpressRouteGatewayExpressRouteConnection(string name) : this() => Name = name;
        public ExpressRouteGatewayExpressRouteConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteGatewayExpressRouteConnection WithProperties(Action<ExpressRouteGatewayExpressRouteConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteGatewayExpressRouteConnectionProperties : PropertyBase
    {

        private ExpressRouteCircuitPeeringInfo _expressRouteCircuitPeering;
        public ExpressRouteCircuitPeeringInfo ExpressRouteCircuitPeering
        {
            get => _expressRouteCircuitPeering = Get(_expressRouteCircuitPeering);
            set => _expressRouteCircuitPeering = value;
        }

        public string AuthorizationKey { get; set; }

        public int? RoutingWeight { get; set; }

        public bool? EnableInternetSecurity { get; set; }

        private RoutingConfigurationInfo _routingConfiguration;
        public RoutingConfigurationInfo RoutingConfiguration
        {
            get => _routingConfiguration = Get(_routingConfiguration);
            set => _routingConfiguration = value;
        }
    }

    public class RoutingConfigurationInfo : PropertyBase
    {

        private AssociatedRouteTableInfo _associatedRouteTable;
        public AssociatedRouteTableInfo AssociatedRouteTable
        {
            get => _associatedRouteTable = Get(_associatedRouteTable);
            set => _associatedRouteTable = value;
        }

        private PropagatedRouteTablesInfo _propagatedRouteTables;
        public PropagatedRouteTablesInfo PropagatedRouteTables
        {
            get => _propagatedRouteTables = Get(_propagatedRouteTables);
            set => _propagatedRouteTables = value;
        }

        private VnetRoutesInfo _vnetRoutes;
        public VnetRoutesInfo VnetRoutes
        {
            get => _vnetRoutes = Get(_vnetRoutes);
            set => _vnetRoutes = value;
        }
    }

    public class AssociatedRouteTableInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PropagatedRouteTablesInfo : PropertyBase
    {

        public IList<string> Labels { get; set; }

        public IList<IdInfo> Ids { get; set; }
    }

    public class IdInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VnetRoutesInfo : PropertyBase
    {

        public IList<StaticRouteInfo> StaticRoutes { get; set; }
    }

    public class StaticRouteInfo : PropertyBase
    {

        public string Name { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class ExpressRouteGateway : Resource<ExpressRouteGatewayProperties>
    {
        public ExpressRouteGateway() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteGateways", "2020-04-01");
        public ExpressRouteGateway(string name) : this() => Name = name;
        public ExpressRouteGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public ExpressRouteGateway WithProperties(Action<ExpressRouteGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRouteGatewayProperties : PropertyBase
    {

        private AutoScaleConfigurationInfo _autoScaleConfiguration;
        public AutoScaleConfigurationInfo AutoScaleConfiguration
        {
            get => _autoScaleConfiguration = Get(_autoScaleConfiguration);
            set => _autoScaleConfiguration = value;
        }

        private VirtualHubInfo _virtualHub;
        public VirtualHubInfo VirtualHub
        {
            get => _virtualHub = Get(_virtualHub);
            set => _virtualHub = value;
        }
    }

    public class AutoScaleConfigurationInfo : PropertyBase
    {

        private BoundsInfo _bounds;
        public BoundsInfo Bounds
        {
            get => _bounds = Get(_bounds);
            set => _bounds = value;
        }
    }

    public class BoundsInfo : PropertyBase
    {

        public int? Min { get; set; }

        public int? Max { get; set; }
    }

    public class ExpressRoutePort : Resource<ExpressRoutePortProperties>
    {
        public ExpressRoutePort() => (Type, ApiVersion) = ("Microsoft.Network/ExpressRoutePorts", "2020-04-01");
        public ExpressRoutePort(string name) : this() => Name = name;
        public ExpressRoutePort(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public ExpressRoutePort WithProperties(Action<ExpressRoutePortProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ExpressRoutePortProperties : PropertyBase
    {

        public string PeeringLocation { get; set; }

        public int? BandwidthInGbps { get; set; }

        public string Encapsulation { get; set; }

        public IList<LinkInfo> Links { get; set; }
    }

    public class LinkInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class MacSecConfigInfo : PropertyBase
    {

        public string CknSecretIdentifier { get; set; }

        public string CakSecretIdentifier { get; set; }

        public string Cipher { get; set; }
    }

    public class FirewallPolicyRuleGroup : Resource<FirewallPolicyRuleGroupProperties>
    {
        public FirewallPolicyRuleGroup() => (Type, ApiVersion) = ("Microsoft.Network/firewallPolicies/ruleGroups", "2020-04-01");
        public FirewallPolicyRuleGroup(string name) : this() => Name = name;
        public FirewallPolicyRuleGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public FirewallPolicyRuleGroup WithProperties(Action<FirewallPolicyRuleGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class FirewallPolicyRuleGroupProperties : PropertyBase
    {

        public int? Priority { get; set; }

        public IList<RuleInfo> Rules { get; set; }
    }

    public class FirewallPolicy : Resource<FirewallPolicyProperties>
    {
        public FirewallPolicy() => (Type, ApiVersion) = ("Microsoft.Network/firewallPolicies", "2020-04-01");
        public FirewallPolicy(string name) : this() => Name = name;
        public FirewallPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public FirewallPolicy WithProperties(Action<FirewallPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class FirewallPolicyProperties : PropertyBase
    {

        private BasePolicyInfo _basePolicy;
        public BasePolicyInfo BasePolicy
        {
            get => _basePolicy = Get(_basePolicy);
            set => _basePolicy = value;
        }

        public string ThreatIntelMode { get; set; }

        private ThreatIntelWhitelistInfo _threatIntelWhitelist;
        public ThreatIntelWhitelistInfo ThreatIntelWhitelist
        {
            get => _threatIntelWhitelist = Get(_threatIntelWhitelist);
            set => _threatIntelWhitelist = value;
        }

        public string IntrusionSystemMode { get; set; }

        private TransportSecurityInfo _transportSecurity;
        public TransportSecurityInfo TransportSecurity
        {
            get => _transportSecurity = Get(_transportSecurity);
            set => _transportSecurity = value;
        }
    }

    public class BasePolicyInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ThreatIntelWhitelistInfo : PropertyBase
    {

        public IList<string> IpAddresses { get; set; }

        public IList<string> Fqdns { get; set; }
    }

    public class TransportSecurityInfo : PropertyBase
    {

        private CertificateAuthorityInfo _certificateAuthority;
        public CertificateAuthorityInfo CertificateAuthority
        {
            get => _certificateAuthority = Get(_certificateAuthority);
            set => _certificateAuthority = value;
        }

        public IList<string> ExcludedDomains { get; set; }

        public IList<TrustedRootCertificateInfo> TrustedRootCertificates { get; set; }
    }

    public class CertificateAuthorityInfo : PropertyBase
    {

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class InterfaceEndpoint : Resource<InterfaceEndpointProperties>
    {
        public InterfaceEndpoint() => (Type, ApiVersion) = ("Microsoft.Network/interfaceEndpoints", "2019-02-01");
        public InterfaceEndpoint(string name) : this() => Name = name;
        public InterfaceEndpoint(string name, Location location) : this() => (Name, Location) = (name, location);

        public InterfaceEndpoint WithProperties(Action<InterfaceEndpointProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class InterfaceEndpointProperties : PropertyBase
    {

        public string Fqdn { get; set; }

        private EndpointServiceInfo _endpointService;
        public EndpointServiceInfo EndpointService
        {
            get => _endpointService = Get(_endpointService);
            set => _endpointService = value;
        }

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }
    }

    public class EndpointServiceInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class NetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private NetworkSecurityGroupPropertiesInfo _properties;
        public NetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class NetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<SecurityRuleInfo> SecurityRules { get; set; }

        public IList<DefaultSecurityRuleInfo> DefaultSecurityRules { get; set; }

        public string ResourceGuid { get; set; }
    }

    public class SecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private SecurityRulePropertiesInfo _properties;
        public SecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class SecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<SourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<DestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class SourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class DestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class DefaultSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private DefaultSecurityRulePropertiesInfo _properties;
        public DefaultSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DefaultSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<DefaultSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<DefaultSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class DefaultSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class DefaultSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class RouteTableInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private RouteTablePropertiesInfo _properties;
        public RouteTablePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class RouteTablePropertiesInfo : PropertyBase
    {

        public IList<RouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class RouteInfo : PropertyBase
    {

        public string Id { get; set; }

        private RoutePropertiesInfo _properties;
        public RoutePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class RoutePropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class NatGatewayInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ServiceEndpointInfo : PropertyBase
    {

        public string Service { get; set; }

        public IList<string> Locations { get; set; }
    }

    public class ServiceEndpointPolicyInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private ServiceEndpointPolicyPropertiesInfo _properties;
        public ServiceEndpointPolicyPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class ServiceEndpointPolicyPropertiesInfo : PropertyBase
    {

        public IList<ServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class ServiceEndpointPolicyDefinitionInfo : PropertyBase
    {

        public string Id { get; set; }

        private ServiceEndpointPolicyDefinitionPropertiesInfo _properties;
        public ServiceEndpointPolicyDefinitionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ServiceEndpointPolicyDefinitionPropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class ResourceNavigationLinkInfo : PropertyBase
    {

        public string Id { get; set; }

        private ResourceNavigationLinkPropertiesInfo _properties;
        public ResourceNavigationLinkPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ResourceNavigationLinkPropertiesInfo : PropertyBase
    {

        public string LinkedResourceType { get; set; }

        public string Link { get; set; }
    }

    public class ServiceAssociationLinkInfo : PropertyBase
    {

        public string Id { get; set; }

        private ServiceAssociationLinkPropertiesInfo _properties;
        public ServiceAssociationLinkPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ServiceAssociationLinkPropertiesInfo : PropertyBase
    {

        public string LinkedResourceType { get; set; }

        public string Link { get; set; }
    }

    public class DelegationInfo : PropertyBase
    {

        public string Id { get; set; }

        private DelegationPropertiesInfo _properties;
        public DelegationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DelegationPropertiesInfo : PropertyBase
    {

        public string ServiceName { get; set; }

        public IList<string> Actions { get; set; }
    }

    public class IpAllocation : Resource<IpAllocationProperties>
    {
        public IpAllocation() => (Type, ApiVersion) = ("Microsoft.Network/IpAllocations", "2020-04-01");
        public IpAllocation(string name) : this() => Name = name;
        public IpAllocation(string name, Location location) : this() => (Name, Location) = (name, location);

        public IpAllocation WithProperties(Action<IpAllocationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IpAllocationProperties : PropertyBase
    {

        public string Type { get; set; }

        public string Prefix { get; set; }

        public int? PrefixLength { get; set; }

        public string PrefixType { get; set; }

        public string IpamAllocationId { get; set; }

        public object AllocationTags { get; set; }
    }

    public class IpGroup : Resource<IpGroupProperties>
    {
        public IpGroup() => (Type, ApiVersion) = ("Microsoft.Network/ipGroups", "2020-04-01");
        public IpGroup(string name) : this() => Name = name;
        public IpGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public IpGroup WithProperties(Action<IpGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IpGroupProperties : PropertyBase
    {

        public IList<string> IpAddresses { get; set; }
    }

    public class LoadBalancerBackendAddressPool : Resource<LoadBalancerBackendAddressPoolProperties>
    {
        public LoadBalancerBackendAddressPool() => (Type, ApiVersion) = ("Microsoft.Network/loadBalancers/backendAddressPools", "2020-04-01");
        public LoadBalancerBackendAddressPool(string name) : this() => Name = name;
        public LoadBalancerBackendAddressPool(string name, Location location) : this() => (Name, Location) = (name, location);

        public LoadBalancerBackendAddressPool WithProperties(Action<LoadBalancerBackendAddressPoolProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class LoadBalancerBackendAddressPoolProperties : PropertyBase
    {

        public IList<LoadBalancerBackendAddresseInfo> LoadBalancerBackendAddresses { get; set; }
    }

    public class LoadBalancerBackendAddresseInfo : PropertyBase
    {

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private VirtualNetworkPropertiesInfo _properties;
        public VirtualNetworkPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class VirtualNetworkPropertiesInfo : PropertyBase
    {

        private AddressSpaceInfo _addressSpace;
        public AddressSpaceInfo AddressSpace
        {
            get => _addressSpace = Get(_addressSpace);
            set => _addressSpace = value;
        }

        private DhcpOptionsInfo _dhcpOptions;
        public DhcpOptionsInfo DhcpOptions
        {
            get => _dhcpOptions = Get(_dhcpOptions);
            set => _dhcpOptions = value;
        }

        public IList<SubnetInfo> Subnets { get; set; }

        public IList<VirtualNetworkPeeringInfo> VirtualNetworkPeerings { get; set; }

        public bool? EnableDdosProtection { get; set; }

        public bool? EnableVmProtection { get; set; }

        private DdosProtectionPlanInfo _ddosProtectionPlan;
        public DdosProtectionPlanInfo DdosProtectionPlan
        {
            get => _ddosProtectionPlan = Get(_ddosProtectionPlan);
            set => _ddosProtectionPlan = value;
        }

        private BgpCommunitiesInfo _bgpCommunities;
        public BgpCommunitiesInfo BgpCommunities
        {
            get => _bgpCommunities = Get(_bgpCommunities);
            set => _bgpCommunities = value;
        }

        public IList<IpAllocationInfo> IpAllocations { get; set; }
    }

    public class AddressSpaceInfo : PropertyBase
    {

        public IList<string> AddressPrefixes { get; set; }
    }

    public class DhcpOptionsInfo : PropertyBase
    {

        public IList<string> DnsServers { get; set; }
    }

    public class SubnetPropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private NetworkSecurityGroupInfo _networkSecurityGroup;
        public NetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private RouteTableInfo _routeTable;
        public RouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<ServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<DelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class IpAllocationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VirtualNetworkPeeringInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkPeeringPropertiesInfo _properties;
        public VirtualNetworkPeeringPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkPeeringPropertiesInfo : PropertyBase
    {

        public bool? AllowVirtualNetworkAccess { get; set; }

        public bool? AllowForwardedTraffic { get; set; }

        public bool? AllowGatewayTransit { get; set; }

        public bool? UseRemoteGateways { get; set; }

        private RemoteVirtualNetworkInfo _remoteVirtualNetwork;
        public RemoteVirtualNetworkInfo RemoteVirtualNetwork
        {
            get => _remoteVirtualNetwork = Get(_remoteVirtualNetwork);
            set => _remoteVirtualNetwork = value;
        }

        private RemoteAddressSpaceInfo _remoteAddressSpace;
        public RemoteAddressSpaceInfo RemoteAddressSpace
        {
            get => _remoteAddressSpace = Get(_remoteAddressSpace);
            set => _remoteAddressSpace = value;
        }

        public string PeeringState { get; set; }
    }

    public class RemoteVirtualNetworkInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class RemoteAddressSpaceInfo : PropertyBase
    {

        public IList<string> AddressPrefixes { get; set; }
    }

    public class DdosProtectionPlanInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class BgpCommunitiesInfo : PropertyBase
    {

        public string VirtualNetworkCommunity { get; set; }
    }

    public class NetworkInterfaceIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesInfo : PropertyBase
    {

        public IList<VirtualNetworkTapInfo> VirtualNetworkTaps { get; set; }

        public IList<ApplicationGatewayBackendAddressPoolInfo> ApplicationGatewayBackendAddressPools { get; set; }

        public IList<LoadBalancerBackendAddressPoolInfo> LoadBalancerBackendAddressPools { get; set; }

        public IList<LoadBalancerInboundNatRuleInfo> LoadBalancerInboundNatRules { get; set; }

        public string PrivateIPAddress { get; set; }

        public string PrivateIPAllocationMethod { get; set; }

        public string PrivateIPAddressVersion { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetInfo _subnet;
        public NetworkInterfaceIPConfigurationPropertiesSubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        public bool? Primary { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesPublicIPAddressInfo _publicIPAddress;
        public NetworkInterfaceIPConfigurationPropertiesPublicIPAddressInfo PublicIPAddress
        {
            get => _publicIPAddress = Get(_publicIPAddress);
            set => _publicIPAddress = value;
        }

        public IList<ApplicationSecurityGroupInfo> ApplicationSecurityGroups { get; set; }
    }

    public class VirtualNetworkTapInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private VirtualNetworkTapPropertiesInfo _properties;
        public VirtualNetworkTapPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class VirtualNetworkTapPropertiesInfo : PropertyBase
    {

        public string DestinationNetworkInterfaceIPConfiguration { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationInfo _destinationLoadBalancerFrontEndIPConfiguration;
        public DestinationLoadBalancerFrontEndIPConfigurationInfo DestinationLoadBalancerFrontEndIPConfiguration
        {
            get => _destinationLoadBalancerFrontEndIPConfiguration = Get(_destinationLoadBalancerFrontEndIPConfiguration);
            set => _destinationLoadBalancerFrontEndIPConfiguration = value;
        }

        public int? DestinationPort { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }

        public IList<string> Zones { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesInfo : PropertyBase
    {

        public string PrivateIPAddress { get; set; }

        public string PrivateIPAllocationMethod { get; set; }

        public string PrivateIPAddressVersion { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetInfo _subnet;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        private PublicIPAddressInfo _publicIPAddress;
        public PublicIPAddressInfo PublicIPAddress
        {
            get => _publicIPAddress = Get(_publicIPAddress);
            set => _publicIPAddress = value;
        }

        private PublicIPPrefixInfo _publicIPPrefix;
        public PublicIPPrefixInfo PublicIPPrefix
        {
            get => _publicIPPrefix = Get(_publicIPPrefix);
            set => _publicIPPrefix = value;
        }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo _networkSecurityGroup;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTableInfo _routeTable;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTableInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo : PropertyBase
    {

        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo : PropertyBase
    {

        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo : PropertyBase
    {

        public string ServiceName { get; set; }
    }

    public class PublicIPAddressPropertiesInfo : PropertyBase
    {

        public string PublicIPAllocationMethod { get; set; }

        public string PublicIPAddressVersion { get; set; }

        private DnsSettingsInfo _dnsSettings;
        public DnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        private DdosSettingsInfo _ddosSettings;
        public DdosSettingsInfo DdosSettings
        {
            get => _ddosSettings = Get(_ddosSettings);
            set => _ddosSettings = value;
        }

        public IList<IpTagInfo> IpTags { get; set; }

        public string IpAddress { get; set; }

        private PublicIPPrefixInfo _publicIPPrefix;
        public PublicIPPrefixInfo PublicIPPrefix
        {
            get => _publicIPPrefix = Get(_publicIPPrefix);
            set => _publicIPPrefix = value;
        }

        public int? IdleTimeoutInMinutes { get; set; }
    }

    public class DnsSettingsInfo : PropertyBase
    {

        public string DomainNameLabel { get; set; }

        public string Fqdn { get; set; }

        public string ReverseFqdn { get; set; }
    }

    public class DdosSettingsInfo : PropertyBase
    {

        private DdosCustomPolicyInfo _ddosCustomPolicy;
        public DdosCustomPolicyInfo DdosCustomPolicy
        {
            get => _ddosCustomPolicy = Get(_ddosCustomPolicy);
            set => _ddosCustomPolicy = value;
        }

        public string ProtectionCoverage { get; set; }

        public bool? ProtectedIP { get; set; }
    }

    public class DdosCustomPolicyInfo : PropertyBase
    {

        public string Id { get; set; }
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

        private ApplicationGatewayBackendAddressPoolPropertiesInfo _properties;
        public ApplicationGatewayBackendAddressPoolPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ApplicationGatewayBackendAddressPoolPropertiesInfo : PropertyBase
    {

        public IList<BackendAddresseInfo> BackendAddresses { get; set; }
    }

    public class LoadBalancerBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Properties { get; set; }

        public string Name { get; set; }
    }

    public class LoadBalancerInboundNatRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private LoadBalancerInboundNatRulePropertiesInfo _properties;
        public LoadBalancerInboundNatRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class LoadBalancerInboundNatRulePropertiesInfo : PropertyBase
    {

        private FrontendIPConfigurationInfo _frontendIPConfiguration;
        public FrontendIPConfigurationInfo FrontendIPConfiguration
        {
            get => _frontendIPConfiguration = Get(_frontendIPConfiguration);
            set => _frontendIPConfiguration = value;
        }

        public string Protocol { get; set; }

        public int? FrontendPort { get; set; }

        public int? BackendPort { get; set; }

        public int? IdleTimeoutInMinutes { get; set; }

        public bool? EnableFloatingIP { get; set; }

        public bool? EnableTcpReset { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetInfo : PropertyBase
    {

        public string Id { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo _networkSecurityGroup;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo _routeTable;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo : PropertyBase
    {

        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo : PropertyBase
    {

        public string Id { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo : PropertyBase
    {

        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo : PropertyBase
    {

        public string Id { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo : PropertyBase
    {

        public string Id { get; set; }

        private NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo : PropertyBase
    {

        public string ServiceName { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesPublicIPAddressInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        private NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesInfo _properties;
        public NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public IList<string> Zones { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesInfo : PropertyBase
    {

        public string PublicIPAllocationMethod { get; set; }

        public string PublicIPAddressVersion { get; set; }

        private DnsSettingsInfo _dnsSettings;
        public DnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        private NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo _ddosSettings;
        public NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo DdosSettings
        {
            get => _ddosSettings = Get(_ddosSettings);
            set => _ddosSettings = value;
        }

        public IList<IpTagInfo> IpTags { get; set; }

        public string IpAddress { get; set; }

        private PublicIPPrefixInfo _publicIPPrefix;
        public PublicIPPrefixInfo PublicIPPrefix
        {
            get => _publicIPPrefix = Get(_publicIPPrefix);
            set => _publicIPPrefix = value;
        }

        public int? IdleTimeoutInMinutes { get; set; }
    }

    public class NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo : PropertyBase
    {

        private DdosCustomPolicyInfo _ddosCustomPolicy;
        public DdosCustomPolicyInfo DdosCustomPolicy
        {
            get => _ddosCustomPolicy = Get(_ddosCustomPolicy);
            set => _ddosCustomPolicy = value;
        }

        public string ProtectionCoverage { get; set; }

        public bool? ProtectedIP { get; set; }
    }

    public class ApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class LoadBalancerInboundNatRule : Resource<LoadBalancerInboundNatRuleProperties>
    {
        public LoadBalancerInboundNatRule() => (Type, ApiVersion) = ("Microsoft.Network/loadBalancers/inboundNatRules", "2020-04-01");
        public LoadBalancerInboundNatRule(string name) : this() => Name = name;
        public LoadBalancerInboundNatRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public LoadBalancerInboundNatRule WithProperties(Action<LoadBalancerInboundNatRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class LoadBalancerInboundNatRuleProperties : PropertyBase
    {

        private FrontendIPConfigurationInfo _frontendIPConfiguration;
        public FrontendIPConfigurationInfo FrontendIPConfiguration
        {
            get => _frontendIPConfiguration = Get(_frontendIPConfiguration);
            set => _frontendIPConfiguration = value;
        }

        public string Protocol { get; set; }

        public int? FrontendPort { get; set; }

        public int? BackendPort { get; set; }

        public int? IdleTimeoutInMinutes { get; set; }

        public bool? EnableFloatingIP { get; set; }

        public bool? EnableTcpReset { get; set; }
    }

    public class LoadBalancer : Resource<LoadBalancerProperties>
    {
        public LoadBalancer() => (Type, ApiVersion) = ("Microsoft.Network/loadBalancers", "2020-04-01");
        public LoadBalancer(string name) : this() => Name = name;
        public LoadBalancer(string name, Location location) : this() => (Name, Location) = (name, location);

        public LoadBalancer WithProperties(Action<LoadBalancerProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class LoadBalancerProperties : PropertyBase
    {

        public IList<FrontendIPConfigurationInfo> FrontendIPConfigurations { get; set; }

        public IList<BackendAddressPoolInfo> BackendAddressPools { get; set; }

        public IList<LoadBalancingRuleInfo> LoadBalancingRules { get; set; }

        public IList<PropertiesProbeInfo> Probes { get; set; }

        public IList<InboundNatRuleInfo> InboundNatRules { get; set; }

        public IList<InboundNatPoolInfo> InboundNatPools { get; set; }

        public IList<OutboundRuleInfo> OutboundRules { get; set; }
    }

    public class LoadBalancerBackendAddressePropertiesInfo : PropertyBase
    {

        private VirtualNetworkInfo _virtualNetwork;
        public VirtualNetworkInfo VirtualNetwork
        {
            get => _virtualNetwork = Get(_virtualNetwork);
            set => _virtualNetwork = value;
        }

        public string IpAddress { get; set; }

        private NetworkInterfaceIPConfigurationInfo _networkInterfaceIPConfiguration;
        public NetworkInterfaceIPConfigurationInfo NetworkInterfaceIPConfiguration
        {
            get => _networkInterfaceIPConfiguration = Get(_networkInterfaceIPConfiguration);
            set => _networkInterfaceIPConfiguration = value;
        }
    }

    public class VirtualNetworkPropertiesSubnetInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupInfo _networkSecurityGroup;
        public VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private VirtualNetworkPropertiesSubnetPropertiesRouteTableInfo _routeTable;
        public VirtualNetworkPropertiesSubnetPropertiesRouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<VirtualNetworkPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesRouteTableInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesInfo : PropertyBase
    {

        public IList<VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo : PropertyBase
    {

        public IList<VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesDelegationInfo : PropertyBase
    {

        public string Id { get; set; }

        private VirtualNetworkPropertiesSubnetPropertiesDelegationPropertiesInfo _properties;
        public VirtualNetworkPropertiesSubnetPropertiesDelegationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualNetworkPropertiesSubnetPropertiesDelegationPropertiesInfo : PropertyBase
    {

        public string ServiceName { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesInfo _properties;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public IList<string> Zones { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesInfo : PropertyBase
    {

        public string PublicIPAllocationMethod { get; set; }

        public string PublicIPAddressVersion { get; set; }

        private DnsSettingsInfo _dnsSettings;
        public DnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        private DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo _ddosSettings;
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo DdosSettings
        {
            get => _ddosSettings = Get(_ddosSettings);
            set => _ddosSettings = value;
        }

        public IList<IpTagInfo> IpTags { get; set; }

        public string IpAddress { get; set; }

        private PublicIPPrefixInfo _publicIPPrefix;
        public PublicIPPrefixInfo PublicIPPrefix
        {
            get => _publicIPPrefix = Get(_publicIPPrefix);
            set => _publicIPPrefix = value;
        }

        public int? IdleTimeoutInMinutes { get; set; }
    }

    public class DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo : PropertyBase
    {

        private DdosCustomPolicyInfo _ddosCustomPolicy;
        public DdosCustomPolicyInfo DdosCustomPolicy
        {
            get => _ddosCustomPolicy = Get(_ddosCustomPolicy);
            set => _ddosCustomPolicy = value;
        }

        public string ProtectionCoverage { get; set; }

        public bool? ProtectedIP { get; set; }
    }

    public class LoadBalancerInboundNatRulePropertiesFrontendIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class LoadBalancingRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private LoadBalancingRulePropertiesInfo _properties;
        public LoadBalancingRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class LoadBalancingRulePropertiesInfo : PropertyBase
    {

        private LoadBalancingRulePropertiesFrontendIPConfigurationInfo _frontendIPConfiguration;
        public LoadBalancingRulePropertiesFrontendIPConfigurationInfo FrontendIPConfiguration
        {
            get => _frontendIPConfiguration = Get(_frontendIPConfiguration);
            set => _frontendIPConfiguration = value;
        }

        private LoadBalancingRulePropertiesBackendAddressPoolInfo _backendAddressPool;
        public LoadBalancingRulePropertiesBackendAddressPoolInfo BackendAddressPool
        {
            get => _backendAddressPool = Get(_backendAddressPool);
            set => _backendAddressPool = value;
        }

        private ProbeInfo _probe;
        public ProbeInfo Probe
        {
            get => _probe = Get(_probe);
            set => _probe = value;
        }

        public string Protocol { get; set; }

        public string LoadDistribution { get; set; }

        public int? FrontendPort { get; set; }

        public int? BackendPort { get; set; }

        public int? IdleTimeoutInMinutes { get; set; }

        public bool? EnableFloatingIP { get; set; }

        public bool? EnableTcpReset { get; set; }

        public bool? DisableOutboundSnat { get; set; }
    }

    public class LoadBalancingRulePropertiesFrontendIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class LoadBalancingRulePropertiesBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PropertiesProbeInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesProbePropertiesInfo _properties;
        public PropertiesProbePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesProbePropertiesInfo : PropertyBase
    {

        public string Protocol { get; set; }

        public int? Port { get; set; }

        public int? IntervalInSeconds { get; set; }

        public int? NumberOfProbes { get; set; }

        public string RequestPath { get; set; }
    }

    public class InboundNatRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private InboundNatRulePropertiesInfo _properties;
        public InboundNatRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class InboundNatRulePropertiesInfo : PropertyBase
    {

        private InboundNatRulePropertiesFrontendIPConfigurationInfo _frontendIPConfiguration;
        public InboundNatRulePropertiesFrontendIPConfigurationInfo FrontendIPConfiguration
        {
            get => _frontendIPConfiguration = Get(_frontendIPConfiguration);
            set => _frontendIPConfiguration = value;
        }

        public string Protocol { get; set; }

        public int? FrontendPort { get; set; }

        public int? BackendPort { get; set; }

        public int? IdleTimeoutInMinutes { get; set; }

        public bool? EnableFloatingIP { get; set; }

        public bool? EnableTcpReset { get; set; }
    }

    public class InboundNatRulePropertiesFrontendIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class InboundNatPoolInfo : PropertyBase
    {

        public string Id { get; set; }

        private InboundNatPoolPropertiesInfo _properties;
        public InboundNatPoolPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class InboundNatPoolPropertiesInfo : PropertyBase
    {

        private InboundNatPoolPropertiesFrontendIPConfigurationInfo _frontendIPConfiguration;
        public InboundNatPoolPropertiesFrontendIPConfigurationInfo FrontendIPConfiguration
        {
            get => _frontendIPConfiguration = Get(_frontendIPConfiguration);
            set => _frontendIPConfiguration = value;
        }

        public string Protocol { get; set; }

        public int? FrontendPortRangeStart { get; set; }

        public int? FrontendPortRangeEnd { get; set; }

        public int? BackendPort { get; set; }

        public int? IdleTimeoutInMinutes { get; set; }

        public bool? EnableFloatingIP { get; set; }

        public bool? EnableTcpReset { get; set; }
    }

    public class InboundNatPoolPropertiesFrontendIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class OutboundRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private OutboundRulePropertiesInfo _properties;
        public OutboundRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class OutboundRulePropertiesInfo : PropertyBase
    {

        public int? AllocatedOutboundPorts { get; set; }

        public IList<OutboundRulePropertiesFrontendIPConfigurationInfo> FrontendIPConfigurations { get; set; }

        private OutboundRulePropertiesBackendAddressPoolInfo _backendAddressPool;
        public OutboundRulePropertiesBackendAddressPoolInfo BackendAddressPool
        {
            get => _backendAddressPool = Get(_backendAddressPool);
            set => _backendAddressPool = value;
        }

        public string Protocol { get; set; }

        public bool? EnableTcpReset { get; set; }

        public int? IdleTimeoutInMinutes { get; set; }
    }

    public class OutboundRulePropertiesFrontendIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class OutboundRulePropertiesBackendAddressPoolInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class LocalNetworkGateway : Resource<LocalNetworkGatewayProperties>
    {
        public LocalNetworkGateway() => (Type, ApiVersion) = ("Microsoft.Network/localNetworkGateways", "2020-04-01");
        public LocalNetworkGateway(string name) : this() => Name = name;
        public LocalNetworkGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public LocalNetworkGateway WithProperties(Action<LocalNetworkGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class LocalNetworkGatewayProperties : PropertyBase
    {

        private LocalNetworkAddressSpaceInfo _localNetworkAddressSpace;
        public LocalNetworkAddressSpaceInfo LocalNetworkAddressSpace
        {
            get => _localNetworkAddressSpace = Get(_localNetworkAddressSpace);
            set => _localNetworkAddressSpace = value;
        }

        public string GatewayIpAddress { get; set; }

        public string Fqdn { get; set; }

        private BgpSettingsInfo _bgpSettings;
        public BgpSettingsInfo BgpSettings
        {
            get => _bgpSettings = Get(_bgpSettings);
            set => _bgpSettings = value;
        }
    }

    public class NatGateway : Resource<NatGatewayProperties>
    {
        public NatGateway() => (Type, ApiVersion) = ("Microsoft.Network/natGateways", "2020-04-01");
        public NatGateway(string name) : this() => Name = name;
        public NatGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public NatGateway WithProperties(Action<NatGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NatGatewayProperties : PropertyBase
    {

        public int? IdleTimeoutInMinutes { get; set; }

        public IList<PublicIpAddresseInfo> PublicIpAddresses { get; set; }

        public IList<PublicIpPrefixeInfo> PublicIpPrefixes { get; set; }
    }

    public class PublicIpAddresseInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PublicIpPrefixeInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class NetworkInterfaceTapConfiguration : Resource<NetworkInterfaceTapConfigurationProperties>
    {
        public NetworkInterfaceTapConfiguration() => (Type, ApiVersion) = ("Microsoft.Network/networkInterfaces/tapConfigurations", "2020-04-01");
        public NetworkInterfaceTapConfiguration(string name) : this() => Name = name;
        public NetworkInterfaceTapConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkInterfaceTapConfiguration WithProperties(Action<NetworkInterfaceTapConfigurationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkInterfaceTapConfigurationProperties : PropertyBase
    {

        private VirtualNetworkTapInfo _virtualNetworkTap;
        public VirtualNetworkTapInfo VirtualNetworkTap
        {
            get => _virtualNetworkTap = Get(_virtualNetworkTap);
            set => _virtualNetworkTap = value;
        }
    }

    public class DestinationNetworkInterfaceIPConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesInfo : PropertyBase
    {

        public IList<string> VirtualNetworkTaps { get; set; }

        public IList<ApplicationGatewayBackendAddressPoolInfo> ApplicationGatewayBackendAddressPools { get; set; }

        public IList<LoadBalancerBackendAddressPoolInfo> LoadBalancerBackendAddressPools { get; set; }

        public IList<LoadBalancerInboundNatRuleInfo> LoadBalancerInboundNatRules { get; set; }

        public string PrivateIPAddress { get; set; }

        public string PrivateIPAllocationMethod { get; set; }

        public string PrivateIPAddressVersion { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetInfo _subnet;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        public bool? Primary { get; set; }

        private PublicIPAddressInfo _publicIPAddress;
        public PublicIPAddressInfo PublicIPAddress
        {
            get => _publicIPAddress = Get(_publicIPAddress);
            set => _publicIPAddress = value;
        }

        public IList<ApplicationSecurityGroupInfo> ApplicationSecurityGroups { get; set; }
    }

    public class LoadBalancerBackendAddressPoolPropertiesInfo : PropertyBase
    {

        public IList<LoadBalancerBackendAddresseInfo> LoadBalancerBackendAddresses { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo _networkSecurityGroup;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo _routeTable;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo : PropertyBase
    {

        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo : PropertyBase
    {

        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo : PropertyBase
    {

        public string Id { get; set; }

        private DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo _properties;
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo : PropertyBase
    {

        public string ServiceName { get; set; }
    }

    public class NetworkInterface : Resource<NetworkInterfaceProperties>
    {
        public NetworkInterface() => (Type, ApiVersion) = ("Microsoft.Network/networkInterfaces", "2020-04-01");
        public NetworkInterface(string name) : this() => Name = name;
        public NetworkInterface(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkInterface WithProperties(Action<NetworkInterfaceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkInterfaceProperties : PropertyBase
    {

        private NetworkSecurityGroupInfo _networkSecurityGroup;
        public NetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        public IList<IpConfigurationInfo> IpConfigurations { get; set; }

        private PropertiesDnsSettingsInfo _dnsSettings;
        public PropertiesDnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        public bool? EnableAcceleratedNetworking { get; set; }

        public bool? EnableIPForwarding { get; set; }
    }

    public class SubnetPropertiesNetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private SubnetPropertiesNetworkSecurityGroupPropertiesInfo _properties;
        public SubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class SubnetPropertiesNetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo _properties;
        public SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class IpConfigurationPropertiesSubnetInfo : PropertyBase
    {

        public string Id { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo _networkSecurityGroup;
        public IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private IpConfigurationPropertiesSubnetPropertiesRouteTableInfo _routeTable;
        public IpConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<IpConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesRouteTableInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo : PropertyBase
    {

        public IList<IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo : PropertyBase
    {

        public string Id { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo : PropertyBase
    {

        public IList<IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo : PropertyBase
    {

        public string Id { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesDelegationInfo : PropertyBase
    {

        public string Id { get; set; }

        private IpConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo _properties;
        public IpConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class IpConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo : PropertyBase
    {

        public string ServiceName { get; set; }
    }

    public class IpConfigurationPropertiesPublicIPAddressInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        private IpConfigurationPropertiesPublicIPAddressPropertiesInfo _properties;
        public IpConfigurationPropertiesPublicIPAddressPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public IList<string> Zones { get; set; }
    }

    public class IpConfigurationPropertiesPublicIPAddressPropertiesInfo : PropertyBase
    {

        public string PublicIPAllocationMethod { get; set; }

        public string PublicIPAddressVersion { get; set; }

        private DnsSettingsInfo _dnsSettings;
        public DnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        private IpConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo _ddosSettings;
        public IpConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo DdosSettings
        {
            get => _ddosSettings = Get(_ddosSettings);
            set => _ddosSettings = value;
        }

        public IList<IpTagInfo> IpTags { get; set; }

        public string IpAddress { get; set; }

        private PublicIPPrefixInfo _publicIPPrefix;
        public PublicIPPrefixInfo PublicIPPrefix
        {
            get => _publicIPPrefix = Get(_publicIPPrefix);
            set => _publicIPPrefix = value;
        }

        public int? IdleTimeoutInMinutes { get; set; }
    }

    public class IpConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo : PropertyBase
    {

        private DdosCustomPolicyInfo _ddosCustomPolicy;
        public DdosCustomPolicyInfo DdosCustomPolicy
        {
            get => _ddosCustomPolicy = Get(_ddosCustomPolicy);
            set => _ddosCustomPolicy = value;
        }

        public string ProtectionCoverage { get; set; }

        public bool? ProtectedIP { get; set; }
    }

    public class PropertiesDnsSettingsInfo : PropertyBase
    {

        public IList<string> DnsServers { get; set; }

        public string InternalDnsNameLabel { get; set; }
    }

    public class NetworkProfile : Resource<NetworkProfileProperties>
    {
        public NetworkProfile() => (Type, ApiVersion) = ("Microsoft.Network/networkProfiles", "2020-04-01");
        public NetworkProfile(string name) : this() => Name = name;
        public NetworkProfile(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkProfile WithProperties(Action<NetworkProfileProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkProfileProperties : PropertyBase
    {

        public IList<ContainerNetworkInterfaceConfigurationInfo> ContainerNetworkInterfaceConfigurations { get; set; }
    }

    public class ContainerNetworkInterfaceConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ContainerNetworkInterfaceInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class NetworkSecurityGroupSecurityRule : Resource<NetworkSecurityGroupSecurityRuleProperties>
    {
        public NetworkSecurityGroupSecurityRule() => (Type, ApiVersion) = ("Microsoft.Network/networkSecurityGroups/securityRules", "2020-04-01");
        public NetworkSecurityGroupSecurityRule(string name) : this() => Name = name;
        public NetworkSecurityGroupSecurityRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkSecurityGroupSecurityRule WithProperties(Action<NetworkSecurityGroupSecurityRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkSecurityGroupSecurityRuleProperties : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<SourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<DestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class NetworkSecurityGroup : Resource<NetworkSecurityGroupProperties>
    {
        public NetworkSecurityGroup() => (Type, ApiVersion) = ("Microsoft.Network/networkSecurityGroups", "2020-04-01");
        public NetworkSecurityGroup(string name) : this() => Name = name;
        public NetworkSecurityGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkSecurityGroup WithProperties(Action<NetworkSecurityGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkSecurityGroupProperties : PropertyBase
    {

        public IList<SecurityRuleInfo> SecurityRules { get; set; }
    }

    public class NetworkVirtualAppliance : Resource<NetworkVirtualApplianceProperties>
    {
        public NetworkVirtualAppliance() => (Type, ApiVersion) = ("Microsoft.Network/networkVirtualAppliances", "2020-04-01");
        public NetworkVirtualAppliance(string name) : this() => Name = name;
        public NetworkVirtualAppliance(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public NetworkVirtualAppliance WithProperties(Action<NetworkVirtualApplianceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkVirtualApplianceProperties : PropertyBase
    {

        public IList<string> BootStrapConfigurationBlob { get; set; }

        private VirtualHubInfo _virtualHub;
        public VirtualHubInfo VirtualHub
        {
            get => _virtualHub = Get(_virtualHub);
            set => _virtualHub = value;
        }

        public IList<string> CloudInitConfigurationBlob { get; set; }

        public int? VirtualApplianceAsn { get; set; }
    }

    public class NetworkWatcherConnectionMonitor : Resource<NetworkWatcherConnectionMonitorProperties>
    {
        public NetworkWatcherConnectionMonitor() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers/connectionMonitors", "2020-04-01");
        public NetworkWatcherConnectionMonitor(string name) : this() => Name = name;
        public NetworkWatcherConnectionMonitor(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkWatcherConnectionMonitor WithProperties(Action<NetworkWatcherConnectionMonitorProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkWatcherConnectionMonitorProperties : PropertyBase
    {

        private SourceInfo _source;
        public SourceInfo Source
        {
            get => _source = Get(_source);
            set => _source = value;
        }

        private DestinationInfo _destination;
        public DestinationInfo Destination
        {
            get => _destination = Get(_destination);
            set => _destination = value;
        }

        public bool? AutoStart { get; set; }

        public int? MonitoringIntervalInSeconds { get; set; }

        public IList<EndpointInfo> Endpoints { get; set; }

        public IList<TestConfigurationInfo> TestConfigurations { get; set; }

        public IList<TestGroupInfo> TestGroups { get; set; }

        public IList<OutputInfo> Outputs { get; set; }

        public string Notes { get; set; }
    }

    public class SourceInfo : PropertyBase
    {

        public string ResourceId { get; set; }

        public int? Port { get; set; }
    }

    public class DestinationInfo : PropertyBase
    {

        public string ResourceId { get; set; }

        public string Address { get; set; }

        public int? Port { get; set; }
    }

    public class EndpointInfo : PropertyBase
    {

        public string Name { get; set; }

        public string ResourceId { get; set; }

        public string Address { get; set; }

        private FilterInfo _filter;
        public FilterInfo Filter
        {
            get => _filter = Get(_filter);
            set => _filter = value;
        }
    }

    public class FilterInfo : PropertyBase
    {

        public string Type { get; set; }

        public IList<ItemInfo> Items { get; set; }
    }

    public class ItemInfo : PropertyBase
    {

        public string Type { get; set; }

        public string Address { get; set; }
    }

    public class TestConfigurationInfo : PropertyBase
    {

        public string Name { get; set; }

        public int? TestFrequencySec { get; set; }

        public string Protocol { get; set; }

        public string PreferredIPVersion { get; set; }

        private HttpConfigurationInfo _httpConfiguration;
        public HttpConfigurationInfo HttpConfiguration
        {
            get => _httpConfiguration = Get(_httpConfiguration);
            set => _httpConfiguration = value;
        }

        private TcpConfigurationInfo _tcpConfiguration;
        public TcpConfigurationInfo TcpConfiguration
        {
            get => _tcpConfiguration = Get(_tcpConfiguration);
            set => _tcpConfiguration = value;
        }

        private IcmpConfigurationInfo _icmpConfiguration;
        public IcmpConfigurationInfo IcmpConfiguration
        {
            get => _icmpConfiguration = Get(_icmpConfiguration);
            set => _icmpConfiguration = value;
        }

        private SuccessThresholdInfo _successThreshold;
        public SuccessThresholdInfo SuccessThreshold
        {
            get => _successThreshold = Get(_successThreshold);
            set => _successThreshold = value;
        }
    }

    public class HttpConfigurationInfo : PropertyBase
    {

        public int? Port { get; set; }

        public string Method { get; set; }

        public string Path { get; set; }

        public IList<RequestHeaderInfo> RequestHeaders { get; set; }

        public IList<string> ValidStatusCodeRanges { get; set; }

        public bool? PreferHTTPS { get; set; }
    }

    public class RequestHeaderInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }
    }

    public class TcpConfigurationInfo : PropertyBase
    {

        public int? Port { get; set; }

        public bool? DisableTraceRoute { get; set; }
    }

    public class IcmpConfigurationInfo : PropertyBase
    {

        public bool? DisableTraceRoute { get; set; }
    }

    public class SuccessThresholdInfo : PropertyBase
    {

        public int? ChecksFailedPercent { get; set; }

        public string RoundTripTimeMs { get; set; }
    }

    public class TestGroupInfo : PropertyBase
    {

        public string Name { get; set; }

        public bool? Disable { get; set; }

        public IList<string> TestConfigurations { get; set; }

        public IList<string> Sources { get; set; }

        public IList<string> Destinations { get; set; }
    }

    public class OutputInfo : PropertyBase
    {

        public string Type { get; set; }

        private WorkspaceSettingsInfo _workspaceSettings;
        public WorkspaceSettingsInfo WorkspaceSettings
        {
            get => _workspaceSettings = Get(_workspaceSettings);
            set => _workspaceSettings = value;
        }
    }

    public class WorkspaceSettingsInfo : PropertyBase
    {

        public string WorkspaceResourceId { get; set; }
    }

    public class NetworkWatcherFlowLog : Resource<NetworkWatcherFlowLogProperties>
    {
        public NetworkWatcherFlowLog() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers/flowLogs", "2020-04-01");
        public NetworkWatcherFlowLog(string name) : this() => Name = name;
        public NetworkWatcherFlowLog(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkWatcherFlowLog WithProperties(Action<NetworkWatcherFlowLogProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkWatcherFlowLogProperties : PropertyBase
    {

        public string TargetResourceId { get; set; }

        public string StorageId { get; set; }

        public bool? Enabled { get; set; }

        private RetentionPolicyInfo _retentionPolicy;
        public RetentionPolicyInfo RetentionPolicy
        {
            get => _retentionPolicy = Get(_retentionPolicy);
            set => _retentionPolicy = value;
        }

        private FormatInfo _format;
        public FormatInfo Format
        {
            get => _format = Get(_format);
            set => _format = value;
        }

        private FlowAnalyticsConfigurationInfo _flowAnalyticsConfiguration;
        public FlowAnalyticsConfigurationInfo FlowAnalyticsConfiguration
        {
            get => _flowAnalyticsConfiguration = Get(_flowAnalyticsConfiguration);
            set => _flowAnalyticsConfiguration = value;
        }
    }

    public class RetentionPolicyInfo : PropertyBase
    {

        public int? Days { get; set; }

        public bool? Enabled { get; set; }
    }

    public class FormatInfo : PropertyBase
    {

        public string Type { get; set; }

        public int? Version { get; set; }
    }

    public class FlowAnalyticsConfigurationInfo : PropertyBase
    {

        private NetworkWatcherFlowAnalyticsConfigurationInfo _networkWatcherFlowAnalyticsConfiguration;
        public NetworkWatcherFlowAnalyticsConfigurationInfo NetworkWatcherFlowAnalyticsConfiguration
        {
            get => _networkWatcherFlowAnalyticsConfiguration = Get(_networkWatcherFlowAnalyticsConfiguration);
            set => _networkWatcherFlowAnalyticsConfiguration = value;
        }
    }

    public class NetworkWatcherFlowAnalyticsConfigurationInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public string WorkspaceId { get; set; }

        public string WorkspaceRegion { get; set; }

        public string WorkspaceResourceId { get; set; }

        public int? TrafficAnalyticsInterval { get; set; }
    }

    public class NetworkWatcherPacketCapture : Resource<NetworkWatcherPacketCaptureProperties>
    {
        public NetworkWatcherPacketCapture() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers/packetCaptures", "2020-04-01");
        public NetworkWatcherPacketCapture(string name) : this() => Name = name;
        public NetworkWatcherPacketCapture(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkWatcherPacketCapture WithProperties(Action<NetworkWatcherPacketCaptureProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkWatcherPacketCaptureProperties : PropertyBase
    {

        public string Target { get; set; }

        public int? BytesToCapturePerPacket { get; set; }

        public int? TotalBytesPerSession { get; set; }

        public int? TimeLimitInSeconds { get; set; }

        private StorageLocationInfo _storageLocation;
        public StorageLocationInfo StorageLocation
        {
            get => _storageLocation = Get(_storageLocation);
            set => _storageLocation = value;
        }

        public IList<FilterInfo> Filters { get; set; }
    }

    public class StorageLocationInfo : PropertyBase
    {

        public string StorageId { get; set; }

        public string StoragePath { get; set; }

        public string FilePath { get; set; }
    }

    public class NetworkWatcher : Resource<NetworkWatcherProperties>
    {
        public NetworkWatcher() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers", "2020-04-01");
        public NetworkWatcher(string name) : this() => Name = name;
        public NetworkWatcher(string name, Location location) : this() => (Name, Location) = (name, location);

        public NetworkWatcher WithProperties(Action<NetworkWatcherProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NetworkWatcherProperties : PropertyBase
    {
    }

    public class P2svpnGateway : Resource<P2svpnGatewayProperties>
    {
        public P2svpnGateway() => (Type, ApiVersion) = ("Microsoft.Network/p2svpnGateways", "2020-04-01");
        public P2svpnGateway(string name) : this() => Name = name;
        public P2svpnGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public P2svpnGateway WithProperties(Action<P2svpnGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class P2svpnGatewayProperties : PropertyBase
    {

        private VirtualHubInfo _virtualHub;
        public VirtualHubInfo VirtualHub
        {
            get => _virtualHub = Get(_virtualHub);
            set => _virtualHub = value;
        }

        public IList<P2SConnectionConfigurationInfo> P2SConnectionConfigurations { get; set; }

        public int? VpnGatewayScaleUnit { get; set; }

        private VpnServerConfigurationInfo _vpnServerConfiguration;
        public VpnServerConfigurationInfo VpnServerConfiguration
        {
            get => _vpnServerConfiguration = Get(_vpnServerConfiguration);
            set => _vpnServerConfiguration = value;
        }

        public IList<string> CustomDnsServers { get; set; }
    }

    public class P2SConnectionConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VpnServerConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PrivateEndpointPrivateDnsZoneGroup : Resource<PrivateEndpointPrivateDnsZoneGroupProperties>
    {
        public PrivateEndpointPrivateDnsZoneGroup() => (Type, ApiVersion) = ("Microsoft.Network/privateEndpoints/privateDnsZoneGroups", "2020-04-01");
        public PrivateEndpointPrivateDnsZoneGroup(string name) : this() => Name = name;
        public PrivateEndpointPrivateDnsZoneGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public PrivateEndpointPrivateDnsZoneGroup WithProperties(Action<PrivateEndpointPrivateDnsZoneGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PrivateEndpointPrivateDnsZoneGroupProperties : PropertyBase
    {

        public IList<PrivateDnsZoneConfigInfo> PrivateDnsZoneConfigs { get; set; }
    }

    public class PrivateDnsZoneConfigInfo : PropertyBase
    {

        public string Name { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class PrivateEndpoint : Resource<PrivateEndpointProperties>
    {
        public PrivateEndpoint() => (Type, ApiVersion) = ("Microsoft.Network/privateEndpoints", "2020-04-01");
        public PrivateEndpoint(string name) : this() => Name = name;
        public PrivateEndpoint(string name, Location location) : this() => (Name, Location) = (name, location);

        public PrivateEndpoint WithProperties(Action<PrivateEndpointProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PrivateEndpointProperties : PropertyBase
    {

        private SubnetInfo _subnet;
        public SubnetInfo Subnet
        {
            get => _subnet = Get(_subnet);
            set => _subnet = value;
        }

        public IList<PrivateLinkServiceConnectionInfo> PrivateLinkServiceConnections { get; set; }

        public IList<ManualPrivateLinkServiceConnectionInfo> ManualPrivateLinkServiceConnections { get; set; }

        public IList<CustomDnsConfigInfo> CustomDnsConfigs { get; set; }
    }

    public class PrivateLinkServiceConnectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PrivateLinkServiceConnectionStateInfo : PropertyBase
    {

        public string Status { get; set; }

        public string Description { get; set; }

        public string ActionsRequired { get; set; }
    }

    public class ManualPrivateLinkServiceConnectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private ManualPrivateLinkServiceConnectionPropertiesInfo _properties;
        public ManualPrivateLinkServiceConnectionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class ManualPrivateLinkServiceConnectionPropertiesInfo : PropertyBase
    {

        public string PrivateLinkServiceId { get; set; }

        public IList<string> GroupIds { get; set; }

        public string RequestMessage { get; set; }

        private PrivateLinkServiceConnectionStateInfo _privateLinkServiceConnectionState;
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState
        {
            get => _privateLinkServiceConnectionState = Get(_privateLinkServiceConnectionState);
            set => _privateLinkServiceConnectionState = value;
        }
    }

    public class CustomDnsConfigInfo : PropertyBase
    {

        public string Fqdn { get; set; }

        public IList<string> IpAddresses { get; set; }
    }

    public class PrivateLinkServicePrivateEndpointConnection : Resource<PrivateLinkServicePrivateEndpointConnectionProperties>
    {
        public PrivateLinkServicePrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.Network/privateLinkServices/privateEndpointConnections", "2020-04-01");
        public PrivateLinkServicePrivateEndpointConnection(string name) : this() => Name = name;
        public PrivateLinkServicePrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public PrivateLinkServicePrivateEndpointConnection WithProperties(Action<PrivateLinkServicePrivateEndpointConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PrivateLinkServicePrivateEndpointConnectionProperties : PropertyBase
    {

        private PrivateLinkServiceConnectionStateInfo _privateLinkServiceConnectionState;
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState
        {
            get => _privateLinkServiceConnectionState = Get(_privateLinkServiceConnectionState);
            set => _privateLinkServiceConnectionState = value;
        }
    }

    public class PrivateLinkService : Resource<PrivateLinkServiceProperties>
    {
        public PrivateLinkService() => (Type, ApiVersion) = ("Microsoft.Network/privateLinkServices", "2020-04-01");
        public PrivateLinkService(string name) : this() => Name = name;
        public PrivateLinkService(string name, Location location) : this() => (Name, Location) = (name, location);

        public PrivateLinkService WithProperties(Action<PrivateLinkServiceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PrivateLinkServiceProperties : PropertyBase
    {

        public IList<LoadBalancerFrontendIpConfigurationInfo> LoadBalancerFrontendIpConfigurations { get; set; }

        public IList<IpConfigurationInfo> IpConfigurations { get; set; }

        private VisibilityInfo _visibility;
        public VisibilityInfo Visibility
        {
            get => _visibility = Get(_visibility);
            set => _visibility = value;
        }

        private AutoApprovalInfo _autoApproval;
        public AutoApprovalInfo AutoApproval
        {
            get => _autoApproval = Get(_autoApproval);
            set => _autoApproval = value;
        }

        public IList<string> Fqdns { get; set; }

        public bool? EnableProxyProtocol { get; set; }
    }

    public class LoadBalancerFrontendIpConfigurationInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }

        public IList<string> Zones { get; set; }
    }

    public class VisibilityInfo : PropertyBase
    {

        public IList<string> Subscriptions { get; set; }
    }

    public class AutoApprovalInfo : PropertyBase
    {

        public IList<string> Subscriptions { get; set; }
    }

    public class PublicIPAddresse : Resource<PublicIPAddresseProperties>
    {
        public PublicIPAddresse() => (Type, ApiVersion) = ("Microsoft.Network/publicIPAddresses", "2020-04-01");
        public PublicIPAddresse(string name) : this() => Name = name;
        public PublicIPAddresse(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public PublicIPAddresse WithProperties(Action<PublicIPAddresseProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PublicIPAddresseProperties : PropertyBase
    {

        public string PublicIPAllocationMethod { get; set; }

        public string PublicIPAddressVersion { get; set; }

        private DnsSettingsInfo _dnsSettings;
        public DnsSettingsInfo DnsSettings
        {
            get => _dnsSettings = Get(_dnsSettings);
            set => _dnsSettings = value;
        }

        private DdosSettingsInfo _ddosSettings;
        public DdosSettingsInfo DdosSettings
        {
            get => _ddosSettings = Get(_ddosSettings);
            set => _ddosSettings = value;
        }

        public IList<IpTagInfo> IpTags { get; set; }

        public string IpAddress { get; set; }

        private PublicIPPrefixInfo _publicIPPrefix;
        public PublicIPPrefixInfo PublicIPPrefix
        {
            get => _publicIPPrefix = Get(_publicIPPrefix);
            set => _publicIPPrefix = value;
        }

        public int? IdleTimeoutInMinutes { get; set; }
    }

    public class PublicIPPrefixe : Resource<PublicIPPrefixeProperties>
    {
        public PublicIPPrefixe() => (Type, ApiVersion) = ("Microsoft.Network/publicIPPrefixes", "2020-04-01");
        public PublicIPPrefixe(string name) : this() => Name = name;
        public PublicIPPrefixe(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public PublicIPPrefixe WithProperties(Action<PublicIPPrefixeProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PublicIPPrefixeProperties : PropertyBase
    {

        public string PublicIPAddressVersion { get; set; }

        public IList<IpTagInfo> IpTags { get; set; }

        public int? PrefixLength { get; set; }
    }

    public class RouteFilterRouteFilterRule : Resource<RouteFilterRouteFilterRuleProperties>
    {
        public RouteFilterRouteFilterRule() => (Type, ApiVersion) = ("Microsoft.Network/routeFilters/routeFilterRules", "2020-04-01");
        public RouteFilterRouteFilterRule(string name) : this() => Name = name;
        public RouteFilterRouteFilterRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public RouteFilterRouteFilterRule WithProperties(Action<RouteFilterRouteFilterRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RouteFilterRouteFilterRuleProperties : PropertyBase
    {

        public string Access { get; set; }

        public string RouteFilterRuleType { get; set; }

        public IList<string> Communities { get; set; }
    }

    public class RouteFilter : Resource<RouteFilterProperties>
    {
        public RouteFilter() => (Type, ApiVersion) = ("Microsoft.Network/routeFilters", "2020-04-01");
        public RouteFilter(string name) : this() => Name = name;
        public RouteFilter(string name, Location location) : this() => (Name, Location) = (name, location);

        public RouteFilter WithProperties(Action<RouteFilterProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RouteFilterProperties : PropertyBase
    {

        public IList<RuleInfo> Rules { get; set; }
    }

    public class RouteTableRoute : Resource<RouteTableRouteProperties>
    {
        public RouteTableRoute() => (Type, ApiVersion) = ("Microsoft.Network/routeTables/routes", "2020-04-01");
        public RouteTableRoute(string name) : this() => Name = name;
        public RouteTableRoute(string name, Location location) : this() => (Name, Location) = (name, location);

        public RouteTableRoute WithProperties(Action<RouteTableRouteProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RouteTableRouteProperties : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class RouteTable : Resource<RouteTableProperties>
    {
        public RouteTable() => (Type, ApiVersion) = ("Microsoft.Network/routeTables", "2020-04-01");
        public RouteTable(string name) : this() => Name = name;
        public RouteTable(string name, Location location) : this() => (Name, Location) = (name, location);

        public RouteTable WithProperties(Action<RouteTableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RouteTableProperties : PropertyBase
    {

        public IList<RouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class SecurityPartnerProvider : Resource<SecurityPartnerProviderProperties>
    {
        public SecurityPartnerProvider() => (Type, ApiVersion) = ("Microsoft.Network/securityPartnerProviders", "2020-04-01");
        public SecurityPartnerProvider(string name) : this() => Name = name;
        public SecurityPartnerProvider(string name, Location location) : this() => (Name, Location) = (name, location);

        public SecurityPartnerProvider WithProperties(Action<SecurityPartnerProviderProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class SecurityPartnerProviderProperties : PropertyBase
    {

        public string SecurityProviderName { get; set; }

        private VirtualHubInfo _virtualHub;
        public VirtualHubInfo VirtualHub
        {
            get => _virtualHub = Get(_virtualHub);
            set => _virtualHub = value;
        }
    }

    public class ServiceEndpointPolicyServiceEndpointPolicyDefinition : Resource<ServiceEndpointPolicyServiceEndpointPolicyDefinitionProperties>
    {
        public ServiceEndpointPolicyServiceEndpointPolicyDefinition() => (Type, ApiVersion) = ("Microsoft.Network/serviceEndpointPolicies/serviceEndpointPolicyDefinitions", "2020-04-01");
        public ServiceEndpointPolicyServiceEndpointPolicyDefinition(string name) : this() => Name = name;
        public ServiceEndpointPolicyServiceEndpointPolicyDefinition(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServiceEndpointPolicyServiceEndpointPolicyDefinition WithProperties(Action<ServiceEndpointPolicyServiceEndpointPolicyDefinitionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServiceEndpointPolicyServiceEndpointPolicyDefinitionProperties : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class ServiceEndpointPolicy : Resource<ServiceEndpointPolicyProperties>
    {
        public ServiceEndpointPolicy() => (Type, ApiVersion) = ("Microsoft.Network/serviceEndpointPolicies", "2020-04-01");
        public ServiceEndpointPolicy(string name) : this() => Name = name;
        public ServiceEndpointPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public ServiceEndpointPolicy WithProperties(Action<ServiceEndpointPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServiceEndpointPolicyProperties : PropertyBase
    {

        public IList<ServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class VirtualHubHubRouteTable : Resource<VirtualHubHubRouteTableProperties>
    {
        public VirtualHubHubRouteTable() => (Type, ApiVersion) = ("Microsoft.Network/virtualHubs/hubRouteTables", "2020-04-01");
        public VirtualHubHubRouteTable(string name) : this() => Name = name;
        public VirtualHubHubRouteTable(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualHubHubRouteTable WithProperties(Action<VirtualHubHubRouteTableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualHubHubRouteTableProperties : PropertyBase
    {

        public IList<RouteInfo> Routes { get; set; }

        public IList<string> Labels { get; set; }
    }

    public class VirtualHubRouteTable : Resource<VirtualHubRouteTableProperties>
    {
        public VirtualHubRouteTable() => (Type, ApiVersion) = ("Microsoft.Network/virtualHubs/routeTables", "2020-04-01");
        public VirtualHubRouteTable(string name) : this() => Name = name;
        public VirtualHubRouteTable(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualHubRouteTable WithProperties(Action<VirtualHubRouteTableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualHubRouteTableProperties : PropertyBase
    {

        public IList<RouteInfo> Routes { get; set; }

        public IList<string> AttachedConnections { get; set; }
    }

    public class VirtualHub : Resource<VirtualHubProperties>
    {
        public VirtualHub() => (Type, ApiVersion) = ("Microsoft.Network/virtualHubs", "2020-04-01");
        public VirtualHub(string name) : this() => Name = name;
        public VirtualHub(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualHub WithProperties(Action<VirtualHubProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualHubProperties : PropertyBase
    {

        private VirtualWanInfo _virtualWan;
        public VirtualWanInfo VirtualWan
        {
            get => _virtualWan = Get(_virtualWan);
            set => _virtualWan = value;
        }

        private VpnGatewayInfo _vpnGateway;
        public VpnGatewayInfo VpnGateway
        {
            get => _vpnGateway = Get(_vpnGateway);
            set => _vpnGateway = value;
        }

        private P2SVpnGatewayInfo _p2SVpnGateway;
        public P2SVpnGatewayInfo P2SVpnGateway
        {
            get => _p2SVpnGateway = Get(_p2SVpnGateway);
            set => _p2SVpnGateway = value;
        }

        private ExpressRouteGatewayInfo _expressRouteGateway;
        public ExpressRouteGatewayInfo ExpressRouteGateway
        {
            get => _expressRouteGateway = Get(_expressRouteGateway);
            set => _expressRouteGateway = value;
        }

        private AzureFirewallInfo _azureFirewall;
        public AzureFirewallInfo AzureFirewall
        {
            get => _azureFirewall = Get(_azureFirewall);
            set => _azureFirewall = value;
        }

        private SecurityPartnerProviderInfo _securityPartnerProvider;
        public SecurityPartnerProviderInfo SecurityPartnerProvider
        {
            get => _securityPartnerProvider = Get(_securityPartnerProvider);
            set => _securityPartnerProvider = value;
        }

        public IList<VirtualNetworkConnectionInfo> VirtualNetworkConnections { get; set; }

        public string AddressPrefix { get; set; }

        private RouteTableInfo _routeTable;
        public RouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        public string SecurityProviderName { get; set; }

        public IList<VirtualHubRouteTableV2Info> VirtualHubRouteTableV2s { get; set; }

        public string Sku { get; set; }
    }

    public class VirtualWanInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VpnGatewayInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class P2SVpnGatewayInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class ExpressRouteGatewayInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class AzureFirewallInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class SecurityPartnerProviderInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VirtualNetworkConnectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualHubRouteTableV2Info : PropertyBase
    {

        public string Id { get; set; }

        private VirtualHubRouteTableV2PropertiesInfo _properties;
        public VirtualHubRouteTableV2PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VirtualHubRouteTableV2PropertiesInfo : PropertyBase
    {

        public IList<VirtualHubRouteTableV2PropertiesRouteInfo> Routes { get; set; }

        public IList<string> AttachedConnections { get; set; }
    }

    public class VirtualHubRouteTableV2PropertiesRouteInfo : PropertyBase
    {

        public string DestinationType { get; set; }

        public IList<string> Destinations { get; set; }

        public string NextHopType { get; set; }

        public IList<string> NextHops { get; set; }
    }

    public class VirtualNetworkGateway : Resource<VirtualNetworkGatewayProperties>
    {
        public VirtualNetworkGateway() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworkGateways", "2020-04-01");
        public VirtualNetworkGateway(string name) : this() => Name = name;
        public VirtualNetworkGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualNetworkGateway WithProperties(Action<VirtualNetworkGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualNetworkGatewayProperties : PropertyBase
    {

        public IList<IpConfigurationInfo> IpConfigurations { get; set; }

        public string GatewayType { get; set; }

        public string VpnType { get; set; }

        public string VpnGatewayGeneration { get; set; }

        public bool? EnableBgp { get; set; }

        public bool? EnablePrivateIpAddress { get; set; }

        public bool? ActiveActive { get; set; }

        private GatewayDefaultSiteInfo _gatewayDefaultSite;
        public GatewayDefaultSiteInfo GatewayDefaultSite
        {
            get => _gatewayDefaultSite = Get(_gatewayDefaultSite);
            set => _gatewayDefaultSite = value;
        }

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        private VpnClientConfigurationInfo _vpnClientConfiguration;
        public VpnClientConfigurationInfo VpnClientConfiguration
        {
            get => _vpnClientConfiguration = Get(_vpnClientConfiguration);
            set => _vpnClientConfiguration = value;
        }

        private BgpSettingsInfo _bgpSettings;
        public BgpSettingsInfo BgpSettings
        {
            get => _bgpSettings = Get(_bgpSettings);
            set => _bgpSettings = value;
        }

        private CustomRoutesInfo _customRoutes;
        public CustomRoutesInfo CustomRoutes
        {
            get => _customRoutes = Get(_customRoutes);
            set => _customRoutes = value;
        }

        public bool? EnableDnsForwarding { get; set; }
    }

    public class VirtualNetworkSubnet : Resource<VirtualNetworkSubnetProperties>
    {
        public VirtualNetworkSubnet() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworks/subnets", "2020-04-01");
        public VirtualNetworkSubnet(string name) : this() => Name = name;
        public VirtualNetworkSubnet(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualNetworkSubnet WithProperties(Action<VirtualNetworkSubnetProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualNetworkSubnetProperties : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private NetworkSecurityGroupInfo _networkSecurityGroup;
        public NetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private RouteTableInfo _routeTable;
        public RouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<ServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<DelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class VirtualNetworkVirtualNetworkPeering : Resource<VirtualNetworkVirtualNetworkPeeringProperties>
    {
        public VirtualNetworkVirtualNetworkPeering() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworks/virtualNetworkPeerings", "2020-04-01");
        public VirtualNetworkVirtualNetworkPeering(string name) : this() => Name = name;
        public VirtualNetworkVirtualNetworkPeering(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualNetworkVirtualNetworkPeering WithProperties(Action<VirtualNetworkVirtualNetworkPeeringProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualNetworkVirtualNetworkPeeringProperties : PropertyBase
    {

        public bool? AllowVirtualNetworkAccess { get; set; }

        public bool? AllowForwardedTraffic { get; set; }

        public bool? AllowGatewayTransit { get; set; }

        public bool? UseRemoteGateways { get; set; }

        private RemoteVirtualNetworkInfo _remoteVirtualNetwork;
        public RemoteVirtualNetworkInfo RemoteVirtualNetwork
        {
            get => _remoteVirtualNetwork = Get(_remoteVirtualNetwork);
            set => _remoteVirtualNetwork = value;
        }

        private RemoteAddressSpaceInfo _remoteAddressSpace;
        public RemoteAddressSpaceInfo RemoteAddressSpace
        {
            get => _remoteAddressSpace = Get(_remoteAddressSpace);
            set => _remoteAddressSpace = value;
        }

        public string PeeringState { get; set; }
    }

    public class VirtualNetwork : Resource<VirtualNetworkProperties>
    {
        public VirtualNetwork() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworks", "2020-04-01");
        public VirtualNetwork(string name) : this() => Name = name;
        public VirtualNetwork(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualNetwork WithProperties(Action<VirtualNetworkProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualNetworkProperties : PropertyBase
    {

        private AddressSpaceInfo _addressSpace;
        public AddressSpaceInfo AddressSpace
        {
            get => _addressSpace = Get(_addressSpace);
            set => _addressSpace = value;
        }

        private DhcpOptionsInfo _dhcpOptions;
        public DhcpOptionsInfo DhcpOptions
        {
            get => _dhcpOptions = Get(_dhcpOptions);
            set => _dhcpOptions = value;
        }

        public IList<SubnetInfo> Subnets { get; set; }

        public IList<VirtualNetworkPeeringInfo> VirtualNetworkPeerings { get; set; }

        public bool? EnableDdosProtection { get; set; }

        public bool? EnableVmProtection { get; set; }

        private DdosProtectionPlanInfo _ddosProtectionPlan;
        public DdosProtectionPlanInfo DdosProtectionPlan
        {
            get => _ddosProtectionPlan = Get(_ddosProtectionPlan);
            set => _ddosProtectionPlan = value;
        }

        private BgpCommunitiesInfo _bgpCommunities;
        public BgpCommunitiesInfo BgpCommunities
        {
            get => _bgpCommunities = Get(_bgpCommunities);
            set => _bgpCommunities = value;
        }

        public IList<IpAllocationInfo> IpAllocations { get; set; }
    }

    public class VirtualNetworkTap : Resource<VirtualNetworkTapProperties>
    {
        public VirtualNetworkTap() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworkTaps", "2020-04-01");
        public VirtualNetworkTap(string name) : this() => Name = name;
        public VirtualNetworkTap(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualNetworkTap WithProperties(Action<VirtualNetworkTapProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualNetworkTapProperties : PropertyBase
    {

        private DestinationNetworkInterfaceIPConfigurationInfo _destinationNetworkInterfaceIPConfiguration;
        public DestinationNetworkInterfaceIPConfigurationInfo DestinationNetworkInterfaceIPConfiguration
        {
            get => _destinationNetworkInterfaceIPConfiguration = Get(_destinationNetworkInterfaceIPConfiguration);
            set => _destinationNetworkInterfaceIPConfiguration = value;
        }

        private DestinationLoadBalancerFrontEndIPConfigurationInfo _destinationLoadBalancerFrontEndIPConfiguration;
        public DestinationLoadBalancerFrontEndIPConfigurationInfo DestinationLoadBalancerFrontEndIPConfiguration
        {
            get => _destinationLoadBalancerFrontEndIPConfiguration = Get(_destinationLoadBalancerFrontEndIPConfiguration);
            set => _destinationLoadBalancerFrontEndIPConfiguration = value;
        }

        public int? DestinationPort { get; set; }
    }

    public class PropertiesSubnetInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesSubnetPropertiesInfo _properties;
        public PropertiesSubnetPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesSubnetPropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public IList<string> AddressPrefixes { get; set; }

        private PropertiesSubnetPropertiesNetworkSecurityGroupInfo _networkSecurityGroup;
        public PropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup
        {
            get => _networkSecurityGroup = Get(_networkSecurityGroup);
            set => _networkSecurityGroup = value;
        }

        private PropertiesSubnetPropertiesRouteTableInfo _routeTable;
        public PropertiesSubnetPropertiesRouteTableInfo RouteTable
        {
            get => _routeTable = Get(_routeTable);
            set => _routeTable = value;
        }

        private NatGatewayInfo _natGateway;
        public NatGatewayInfo NatGateway
        {
            get => _natGateway = Get(_natGateway);
            set => _natGateway = value;
        }

        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }

        public IList<PropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }

        public IList<IpAllocationInfo> IpAllocations { get; set; }

        public IList<PropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }

        public string PrivateEndpointNetworkPolicies { get; set; }

        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public class PropertiesSubnetPropertiesNetworkSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo _properties;
        public PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo : PropertyBase
    {

        public IList<PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo _properties;
        public PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Protocol { get; set; }

        public string SourcePortRange { get; set; }

        public string DestinationPortRange { get; set; }

        public string SourceAddressPrefix { get; set; }

        public IList<string> SourceAddressPrefixes { get; set; }

        public IList<PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo> SourceApplicationSecurityGroups { get; set; }

        public string DestinationAddressPrefix { get; set; }

        public IList<string> DestinationAddressPrefixes { get; set; }

        public IList<PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo> DestinationApplicationSecurityGroups { get; set; }

        public IList<string> SourcePortRanges { get; set; }

        public IList<string> DestinationPortRanges { get; set; }

        public string Access { get; set; }

        public int? Priority { get; set; }

        public string Direction { get; set; }
    }

    public class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        public object Properties { get; set; }
    }

    public class PropertiesSubnetPropertiesRouteTableInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private PropertiesSubnetPropertiesRouteTablePropertiesInfo _properties;
        public PropertiesSubnetPropertiesRouteTablePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class PropertiesSubnetPropertiesRouteTablePropertiesInfo : PropertyBase
    {

        public IList<PropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }

        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public class PropertiesSubnetPropertiesRouteTablePropertiesRouteInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo _properties;
        public PropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo : PropertyBase
    {

        public string AddressPrefix { get; set; }

        public string NextHopType { get; set; }

        public string NextHopIpAddress { get; set; }
    }

    public class PropertiesSubnetPropertiesServiceEndpointPolicyInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Location { get; set; }

        public object Tags { get; set; }

        private PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo _properties;
        public PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }
    }

    public class PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo : PropertyBase
    {

        public IList<PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public class PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo _properties;
        public PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo : PropertyBase
    {

        public string Description { get; set; }

        public string Service { get; set; }

        public IList<string> ServiceResources { get; set; }
    }

    public class PropertiesSubnetPropertiesDelegationInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesSubnetPropertiesDelegationPropertiesInfo _properties;
        public PropertiesSubnetPropertiesDelegationPropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class PropertiesSubnetPropertiesDelegationPropertiesInfo : PropertyBase
    {

        public string ServiceName { get; set; }
    }

    public class VirtualRouterPeering : Resource<VirtualRouterPeeringProperties>
    {
        public VirtualRouterPeering() => (Type, ApiVersion) = ("Microsoft.Network/virtualRouters/peerings", "2020-04-01");
        public VirtualRouterPeering(string name) : this() => Name = name;
        public VirtualRouterPeering(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualRouterPeering WithProperties(Action<VirtualRouterPeeringProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualRouterPeeringProperties : PropertyBase
    {

        public int? PeerAsn { get; set; }

        public string PeerIp { get; set; }
    }

    public class VirtualRouter : Resource<VirtualRouterProperties>
    {
        public VirtualRouter() => (Type, ApiVersion) = ("Microsoft.Network/virtualRouters", "2020-04-01");
        public VirtualRouter(string name) : this() => Name = name;
        public VirtualRouter(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualRouter WithProperties(Action<VirtualRouterProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualRouterProperties : PropertyBase
    {

        public int? VirtualRouterAsn { get; set; }

        public IList<string> VirtualRouterIps { get; set; }

        private HostedSubnetInfo _hostedSubnet;
        public HostedSubnetInfo HostedSubnet
        {
            get => _hostedSubnet = Get(_hostedSubnet);
            set => _hostedSubnet = value;
        }

        private HostedGatewayInfo _hostedGateway;
        public HostedGatewayInfo HostedGateway
        {
            get => _hostedGateway = Get(_hostedGateway);
            set => _hostedGateway = value;
        }
    }

    public class HostedSubnetInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class HostedGatewayInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VirtualWanP2sVpnServerConfiguration : Resource<VirtualWanP2sVpnServerConfigurationProperties>
    {
        public VirtualWanP2sVpnServerConfiguration() => (Type, ApiVersion) = ("Microsoft.Network/virtualWans/p2sVpnServerConfigurations", "2019-07-01");
        public VirtualWanP2sVpnServerConfiguration(string name) : this() => Name = name;
        public VirtualWanP2sVpnServerConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualWanP2sVpnServerConfiguration WithProperties(Action<VirtualWanP2sVpnServerConfigurationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualWanP2sVpnServerConfigurationProperties : PropertyBase
    {

        public string Name { get; set; }

        public IList<string> VpnProtocols { get; set; }

        public IList<P2SVpnServerConfigVpnClientRootCertificateInfo> P2SVpnServerConfigVpnClientRootCertificates { get; set; }

        public IList<P2SVpnServerConfigVpnClientRevokedCertificateInfo> P2SVpnServerConfigVpnClientRevokedCertificates { get; set; }

        public IList<P2SVpnServerConfigRadiusServerRootCertificateInfo> P2SVpnServerConfigRadiusServerRootCertificates { get; set; }

        public IList<P2SVpnServerConfigRadiusClientRootCertificateInfo> P2SVpnServerConfigRadiusClientRootCertificates { get; set; }

        public IList<VpnClientIpsecPolicyInfo> VpnClientIpsecPolicies { get; set; }

        public string RadiusServerAddress { get; set; }

        public string RadiusServerSecret { get; set; }
    }

    public class P2SVpnServerConfigVpnClientRootCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class P2SVpnServerConfigVpnClientRevokedCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private P2SVpnServerConfigVpnClientRevokedCertificatePropertiesInfo _properties;
        public P2SVpnServerConfigVpnClientRevokedCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class P2SVpnServerConfigVpnClientRevokedCertificatePropertiesInfo : PropertyBase
    {

        public string Thumbprint { get; set; }
    }

    public class P2SVpnServerConfigRadiusServerRootCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class P2SVpnServerConfigRadiusClientRootCertificateInfo : PropertyBase
    {

        public string Id { get; set; }

        private P2SVpnServerConfigRadiusClientRootCertificatePropertiesInfo _properties;
        public P2SVpnServerConfigRadiusClientRootCertificatePropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class P2SVpnServerConfigRadiusClientRootCertificatePropertiesInfo : PropertyBase
    {

        public string Thumbprint { get; set; }
    }

    public class VirtualWan : Resource<VirtualWanProperties>
    {
        public VirtualWan() => (Type, ApiVersion) = ("Microsoft.Network/virtualWans", "2020-04-01");
        public VirtualWan(string name) : this() => Name = name;
        public VirtualWan(string name, Location location) : this() => (Name, Location) = (name, location);

        public VirtualWan WithProperties(Action<VirtualWanProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VirtualWanProperties : PropertyBase
    {

        public bool? DisableVpnEncryption { get; set; }

        public bool? AllowBranchToBranchTraffic { get; set; }

        public bool? AllowVnetToVnetTraffic { get; set; }

        public string Office365LocalBreakoutCategory { get; set; }

        public string Type { get; set; }
    }

    public class VpnGatewayVpnConnection : Resource<VpnGatewayVpnConnectionProperties>
    {
        public VpnGatewayVpnConnection() => (Type, ApiVersion) = ("Microsoft.Network/vpnGateways/vpnConnections", "2020-04-01");
        public VpnGatewayVpnConnection(string name) : this() => Name = name;
        public VpnGatewayVpnConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public VpnGatewayVpnConnection WithProperties(Action<VpnGatewayVpnConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VpnGatewayVpnConnectionProperties : PropertyBase
    {

        private RemoteVpnSiteInfo _remoteVpnSite;
        public RemoteVpnSiteInfo RemoteVpnSite
        {
            get => _remoteVpnSite = Get(_remoteVpnSite);
            set => _remoteVpnSite = value;
        }

        public int? RoutingWeight { get; set; }

        public int? DpdTimeoutSeconds { get; set; }

        public string ConnectionStatus { get; set; }

        public string VpnConnectionProtocolType { get; set; }

        public int? ConnectionBandwidth { get; set; }

        public string SharedKey { get; set; }

        public bool? EnableBgp { get; set; }

        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        public IList<IpsecPolicyInfo> IpsecPolicies { get; set; }

        public bool? EnableRateLimiting { get; set; }

        public bool? EnableInternetSecurity { get; set; }

        public bool? UseLocalAzureIpAddress { get; set; }

        public IList<VpnLinkConnectionInfo> VpnLinkConnections { get; set; }

        private RoutingConfigurationInfo _routingConfiguration;
        public RoutingConfigurationInfo RoutingConfiguration
        {
            get => _routingConfiguration = Get(_routingConfiguration);
            set => _routingConfiguration = value;
        }
    }

    public class RemoteVpnSiteInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VpnLinkConnectionInfo : PropertyBase
    {

        public string Id { get; set; }

        private PropertiesInfo _properties;
        public PropertiesInfo Properties
        {
            get => _properties = Get(_properties);
            set => _properties = value;
        }

        public string Name { get; set; }
    }

    public class VpnSiteLinkInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class VpnGateway : Resource<VpnGatewayProperties>
    {
        public VpnGateway() => (Type, ApiVersion) = ("Microsoft.Network/vpnGateways", "2020-04-01");
        public VpnGateway(string name) : this() => Name = name;
        public VpnGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public VpnGateway WithProperties(Action<VpnGatewayProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VpnGatewayProperties : PropertyBase
    {

        private VirtualHubInfo _virtualHub;
        public VirtualHubInfo VirtualHub
        {
            get => _virtualHub = Get(_virtualHub);
            set => _virtualHub = value;
        }

        public IList<ConnectionInfo> Connections { get; set; }

        private BgpSettingsInfo _bgpSettings;
        public BgpSettingsInfo BgpSettings
        {
            get => _bgpSettings = Get(_bgpSettings);
            set => _bgpSettings = value;
        }

        public int? VpnGatewayScaleUnit { get; set; }
    }

    public class VpnLinkConnectionPropertiesInfo : PropertyBase
    {

        private VpnSiteLinkInfo _vpnSiteLink;
        public VpnSiteLinkInfo VpnSiteLink
        {
            get => _vpnSiteLink = Get(_vpnSiteLink);
            set => _vpnSiteLink = value;
        }

        public int? RoutingWeight { get; set; }

        public string ConnectionStatus { get; set; }

        public string VpnConnectionProtocolType { get; set; }

        public int? ConnectionBandwidth { get; set; }

        public string SharedKey { get; set; }

        public bool? EnableBgp { get; set; }

        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        public IList<IpsecPolicyInfo> IpsecPolicies { get; set; }

        public bool? EnableRateLimiting { get; set; }

        public bool? UseLocalAzureIpAddress { get; set; }
    }

    public class VpnServerConfiguration : Resource<VpnServerConfigurationProperties>
    {
        public VpnServerConfiguration() => (Type, ApiVersion) = ("Microsoft.Network/vpnServerConfigurations", "2020-04-01");
        public VpnServerConfiguration(string name) : this() => Name = name;
        public VpnServerConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);

        public VpnServerConfiguration WithProperties(Action<VpnServerConfigurationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VpnServerConfigurationProperties : PropertyBase
    {

        public string Name { get; set; }

        public IList<string> VpnProtocols { get; set; }

        public IList<string> VpnAuthenticationTypes { get; set; }

        public IList<VpnClientRootCertificateInfo> VpnClientRootCertificates { get; set; }

        public IList<VpnClientRevokedCertificateInfo> VpnClientRevokedCertificates { get; set; }

        public IList<RadiusServerRootCertificateInfo> RadiusServerRootCertificates { get; set; }

        public IList<RadiusClientRootCertificateInfo> RadiusClientRootCertificates { get; set; }

        public IList<VpnClientIpsecPolicyInfo> VpnClientIpsecPolicies { get; set; }

        public string RadiusServerAddress { get; set; }

        public string RadiusServerSecret { get; set; }

        public IList<RadiusServerInfo> RadiusServers { get; set; }

        private AadAuthenticationParametersInfo _aadAuthenticationParameters;
        public AadAuthenticationParametersInfo AadAuthenticationParameters
        {
            get => _aadAuthenticationParameters = Get(_aadAuthenticationParameters);
            set => _aadAuthenticationParameters = value;
        }
    }

    public class RadiusServerRootCertificateInfo : PropertyBase
    {

        public string Name { get; set; }

        public string PublicCertData { get; set; }
    }

    public class RadiusClientRootCertificateInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Thumbprint { get; set; }
    }

    public class AadAuthenticationParametersInfo : PropertyBase
    {

        public string AadTenant { get; set; }

        public string AadAudience { get; set; }

        public string AadIssuer { get; set; }
    }

    public class VpnSite : Resource<VpnSiteProperties>
    {
        public VpnSite() => (Type, ApiVersion) = ("Microsoft.Network/vpnSites", "2020-04-01");
        public VpnSite(string name) : this() => Name = name;
        public VpnSite(string name, Location location) : this() => (Name, Location) = (name, location);

        public VpnSite WithProperties(Action<VpnSiteProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VpnSiteProperties : PropertyBase
    {

        private VirtualWanInfo _virtualWan;
        public VirtualWanInfo VirtualWan
        {
            get => _virtualWan = Get(_virtualWan);
            set => _virtualWan = value;
        }

        private DevicePropertiesInfo _deviceProperties;
        public DevicePropertiesInfo DeviceProperties
        {
            get => _deviceProperties = Get(_deviceProperties);
            set => _deviceProperties = value;
        }

        public string IpAddress { get; set; }

        public string SiteKey { get; set; }

        private AddressSpaceInfo _addressSpace;
        public AddressSpaceInfo AddressSpace
        {
            get => _addressSpace = Get(_addressSpace);
            set => _addressSpace = value;
        }

        private BgpPropertiesInfo _bgpProperties;
        public BgpPropertiesInfo BgpProperties
        {
            get => _bgpProperties = Get(_bgpProperties);
            set => _bgpProperties = value;
        }

        public bool? IsSecuritySite { get; set; }

        public IList<VpnSiteLinkInfo> VpnSiteLinks { get; set; }
    }

    public class DevicePropertiesInfo : PropertyBase
    {

        public string DeviceVendor { get; set; }

        public string DeviceModel { get; set; }

        public int? LinkSpeedInMbps { get; set; }
    }

    public class BgpPropertiesInfo : PropertyBase
    {

        public int? Asn { get; set; }

        public string BgpPeeringAddress { get; set; }

        public int? PeerWeight { get; set; }

        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public class LinkPropertiesInfo : PropertyBase
    {

        public string LinkProviderName { get; set; }

        public int? LinkSpeedInMbps { get; set; }
    }

    public class PropertiesBgpPropertiesInfo : PropertyBase
    {

        public int? Asn { get; set; }

        public string BgpPeeringAddress { get; set; }
    }
}
