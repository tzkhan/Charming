namespace Charming.Types.Blockchain
{
    using System;
    using System.Collections.Generic;
    using Charming;
    using Charming.Types.Internal;

    public class BlockchainMemberTransactionNode : Resource<BlockchainMemberTransactionNodeProperties>
    {
        public BlockchainMemberTransactionNode() => (Type, ApiVersion) = ("Microsoft.Blockchain/blockchainMembers/transactionNodes", "2018-06-01-preview");
        public BlockchainMemberTransactionNode(string name) : this() => Name = name;
        public BlockchainMemberTransactionNode(string name, Location location) : this() => (Name, Location) = (name, location);

        public BlockchainMemberTransactionNode WithProperties(Action<BlockchainMemberTransactionNodeProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BlockchainMemberTransactionNodeProperties : PropertyBase
    {

        public string Password { get; set; }

        public IList<FirewallRuleInfo> FirewallRules { get; set; }
    }

    public class FirewallRuleInfo : PropertyBase
    {

        public string RuleName { get; set; }

        public string StartIpAddress { get; set; }

        public string EndIpAddress { get; set; }
    }

    public class BlockchainMember : Resource<BlockchainMemberProperties>
    {
        public BlockchainMember() => (Type, ApiVersion) = ("Microsoft.Blockchain/blockchainMembers", "2018-06-01-preview");
        public BlockchainMember(string name) : this() => Name = name;
        public BlockchainMember(string name, Location location) : this() => (Name, Location) = (name, location);

        public BlockchainMember WithProperties(Action<BlockchainMemberProperties> setter)
        {
            PropertyBase.SetProperties(setter, Properties);
            return this;
        }
    }

    public class BlockchainMemberProperties : PropertyBase
    {

        public string Protocol { get; set; }

        private ValidatorNodesSkuInfo _validatorNodesSku;
        public ValidatorNodesSkuInfo ValidatorNodesSku
        {
            get => _validatorNodesSku = Get(_validatorNodesSku);
            set => _validatorNodesSku = value;
        }

        public string Password { get; set; }

        public string Consortium { get; set; }

        public string ConsortiumManagementAccountPassword { get; set; }

        public string ConsortiumRole { get; set; }

        public string ConsortiumMemberDisplayName { get; set; }

        public IList<FirewallRuleInfo> FirewallRules { get; set; }
    }

    public class ValidatorNodesSkuInfo : PropertyBase
    {

        public int? Capacity { get; set; }
    }
}
