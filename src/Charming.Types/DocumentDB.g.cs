namespace Charming.Types.DocumentDB
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class DatabaseAccountApiDatabaseCollection : Resource<DatabaseAccountApiDatabaseCollectionProperties>
    {
        public DatabaseAccountApiDatabaseCollection() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases/collections", "2016-03-31");
        public DatabaseAccountApiDatabaseCollection(string name) : this() => Name = name;
        public DatabaseAccountApiDatabaseCollection(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountApiDatabaseCollection WithProperties(Action<DatabaseAccountApiDatabaseCollectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountApiDatabaseCollectionProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        public object Options { get; set; }
    }

    public class ResourceInfo : PropertyBase
    {

        public string Id { get; set; }

        public object ShardKey { get; set; }

        public IList<IndexeInfo> Indexes { get; set; }
    }

    public class IndexeInfo : PropertyBase
    {

        private KeyInfo _key;
        public KeyInfo Key
        {
            get => _key = Get(_key);
            set => _key = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class KeyInfo : PropertyBase
    {

        public IList<string> Keys { get; set; }
    }

    public class OptionsInfo : PropertyBase
    {

        public int? ExpireAfterSeconds { get; set; }

        public bool? Unique { get; set; }
    }

    public class DatabaseAccountApiDatabaseContainer : Resource<DatabaseAccountApiDatabaseContainerProperties>
    {
        public DatabaseAccountApiDatabaseContainer() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases/containers", "2016-03-31");
        public DatabaseAccountApiDatabaseContainer(string name) : this() => Name = name;
        public DatabaseAccountApiDatabaseContainer(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountApiDatabaseContainer WithProperties(Action<DatabaseAccountApiDatabaseContainerProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountApiDatabaseContainerProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        public object Options { get; set; }
    }

    public class IndexingPolicyInfo : PropertyBase
    {

        public bool? Automatic { get; set; }

        public string IndexingMode { get; set; }

        public IList<IncludedPathInfo> IncludedPaths { get; set; }

        public IList<ExcludedPathInfo> ExcludedPaths { get; set; }
    }

    public class IncludedPathInfo : PropertyBase
    {

        public string Path { get; set; }

        public IList<IndexeInfo> Indexes { get; set; }
    }

    public class ExcludedPathInfo : PropertyBase
    {

        public string Path { get; set; }
    }

    public class PartitionKeyInfo : PropertyBase
    {

        public IList<string> Paths { get; set; }

        public string Kind { get; set; }
    }

    public class UniqueKeyPolicyInfo : PropertyBase
    {

        public IList<UniqueKeyInfo> UniqueKeys { get; set; }
    }

    public class UniqueKeyInfo : PropertyBase
    {

        public IList<string> Paths { get; set; }
    }

    public class ConflictResolutionPolicyInfo : PropertyBase
    {

        public string Mode { get; set; }

        public string ConflictResolutionPath { get; set; }

        public string ConflictResolutionProcedure { get; set; }
    }

    public class DatabaseAccountApiDatabaseGraph : Resource<DatabaseAccountApiDatabaseGraphProperties>
    {
        public DatabaseAccountApiDatabaseGraph() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases/graphs", "2016-03-31");
        public DatabaseAccountApiDatabaseGraph(string name) : this() => Name = name;
        public DatabaseAccountApiDatabaseGraph(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountApiDatabaseGraph WithProperties(Action<DatabaseAccountApiDatabaseGraphProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountApiDatabaseGraphProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        public object Options { get; set; }
    }

    public class DatabaseAccountApiDatabase : Resource<DatabaseAccountApiDatabaseProperties>
    {
        public DatabaseAccountApiDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/databases", "2016-03-31");
        public DatabaseAccountApiDatabase(string name) : this() => Name = name;
        public DatabaseAccountApiDatabase(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountApiDatabase WithProperties(Action<DatabaseAccountApiDatabaseProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountApiDatabaseProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        public object Options { get; set; }
    }

    public class DatabaseAccountApiKeyspaceTable : Resource<DatabaseAccountApiKeyspaceTableProperties>
    {
        public DatabaseAccountApiKeyspaceTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/tables", "2016-03-31");
        public DatabaseAccountApiKeyspaceTable(string name) : this() => Name = name;
        public DatabaseAccountApiKeyspaceTable(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountApiKeyspaceTable WithProperties(Action<DatabaseAccountApiKeyspaceTableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountApiKeyspaceTableProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        public object Options { get; set; }
    }

    public class SchemaInfo : PropertyBase
    {

        public IList<ColumnInfo> Columns { get; set; }

        public IList<PartitionKeyInfo> PartitionKeys { get; set; }

        public IList<ClusterKeyInfo> ClusterKeys { get; set; }
    }

    public class ColumnInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Type { get; set; }
    }

    public class ClusterKeyInfo : PropertyBase
    {

        public string Name { get; set; }

        public string OrderBy { get; set; }
    }

    public class DatabaseAccountApiKeyspace : Resource<DatabaseAccountApiKeyspaceProperties>
    {
        public DatabaseAccountApiKeyspace() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces", "2016-03-31");
        public DatabaseAccountApiKeyspace(string name) : this() => Name = name;
        public DatabaseAccountApiKeyspace(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountApiKeyspace WithProperties(Action<DatabaseAccountApiKeyspaceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountApiKeyspaceProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        public object Options { get; set; }
    }

    public class DatabaseAccountApiTable : Resource<DatabaseAccountApiTableProperties>
    {
        public DatabaseAccountApiTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/apis/tables", "2016-03-31");
        public DatabaseAccountApiTable(string name) : this() => Name = name;
        public DatabaseAccountApiTable(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountApiTable WithProperties(Action<DatabaseAccountApiTableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountApiTableProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        public object Options { get; set; }
    }

    public class DatabaseAccountCassandraKeyspaceTable : Resource<DatabaseAccountCassandraKeyspaceTableProperties>
    {
        public DatabaseAccountCassandraKeyspaceTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables", "2020-03-01");
        public DatabaseAccountCassandraKeyspaceTable(string name) : this() => Name = name;
        public DatabaseAccountCassandraKeyspaceTable(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountCassandraKeyspaceTable WithProperties(Action<DatabaseAccountCassandraKeyspaceTableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountCassandraKeyspaceTableProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountCassandraKeyspace : Resource<DatabaseAccountCassandraKeyspaceProperties>
    {
        public DatabaseAccountCassandraKeyspace() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces", "2020-03-01");
        public DatabaseAccountCassandraKeyspace(string name) : this() => Name = name;
        public DatabaseAccountCassandraKeyspace(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountCassandraKeyspace WithProperties(Action<DatabaseAccountCassandraKeyspaceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountCassandraKeyspaceProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountGremlinDatabaseGraph : Resource<DatabaseAccountGremlinDatabaseGraphProperties>
    {
        public DatabaseAccountGremlinDatabaseGraph() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/graphs", "2020-03-01");
        public DatabaseAccountGremlinDatabaseGraph(string name) : this() => Name = name;
        public DatabaseAccountGremlinDatabaseGraph(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountGremlinDatabaseGraph WithProperties(Action<DatabaseAccountGremlinDatabaseGraphProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountGremlinDatabaseGraphProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class SpatialIndexeInfo : PropertyBase
    {

        public string Path { get; set; }

        public IList<string> Types { get; set; }
    }

    public class DatabaseAccountGremlinDatabase : Resource<DatabaseAccountGremlinDatabaseProperties>
    {
        public DatabaseAccountGremlinDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/gremlinDatabases", "2020-03-01");
        public DatabaseAccountGremlinDatabase(string name) : this() => Name = name;
        public DatabaseAccountGremlinDatabase(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountGremlinDatabase WithProperties(Action<DatabaseAccountGremlinDatabaseProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountGremlinDatabaseProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountMongodbDatabaseCollection : Resource<DatabaseAccountMongodbDatabaseCollectionProperties>
    {
        public DatabaseAccountMongodbDatabaseCollection() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/collections", "2020-03-01");
        public DatabaseAccountMongodbDatabaseCollection(string name) : this() => Name = name;
        public DatabaseAccountMongodbDatabaseCollection(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountMongodbDatabaseCollection WithProperties(Action<DatabaseAccountMongodbDatabaseCollectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountMongodbDatabaseCollectionProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private PropertiesOptionsInfo _options;
        public PropertiesOptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class PropertiesOptionsInfo : PropertyBase
    {

        public object AdditionalProperties { get; set; }

        public string Throughput { get; set; }
    }

    public class DatabaseAccountMongodbDatabase : Resource<DatabaseAccountMongodbDatabaseProperties>
    {
        public DatabaseAccountMongodbDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/mongodbDatabases", "2020-03-01");
        public DatabaseAccountMongodbDatabase(string name) : this() => Name = name;
        public DatabaseAccountMongodbDatabase(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountMongodbDatabase WithProperties(Action<DatabaseAccountMongodbDatabaseProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountMongodbDatabaseProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountSqlDatabaseContainerStoredProcedure : Resource<DatabaseAccountSqlDatabaseContainerStoredProcedureProperties>
    {
        public DatabaseAccountSqlDatabaseContainerStoredProcedure() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/storedProcedures", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainerStoredProcedure(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainerStoredProcedure(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountSqlDatabaseContainerStoredProcedure WithProperties(Action<DatabaseAccountSqlDatabaseContainerStoredProcedureProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountSqlDatabaseContainerStoredProcedureProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountSqlDatabaseContainerTrigger : Resource<DatabaseAccountSqlDatabaseContainerTriggerProperties>
    {
        public DatabaseAccountSqlDatabaseContainerTrigger() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/triggers", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainerTrigger(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainerTrigger(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountSqlDatabaseContainerTrigger WithProperties(Action<DatabaseAccountSqlDatabaseContainerTriggerProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountSqlDatabaseContainerTriggerProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountSqlDatabaseContainerUserDefinedFunction : Resource<DatabaseAccountSqlDatabaseContainerUserDefinedFunctionProperties>
    {
        public DatabaseAccountSqlDatabaseContainerUserDefinedFunction() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/userDefinedFunctions", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainerUserDefinedFunction(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainerUserDefinedFunction(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountSqlDatabaseContainerUserDefinedFunction WithProperties(Action<DatabaseAccountSqlDatabaseContainerUserDefinedFunctionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountSqlDatabaseContainerUserDefinedFunctionProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountSqlDatabaseContainer : Resource<DatabaseAccountSqlDatabaseContainerProperties>
    {
        public DatabaseAccountSqlDatabaseContainer() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers", "2020-03-01");
        public DatabaseAccountSqlDatabaseContainer(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabaseContainer(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountSqlDatabaseContainer WithProperties(Action<DatabaseAccountSqlDatabaseContainerProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountSqlDatabaseContainerProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountSqlDatabase : Resource<DatabaseAccountSqlDatabaseProperties>
    {
        public DatabaseAccountSqlDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases", "2020-03-01");
        public DatabaseAccountSqlDatabase(string name) : this() => Name = name;
        public DatabaseAccountSqlDatabase(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountSqlDatabase WithProperties(Action<DatabaseAccountSqlDatabaseProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountSqlDatabaseProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccountTable : Resource<DatabaseAccountTableProperties>
    {
        public DatabaseAccountTable() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/tables", "2020-03-01");
        public DatabaseAccountTable(string name) : this() => Name = name;
        public DatabaseAccountTable(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccountTable WithProperties(Action<DatabaseAccountTableProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountTableProperties : PropertyBase
    {

        private ResourceInfo _resource;
        public ResourceInfo Resource
        {
            get => _resource = Get(_resource);
            set => _resource = value;
        }

        private OptionsInfo _options;
        public OptionsInfo Options
        {
            get => _options = Get(_options);
            set => _options = value;
        }
    }

    public class DatabaseAccount : Resource<DatabaseAccountProperties>
    {
        public DatabaseAccount() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts", "2020-03-01");
        public DatabaseAccount(string name) : this() => Name = name;
        public DatabaseAccount(string name, Location location) : this() => (Name, Location) = (name, location);

        public DatabaseAccount WithProperties(Action<DatabaseAccountProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DatabaseAccountProperties : PropertyBase
    {

        private ConsistencyPolicyInfo _consistencyPolicy;
        public ConsistencyPolicyInfo ConsistencyPolicy
        {
            get => _consistencyPolicy = Get(_consistencyPolicy);
            set => _consistencyPolicy = value;
        }

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

    public class ConsistencyPolicyInfo : PropertyBase
    {

        public string DefaultConsistencyLevel { get; set; }

        public int? MaxStalenessPrefix { get; set; }

        public int? MaxIntervalInSeconds { get; set; }
    }

    public class LocationInfo : PropertyBase
    {

        public string LocationName { get; set; }

        public int? FailoverPriority { get; set; }

        public bool? IsZoneRedundant { get; set; }
    }

    public class CapabilityInfo : PropertyBase
    {

        public string Name { get; set; }
    }

    public class VirtualNetworkRuleInfo : PropertyBase
    {

        public string Id { get; set; }

        public bool? IgnoreMissingVNetServiceEndpoint { get; set; }
    }
}
