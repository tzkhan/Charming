namespace Charming.Types.ManagedIdentity
{
    using System;
    using Charming;
    using Charming.Types.Internal;

    public class UserAssignedIdentity : Resource<UserAssignedIdentityProperties>
    {
        public UserAssignedIdentity() => (Type, ApiVersion) = ("Microsoft.ManagedIdentity/userAssignedIdentities", "2018-11-30");
        public UserAssignedIdentity(string name) : this() => Name = name;
        public UserAssignedIdentity(string name, Location location) : this() => (Name, Location) = (name, location);

        public UserAssignedIdentity WithProperties(Action<UserAssignedIdentityProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class UserAssignedIdentityProperties : PropertyBase
    {
    }
}
