namespace EOD.Model.Rates
{
    /// <summary>
    /// Metadata for rates endpoint responses.
    /// </summary>
    public class RatesMeta
    {
        /// <summary>
        /// Total rows for the current filter.
        /// </summary>
        public int? Total { get; set; }

        /// <summary>
        /// Current page metadata.
        /// </summary>
        public RatesPage Page { get; set; }
    }
}
