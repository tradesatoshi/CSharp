using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class WithdrawRequest : IRequest
    {
        public string Currency { get; set; }

        public string Address { get; set; }

        public decimal Amount { get; set; }

        public string PaymentId { get; set; }
    }
}
