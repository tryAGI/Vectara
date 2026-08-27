
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The configuration a widget client needs to render and to open a session, and — for a widget that admits anonymous visitors — the anonymous identity to open one with.<br/>
    /// Session attributes such as idle lifetime are reported on the session object returned by the end-user session create endpoint.
    /// </summary>
    public sealed partial class BootstrapWidgetResponse
    {
        /// <summary>
        /// The anonymous identity minted for this visitor. Present only when the widget admits anonymous visitors; a sign-in-only widget returns no `visitor_id`, and its callers open a session with a customer-IdP token instead.<br/>
        /// Presented as the `X-Visitor-Id` header on every end-user session request.<br/>
        /// Store it durably on the client; it never expires, and it is the only proof of ownership of the sessions it creates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitor_id")]
        public string? VisitorId { get; set; }

        /// <summary>
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </summary>
        /// <example>support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AliasKey { get; set; }

        /// <summary>
        /// The presentation configuration the widget client renders — branding, palette, welcome content, suggested prompts.<br/>
        /// Free-form apart from the required `version`; the platform stores it verbatim, serves it back uninterpreted, and caps its total size.<br/>
        /// Null-valued keys are accepted but are omitted from responses.<br/>
        /// Served to anonymous visitors by the unauthenticated widget bootstrap endpoint, so widget clients must treat every value as untrusted data.<br/>
        /// Schema validation of the payload lands with the first Altera release; `version` is what lets clients render older payloads once the shape evolves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.WidgetPresentation Presentation { get; set; }

        /// <summary>
        /// Enables the widget's sign-in affordance and names the identity provider it authenticates users against.<br/>
        /// The host page supplies a token minted by the referenced trusted token issuer, and the widget presents it as the bearer credential on end-user session requests.<br/>
        /// The platform verifies the token by its `iss` claim against the globally-unique issuer registration — never against this connector — so the token stands on its own: it signs the caller in as an end user across the customer's aliases, not this widget's alone.<br/>
        /// The platform accepts the token when its signature verifies against the issuer's JWKS and it carries an `email` claim.<br/>
        /// The referenced registration must exist, or the connector write is rejected with `400`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_user_sign_in")]
        public global::Vectara.WidgetSignIn? EndUserSignIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BootstrapWidgetResponse" /> class.
        /// </summary>
        /// <param name="aliasKey">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="presentation">
        /// The presentation configuration the widget client renders — branding, palette, welcome content, suggested prompts.<br/>
        /// Free-form apart from the required `version`; the platform stores it verbatim, serves it back uninterpreted, and caps its total size.<br/>
        /// Null-valued keys are accepted but are omitted from responses.<br/>
        /// Served to anonymous visitors by the unauthenticated widget bootstrap endpoint, so widget clients must treat every value as untrusted data.<br/>
        /// Schema validation of the payload lands with the first Altera release; `version` is what lets clients render older payloads once the shape evolves.
        /// </param>
        /// <param name="visitorId">
        /// The anonymous identity minted for this visitor. Present only when the widget admits anonymous visitors; a sign-in-only widget returns no `visitor_id`, and its callers open a session with a customer-IdP token instead.<br/>
        /// Presented as the `X-Visitor-Id` header on every end-user session request.<br/>
        /// Store it durably on the client; it never expires, and it is the only proof of ownership of the sessions it creates.
        /// </param>
        /// <param name="endUserSignIn">
        /// Enables the widget's sign-in affordance and names the identity provider it authenticates users against.<br/>
        /// The host page supplies a token minted by the referenced trusted token issuer, and the widget presents it as the bearer credential on end-user session requests.<br/>
        /// The platform verifies the token by its `iss` claim against the globally-unique issuer registration — never against this connector — so the token stands on its own: it signs the caller in as an end user across the customer's aliases, not this widget's alone.<br/>
        /// The platform accepts the token when its signature verifies against the issuer's JWKS and it carries an `email` claim.<br/>
        /// The referenced registration must exist, or the connector write is rejected with `400`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BootstrapWidgetResponse(
            string aliasKey,
            global::Vectara.WidgetPresentation presentation,
            string? visitorId,
            global::Vectara.WidgetSignIn? endUserSignIn)
        {
            this.VisitorId = visitorId;
            this.AliasKey = aliasKey ?? throw new global::System.ArgumentNullException(nameof(aliasKey));
            this.Presentation = presentation ?? throw new global::System.ArgumentNullException(nameof(presentation));
            this.EndUserSignIn = endUserSignIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BootstrapWidgetResponse" /> class.
        /// </summary>
        public BootstrapWidgetResponse()
        {
        }

    }
}