using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class MarketSummaryResult
    {
        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "high")]
        public decimal High { get; set; }

        [DataMember(Name = "low")]
        public decimal Low { get; set; }

        [DataMember(Name = "volume")]
        public decimal Volume { get; set; }

        [DataMember(Name = "baseVolume")]
        public decimal BaseVolume { get; set; }

        [DataMember(Name = "last")]
        public decimal Last { get; set; }

        [DataMember(Name = "bid")]
        public decimal Bid { get; set; }

        [DataMember(Name = "ask")]
        public decimal Ask { get; set; }

        [DataMember(Name = "openBuyOrders")]
        public int OpenBuyOrders { get; set; }

        [DataMember(Name = "openSellOrders")]
        public int OpenSellOrders { get; set; }

        [DataMember(Name = "marketStatus")]
        public string MarketStatus { get; set; }

        [DataMember(Name = "change")]
        public double Change { get; set; }
    }
}
