#nullable enable

namespace Vectara
{
    public partial interface IEncodersClient
    {
        /// <summary>
        /// Create an encoder<br/>
        /// Create a new encoder.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.Encoder> CreateAsync(

            global::Vectara.CreateEncoderRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}