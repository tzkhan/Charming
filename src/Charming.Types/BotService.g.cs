namespace Charming.Types.BotService
{
    using System;
    using Charming;
    using Charming.Types.Internal;
    using System.Collections.Generic;

    public class BotServiceChannel : Resource<BotServiceChannelProperties>
    {
        public BotServiceChannel() => (Type, ApiVersion) = ("Microsoft.BotService/botServices/channels", "2018-07-12");
        public BotServiceChannel(string name) : this() => Name = name;
        public BotServiceChannel(string name, Location location) : this() => (Name, Location) = (name, location);

        public BotServiceChannel WithProperties(Action<BotServiceChannelProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BotServiceChannelProperties : PropertyBase
    {

        public string ChannelName { get; set; }
    }

    public class BotServiceConnection : Resource<BotServiceConnectionProperties>
    {
        public BotServiceConnection() => (Type, ApiVersion) = ("Microsoft.BotService/botServices/Connections", "2018-07-12");
        public BotServiceConnection(string name) : this() => Name = name;
        public BotServiceConnection(string name, Location location) : this() => (Name, Location) = (name, location);

        public BotServiceConnection WithProperties(Action<BotServiceConnectionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BotServiceConnectionProperties : PropertyBase
    {

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string Scopes { get; set; }

        public string ServiceProviderId { get; set; }

        public string ServiceProviderDisplayName { get; set; }

        public IList<ParameterInfo> Parameters { get; set; }
    }

    public class ParameterInfo : PropertyBase
    {

        public string Key { get; set; }

        public string Value { get; set; }
    }

    public class BotService : Resource<BotServiceProperties>
    {
        public BotService() => (Type, ApiVersion) = ("Microsoft.BotService/botServices", "2018-07-12");
        public BotService(string name) : this() => Name = name;
        public BotService(string name, Location location) : this() => (Name, Location) = (name, location);

        public BotService WithProperties(Action<BotServiceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BotServiceProperties : PropertyBase
    {

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string IconUrl { get; set; }

        public string Endpoint { get; set; }

        public string MsaAppId { get; set; }

        public string DeveloperAppInsightKey { get; set; }

        public string DeveloperAppInsightsApiKey { get; set; }

        public string DeveloperAppInsightsApplicationId { get; set; }

        public IList<string> LuisAppIds { get; set; }

        public string LuisKey { get; set; }
    }

    public class EnterpriseChannel : Resource<EnterpriseChannelProperties>
    {
        public EnterpriseChannel() => (Type, ApiVersion) = ("Microsoft.BotService/enterpriseChannels", "2018-07-12");
        public EnterpriseChannel(string name) : this() => Name = name;
        public EnterpriseChannel(string name, Location location) : this() => (Name, Location) = (name, location);

        public EnterpriseChannel WithProperties(Action<EnterpriseChannelProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class EnterpriseChannelProperties : PropertyBase
    {

        public string State { get; set; }

        public IList<NodeInfo> Nodes { get; set; }
    }

    public class NodeInfo : PropertyBase
    {

        public string State { get; set; }

        public string Name { get; set; }

        public string AzureSku { get; set; }

        public string AzureLocation { get; set; }
    }
}
