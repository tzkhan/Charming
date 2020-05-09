namespace Charming.Internal
{
    using Newtonsoft.Json;

    internal static class Serializer
    {
        public static string Serialize(ITemplate template, SerializerOptions? options = default)
        {
            if (template is null)
            {
                return string.Empty;
            }

            TemplateMetadataManager.SetMetadata(template);

            options ??= new SerializerOptions
            {
                Indent = true,
            };

            var jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = TemplateContractResolver.Instance,
                Formatting = options.Indent ? Formatting.Indented : Formatting.None,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            return JsonConvert.SerializeObject(template, jsonSettings);
        }
    }
}
