using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class SubmitTransferRequest : IRequest
    {
        public string currency { get; set; }
        public string username { get; set; }
        public decimal Amount { get; set; }
    }
}
