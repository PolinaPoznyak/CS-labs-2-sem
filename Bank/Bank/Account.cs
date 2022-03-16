using System;
using System.Runtime.Serialization;

namespace Bank
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public int number;
        public string openingDate;
        [DataMember]
        private int balance;
        [DataMember]
        private string contributionType;

        public Account(int _number, DateTime _openingDate, int _balance, string _contributionType)
        {
            number = _number;
            openingDate = _openingDate.ToString();
            balance = _balance;
            contributionType = _contributionType;
        }

        public string ShowBalance()
        {
            string balanceInfo = $"{balance}";
            return balanceInfo;
        }
        public string ShowContribType()
        {
            string contribTypeInfo = $"{contributionType}";
            return contribTypeInfo;
        }
    }
}
