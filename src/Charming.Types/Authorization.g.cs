namespace Charming.Types.Authorization
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class Lock : Resource<LockProperties>
    {
        public Lock() => (Type, ApiVersion) = ("Microsoft.Authorization/locks", "2016-09-01");
        public Lock(string name) : this() => Name = name;
        public Lock(string name, Location location) : this() => (Name, Location) = (name, location);

        public Lock WithProperties(Action<LockProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class LockProperties : PropertyBase
    {

        public string Level { get; set; }

        public string Notes { get; set; }
    }

    public class PolicyAssignment : Resource<PolicyAssignmentProperties>
    {
        public PolicyAssignment() => (Type, ApiVersion) = ("Microsoft.Authorization/policyAssignments", "2019-06-01");
        public PolicyAssignment(string name) : this() => Name = name;
        public PolicyAssignment(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public PolicyAssignment WithProperties(Action<PolicyAssignmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PolicyAssignmentProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public string PolicyDefinitionId { get; set; }

        public string Scope { get; set; }

        public IList<string> NotScopes { get; set; }

        public object Parameters { get; set; }

        public string Description { get; set; }

        public object Metadata { get; set; }

        public string EnforcementMode { get; set; }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }
    }

    public class PolicyDefinition : Resource<PolicyDefinitionProperties>
    {
        public PolicyDefinition() => (Type, ApiVersion) = ("Microsoft.Authorization/policyDefinitions", "2019-06-01");
        public PolicyDefinition(string name) : this() => Name = name;
        public PolicyDefinition(string name, Location location) : this() => (Name, Location) = (name, location);

        public PolicyDefinition WithProperties(Action<PolicyDefinitionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PolicyDefinitionProperties : PropertyBase
    {

        public string PolicyType { get; set; }

        public string Mode { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public object PolicyRule { get; set; }

        public object Metadata { get; set; }

        public object Parameters { get; set; }
    }

    public class PolicySetDefinition : Resource<PolicySetDefinitionProperties>
    {
        public PolicySetDefinition() => (Type, ApiVersion) = ("Microsoft.Authorization/policySetDefinitions", "2019-06-01");
        public PolicySetDefinition(string name) : this() => Name = name;
        public PolicySetDefinition(string name, Location location) : this() => (Name, Location) = (name, location);

        public PolicySetDefinition WithProperties(Action<PolicySetDefinitionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class PolicySetDefinitionProperties : PropertyBase
    {

        public string PolicyType { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public object Metadata { get; set; }

        public object Parameters { get; set; }

        public IList<PolicyDefinitionInfo> PolicyDefinitions { get; set; }
    }

    public class PolicyDefinitionInfo : PropertyBase
    {

        public string PolicyDefinitionId { get; set; }

        public object Parameters { get; set; }
    }

    public class RoleAssignment : Resource<RoleAssignmentProperties>
    {
        public RoleAssignment() => (Type, ApiVersion) = ("Microsoft.Authorization/roleAssignments", "2018-09-01-preview");
        public RoleAssignment(string name) : this() => Name = name;
        public RoleAssignment(string name, Location location) : this() => (Name, Location) = (name, location);

        public RoleAssignment WithProperties(Action<RoleAssignmentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RoleAssignmentProperties : PropertyBase
    {

        public string RoleDefinitionId { get; set; }

        public string PrincipalId { get; set; }

        public string PrincipalType { get; set; }

        public bool? CanDelegate { get; set; }
    }

    public class RoleDefinition : Resource<RoleDefinitionProperties>
    {
        public RoleDefinition() => (Type, ApiVersion) = ("Microsoft.Authorization/roleDefinitions", "2018-01-01-preview");
        public RoleDefinition(string name) : this() => Name = name;
        public RoleDefinition(string name, Location location) : this() => (Name, Location) = (name, location);

        public RoleDefinition WithProperties(Action<RoleDefinitionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RoleDefinitionProperties : PropertyBase
    {

        public string RoleName { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public IList<PermissionInfo> Permissions { get; set; }

        public IList<string> AssignableScopes { get; set; }
    }

    public class PermissionInfo : PropertyBase
    {

        public IList<string> Actions { get; set; }

        public IList<string> NotActions { get; set; }

        public IList<string> DataActions { get; set; }

        public IList<string> NotDataActions { get; set; }
    }
}
