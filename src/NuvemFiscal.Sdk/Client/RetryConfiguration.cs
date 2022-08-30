/*
 * Nuvem Fiscal - SDK para .NET
 * https://www.nuvemfiscal.com.br
 */


using Polly;
using System.Net.Http;

namespace NuvemFiscal.Sdk.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public static class RetryConfiguration
    {
        /// <summary>
        /// Retry policy
        /// </summary>
        public static Policy<HttpResponseMessage> RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy
        /// </summary>
        public static AsyncPolicy<HttpResponseMessage> AsyncRetryPolicy { get; set; }
    }
}
