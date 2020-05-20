namespace Charming.Types.AppConfiguration
{
    using System;
    using Charming;
    using Charming.Types.Internal;

    public class ConfigurationStorePrivateEndpointConnection : Resource<ConfigurationStorePrivateEndpointConnectionProperties>
    {
        public ConfigurationStorePrivateEndpointConnection() => (Type, ApiVersion) = ("Microsoft.AppConfiguration/configurationStores/privateEndpointConnections", "2019-11-01-preview");
        public ConfigurationStorePrivateEndpointConnection(string name) : this() => Name = name;
        public ConfigurationStorePrivateEndpointConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public ConfigurationStorePrivateEndpointConnection WithProperties(Action<ConfigurationStorePrivateEndpointConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ConfigurationStorePrivateEndpointConnectionProperties : PropertyBase
    {

        private PrivateEndpointInfo _privateEndpoint;
        public PrivateEndpointInfo PrivateEndpoint
        {
            get => _privateEndpoint = Get(_privateEndpoint);
            set => _privateEndpoint = value;
        }

        private PrivateLinkServiceConnectionStateInfo _privateLinkServiceConnectionState;
        public PrivateLinkServiceConnectionStateInfo PrivateLinkServiceConnectionState
        {
            get => _privateLinkServiceConnectionState = Get(_privateLinkServiceConnectionState);
            set => _privateLinkServiceConnectionState = value;
        }
    }

    public class PrivateEndpointInfo : PropertyBase
    {

        public string Id { get; set; }
    }

    public class PrivateLinkServiceConnectionStateInfo : PropertyBase
    {

        public string Status { get; set; }

        public string Description { get; set; }
    }

    public class ConfigurationStore : Resource<ConfigurationStoreProperties>
    {
        public ConfigurationStore() => (Type, ApiVersion) = ("Microsoft.AppConfiguration/configurationStores", "2019-11-01-preview");
        public ConfigurationStore(string name) : this() => Name = name;
        public ConfigurationStore(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public ConfigurationStore WithProperties(Action<ConfigurationStoreProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }

        public object UserAssignedIdentities { get; set; }
    }

    public class ConfigurationStoreProperties : PropertyBase
    {

        private EncryptionInfo _encryption;
        public EncryptionInfo Encryption
        {
            get => _encryption = Get(_encryption);
            set => _encryption = value;
        }
    }

    public class EncryptionInfo : PropertyBase
    {

        private KeyVaultPropertiesInfo _keyVaultProperties;
        public KeyVaultPropertiesInfo KeyVaultProperties
        {
            get => _keyVaultProperties = Get(_keyVaultProperties);
            set => _keyVaultProperties = value;
        }
    }

    public class KeyVaultPropertiesInfo : PropertyBase
    {

        public string KeyIdentifier { get; set; }

        public string IdentityClientId { get; set; }
    }
}
