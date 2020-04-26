namespace Charming
{
    public sealed class StringOutputValue : OutputValue
    {
        public bool IsObject { get; set; }

        public bool IsSecure { get; set; }

        public string Value { get; set; }

        public override bool HasValue => !string.IsNullOrWhiteSpace(Value);
    }
}
