namespace Charming.Types.AAD
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class DomainService : Resource<DomainServiceProperties>
    {
        public DomainService() => (Type, ApiVersion) = ("Microsoft.AAD/domainServices", "2020-01-01");
        public DomainService(string name) : this() => Name = name;
        public DomainService(string name, Location location) : this() => (Name, Location) = (name, location);

        public DomainService WithProperties(Action<DomainServiceProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class DomainServiceProperties : PropertyBase
    {

        public string DomainName { get; set; }

        public IList<ReplicaSetInfo> ReplicaSets { get; set; }

        private LdapsSettingsInfo _ldapsSettings;
        public LdapsSettingsInfo LdapsSettings
        {
            get => _ldapsSettings = Get(_ldapsSettings);
            set => _ldapsSettings = value;
        }

        private DomainSecuritySettingsInfo _domainSecuritySettings;
        public DomainSecuritySettingsInfo DomainSecuritySettings
        {
            get => _domainSecuritySettings = Get(_domainSecuritySettings);
            set => _domainSecuritySettings = value;
        }

        public string FilteredSync { get; set; }

        private NotificationSettingsInfo _notificationSettings;
        public NotificationSettingsInfo NotificationSettings
        {
            get => _notificationSettings = Get(_notificationSettings);
            set => _notificationSettings = value;
        }
    }

    public class ReplicaSetInfo : PropertyBase
    {

        public string Location { get; set; }

        public string SubnetId { get; set; }
    }

    public class LdapsSettingsInfo : PropertyBase
    {

        public string Ldaps { get; set; }

        public string PfxCertificate { get; set; }

        public string PfxCertificatePassword { get; set; }

        public string ExternalAccess { get; set; }
    }

    public class DomainSecuritySettingsInfo : PropertyBase
    {

        public string NtlmV1 { get; set; }

        public string TlsV1 { get; set; }

        public string SyncNtlmPasswords { get; set; }
    }

    public class NotificationSettingsInfo : PropertyBase
    {

        public string NotifyGlobalAdmins { get; set; }

        public string NotifyDcAdmins { get; set; }

        public IList<string> AdditionalRecipients { get; set; }
    }
}
