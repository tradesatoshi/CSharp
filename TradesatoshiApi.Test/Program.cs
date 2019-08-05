using System;
using System.Threading.Tasks;
using Tradesatoshi.Api;
using Tradesatoshi.Api.DataObjects;

namespace TradesatoshiApi.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CallApi().Wait();
        }

        static async Task CallApi()
        {
            // Public Api
            using (var api = new TradesatoshiPublicApi())
            {
                var tickerResult = await api.GetTicker(new TickerRequest() { market = "BTC_USDT" });
                if (!tickerResult.Success)
                    Console.WriteLine(tickerResult.Message);
                else
                    Console.WriteLine($"LastPrice: {tickerResult.Result.Last}");
            }


            // Private Api
            var apiKey = "your tradesatoshi api key";
            var apiSecret = "your tradesatoshi api secret";

            using (var api = new TradesatoshiPrivateApi(apiKey, apiSecret))
            {
                var balanceResult = await api.GetBalance(new BalanceRequest() { Currency = "USDT" });
                if (!balanceResult.Success)
                    Console.WriteLine(balanceResult);
                else
                    Console.WriteLine($"Your {balanceResult.Result.Currency} Balance : {balanceResult.Result.Available}");
            }


            Console.ReadLine();
        }
    }
}
