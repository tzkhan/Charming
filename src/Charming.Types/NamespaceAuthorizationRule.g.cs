namespace Charming.Types.ServiceBus
{
    using Charming;
    using System.Collections.Generic;

    public class NamespaceAuthorizationRule : Resource<NamespaceAuthorizationRule.PropertyCollection>
    {
        public NamespaceAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/AuthorizationRules", "2017-04-01");

        public partial class PropertyCollection
        {
            public IList<string> Rights { get; set; }
        }
    }
}
