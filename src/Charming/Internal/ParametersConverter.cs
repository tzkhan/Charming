namespace Charming.Internal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    internal class ParametersConverter : JsonConverter<IList<Parameter>>
    {
        public override IList<Parameter> ReadJson(JsonReader reader, Type objectType, IList<Parameter> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, IList<Parameter> value, JsonSerializer serializer)
        {
            if (value is null)
            {
                return;
            }

            writer.WriteStartObject();

            foreach (var item in value)
            {
                if (!item.IsValid)
                {
                    continue;
                }

                writer.WritePropertyName(item.Name);

                writer.WriteStartObject();

                writer.WritePropertyName("value");
                writer.WriteValue(item.Value);

                writer.WriteEndObject();
            }

            writer.WriteEndObject();
        }
    }
}
