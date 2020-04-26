namespace Charming
{
    using System.Collections.Generic;

    public static class TemplateExtensions
    {
        public static void AddArrayOutput(this ITemplate template, string key, params string[] values) =>
            template?.Outputs.Add(Output.Array(key, values));

        public static void AddArrayOutput(this ITemplate template, string key, IList<string> values) =>
            template?.Outputs.Add(Output.Array(key, values));

        public static void AddArrayOutput(this ITemplate template, string key, IList<Dictionary<string, string>> values) =>
            template?.Outputs.Add(Output.Array(key, values));

        public static void AddObjectOutput(this ITemplate template, string key, string value) =>
            template?.Outputs.Add(Output.Object(key, value, isSecure: false));

        public static void AddSecureObjectOutput(this ITemplate template, string key, string value) =>
            template?.Outputs.Add(Output.Object(key, value, isSecure: true));

        public static void AddObjectOutput(this ITemplate template, string key, IDictionary<string, string> value) =>
            template?.Outputs.Add(Output.Object(key, value, isSecure: false));

        public static void AddSecureObjectOutput(this ITemplate template, string key, IDictionary<string, string> value) =>
            template?.Outputs.Add(Output.Object(key, value, isSecure: true));

        public static void AddStringOutput(this ITemplate template, string key, string value) =>
            template?.Outputs.Add(Output.String(key, value, isSecure: false));

        public static void AddSecureStringOutput(this ITemplate template, string key, string value) =>
            template?.Outputs.Add(Output.String(key, value, isSecure: true));
    }
}
