
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Wolken ServiceDesk forms source configuration. Ingests the end-user-facing service catalog<br/>
    /// forms of a Wolken ServiceDesk instance, covering both incident forms and service request forms.<br/>
    /// Each form becomes one document carrying the form's title, description, and category, and, when<br/>
    /// `include_form_details` is true, its FAQs, field definitions, and option values. Requires Wolken<br/>
    /// credentials with read access to the service catalog listing endpoint, and, when<br/>
    /// `include_form_details` is true, to the form metadata, special instructions, and lookup value<br/>
    /// endpoints.
    /// </summary>
    public sealed partial class BaseWolkenFormsSourceConfiguration
    {
        /// <summary>
        /// Discriminator value identifying this source configuration as `wolken_forms`.<br/>
        /// Default Value: wolken_forms<br/>
        /// Example: wolken_forms
        /// </summary>
        /// <default>"wolken_forms"</default>
        /// <example>wolken_forms</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "wolken_forms";

        /// <summary>
        /// Base URL of the Wolken API.<br/>
        /// Example: https://example-api.wolkenservicedesk.com
        /// </summary>
        /// <example>https://example-api.wolkenservicedesk.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// The value of the `domain` header issued with your Wolken API credentials. Wolken deployments vary in whether this is a tenant name or a full hostname, so use the exact value from your credential handoff.<br/>
        /// Example: example.wolkenservicedesk.com
        /// </summary>
        /// <example>example.wolkenservicedesk.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Whether each form document includes the form's FAQs, field definitions, field help text,<br/>
        /// and the selectable values of its dropdown and lookup fields. When false, documents are<br/>
        /// built from the service catalog listing alone.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_form_details")]
        public bool? IncludeFormDetails { get; set; }

        /// <summary>
        /// Template for the portal URL of a form. The `{item_id}` placeholder is replaced with the<br/>
        /// form's item ID. When omitted, documents carry no URL metadata.<br/>
        /// Example: https://example-enduser.wolkenservicedesk.com/wolken-support/item_details?itemId={item_id}
        /// </summary>
        /// <example>https://example-enduser.wolkenservicedesk.com/wolken-support/item_details?itemId={item_id}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_url_template")]
        public string? ItemUrlTemplate { get; set; }

        /// <summary>
        /// Wolken OAuth client ID.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2
        /// </summary>
        /// <example>a1b2c3d4e5f6g7h8i9j0k1l2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Wolken service account the API calls run as. Sent as a header on API requests.<br/>
        /// Example: svc-catalog-reader@example.com
        /// </summary>
        /// <example>svc-catalog-reader@example.com</example>
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
        /// Initializes a new instance of the <see cref="BaseWolkenFormsSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value identifying this source configuration as `wolken_forms`.<br/>
        /// Default Value: wolken_forms<br/>
        /// Example: wolken_forms
        /// </param>
        /// <param name="baseUrl">
        /// Base URL of the Wolken API.<br/>
        /// Example: https://example-api.wolkenservicedesk.com
        /// </param>
        /// <param name="domain">
        /// The value of the `domain` header issued with your Wolken API credentials. Wolken deployments vary in whether this is a tenant name or a full hostname, so use the exact value from your credential handoff.<br/>
        /// Example: example.wolkenservicedesk.com
        /// </param>
        /// <param name="includeFormDetails">
        /// Whether each form document includes the form's FAQs, field definitions, field help text,<br/>
        /// and the selectable values of its dropdown and lookup fields. When false, documents are<br/>
        /// built from the service catalog listing alone.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="itemUrlTemplate">
        /// Template for the portal URL of a form. The `{item_id}` placeholder is replaced with the<br/>
        /// form's item ID. When omitted, documents carry no URL metadata.<br/>
        /// Example: https://example-enduser.wolkenservicedesk.com/wolken-support/item_details?itemId={item_id}
        /// </param>
        /// <param name="clientId">
        /// Wolken OAuth client ID.<br/>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2
        /// </param>
        /// <param name="serviceAccount">
        /// Wolken service account the API calls run as. Sent as a header on API requests.<br/>
        /// Example: svc-catalog-reader@example.com
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
        public BaseWolkenFormsSourceConfiguration(
            string type,
            string? baseUrl,
            string? domain,
            bool? includeFormDetails,
            string? itemUrlTemplate,
            string? clientId,
            string? serviceAccount,
            string? authCode,
            string? refreshToken)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.BaseUrl = baseUrl;
            this.Domain = domain;
            this.IncludeFormDetails = includeFormDetails;
            this.ItemUrlTemplate = itemUrlTemplate;
            this.ClientId = clientId;
            this.ServiceAccount = serviceAccount;
            this.AuthCode = authCode;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWolkenFormsSourceConfiguration" /> class.
        /// </summary>
        public BaseWolkenFormsSourceConfiguration()
        {
        }

    }
}