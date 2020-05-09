namespace Charming.Types.Devices
{
    using Charming;
    using System.Collections.Generic;

    public partial class IotHub : Resource<IotHubProperties>
    {
        public IotHub() => (Type, ApiVersion) = ("Microsoft.Devices/IotHubs", "2019-03-22");
        public IotHub(string name) : this() => Name = name;
        public IotHub(string name, Location location) : this() => (Name, Location) = (name, location);
    }

    public partial class IotHubProperties
    {
        public IList<AuthorizationPolicyInfo> AuthorizationPolicies { get; set; }
        public IList<IpFilterRuleInfo> IpFilterRules { get; set; }
        public object EventHubEndpoints { get; set; }
        public RoutingInfo Routing { get; set; }
        public object StorageEndpoints { get; set; }
        public object MessagingEndpoints { get; set; }
        public bool? EnableFileUploadNotifications { get; set; }
        public CloudToDeviceInfo CloudToDevice { get; set; }
        public string Comments { get; set; }
        public string Features { get; set; }
    }

    public partial class AuthorizationPolicyInfo
    {
        public string KeyName { get; set; }
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
        public string Rights { get; set; }
    }

    public partial class IpFilterRuleInfo
    {
        public string FilterName { get; set; }
        public string Action { get; set; }
        public string IpMask { get; set; }
    }

    public partial class RoutingInfo
    {
        public EndpointsInfo Endpoints { get; set; }
        public IList<RouteInfo> Routes { get; set; }
        public FallbackRouteInfo FallbackRoute { get; set; }
    }

    public partial class EndpointsInfo
    {
        public IList<ServiceBusQueueInfo> ServiceBusQueues { get; set; }
        public IList<ServiceBusTopicInfo> ServiceBusTopics { get; set; }
        public IList<EventHubInfo> EventHubs { get; set; }
        public IList<StorageContainerInfo> StorageContainers { get; set; }
    }

    public partial class ServiceBusQueueInfo
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroup { get; set; }
    }

    public partial class ServiceBusTopicInfo
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroup { get; set; }
    }

    public partial class EventHubInfo
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroup { get; set; }
    }

    public partial class StorageContainerInfo
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string SubscriptionId { get; set; }
        public string ResourceGroup { get; set; }
        public string ContainerName { get; set; }
        public string FileNameFormat { get; set; }
        public int? BatchFrequencyInSeconds { get; set; }
        public int? MaxChunkSizeInBytes { get; set; }
        public string Encoding { get; set; }
    }

    public partial class RouteInfo
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string Condition { get; set; }
        public IList<string> EndpointNames { get; set; }
        public bool? IsEnabled { get; set; }
    }

    public partial class FallbackRouteInfo
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string Condition { get; set; }
        public IList<string> EndpointNames { get; set; }
        public bool? IsEnabled { get; set; }
    }

    public partial class CloudToDeviceInfo
    {
        public int? MaxDeliveryCount { get; set; }
        public string DefaultTtlAsIso8601 { get; set; }
        public FeedbackInfo Feedback { get; set; }
    }

    public partial class FeedbackInfo
    {
        public string LockDurationAsIso8601 { get; set; }
        public string TtlAsIso8601 { get; set; }
        public int? MaxDeliveryCount { get; set; }
    }
}
