using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Tradesatoshi.Api.DataObjects;
using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api
{
    public class TradesatoshiPublicApi : IDisposable
    {
        private HttpClient _client;
        private string _apiBaseAddress;

        public TradesatoshiPublicApi(string apiBaseAddress = "https://tradesatoshi.com")
        {
            _apiBaseAddress = apiBaseAddress;
            _client = HttpClientFactory.Create();
        }

        #region ApiCall

        public async Task<CurrenciesResponse> GetCurrencies()
        {
            return await GetResult<CurrenciesResponse>(PublicApiCall.GetCurrencies, null);
        }

        public async Task<CurrencyResponse> GetCurrency(CurrencyRequest request)
        {
            var query = GetQueryString((object)request);
            return await GetResult<CurrencyResponse>(PublicApiCall.GetCurrency, query);
        }

        public async Task<TickerResponse> GetTicker(TickerRequest request)
        {
            return await GetResult<TickerResponse>(PublicApiCall.GetTicker, GetQueryString((object)request));
        }

        public async Task<MarketStatusResponse> GetMarketStatus(MarketStatusRequest request)
        {
            return await GetResult<MarketStatusResponse>(PublicApiCall.GetMarketStatus, GetQueryString((object)request));
        }

        public async Task<MarketHistoryResponse> GetMarketHistory(MarketHistoryRequest request)
        {
            return await GetResult<MarketHistoryResponse>(PublicApiCall.GetMarketHistory, GetQueryString((object)request));
        }

        public async Task<MarketSummaryResponse> GetMarketSummary(MarketSummaryRequest request)
        {
            return await GetResult<MarketSummaryResponse>(PublicApiCall.GetMarketSummary, GetQueryString((object)request));
        }

        public async Task<MarketSummariesResponse> GetMarketSummaries()
        {
            return await GetResult<MarketSummariesResponse>(PublicApiCall.GetMarketSummaries, null);
        }

        public async Task<OrderBookResponse> GetOrderBook(OrderBookRequest request)
        {
            return await GetResult<OrderBookResponse>(PublicApiCall.GetOrderBook, GetQueryString((object)request));
        }

        #endregion

        #region Public Members

        public async Task<T> GetResult<T>(PublicApiCall call, string requestData) where T : IResponse, new()
        {
            var response = await _client.GetStringAsync(string.Format("{0}/api/public/{1}{2}", _apiBaseAddress, call, requestData));
            if (string.IsNullOrEmpty(response))
            {
                return new T() { Success = false, Message = "No Response." };
            }
            return GetObject<T>(response);
        }

        private T GetObject<T>(string jsonData)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonData)))
            {
                var serializer = new DataContractJsonSerializer(typeof(T),
                    new DataContractJsonSerializerSettings());
                return (T)(object)serializer.ReadObject(stream);
            }
        }

        public void Dispose()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }

        #endregion

        private string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return "?" + string.Join("&", properties.ToArray());
        }

    }
}