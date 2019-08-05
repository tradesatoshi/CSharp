namespace Tradesatoshi.Api.Implementation
{
    public interface IResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether this response was successful.
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// Gets or sets the error if the response is not successful.
        /// </summary>
        string Message { get; set; }
    }
}
