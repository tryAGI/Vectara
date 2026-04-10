#nullable enable

namespace Vectara
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List tools<br/>
        /// List all tools available to the authenticated user, with optional filtering and pagination. Tools represent capabilities that agents can invoke during conversation, including built-in system tools and user-defined Lambda tools. Use filters to locate tools by name, type, status, or tool server.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: rag.*
        /// </param>
        /// <param name="type">
        /// Example: mcp
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="category">
        /// Example: [retrieval, utilities]
        /// </param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListToolsResponse> ListAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            global::Vectara.ListToolsType? type = default,
            bool? enabled = default,
            global::System.Collections.Generic.IList<string>? category = default,
            string? toolServerId = default,
            int? limit = default,
            string? pageKey = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}