namespace Charming
{
    using System.Collections.Generic;

    public sealed class ArrayOutputValue : OutputValue
    {
        public IList<OutputValue> Value { get; internal set; } = new List<OutputValue>();

        public override bool HasValue => Value?.Count > 0;
    }
}
