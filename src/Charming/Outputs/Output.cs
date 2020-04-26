namespace Charming
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class Output
    {
        public string? Condition { get; set; }

        public string Key { get; set; }

        public OutputValue Value { get; set; }

        public static Output Array(string key, params string[] values) =>
            Array(key, values.ToList());

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
