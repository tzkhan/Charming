namespace Charming.Types.Resources
{
    using Charming;
    using System.Collections.Generic;

    public partial class Deployment : Resource<DeploymentProperties>
    {
        public Deployment() => (Type, ApiVersion) = ("Microsoft.Resources/deployments", "2019-10-01");
        public Deployment(string name) : this() => Name = name;
        public Deployment(string name, Location location) : this() => (Name, Location) = (name, location);

        public string SubscriptionId { get; set; }

        public string ResourceGroup { get; set; }
    }

    public partial class DeploymentProperties
    {
        public ITemplate Template { get; set; }
        public TemplateLinkInfo TemplateLink { get; set; }
        public IList<Parameter> Parameters { get; set; }
        public ParametersLinkInfo ParametersLink { get; set; }
        public DeploymentMode Mode { get; set; }
        public DebugSettingInfo DebugSetting { get; set; }
        public OnErrorDeploymentInfo OnErrorDeployment { get; set; }
    }

    public partial class TemplateLinkInfo
    {
        public string Uri { get; set; }
        public string ContentVersion { get; set; }
    }

    public partial class ParametersLinkInfo
    {
        public string Uri { get; set; }
        public string ContentVersion { get; set; }
    }

    public partial class DebugSettingInfo
    {
        public string DetailLevel { get; set; }
    }

    public partial class OnErrorDeploymentInfo
    {
        public string Type { get; set; }
        public string DeploymentName { get; set; }
    }

    public partial class DeploymentScript : Resource<DeploymentScriptProperties>
    {
        public DeploymentScript() => (Type, ApiVersion) = ("Microsoft.Resources/deploymentScripts", "2019-10-01-preview");
        public DeploymentScript(string name) : this() => Name = name;
        public DeploymentScript(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class IdentityInfo
    {
        public string Type { get; set; }
        public UserAssignedIdentitiesInfo UserAssignedIdentities { get; set; }
    }

    public partial class UserAssignedIdentitiesInfo
    {
        public string PrincipalId { get; set; }
        public string ClientId { get; set; }
    }

    public partial class DeploymentScriptProperties
    {
        public string AzPowerShellVersion { get; set; }
        public string AzCliVersion { get; set; }
        public ContainerSettingsInfo ContainerSettings { get; set; }
        public string CleanupPreference { get; set; }
        public string PrimaryScriptUri { get; set; }
        public IList<string> SupportingScriptUris { get; set; }
        public string ScriptContent { get; set; }
        public string Arguments { get; set; }
        public IList<EnvironmentVariableInfo> EnvironmentVariables { get; set; }
        public string ForceUpdateTag { get; set; }
        public string RetentionInterval { get; set; }
        public string Timeout { get; set; }
    }

    public partial class ContainerSettingsInfo
    {
        public string ContainerGroupName { get; set; }
    }

    public partial class EnvironmentVariableInfo
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string SecureValue { get; set; }
    }

    public partial class ResourceGroup : Resource<ResourceGroupProperties>
    {
        public ResourceGroup() => (Type, ApiVersion) = ("Microsoft.Resources/resourceGroups", "2019-10-01");
        public ResourceGroup(string name) : this() => Name = name;
        public ResourceGroup(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class ResourceGroupProperties
    {
    }

    public partial class Tag : Resource<TagProperties>
    {
        public Tag() => (Type, ApiVersion) = ("Microsoft.Resources/tags", "2019-10-01");
        public Tag(string name) : this() => Name = name;
        public Tag(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class TagProperties
    {
        public IDictionary<string, string> Tags { get; set; }
    }
}
