namespace Charming.Types.ManagedIdentity
{
    using Charming;

    public partial class UserAssignedIdentity : Resource<UserAssignedIdentityProperties>
    {
        public UserAssignedIdentity() => (Type, ApiVersion) = ("Microsoft.ManagedIdentity/userAssignedIdentities", "2018-11-30");
        public UserAssignedIdentity(string name) : this() => Name = name;
        public UserAssignedIdentity(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class UserAssignedIdentityProperties
    {
    }
}
