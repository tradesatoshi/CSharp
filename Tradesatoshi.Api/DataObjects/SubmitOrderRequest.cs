using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class SubmitOrderRequest : IRequest
    {
        public string Market { get; set; }

        public string Type { get; set; }

        public decimal Amount { get; set; }

        public decimal Price { get; set; }
    }
}