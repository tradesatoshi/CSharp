using System.Net.Http;
using System.Threading.Tasks;
using Tradesatoshi.Api.DataObjects;
using Tradesatoshi.Api.Implementation;

namespace Tradesatoshi.Api
{
    public class TradesatoshiPrivateApi : ITradesatoshiApiPrivate
    {
        private HttpClient _client;
        private string _apiBaseAddress;

        public TradesatoshiPrivateApi(string key, string secret, string apiBaseAddress = "https://tradesatoshi.com")
        {
            _apiBaseAddress = apiBaseAddress;
            _client = HttpClientFactory.Create(new AuthDelegatingHandler(key, secret));
        }

        public async Task<BalanceResponse> GetBalance(BalanceRequest request)
        {
            return await GetResult<BalanceResponse, BalanceRequest>(PrivateApiCall.GetBalance, request);
        }

        public async Task<BalancesResponse> GetBalances(BalancesRequest request)
        {
            return await GetResult<BalancesResponse, BalancesRequest>(PrivateApiCall.GetBalances, request);
        }

        public async Task<OrderResponse> GetOrder(OrderRequest request)
        {
            return await GetResult<OrderResponse, OrderRequest>(PrivateApiCall.GetOrder, request);
        }

        public async Task<OrdersResponse> GetOrders(OrdersRequest request)
        {
            return await GetResult<OrdersResponse, OrdersRequest>(PrivateApiCall.GetOrders, request);
        }

        public async Task<SubmitOrderResponse> SubmitOrder(SubmitOrderRequest request)
        {
            return await GetResult<SubmitOrderResponse, SubmitOrderRequest>(PrivateApiCall.SubmitOrder, request);
        }

        public async Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request)
        {
            return await GetResult<CancelOrderResponse, CancelOrderRequest>(PrivateApiCall.CancelOrder, request);
        }

        public async Task<TradeHistoryResponse> GetTradeHistory(TradeHistoryRequest request)
        {
            return await GetResult<TradeHistoryResponse, TradeHistoryRequest>(PrivateApiCall.GetTradeHistory, request);
        }

        public async Task<AddressResponse> GenerateAddress(AddressRequest request)
        {
            return await GetResult<AddressResponse, AddressRequest>(PrivateApiCall.GenerateAddress, request);
        }

        public async Task<WithdrawResponse> SubmitWithdraw(WithdrawRequest request)
        {
            return await GetResult<WithdrawResponse, WithdrawRequest>(PrivateApiCall.SubmitWithdraw, request);
        }

        public async Task<DepositResponse> GetDeposits(DepositRequest request)
        {
            return await GetResult<DepositResponse, DepositRequest>(PrivateApiCall.GetDeposits, request);
        }

        public async Task<GetWithdrawResponse> GetWithdrawals(GetWithdrawRequest request)
        {
            return await GetResult<GetWithdrawResponse, GetWithdrawRequest>(PrivateApiCall.GetWithdrawals, request);
        }

        public async Task<SubmitTransferResponse> SubmitTransfer(SubmitTransferRequest request)
        {
            return await GetResult<SubmitTransferResponse, SubmitTransferRequest>(PrivateApiCall.SubmitTransfer, request);
        }

        public async Task<SubmitTipResponse> SubmitTip(SubmitTipRequest request)
        {
            return await GetResult<SubmitTipResponse, SubmitTipRequest>(PrivateApiCall.SubmitTip, request);
        }

        #region public Members

        public async Task<T> GetResult<T, U>(PrivateApiCall call, U requestData) where T : IResponse where U : IRequest
        {
            var response = await _client.PostAsJsonAsync<U>(string.Format("{0}/api/private/{1}", _apiBaseAddress.TrimEnd('/'), call.ToString().ToLower()), requestData);
            return await response.Content.ReadAsAsync<T>();
        }

        public void Dispose()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }

        #endregion

    }
}
