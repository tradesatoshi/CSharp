using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class OrderRequest : IRequest
    {
        public int OrderId { get; set; }
    }

    public class OrdersRequest : IRequest
    {
        public string Market { get; set; }
        public int count { get; set; }
    }
}
