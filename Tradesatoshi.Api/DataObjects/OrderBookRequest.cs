namespace Tradesatoshi.Api.DataObjects
{
    public class OrderBookRequest
    {
        public string market { get; set; }
        public string type { get; set; }
        public int depth { get; set; }
    }
}
