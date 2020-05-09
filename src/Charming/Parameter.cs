namespace Charming
{
    /// <summary>
    /// Represents a parameter that can be passed to a nested deployment template.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Gets or sets the parameter name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the parameter value.
        /// </summary>
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets a value indicating whether the parameter is in a valid state.
        /// </summary>
        public bool IsValid =>
            !string.IsNullOrWhiteSpace(Name)
            && !string.IsNullOrWhiteSpace(Value);
    }
}
