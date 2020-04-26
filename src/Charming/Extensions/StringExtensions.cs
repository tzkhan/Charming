namespace Charming
{
    public static class StringExtensions
    {
        public static string DeDash(this string value) =>
            value?.Replace("-", string.Empty) ?? string.Empty;
    }
}
