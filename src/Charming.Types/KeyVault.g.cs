namespace Charming.Types.KeyVault
{
    using Charming;
    using System.Collections.Generic;

    public partial class VaultAccessPolicy : Resource<VaultAccessPolicyProperties>
    {
        public VaultAccessPolicy() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/accessPolicies", "2019-09-01");
        public VaultAccessPolicy(string name) : this() => Name = name;
        public VaultAccessPolicy(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VaultAccessPolicyProperties
    {
        public IList<AccessPolicyInfo> AccessPolicies { get; set; }
    }

    public partial class AccessPolicyInfo
    {
        public string TenantId { get; set; }
        public string ObjectId { get; set; }
        public string ApplicationId { get; set; }
        public PermissionsInfo Permissions { get; set; }
    }

    public partial class PermissionsInfo
    {
        public IList<string> Keys { get; set; }
        public IList<string> Secrets { get; set; }
        public IList<string> Certificates { get; set; }
        public IList<string> Storage { get; set; }
    }

    public partial class VaultPrivateEndpointConnection : Resource<VaultPrivateEndpointConnectionProperties>
    {
        public VaultPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/privateEndpointConnections", "2019-09-01");
        public VaultPrivateEndpointConnection(string name) : this() => Name = name;
        public VaultPrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VaultPrivateEndpointConnectionProperties
    {
        public object PrivateEndpoint { get; set; }
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState { get; set; }
    }

    public partial class PrivateLinkServiceConnectionStateInfo
    {
        public string Status { get; set; }
        public string Description { get; set; }
        public string ActionRequired { get; set; }
    }

    public partial class VaultSecret : Resource<VaultSecretProperties>
    {
        public VaultSecret() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/secrets", "2019-09-01");
        public VaultSecret(string name) : this() => Name = name;
        public VaultSecret(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VaultSecretProperties
    {
        public string Value { get; set; }
        public string ContentType { get; set; }
        public AttributesInfo Attributes { get; set; }
    }

    public partial class AttributesInfo
    {
        public bool? Enabled { get; set; }
        public int? Nbf { get; set; }
        public int? Exp { get; set; }
    }

    public partial class Vault : Resource<VaultProperties>
    {
        public Vault() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults", "2019-09-01");
        public Vault(string name) : this() => Name = name;
        public Vault(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class VaultProperties
    {
        public string TenantId { get; set; }
        public SkuInfo Sku { get; set; }
        public IList<AccessPolicyInfo> AccessPolicies { get; set; }
        public string VaultUri { get; set; }
        public bool? EnabledForDeployment { get; set; }
        public bool? EnabledForDiskEncryption { get; set; }
        public bool? EnabledForTemplateDeployment { get; set; }
        public bool? EnableSoftDelete { get; set; }
        public int? SoftDeleteRetentionInDays { get; set; }
        public bool? EnableRbacAuthorization { get; set; }
        public string CreateMode { get; set; }
        public bool? EnablePurgeProtection { get; set; }
        public NetworkAclsInfo NetworkAcls { get; set; }
    }

    public partial class SkuInfo
    {
        public string Family { get; set; }
        public string Name { get; set; }
    }

    public partial class NetworkAclsInfo
    {
        public string Bypass { get; set; }
        public string DefaultAction { get; set; }
        public IList<IpRuleInfo> IpRules { get; set; }
        public IList<VirtualNetworkRuleInfo> VirtualNetworkRules { get; set; }
    }

    public partial class IpRuleInfo
    {
        public string Value { get; set; }
    }

    public partial class VirtualNetworkRuleInfo
    {
        public string Id { get; set; }
    }
}
