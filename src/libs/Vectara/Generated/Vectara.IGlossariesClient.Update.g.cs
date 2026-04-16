#nullable enable

namespace Vectara
{
    public partial interface IGlossariesClient
    {
        /// <summary>
        /// Update glossary<br/>
        /// Update the metadata of a glossary.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="glossaryKey">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Glossary> UpdateAsync(
            string glossaryKey,

            global::Vectara.UpdateGlossaryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update glossary<br/>
        /// Update the metadata of a glossary.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="glossaryKey">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
        /// <param name="name">
        /// Updated name for the glossary.<br/>
        /// Example: Platform Acronyms
        /// </param>
        /// <param name="description">
        /// Updated description.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Glossary> UpdateAsync(
            string glossaryKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}