#nullable enable

namespace Vectara
{
    public partial interface IHallucinationCorrectorsClient
    {
        /// <summary>
        /// List hallucination correctors<br/>
        /// Retrieves a list of available hallucination correctors used for detecting and correcting hallucinations in AI-generated content. This endpoint supports filtering by name or description, pagination, and metadata for navigating large result sets.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListHallucinationCorrectorsResponse> ListHallucinationCorrectorsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}