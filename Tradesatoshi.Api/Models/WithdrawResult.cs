using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class WithdrawResult
    {
        [DataMember(Name = "withdrawalId")]
        public int WithdrawalId { get; set; }
    }
}
