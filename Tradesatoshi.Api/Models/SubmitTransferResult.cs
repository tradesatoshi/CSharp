using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class SubmitTransferResult
    {
        [DataMember(Name = "data")]
        public string Data { get; set; }
    }
}
