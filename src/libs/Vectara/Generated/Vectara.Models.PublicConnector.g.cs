
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The public view of a connector that fronts an end-user surface, served unauthenticated to the embed snippet.<br/>
    /// End-user sessions are created on the addressed alias — `/v2/agent_aliases/{alias_key}/end_user_sessions` — naming this connector in the request body; the embed snippet carries the alias key and connector id it needs, and this view serves the `customer_id` that visitor minting (`POST /v2/visitors`) is addressed to.<br/>
    /// Session attributes such as idle lifetime are reported on the session object returned by the end-user session create endpoint.
    /// </summary>
    public sealed partial class PublicConnector
    {
        /// <summary>
        /// The unique identifier of the customer the connector belongs to, presented as the `X-Customer-Id` header when minting a visitor identity through `POST /v2/visitors`.<br/>
        /// Example: 1234567890
        /// </summary>
        /// <example>1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CustomerId { get; set; }

        /// <summary>
        /// Whether the connector admits anonymous visitors.<br/>
        /// When false, the client signs the user in through `end_user_sign_in` before creating a session.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PublicAccess { get; set; }

        /// <summary>
        /// The presentation configuration the widget client renders — branding, palette, welcome content, suggested prompts.<br/>
        /// Free-form apart from the required `version`; the platform stores it verbatim, serves it back uninterpreted, and caps its total size.<br/>
        /// Null-valued keys are accepted but are omitted from responses.<br/>
        /// Served to anonymous visitors by the unauthenticated public connector view, so widget clients must treat every value as untrusted data.<br/>
        /// Schema validation of the payload lands with the first Altera release; `version` is what lets clients render older payloads once the shape evolves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.WidgetPresentation Presentation { get; set; }

        /// <summary>
        /// The sign-in affordance of the public connector view. Identifies the identity provider the widget authenticates users against by its issuer URL — the `iss` claim of the tokens the host page supplies — never by the internal registration id.<br/>
        /// The host page obtains a token from this issuer and the widget presents it as the bearer credential on end-user session requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_user_sign_in")]
        public global::Vectara.PublicSignIn? EndUserSignIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicConnector" /> class.
        /// </summary>
        /// <param name="customerId">
        /// The unique identifier of the customer the connector belongs to, presented as the `X-Customer-Id` header when minting a visitor identity through `POST /v2/visitors`.<br/>
        /// Example: 1234567890
        /// </param>
        /// <param name="publicAccess">
        /// Whether the connector admits anonymous visitors.<br/>
        /// When false, the client signs the user in through `end_user_sign_in` before creating a session.<br/>
        /// Example: true
        /// </param>
        /// <param name="presentation">
        /// The presentation configuration the widget client renders — branding, palette, welcome content, suggested prompts.<br/>
        /// Free-form apart from the required `version`; the platform stores it verbatim, serves it back uninterpreted, and caps its total size.<br/>
        /// Null-valued keys are accepted but are omitted from responses.<br/>
        /// Served to anonymous visitors by the unauthenticated public connector view, so widget clients must treat every value as untrusted data.<br/>
        /// Schema validation of the payload lands with the first Altera release; `version` is what lets clients render older payloads once the shape evolves.
        /// </param>
        /// <param name="endUserSignIn">
        /// The sign-in affordance of the public connector view. Identifies the identity provider the widget authenticates users against by its issuer URL — the `iss` claim of the tokens the host page supplies — never by the internal registration id.<br/>
        /// The host page obtains a token from this issuer and the widget presents it as the bearer credential on end-user session requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicConnector(
            long customerId,
            bool publicAccess,
            global::Vectara.WidgetPresentation presentation,
            global::Vectara.PublicSignIn? endUserSignIn)
        {
            this.CustomerId = customerId;
            this.PublicAccess = publicAccess;
            this.Presentation = presentation ?? throw new global::System.ArgumentNullException(nameof(presentation));
            this.EndUserSignIn = endUserSignIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicConnector" /> class.
        /// </summary>
        public PublicConnector()
        {
        }

    }
}