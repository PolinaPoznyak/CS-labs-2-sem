using System;
using System.Runtime.Serialization;

namespace Bank
{
    [DataContract]
    public class Owner
    {
        [DataMember]
        public Account account;
        public HistoryOperations historyOperations;
        [DataMember]
        public string fullName;
        [DataMember]
        public DateTime birthday;
        [DataMember]
        public string passportData;
        [DataMember]
        public bool smsConnect;
        [DataMember]
        public bool netBankingConnect;
        [DataMember]
        public string smsInfo;
        [DataMember]
        public string netBankInfo;

        public Owner(Account _account, string _fullName, DateTime _birthday, string _passportDate, bool _smsConnect, bool _netBankingConnect)
        {
            account = _account;
            fullName = _fullName;
            birthday = _birthday;
            passportData = _passportDate;
            smsConnect = _smsConnect;
            netBankingConnect = _netBankingConnect;
            smsInfo = smsConnect ? "SMS-оповещения подключены" : "SMS-оповещения не подключены";
            netBankInfo = netBankingConnect ? "Интернет банкинг подключен" : "Интернет банкинг не подключен";
        }

        public string ShowOwnerInfo()
        {
            string ownerInfo = $"Номер счёта: {account.number} \t" +
                $"ФИО: {fullName}\t" +
                $"Дата рождения: {birthday} \t" +
                $"Дата открытия счёта: {account.openingDate} \t" +
                $"Подписка на дополнительные услуги: \t{smsInfo} \t{netBankInfo} \t" +
                $"Баланс: {account.ShowBalance()} \t" +
                $"Тип вклада: {account.ShowContribType()}";
            return ownerInfo;
        }
    }
}
