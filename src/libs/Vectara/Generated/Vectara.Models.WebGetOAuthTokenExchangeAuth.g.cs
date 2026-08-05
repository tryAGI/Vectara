
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Two-legged OAuth token exchange. The platform first mints a subject token via the client-credentials grant at `token_endpoint`, scoped to `subject_audience`. It then exchanges the subject token at `exchange_endpoint` for the token sent to the target service. Configurable to cover both RFC 8693 and non-standard STS endpoints that present the subject token or parameters differently. The platform caches both tokens until they expire.
    /// </summary>
    public sealed partial class WebGetOAuthTokenExchangeAuth
    {
        /// <summary>
        /// The auth type discriminator; always `oauth_token_exchange` for this variant.<br/>
        /// Default Value: oauth_token_exchange<br/>
        /// Example: oauth_token_exchange
        /// </summary>
        /// <default>"oauth_token_exchange"</default>
        /// <example>oauth_token_exchange</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "oauth_token_exchange";

        /// <summary>
        /// Client id used to mint the subject token (client-credentials grant). May be an EagerReference to an agent secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> ClientId { get; set; }

        /// <summary>
        /// Client secret used to mint the subject token. May be an EagerReference to an agent secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> ClientSecret { get; set; }

        /// <summary>
        /// Token endpoint that mints the subject token.<br/>
        /// Example: https://auth.example.com/oauth2/token
        /// </summary>
        /// <example>https://auth.example.com/oauth2/token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenEndpoint { get; set; }

        /// <summary>
        /// OAuth scopes requested for the subject token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Audience requested for the subject token; must be accepted by the exchange endpoint (e.g. the STS issuer).<br/>
        /// Example: https://sts.example.com
        /// </summary>
        /// <example>https://sts.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectAudience { get; set; }

        /// <summary>
        /// STS endpoint that exchanges the subject token for the target token.<br/>
        /// Example: https://sts.example.com/exchange
        /// </summary>
        /// <example>https://sts.example.com/exchange</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exchange_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExchangeEndpoint { get; set; }

        /// <summary>
        /// How the subject token is sent to the exchange endpoint: authorization_bearer (in the `Authorization: Bearer` header) or body_param (an RFC 8693 `subject_token` form field).<br/>
        /// Default Value: authorization_bearer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.WebGetOAuthTokenExchangeAuthSubjectPlacementJsonConverter))]
        public global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement? SubjectPlacement { get; set; }

        /// <summary>
        /// Body parameter name carrying the subject token when subject_placement is body_param (e.g. `subject_token`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_body_param")]
        public string? SubjectBodyParam { get; set; }

        /// <summary>
        /// Where the exchange `params` are sent: query or body (RFC 8693 uses body).<br/>
        /// Default Value: query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.WebGetOAuthTokenExchangeAuthParamLocationJsonConverter))]
        public global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation? ParamLocation { get; set; }

        /// <summary>
        /// Extra exchange parameters (e.g. `aud` and an `identity` selector for an assumable-identity STS; `grant_type`, `audience`,<br/>
        /// `subject_token_type` for RFC 8693).<br/>
        /// Example: {"aud":"https://api.example.com","identity":"\u003Cassumable-identity-id\u003E"}
        /// </summary>
        /// <example>{"aud":"https://api.example.com","identity":"\u003Cassumable-identity-id\u003E"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::System.Collections.Generic.Dictionary<string, string>? Params { get; set; }

        /// <summary>
        /// JSON field in the exchange response holding the issued token (e.g. `token`, or `access_token` for RFC 8693).<br/>
        /// Default Value: access_token<br/>
        /// Example: token
        /// </summary>
        /// <example>token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_response_field")]
        public string? TokenResponseField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetOAuthTokenExchangeAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// The auth type discriminator; always `oauth_token_exchange` for this variant.<br/>
        /// Default Value: oauth_token_exchange<br/>
        /// Example: oauth_token_exchange
        /// </param>
        /// <param name="clientId">
        /// Client id used to mint the subject token (client-credentials grant). May be an EagerReference to an agent secret.
        /// </param>
        /// <param name="clientSecret">
        /// Client secret used to mint the subject token. May be an EagerReference to an agent secret.
        /// </param>
        /// <param name="tokenEndpoint">
        /// Token endpoint that mints the subject token.<br/>
        /// Example: https://auth.example.com/oauth2/token
        /// </param>
        /// <param name="subjectAudience">
        /// Audience requested for the subject token; must be accepted by the exchange endpoint (e.g. the STS issuer).<br/>
        /// Example: https://sts.example.com
        /// </param>
        /// <param name="exchangeEndpoint">
        /// STS endpoint that exchanges the subject token for the target token.<br/>
        /// Example: https://sts.example.com/exchange
        /// </param>
        /// <param name="scopes">
        /// OAuth scopes requested for the subject token.
        /// </param>
        /// <param name="subjectPlacement">
        /// How the subject token is sent to the exchange endpoint: authorization_bearer (in the `Authorization: Bearer` header) or body_param (an RFC 8693 `subject_token` form field).<br/>
        /// Default Value: authorization_bearer
        /// </param>
        /// <param name="subjectBodyParam">
        /// Body parameter name carrying the subject token when subject_placement is body_param (e.g. `subject_token`).
        /// </param>
        /// <param name="paramLocation">
        /// Where the exchange `params` are sent: query or body (RFC 8693 uses body).<br/>
        /// Default Value: query
        /// </param>
        /// <param name="params">
        /// Extra exchange parameters (e.g. `aud` and an `identity` selector for an assumable-identity STS; `grant_type`, `audience`,<br/>
        /// `subject_token_type` for RFC 8693).<br/>
        /// Example: {"aud":"https://api.example.com","identity":"\u003Cassumable-identity-id\u003E"}
        /// </param>
        /// <param name="tokenResponseField">
        /// JSON field in the exchange response holding the issued token (e.g. `token`, or `access_token` for RFC 8693).<br/>
        /// Default Value: access_token<br/>
        /// Example: token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetOAuthTokenExchangeAuth(
            string type,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> clientId,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> clientSecret,
            string tokenEndpoint,
            string subjectAudience,
            string exchangeEndpoint,
            global::System.Collections.Generic.IList<string>? scopes,
            global::Vectara.WebGetOAuthTokenExchangeAuthSubjectPlacement? subjectPlacement,
            string? subjectBodyParam,
            global::Vectara.WebGetOAuthTokenExchangeAuthParamLocation? paramLocation,
            global::System.Collections.Generic.Dictionary<string, string>? @params,
            string? tokenResponseField)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.TokenEndpoint = tokenEndpoint ?? throw new global::System.ArgumentNullException(nameof(tokenEndpoint));
            this.Scopes = scopes;
            this.SubjectAudience = subjectAudience ?? throw new global::System.ArgumentNullException(nameof(subjectAudience));
            this.ExchangeEndpoint = exchangeEndpoint ?? throw new global::System.ArgumentNullException(nameof(exchangeEndpoint));
            this.SubjectPlacement = subjectPlacement;
            this.SubjectBodyParam = subjectBodyParam;
            this.ParamLocation = paramLocation;
            this.Params = @params;
            this.TokenResponseField = tokenResponseField;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetOAuthTokenExchangeAuth" /> class.
        /// </summary>
        public WebGetOAuthTokenExchangeAuth()
        {
        }

    }
}