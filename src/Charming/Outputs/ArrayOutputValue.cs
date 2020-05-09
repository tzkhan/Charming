namespace Charming
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents an array output in a template.
    /// </summary>
    public sealed class ArrayOutputValue : OutputValue
    {
        /// <summary>
        /// Gets a list of either all string or all object outputs.
        /// </summary>
        public IList<OutputValue> Value { get; internal set; } = new List<OutputValue>();

        /// <summary>
        /// Gets a value indicating whether any items have been added to the array output.
        /// </summary>
        public override bool HasValue => Value?.Count > 0;
    }
}
