namespace Charming.Types.KeyVault
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class VaultAccessPolicy : Resource<VaultAccessPolicyProperties>
    {
        public VaultAccessPolicy() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/accessPolicies", "2019-09-01");
        public VaultAccessPolicy(string name) : this() => Name = name;
        public VaultAccessPolicy(string name, Location location) : this() => (Name, Location) = (name, location);

        public VaultAccessPolicy WithProperties(Action<VaultAccessPolicyProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VaultAccessPolicyProperties : PropertyBase
    {

        public IList<AccessPolicyInfo> AccessPolicies { get; set; }
    }

    public class AccessPolicyInfo : PropertyBase
    {

        public string TenantId { get; set; }

        public string ObjectId { get; set; }

        public string ApplicationId { get; set; }

        private PermissionsInfo _permissions;
        public PermissionsInfo Permissions
        {
            get => _permissions = Get(_permissions);
            set => _permissions = value;
        }
    }

    public class PermissionsInfo : PropertyBase
    {

        public IList<string> Keys { get; set; }

        public IList<string> Secrets { get; set; }

        public IList<string> Certificates { get; set; }

        public IList<string> Storage { get; set; }
    }

    public class VaultPrivateEndpointConnection : Resource<VaultPrivateEndpointConnectionProperties>
    {
        public VaultPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/privateEndpointConnections", "2019-09-01");
        public VaultPrivateEndpointConnection(string name) : this() => Name = name;
        public VaultPrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public VaultPrivateEndpointConnection WithProperties(Action<VaultPrivateEndpointConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VaultPrivateEndpointConnectionProperties : PropertyBase
    {

        public object PrivateEndpoint { get; set; }

        private PrivateLinkServiceConnectionStateInfo _privateLinkServiceConnectionState;
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState
        {
            get => _privateLinkServiceConnectionState = Get(_privateLinkServiceConnectionState);
            set => _privateLinkServiceConnectionState = value;
        }
    }

    public class PrivateLinkServiceConnectionStateInfo : PropertyBase
    {

        public string Status { get; set; }

        public string Description { get; set; }

        public string ActionRequired { get; set; }
    }

    public class VaultSecret : Resource<VaultSecretProperties>
    {
        public VaultSecret() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/secrets", "2019-09-01");
        public VaultSecret(string name) : this() => Name = name;
        public VaultSecret(string name, Location location) : this() => (Name, Location) = (name, location);

        public VaultSecret WithProperties(Action<VaultSecretProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VaultSecretProperties : PropertyBase
    {

        public string Value { get; set; }

        public string ContentType { get; set; }

        private AttributesInfo _attributes;
        public AttributesInfo Attributes
        {
            get => _attributes = Get(_attributes);
            set => _attributes = value;
        }
    }

    public class AttributesInfo : PropertyBase
    {

        public bool? Enabled { get; set; }

        public int? Nbf { get; set; }

        public int? Exp { get; set; }
    }

    public class Vault : Resource<VaultProperties>
    {
        public Vault() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults", "2019-09-01");
        public Vault(string name) : this() => Name = name;
        public Vault(string name, Location location) : this() => (Name, Location) = (name, location);

        public Vault WithProperties(Action<VaultProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class VaultProperties : PropertyBase
    {

        public string TenantId { get; set; }

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

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

        private NetworkAclsInfo _networkAcls;
        public NetworkAclsInfo NetworkAcls
        {
            get => _networkAcls = Get(_networkAcls);
            set => _networkAcls = value;
        }
    }

    public class SkuInfo : PropertyBase
    {

        public string Family { get; set; }

        public string Name { get; set; }
    }

    public class NetworkAclsInfo : PropertyBase
    {

        public string Bypass { get; set; }

        public string DefaultAction { get; set; }

        public IList<IpRuleInfo> IpRules { get; set; }

        public IList<VirtualNetworkRuleInfo> VirtualNetworkRules { get; set; }
    }

    public class IpRuleInfo : PropertyBase
    {

        public string Value { get; set; }
    }

    public class VirtualNetworkRuleInfo : PropertyBase
    {

        public string Id { get; set; }
    }
}
