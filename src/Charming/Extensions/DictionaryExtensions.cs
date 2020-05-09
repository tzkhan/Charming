namespace Charming
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Convenience extension methods for a dictionary.
    /// </summary>
    [DebuggerNonUserCode]
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Converts a given string key value dictionary to a
        /// string -> <see cref="StringOutputValue" /> dictionary.
        /// </summary>
        /// <param name="dictionary">Dictionary to convert.</param>
        /// <returns>Converted <see cref="StringOutputValue" /> based dictionary.</returns>
        public static IDictionary<string, OutputValue> ToStringOutputValueDictionary(this IDictionary<string, string> dictionary) =>
            dictionary.ToDictionary(x => x.Key, x => new StringOutputValue { Value = x.Value } as OutputValue);
    }
}
