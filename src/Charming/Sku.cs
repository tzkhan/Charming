#pragma warning disable CS1591, SA1600
namespace Charming
{
    public class Sku
    {
        public string Name { get; set; } = string.Empty;

        public string? Tier { get; set; }

        public string? Size { get; set; }

        public string? Family { get; set; }

        public string? Capacity { get; set; }
    }
}
