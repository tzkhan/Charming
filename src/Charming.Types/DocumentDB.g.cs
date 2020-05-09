namespace Charming.Types.DocumentDB
{
    using Charming;
    using System.Collections.Generic;

    public partial class DatabaseAccountApiDatabaseCollection : Resource<DatabaseAccountApiDatabaseCollectionProperties>
    {
        public DatabaseAccountApiDatabaseCollection() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases/collections", "2016-03-31");
        public DatabaseAccountApiDatabaseCollection(string name) : this() => Name = name;
        public DatabaseAccountApiDatabaseCollection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountApiDatabaseCollectionProperties
    {
        public ResourceInfo Resource { get; set; }
        public object Options { get; set; }
    }

    public partial class ResourceInfo
    {
        public string Id { get; set; }
        public object ShardKey { get; set; }
        public IList<IndexeInfo> Indexes { get; set; }
    }

    public partial class IndexeInfo
    {
        public KeyInfo Key { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class KeyInfo
    {
        public IList<string> Keys { get; set; }
    }

    public partial class OptionsInfo
    {
        public int? ExpireAfterSeconds { get; set; }
        public bool? Unique { get; set; }
    }

    public partial class DatabaseAccountApiDatabaseContainer : Resource<DatabaseAccountApiDatabaseContainerProperties>
    {
        public DatabaseAccountApiDatabaseContainer() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases/containers", "2016-03-31");
        public DatabaseAccountApiDatabaseContainer(string name) : this() => Name = name;
        public DatabaseAccountApiDatabaseContainer(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountApiDatabaseContainerProperties
    {
        public ResourceInfo Resource { get; set; }
        public object Options { get; set; }
    }

    public partial class IndexingPolicyInfo
    {
        public bool? Automatic { get; set; }
        public string IndexingMode { get; set; }
        public IList<IncludedPathInfo> IncludedPaths { get; set; }
        public IList<ExcludedPathInfo> ExcludedPaths { get; set; }
    }

    public partial class IncludedPathInfo
    {
        public string Path { get; set; }
        public IList<IndexeInfo> Indexes { get; set; }
    }

    public partial class ExcludedPathInfo
    {
        public string Path { get; set; }
    }

    public partial class PartitionKeyInfo
    {
        public IList<string> Paths { get; set; }
        public string Kind { get; set; }
    }

    public partial class UniqueKeyPolicyInfo
    {
        public IList<UniqueKeyInfo> UniqueKeys { get; set; }
    }

    public partial class UniqueKeyInfo
    {
        public IList<string> Paths { get; set; }
    }

    public partial class ConflictResolutionPolicyInfo
    {
        public string Mode { get; set; }
        public string ConflictResolutionPath { get; set; }
        public string ConflictResolutionProcedure { get; set; }
    }

    public partial class DatabaseAccountApiDatabaseGraph : Resource<DatabaseAccountApiDatabaseGraphProperties>
    {
        public DatabaseAccountApiDatabaseGraph() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases/graphs", "2016-03-31");
        public DatabaseAccountApiDatabaseGraph(string name) : this() => Name = name;
        public DatabaseAccountApiDatabaseGraph(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountApiDatabaseGraphProperties
    {
        public ResourceInfo Resource { get; set; }
        public object Options { get; set; }
    }

    public partial class DatabaseAccountApiDatabase : Resource<DatabaseAccountApiDatabaseProperties>
    {
        public DatabaseAccountApiDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases", "2016-03-31");
        public DatabaseAccountApiDatabase(string name) : this() => Name = name;
        public DatabaseAccountApiDatabase(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountApiDatabaseProperties
    {
        public ResourceInfo Resource { get; set; }
        public object Options { get; set; }
    }

    public partial class DatabaseAccountApiKeyspaceTable : Resource<DatabaseAccountApiKeyspaceTableProperties>
    {
        public DatabaseAccountApiKeyspaceTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/tables", "2016-03-31");
        public DatabaseAccountApiKeyspaceTable(string name) : this() => Name = name;
        public DatabaseAccountApiKeyspaceTable(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountApiKeyspaceTableProperties
    {
        public ResourceInfo Resource { get; set; }
        public object Options { get; set; }
    }

    public partial class SchemaInfo
    {
        public IList<ColumnInfo> Columns { get; set; }
        public IList<PartitionKeyInfo> PartitionKeys { get; set; }
        public IList<ClusterKeyInfo> ClusterKeys { get; set; }
    }

    public partial class ColumnInfo
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public partial class ClusterKeyInfo
    {
        public string Name { get; set; }
        public string OrderBy { get; set; }
    }

    public partial class DatabaseAccountApiKeyspace : Resource<DatabaseAccountApiKeyspaceProperties>
    {
        public DatabaseAccountApiKeyspace() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces", "2016-03-31");
        public DatabaseAccountApiKeyspace(string name) : this() => Name = name;
        public DatabaseAccountApiKeyspace(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountApiKeyspaceProperties
    {
        public ResourceInfo Resource { get; set; }
        public object Options { get; set; }
    }

    public partial class DatabaseAccountApiTable : Resource<DatabaseAccountApiTableProperties>
    {
        public DatabaseAccountApiTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/tables", "2016-03-31");
        public DatabaseAccountApiTable(string name) : this() => Name = name;
        public DatabaseAccountApiTable(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountApiTableProperties
    {
        public ResourceInfo Resource { get; set; }
        public object Options { get; set; }
    }

    public partial class DatabaseAccountCassandraKeyspaceTable : Resource<DatabaseAccountCassandraKeyspaceTableProperties>
    {
        public DatabaseAccountCassandraKeyspaceTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables", "2020-03-01");
        public DatabaseAccountCassandraKeyspaceTable(string name) : this() => Name = name;
        public DatabaseAccountCassandraKeyspaceTable(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountCassandraKeyspaceTableProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountCassandraKeyspace : Resource<DatabaseAccountCassandraKeyspaceProperties>
    {
        public DatabaseAccountCassandraKeyspace() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces", "2020-03-01");
        public DatabaseAccountCassandraKeyspace(string name) : this() => Name = name;
        public DatabaseAccountCassandraKeyspace(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountCassandraKeyspaceProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountGremlinDatabaseGraph : Resource<DatabaseAccountGremlinDatabaseGraphProperties>
    {
        public DatabaseAccountGremlinDatabaseGraph() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/graphs", "2020-03-01");
        public DatabaseAccountGremlinDatabaseGraph(string name) : this() => Name = name;
        public DatabaseAccountGremlinDatabaseGraph(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountGremlinDatabaseGraphProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class SpatialIndexeInfo
    {
        public string Path { get; set; }
        public IList<string> Types { get; set; }
    }

    public partial class DatabaseAccountGremlinDatabase : Resource<DatabaseAccountGremlinDatabaseProperties>
    {
        public DatabaseAccountGremlinDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/gremlinDatabases", "2020-03-01");
        public DatabaseAccountGremlinDatabase(string name) : this() => Name = name;
        public DatabaseAccountGremlinDatabase(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountGremlinDatabaseProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountMongodbDatabaseCollection : Resource<DatabaseAccountMongodbDatabaseCollectionProperties>
    {
        public DatabaseAccountMongodbDatabaseCollection() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/collections", "2020-03-01");
        public DatabaseAccountMongodbDatabaseCollection(string name) : this() => Name = name;
        public DatabaseAccountMongodbDatabaseCollection(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountMongodbDatabaseCollectionProperties
    {
        public ResourceInfo Resource { get; set; }
        public PropertiesOptionsInfo Options { get; set; }
    }

    public partial class PropertiesOptionsInfo
    {
        public object AdditionalProperties { get; set; }
        public string Throughput { get; set; }
    }

    public partial class DatabaseAccountMongodbDatabase : Resource<DatabaseAccountMongodbDatabaseProperties>
    {
        public DatabaseAccountMongodbDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/mongodbDatabases", "2020-03-01");
        public DatabaseAccountMongodbDatabase(string name) : this() => Name = name;
        public DatabaseAccountMongodbDatabase(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountMongodbDatabaseProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountSqlDatabaseContainerStoredProcedure : Resource<DatabaseAccountSqlDatabaseContainerStoredProcedureProperties>
    {
        public DatabaseAccountSqlDatabaseContainerStoredProcedure() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/storedProcedures", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainerStoredProcedure(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainerStoredProcedure(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountSqlDatabaseContainerStoredProcedureProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountSqlDatabaseContainerTrigger : Resource<DatabaseAccountSqlDatabaseContainerTriggerProperties>
    {
        public DatabaseAccountSqlDatabaseContainerTrigger() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/triggers", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainerTrigger(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainerTrigger(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountSqlDatabaseContainerTriggerProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountSqlDatabaseContainerUserDefinedFunction : Resource<DatabaseAccountSqlDatabaseContainerUserDefinedFunctionProperties>
    {
        public DatabaseAccountSqlDatabaseContainerUserDefinedFunction() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/userDefinedFunctions", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainerUserDefinedFunction(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainerUserDefinedFunction(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountSqlDatabaseContainerUserDefinedFunctionProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountSqlDatabaseContainer : Resource<DatabaseAccountSqlDatabaseContainerProperties>
    {
        public DatabaseAccountSqlDatabaseContainer() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainer(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainer(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountSqlDatabaseContainerProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountSqlDatabase : Resource<DatabaseAccountSqlDatabaseProperties>
    {
        public DatabaseAccountSqlDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases", "2020-03-01");
        public DatabaseAccountSqlDatabase(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabase(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountSqlDatabaseProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccountTable : Resource<DatabaseAccountTableProperties>
    {
        public DatabaseAccountTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/tables", "2020-03-01");
        public DatabaseAccountTable(string name) : this() => Name = name;
        public DatabaseAccountTable(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountTableProperties
    {
        public ResourceInfo Resource { get; set; }
        public OptionsInfo Options { get; set; }
    }

    public partial class DatabaseAccount : Resource<DatabaseAccountProperties>
    {
        public DatabaseAccount() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts", "2020-03-01");
        public DatabaseAccount(string name) : this() => Name = name;
        public DatabaseAccount(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class DatabaseAccountProperties
    {
        public ConsistencyPolicyInfo ConsistencyPolicy { get; set; }
        public IList<LocationInfo> Locations { get; set; }
        public string DatabaseAccountOfferType { get; set; }
        public string IpRangeFilter { get; set; }
        public bool? IsVirtualNetworkFilterEnabled { get; set; }
        public bool? EnableAutomaticFailover { get; set; }
        public IList<CapabilityInfo> Capabilities { get; set; }
        public IList<VirtualNetworkRuleInfo> VirtualNetworkRules { get; set; }
        public bool? EnableMultipleWriteLocations { get; set; }
        public bool? EnableCassandraConnector { get; set; }
        public string ConnectorOffer { get; set; }
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }
        public string KeyVaultKeyUri { get; set; }
        public string PublicNetworkAccess { get; set; }
    }

    public partial class ConsistencyPolicyInfo
    {
        public string DefaultConsistencyLevel { get; set; }
        public int? MaxStalenessPrefix { get; set; }
        public int? MaxIntervalInSeconds { get; set; }
    }

    public partial class LocationInfo
    {
        public string LocationName { get; set; }
        public int? FailoverPriority { get; set; }
        public bool? IsZoneRedundant { get; set; }
    }

    public partial class CapabilityInfo
    {
        public string Name { get; set; }
    }

    public partial class VirtualNetworkRuleInfo
    {
        public string Id { get; set; }
        public bool? IgnoreMissingVNetServiceEndpoint { get; set; }
    }
}
