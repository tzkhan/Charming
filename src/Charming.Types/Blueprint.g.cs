namespace Charming.Types.Blueprint
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class BlueprintAssignment : Resource<BlueprintAssignmentProperties>
    {
        public BlueprintAssignment() => (Type, ApiVersion) = ("Microsoft.Blueprint/blueprintAssignments", "2018-11-01-preview");
        public BlueprintAssignment(string name) : this() => Name = name;
        public BlueprintAssignment(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public BlueprintAssignment WithProperties(Action<BlueprintAssignmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }

        public string PrincipalId { get; set; }

        public string TenantId { get; set; }

        public object UserAssignedIdentities { get; set; }
    }

    public class BlueprintAssignmentProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string BlueprintId { get; set; }

        public string Scope { get; set; }

        public object Parameters { get; set; }

        public object ResourceGroups { get; set; }

        private LocksInfo _locks;
        public LocksInfo Locks
        {
            get => _locks = Get(_locks);
            set => _locks = value;
        }
    }

    public class LocksInfo : PropertyBase
    {

        public string Mode { get; set; }

        public IList<string> ExcludedPrincipals { get; set; }

        public IList<string> ExcludedActions { get; set; }
    }

    public class BlueprintVersion : Resource<BlueprintVersionProperties>
    {
        public BlueprintVersion() => (Type, ApiVersion) = ("Microsoft.Blueprint/blueprints/versions", "2018-11-01-preview");
        public BlueprintVersion(string name) : this() => Name = name;
        public BlueprintVersion(string name, Location location) : this() => (Name, Location) = (name, location);

        public BlueprintVersion WithProperties(Action<BlueprintVersionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BlueprintVersionProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string TargetScope { get; set; }

        public object Parameters { get; set; }

        public object ResourceGroups { get; set; }

        public string BlueprintName { get; set; }

        public string ChangeNotes { get; set; }
    }

    public class Blueprint : Resource<BlueprintProperties>
    {
        public Blueprint() => (Type, ApiVersion) = ("Microsoft.Blueprint/blueprints", "2018-11-01-preview");
        public Blueprint(string name) : this() => Name = name;
        public Blueprint(string name, Location location) : this() => (Name, Location) = (name, location);

        public Blueprint WithProperties(Action<BlueprintProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BlueprintProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string TargetScope { get; set; }

        public object Parameters { get; set; }

        public object ResourceGroups { get; set; }

        public object Versions { get; set; }

        public object Layout { get; set; }
    }
}
