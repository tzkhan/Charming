namespace Charming.Internal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    internal class DependsOnConverter : JsonConverter<IList<Resource>>
    {
        public override IList<Resource> ReadJson(JsonReader reader, Type objectType, IList<Resource> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, IList<Resource> value, JsonSerializer serializer)
        {
            writer.WriteStartArray();

            foreach (var item in value)
            {
                writer.WriteValue(Functions.ResourceId(item).Box());
            }

            writer.WriteEndArray();
        }
    }
}
