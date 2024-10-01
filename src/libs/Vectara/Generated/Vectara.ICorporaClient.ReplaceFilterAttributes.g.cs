#nullable enable

namespace Vectara
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Replace the filter attributes of a corpus<br/>
        /// Replace the filter attributes of a corpus. This does not happen immediately, but<br/>
        /// instead creates a job and will complete when that job completes. Until that<br/>
        /// job completes, using new filter attributes will not work.<br/>
        /// You can monitor the status of the filter change using the returned job id.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ReplaceFilterAttributesResponse> ReplaceFilterAttributesAsync(
            string corpusKey,
            global::Vectara.ReplaceFilterAttributesRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace the filter attributes of a corpus<br/>
        /// Replace the filter attributes of a corpus. This does not happen immediately, but<br/>
        /// instead creates a job and will complete when that job completes. Until that<br/>
        /// job completes, using new filter attributes will not work.<br/>
        /// You can monitor the status of the filter change using the returned job id.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ReplaceFilterAttributesResponse> ReplaceFilterAttributesAsync(
            string corpusKey,
            global::System.Collections.Generic.IList<global::Vectara.FilterAttribute> filterAttributes,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}