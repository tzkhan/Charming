namespace Charming.Types.AzureStack
{
    using System;
    using Charming;
    using Charming.Types.Internal;

    public class RegistrationCustomerSubscription : Resource<RegistrationCustomerSubscriptionProperties>
    {
        public RegistrationCustomerSubscription() => (Type, ApiVersion) = ("Microsoft.AzureStack/registrations/customerSubscriptions", "2017-06-01");
        public RegistrationCustomerSubscription(string name) : this() => Name = name;
        public RegistrationCustomerSubscription(string name, Location location) : this() => (Name, Location) = (name, location);

        public RegistrationCustomerSubscription WithProperties(Action<RegistrationCustomerSubscriptionProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RegistrationCustomerSubscriptionProperties : PropertyBase
    {

        public string TenantId { get; set; }
    }

    public class Registration : Resource<RegistrationProperties>
    {
        public Registration() => (Type, ApiVersion) = ("Microsoft.AzureStack/registrations", "2017-06-01");
        public Registration(string name) : this() => Name = name;
        public Registration(string name, Location location) : this() => (Name, Location) = (name, location);

        public Registration WithProperties(Action<RegistrationProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class RegistrationProperties : PropertyBase
    {

        public string RegistrationToken { get; set; }
    }
}
