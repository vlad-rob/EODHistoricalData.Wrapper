using EOD.APIs.Abstract;
using EOD.Model.Rates;
using System;
using System.Threading.Tasks;

namespace EOD.APIs
{
    internal class InterestRatesAPI : BaseAPI, IInterestRatesAPI
    {
        private const string sourceReferenceRates = @"https://eodhistoricaldata.com/api/rates/reference-rates?";

        public InterestRatesAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

        public Task<ReferenceRatesResponse> GetRiskFreeReferenceRatesAsync(string code = null, string currency = null,
            DateTime? from = null, DateTime? to = null, int? limit = null, int? offset = null)
        {
            string uri = sourceReferenceRates;
            if (code != null) uri += $"&filter[code]={Uri.EscapeDataString(code)}";
            if (currency != null) uri += $"&filter[currency]={Uri.EscapeDataString(currency)}";
            if (from != null) uri += $"&filter[from]={from?.ToString("yyyy-MM-dd")}";
            if (to != null) uri += $"&filter[to]={to?.ToString("yyyy-MM-dd")}";
            if (limit != null) uri += $"&page[limit]={limit}";
            if (offset != null) uri += $"&page[offset]={offset}";

            return ExecuteQueryAsync<ReferenceRatesResponse>(uri);
        }
    }
}
