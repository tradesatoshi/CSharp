using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class CancelOrderRequest : IRequest
    {
        public string Type { get; set; }

        public int? OrderId { get; set; }

        public string Market { get; set; }
    }
}