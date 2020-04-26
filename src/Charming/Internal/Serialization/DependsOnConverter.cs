namespace Charming.Serialization
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    internal class DependsOnConverter : JsonConverter<IList<IResource>>
    {
        public override IList<IResource> ReadJson(JsonReader reader, Type objectType, IList<IResource> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, IList<IResource> value, JsonSerializer serializer)
        {
            writer.WriteStartArray();

            foreach (var item in value)
            {
                writer.WriteValue(item.Id);
            }

            writer.WriteEndArray();
        }
    }
}
