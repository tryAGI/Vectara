
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Wolken ServiceDesk knowledge-base source configuration. Ingests knowledge-base articles<br/>
    /// matching the configured filters, with each article's audience attributes carried as document<br/>
    /// metadata for attribute-based filtering. Requires Wolken data API credentials with read access<br/>
    /// to the knowledge-base listing and article-detail endpoints. Incremental sync additionally<br/>
    /// requires the listing to support update-time filters. Supported filters vary by Wolken<br/>
    /// deployment.
    /// </summary>
    public sealed partial class BaseWolkenKbSourceConfiguration
    {
        /// <summary>
        /// Default Value: wolken_kb<br/>
        /// Example: wolken_kb
        /// </summary>
        /// <default>"wolken_kb"</default>
        /// <example>wolken_kb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "wolken_kb";

        /// <summary>
        /// Base URL of the Wolken API.<br/>
        /// Example: https://example-api.wolkenservicedesk.com
        /// </summary>
        /// <example>https://example-api.wolkenservicedesk.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_endpoint")]
        public string? ApiEndpoint { get; set; }

        /// <summary>
        /// The Wolken tenant name issued with your Wolken API credentials, not a hostname. For example `example`, not `example.wolkenservicedesk.com`.<br/>
        /// Example: example
        /// </summary>
        /// <example>example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Lifecycle status to filter articles by. If unset, articles of every lifecycle status are<br/>
        /// ingested. Status IDs are specific to your Wolken deployment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_id")]
        public int? StatusId { get; set; }

        /// <summary>
        /// Validation status to filter articles by. If unset, articles of every validation status<br/>
        /// are ingested. Validation status IDs are specific to your Wolken deployment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_status_id")]
        public int? ValidationStatusId { get; set; }

        /// <summary>
        /// Audience level to filter articles by. If unset, articles of every audience level are<br/>
        /// ingested. Level IDs are specific to your Wolken deployment.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("level_id")]
        public int? LevelId { get; set; }

        /// <summary>
        /// Operator used for the upper bound when filtering articles by when they were last updated.<br/>
        /// `lt` is strict less-than and `lte` is less-than-or-equal.<br/>
        /// Default Value: lte
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_upper_bound_operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperatorJsonConverter))]
        public global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator? UpdateUpperBoundOperator { get; set; }

        /// <summary>
        /// Template for each article's public URL. The `{article_number}` placeholder is replaced<br/>
        /// with the article number. When omitted, the URL returned by the Wolken listing is used. If<br/>
        /// the listing returns no URL, the article has no public URL recorded.<br/>
        /// Example: https://example.wolkenservicedesk.com/external/article?articleNumber={article_number}
        /// </summary>
        /// <example>https://example.wolkenservicedesk.com/external/article?articleNumber={article_number}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("article_url_template")]
        public string? ArticleUrlTemplate { get; set; }

        /// <summary>
        /// Wolken OAuth client ID.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2
        /// </summary>
        /// <example>a1b2c3d4e5f6g7h8i9j0k1l2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Wolken service account the data API calls run as.<br/>
        /// Example: svc-kb-reader@example.com
        /// </summary>
        /// <example>svc-kb-reader@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public string? ServiceAccount { get; set; }

        /// <summary>
        /// The auth code Wolken issues for the instance, used with `refresh_token` to obtain access<br/>
        /// tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        public string? AuthCode { get; set; }

        /// <summary>
        /// Long-lived refresh token exchanged for access tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWolkenKbSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: wolken_kb<br/>
        /// Example: wolken_kb
        /// </param>
        /// <param name="apiEndpoint">
        /// Base URL of the Wolken API.<br/>
        /// Example: https://example-api.wolkenservicedesk.com
        /// </param>
        /// <param name="domain">
        /// The Wolken tenant name issued with your Wolken API credentials, not a hostname. For example `example`, not `example.wolkenservicedesk.com`.<br/>
        /// Example: example
        /// </param>
        /// <param name="statusId">
        /// Lifecycle status to filter articles by. If unset, articles of every lifecycle status are<br/>
        /// ingested. Status IDs are specific to your Wolken deployment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="validationStatusId">
        /// Validation status to filter articles by. If unset, articles of every validation status<br/>
        /// are ingested. Validation status IDs are specific to your Wolken deployment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="levelId">
        /// Audience level to filter articles by. If unset, articles of every audience level are<br/>
        /// ingested. Level IDs are specific to your Wolken deployment.<br/>
        /// Example: 3
        /// </param>
        /// <param name="updateUpperBoundOperator">
        /// Operator used for the upper bound when filtering articles by when they were last updated.<br/>
        /// `lt` is strict less-than and `lte` is less-than-or-equal.<br/>
        /// Default Value: lte
        /// </param>
        /// <param name="articleUrlTemplate">
        /// Template for each article's public URL. The `{article_number}` placeholder is replaced<br/>
        /// with the article number. When omitted, the URL returned by the Wolken listing is used. If<br/>
        /// the listing returns no URL, the article has no public URL recorded.<br/>
        /// Example: https://example.wolkenservicedesk.com/external/article?articleNumber={article_number}
        /// </param>
        /// <param name="clientId">
        /// Wolken OAuth client ID.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2
        /// </param>
        /// <param name="serviceAccount">
        /// Wolken service account the data API calls run as.<br/>
        /// Example: svc-kb-reader@example.com
        /// </param>
        /// <param name="authCode">
        /// The auth code Wolken issues for the instance, used with `refresh_token` to obtain access<br/>
        /// tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="refreshToken">
        /// Long-lived refresh token exchanged for access tokens. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseWolkenKbSourceConfiguration(
            string type,
            string? apiEndpoint,
            string? domain,
            int? statusId,
            int? validationStatusId,
            int? levelId,
            global::Vectara.BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator? updateUpperBoundOperator,
            string? articleUrlTemplate,
            string? clientId,
            string? serviceAccount,
            string? authCode,
            string? refreshToken)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ApiEndpoint = apiEndpoint;
            this.Domain = domain;
            this.StatusId = statusId;
            this.ValidationStatusId = validationStatusId;
            this.LevelId = levelId;
            this.UpdateUpperBoundOperator = updateUpperBoundOperator;
            this.ArticleUrlTemplate = articleUrlTemplate;
            this.ClientId = clientId;
            this.ServiceAccount = serviceAccount;
            this.AuthCode = authCode;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWolkenKbSourceConfiguration" /> class.
        /// </summary>
        public BaseWolkenKbSourceConfiguration()
        {
        }

    }
}