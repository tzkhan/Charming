namespace Charming
{
    using Charming.Serialization;
    using Newtonsoft.Json;

    public static class Publisher
    {
        public static void Publish(ITemplate template, string filePath)
        {
            if (template == null)
            {
                return;
            }

            var settings = new JsonSerializerSettings
            {
                ContractResolver = TemplateContractResolver.Instance,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            };

            string json = JsonConvert.SerializeObject(template, settings);

            System.IO.File.WriteAllText(filePath, json);
        }
    }
}
