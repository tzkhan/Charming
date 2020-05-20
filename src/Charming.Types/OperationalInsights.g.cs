namespace Charming.Types.OperationalInsights
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class Cluster : Resource<ClusterProperties>
    {
        public Cluster() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/clusters", "2020-03-01-preview");
        public Cluster(string name) : this() => Name = name;
        public Cluster(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }

        public Cluster WithProperties(Action<ClusterProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string Type { get; set; }
    }

    public class ClusterProperties : PropertyBase
    {

        public string NextLink { get; set; }

        private KeyVaultPropertiesInfo _keyVaultProperties;
        public KeyVaultPropertiesInfo KeyVaultProperties
        {
            get => _keyVaultProperties = Get(_keyVaultProperties);
            set => _keyVaultProperties = value;
        }
    }

    public class KeyVaultPropertiesInfo : PropertyBase
    {

        public string KeyVaultUri { get; set; }

        public string KeyName { get; set; }

        public string KeyVersion { get; set; }
    }

    public class WorkspaceDataExport : Resource<WorkspaceDataExportProperties>
    {
        public WorkspaceDataExport() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/dataExports", "2020-03-01-preview");
        public WorkspaceDataExport(string name) : this() => Name = name;
        public WorkspaceDataExport(string name, Location location) : this() => (Name, Location) = (name, location);

        public WorkspaceDataExport WithProperties(Action<WorkspaceDataExportProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class WorkspaceDataExportProperties : PropertyBase
    {

        public string DataExportId { get; set; }

        public bool? AllTables { get; set; }

        public IList<string> TableNames { get; set; }

        private DestinationInfo _destination;
        public DestinationInfo Destination
        {
            get => _destination = Get(_destination);
            set => _destination = value;
        }

        public bool? Enable { get; set; }

        public string LastModifiedDate { get; set; }
    }

    public class DestinationInfo : PropertyBase
    {

        public string ResourceId { get; set; }

        private MetaDataInfo _metaData;
        public MetaDataInfo MetaData
        {
            get => _metaData = Get(_metaData);
            set => _metaData = value;
        }
    }

    public class MetaDataInfo : PropertyBase
    {

        public string EventHubName { get; set; }
    }

    public class WorkspaceDataSource : Resource<WorkspaceDataSourceProperties>
    {
        public WorkspaceDataSource() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/dataSources", "2020-03-01-preview");
        public WorkspaceDataSource(string name) : this() => Name = name;
        public WorkspaceDataSource(string name, Location location) : this() => (Name, Location) = (name, location);

        public WorkspaceDataSource WithProperties(Action<WorkspaceDataSourceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class WorkspaceDataSourceProperties : PropertyBase
    {
    }

    public class WorkspaceLinkedService : Resource<WorkspaceLinkedServiceProperties>
    {
        public WorkspaceLinkedService() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/linkedServices", "2020-03-01-preview");
        public WorkspaceLinkedService(string name) : this() => Name = name;
        public WorkspaceLinkedService(string name, Location location) : this() => (Name, Location) = (name, location);

        public WorkspaceLinkedService WithProperties(Action<WorkspaceLinkedServiceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class WorkspaceLinkedServiceProperties : PropertyBase
    {

        public string ResourceId { get; set; }

        public string WriteAccessResourceId { get; set; }
    }

    public class WorkspaceLinkedStorageAccount : Resource<WorkspaceLinkedStorageAccountProperties>
    {
        public WorkspaceLinkedStorageAccount() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/linkedStorageAccounts", "2020-03-01-preview");
        public WorkspaceLinkedStorageAccount(string name) : this() => Name = name;
        public WorkspaceLinkedStorageAccount(string name, Location location) : this() => (Name, Location) = (name, location);

        public WorkspaceLinkedStorageAccount WithProperties(Action<WorkspaceLinkedStorageAccountProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class WorkspaceLinkedStorageAccountProperties : PropertyBase
    {

        public IList<string> StorageAccountIds { get; set; }
    }

    public class WorkspaceSavedSearche : Resource<WorkspaceSavedSearcheProperties>
    {
        public WorkspaceSavedSearche() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/savedSearches", "2020-03-01-preview");
        public WorkspaceSavedSearche(string name) : this() => Name = name;
        public WorkspaceSavedSearche(string name, Location location) : this() => (Name, Location) = (name, location);

        public WorkspaceSavedSearche WithProperties(Action<WorkspaceSavedSearcheProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class WorkspaceSavedSearcheProperties : PropertyBase
    {

        public string Category { get; set; }

        public string DisplayName { get; set; }

        public string Query { get; set; }

        public int? Version { get; set; }

        public IList<TagInfo> Tags { get; set; }
    }

    public class TagInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Value { get; set; }
    }

    public class WorkspaceStorageInsightConfig : Resource<WorkspaceStorageInsightConfigProperties>
    {
        public WorkspaceStorageInsightConfig() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/storageInsightConfigs", "2020-03-01-preview");
        public WorkspaceStorageInsightConfig(string name) : this() => Name = name;
        public WorkspaceStorageInsightConfig(string name, Location location) : this() => (Name, Location) = (name, location);

        public WorkspaceStorageInsightConfig WithProperties(Action<WorkspaceStorageInsightConfigProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class WorkspaceStorageInsightConfigProperties : PropertyBase
    {

        public IList<string> Containers { get; set; }

        public IList<string> Tables { get; set; }

        private StorageAccountInfo _storageAccount;
        public StorageAccountInfo StorageAccount
        {
            get => _storageAccount = Get(_storageAccount);
            set => _storageAccount = value;
        }
    }

    public class StorageAccountInfo : PropertyBase
    {

        public string Id { get; set; }

        public string Key { get; set; }
    }

    public class Workspace : Resource<WorkspaceProperties>
    {
        public Workspace() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces", "2020-03-01-preview");
        public Workspace(string name) : this() => Name = name;
        public Workspace(string name, Location location) : this() => (Name, Location) = (name, location);

        public Workspace WithProperties(Action<WorkspaceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class WorkspaceProperties : PropertyBase
    {

        private SkuInfo _sku;
        public SkuInfo Sku
        {
            get => _sku = Get(_sku);
            set => _sku = value;
        }

        public int? RetentionInDays { get; set; }

        public string PublicNetworkAccessForIngestion { get; set; }

        public string PublicNetworkAccessForQuery { get; set; }
    }

    public class SkuInfo : PropertyBase
    {

        public string Name { get; set; }
    }
}
