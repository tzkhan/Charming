namespace Charming.Types.OperationalInsights
{
    using Charming;
    using System.Collections.Generic;

    public partial class Cluster : Resource<ClusterProperties>
    {
        public Cluster() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/clusters", "2020-03-01-preview");
        public Cluster(string name) : this() => Name = name;
        public Cluster(string name, Location location) : this() => (Name, Location) = (name, location);

        public IdentityInfo Identity { get; set; }
    }

    public partial class IdentityInfo
    {
        public string Type { get; set; }
    }

    public partial class ClusterProperties
    {
        public string NextLink { get; set; }
        public KeyVaultPropertiesInfo KeyVaultProperties { get; set; }
    }

    public partial class KeyVaultPropertiesInfo
    {
        public string KeyVaultUri { get; set; }
        public string KeyName { get; set; }
        public string KeyVersion { get; set; }
    }

    public partial class WorkspaceDataExport : Resource<WorkspaceDataExportProperties>
    {
        public WorkspaceDataExport() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/dataExports", "2020-03-01-preview");
        public WorkspaceDataExport(string name) : this() => Name = name;
        public WorkspaceDataExport(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class WorkspaceDataExportProperties
    {
        public string DataExportId { get; set; }
        public bool? AllTables { get; set; }
        public IList<string> TableNames { get; set; }
        public DestinationInfo Destination { get; set; }
        public bool? Enable { get; set; }
        public string LastModifiedDate { get; set; }
    }

    public partial class DestinationInfo
    {
        public string ResourceId { get; set; }
        public MetaDataInfo MetaData { get; set; }
    }

    public partial class MetaDataInfo
    {
        public string EventHubName { get; set; }
    }

    public partial class WorkspaceDataSource : Resource<WorkspaceDataSourceProperties>
    {
        public WorkspaceDataSource() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/dataSources", "2020-03-01-preview");
        public WorkspaceDataSource(string name) : this() => Name = name;
        public WorkspaceDataSource(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class WorkspaceDataSourceProperties
    {
    }

    public partial class WorkspaceLinkedService : Resource<WorkspaceLinkedServiceProperties>
    {
        public WorkspaceLinkedService() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/linkedServices", "2020-03-01-preview");
        public WorkspaceLinkedService(string name) : this() => Name = name;
        public WorkspaceLinkedService(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class WorkspaceLinkedServiceProperties
    {
        public string ResourceId { get; set; }
        public string WriteAccessResourceId { get; set; }
    }

    public partial class WorkspaceLinkedStorageAccount : Resource<WorkspaceLinkedStorageAccountProperties>
    {
        public WorkspaceLinkedStorageAccount() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/linkedStorageAccounts", "2020-03-01-preview");
        public WorkspaceLinkedStorageAccount(string name) : this() => Name = name;
        public WorkspaceLinkedStorageAccount(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class WorkspaceLinkedStorageAccountProperties
    {
        public IList<string> StorageAccountIds { get; set; }
    }

    public partial class WorkspaceSavedSearche : Resource<WorkspaceSavedSearcheProperties>
    {
        public WorkspaceSavedSearche() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/savedSearches", "2020-03-01-preview");
        public WorkspaceSavedSearche(string name) : this() => Name = name;
        public WorkspaceSavedSearche(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class WorkspaceSavedSearcheProperties
    {
        public string Category { get; set; }
        public string DisplayName { get; set; }
        public string Query { get; set; }
        public int? Version { get; set; }
        public IList<TagInfo> Tags { get; set; }
    }

    public partial class TagInfo
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public partial class WorkspaceStorageInsightConfig : Resource<WorkspaceStorageInsightConfigProperties>
    {
        public WorkspaceStorageInsightConfig() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces/storageInsightConfigs", "2020-03-01-preview");
        public WorkspaceStorageInsightConfig(string name) : this() => Name = name;
        public WorkspaceStorageInsightConfig(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class WorkspaceStorageInsightConfigProperties
    {
        public IList<string> Containers { get; set; }
        public IList<string> Tables { get; set; }
        public StorageAccountInfo StorageAccount { get; set; }
    }

    public partial class StorageAccountInfo
    {
        public string Id { get; set; }
        public string Key { get; set; }
    }

    public partial class Workspace : Resource<WorkspaceProperties>
    {
        public Workspace() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces", "2020-03-01-preview");
        public Workspace(string name) : this() => Name = name;
        public Workspace(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class WorkspaceProperties
    {
        public SkuInfo Sku { get; set; }
        public int? RetentionInDays { get; set; }
        public string PublicNetworkAccessForIngestion { get; set; }
        public string PublicNetworkAccessForQuery { get; set; }
    }

    public partial class SkuInfo
    {
        public string Name { get; set; }
    }
}
