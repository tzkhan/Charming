namespace Charming.Types.DocumentDB
{
    using Charming;

    public class DatabaseAccountSqlDatabase : Resource<DatabaseAccountSqlDatabase.PropertyCollection>
    {
        public DatabaseAccountSqlDatabase() => (Type, ApiVersion) = ("Microsoft.DocumentDB/databaseAccounts/sqlDatabases", "2020-03-01");

        public partial class PropertyCollection
        {
            public ResourceInfo Resource { get; set; }
            public OptionsInfo Options { get; set; }
        }

        public partial class ResourceInfo
        {
            public string Id { get; set; }
        }

        public partial class OptionsInfo
        {
            public object AdditionalProperties { get; set; }
            public string Throughput { get; set; }
        }
    }
}
