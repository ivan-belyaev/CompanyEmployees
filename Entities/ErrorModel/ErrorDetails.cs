using Newtonsoft.Json;


namespace Entities.ErrorModel
{
    /// <summary>
    /// Error Details
    /// </summary>
    public class ErrorDetails
    {
        /// <summary>
        /// Status Code
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
