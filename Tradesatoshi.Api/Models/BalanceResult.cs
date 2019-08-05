using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class BalanceResult
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "currencyLong")]
        public string CurrencyLong { get; set; }

        [DataMember(Name = "available")]
        public decimal Available { get; set; }

        [DataMember(Name = "total")]
        public decimal Total { get; set; }

        [DataMember(Name = "heldForTrades")]
        public decimal HeldForTrades { get; set; }

        [DataMember(Name = "unconfirmed")]
        public decimal Unconfirmed { get; set; }

        [DataMember(Name = "pendingWithdraw")]
        public decimal PendingWithdraw { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "paymentId")]
        public string PaymentId { get; set; }
    }
}