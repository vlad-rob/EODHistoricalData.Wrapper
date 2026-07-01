using System.Collections.Generic;

namespace EOD.Model.Rates
{
    /// <summary>
    /// Response envelope for risk-free reference rates.
    /// </summary>
    public class ReferenceRatesResponse
    {
        /// <summary>
        /// Reference rate observations.
        /// </summary>
        public List<ReferenceRateData> Data { get; set; }

        /// <summary>
        /// Response metadata.
        /// </summary>
        public RatesMeta Meta { get; set; }

        /// <summary>
        /// Pagination links.
        /// </summary>
        public RatesLinks Links { get; set; }
    }
}
