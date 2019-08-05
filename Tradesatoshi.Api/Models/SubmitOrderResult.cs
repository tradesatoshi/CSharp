using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class SubmitOrderResult
    {
        [DataMember(Name = "OrderId")]
        public int? OrderId { get; set; }

        [DataMember(Name = "Filled")]
        public List<int> Filled { get; set; }
    }
}
