
#nullable enable

namespace Vectara
{
    public sealed partial class VectaraClient
    {
        /// <inheritdoc cref="VectaraClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Vectara.EndPointAuthorization?)"/>
        public VectaraClient(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Vectara.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}