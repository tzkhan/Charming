namespace Charming.Types.AnalysisServices
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class Server : Resource<ServerProperties>
    {
        public Server() => (Type, ApiVersion) = ("Microsoft.AnalysisServices/servers", "2017-08-01");
        public Server(string name) : this() => Name = name;
        public Server(string name, Location location) : this() => (Name, Location) = (name, location);

        public Server WithProperties(Action<ServerProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class ServerProperties : PropertyBase
    {

        private AsAdministratorsInfo _asAdministrators;
        public AsAdministratorsInfo AsAdministrators
        {
            get => _asAdministrators = Get(_asAdministrators);
            set => _asAdministrators = value;
        }

        public string BackupBlobContainerUri { get; set; }

        private GatewayDetailsInfo _gatewayDetails;
        public GatewayDetailsInfo GatewayDetails
        {
            get => _gatewayDetails = Get(_gatewayDetails);
            set => _gatewayDetails = value;
        }

        private IpV4FirewallSettingsInfo _ipV4FirewallSettings;
        public IpV4FirewallSettingsInfo IpV4FirewallSettings
        {
            get => _ipV4FirewallSettings = Get(_ipV4FirewallSettings);
            set => _ipV4FirewallSettings = value;
        }

        public string QuerypoolConnectionMode { get; set; }
    }

    public class AsAdministratorsInfo : PropertyBase
    {

        public IList<string> Members { get; set; }
    }

    public class GatewayDetailsInfo : PropertyBase
    {

        public string GatewayResourceId { get; set; }
    }

    public class IpV4FirewallSettingsInfo : PropertyBase
    {

        public IList<FirewallRuleInfo> FirewallRules { get; set; }

        public bool? EnablePowerBIService { get; set; }
    }

    public class FirewallRuleInfo : PropertyBase
    {

        public string FirewallRuleName { get; set; }

        public string RangeStart { get; set; }

        public string RangeEnd { get; set; }
    }
}
