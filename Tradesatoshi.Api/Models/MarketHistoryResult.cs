using System;
using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class MarketHistoryResult
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "timeStamp")]
        public string TimeStamp { get; set; }

        [DataMember(Name = "quantity")]
        public decimal Quantity { get; set; }

        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        [DataMember(Name = "orderType")]
        public string OrderType { get; set; }

        [DataMember(Name = "total")]
        public decimal Total { get; set; }
    }
}