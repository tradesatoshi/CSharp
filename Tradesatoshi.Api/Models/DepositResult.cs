using System;
using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class DepositResult
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "currencyLong")]
        public string CurrencyLong { get; set; }

        [DataMember(Name = "amount")]
        public decimal Amount { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "txid")]
        public string Txid { get; set; }

        [DataMember(Name = "confirmations")]
        public int Confirmations { get; set; }

        [DataMember(Name = "timeStamp")]
        public DateTime TimeStamp { get; set; }
    }
}
