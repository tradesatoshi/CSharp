using System;
using System.Threading.Tasks;

namespace Tradesatoshi.Api.Implementation
{
    public interface ITradesatoshiApiPrivate : IDisposable
    {
        Task<T> GetResult<T, U>(PrivateApiCall call, U requestData)
            where T : IResponse
            where U : IRequest;
    }
}
