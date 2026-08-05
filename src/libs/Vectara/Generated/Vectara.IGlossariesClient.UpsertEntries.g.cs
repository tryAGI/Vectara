#nullable enable

namespace Vectara
{
    public partial interface IGlossariesClient
    {
        /// <summary>
        /// Upsert glossary entries<br/>
        /// Upserts entries into a glossary in bulk. Entries with existing terms are updated. New terms are inserted. The platform rebuilds the glossary index after the upsert. Agents use the updated glossary after the rebuild completes.
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
        global::System.Threading.Tasks.Task UpsertEntriesAsync(
            string glossaryKey,

            global::Vectara.UpsertGlossaryEntriesRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert glossary entries<br/>
        /// Upserts entries into a glossary in bulk. Entries with existing terms are updated. New terms are inserted. The platform rebuilds the glossary index after the upsert. Agents use the updated glossary after the rebuild completes.
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
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse> UpsertEntriesAsResponseAsync(
            string glossaryKey,

            global::Vectara.UpsertGlossaryEntriesRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert glossary entries<br/>
        /// Upserts entries into a glossary in bulk. Entries with existing terms are updated. New terms are inserted. The platform rebuilds the glossary index after the upsert. Agents use the updated glossary after the rebuild completes.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="glossaryKey">
        /// A user-provided key that uniquely identifies a glossary.<br/>
        /// Example: eng-acronyms
        /// </param>
        /// <param name="entries">
        /// A map of terms to their expanded forms. Keys are terms (1–200 characters);<br/>
        /// values are expansions (1–1000 characters).<br/>
        /// Example: {"k8s":"Kubernetes","tf":"Terraform"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpsertEntriesAsync(
            string glossaryKey,
            global::System.Collections.Generic.Dictionary<string, string> entries,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}