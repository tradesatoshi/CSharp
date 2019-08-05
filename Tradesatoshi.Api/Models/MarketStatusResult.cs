using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class MarketStatusResult
    {
        [DataMember(Name = "marketStatus")]
        public string MarketStatus { get; set; }

        [DataMember(Name = "statusMessage")]
        public string StatusMessage { get; set; }
    }
}