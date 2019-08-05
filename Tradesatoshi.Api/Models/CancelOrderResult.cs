using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Tradesatoshi.Api.Models
{
    [DataContract]
    public class CancelOrderResult
    {
        [DataMember(Name = "canceledOrders")]
        public List<int> CanceledOrders { get; set; }
    }
}
