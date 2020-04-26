namespace Charming.Types.Resources
{
    using Charming;

    public class ResourceGroup : Resource<ResourceGroup.PropertyCollection>
    {
        public ResourceGroup() => (Type, ApiVersion) = ("Microsoft.Resources/resourceGroups", "2019-10-01");

        public partial class PropertyCollection
        {
        }
    }
}
