namespace Charming
{
    using System.Diagnostics;

    /// <summary>
    /// Convenience extension methods for a string.
    /// </summary>
    [DebuggerNonUserCode]
    public static class StringExtensions
    {
        /// <summary>
        /// Removes all dashes (hyphens) from a given string.
        /// </summary>
        /// <param name="value">String to remove dashes from.</param>
        /// <returns>String with dashes removed.</returns>
        public static string DeDash(this string value) =>
            value?.Replace("-", string.Empty) ?? string.Empty;
    }
}
