namespace Charming.Types.KeyVault
{
    using Charming;

    public class VaultSecret : Resource<VaultSecret.PropertyCollection>
    {
        public VaultSecret() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/secrets", "2019-09-01");

        public partial class PropertyCollection
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
    }
}
