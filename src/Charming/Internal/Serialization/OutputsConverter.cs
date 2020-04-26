namespace Charming.Serialization
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    internal class OutputsConverter : JsonConverter<IList<Output>>
    {
        public override IList<Output> ReadJson(JsonReader reader, Type objectType, IList<Output> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, IList<Output> value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            writer.WriteStartObject();

            foreach (var item in value)
            {
                if (!item.Value.HasValue)
                {
                    continue;
                }

                writer.WritePropertyName(item.Key);

                writer.WriteStartObject();

                if (!string.IsNullOrWhiteSpace(item.Condition))
                {
                    writer.WritePropertyName("condition");
                    writer.WriteValue(item.Condition);
                }

                writer.WritePropertyName("type");
                writer.WriteValue(GetOutputType(item.Value));

                writer.WritePropertyName("value");
                WriteOutputValue(writer, item.Value);

                writer.WriteEndObject();
            }

            writer.WriteEndObject();
        }

        private static string GetOutputType(OutputValue value) =>
            value switch
            {
                ArrayOutputValue _ => "array",
                ObjectOutputValue o => BuildObjectOutputType(o),
                StringOutputValue s => BuildStringOutputType(s),
                _ => throw new JsonException("Unknown output value type."),
            };

        private static string BuildObjectOutputType(ObjectOutputValue o) =>
            $"{(o.IsSecure ? "secure" : string.Empty)}object";

        private static string BuildStringOutputType(StringOutputValue s) =>
            $"{(s.IsSecure ? "secure" : string.Empty)}{(s.IsObject ? "object" : "string")}";

        private static void WriteOutputValue(JsonWriter writer, OutputValue value)
        {
            switch (value)
            {
                case ArrayOutputValue a:
                    WriteArrayOutputValue(writer, a);
                    break;

                case ObjectOutputValue o:
                    WriteObjectOutputValue(writer, o);
                    break;

                case StringOutputValue s:
                    WriteStringOutputValue(writer, s);
                    break;
            }
        }

        private static void WriteArrayOutputValue(JsonWriter writer, ArrayOutputValue value)
        {
            writer.WriteStartArray();

            foreach (var item in value.Value)
            {
                WriteOutputValue(writer, item);
            }

            writer.WriteEndArray();
        }

        private static void WriteObjectOutputValue(JsonWriter writer, ObjectOutputValue value)
        {
            writer.WriteStartObject();

            foreach (var item in value.Value)
            {
                writer.WritePropertyName(item.Key);
                WriteOutputValue(writer, item.Value);
            }

            writer.WriteEndObject();
        }

        private static void WriteStringOutputValue(JsonWriter writer, StringOutputValue value)
        {
            writer.WriteValue(value.Value);
        }
    }
}
