using JetBrains.Annotations;
using MAVN.Service.CurrencyConvertor.Client.Models.Enums;

namespace MAVN.Service.CurrencyConvertor.Client.Models.Responses
{
    /// <summary>
    /// Represents a currency converter response.
    /// </summary>
    [PublicAPI]
    public class ConverterResponse
    {
        /// <summary>
        /// The target currency amount. 
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The currency converter operation error code.
        /// </summary>
        public ConverterErrorCode ErrorCode { get; set; }
    }
}
