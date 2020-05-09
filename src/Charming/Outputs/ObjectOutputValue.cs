namespace Charming
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents an object output in a template.
    /// </summary>
    public sealed class ObjectOutputValue : OutputValue
    {
        /// <summary>
        /// Gets or sets a value indicating whether to use a secure object output.
        /// </summary>
        public bool IsSecure { get; set; }

        /// <summary>
        /// Gets a mapping of key and other <c>OutputValue</c> items to be included in the object output.
        /// </summary>
        public IDictionary<string, OutputValue> Value { get; internal set; } = new Dictionary<string, OutputValue>();

        /// <summary>
        /// Gets a value indicating whether any items have been added to the object output.
        /// </summary>
        public override bool HasValue => Value?.Count > 0;
    }
}
