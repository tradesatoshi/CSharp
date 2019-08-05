using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class TradeHistoryRequest : IRequest
    {
        public string Market { get; set; }

        public int Count { get; set; }

        public int PageNumber { get; set; }
    }
}
