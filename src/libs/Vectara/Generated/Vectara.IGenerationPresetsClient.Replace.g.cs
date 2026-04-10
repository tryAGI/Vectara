#nullable enable

namespace Vectara
{
    public partial interface IGenerationPresetsClient
    {
        /// <summary>
        /// Replace a generation preset<br/>
        /// Replace an existing custom generation preset. This performs a full replacement of the preset configuration.<br/>
        /// The preset must have been created by the customer (platform presets cannot be replaced).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="generationPresetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GenerationPreset> ReplaceAsync(
            string generationPresetId,

            global::Vectara.CreateGenerationPresetRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a generation preset<br/>
        /// Replace an existing custom generation preset. This performs a full replacement of the preset configuration.<br/>
        /// The preset must have been created by the customer (platform presets cannot be replaced).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="generationPresetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.GenerationPreset> ReplaceAsync(
            string generationPresetId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}