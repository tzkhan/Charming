namespace Charming
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Charming.Internal;

    /// <summary>
    /// Convenience extension methods to allow easy adding
    /// of items to some of the <see cref="ITemplate"/> properties.
    /// </summary>
    [DebuggerNonUserCode]
    public static class TemplateExtensions
    {
        /// <summary>
        /// Adds an array output to the template as a list of strings.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the array output.</param>
        /// <param name="values">List of string values to be added to the array output.</param>
        public static void AddArrayOutput(this ITemplate template, string key, params string[] values) =>
            template.Outputs.Add(Output.Array(key, values));

        /// <summary>
        /// Adds an array output to the template as a list of strings.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the array output.</param>
        /// <param name="values">List of string values to be added to the array output.</param>
        public static void AddArrayOutput(this ITemplate template, string key, IList<string> values) =>
            template.Outputs.Add(Output.Array(key, values));

        /// <summary>
        /// Adds an array output to the template as a list of objects.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the array output.</param>
        /// <param name="values">List of objects mapped as a dictionary of key value strings to be added to the array output.</param>
        public static void AddArrayOutput(this ITemplate template, string key, IList<Dictionary<string, string>> values) =>
            template.Outputs.Add(Output.Array(key, values));

        /// <summary>
        /// Adds an object output to the template.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the object output.</param>
        /// <param name="value">Value that the object output should be set to. Typically a resource name or a function call.</param>
        public static void AddObjectOutput(this ITemplate template, string key, string value) =>
            template.Outputs.Add(Output.Object(key, value, isSecure: false));

        /// <summary>
        /// Adds a secure object output to the template.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the object output.</param>
        /// <param name="value">Value that the object output should be set to. Typically a resource name or a function call.</param>
        public static void AddSecureObjectOutput(this ITemplate template, string key, string value) =>
            template.Outputs.Add(Output.Object(key, value, isSecure: true));

        /// <summary>
        /// Adds an object output to the template.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the object output.</param>
        /// <param name="value">A key value mapping that the object output should be set to.</param>
        public static void AddObjectOutput(this ITemplate template, string key, IDictionary<string, string> value) =>
            template.Outputs.Add(Output.Object(key, value, isSecure: false));

        /// <summary>
        /// Adds a secure object output to the template.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the object output.</param>
        /// <param name="value">A key value mapping that the object output should be set to.</param>
        public static void AddSecureObjectOutput(this ITemplate template, string key, IDictionary<string, string> value) =>
            template.Outputs.Add(Output.Object(key, value, isSecure: true));

        /// <summary>
        /// Adds a string output to the template.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the string output.</param>
        /// <param name="value">Value that the string output should be set to. Typically a reference to a resource name.</param>
        public static void AddStringOutput(this ITemplate template, string key, string value) =>
            template.Outputs.Add(Output.String(key, value, isSecure: false));

        /// <summary>
        /// Adds a secure string output to the template.
        /// </summary>
        /// <param name="template">Current template.</param>
        /// <param name="key">Value to use as a key for the string output.</param>
        /// <param name="value">Value that the string output should be set to.</param>
        public static void AddSecureStringOutput(this ITemplate template, string key, string value) =>
            template.Outputs.Add(Output.String(key, value, isSecure: true));

        /// <summary>
        /// Adds a sequence of resources to <see cref="ITemplate.Resources"/>.
        /// </summary>
        /// <typeparam name="TTemplate">A type representing a template.</typeparam>
        /// <param name="template">Current template.</param>
        /// <param name="resources">List of resources to deploy.</param>
        /// <returns>Returns the current template for chaining.</returns>
        public static TTemplate WithResources<TTemplate>(this TTemplate template, params Resource[] resources)
            where TTemplate : Template =>
            template.WithEnumerable(template.Resources, resources?.ToList());

        /// <summary>
        /// Adds a sequence of resources to <see cref="ITemplate.Resources"/>.
        /// </summary>
        /// <typeparam name="TTemplate">A type representing a template.</typeparam>
        /// <param name="template">Current template.</param>
        /// <param name="resources">List of resources to deploy.</param>
        /// <returns>Returns the current template for chaining.</returns>
        public static TTemplate WithResources<TTemplate>(this TTemplate template, IEnumerable<Resource> resources)
            where TTemplate : Template =>
            template.WithEnumerable(template.Resources, resources);

        /// <summary>
        /// Adds a sequence of outputs to <see cref="ITemplate.Outputs"/>.
        /// </summary>
        /// <typeparam name="TTemplate">A type representing a template.</typeparam>
        /// <param name="template">Current template.</param>
        /// <param name="outputs">List of outputs to display after deployment.</param>
        /// <returns>Returns the current template for chaining.</returns>
        public static TTemplate WithOutputs<TTemplate>(this TTemplate template, params Output[] outputs)
            where TTemplate : Template =>
            template.WithEnumerable(template.Outputs, outputs?.ToList());

        /// <summary>
        /// Adds a sequence of outputs to <see cref="ITemplate.Outputs"/>.
        /// </summary>
        /// <typeparam name="TTemplate">A type representing a template.</typeparam>
        /// <param name="template">Current template.</param>
        /// <param name="outputs">List of outputs to display after deployment.</param>
        /// <returns>Returns the current template for chaining.</returns>
        public static TTemplate WithOutputs<TTemplate>(this TTemplate template, IEnumerable<Output> outputs)
            where TTemplate : Template =>
            template.WithEnumerable(template.Outputs, outputs);

        private static TTemplate WithEnumerable<TTemplate, T>(
            this TTemplate template,
            ICollection<T> collection,
            IEnumerable<T>? enumerable)
            where TTemplate : Template
        {
            collection.AddEnumerable(enumerable);
            return template;
        }
    }
}
