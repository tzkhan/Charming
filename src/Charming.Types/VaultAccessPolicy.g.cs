namespace Charming.Types.KeyVault
{
    using Charming;
    using System.Collections.Generic;

    public class VaultAccessPolicy : Resource<VaultAccessPolicy.PropertyCollection>
    {
        public VaultAccessPolicy() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/accessPolicies", "2019-09-01");

        public partial class PropertyCollection
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
    }
}
