#pragma warning disable CA1720
namespace Charming
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a template output item.
    /// </summary>
    public sealed class Output
    {
        private static readonly EmptyOutputValue Empty = new EmptyOutputValue();

        /// <summary>
        /// Gets or sets the output key.
        /// </summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the output value.
        /// This can be one of three types:
        /// <see cref="ArrayOutputValue"/>
        /// <see cref="ObjectOutputValue"/>
        /// <see cref="StringOutputValue"/>.
        /// </summary>
        public OutputValue Value { get; set; } = Empty;

        /// <summary>
        /// Creates an array output as a list of strings.
        /// </summary>
        /// <param name="key">Value to use as a key for the array output.</param>
        /// <param name="values">List of string values to be added to the array output.</param>
        /// <returns>Array output with a list of strings.</returns>
        public static Output Array(string key, params string[] values) =>
            Array(key, values.ToList());

        /// <summary>
        /// Creates an array output as a list of strings.
        /// </summary>
        /// <param name="key">Value to use as a key for the array output.</param>
        /// <param name="values">List of string values to be added to the array output.</param>
        /// <returns>Array output with a list of strings.</returns>
        public static Output Array(string key, IList<string> values) =>
            new Output
            {
                Key = key,
                Value = new ArrayOutputValue
                {
                    Value = values
                        .Select(x => new StringOutputValue { Value = x })
                        .Cast<OutputValue>()
                        .ToList(),
                },
            };

        /// <summary>
        /// Creates an array output as a list of objects.
        /// </summary>
        /// <param name="key">Value to use as a key for the array output.</param>
        /// <param name="values">List of objects mapped as a dictionary of key value strings to be added to the array output.</param>
        /// <returns>Array output with a list of objects.</returns>
        public static Output Array(string key, IList<Dictionary<string, string>> values) =>
            new Output
            {
                Key = key,
                Value = new ArrayOutputValue
                {
                    Value = values
                        .Select(x => new ObjectOutputValue { Value = x.ToStringOutputValueDictionary() })
                        .Cast<OutputValue>()
                        .ToList(),
                },
            };

        /// <summary>
        /// Creates an object output.
        /// </summary>
        /// <param name="key">Value to use as a key for the object output.</param>
        /// <param name="value">Value that the object output should be set to. Typically a resource name or a function call.</param>
        /// <param name="isSecure">Indicates whether to set the output type to <c>object</c> or <c>secureobject</c>.</param>
        /// <returns>Object output.</returns>
        public static Output Object(string key, string value, bool isSecure = default) =>
            new Output
            {
                Key = key,
                Value = new StringOutputValue
                {
                    IsObject = true,
                    IsSecure = isSecure,
                    Value = value,
                },
            };

        /// <summary>
        /// Creates an object output.
        /// </summary>
        /// <param name="key">Value to use as a key for the object output.</param>
        /// <param name="value">A key value mapping that the object output should be set to.</param>
        /// <param name="isSecure">Indicates whether to set the output type to <c>object</c> or <c>secureobject</c>.</param>
        /// <returns>Object output.</returns>
        public static Output Object(string key, IDictionary<string, string> value, bool isSecure = default) =>
            new Output
            {
                Key = key,
                Value = new ObjectOutputValue
                {
                    IsSecure = isSecure,
                    Value = value.ToStringOutputValueDictionary(),
                },
            };

        /// <summary>
        /// Creates a string output.
        /// </summary>
        /// <param name="key">Value to use as a key for the string output.</param>
        /// <param name="value">Value that the string output should be set to.</param>
        /// <param name="isSecure">Indicates whether to set the output type to <c>string</c> or <c>securestring</c>.</param>
        /// <returns>String output.</returns>
        public static Output String(string key, string value, bool isSecure = default) =>
            new Output
            {
                Key = key,
                Value = new StringOutputValue
                {
                    IsObject = false,
                    IsSecure = isSecure,
                    Value = value,
                },
            };
    }
}
