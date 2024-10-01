#nullable enable

namespace Vectara
{
    public partial interface IGenerationPresetsClient
    {
        /// <summary>
        /// List generation presets<br/>
        /// List generation presets used for query or chat requests. Generation presets are<br/>
        /// the build of properties used to configure generation for a request. This includes<br/>
        /// the template that renders the prompt, and various generation settings like<br/>
        /// `temperature`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="llmName"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListGenerationPresetsResponse> ListGenerationPresetsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? llmName = default,
            int? limit = 10,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}