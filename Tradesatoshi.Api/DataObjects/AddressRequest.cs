using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api.DataObjects
{
    public class AddressRequest : IRequest
    {
        public string Currency { get; set; }
    }
}
