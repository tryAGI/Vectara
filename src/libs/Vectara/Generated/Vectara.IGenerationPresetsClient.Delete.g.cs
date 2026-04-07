#nullable enable

namespace Vectara
{
    public partial interface IGenerationPresetsClient
    {
        /// <summary>
        /// Delete a generation preset<br/>
        /// Delete an existing custom generation preset.<br/>
        /// The preset must have been created by the customer (platform presets cannot be deleted).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="generationPresetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string generationPresetId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}