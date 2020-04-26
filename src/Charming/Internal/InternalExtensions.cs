namespace Charming
{
    using System.Collections.Generic;
    using System.Linq;

    internal static class InternalExtensions
    {
        public static IDictionary<string, OutputValue> ToStringOutputValueDictionary(this IDictionary<string, string> dictionary) =>
            dictionary.ToDictionary(x => x.Key, x => new StringOutputValue { Value = x.Value } as OutputValue);
    }
}
