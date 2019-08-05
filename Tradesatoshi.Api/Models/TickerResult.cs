using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class TickerResult
    {
        [DataMember(Name = "bid")]
        public decimal Bid { get; set; }

        [DataMember(Name = "ask")]
        public decimal Ask { get; set; }

        [DataMember(Name = "last")]
        public decimal Last { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }
    }
}