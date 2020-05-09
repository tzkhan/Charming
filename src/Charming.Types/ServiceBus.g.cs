namespace Charming.Types.ServiceBus
{
    using Charming;
    using System.Collections.Generic;

    public partial class NamespaceAuthorizationRule : Resource<NamespaceAuthorizationRuleProperties>
    {
        public NamespaceAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/AuthorizationRules", "2017-04-01");
        public NamespaceAuthorizationRule(string name) : this() => Name = name;
        public NamespaceAuthorizationRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceAuthorizationRuleProperties
    {
        public IList<string> Rights { get; set; }
    }

    public partial class NamespaceDisasterRecoveryConfig : Resource<NamespaceDisasterRecoveryConfigProperties>
    {
        public NamespaceDisasterRecoveryConfig() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs", "2017-04-01");
        public NamespaceDisasterRecoveryConfig(string name) : this() => Name = name;
        public NamespaceDisasterRecoveryConfig(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceDisasterRecoveryConfigProperties
    {
        public string PartnerNamespace { get; set; }
        public string AlternateName { get; set; }
    }

    public partial class NamespaceIpfilterrule : Resource<NamespaceIpfilterruleProperties>
    {
        public NamespaceIpfilterrule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/ipfilterrules", "2018-01-01-preview");
        public NamespaceIpfilterrule(string name) : this() => Name = name;
        public NamespaceIpfilterrule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceIpfilterruleProperties
    {
        public string IpMask { get; set; }
        public string Action { get; set; }
        public string FilterName { get; set; }
    }

    public partial class NamespaceMigrationConfiguration : Resource<NamespaceMigrationConfigurationProperties>
    {
        public NamespaceMigrationConfiguration() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/migrationConfigurations", "2017-04-01");
        public NamespaceMigrationConfiguration(string name) : this() => Name = name;
        public NamespaceMigrationConfiguration(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceMigrationConfigurationProperties
    {
        public string TargetNamespace { get; set; }
        public string PostMigrationName { get; set; }
    }

    public partial class NamespaceQueueAuthorizationRule : Resource<NamespaceQueueAuthorizationRuleProperties>
    {
        public NamespaceQueueAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/queues/authorizationRules", "2017-04-01");
        public NamespaceQueueAuthorizationRule(string name) : this() => Name = name;
        public NamespaceQueueAuthorizationRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceQueueAuthorizationRuleProperties
    {
        public IList<string> Rights { get; set; }
    }

    public partial class NamespaceQueue : Resource<NamespaceQueueProperties>
    {
        public NamespaceQueue() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/queues", "2017-04-01");
        public NamespaceQueue(string name) : this() => Name = name;
        public NamespaceQueue(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceQueueProperties
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

    public partial class NamespaceTopicAuthorizationRule : Resource<NamespaceTopicAuthorizationRuleProperties>
    {
        public NamespaceTopicAuthorizationRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics/authorizationRules", "2017-04-01");
        public NamespaceTopicAuthorizationRule(string name) : this() => Name = name;
        public NamespaceTopicAuthorizationRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceTopicAuthorizationRuleProperties
    {
        public IList<string> Rights { get; set; }
    }

    public partial class NamespaceTopicSubscriptionRule : Resource<NamespaceTopicSubscriptionRuleProperties>
    {
        public NamespaceTopicSubscriptionRule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics/subscriptions/rules", "2017-04-01");
        public NamespaceTopicSubscriptionRule(string name) : this() => Name = name;
        public NamespaceTopicSubscriptionRule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceTopicSubscriptionRuleProperties
    {
        public ActionInfo Action { get; set; }
        public string FilterType { get; set; }
        public SqlFilterInfo SqlFilter { get; set; }
        public CorrelationFilterInfo CorrelationFilter { get; set; }
    }

    public partial class ActionInfo
    {
        public string SqlExpression { get; set; }
        public int? CompatibilityLevel { get; set; }
        public bool? RequiresPreprocessing { get; set; }
    }

    public partial class SqlFilterInfo
    {
        public string SqlExpression { get; set; }
        public int? CompatibilityLevel { get; set; }
        public bool? RequiresPreprocessing { get; set; }
    }

    public partial class CorrelationFilterInfo
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

    public partial class NamespaceTopicSubscription : Resource<NamespaceTopicSubscriptionProperties>
    {
        public NamespaceTopicSubscription() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics/subscriptions", "2017-04-01");
        public NamespaceTopicSubscription(string name) : this() => Name = name;
        public NamespaceTopicSubscription(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceTopicSubscriptionProperties
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

    public partial class NamespaceTopic : Resource<NamespaceTopicProperties>
    {
        public NamespaceTopic() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/topics", "2017-04-01");
        public NamespaceTopic(string name) : this() => Name = name;
        public NamespaceTopic(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceTopicProperties
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

    public partial class NamespaceVirtualnetworkrule : Resource<NamespaceVirtualnetworkruleProperties>
    {
        public NamespaceVirtualnetworkrule() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces/virtualnetworkrules", "2018-01-01-preview");
        public NamespaceVirtualnetworkrule(string name) : this() => Name = name;
        public NamespaceVirtualnetworkrule(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceVirtualnetworkruleProperties
    {
        public string VirtualNetworkSubnetId { get; set; }
    }

    public partial class Namespace : Resource<NamespaceProperties>
    {
        public Namespace() => (Type, ApiVersion) = ("Microsoft.ServiceBus/namespaces", "2018-01-01-preview");
        public Namespace(string name) : this() => Name = name;
        public Namespace(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class NamespaceProperties
    {
        public bool? ZoneRedundant { get; set; }
        public IdentityInfo Identity { get; set; }
        public EncryptionInfo Encryption { get; set; }
    }

    public partial class IdentityInfo
    {
        public string PrincipalId { get; set; }
        public string TenantId { get; set; }
        public string Type { get; set; }
    }

    public partial class EncryptionInfo
    {
        public KeyVaultPropertiesInfo KeyVaultProperties { get; set; }
        public string KeySource { get; set; }
    }

    public partial class KeyVaultPropertiesInfo
    {
        public string KeyName { get; set; }
        public string KeyVaultUri { get; set; }
    }
}
