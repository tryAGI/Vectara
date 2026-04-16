#nullable enable

namespace Vectara
{
    public partial interface IGlossariesClient
    {
        /// <summary>
        /// Create glossary<br/>
        /// Create a new glossary. A glossary is a reusable mapping of terms to expanded forms that agents use to expand abbreviations and acronyms in user messages.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Glossary> CreateAsync(

            global::Vectara.CreateGlossaryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create glossary<br/>
        /// Create a new glossary. A glossary is a reusable mapping of terms to expanded forms that agents use to expand abbreviations and acronyms in user messages.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
        /// <param name="name">
        /// Human-readable name for the glossary.<br/>
        /// Example: Engineering Acronyms
        /// </param>
        /// <param name="description">
        /// A description of what this glossary covers.<br/>
        /// Example: Common engineering and infrastructure acronyms used by the platform team.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Glossary> CreateAsync(
            string name,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? description = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}