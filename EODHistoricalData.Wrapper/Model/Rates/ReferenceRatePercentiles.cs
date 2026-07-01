namespace EOD.Model.Rates
{
    /// <summary>
    /// NY Fed intraday rate distribution percentiles.
    /// </summary>
    public class ReferenceRatePercentiles
    {
        /// <summary>
        /// First percentile.
        /// </summary>
        public double? P1 { get; set; }

        /// <summary>
        /// Twenty-fifth percentile.
        /// </summary>
        public double? P25 { get; set; }

        /// <summary>
        /// Seventy-fifth percentile.
        /// </summary>
        public double? P75 { get; set; }

        /// <summary>
        /// Ninety-ninth percentile.
        /// </summary>
        public double? P99 { get; set; }
    }
}
