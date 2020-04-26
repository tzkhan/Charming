namespace Charming.Types.ServiceBus
{
    using Charming;
    using System.Collections.Generic;

    public class NamespaceTopicAuthorizationRule : Resource<NamespaceTopicAuthorizationRule.PropertyCollection>
    {
        public NamespaceTopicAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics/authorizationRules", "2017-04-01");

        public partial class PropertyCollection
        {
            public IList<string> Rights { get; set; }
        }
    }
}
