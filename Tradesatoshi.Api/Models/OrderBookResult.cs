using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class OrderBookResult
    {
        [DataMember(Name = "buy")]
        public List<BookDetails> Buy { get; set; }

        [DataMember(Name = "sell")]
        public List<BookDetails> Sell { get; set; }
    }

    [DataContract]
    public class BookDetails
    {
        [DataMember(Name = "quantity")]
        public decimal Quantity { get; set; }

        [DataMember(Name = "rate")]
        public decimal Rate { get; set; }
    }
}