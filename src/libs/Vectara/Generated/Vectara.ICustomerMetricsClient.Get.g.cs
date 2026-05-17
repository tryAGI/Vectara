#nullable enable

namespace Vectara
{
    public partial interface ICustomerMetricsClient
    {
        /// <summary>
        /// Query a metric time series<br/>
        /// Returns a time series of aggregated metric values for the named metric within the requested time range.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="metricName"></param>
        /// <param name="labels"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="maxBuckets">
        /// Default Value: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.MetricSeries> GetAsync(
            string metricName,
            global::System.DateTime start,
            global::System.DateTime end,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? labels = default,
            int? maxBuckets = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query a metric time series<br/>
        /// Returns a time series of aggregated metric values for the named metric within the requested time range.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="metricName"></param>
        /// <param name="labels"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="maxBuckets">
        /// Default Value: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.MetricSeries>> GetAsResponseAsync(
            string metricName,
            global::System.DateTime start,
            global::System.DateTime end,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? labels = default,
            int? maxBuckets = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}