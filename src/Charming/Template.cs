namespace Charming
{
    using System.Collections.Generic;
    using Charming.Internal;

    /// <inheritdoc/>
    public abstract class Template : ITemplate
    {
        /// <inheritdoc/>
        public string Schema { get; set; } = string.Empty;

        /// <inheritdoc/>
        public string ContentVersion { get; set; } = Constants.DefaultContentVersion;

        /// <inheritdoc/>
        public IList<Resource> Resources { get; } = new List<Resource>();

        /// <inheritdoc/>
        public IList<Output> Outputs { get; } = new List<Output>();

        /// <inheritdoc/>
        public string ToJson() =>
            Serializer.Serialize(this);

        /// <inheritdoc/>
        public string ToJson(SerializerOptions options) =>
            Serializer.Serialize(this, options);
    }
}
