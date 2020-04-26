namespace Charming.Types.KeyVault
{
    using Charming;

    public class VaultPrivateEndpointConnection : Resource<VaultPrivateEndpointConnection.PropertyCollection>
    {
        public VaultPrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.KeyVault/vaults/privateEndpointConnections", "2019-09-01");

        public partial class PropertyCollection
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
    }
}
