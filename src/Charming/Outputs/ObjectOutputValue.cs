namespace Charming
{
    using System.Collections.Generic;

    public sealed class ObjectOutputValue : OutputValue
    {
        public bool IsSecure { get; set; }

        public IDictionary<string, OutputValue> Value { get; internal set; } = new Dictionary<string, OutputValue>();

        public override bool HasValue => Value?.Count > 0;
    }
}
