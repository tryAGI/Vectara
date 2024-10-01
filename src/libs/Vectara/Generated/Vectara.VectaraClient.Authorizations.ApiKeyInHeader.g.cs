
#nullable enable

namespace Vectara
{
    public sealed partial class VectaraClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Vectara.EndPointAuthorization
            {
                Name = "x-api-key",
                Value = apiKey,
            };
        }
    }
}