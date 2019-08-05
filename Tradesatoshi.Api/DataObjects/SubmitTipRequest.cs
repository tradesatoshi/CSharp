using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class SubmitTipRequest : IRequest
    {
        public string Currency { get; set; }

        public int ActiveUsers { get; set; }

        public decimal Amount { get; set; }

        public string Reason { get; set; }
    }
}
