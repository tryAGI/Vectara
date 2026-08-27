
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWidgetConnectorConfigurationVariant2
    {
        /// <summary>
        /// The type of connector configuration.<br/>
        /// Default Value: widget<br/>
        /// Example: widget
        /// </summary>
        /// <default>"widget"</default>
        /// <example>widget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "widget";

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
        /// How long a session created through this widget may sit idle before it is closed, in minutes.<br/>
        /// Applied to sessions created with this connector's id as `connector_id`, anonymous or signed-in.<br/>
        /// Set to 0 for sessions that never expire.<br/>
        /// Omit to use the platform default of 30 days.<br/>
        /// Default Value: 43200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_tti_minutes")]
        public int? SessionTtiMinutes { get; set; }

        /// <summary>
        /// Agent output types included in the widget's end-user event projection; the final response is always visible.<br/>
        /// Applies to sessions created with this connector's id as `connector_id`, anonymous or signed-in.<br/>
        /// Omitted or empty reveals none.<br/>
        /// Default Value: []<br/>
        /// Example: [tool_calls]
        /// </summary>
        /// <example>[tool_calls]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revealed_output_types")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? RevealedOutputTypes { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateWidgetConnectorConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector configuration.<br/>
        /// Default Value: widget<br/>
        /// Example: widget
        /// </param>
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
        /// <param name="sessionTtiMinutes">
        /// How long a session created through this widget may sit idle before it is closed, in minutes.<br/>
        /// Applied to sessions created with this connector's id as `connector_id`, anonymous or signed-in.<br/>
        /// Set to 0 for sessions that never expire.<br/>
        /// Omit to use the platform default of 30 days.<br/>
        /// Default Value: 43200
        /// </param>
        /// <param name="revealedOutputTypes">
        /// Agent output types included in the widget's end-user event projection; the final response is always visible.<br/>
        /// Applies to sessions created with this connector's id as `connector_id`, anonymous or signed-in.<br/>
        /// Omitted or empty reveals none.<br/>
        /// Default Value: []<br/>
        /// Example: [tool_calls]
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
        public CreateWidgetConnectorConfigurationVariant2(
            string type,
            string aliasKey,
            global::Vectara.WidgetPresentation presentation,
            int? sessionTtiMinutes,
            global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? revealedOutputTypes,
            global::Vectara.WidgetSignIn? endUserSignIn)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AliasKey = aliasKey ?? throw new global::System.ArgumentNullException(nameof(aliasKey));
            this.Presentation = presentation ?? throw new global::System.ArgumentNullException(nameof(presentation));
            this.SessionTtiMinutes = sessionTtiMinutes;
            this.RevealedOutputTypes = revealedOutputTypes;
            this.EndUserSignIn = endUserSignIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWidgetConnectorConfigurationVariant2" /> class.
        /// </summary>
        public CreateWidgetConnectorConfigurationVariant2()
        {
        }

    }
}