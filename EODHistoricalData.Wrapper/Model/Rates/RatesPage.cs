namespace EOD.Model.Rates
{
    /// <summary>
    /// Pagination metadata for rates endpoint responses.
    /// </summary>
    public class RatesPage
    {
        /// <summary>
        /// Number of rows skipped.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// Rows requested for the page.
        /// </summary>
        public int? Limit { get; set; }
    }
}
