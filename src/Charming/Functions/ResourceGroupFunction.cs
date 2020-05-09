namespace Charming
{
    /// <summary>
    /// Object that represents the <c>resourceGroup()</c> function call.
    /// </summary>
    public sealed class ResourceGroupFunction : IFunction
    {
        private const string _template = "resourceGroup()";

        /// <summary>
        /// Gets the generated function call string including the <c>id</c> property.
        /// </summary>
        public string Id { get; } = $"{_template}.id";

        /// <summary>
        /// Gets the generated function call string including the <c>name</c> property.
        /// </summary>
        public string Name { get; } = $"{_template}.name";

        /// <summary>
        /// Gets the generated function call string including the <c>type</c> property.
        /// </summary>
        public string Type { get; } = $"{_template}.type";

        /// <summary>
        /// Gets the generated function call string including the <c>location</c> property.
        /// </summary>
        public string Location { get; } = $"{_template}.location";

        /// <summary>
        /// Gets the generated function call string including the <c>managedBy</c> property.
        /// </summary>
        public string ManagedBy { get; } = $"{_template}.managedBy";

        /// <summary>
        /// Gets the generated function call string including the <c>tags</c> property.
        /// </summary>
        public string Tags { get; } = $"{_template}.tags";

        /// <summary>
        /// Generates a string representing the <c>resourceGroup()</c> function call.
        /// </summary>
        /// <returns>A string representing the <c>resourceGroup()</c> function call.</returns>
        public string Invoke() => _template;

        /// <summary>
        /// Generates a string representing the <c>resourceGroup()</c> function call.
        /// </summary>
        /// <returns>A string representing the <c>resourceGroup()</c> function call.</returns>
        public override string ToString() => _template;
    }
}
