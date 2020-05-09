namespace Charming.Types.Network
{
    using Charming;
    using System.Collections.Generic;

    public partial class ApplicationGateway : Resource<ApplicationGatewayProperties>
    {
        public ApplicationGateway() => (Type, ApiVersion) = ("Microsoft.Network/applicationGateways", "2020-04-01");
        public ApplicationGateway(string name) : this() => Name = name;
        public ApplicationGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }

        public IdentityInfo Identity { get; set; }
    }

    public partial class ApplicationGatewayProperties
    {
        public SkuInfo Sku { get; set; }
        public SslPolicyInfo SslPolicy { get; set; }
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
        public WebApplicationFirewallConfigurationInfo WebApplicationFirewallConfiguration { get; set; }
        public FirewallPolicyInfo FirewallPolicy { get; set; }
        public bool? EnableHttp2 { get; set; }
        public bool? EnableFips { get; set; }
        public AutoscaleConfigurationInfo AutoscaleConfiguration { get; set; }
        public IList<CustomErrorConfigurationInfo> CustomErrorConfigurations { get; set; }
        public bool? ForceFirewallPolicyAssociation { get; set; }
    }

    public partial class SkuInfo
    {
        public string Name { get; set; }
        public string Tier { get; set; }
        public int? Capacity { get; set; }
    }

    public partial class SslPolicyInfo
    {
        public IList<string> DisabledSslProtocols { get; set; }
        public string PolicyType { get; set; }
        public string PolicyName { get; set; }
        public IList<string> CipherSuites { get; set; }
        public string MinProtocolVersion { get; set; }
    }

    public partial class GatewayIPConfigurationInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesInfo
    {
        public SubnetInfo Subnet { get; set; }
    }

    public partial class SubnetInfo
    {
        public string Id { get; set; }
    }

    public partial class AuthenticationCertificateInfo
    {
        public string Id { get; set; }
        public AuthenticationCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class AuthenticationCertificatePropertiesInfo
    {
        public string Data { get; set; }
    }

    public partial class TrustedRootCertificateInfo
    {
        public string Id { get; set; }
        public TrustedRootCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class TrustedRootCertificatePropertiesInfo
    {
        public string Data { get; set; }
        public string KeyVaultSecretId { get; set; }
    }

    public partial class SslCertificateInfo
    {
        public string Id { get; set; }
        public SslCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class SslCertificatePropertiesInfo
    {
        public string Data { get; set; }
        public string Password { get; set; }
        public string KeyVaultSecretId { get; set; }
    }

    public partial class FrontendIPConfigurationInfo
    {
        public string Id { get; set; }
        public FrontendIPConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class FrontendIPConfigurationPropertiesInfo
    {
        public string PrivateIPAddress { get; set; }
        public string PrivateIPAllocationMethod { get; set; }
        public SubnetInfo Subnet { get; set; }
        public PublicIPAddressInfo PublicIPAddress { get; set; }
    }

    public partial class PublicIPAddressInfo
    {
        public string Id { get; set; }
    }

    public partial class FrontendPortInfo
    {
        public string Id { get; set; }
        public FrontendPortPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class FrontendPortPropertiesInfo
    {
        public int? Port { get; set; }
    }

    public partial class ProbeInfo
    {
        public string Id { get; set; }
        public ProbePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ProbePropertiesInfo
    {
        public string Protocol { get; set; }
        public string Host { get; set; }
        public string Path { get; set; }
        public int? Interval { get; set; }
        public int? Timeout { get; set; }
        public int? UnhealthyThreshold { get; set; }
        public bool? PickHostNameFromBackendHttpSettings { get; set; }
        public int? MinServers { get; set; }
        public MatchInfo Match { get; set; }
        public int? Port { get; set; }
    }

    public partial class MatchInfo
    {
        public string Body { get; set; }
        public IList<string> StatusCodes { get; set; }
    }

    public partial class BackendAddressPoolInfo
    {
        public string Id { get; set; }
        public BackendAddressPoolPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class BackendAddressPoolPropertiesInfo
    {
        public IList<BackendAddresseInfo> BackendAddresses { get; set; }
    }

    public partial class BackendAddresseInfo
    {
        public string Fqdn { get; set; }
        public string IpAddress { get; set; }
    }

    public partial class BackendHttpSettingsCollectionInfo
    {
        public string Id { get; set; }
        public BackendHttpSettingsCollectionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class BackendHttpSettingsCollectionPropertiesInfo
    {
        public int? Port { get; set; }
        public string Protocol { get; set; }
        public string CookieBasedAffinity { get; set; }
        public int? RequestTimeout { get; set; }
        public BackendHttpSettingsCollectionPropertiesProbeInfo Probe { get; set; }
        public IList<BackendHttpSettingsCollectionPropertiesAuthenticationCertificateInfo> AuthenticationCertificates { get; set; }
        public IList<BackendHttpSettingsCollectionPropertiesTrustedRootCertificateInfo> TrustedRootCertificates { get; set; }
        public ConnectionDrainingInfo ConnectionDraining { get; set; }
        public string HostName { get; set; }
        public bool? PickHostNameFromBackendAddress { get; set; }
        public string AffinityCookieName { get; set; }
        public bool? ProbeEnabled { get; set; }
        public string Path { get; set; }
    }

    public partial class BackendHttpSettingsCollectionPropertiesProbeInfo
    {
        public string Id { get; set; }
    }

    public partial class BackendHttpSettingsCollectionPropertiesAuthenticationCertificateInfo
    {
        public string Id { get; set; }
    }

    public partial class BackendHttpSettingsCollectionPropertiesTrustedRootCertificateInfo
    {
        public string Id { get; set; }
    }

    public partial class ConnectionDrainingInfo
    {
        public bool? Enabled { get; set; }
        public int? DrainTimeoutInSec { get; set; }
    }

    public partial class HttpListenerInfo
    {
        public string Id { get; set; }
        public HttpListenerPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class HttpListenerPropertiesInfo
    {
        public HttpListenerPropertiesFrontendIPConfigurationInfo FrontendIPConfiguration { get; set; }
        public HttpListenerPropertiesFrontendPortInfo FrontendPort { get; set; }
        public string Protocol { get; set; }
        public string HostName { get; set; }
        public HttpListenerPropertiesSslCertificateInfo SslCertificate { get; set; }
        public bool? RequireServerNameIndication { get; set; }
        public IList<CustomErrorConfigurationInfo> CustomErrorConfigurations { get; set; }
        public FirewallPolicyInfo FirewallPolicy { get; set; }
        public IList<string> HostNames { get; set; }
    }

    public partial class HttpListenerPropertiesFrontendIPConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class HttpListenerPropertiesFrontendPortInfo
    {
        public string Id { get; set; }
    }

    public partial class HttpListenerPropertiesSslCertificateInfo
    {
        public string Id { get; set; }
    }

    public partial class CustomErrorConfigurationInfo
    {
        public string StatusCode { get; set; }
        public string CustomErrorPageUrl { get; set; }
    }

    public partial class FirewallPolicyInfo
    {
        public string Id { get; set; }
    }

    public partial class UrlPathMapInfo
    {
        public string Id { get; set; }
        public UrlPathMapPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class UrlPathMapPropertiesInfo
    {
        public DefaultBackendAddressPoolInfo DefaultBackendAddressPool { get; set; }
        public DefaultBackendHttpSettingsInfo DefaultBackendHttpSettings { get; set; }
        public DefaultRewriteRuleSetInfo DefaultRewriteRuleSet { get; set; }
        public DefaultRedirectConfigurationInfo DefaultRedirectConfiguration { get; set; }
        public IList<PathRuleInfo> PathRules { get; set; }
    }

    public partial class DefaultBackendAddressPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class DefaultBackendHttpSettingsInfo
    {
        public string Id { get; set; }
    }

    public partial class DefaultRewriteRuleSetInfo
    {
        public string Id { get; set; }
    }

    public partial class DefaultRedirectConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class PathRuleInfo
    {
        public string Id { get; set; }
        public PathRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PathRulePropertiesInfo
    {
        public IList<string> Paths { get; set; }
        public PathRulePropertiesBackendAddressPoolInfo BackendAddressPool { get; set; }
        public BackendHttpSettingsInfo BackendHttpSettings { get; set; }
        public RedirectConfigurationInfo RedirectConfiguration { get; set; }
        public RewriteRuleSetInfo RewriteRuleSet { get; set; }
        public FirewallPolicyInfo FirewallPolicy { get; set; }
    }

    public partial class PathRulePropertiesBackendAddressPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class BackendHttpSettingsInfo
    {
        public string Id { get; set; }
    }

    public partial class RedirectConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class RewriteRuleSetInfo
    {
        public string Id { get; set; }
    }

    public partial class RequestRoutingRuleInfo
    {
        public string Id { get; set; }
        public RequestRoutingRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class RequestRoutingRulePropertiesInfo
    {
        public string RuleType { get; set; }
        public int? Priority { get; set; }
        public RequestRoutingRulePropertiesBackendAddressPoolInfo BackendAddressPool { get; set; }
        public BackendHttpSettingsInfo BackendHttpSettings { get; set; }
        public RequestRoutingRulePropertiesHttpListenerInfo HttpListener { get; set; }
        public RequestRoutingRulePropertiesUrlPathMapInfo UrlPathMap { get; set; }
        public RewriteRuleSetInfo RewriteRuleSet { get; set; }
        public RedirectConfigurationInfo RedirectConfiguration { get; set; }
    }

    public partial class RequestRoutingRulePropertiesBackendAddressPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class RequestRoutingRulePropertiesHttpListenerInfo
    {
        public string Id { get; set; }
    }

    public partial class RequestRoutingRulePropertiesUrlPathMapInfo
    {
        public string Id { get; set; }
    }

    public partial class PropertiesRewriteRuleSetInfo
    {
        public string Id { get; set; }
        public PropertiesRewriteRuleSetPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesRewriteRuleSetPropertiesInfo
    {
        public IList<RewriteRuleInfo> RewriteRules { get; set; }
    }

    public partial class RewriteRuleInfo
    {
        public string Name { get; set; }
        public int? RuleSequence { get; set; }
        public IList<ConditionInfo> Conditions { get; set; }
        public ActionSetInfo ActionSet { get; set; }
    }

    public partial class ConditionInfo
    {
        public string Variable { get; set; }
        public string Pattern { get; set; }
        public bool? IgnoreCase { get; set; }
        public bool? Negate { get; set; }
    }

    public partial class ActionSetInfo
    {
        public IList<RequestHeaderConfigurationInfo> RequestHeaderConfigurations { get; set; }
        public IList<ResponseHeaderConfigurationInfo> ResponseHeaderConfigurations { get; set; }
        public UrlConfigurationInfo UrlConfiguration { get; set; }
    }

    public partial class RequestHeaderConfigurationInfo
    {
        public string HeaderName { get; set; }
        public string HeaderValue { get; set; }
    }

    public partial class ResponseHeaderConfigurationInfo
    {
        public string HeaderName { get; set; }
        public string HeaderValue { get; set; }
    }

    public partial class UrlConfigurationInfo
    {
        public string ModifiedPath { get; set; }
        public string ModifiedQueryString { get; set; }
        public bool? Reroute { get; set; }
    }

    public partial class PropertiesRedirectConfigurationInfo
    {
        public string Id { get; set; }
        public PropertiesRedirectConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesRedirectConfigurationPropertiesInfo
    {
        public string RedirectType { get; set; }
        public TargetListenerInfo TargetListener { get; set; }
        public string TargetUrl { get; set; }
        public bool? IncludePath { get; set; }
        public bool? IncludeQueryString { get; set; }
        public IList<PropertiesRedirectConfigurationPropertiesRequestRoutingRuleInfo> RequestRoutingRules { get; set; }
        public IList<PropertiesRedirectConfigurationPropertiesUrlPathMapInfo> UrlPathMaps { get; set; }
        public IList<PropertiesRedirectConfigurationPropertiesPathRuleInfo> PathRules { get; set; }
    }

    public partial class TargetListenerInfo
    {
        public string Id { get; set; }
    }

    public partial class PropertiesRedirectConfigurationPropertiesRequestRoutingRuleInfo
    {
        public string Id { get; set; }
    }

    public partial class PropertiesRedirectConfigurationPropertiesUrlPathMapInfo
    {
        public string Id { get; set; }
    }

    public partial class PropertiesRedirectConfigurationPropertiesPathRuleInfo
    {
        public string Id { get; set; }
    }

    public partial class WebApplicationFirewallConfigurationInfo
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

    public partial class DisabledRuleGroupInfo
    {
        public string RuleGroupName { get; set; }
        public IList<string> Rules { get; set; }
    }

    public partial class ExclusionInfo
    {
        public string MatchVariable { get; set; }
        public string SelectorMatchOperator { get; set; }
        public string Selector { get; set; }
    }

    public partial class AutoscaleConfigurationInfo
    {
        public int? MinCapacity { get; set; }
        public int? MaxCapacity { get; set; }
    }

    public partial class IdentityInfo
    {
        public string Type { get; set; }
        public object UserAssignedIdentities { get; set; }
    }

    public partial class ApplicationGatewayWebApplicationFirewallPolicy : Resource<ApplicationGatewayWebApplicationFirewallPolicyProperties>
    {
        public ApplicationGatewayWebApplicationFirewallPolicy() => (Type, ApiVersion) = ("Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies", "2020-04-01");
        public ApplicationGatewayWebApplicationFirewallPolicy(string name) : this() => Name = name;
        public ApplicationGatewayWebApplicationFirewallPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ApplicationGatewayWebApplicationFirewallPolicyProperties
    {
        public PolicySettingsInfo PolicySettings { get; set; }
        public IList<CustomRuleInfo> CustomRules { get; set; }
        public ManagedRulesInfo ManagedRules { get; set; }
    }

    public partial class PolicySettingsInfo
    {
        public string State { get; set; }
        public string Mode { get; set; }
        public bool? RequestBodyCheck { get; set; }
        public int? MaxRequestBodySizeInKb { get; set; }
        public int? FileUploadLimitInMb { get; set; }
    }

    public partial class CustomRuleInfo
    {
        public string Name { get; set; }
        public int? Priority { get; set; }
        public string RuleType { get; set; }
        public IList<MatchConditionInfo> MatchConditions { get; set; }
        public string Action { get; set; }
    }

    public partial class MatchConditionInfo
    {
        public IList<MatchVariableInfo> MatchVariables { get; set; }
        public string Operator { get; set; }
        public bool? NegationConditon { get; set; }
        public IList<string> MatchValues { get; set; }
        public IList<string> Transforms { get; set; }
    }

    public partial class MatchVariableInfo
    {
        public string VariableName { get; set; }
        public string Selector { get; set; }
    }

    public partial class ManagedRulesInfo
    {
        public IList<ExclusionInfo> Exclusions { get; set; }
        public IList<ManagedRuleSetInfo> ManagedRuleSets { get; set; }
    }

    public partial class ManagedRuleSetInfo
    {
        public string RuleSetType { get; set; }
        public string RuleSetVersion { get; set; }
        public IList<RuleGroupOverrideInfo> RuleGroupOverrides { get; set; }
    }

    public partial class RuleGroupOverrideInfo
    {
        public string RuleGroupName { get; set; }
        public IList<RuleInfo> Rules { get; set; }
    }

    public partial class RuleInfo
    {
        public string RuleId { get; set; }
        public string State { get; set; }
    }

    public partial class ApplicationSecurityGroup : Resource<ApplicationSecurityGroupProperties>
    {
        public ApplicationSecurityGroup() => (Type, ApiVersion) = ("Microsoft.Network/applicationSecurityGroups", "2020-04-01");
        public ApplicationSecurityGroup(string name) : this() => Name = name;
        public ApplicationSecurityGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ApplicationSecurityGroupProperties
    {
    }

    public partial class AzureFirewall : Resource<AzureFirewallProperties>
    {
        public AzureFirewall() => (Type, ApiVersion) = ("Microsoft.Network/azureFirewalls", "2020-04-01");
        public AzureFirewall(string name) : this() => Name = name;
        public AzureFirewall(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }
    }

    public partial class AzureFirewallProperties
    {
        public IList<ApplicationRuleCollectionInfo> ApplicationRuleCollections { get; set; }
        public IList<NatRuleCollectionInfo> NatRuleCollections { get; set; }
        public IList<NetworkRuleCollectionInfo> NetworkRuleCollections { get; set; }
        public IList<IpConfigurationInfo> IpConfigurations { get; set; }
        public ManagementIpConfigurationInfo ManagementIpConfiguration { get; set; }
        public string ThreatIntelMode { get; set; }
        public VirtualHubInfo VirtualHub { get; set; }
        public FirewallPolicyInfo FirewallPolicy { get; set; }
        public SkuInfo Sku { get; set; }
        public object AdditionalProperties { get; set; }
    }

    public partial class ApplicationRuleCollectionInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ActionInfo
    {
        public string Type { get; set; }
    }

    public partial class ProtocolInfo
    {
        public string ProtocolType { get; set; }
        public int? Port { get; set; }
    }

    public partial class NatRuleCollectionInfo
    {
        public string Id { get; set; }
        public NatRuleCollectionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NatRuleCollectionPropertiesInfo
    {
        public int? Priority { get; set; }
        public ActionInfo Action { get; set; }
        public IList<NatRuleCollectionPropertiesRuleInfo> Rules { get; set; }
    }

    public partial class NatRuleCollectionPropertiesRuleInfo
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

    public partial class NetworkRuleCollectionInfo
    {
        public string Id { get; set; }
        public NetworkRuleCollectionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkRuleCollectionPropertiesInfo
    {
        public int? Priority { get; set; }
        public ActionInfo Action { get; set; }
        public IList<NetworkRuleCollectionPropertiesRuleInfo> Rules { get; set; }
    }

    public partial class NetworkRuleCollectionPropertiesRuleInfo
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

    public partial class IpConfigurationInfo
    {
        public string Id { get; set; }
        public IpConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class IpConfigurationPropertiesInfo
    {
        public SubnetInfo Subnet { get; set; }
        public PublicIPAddressInfo PublicIPAddress { get; set; }
    }

    public partial class ManagementIpConfigurationInfo
    {
        public string Id { get; set; }
        public ManagementIpConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ManagementIpConfigurationPropertiesInfo
    {
        public SubnetInfo Subnet { get; set; }
        public PublicIPAddressInfo PublicIPAddress { get; set; }
    }

    public partial class VirtualHubInfo
    {
        public string Id { get; set; }
    }

    public partial class BastionHost : Resource<BastionHostProperties>
    {
        public BastionHost() => (Type, ApiVersion) = ("Microsoft.Network/bastionHosts", "2020-04-01");
        public BastionHost(string name) : this() => Name = name;
        public BastionHost(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class BastionHostProperties
    {
        public IList<IpConfigurationInfo> IpConfigurations { get; set; }
        public string DnsName { get; set; }
    }

    public partial class Connection : Resource<ConnectionProperties>
    {
        public Connection() => (Type, ApiVersion) = ("Microsoft.Network/connections", "2020-04-01");
        public Connection(string name) : this() => Name = name;
        public Connection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ConnectionProperties
    {
        public string AuthorizationKey { get; set; }
        public VirtualNetworkGateway1Info VirtualNetworkGateway1 { get; set; }
        public VirtualNetworkGateway2Info VirtualNetworkGateway2 { get; set; }
        public LocalNetworkGateway2Info LocalNetworkGateway2 { get; set; }
        public string ConnectionType { get; set; }
        public string ConnectionProtocol { get; set; }
        public int? RoutingWeight { get; set; }
        public int? DpdTimeoutSeconds { get; set; }
        public string SharedKey { get; set; }
        public PeerInfo Peer { get; set; }
        public bool? EnableBgp { get; set; }
        public bool? UseLocalAzureIpAddress { get; set; }
        public bool? UsePolicyBasedTrafficSelectors { get; set; }
        public IList<IpsecPolicyInfo> IpsecPolicies { get; set; }
        public IList<TrafficSelectorPolicyInfo> TrafficSelectorPolicies { get; set; }
        public bool? ExpressRouteGatewayBypass { get; set; }
    }

    public partial class VirtualNetworkGateway1Info
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public PropertiesInfo Properties { get; set; }
    }

    public partial class GatewayDefaultSiteInfo
    {
        public string Id { get; set; }
    }

    public partial class VpnClientConfigurationInfo
    {
        public VpnClientAddressPoolInfo VpnClientAddressPool { get; set; }
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

    public partial class VpnClientAddressPoolInfo
    {
        public IList<string> AddressPrefixes { get; set; }
    }

    public partial class VpnClientRootCertificateInfo
    {
        public string Id { get; set; }
        public VpnClientRootCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VpnClientRootCertificatePropertiesInfo
    {
        public string PublicCertData { get; set; }
    }

    public partial class VpnClientRevokedCertificateInfo
    {
        public string Id { get; set; }
        public VpnClientRevokedCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VpnClientRevokedCertificatePropertiesInfo
    {
        public string Thumbprint { get; set; }
    }

    public partial class VpnClientIpsecPolicyInfo
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

    public partial class RadiusServerInfo
    {
        public string RadiusServerAddress { get; set; }
        public int? RadiusServerScore { get; set; }
        public string RadiusServerSecret { get; set; }
    }

    public partial class BgpSettingsInfo
    {
        public int? Asn { get; set; }
        public string BgpPeeringAddress { get; set; }
        public int? PeerWeight { get; set; }
        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public partial class BgpPeeringAddresseInfo
    {
        public string IpconfigurationId { get; set; }
        public IList<string> CustomBgpIpAddresses { get; set; }
    }

    public partial class CustomRoutesInfo
    {
        public IList<string> AddressPrefixes { get; set; }
    }

    public partial class VirtualNetworkGateway2Info
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public VirtualNetworkGateway2PropertiesInfo Properties { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesInfo
    {
        public IList<VirtualNetworkGateway2PropertiesIpConfigurationInfo> IpConfigurations { get; set; }
        public string GatewayType { get; set; }
        public string VpnType { get; set; }
        public string VpnGatewayGeneration { get; set; }
        public bool? EnableBgp { get; set; }
        public bool? EnablePrivateIpAddress { get; set; }
        public bool? ActiveActive { get; set; }
        public GatewayDefaultSiteInfo GatewayDefaultSite { get; set; }
        public SkuInfo Sku { get; set; }
        public VirtualNetworkGateway2PropertiesVpnClientConfigurationInfo VpnClientConfiguration { get; set; }
        public VirtualNetworkGateway2PropertiesBgpSettingsInfo BgpSettings { get; set; }
        public CustomRoutesInfo CustomRoutes { get; set; }
        public bool? EnableDnsForwarding { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesIpConfigurationInfo
    {
        public string Id { get; set; }
        public VirtualNetworkGateway2PropertiesIpConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesIpConfigurationPropertiesInfo
    {
        public string PrivateIPAllocationMethod { get; set; }
        public SubnetInfo Subnet { get; set; }
        public PublicIPAddressInfo PublicIPAddress { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesVpnClientConfigurationInfo
    {
        public VpnClientAddressPoolInfo VpnClientAddressPool { get; set; }
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

    public partial class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificateInfo
    {
        public string Id { get; set; }
        public VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRootCertificatePropertiesInfo
    {
        public string PublicCertData { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificateInfo
    {
        public string Id { get; set; }
        public VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesVpnClientConfigurationVpnClientRevokedCertificatePropertiesInfo
    {
        public string Thumbprint { get; set; }
    }

    public partial class VirtualNetworkGateway2PropertiesBgpSettingsInfo
    {
        public int? Asn { get; set; }
        public string BgpPeeringAddress { get; set; }
        public int? PeerWeight { get; set; }
        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public partial class LocalNetworkGateway2Info
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public LocalNetworkGateway2PropertiesInfo Properties { get; set; }
    }

    public partial class LocalNetworkGateway2PropertiesInfo
    {
        public LocalNetworkAddressSpaceInfo LocalNetworkAddressSpace { get; set; }
        public string GatewayIpAddress { get; set; }
        public string Fqdn { get; set; }
        public LocalNetworkGateway2PropertiesBgpSettingsInfo BgpSettings { get; set; }
    }

    public partial class LocalNetworkAddressSpaceInfo
    {
        public IList<string> AddressPrefixes { get; set; }
    }

    public partial class LocalNetworkGateway2PropertiesBgpSettingsInfo
    {
        public int? Asn { get; set; }
        public string BgpPeeringAddress { get; set; }
        public int? PeerWeight { get; set; }
        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public partial class PeerInfo
    {
        public string Id { get; set; }
    }

    public partial class IpsecPolicyInfo
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

    public partial class TrafficSelectorPolicyInfo
    {
        public IList<string> LocalAddressRanges { get; set; }
        public IList<string> RemoteAddressRanges { get; set; }
    }

    public partial class DdosCustomPolicy : Resource<DdosCustomPolicyProperties>
    {
        public DdosCustomPolicy() => (Type, ApiVersion) = ("Microsoft.Network/ddosCustomPolicies", "2020-04-01");
        public DdosCustomPolicy(string name) : this() => Name = name;
        public DdosCustomPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DdosCustomPolicyProperties
    {
        public IList<ProtocolCustomSettingInfo> ProtocolCustomSettings { get; set; }
    }

    public partial class ProtocolCustomSettingInfo
    {
        public string Protocol { get; set; }
        public string TriggerRateOverride { get; set; }
        public string SourceRateOverride { get; set; }
        public string TriggerSensitivityOverride { get; set; }
    }

    public partial class DdosProtectionPlan : Resource<DdosProtectionPlanProperties>
    {
        public DdosProtectionPlan() => (Type, ApiVersion) = ("Microsoft.Network/ddosProtectionPlans", "2020-04-01");
        public DdosProtectionPlan(string name) : this() => Name = name;
        public DdosProtectionPlan(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DdosProtectionPlanProperties
    {
    }

    public partial class ExpressRouteCircuitAuthorization : Resource<ExpressRouteCircuitAuthorizationProperties>
    {
        public ExpressRouteCircuitAuthorization() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits/authorizations", "2020-04-01");
        public ExpressRouteCircuitAuthorization(string name) : this() => Name = name;
        public ExpressRouteCircuitAuthorization(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteCircuitAuthorizationProperties
    {
        public string AuthorizationKey { get; set; }
        public string AuthorizationUseStatus { get; set; }
    }

    public partial class ExpressRouteCircuitPeeringConnection : Resource<ExpressRouteCircuitPeeringConnectionProperties>
    {
        public ExpressRouteCircuitPeeringConnection() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits/peerings/connections", "2020-04-01");
        public ExpressRouteCircuitPeeringConnection(string name) : this() => Name = name;
        public ExpressRouteCircuitPeeringConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteCircuitPeeringConnectionProperties
    {
        public ExpressRouteCircuitPeeringInfo ExpressRouteCircuitPeering { get; set; }
        public PeerExpressRouteCircuitPeeringInfo PeerExpressRouteCircuitPeering { get; set; }
        public string AddressPrefix { get; set; }
        public string AuthorizationKey { get; set; }
        public Ipv6CircuitConnectionConfigInfo Ipv6CircuitConnectionConfig { get; set; }
        public string CircuitConnectionStatus { get; set; }
    }

    public partial class ExpressRouteCircuitPeeringInfo
    {
        public string Id { get; set; }
    }

    public partial class PeerExpressRouteCircuitPeeringInfo
    {
        public string Id { get; set; }
    }

    public partial class Ipv6CircuitConnectionConfigInfo
    {
        public string AddressPrefix { get; set; }
    }

    public partial class ExpressRouteCircuitPeering : Resource<ExpressRouteCircuitPeeringProperties>
    {
        public ExpressRouteCircuitPeering() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits/peerings", "2020-04-01");
        public ExpressRouteCircuitPeering(string name) : this() => Name = name;
        public ExpressRouteCircuitPeering(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteCircuitPeeringProperties
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
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig { get; set; }
        public StatsInfo Stats { get; set; }
        public RouteFilterInfo RouteFilter { get; set; }
        public Ipv6PeeringConfigInfo Ipv6PeeringConfig { get; set; }
        public object ExpressRouteConnection { get; set; }
        public IList<ConnectionInfo> Connections { get; set; }
    }

    public partial class MicrosoftPeeringConfigInfo
    {
        public IList<string> AdvertisedPublicPrefixes { get; set; }
        public IList<string> AdvertisedCommunities { get; set; }
        public int? LegacyMode { get; set; }
        public int? CustomerASN { get; set; }
        public string RoutingRegistryName { get; set; }
    }

    public partial class StatsInfo
    {
        public int? PrimarybytesIn { get; set; }
        public int? PrimarybytesOut { get; set; }
        public int? SecondarybytesIn { get; set; }
        public int? SecondarybytesOut { get; set; }
    }

    public partial class RouteFilterInfo
    {
        public string Id { get; set; }
    }

    public partial class Ipv6PeeringConfigInfo
    {
        public string PrimaryPeerAddressPrefix { get; set; }
        public string SecondaryPeerAddressPrefix { get; set; }
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig { get; set; }
        public RouteFilterInfo RouteFilter { get; set; }
        public string State { get; set; }
    }

    public partial class ConnectionInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ExpressRouteCircuit : Resource<ExpressRouteCircuitProperties>
    {
        public ExpressRouteCircuit() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCircuits", "2020-04-01");
        public ExpressRouteCircuit(string name) : this() => Name = name;
        public ExpressRouteCircuit(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteCircuitProperties
    {
        public bool? AllowClassicOperations { get; set; }
        public IList<AuthorizationInfo> Authorizations { get; set; }
        public IList<PeeringInfo> Peerings { get; set; }
        public string ServiceKey { get; set; }
        public string ServiceProviderNotes { get; set; }
        public ServiceProviderPropertiesInfo ServiceProviderProperties { get; set; }
        public ExpressRoutePortInfo ExpressRoutePort { get; set; }
        public string BandwidthInGbps { get; set; }
        public bool? GlobalReachEnabled { get; set; }
    }

    public partial class AuthorizationInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PeeringInfo
    {
        public string Id { get; set; }
        public PeeringPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PeeringPropertiesInfo
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
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig { get; set; }
        public StatsInfo Stats { get; set; }
        public RouteFilterInfo RouteFilter { get; set; }
        public Ipv6PeeringConfigInfo Ipv6PeeringConfig { get; set; }
        public object ExpressRouteConnection { get; set; }
        public IList<ConnectionInfo> Connections { get; set; }
    }

    public partial class ConnectionPropertiesInfo
    {
        public ExpressRouteCircuitPeeringInfo ExpressRouteCircuitPeering { get; set; }
        public PeerExpressRouteCircuitPeeringInfo PeerExpressRouteCircuitPeering { get; set; }
        public string AddressPrefix { get; set; }
        public string AuthorizationKey { get; set; }
        public Ipv6CircuitConnectionConfigInfo Ipv6CircuitConnectionConfig { get; set; }
        public string CircuitConnectionStatus { get; set; }
    }

    public partial class ServiceProviderPropertiesInfo
    {
        public string ServiceProviderName { get; set; }
        public string PeeringLocation { get; set; }
        public int? BandwidthInMbps { get; set; }
    }

    public partial class ExpressRoutePortInfo
    {
        public string Id { get; set; }
    }

    public partial class ExpressRouteCrossConnectionPeering : Resource<ExpressRouteCrossConnectionPeeringProperties>
    {
        public ExpressRouteCrossConnectionPeering() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCrossConnections/peerings", "2020-04-01");
        public ExpressRouteCrossConnectionPeering(string name) : this() => Name = name;
        public ExpressRouteCrossConnectionPeering(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteCrossConnectionPeeringProperties
    {
        public string PeeringType { get; set; }
        public string State { get; set; }
        public int? PeerASN { get; set; }
        public string PrimaryPeerAddressPrefix { get; set; }
        public string SecondaryPeerAddressPrefix { get; set; }
        public string SharedKey { get; set; }
        public int? VlanId { get; set; }
        public MicrosoftPeeringConfigInfo MicrosoftPeeringConfig { get; set; }
        public Ipv6PeeringConfigInfo Ipv6PeeringConfig { get; set; }
    }

    public partial class ExpressRouteCrossConnection : Resource<ExpressRouteCrossConnectionProperties>
    {
        public ExpressRouteCrossConnection() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteCrossConnections", "2020-04-01");
        public ExpressRouteCrossConnection(string name) : this() => Name = name;
        public ExpressRouteCrossConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteCrossConnectionProperties
    {
        public string PeeringLocation { get; set; }
        public int? BandwidthInMbps { get; set; }
        public ExpressRouteCircuitInfo ExpressRouteCircuit { get; set; }
        public string ServiceProviderNotes { get; set; }
        public IList<PeeringInfo> Peerings { get; set; }
    }

    public partial class ExpressRouteCircuitInfo
    {
        public string Id { get; set; }
    }

    public partial class ExpressRouteGatewayExpressRouteConnection : Resource<ExpressRouteGatewayExpressRouteConnectionProperties>
    {
        public ExpressRouteGatewayExpressRouteConnection() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteGateways/expressRouteConnections", "2020-04-01");
        public ExpressRouteGatewayExpressRouteConnection(string name) : this() => Name = name;
        public ExpressRouteGatewayExpressRouteConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteGatewayExpressRouteConnectionProperties
    {
        public ExpressRouteCircuitPeeringInfo ExpressRouteCircuitPeering { get; set; }
        public string AuthorizationKey { get; set; }
        public int? RoutingWeight { get; set; }
        public bool? EnableInternetSecurity { get; set; }
        public RoutingConfigurationInfo RoutingConfiguration { get; set; }
    }

    public partial class RoutingConfigurationInfo
    {
        public AssociatedRouteTableInfo AssociatedRouteTable { get; set; }
        public PropagatedRouteTablesInfo PropagatedRouteTables { get; set; }
        public VnetRoutesInfo VnetRoutes { get; set; }
    }

    public partial class AssociatedRouteTableInfo
    {
        public string Id { get; set; }
    }

    public partial class PropagatedRouteTablesInfo
    {
        public IList<string> Labels { get; set; }
        public IList<IdInfo> Ids { get; set; }
    }

    public partial class IdInfo
    {
        public string Id { get; set; }
    }

    public partial class VnetRoutesInfo
    {
        public IList<StaticRouteInfo> StaticRoutes { get; set; }
    }

    public partial class StaticRouteInfo
    {
        public string Name { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class ExpressRouteGateway : Resource<ExpressRouteGatewayProperties>
    {
        public ExpressRouteGateway() => (Type, ApiVersion) = ("Microsoft.Network/expressRouteGateways", "2020-04-01");
        public ExpressRouteGateway(string name) : this() => Name = name;
        public ExpressRouteGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ExpressRouteGatewayProperties
    {
        public AutoScaleConfigurationInfo AutoScaleConfiguration { get; set; }
        public VirtualHubInfo VirtualHub { get; set; }
    }

    public partial class AutoScaleConfigurationInfo
    {
        public BoundsInfo Bounds { get; set; }
    }

    public partial class BoundsInfo
    {
        public int? Min { get; set; }
        public int? Max { get; set; }
    }

    public partial class ExpressRoutePort : Resource<ExpressRoutePortProperties>
    {
        public ExpressRoutePort() => (Type, ApiVersion) = ("Microsoft.Network/ExpressRoutePorts", "2020-04-01");
        public ExpressRoutePort(string name) : this() => Name = name;
        public ExpressRoutePort(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class ExpressRoutePortProperties
    {
        public string PeeringLocation { get; set; }
        public int? BandwidthInGbps { get; set; }
        public string Encapsulation { get; set; }
        public IList<LinkInfo> Links { get; set; }
    }

    public partial class LinkInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class MacSecConfigInfo
    {
        public string CknSecretIdentifier { get; set; }
        public string CakSecretIdentifier { get; set; }
        public string Cipher { get; set; }
    }

    public partial class FirewallPolicyRuleGroup : Resource<FirewallPolicyRuleGroupProperties>
    {
        public FirewallPolicyRuleGroup() => (Type, ApiVersion) = ("Microsoft.Network/firewallPolicies/ruleGroups", "2020-04-01");
        public FirewallPolicyRuleGroup(string name) : this() => Name = name;
        public FirewallPolicyRuleGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class FirewallPolicyRuleGroupProperties
    {
        public int? Priority { get; set; }
        public IList<RuleInfo> Rules { get; set; }
    }

    public partial class FirewallPolicy : Resource<FirewallPolicyProperties>
    {
        public FirewallPolicy() => (Type, ApiVersion) = ("Microsoft.Network/firewallPolicies", "2020-04-01");
        public FirewallPolicy(string name) : this() => Name = name;
        public FirewallPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class FirewallPolicyProperties
    {
        public BasePolicyInfo BasePolicy { get; set; }
        public string ThreatIntelMode { get; set; }
        public ThreatIntelWhitelistInfo ThreatIntelWhitelist { get; set; }
        public string IntrusionSystemMode { get; set; }
        public TransportSecurityInfo TransportSecurity { get; set; }
    }

    public partial class BasePolicyInfo
    {
        public string Id { get; set; }
    }

    public partial class ThreatIntelWhitelistInfo
    {
        public IList<string> IpAddresses { get; set; }
        public IList<string> Fqdns { get; set; }
    }

    public partial class TransportSecurityInfo
    {
        public CertificateAuthorityInfo CertificateAuthority { get; set; }
        public IList<string> ExcludedDomains { get; set; }
        public IList<TrustedRootCertificateInfo> TrustedRootCertificates { get; set; }
    }

    public partial class CertificateAuthorityInfo
    {
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class InterfaceEndpoint : Resource<InterfaceEndpointProperties>
    {
        public InterfaceEndpoint() => (Type, ApiVersion) = ("Microsoft.Network/interfaceEndpoints", "2019-02-01");
        public InterfaceEndpoint(string name) : this() => Name = name;
        public InterfaceEndpoint(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class InterfaceEndpointProperties
    {
        public string Fqdn { get; set; }
        public EndpointServiceInfo EndpointService { get; set; }
        public SubnetInfo Subnet { get; set; }
    }

    public partial class EndpointServiceInfo
    {
        public string Id { get; set; }
    }

    public partial class NetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public NetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class NetworkSecurityGroupPropertiesInfo
    {
        public IList<SecurityRuleInfo> SecurityRules { get; set; }
        public IList<DefaultSecurityRuleInfo> DefaultSecurityRules { get; set; }
        public string ResourceGuid { get; set; }
    }

    public partial class SecurityRuleInfo
    {
        public string Id { get; set; }
        public SecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class SecurityRulePropertiesInfo
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

    public partial class SourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class DestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class DefaultSecurityRuleInfo
    {
        public string Id { get; set; }
        public DefaultSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DefaultSecurityRulePropertiesInfo
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

    public partial class DefaultSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class DefaultSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class RouteTableInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public RouteTablePropertiesInfo Properties { get; set; }
    }

    public partial class RouteTablePropertiesInfo
    {
        public IList<RouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class RouteInfo
    {
        public string Id { get; set; }
        public RoutePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class RoutePropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class NatGatewayInfo
    {
        public string Id { get; set; }
    }

    public partial class ServiceEndpointInfo
    {
        public string Service { get; set; }
        public IList<string> Locations { get; set; }
    }

    public partial class ServiceEndpointPolicyInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public ServiceEndpointPolicyPropertiesInfo Properties { get; set; }
    }

    public partial class ServiceEndpointPolicyPropertiesInfo
    {
        public IList<ServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class ServiceEndpointPolicyDefinitionInfo
    {
        public string Id { get; set; }
        public ServiceEndpointPolicyDefinitionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ServiceEndpointPolicyDefinitionPropertiesInfo
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class ResourceNavigationLinkInfo
    {
        public string Id { get; set; }
        public ResourceNavigationLinkPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ResourceNavigationLinkPropertiesInfo
    {
        public string LinkedResourceType { get; set; }
        public string Link { get; set; }
    }

    public partial class ServiceAssociationLinkInfo
    {
        public string Id { get; set; }
        public ServiceAssociationLinkPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ServiceAssociationLinkPropertiesInfo
    {
        public string LinkedResourceType { get; set; }
        public string Link { get; set; }
    }

    public partial class DelegationInfo
    {
        public string Id { get; set; }
        public DelegationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DelegationPropertiesInfo
    {
        public string ServiceName { get; set; }
        public IList<string> Actions { get; set; }
    }

    public partial class IpAllocation : Resource<IpAllocationProperties>
    {
        public IpAllocation() => (Type, ApiVersion) = ("Microsoft.Network/IpAllocations", "2020-04-01");
        public IpAllocation(string name) : this() => Name = name;
        public IpAllocation(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class IpAllocationProperties
    {
        public string Type { get; set; }
        public string Prefix { get; set; }
        public int? PrefixLength { get; set; }
        public string PrefixType { get; set; }
        public string IpamAllocationId { get; set; }
        public object AllocationTags { get; set; }
    }

    public partial class IpGroup : Resource<IpGroupProperties>
    {
        public IpGroup() => (Type, ApiVersion) = ("Microsoft.Network/ipGroups", "2020-04-01");
        public IpGroup(string name) : this() => Name = name;
        public IpGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class IpGroupProperties
    {
        public IList<string> IpAddresses { get; set; }
    }

    public partial class LoadBalancerBackendAddressPool : Resource<LoadBalancerBackendAddressPoolProperties>
    {
        public LoadBalancerBackendAddressPool() => (Type, ApiVersion) = ("Microsoft.Network/loadBalancers/backendAddressPools", "2020-04-01");
        public LoadBalancerBackendAddressPool(string name) : this() => Name = name;
        public LoadBalancerBackendAddressPool(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class LoadBalancerBackendAddressPoolProperties
    {
        public IList<LoadBalancerBackendAddresseInfo> LoadBalancerBackendAddresses { get; set; }
    }

    public partial class LoadBalancerBackendAddresseInfo
    {
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public VirtualNetworkPropertiesInfo Properties { get; set; }
    }

    public partial class VirtualNetworkPropertiesInfo
    {
        public AddressSpaceInfo AddressSpace { get; set; }
        public DhcpOptionsInfo DhcpOptions { get; set; }
        public IList<SubnetInfo> Subnets { get; set; }
        public IList<VirtualNetworkPeeringInfo> VirtualNetworkPeerings { get; set; }
        public bool? EnableDdosProtection { get; set; }
        public bool? EnableVmProtection { get; set; }
        public DdosProtectionPlanInfo DdosProtectionPlan { get; set; }
        public BgpCommunitiesInfo BgpCommunities { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
    }

    public partial class AddressSpaceInfo
    {
        public IList<string> AddressPrefixes { get; set; }
    }

    public partial class DhcpOptionsInfo
    {
        public IList<string> DnsServers { get; set; }
    }

    public partial class SubnetPropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public NetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public RouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<ServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<DelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class IpAllocationInfo
    {
        public string Id { get; set; }
    }

    public partial class VirtualNetworkPeeringInfo
    {
        public string Id { get; set; }
        public VirtualNetworkPeeringPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkPeeringPropertiesInfo
    {
        public bool? AllowVirtualNetworkAccess { get; set; }
        public bool? AllowForwardedTraffic { get; set; }
        public bool? AllowGatewayTransit { get; set; }
        public bool? UseRemoteGateways { get; set; }
        public RemoteVirtualNetworkInfo RemoteVirtualNetwork { get; set; }
        public RemoteAddressSpaceInfo RemoteAddressSpace { get; set; }
        public string PeeringState { get; set; }
    }

    public partial class RemoteVirtualNetworkInfo
    {
        public string Id { get; set; }
    }

    public partial class RemoteAddressSpaceInfo
    {
        public IList<string> AddressPrefixes { get; set; }
    }

    public partial class DdosProtectionPlanInfo
    {
        public string Id { get; set; }
    }

    public partial class BgpCommunitiesInfo
    {
        public string VirtualNetworkCommunity { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationInfo
    {
        public string Id { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesInfo
    {
        public IList<VirtualNetworkTapInfo> VirtualNetworkTaps { get; set; }
        public IList<ApplicationGatewayBackendAddressPoolInfo> ApplicationGatewayBackendAddressPools { get; set; }
        public IList<LoadBalancerBackendAddressPoolInfo> LoadBalancerBackendAddressPools { get; set; }
        public IList<LoadBalancerInboundNatRuleInfo> LoadBalancerInboundNatRules { get; set; }
        public string PrivateIPAddress { get; set; }
        public string PrivateIPAllocationMethod { get; set; }
        public string PrivateIPAddressVersion { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetInfo Subnet { get; set; }
        public bool? Primary { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesPublicIPAddressInfo PublicIPAddress { get; set; }
        public IList<ApplicationSecurityGroupInfo> ApplicationSecurityGroups { get; set; }
    }

    public partial class VirtualNetworkTapInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public VirtualNetworkTapPropertiesInfo Properties { get; set; }
    }

    public partial class VirtualNetworkTapPropertiesInfo
    {
        public string DestinationNetworkInterfaceIPConfiguration { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationInfo DestinationLoadBalancerFrontEndIPConfiguration { get; set; }
        public int? DestinationPort { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationInfo
    {
        public string Id { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
        public IList<string> Zones { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesInfo
    {
        public string PrivateIPAddress { get; set; }
        public string PrivateIPAllocationMethod { get; set; }
        public string PrivateIPAddressVersion { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetInfo Subnet { get; set; }
        public PublicIPAddressInfo PublicIPAddress { get; set; }
        public PublicIPPrefixInfo PublicIPPrefix { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetInfo
    {
        public string Id { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo
    {
        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo
    {
        public string Id { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo
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

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTableInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo
    {
        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo
    {
        public string Id { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo
    {
        public IList<DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo
    {
        public string Id { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationInfo
    {
        public string Id { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo
    {
        public string ServiceName { get; set; }
    }

    public partial class PublicIPAddressPropertiesInfo
    {
        public string PublicIPAllocationMethod { get; set; }
        public string PublicIPAddressVersion { get; set; }
        public DnsSettingsInfo DnsSettings { get; set; }
        public DdosSettingsInfo DdosSettings { get; set; }
        public IList<IpTagInfo> IpTags { get; set; }
        public string IpAddress { get; set; }
        public PublicIPPrefixInfo PublicIPPrefix { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
    }

    public partial class DnsSettingsInfo
    {
        public string DomainNameLabel { get; set; }
        public string Fqdn { get; set; }
        public string ReverseFqdn { get; set; }
    }

    public partial class DdosSettingsInfo
    {
        public DdosCustomPolicyInfo DdosCustomPolicy { get; set; }
        public string ProtectionCoverage { get; set; }
        public bool? ProtectedIP { get; set; }
    }

    public partial class DdosCustomPolicyInfo
    {
        public string Id { get; set; }
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
        public ApplicationGatewayBackendAddressPoolPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ApplicationGatewayBackendAddressPoolPropertiesInfo
    {
        public IList<BackendAddresseInfo> BackendAddresses { get; set; }
    }

    public partial class LoadBalancerBackendAddressPoolInfo
    {
        public string Id { get; set; }
        public string Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class LoadBalancerInboundNatRuleInfo
    {
        public string Id { get; set; }
        public LoadBalancerInboundNatRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class LoadBalancerInboundNatRulePropertiesInfo
    {
        public FrontendIPConfigurationInfo FrontendIPConfiguration { get; set; }
        public string Protocol { get; set; }
        public int? FrontendPort { get; set; }
        public int? BackendPort { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
        public bool? EnableFloatingIP { get; set; }
        public bool? EnableTcpReset { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetInfo
    {
        public string Id { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo
    {
        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo
    {
        public string Id { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo
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

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo
    {
        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo
    {
        public string Id { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo
    {
        public IList<NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo
    {
        public string Id { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo
    {
        public string Id { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo
    {
        public string ServiceName { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesPublicIPAddressInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public SkuInfo Sku { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesInfo Properties { get; set; }
        public IList<string> Zones { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesInfo
    {
        public string PublicIPAllocationMethod { get; set; }
        public string PublicIPAddressVersion { get; set; }
        public DnsSettingsInfo DnsSettings { get; set; }
        public NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo DdosSettings { get; set; }
        public IList<IpTagInfo> IpTags { get; set; }
        public string IpAddress { get; set; }
        public PublicIPPrefixInfo PublicIPPrefix { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
    }

    public partial class NetworkInterfaceIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo
    {
        public DdosCustomPolicyInfo DdosCustomPolicy { get; set; }
        public string ProtectionCoverage { get; set; }
        public bool? ProtectedIP { get; set; }
    }

    public partial class ApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class LoadBalancerInboundNatRule : Resource<LoadBalancerInboundNatRuleProperties>
    {
        public LoadBalancerInboundNatRule() => (Type, ApiVersion) = ("Microsoft.Network/loadBalancers/inboundNatRules", "2020-04-01");
        public LoadBalancerInboundNatRule(string name) : this() => Name = name;
        public LoadBalancerInboundNatRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class LoadBalancerInboundNatRuleProperties
    {
        public FrontendIPConfigurationInfo FrontendIPConfiguration { get; set; }
        public string Protocol { get; set; }
        public int? FrontendPort { get; set; }
        public int? BackendPort { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
        public bool? EnableFloatingIP { get; set; }
        public bool? EnableTcpReset { get; set; }
    }

    public partial class LoadBalancer : Resource<LoadBalancerProperties>
    {
        public LoadBalancer() => (Type, ApiVersion) = ("Microsoft.Network/loadBalancers", "2020-04-01");
        public LoadBalancer(string name) : this() => Name = name;
        public LoadBalancer(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class LoadBalancerProperties
    {
        public IList<FrontendIPConfigurationInfo> FrontendIPConfigurations { get; set; }
        public IList<BackendAddressPoolInfo> BackendAddressPools { get; set; }
        public IList<LoadBalancingRuleInfo> LoadBalancingRules { get; set; }
        public IList<PropertiesProbeInfo> Probes { get; set; }
        public IList<InboundNatRuleInfo> InboundNatRules { get; set; }
        public IList<InboundNatPoolInfo> InboundNatPools { get; set; }
        public IList<OutboundRuleInfo> OutboundRules { get; set; }
    }

    public partial class LoadBalancerBackendAddressePropertiesInfo
    {
        public VirtualNetworkInfo VirtualNetwork { get; set; }
        public string IpAddress { get; set; }
        public NetworkInterfaceIPConfigurationInfo NetworkInterfaceIPConfiguration { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetInfo
    {
        public string Id { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesRouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<VirtualNetworkPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo
    {
        public IList<VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo
    {
        public string Id { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo
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

    public partial class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesRouteTableInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesInfo
    {
        public IList<VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo
    {
        public string Id { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo
    {
        public IList<VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo
    {
        public string Id { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesDelegationInfo
    {
        public string Id { get; set; }
        public VirtualNetworkPropertiesSubnetPropertiesDelegationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualNetworkPropertiesSubnetPropertiesDelegationPropertiesInfo
    {
        public string ServiceName { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public SkuInfo Sku { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesInfo Properties { get; set; }
        public IList<string> Zones { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesInfo
    {
        public string PublicIPAllocationMethod { get; set; }
        public string PublicIPAddressVersion { get; set; }
        public DnsSettingsInfo DnsSettings { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo DdosSettings { get; set; }
        public IList<IpTagInfo> IpTags { get; set; }
        public string IpAddress { get; set; }
        public PublicIPPrefixInfo PublicIPPrefix { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
    }

    public partial class DestinationLoadBalancerFrontEndIPConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo
    {
        public DdosCustomPolicyInfo DdosCustomPolicy { get; set; }
        public string ProtectionCoverage { get; set; }
        public bool? ProtectedIP { get; set; }
    }

    public partial class LoadBalancerInboundNatRulePropertiesFrontendIPConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class LoadBalancingRuleInfo
    {
        public string Id { get; set; }
        public LoadBalancingRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class LoadBalancingRulePropertiesInfo
    {
        public LoadBalancingRulePropertiesFrontendIPConfigurationInfo FrontendIPConfiguration { get; set; }
        public LoadBalancingRulePropertiesBackendAddressPoolInfo BackendAddressPool { get; set; }
        public ProbeInfo Probe { get; set; }
        public string Protocol { get; set; }
        public string LoadDistribution { get; set; }
        public int? FrontendPort { get; set; }
        public int? BackendPort { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
        public bool? EnableFloatingIP { get; set; }
        public bool? EnableTcpReset { get; set; }
        public bool? DisableOutboundSnat { get; set; }
    }

    public partial class LoadBalancingRulePropertiesFrontendIPConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class LoadBalancingRulePropertiesBackendAddressPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class PropertiesProbeInfo
    {
        public string Id { get; set; }
        public PropertiesProbePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesProbePropertiesInfo
    {
        public string Protocol { get; set; }
        public int? Port { get; set; }
        public int? IntervalInSeconds { get; set; }
        public int? NumberOfProbes { get; set; }
        public string RequestPath { get; set; }
    }

    public partial class InboundNatRuleInfo
    {
        public string Id { get; set; }
        public InboundNatRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class InboundNatRulePropertiesInfo
    {
        public InboundNatRulePropertiesFrontendIPConfigurationInfo FrontendIPConfiguration { get; set; }
        public string Protocol { get; set; }
        public int? FrontendPort { get; set; }
        public int? BackendPort { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
        public bool? EnableFloatingIP { get; set; }
        public bool? EnableTcpReset { get; set; }
    }

    public partial class InboundNatRulePropertiesFrontendIPConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class InboundNatPoolInfo
    {
        public string Id { get; set; }
        public InboundNatPoolPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class InboundNatPoolPropertiesInfo
    {
        public InboundNatPoolPropertiesFrontendIPConfigurationInfo FrontendIPConfiguration { get; set; }
        public string Protocol { get; set; }
        public int? FrontendPortRangeStart { get; set; }
        public int? FrontendPortRangeEnd { get; set; }
        public int? BackendPort { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
        public bool? EnableFloatingIP { get; set; }
        public bool? EnableTcpReset { get; set; }
    }

    public partial class InboundNatPoolPropertiesFrontendIPConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class OutboundRuleInfo
    {
        public string Id { get; set; }
        public OutboundRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class OutboundRulePropertiesInfo
    {
        public int? AllocatedOutboundPorts { get; set; }
        public IList<OutboundRulePropertiesFrontendIPConfigurationInfo> FrontendIPConfigurations { get; set; }
        public OutboundRulePropertiesBackendAddressPoolInfo BackendAddressPool { get; set; }
        public string Protocol { get; set; }
        public bool? EnableTcpReset { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
    }

    public partial class OutboundRulePropertiesFrontendIPConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class OutboundRulePropertiesBackendAddressPoolInfo
    {
        public string Id { get; set; }
    }

    public partial class LocalNetworkGateway : Resource<LocalNetworkGatewayProperties>
    {
        public LocalNetworkGateway() => (Type, ApiVersion) = ("Microsoft.Network/localNetworkGateways", "2020-04-01");
        public LocalNetworkGateway(string name) : this() => Name = name;
        public LocalNetworkGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class LocalNetworkGatewayProperties
    {
        public LocalNetworkAddressSpaceInfo LocalNetworkAddressSpace { get; set; }
        public string GatewayIpAddress { get; set; }
        public string Fqdn { get; set; }
        public BgpSettingsInfo BgpSettings { get; set; }
    }

    public partial class NatGateway : Resource<NatGatewayProperties>
    {
        public NatGateway() => (Type, ApiVersion) = ("Microsoft.Network/natGateways", "2020-04-01");
        public NatGateway(string name) : this() => Name = name;
        public NatGateway(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }
    }

    public partial class NatGatewayProperties
    {
        public int? IdleTimeoutInMinutes { get; set; }
        public IList<PublicIpAddresseInfo> PublicIpAddresses { get; set; }
        public IList<PublicIpPrefixeInfo> PublicIpPrefixes { get; set; }
    }

    public partial class PublicIpAddresseInfo
    {
        public string Id { get; set; }
    }

    public partial class PublicIpPrefixeInfo
    {
        public string Id { get; set; }
    }

    public partial class NetworkInterfaceTapConfiguration : Resource<NetworkInterfaceTapConfigurationProperties>
    {
        public NetworkInterfaceTapConfiguration() => (Type, ApiVersion) = ("Microsoft.Network/networkInterfaces/tapConfigurations", "2020-04-01");
        public NetworkInterfaceTapConfiguration(string name) : this() => Name = name;
        public NetworkInterfaceTapConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkInterfaceTapConfigurationProperties
    {
        public VirtualNetworkTapInfo VirtualNetworkTap { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationInfo
    {
        public string Id { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesInfo
    {
        public IList<string> VirtualNetworkTaps { get; set; }
        public IList<ApplicationGatewayBackendAddressPoolInfo> ApplicationGatewayBackendAddressPools { get; set; }
        public IList<LoadBalancerBackendAddressPoolInfo> LoadBalancerBackendAddressPools { get; set; }
        public IList<LoadBalancerInboundNatRuleInfo> LoadBalancerInboundNatRules { get; set; }
        public string PrivateIPAddress { get; set; }
        public string PrivateIPAllocationMethod { get; set; }
        public string PrivateIPAddressVersion { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetInfo Subnet { get; set; }
        public bool? Primary { get; set; }
        public PublicIPAddressInfo PublicIPAddress { get; set; }
        public IList<ApplicationSecurityGroupInfo> ApplicationSecurityGroups { get; set; }
    }

    public partial class LoadBalancerBackendAddressPoolPropertiesInfo
    {
        public IList<LoadBalancerBackendAddresseInfo> LoadBalancerBackendAddresses { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetInfo
    {
        public string Id { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo
    {
        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo
    {
        public string Id { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo
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

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTableInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo
    {
        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo
    {
        public string Id { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo
    {
        public IList<DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo
    {
        public string Id { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationInfo
    {
        public string Id { get; set; }
        public DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class DestinationNetworkInterfaceIPConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo
    {
        public string ServiceName { get; set; }
    }

    public partial class NetworkInterface : Resource<NetworkInterfaceProperties>
    {
        public NetworkInterface() => (Type, ApiVersion) = ("Microsoft.Network/networkInterfaces", "2020-04-01");
        public NetworkInterface(string name) : this() => Name = name;
        public NetworkInterface(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkInterfaceProperties
    {
        public NetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public IList<IpConfigurationInfo> IpConfigurations { get; set; }
        public PropertiesDnsSettingsInfo DnsSettings { get; set; }
        public bool? EnableAcceleratedNetworking { get; set; }
        public bool? EnableIPForwarding { get; set; }
    }

    public partial class SubnetPropertiesNetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public SubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class SubnetPropertiesNetworkSecurityGroupPropertiesInfo
    {
        public IList<SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo
    {
        public string Id { get; set; }
        public SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo
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

    public partial class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class SubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetInfo
    {
        public string Id { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesRouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<IpConfigurationPropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo
    {
        public IList<IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo
    {
        public string Id { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo
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

    public partial class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesRouteTableInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo Properties { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesInfo
    {
        public IList<IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRouteInfo
    {
        public string Id { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo
    {
        public IList<IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo
    {
        public string Id { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesDelegationInfo
    {
        public string Id { get; set; }
        public IpConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class IpConfigurationPropertiesSubnetPropertiesDelegationPropertiesInfo
    {
        public string ServiceName { get; set; }
    }

    public partial class IpConfigurationPropertiesPublicIPAddressInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public SkuInfo Sku { get; set; }
        public IpConfigurationPropertiesPublicIPAddressPropertiesInfo Properties { get; set; }
        public IList<string> Zones { get; set; }
    }

    public partial class IpConfigurationPropertiesPublicIPAddressPropertiesInfo
    {
        public string PublicIPAllocationMethod { get; set; }
        public string PublicIPAddressVersion { get; set; }
        public DnsSettingsInfo DnsSettings { get; set; }
        public IpConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo DdosSettings { get; set; }
        public IList<IpTagInfo> IpTags { get; set; }
        public string IpAddress { get; set; }
        public PublicIPPrefixInfo PublicIPPrefix { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
    }

    public partial class IpConfigurationPropertiesPublicIPAddressPropertiesDdosSettingsInfo
    {
        public DdosCustomPolicyInfo DdosCustomPolicy { get; set; }
        public string ProtectionCoverage { get; set; }
        public bool? ProtectedIP { get; set; }
    }

    public partial class PropertiesDnsSettingsInfo
    {
        public IList<string> DnsServers { get; set; }
        public string InternalDnsNameLabel { get; set; }
    }

    public partial class NetworkProfile : Resource<NetworkProfileProperties>
    {
        public NetworkProfile() => (Type, ApiVersion) = ("Microsoft.Network/networkProfiles", "2020-04-01");
        public NetworkProfile(string name) : this() => Name = name;
        public NetworkProfile(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkProfileProperties
    {
        public IList<ContainerNetworkInterfaceConfigurationInfo> ContainerNetworkInterfaceConfigurations { get; set; }
    }

    public partial class ContainerNetworkInterfaceConfigurationInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ContainerNetworkInterfaceInfo
    {
        public string Id { get; set; }
    }

    public partial class NetworkSecurityGroupSecurityRule : Resource<NetworkSecurityGroupSecurityRuleProperties>
    {
        public NetworkSecurityGroupSecurityRule() => (Type, ApiVersion) = ("Microsoft.Network/networkSecurityGroups/securityRules", "2020-04-01");
        public NetworkSecurityGroupSecurityRule(string name) : this() => Name = name;
        public NetworkSecurityGroupSecurityRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkSecurityGroupSecurityRuleProperties
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

    public partial class NetworkSecurityGroup : Resource<NetworkSecurityGroupProperties>
    {
        public NetworkSecurityGroup() => (Type, ApiVersion) = ("Microsoft.Network/networkSecurityGroups", "2020-04-01");
        public NetworkSecurityGroup(string name) : this() => Name = name;
        public NetworkSecurityGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkSecurityGroupProperties
    {
        public IList<SecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class NetworkVirtualAppliance : Resource<NetworkVirtualApplianceProperties>
    {
        public NetworkVirtualAppliance() => (Type, ApiVersion) = ("Microsoft.Network/networkVirtualAppliances", "2020-04-01");
        public NetworkVirtualAppliance(string name) : this() => Name = name;
        public NetworkVirtualAppliance(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class NetworkVirtualApplianceProperties
    {
        public IList<string> BootStrapConfigurationBlob { get; set; }
        public VirtualHubInfo VirtualHub { get; set; }
        public IList<string> CloudInitConfigurationBlob { get; set; }
        public int? VirtualApplianceAsn { get; set; }
    }

    public partial class NetworkWatcherConnectionMonitor : Resource<NetworkWatcherConnectionMonitorProperties>
    {
        public NetworkWatcherConnectionMonitor() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers/connectionMonitors", "2020-04-01");
        public NetworkWatcherConnectionMonitor(string name) : this() => Name = name;
        public NetworkWatcherConnectionMonitor(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkWatcherConnectionMonitorProperties
    {
        public SourceInfo Source { get; set; }
        public DestinationInfo Destination { get; set; }
        public bool? AutoStart { get; set; }
        public int? MonitoringIntervalInSeconds { get; set; }
        public IList<EndpointInfo> Endpoints { get; set; }
        public IList<TestConfigurationInfo> TestConfigurations { get; set; }
        public IList<TestGroupInfo> TestGroups { get; set; }
        public IList<OutputInfo> Outputs { get; set; }
        public string Notes { get; set; }
    }

    public partial class SourceInfo
    {
        public string ResourceId { get; set; }
        public int? Port { get; set; }
    }

    public partial class DestinationInfo
    {
        public string ResourceId { get; set; }
        public string Address { get; set; }
        public int? Port { get; set; }
    }

    public partial class EndpointInfo
    {
        public string Name { get; set; }
        public string ResourceId { get; set; }
        public string Address { get; set; }
        public FilterInfo Filter { get; set; }
    }

    public partial class FilterInfo
    {
        public string Type { get; set; }
        public IList<ItemInfo> Items { get; set; }
    }

    public partial class ItemInfo
    {
        public string Type { get; set; }
        public string Address { get; set; }
    }

    public partial class TestConfigurationInfo
    {
        public string Name { get; set; }
        public int? TestFrequencySec { get; set; }
        public string Protocol { get; set; }
        public string PreferredIPVersion { get; set; }
        public HttpConfigurationInfo HttpConfiguration { get; set; }
        public TcpConfigurationInfo TcpConfiguration { get; set; }
        public IcmpConfigurationInfo IcmpConfiguration { get; set; }
        public SuccessThresholdInfo SuccessThreshold { get; set; }
    }

    public partial class HttpConfigurationInfo
    {
        public int? Port { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public IList<RequestHeaderInfo> RequestHeaders { get; set; }
        public IList<string> ValidStatusCodeRanges { get; set; }
        public bool? PreferHTTPS { get; set; }
    }

    public partial class RequestHeaderInfo
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public partial class TcpConfigurationInfo
    {
        public int? Port { get; set; }
        public bool? DisableTraceRoute { get; set; }
    }

    public partial class IcmpConfigurationInfo
    {
        public bool? DisableTraceRoute { get; set; }
    }

    public partial class SuccessThresholdInfo
    {
        public int? ChecksFailedPercent { get; set; }
        public string RoundTripTimeMs { get; set; }
    }

    public partial class TestGroupInfo
    {
        public string Name { get; set; }
        public bool? Disable { get; set; }
        public IList<string> TestConfigurations { get; set; }
        public IList<string> Sources { get; set; }
        public IList<string> Destinations { get; set; }
    }

    public partial class OutputInfo
    {
        public string Type { get; set; }
        public WorkspaceSettingsInfo WorkspaceSettings { get; set; }
    }

    public partial class WorkspaceSettingsInfo
    {
        public string WorkspaceResourceId { get; set; }
    }

    public partial class NetworkWatcherFlowLog : Resource<NetworkWatcherFlowLogProperties>
    {
        public NetworkWatcherFlowLog() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers/flowLogs", "2020-04-01");
        public NetworkWatcherFlowLog(string name) : this() => Name = name;
        public NetworkWatcherFlowLog(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkWatcherFlowLogProperties
    {
        public string TargetResourceId { get; set; }
        public string StorageId { get; set; }
        public bool? Enabled { get; set; }
        public RetentionPolicyInfo RetentionPolicy { get; set; }
        public FormatInfo Format { get; set; }
        public FlowAnalyticsConfigurationInfo FlowAnalyticsConfiguration { get; set; }
    }

    public partial class RetentionPolicyInfo
    {
        public int? Days { get; set; }
        public bool? Enabled { get; set; }
    }

    public partial class FormatInfo
    {
        public string Type { get; set; }
        public int? Version { get; set; }
    }

    public partial class FlowAnalyticsConfigurationInfo
    {
        public NetworkWatcherFlowAnalyticsConfigurationInfo NetworkWatcherFlowAnalyticsConfiguration { get; set; }
    }

    public partial class NetworkWatcherFlowAnalyticsConfigurationInfo
    {
        public bool? Enabled { get; set; }
        public string WorkspaceId { get; set; }
        public string WorkspaceRegion { get; set; }
        public string WorkspaceResourceId { get; set; }
        public int? TrafficAnalyticsInterval { get; set; }
    }

    public partial class NetworkWatcherPacketCapture : Resource<NetworkWatcherPacketCaptureProperties>
    {
        public NetworkWatcherPacketCapture() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers/packetCaptures", "2020-04-01");
        public NetworkWatcherPacketCapture(string name) : this() => Name = name;
        public NetworkWatcherPacketCapture(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkWatcherPacketCaptureProperties
    {
        public string Target { get; set; }
        public int? BytesToCapturePerPacket { get; set; }
        public int? TotalBytesPerSession { get; set; }
        public int? TimeLimitInSeconds { get; set; }
        public StorageLocationInfo StorageLocation { get; set; }
        public IList<FilterInfo> Filters { get; set; }
    }

    public partial class StorageLocationInfo
    {
        public string StorageId { get; set; }
        public string StoragePath { get; set; }
        public string FilePath { get; set; }
    }

    public partial class NetworkWatcher : Resource<NetworkWatcherProperties>
    {
        public NetworkWatcher() => (Type, ApiVersion) = ("Microsoft.Network/networkWatchers", "2020-04-01");
        public NetworkWatcher(string name) : this() => Name = name;
        public NetworkWatcher(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NetworkWatcherProperties
    {
    }

    public partial class P2svpnGateway : Resource<P2svpnGatewayProperties>
    {
        public P2svpnGateway() => (Type, ApiVersion) = ("Microsoft.Network/p2svpnGateways", "2020-04-01");
        public P2svpnGateway(string name) : this() => Name = name;
        public P2svpnGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class P2svpnGatewayProperties
    {
        public VirtualHubInfo VirtualHub { get; set; }
        public IList<P2SConnectionConfigurationInfo> P2SConnectionConfigurations { get; set; }
        public int? VpnGatewayScaleUnit { get; set; }
        public VpnServerConfigurationInfo VpnServerConfiguration { get; set; }
        public IList<string> CustomDnsServers { get; set; }
    }

    public partial class P2SConnectionConfigurationInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VpnServerConfigurationInfo
    {
        public string Id { get; set; }
    }

    public partial class PrivateEndpointPrivateDnsZoneGroup : Resource<PrivateEndpointPrivateDnsZoneGroupProperties>
    {
        public PrivateEndpointPrivateDnsZoneGroup() => (Type, ApiVersion) = ("Microsoft.Network/privateEndpoints/privateDnsZoneGroups", "2020-04-01");
        public PrivateEndpointPrivateDnsZoneGroup(string name) : this() => Name = name;
        public PrivateEndpointPrivateDnsZoneGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class PrivateEndpointPrivateDnsZoneGroupProperties
    {
        public IList<PrivateDnsZoneConfigInfo> PrivateDnsZoneConfigs { get; set; }
    }

    public partial class PrivateDnsZoneConfigInfo
    {
        public string Name { get; set; }
        public PropertiesInfo Properties { get; set; }
    }

    public partial class PrivateEndpoint : Resource<PrivateEndpointProperties>
    {
        public PrivateEndpoint() => (Type, ApiVersion) = ("Microsoft.Network/privateEndpoints", "2020-04-01");
        public PrivateEndpoint(string name) : this() => Name = name;
        public PrivateEndpoint(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class PrivateEndpointProperties
    {
        public SubnetInfo Subnet { get; set; }
        public IList<PrivateLinkServiceConnectionInfo> PrivateLinkServiceConnections { get; set; }
        public IList<ManualPrivateLinkServiceConnectionInfo> ManualPrivateLinkServiceConnections { get; set; }
        public IList<CustomDnsConfigInfo> CustomDnsConfigs { get; set; }
    }

    public partial class PrivateLinkServiceConnectionInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PrivateLinkServiceConnectionStateInfo
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public string ActionsRequired { get; set; }
    }

    public partial class ManualPrivateLinkServiceConnectionInfo
    {
        public string Id { get; set; }
        public ManualPrivateLinkServiceConnectionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class ManualPrivateLinkServiceConnectionPropertiesInfo
    {
        public string PrivateLinkServiceId { get; set; }
        public IList<string> GroupIds { get; set; }
        public string RequestMessage { get; set; }
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState { get; set; }
    }

    public partial class CustomDnsConfigInfo
    {
        public string Fqdn { get; set; }
        public IList<string> IpAddresses { get; set; }
    }

    public partial class PrivateLinkServicePrivateEndpointConnection : Resource<PrivateLinkServicePrivateEndpointConnectionProperties>
    {
        public PrivateLinkServicePrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.Network/privateLinkServices/privateEndpointConnections", "2020-04-01");
        public PrivateLinkServicePrivateEndpointConnection(string name) : this() => Name = name;
        public PrivateLinkServicePrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class PrivateLinkServicePrivateEndpointConnectionProperties
    {
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState { get; set; }
    }

    public partial class PrivateLinkService : Resource<PrivateLinkServiceProperties>
    {
        public PrivateLinkService() => (Type, ApiVersion) = ("Microsoft.Network/privateLinkServices", "2020-04-01");
        public PrivateLinkService(string name) : this() => Name = name;
        public PrivateLinkService(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class PrivateLinkServiceProperties
    {
        public IList<LoadBalancerFrontendIpConfigurationInfo> LoadBalancerFrontendIpConfigurations { get; set; }
        public IList<IpConfigurationInfo> IpConfigurations { get; set; }
        public VisibilityInfo Visibility { get; set; }
        public AutoApprovalInfo AutoApproval { get; set; }
        public IList<string> Fqdns { get; set; }
        public bool? EnableProxyProtocol { get; set; }
    }

    public partial class LoadBalancerFrontendIpConfigurationInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
        public IList<string> Zones { get; set; }
    }

    public partial class VisibilityInfo
    {
        public IList<string> Subscriptions { get; set; }
    }

    public partial class AutoApprovalInfo
    {
        public IList<string> Subscriptions { get; set; }
    }

    public partial class PublicIPAddresse : Resource<PublicIPAddresseProperties>
    {
        public PublicIPAddresse() => (Type, ApiVersion) = ("Microsoft.Network/publicIPAddresses", "2020-04-01");
        public PublicIPAddresse(string name) : this() => Name = name;
        public PublicIPAddresse(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }
    }

    public partial class PublicIPAddresseProperties
    {
        public string PublicIPAllocationMethod { get; set; }
        public string PublicIPAddressVersion { get; set; }
        public DnsSettingsInfo DnsSettings { get; set; }
        public DdosSettingsInfo DdosSettings { get; set; }
        public IList<IpTagInfo> IpTags { get; set; }
        public string IpAddress { get; set; }
        public PublicIPPrefixInfo PublicIPPrefix { get; set; }
        public int? IdleTimeoutInMinutes { get; set; }
    }

    public partial class PublicIPPrefixe : Resource<PublicIPPrefixeProperties>
    {
        public PublicIPPrefixe() => (Type, ApiVersion) = ("Microsoft.Network/publicIPPrefixes", "2020-04-01");
        public PublicIPPrefixe(string name) : this() => Name = name;
        public PublicIPPrefixe(string name, Location location) : this() => (Name, Location) = (name, location);

        public IList<string> Zones { get; set; }
    }

    public partial class PublicIPPrefixeProperties
    {
        public string PublicIPAddressVersion { get; set; }
        public IList<IpTagInfo> IpTags { get; set; }
        public int? PrefixLength { get; set; }
    }

    public partial class RouteFilterRouteFilterRule : Resource<RouteFilterRouteFilterRuleProperties>
    {
        public RouteFilterRouteFilterRule() => (Type, ApiVersion) = ("Microsoft.Network/routeFilters/routeFilterRules", "2020-04-01");
        public RouteFilterRouteFilterRule(string name) : this() => Name = name;
        public RouteFilterRouteFilterRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class RouteFilterRouteFilterRuleProperties
    {
        public string Access { get; set; }
        public string RouteFilterRuleType { get; set; }
        public IList<string> Communities { get; set; }
    }

    public partial class RouteFilter : Resource<RouteFilterProperties>
    {
        public RouteFilter() => (Type, ApiVersion) = ("Microsoft.Network/routeFilters", "2020-04-01");
        public RouteFilter(string name) : this() => Name = name;
        public RouteFilter(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class RouteFilterProperties
    {
        public IList<RuleInfo> Rules { get; set; }
    }

    public partial class RouteTableRoute : Resource<RouteTableRouteProperties>
    {
        public RouteTableRoute() => (Type, ApiVersion) = ("Microsoft.Network/routeTables/routes", "2020-04-01");
        public RouteTableRoute(string name) : this() => Name = name;
        public RouteTableRoute(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class RouteTableRouteProperties
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class RouteTable : Resource<RouteTableProperties>
    {
        public RouteTable() => (Type, ApiVersion) = ("Microsoft.Network/routeTables", "2020-04-01");
        public RouteTable(string name) : this() => Name = name;
        public RouteTable(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class RouteTableProperties
    {
        public IList<RouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class SecurityPartnerProvider : Resource<SecurityPartnerProviderProperties>
    {
        public SecurityPartnerProvider() => (Type, ApiVersion) = ("Microsoft.Network/securityPartnerProviders", "2020-04-01");
        public SecurityPartnerProvider(string name) : this() => Name = name;
        public SecurityPartnerProvider(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class SecurityPartnerProviderProperties
    {
        public string SecurityProviderName { get; set; }
        public VirtualHubInfo VirtualHub { get; set; }
    }

    public partial class ServiceEndpointPolicyServiceEndpointPolicyDefinition : Resource<ServiceEndpointPolicyServiceEndpointPolicyDefinitionProperties>
    {
        public ServiceEndpointPolicyServiceEndpointPolicyDefinition() => (Type, ApiVersion) = ("Microsoft.Network/serviceEndpointPolicies/serviceEndpointPolicyDefinitions", "2020-04-01");
        public ServiceEndpointPolicyServiceEndpointPolicyDefinition(string name) : this() => Name = name;
        public ServiceEndpointPolicyServiceEndpointPolicyDefinition(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServiceEndpointPolicyServiceEndpointPolicyDefinitionProperties
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class ServiceEndpointPolicy : Resource<ServiceEndpointPolicyProperties>
    {
        public ServiceEndpointPolicy() => (Type, ApiVersion) = ("Microsoft.Network/serviceEndpointPolicies", "2020-04-01");
        public ServiceEndpointPolicy(string name) : this() => Name = name;
        public ServiceEndpointPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ServiceEndpointPolicyProperties
    {
        public IList<ServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class VirtualHubHubRouteTable : Resource<VirtualHubHubRouteTableProperties>
    {
        public VirtualHubHubRouteTable() => (Type, ApiVersion) = ("Microsoft.Network/virtualHubs/hubRouteTables", "2020-04-01");
        public VirtualHubHubRouteTable(string name) : this() => Name = name;
        public VirtualHubHubRouteTable(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualHubHubRouteTableProperties
    {
        public IList<RouteInfo> Routes { get; set; }
        public IList<string> Labels { get; set; }
    }

    public partial class VirtualHubRouteTable : Resource<VirtualHubRouteTableProperties>
    {
        public VirtualHubRouteTable() => (Type, ApiVersion) = ("Microsoft.Network/virtualHubs/routeTables", "2020-04-01");
        public VirtualHubRouteTable(string name) : this() => Name = name;
        public VirtualHubRouteTable(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualHubRouteTableProperties
    {
        public IList<RouteInfo> Routes { get; set; }
        public IList<string> AttachedConnections { get; set; }
    }

    public partial class VirtualHub : Resource<VirtualHubProperties>
    {
        public VirtualHub() => (Type, ApiVersion) = ("Microsoft.Network/virtualHubs", "2020-04-01");
        public VirtualHub(string name) : this() => Name = name;
        public VirtualHub(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualHubProperties
    {
        public VirtualWanInfo VirtualWan { get; set; }
        public VpnGatewayInfo VpnGateway { get; set; }
        public P2SVpnGatewayInfo P2SVpnGateway { get; set; }
        public ExpressRouteGatewayInfo ExpressRouteGateway { get; set; }
        public AzureFirewallInfo AzureFirewall { get; set; }
        public SecurityPartnerProviderInfo SecurityPartnerProvider { get; set; }
        public IList<VirtualNetworkConnectionInfo> VirtualNetworkConnections { get; set; }
        public string AddressPrefix { get; set; }
        public RouteTableInfo RouteTable { get; set; }
        public string SecurityProviderName { get; set; }
        public IList<VirtualHubRouteTableV2Info> VirtualHubRouteTableV2s { get; set; }
        public string Sku { get; set; }
    }

    public partial class VirtualWanInfo
    {
        public string Id { get; set; }
    }

    public partial class VpnGatewayInfo
    {
        public string Id { get; set; }
    }

    public partial class P2SVpnGatewayInfo
    {
        public string Id { get; set; }
    }

    public partial class ExpressRouteGatewayInfo
    {
        public string Id { get; set; }
    }

    public partial class AzureFirewallInfo
    {
        public string Id { get; set; }
    }

    public partial class SecurityPartnerProviderInfo
    {
        public string Id { get; set; }
    }

    public partial class VirtualNetworkConnectionInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualHubRouteTableV2Info
    {
        public string Id { get; set; }
        public VirtualHubRouteTableV2PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VirtualHubRouteTableV2PropertiesInfo
    {
        public IList<VirtualHubRouteTableV2PropertiesRouteInfo> Routes { get; set; }
        public IList<string> AttachedConnections { get; set; }
    }

    public partial class VirtualHubRouteTableV2PropertiesRouteInfo
    {
        public string DestinationType { get; set; }
        public IList<string> Destinations { get; set; }
        public string NextHopType { get; set; }
        public IList<string> NextHops { get; set; }
    }

    public partial class VirtualNetworkGateway : Resource<VirtualNetworkGatewayProperties>
    {
        public VirtualNetworkGateway() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworkGateways", "2020-04-01");
        public VirtualNetworkGateway(string name) : this() => Name = name;
        public VirtualNetworkGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualNetworkGatewayProperties
    {
        public IList<IpConfigurationInfo> IpConfigurations { get; set; }
        public string GatewayType { get; set; }
        public string VpnType { get; set; }
        public string VpnGatewayGeneration { get; set; }
        public bool? EnableBgp { get; set; }
        public bool? EnablePrivateIpAddress { get; set; }
        public bool? ActiveActive { get; set; }
        public GatewayDefaultSiteInfo GatewayDefaultSite { get; set; }
        public SkuInfo Sku { get; set; }
        public VpnClientConfigurationInfo VpnClientConfiguration { get; set; }
        public BgpSettingsInfo BgpSettings { get; set; }
        public CustomRoutesInfo CustomRoutes { get; set; }
        public bool? EnableDnsForwarding { get; set; }
    }

    public partial class VirtualNetworkSubnet : Resource<VirtualNetworkSubnetProperties>
    {
        public VirtualNetworkSubnet() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworks/subnets", "2020-04-01");
        public VirtualNetworkSubnet(string name) : this() => Name = name;
        public VirtualNetworkSubnet(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualNetworkSubnetProperties
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public NetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public RouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<ServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<DelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class VirtualNetworkVirtualNetworkPeering : Resource<VirtualNetworkVirtualNetworkPeeringProperties>
    {
        public VirtualNetworkVirtualNetworkPeering() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworks/virtualNetworkPeerings", "2020-04-01");
        public VirtualNetworkVirtualNetworkPeering(string name) : this() => Name = name;
        public VirtualNetworkVirtualNetworkPeering(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualNetworkVirtualNetworkPeeringProperties
    {
        public bool? AllowVirtualNetworkAccess { get; set; }
        public bool? AllowForwardedTraffic { get; set; }
        public bool? AllowGatewayTransit { get; set; }
        public bool? UseRemoteGateways { get; set; }
        public RemoteVirtualNetworkInfo RemoteVirtualNetwork { get; set; }
        public RemoteAddressSpaceInfo RemoteAddressSpace { get; set; }
        public string PeeringState { get; set; }
    }

    public partial class VirtualNetwork : Resource<VirtualNetworkProperties>
    {
        public VirtualNetwork() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworks", "2020-04-01");
        public VirtualNetwork(string name) : this() => Name = name;
        public VirtualNetwork(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualNetworkProperties
    {
        public AddressSpaceInfo AddressSpace { get; set; }
        public DhcpOptionsInfo DhcpOptions { get; set; }
        public IList<SubnetInfo> Subnets { get; set; }
        public IList<VirtualNetworkPeeringInfo> VirtualNetworkPeerings { get; set; }
        public bool? EnableDdosProtection { get; set; }
        public bool? EnableVmProtection { get; set; }
        public DdosProtectionPlanInfo DdosProtectionPlan { get; set; }
        public BgpCommunitiesInfo BgpCommunities { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
    }

    public partial class VirtualNetworkTap : Resource<VirtualNetworkTapProperties>
    {
        public VirtualNetworkTap() => (Type, ApiVersion) = ("Microsoft.Network/virtualNetworkTaps", "2020-04-01");
        public VirtualNetworkTap(string name) : this() => Name = name;
        public VirtualNetworkTap(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualNetworkTapProperties
    {
        public DestinationNetworkInterfaceIPConfigurationInfo DestinationNetworkInterfaceIPConfiguration { get; set; }
        public DestinationLoadBalancerFrontEndIPConfigurationInfo DestinationLoadBalancerFrontEndIPConfiguration { get; set; }
        public int? DestinationPort { get; set; }
    }

    public partial class PropertiesSubnetInfo
    {
        public string Id { get; set; }
        public PropertiesSubnetPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesSubnetPropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public IList<string> AddressPrefixes { get; set; }
        public PropertiesSubnetPropertiesNetworkSecurityGroupInfo NetworkSecurityGroup { get; set; }
        public PropertiesSubnetPropertiesRouteTableInfo RouteTable { get; set; }
        public NatGatewayInfo NatGateway { get; set; }
        public IList<ServiceEndpointInfo> ServiceEndpoints { get; set; }
        public IList<PropertiesSubnetPropertiesServiceEndpointPolicyInfo> ServiceEndpointPolicies { get; set; }
        public IList<IpAllocationInfo> IpAllocations { get; set; }
        public IList<PropertiesSubnetPropertiesDelegationInfo> Delegations { get; set; }
        public string PrivateEndpointNetworkPolicies { get; set; }
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }

    public partial class PropertiesSubnetPropertiesNetworkSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo Properties { get; set; }
    }

    public partial class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesInfo
    {
        public IList<PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo> SecurityRules { get; set; }
    }

    public partial class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRuleInfo
    {
        public string Id { get; set; }
        public PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesInfo
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

    public partial class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesSourceApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class PropertiesSubnetPropertiesNetworkSecurityGroupPropertiesSecurityRulePropertiesDestinationApplicationSecurityGroupInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public object Properties { get; set; }
    }

    public partial class PropertiesSubnetPropertiesRouteTableInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public PropertiesSubnetPropertiesRouteTablePropertiesInfo Properties { get; set; }
    }

    public partial class PropertiesSubnetPropertiesRouteTablePropertiesInfo
    {
        public IList<PropertiesSubnetPropertiesRouteTablePropertiesRouteInfo> Routes { get; set; }
        public bool? DisableBgpRoutePropagation { get; set; }
    }

    public partial class PropertiesSubnetPropertiesRouteTablePropertiesRouteInfo
    {
        public string Id { get; set; }
        public PropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesSubnetPropertiesRouteTablePropertiesRoutePropertiesInfo
    {
        public string AddressPrefix { get; set; }
        public string NextHopType { get; set; }
        public string NextHopIpAddress { get; set; }
    }

    public partial class PropertiesSubnetPropertiesServiceEndpointPolicyInfo
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public object Tags { get; set; }
        public PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo Properties { get; set; }
    }

    public partial class PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesInfo
    {
        public IList<PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo> ServiceEndpointPolicyDefinitions { get; set; }
    }

    public partial class PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionInfo
    {
        public string Id { get; set; }
        public PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesSubnetPropertiesServiceEndpointPolicyPropertiesServiceEndpointPolicyDefinitionPropertiesInfo
    {
        public string Description { get; set; }
        public string Service { get; set; }
        public IList<string> ServiceResources { get; set; }
    }

    public partial class PropertiesSubnetPropertiesDelegationInfo
    {
        public string Id { get; set; }
        public PropertiesSubnetPropertiesDelegationPropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class PropertiesSubnetPropertiesDelegationPropertiesInfo
    {
        public string ServiceName { get; set; }
    }

    public partial class VirtualRouterPeering : Resource<VirtualRouterPeeringProperties>
    {
        public VirtualRouterPeering() => (Type, ApiVersion) = ("Microsoft.Network/virtualRouters/peerings", "2020-04-01");
        public VirtualRouterPeering(string name) : this() => Name = name;
        public VirtualRouterPeering(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualRouterPeeringProperties
    {
        public int? PeerAsn { get; set; }
        public string PeerIp { get; set; }
    }

    public partial class VirtualRouter : Resource<VirtualRouterProperties>
    {
        public VirtualRouter() => (Type, ApiVersion) = ("Microsoft.Network/virtualRouters", "2020-04-01");
        public VirtualRouter(string name) : this() => Name = name;
        public VirtualRouter(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualRouterProperties
    {
        public int? VirtualRouterAsn { get; set; }
        public IList<string> VirtualRouterIps { get; set; }
        public HostedSubnetInfo HostedSubnet { get; set; }
        public HostedGatewayInfo HostedGateway { get; set; }
    }

    public partial class HostedSubnetInfo
    {
        public string Id { get; set; }
    }

    public partial class HostedGatewayInfo
    {
        public string Id { get; set; }
    }

    public partial class VirtualWanP2sVpnServerConfiguration : Resource<VirtualWanP2sVpnServerConfigurationProperties>
    {
        public VirtualWanP2sVpnServerConfiguration() => (Type, ApiVersion) = ("Microsoft.Network/virtualWans/p2sVpnServerConfigurations", "2019-07-01");
        public VirtualWanP2sVpnServerConfiguration(string name) : this() => Name = name;
        public VirtualWanP2sVpnServerConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualWanP2sVpnServerConfigurationProperties
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

    public partial class P2SVpnServerConfigVpnClientRootCertificateInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class P2SVpnServerConfigVpnClientRevokedCertificateInfo
    {
        public string Id { get; set; }
        public P2SVpnServerConfigVpnClientRevokedCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class P2SVpnServerConfigVpnClientRevokedCertificatePropertiesInfo
    {
        public string Thumbprint { get; set; }
    }

    public partial class P2SVpnServerConfigRadiusServerRootCertificateInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class P2SVpnServerConfigRadiusClientRootCertificateInfo
    {
        public string Id { get; set; }
        public P2SVpnServerConfigRadiusClientRootCertificatePropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class P2SVpnServerConfigRadiusClientRootCertificatePropertiesInfo
    {
        public string Thumbprint { get; set; }
    }

    public partial class VirtualWan : Resource<VirtualWanProperties>
    {
        public VirtualWan() => (Type, ApiVersion) = ("Microsoft.Network/virtualWans", "2020-04-01");
        public VirtualWan(string name) : this() => Name = name;
        public VirtualWan(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VirtualWanProperties
    {
        public bool? DisableVpnEncryption { get; set; }
        public bool? AllowBranchToBranchTraffic { get; set; }
        public bool? AllowVnetToVnetTraffic { get; set; }
        public string Office365LocalBreakoutCategory { get; set; }
        public string Type { get; set; }
    }

    public partial class VpnGatewayVpnConnection : Resource<VpnGatewayVpnConnectionProperties>
    {
        public VpnGatewayVpnConnection() => (Type, ApiVersion) = ("Microsoft.Network/vpnGateways/vpnConnections", "2020-04-01");
        public VpnGatewayVpnConnection(string name) : this() => Name = name;
        public VpnGatewayVpnConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VpnGatewayVpnConnectionProperties
    {
        public RemoteVpnSiteInfo RemoteVpnSite { get; set; }
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
        public RoutingConfigurationInfo RoutingConfiguration { get; set; }
    }

    public partial class RemoteVpnSiteInfo
    {
        public string Id { get; set; }
    }

    public partial class VpnLinkConnectionInfo
    {
        public string Id { get; set; }
        public PropertiesInfo Properties { get; set; }
        public string Name { get; set; }
    }

    public partial class VpnSiteLinkInfo
    {
        public string Id { get; set; }
    }

    public partial class VpnGateway : Resource<VpnGatewayProperties>
    {
        public VpnGateway() => (Type, ApiVersion) = ("Microsoft.Network/vpnGateways", "2020-04-01");
        public VpnGateway(string name) : this() => Name = name;
        public VpnGateway(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VpnGatewayProperties
    {
        public VirtualHubInfo VirtualHub { get; set; }
        public IList<ConnectionInfo> Connections { get; set; }
        public BgpSettingsInfo BgpSettings { get; set; }
        public int? VpnGatewayScaleUnit { get; set; }
    }

    public partial class VpnLinkConnectionPropertiesInfo
    {
        public VpnSiteLinkInfo VpnSiteLink { get; set; }
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

    public partial class VpnServerConfiguration : Resource<VpnServerConfigurationProperties>
    {
        public VpnServerConfiguration() => (Type, ApiVersion) = ("Microsoft.Network/vpnServerConfigurations", "2020-04-01");
        public VpnServerConfiguration(string name) : this() => Name = name;
        public VpnServerConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VpnServerConfigurationProperties
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
        public AadAuthenticationParametersInfo AadAuthenticationParameters { get; set; }
    }

    public partial class RadiusServerRootCertificateInfo
    {
        public string Name { get; set; }
        public string PublicCertData { get; set; }
    }

    public partial class RadiusClientRootCertificateInfo
    {
        public string Name { get; set; }
        public string Thumbprint { get; set; }
    }

    public partial class AadAuthenticationParametersInfo
    {
        public string AadTenant { get; set; }
        public string AadAudience { get; set; }
        public string AadIssuer { get; set; }
    }

    public partial class VpnSite : Resource<VpnSiteProperties>
    {
        public VpnSite() => (Type, ApiVersion) = ("Microsoft.Network/vpnSites", "2020-04-01");
        public VpnSite(string name) : this() => Name = name;
        public VpnSite(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VpnSiteProperties
    {
        public VirtualWanInfo VirtualWan { get; set; }
        public DevicePropertiesInfo DeviceProperties { get; set; }
        public string IpAddress { get; set; }
        public string SiteKey { get; set; }
        public AddressSpaceInfo AddressSpace { get; set; }
        public BgpPropertiesInfo BgpProperties { get; set; }
        public bool? IsSecuritySite { get; set; }
        public IList<VpnSiteLinkInfo> VpnSiteLinks { get; set; }
    }

    public partial class DevicePropertiesInfo
    {
        public string DeviceVendor { get; set; }
        public string DeviceModel { get; set; }
        public int? LinkSpeedInMbps { get; set; }
    }

    public partial class BgpPropertiesInfo
    {
        public int? Asn { get; set; }
        public string BgpPeeringAddress { get; set; }
        public int? PeerWeight { get; set; }
        public IList<BgpPeeringAddresseInfo> BgpPeeringAddresses { get; set; }
    }

    public partial class LinkPropertiesInfo
    {
        public string LinkProviderName { get; set; }
        public int? LinkSpeedInMbps { get; set; }
    }

    public partial class PropertiesBgpPropertiesInfo
    {
        public int? Asn { get; set; }
        public string BgpPeeringAddress { get; set; }
    }
}
