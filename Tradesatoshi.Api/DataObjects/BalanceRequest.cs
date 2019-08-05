using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class BalanceRequest : IRequest
    {
        public string Currency { get; set; }
    }

    public class BalancesRequest : IRequest
    {
    }
}
