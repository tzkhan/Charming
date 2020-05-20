namespace Charming.Types.Resources
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class Deployment : Resource<DeploymentProperties>
    {
        public Deployment() => (Type, ApiVersion) = ("Microsoft.Resources/deployments", "2019-10-01");
        public Deployment(string name) : this() => Name = name;
        public Deployment(string name, Location location) : this() => (Name, Location) = (name, location);

        public string SubscriptionId { get; set; }

        public string ResourceGroup { get; set; }

        public Deployment WithProperties(Action<DeploymentProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DeploymentProperties : PropertyBase
    {

        public ITemplate Template { get; set; }

        private TemplateLinkInfo _templateLink;
        public TemplateLinkInfo TemplateLink
        {
            get => _templateLink = Get(_templateLink);
            set => _templateLink = value;
        }

        public IList<Parameter> Parameters { get; set; }

        private ParametersLinkInfo _parametersLink;
        public ParametersLinkInfo ParametersLink
        {
            get => _parametersLink = Get(_parametersLink);
            set => _parametersLink = value;
        }

        public DeploymentMode Mode { get; set; }

        private DebugSettingInfo _debugSetting;
        public DebugSettingInfo DebugSetting
        {
            get => _debugSetting = Get(_debugSetting);
            set => _debugSetting = value;
        }

        private OnErrorDeploymentInfo _onErrorDeployment;
        public OnErrorDeploymentInfo OnErrorDeployment
        {
            get => _onErrorDeployment = Get(_onErrorDeployment);
            set => _onErrorDeployment = value;
        }
    }

    public class TemplateLinkInfo : PropertyBase
    {

        public string Uri { get; set; }

        public string ContentVersion { get; set; }
    }

    public class ParametersLinkInfo : PropertyBase
    {

        public string Uri { get; set; }

        public string ContentVersion { get; set; }
    }

    public class DebugSettingInfo : PropertyBase
    {

        public string DetailLevel { get; set; }
    }

    public class OnErrorDeploymentInfo : PropertyBase
    {

        public string Type { get; set; }

        public string DeploymentName { get; set; }
    }

    public class DeploymentScript : Resource<DeploymentScriptProperties>
    {
        public DeploymentScript() => (Type, ApiVersion) = ("Microsoft.Resources/deploymentScripts", "2019-10-01-preview");
        public DeploymentScript(string name) : this() => Name = name;
        public DeploymentScript(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public DeploymentScript WithProperties(Action<DeploymentScriptProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }

        private UserAssignedIdentitiesInfo _userAssignedIdentities;
        public UserAssignedIdentitiesInfo UserAssignedIdentities
        {
            get => _userAssignedIdentities = Get(_userAssignedIdentities);
            set => _userAssignedIdentities = value;
        }
    }

    public class UserAssignedIdentitiesInfo : PropertyBase
    {

        public string PrincipalId { get; set; }

        public string ClientId { get; set; }
    }

    public class DeploymentScriptProperties : PropertyBase
    {

        public string AzPowerShellVersion { get; set; }

        public string AzCliVersion { get; set; }

        private ContainerSettingsInfo _containerSettings;
        public ContainerSettingsInfo ContainerSettings
        {
            get => _containerSettings = Get(_containerSettings);
            set => _containerSettings = value;
        }

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

    public class ContainerSettingsInfo : PropertyBase
    {

        public string ContainerGroupName { get; set; }
    }

    public class EnvironmentVariableInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }

        public string SecureValue { get; set; }
    }

    public class ResourceGroup : Resource<ResourceGroupProperties>
    {
        public ResourceGroup() => (Type, ApiVersion) = ("Microsoft.Resources/resourceGroups", "2019-10-01");
        public ResourceGroup(string name) : this() => Name = name;
        public ResourceGroup(string name, Location location) : this() => (Name, Location) = (name, location);

        public ResourceGroup WithProperties(Action<ResourceGroupProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ResourceGroupProperties : PropertyBase
    {
    }

    public class Tag : Resource<TagProperties>
    {
        public Tag() => (Type, ApiVersion) = ("Microsoft.Resources/tags", "2019-10-01");
        public Tag(string name) : this() => Name = name;
        public Tag(string name, Location location) : this() => (Name, Location) = (name, location);

        public Tag WithProperties(Action<TagProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class TagProperties : PropertyBase
    {

        public IDictionary<string, string> Tags { get; set; }
    }
}
