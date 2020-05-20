namespace Charming.Types.Devices
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class IotHub : Resource<IotHubProperties>
    {
        public IotHub() => (Type, ApiVersion) = ("Microsoft.Devices/IotHubs", "2019-03-22");
        public IotHub(string name) : this() => Name = name;
        public IotHub(string name, Location location) : this() => (Name, Location) = (name, location);

        public IotHub WithProperties(Action<IotHubProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class IotHubProperties : PropertyBase
    {

        public IList<AuthorizationPolicyInfo> AuthorizationPolicies { get; set; }

        public IList<IpFilterRuleInfo> IpFilterRules { get; set; }

        public object EventHubEndpoints { get; set; }

        private RoutingInfo _routing;
        public RoutingInfo Routing
        {
            get => _routing = Get(_routing);
            set => _routing = value;
        }

        public object StorageEndpoints { get; set; }

        public object MessagingEndpoints { get; set; }

        public bool? EnableFileUploadNotifications { get; set; }

        private CloudToDeviceInfo _cloudToDevice;
        public CloudToDeviceInfo CloudToDevice
        {
            get => _cloudToDevice = Get(_cloudToDevice);
            set => _cloudToDevice = value;
        }

        public string Comments { get; set; }

        public string Features { get; set; }
    }

    public class AuthorizationPolicyInfo : PropertyBase
    {

        public string KeyName { get; set; }

        public string PrimaryKey { get; set; }

        public string SecondaryKey { get; set; }

        public string Rights { get; set; }
    }

    public class IpFilterRuleInfo : PropertyBase
    {

        public string FilterName { get; set; }

        public string Action { get; set; }

        public string IpMask { get; set; }
    }

    public class RoutingInfo : PropertyBase
    {

        private EndpointsInfo _endpoints;
        public EndpointsInfo Endpoints
        {
            get => _endpoints = Get(_endpoints);
            set => _endpoints = value;
        }

        public IList<RouteInfo> Routes { get; set; }

        private FallbackRouteInfo _fallbackRoute;
        public FallbackRouteInfo FallbackRoute
        {
            get => _fallbackRoute = Get(_fallbackRoute);
            set => _fallbackRoute = value;
        }
    }

    public class EndpointsInfo : PropertyBase
    {

        public IList<ServiceBusQueueInfo> ServiceBusQueues { get; set; }

        public IList<ServiceBusTopicInfo> ServiceBusTopics { get; set; }

        public IList<EventHubInfo> EventHubs { get; set; }

        public IList<StorageContainerInfo> StorageContainers { get; set; }
    }

    public class ServiceBusQueueInfo : PropertyBase
    {

        public string ConnectionString { get; set; }

        public string Name { get; set; }

        public string SubscriptionId { get; set; }

        public string ResourceGroup { get; set; }
    }

    public class ServiceBusTopicInfo : PropertyBase
    {

        public string ConnectionString { get; set; }

        public string Name { get; set; }

        public string SubscriptionId { get; set; }

        public string ResourceGroup { get; set; }
    }

    public class EventHubInfo : PropertyBase
    {

        public string ConnectionString { get; set; }

        public string Name { get; set; }

        public string SubscriptionId { get; set; }

        public string ResourceGroup { get; set; }
    }

    public class StorageContainerInfo : PropertyBase
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

    public class RouteInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Source { get; set; }

        public string Condition { get; set; }

        public IList<string> EndpointNames { get; set; }

        public bool? IsEnabled { get; set; }
    }

    public class FallbackRouteInfo : PropertyBase
    {

        public string Name { get; set; }

        public string Source { get; set; }

        public string Condition { get; set; }

        public IList<string> EndpointNames { get; set; }

        public bool? IsEnabled { get; set; }
    }

    public class CloudToDeviceInfo : PropertyBase
    {

        public int? MaxDeliveryCount { get; set; }

        public string DefaultTtlAsIso8601 { get; set; }

        private FeedbackInfo _feedback;
        public FeedbackInfo Feedback
        {
            get => _feedback = Get(_feedback);
            set => _feedback = value;
        }
    }

    public class FeedbackInfo : PropertyBase
    {

        public string LockDurationAsIso8601 { get; set; }

        public string TtlAsIso8601 { get; set; }

        public int? MaxDeliveryCount { get; set; }
    }
}
