namespace Charming.Types.KeyVault
{
    using Charming;
    using System.Collections.Generic;

    public class Vault : Resource<Vault.PropertyCollection>
    {
        public Vault() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults", "2019-09-01");

        public partial class PropertyCollection
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
}
