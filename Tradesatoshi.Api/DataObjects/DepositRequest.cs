using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class DepositRequest : IRequest
    {
        public string Currency { get; set; }

        public int Count { get; set; }
    }
}