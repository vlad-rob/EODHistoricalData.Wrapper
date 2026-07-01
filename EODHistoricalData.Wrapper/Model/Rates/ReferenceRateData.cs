using Newtonsoft.Json;
using System;

namespace EOD.Model.Rates
{
    /// <summary>
    /// Risk-free reference rate observation.
    /// </summary>
    public class ReferenceRateData
    {
        /// <summary>
        /// Observation date.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Series code, for example SOFR, EFFR, SONIA, or ESTR.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Currency of the rate: USD, GBP, or EUR.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Rate type: overnight, average, or index.
        /// </summary>
        [JsonProperty("rate_type")]
        public string RateType { get; set; }

        /// <summary>
        /// Rate value in percent.
        /// </summary>
        public double? Rate { get; set; }

        /// <summary>
        /// Upstream provider.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Identifier of the series at the upstream source.
        /// </summary>
        [JsonProperty("source_series_id")]
        public string SourceSeriesId { get; set; }

        /// <summary>
        /// NY Fed intraday rate distribution. Present only on NY Fed rows.
        /// </summary>
        public ReferenceRatePercentiles Percentiles { get; set; }

        /// <summary>
        /// Transaction volume underpinning the rate, in USD billions. Present only on NY Fed rows.
        /// </summary>
        [JsonProperty("volume_billion_usd")]
        public double? VolumeBillionUsd { get; set; }
    }
}
