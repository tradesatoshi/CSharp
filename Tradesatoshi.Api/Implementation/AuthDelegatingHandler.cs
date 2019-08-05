using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tradesatoshi.Api.Implementation
{
    public class AuthDelegatingHandler : DelegatingHandler
    {
        private string _apiKey;
        private string _apiSecret;

        public AuthDelegatingHandler(string key, string secret)
        {
            _apiKey = key;
            _apiSecret = secret;
        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string requestContentBase64String = string.Empty;
            string requestUri = System.Web.HttpUtility.UrlEncode(request.RequestUri.AbsoluteUri.ToLower());

            //Checking if the request contains body, usually will be null with HTTP GET
            if (request.Content != null)
            {
                requestContentBase64String = Convert.ToBase64String(await request.Content.ReadAsByteArrayAsync());
            }

            //create random nonce for each request
            var nonce = Guid.NewGuid().ToString("N");

            //Creating the raw signature string
            var signatureRawData = string.Concat(_apiKey, "POST", requestUri, nonce, requestContentBase64String);
            var secretKeyByteArray = Convert.FromBase64String(_apiSecret);
            var signature = Encoding.UTF8.GetBytes(signatureRawData);
            using (var hmac = new HMACSHA512(secretKeyByteArray))
            {
                var signatureBytes = hmac.ComputeHash(signature);
                var requestSignatureBase64String = Convert.ToBase64String(signatureBytes);
                //Setting the values in the Authorization header using custom scheme (Basic)
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", string.Format("{0}:{1}:{2}", _apiKey, requestSignatureBase64String, nonce));
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
