namespace Charming.Internal
{
    using Newtonsoft.Json.Serialization;

    internal class LowerCaseNamingStrategy : NamingStrategy
    {
#pragma warning disable CA1308
        protected override string ResolvePropertyName(string name) => name.ToLowerInvariant();
    }
}
