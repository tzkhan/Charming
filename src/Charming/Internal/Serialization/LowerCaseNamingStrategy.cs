namespace Charming.Serialization
{
    using Newtonsoft.Json.Serialization;

    internal class LowerCaseNamingStrategy : NamingStrategy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "Lowercasing is intentionally needed here")]
        protected override string ResolvePropertyName(string name) => name?.ToLowerInvariant();
    }
}
