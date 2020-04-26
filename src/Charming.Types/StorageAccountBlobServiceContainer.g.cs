namespace Charming.Types.Storage
{
    using Charming;

    public class StorageAccountBlobServiceContainer : Resource<StorageAccountBlobServiceContainer.PropertyCollection>
    {
        public StorageAccountBlobServiceContainer() => (Type, ApiVersion) = ("Microsoft.Storage/storageAccounts/blobServices/containers", "2019-06-01");

        public partial class PropertyCollection
        {
            public string PublicAccess { get; set; }
            public object Metadata { get; set; }
        }
    }
}
