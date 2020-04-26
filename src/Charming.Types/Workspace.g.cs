namespace Charming.Types.OperationalInsights
{
    using Charming;

    public class Workspace : Resource<Workspace.PropertyCollection>
    {
        public Workspace() => (Type, ApiVersion) = ("Microsoft.OperationalInsights/workspaces", "2015-11-01-preview");

        public partial class PropertyCollection
        {
            public SkuInfo Sku { get; set; }
            public int? RetentionInDays { get; set; }
        }

        public partial class SkuInfo
        {
            public string Name { get; set; }
        }
    }
}
