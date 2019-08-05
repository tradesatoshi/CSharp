using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class CurrencyResult
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "currencyLong")]
        public string CurrencyLong { get; set; }

        [DataMember(Name = "minConfirmation")]
        public int MinConfirmation { get; set; }

        [DataMember(Name = "txFee")]
        public decimal TxFee { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "statusMessage")]
        public string StatusMessage { get; set; }

        [DataMember(Name = "minBaseTrade")]
        public decimal MinBaseTrade { get; set; }

        [DataMember(Name = "isTipEnabled")]
        public bool IsTipEnabled { get; set; }

        [DataMember(Name = "minTip")]
        public decimal MinTip { get; set; }

        [DataMember(Name = "maxTip")]
        public decimal MaxTip { get; set; }
    }
}