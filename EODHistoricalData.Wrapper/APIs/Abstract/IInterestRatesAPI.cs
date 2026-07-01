using EOD.Model.Rates;
using System;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
    internal interface IInterestRatesAPI
    {
        /// <summary>
        /// Get post-LIBOR risk-free reference rates.
        /// </summary>
        Task<ReferenceRatesResponse> GetRiskFreeReferenceRatesAsync(string code = null, string currency = null,
            DateTime? from = null, DateTime? to = null, int? limit = null, int? offset = null);
    }
}
