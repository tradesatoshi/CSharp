using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class SubmitTipResult
    {
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
