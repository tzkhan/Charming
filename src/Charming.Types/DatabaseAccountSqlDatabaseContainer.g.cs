namespace Charming.Types.DocumentDB
{
    using Charming;
    using System.Collections.Generic;

    public class DatabaseAccountSqlDatabaseContainer : Resource<DatabaseAccountSqlDatabaseContainer.PropertyCollection>
    {
        public DatabaseAccountSqlDatabaseContainer() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers", "2020-03-01");

        public partial class PropertyCollection
        {
            public ResourceInfo Resource { get; set; }
            public OptionsInfo Options { get; set; }
        }

        public partial class ResourceInfo
        {
            public string Id { get; set; }
            public IndexingPolicyInfo IndexingPolicy { get; set; }
            public PartitionKeyInfo PartitionKey { get; set; }
            public int? DefaultTtl { get; set; }
            public UniqueKeyPolicyInfo UniqueKeyPolicy { get; set; }
            public ConflictResolutionPolicyInfo ConflictResolutionPolicy { get; set; }
        }

        public partial class IndexingPolicyInfo
        {
            public bool? Automatic { get; set; }
            public string IndexingMode { get; set; }
            public IList<IncludedPathInfo> IncludedPaths { get; set; }
            public IList<ExcludedPathInfo> ExcludedPaths { get; set; }
            public IList<SpatialIndexeInfo> SpatialIndexes { get; set; }
        }

        public partial class IncludedPathInfo
        {
            public string Path { get; set; }
            public IList<IndexeInfo> Indexes { get; set; }
        }

        public partial class IndexeInfo
        {
            public string DataType { get; set; }
            public int? Precision { get; set; }
            public string Kind { get; set; }
        }

        public partial class ExcludedPathInfo
        {
            public string Path { get; set; }
        }

        public partial class SpatialIndexeInfo
        {
            public string Path { get; set; }
            public IList<string> Types { get; set; }
        }

        public partial class PartitionKeyInfo
        {
            public IList<string> Paths { get; set; }
            public string Kind { get; set; }
            public int? Version { get; set; }
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

        public partial class OptionsInfo
        {
            public object AdditionalProperties { get; set; }
            public string Throughput { get; set; }
        }
    }
}
