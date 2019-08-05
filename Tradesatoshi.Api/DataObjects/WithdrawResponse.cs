using System.Runtime.Serialization;
using Tradesatoshi.Api.Implementation;
using Tradesatoshi.Api.Models;

namespace Tradesatoshi.Api.DataObjects
{
    [DataContract]
    public class WithdrawResponse : IResponse
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "result")]
        public WithdrawResult Result { get; set; }
    }
}
