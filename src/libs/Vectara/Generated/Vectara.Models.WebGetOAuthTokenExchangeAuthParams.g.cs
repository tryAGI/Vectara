
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Extra exchange parameters (e.g. `aud` and an `identity` selector for an assumable-identity STS; `grant_type`, `audience`,<br/>
    /// `subject_token_type` for RFC 8693).<br/>
    /// Example: {"aud":"https://api.example.com","identity":"\u003Cassumable-identity-id\u003E"}
    /// </summary>
    public sealed partial class WebGetOAuthTokenExchangeAuthParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}