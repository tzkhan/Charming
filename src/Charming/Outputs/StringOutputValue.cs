namespace Charming
{
    /// <summary>
    /// Represents a string output in a template.
    /// </summary>
    public sealed class StringOutputValue : OutputValue
    {
        /// <summary>
        /// Gets or sets a value indicating whether the returned output would be of object type.
        /// </summary>
        public bool IsObject { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use a secure string output.
        /// </summary>
        public bool IsSecure { get; set; }

        /// <summary>
        /// Gets or sets a value for the string output.
        /// </summary>
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets a value indicating whether a value for the string output has been set.
        /// </summary>
        public override bool HasValue => !string.IsNullOrWhiteSpace(Value);
    }
}
