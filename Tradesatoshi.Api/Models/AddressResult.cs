using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class AddressResult
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "paymentId")]
        public string PaymentId { get; set; }
    }
}
