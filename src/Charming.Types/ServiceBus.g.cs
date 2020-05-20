namespace Charming.Types.ServiceBus
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class NamespaceAuthorizationRule : Resource<NamespaceAuthorizationRuleProperties>
    {
        public NamespaceAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/AuthorizationRules", "2017-04-01");
        public NamespaceAuthorizationRule(string name) : this() => Name = name;
        public NamespaceAuthorizationRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceAuthorizationRule WithProperties(Action<NamespaceAuthorizationRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceAuthorizationRuleProperties : PropertyBase
    {

        public IList<string> Rights { get; set; }
    }

    public class NamespaceDisasterRecoveryConfig : Resource<NamespaceDisasterRecoveryConfigProperties>
    {
        public NamespaceDisasterRecoveryConfig() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs", "2017-04-01");
        public NamespaceDisasterRecoveryConfig(string name) : this() => Name = name;
        public NamespaceDisasterRecoveryConfig(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceDisasterRecoveryConfig WithProperties(Action<NamespaceDisasterRecoveryConfigProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceDisasterRecoveryConfigProperties : PropertyBase
    {

        public string PartnerNamespace { get; set; }

        public string AlternateName { get; set; }
    }

    public class NamespaceIpfilterrule : Resource<NamespaceIpfilterruleProperties>
    {
        public NamespaceIpfilterrule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/ipfilterrules", "2018-01-01-preview");
        public NamespaceIpfilterrule(string name) : this() => Name = name;
        public NamespaceIpfilterrule(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceIpfilterrule WithProperties(Action<NamespaceIpfilterruleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceIpfilterruleProperties : PropertyBase
    {

        public string IpMask { get; set; }

        public string Action { get; set; }

        public string FilterName { get; set; }
    }

    public class NamespaceMigrationConfiguration : Resource<NamespaceMigrationConfigurationProperties>
    {
        public NamespaceMigrationConfiguration() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/migrationConfigurations", "2017-04-01");
        public NamespaceMigrationConfiguration(string name) : this() => Name = name;
        public NamespaceMigrationConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceMigrationConfiguration WithProperties(Action<NamespaceMigrationConfigurationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceMigrationConfigurationProperties : PropertyBase
    {

        public string TargetNamespace { get; set; }

        public string PostMigrationName { get; set; }
    }

    public class NamespaceQueueAuthorizationRule : Resource<NamespaceQueueAuthorizationRuleProperties>
    {
        public NamespaceQueueAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/queues/authorizationRules", "2017-04-01");
        public NamespaceQueueAuthorizationRule(string name) : this() => Name = name;
        public NamespaceQueueAuthorizationRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceQueueAuthorizationRule WithProperties(Action<NamespaceQueueAuthorizationRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceQueueAuthorizationRuleProperties : PropertyBase
    {

        public IList<string> Rights { get; set; }
    }

    public class NamespaceQueue : Resource<NamespaceQueueProperties>
    {
        public NamespaceQueue() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/queues", "2017-04-01");
        public NamespaceQueue(string name) : this() => Name = name;
        public NamespaceQueue(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceQueue WithProperties(Action<NamespaceQueueProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceQueueProperties : PropertyBase
    {

        public string LockDuration { get; set; }

        public int? MaxSizeInMegabytes { get; set; }

        public bool? RequiresDuplicateDetection { get; set; }

        public bool? RequiresSession { get; set; }

        public string DefaultMessageTimeToLive { get; set; }

        public bool? DeadLetteringOnMessageExpiration { get; set; }

        public string DuplicateDetectionHistoryTimeWindow { get; set; }

        public int? MaxDeliveryCount { get; set; }

        public string Status { get; set; }

        public bool? EnableBatchedOperations { get; set; }

        public string AutoDeleteOnIdle { get; set; }

        public bool? EnablePartitioning { get; set; }

        public bool? EnableExpress { get; set; }

        public string ForwardTo { get; set; }

        public string ForwardDeadLetteredMessagesTo { get; set; }
    }

    public class NamespaceTopicAuthorizationRule : Resource<NamespaceTopicAuthorizationRuleProperties>
    {
        public NamespaceTopicAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics/authorizationRules", "2017-04-01");
        public NamespaceTopicAuthorizationRule(string name) : this() => Name = name;
        public NamespaceTopicAuthorizationRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceTopicAuthorizationRule WithProperties(Action<NamespaceTopicAuthorizationRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceTopicAuthorizationRuleProperties : PropertyBase
    {

        public IList<string> Rights { get; set; }
    }

    public class NamespaceTopicSubscriptionRule : Resource<NamespaceTopicSubscriptionRuleProperties>
    {
        public NamespaceTopicSubscriptionRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics/subscriptions/rules", "2017-04-01");
        public NamespaceTopicSubscriptionRule(string name) : this() => Name = name;
        public NamespaceTopicSubscriptionRule(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceTopicSubscriptionRule WithProperties(Action<NamespaceTopicSubscriptionRuleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceTopicSubscriptionRuleProperties : PropertyBase
    {

        private ActionInfo _action;
        public ActionInfo Action
        {
            get => _action = Get(_action);
            set => _action = value;
        }

        public string FilterType { get; set; }

        private SqlFilterInfo _sqlFilter;
        public SqlFilterInfo SqlFilter
        {
            get => _sqlFilter = Get(_sqlFilter);
            set => _sqlFilter = value;
        }

        private CorrelationFilterInfo _correlationFilter;
        public CorrelationFilterInfo CorrelationFilter
        {
            get => _correlationFilter = Get(_correlationFilter);
            set => _correlationFilter = value;
        }
    }

    public class ActionInfo : PropertyBase
    {

        public string SqlExpression { get; set; }

        public int? CompatibilityLevel { get; set; }

        public bool? RequiresPreprocessing { get; set; }
    }

    public class SqlFilterInfo : PropertyBase
    {

        public string SqlExpression { get; set; }

        public int? CompatibilityLevel { get; set; }

        public bool? RequiresPreprocessing { get; set; }
    }

    public class CorrelationFilterInfo : PropertyBase
    {

        public object Properties { get; set; }

        public string CorrelationId { get; set; }

        public string MessageId { get; set; }

        public string To { get; set; }

        public string ReplyTo { get; set; }

        public string Label { get; set; }

        public string SessionId { get; set; }

        public string ReplyToSessionId { get; set; }

        public string ContentType { get; set; }

        public bool? RequiresPreprocessing { get; set; }
    }

    public class NamespaceTopicSubscription : Resource<NamespaceTopicSubscriptionProperties>
    {
        public NamespaceTopicSubscription() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics/subscriptions", "2017-04-01");
        public NamespaceTopicSubscription(string name) : this() => Name = name;
        public NamespaceTopicSubscription(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceTopicSubscription WithProperties(Action<NamespaceTopicSubscriptionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceTopicSubscriptionProperties : PropertyBase
    {

        public string LockDuration { get; set; }

        public bool? RequiresSession { get; set; }

        public string DefaultMessageTimeToLive { get; set; }

        public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

        public bool? DeadLetteringOnMessageExpiration { get; set; }

        public string DuplicateDetectionHistoryTimeWindow { get; set; }

        public int? MaxDeliveryCount { get; set; }

        public string Status { get; set; }

        public bool? EnableBatchedOperations { get; set; }

        public string AutoDeleteOnIdle { get; set; }

        public string ForwardTo { get; set; }

        public string ForwardDeadLetteredMessagesTo { get; set; }
    }

    public class NamespaceTopic : Resource<NamespaceTopicProperties>
    {
        public NamespaceTopic() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics", "2017-04-01");
        public NamespaceTopic(string name) : this() => Name = name;
        public NamespaceTopic(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceTopic WithProperties(Action<NamespaceTopicProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceTopicProperties : PropertyBase
    {

        public string DefaultMessageTimeToLive { get; set; }

        public int? MaxSizeInMegabytes { get; set; }

        public bool? RequiresDuplicateDetection { get; set; }

        public string DuplicateDetectionHistoryTimeWindow { get; set; }

        public bool? EnableBatchedOperations { get; set; }

        public string Status { get; set; }

        public bool? SupportOrdering { get; set; }

        public string AutoDeleteOnIdle { get; set; }

        public bool? EnablePartitioning { get; set; }

        public bool? EnableExpress { get; set; }
    }

    public class NamespaceVirtualnetworkrule : Resource<NamespaceVirtualnetworkruleProperties>
    {
        public NamespaceVirtualnetworkrule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/virtualnetworkrules", "2018-01-01-preview");
        public NamespaceVirtualnetworkrule(string name) : this() => Name = name;
        public NamespaceVirtualnetworkrule(string name, Location location) : this() => (Name, Location) = (name, location);

        public NamespaceVirtualnetworkrule WithProperties(Action<NamespaceVirtualnetworkruleProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceVirtualnetworkruleProperties : PropertyBase
    {

        public string VirtualNetworkSubnetId { get; set; }
    }

    public class Namespace : Resource<NamespaceProperties>
    {
        public Namespace() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces", "2018-01-01-preview");
        public Namespace(string name) : this() => Name = name;
        public Namespace(string name, Location location) : this() => (Name, Location) = (name, location);

        public Namespace WithProperties(Action<NamespaceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class NamespaceProperties : PropertyBase
    {

        public bool? ZoneRedundant { get; set; }

        private IdentityInfo _identity;
        public IdentityInfo Identity
        {
            get => _identity = Get(_identity);
            set => _identity = value;
        }

        private EncryptionInfo _encryption;
        public EncryptionInfo Encryption
        {
            get => _encryption = Get(_encryption);
            set => _encryption = value;
        }
    }

    public class IdentityInfo : PropertyBase
    {

        public string PrincipalId { get; set; }

        public string TenantId { get; set; }

        public string Type { get; set; }
    }

    public class EncryptionInfo : PropertyBase
    {

        private KeyVaultPropertiesInfo _keyVaultProperties;
        public KeyVaultPropertiesInfo KeyVaultProperties
        {
            get => _keyVaultProperties = Get(_keyVaultProperties);
            set => _keyVaultProperties = value;
        }

        public string KeySource { get; set; }
    }

    public class KeyVaultPropertiesInfo : PropertyBase
    {

        public string KeyName { get; set; }

        public string KeyVaultUri { get; set; }
    }
}
