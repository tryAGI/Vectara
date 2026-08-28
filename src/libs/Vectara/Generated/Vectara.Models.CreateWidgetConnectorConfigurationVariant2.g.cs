
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
        /// The platform-generated key of the alias fronting a widget connector, as reported in the connector's `alias_key` and `bootstrap_path`. Always `als_`-prefixed; the prefix is reserved, so no operator-chosen alias ever matches it.<br/>
        /// Example: als_9f3a1c2b-4d5e-6f70-8192-a3b4c5d6e7f8_00aa
        /// </summary>
        /// <example>als_9f3a1c2b-4d5e-6f70-8192-a3b4c5d6e7f8_00aa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias_key")]
        public string? AliasKey { get; set; }

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
        /// Applied to every session created through this widget's alias, anonymous or signed-in.<br/>
        /// Set to 0 for sessions that never expire.<br/>
        /// Omit to use the platform default of 30 days.<br/>
        /// Default Value: 43200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_tti_minutes")]
        public int? SessionTtiMinutes { get; set; }

        /// <summary>
        /// Agent output types included in the widget's end-user event projection; the final response is always visible.<br/>
        /// Applies to every session created through this widget's alias, anonymous or signed-in.<br/>
        /// Omitted or empty reveals none.<br/>
        /// Default Value: []<br/>
        /// Example: [tool_calls]
        /// </summary>
        /// <example>[tool_calls]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revealed_output_types")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? RevealedOutputTypes { get; set; }

        /// <summary>
        /// Written as the `metadata` of every session created through this widget's alias, anonymous or signed-in.<br/>
        /// Readable wherever session metadata is readable: instruction templates, `run_condition`, `session_enrichment` references, alias routing rules, and tool `argument_override` expressions.<br/>
        /// Not served by the widget bootstrap endpoint and not returned on the end-user session object, though values reach the agent's context and may surface in its replies.<br/>
        /// Omitted or empty writes no session metadata.<br/>
        /// Default Value: {}<br/>
        /// Example: {"instance":"conversational-ai"}
        /// </summary>
        /// <example>{"instance":"conversational-ai"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_metadata")]
        public object? SessionMetadata { get; set; }

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
        /// <param name="presentation">
        /// The presentation configuration the widget client renders — branding, palette, welcome content, suggested prompts.<br/>
        /// Free-form apart from the required `version`; the platform stores it verbatim, serves it back uninterpreted, and caps its total size.<br/>
        /// Null-valued keys are accepted but are omitted from responses.<br/>
        /// Served to anonymous visitors by the unauthenticated widget bootstrap endpoint, so widget clients must treat every value as untrusted data.<br/>
        /// Schema validation of the payload lands with the first Altera release; `version` is what lets clients render older payloads once the shape evolves.
        /// </param>
        /// <param name="aliasKey">
        /// The platform-generated key of the alias fronting a widget connector, as reported in the connector's `alias_key` and `bootstrap_path`. Always `als_`-prefixed; the prefix is reserved, so no operator-chosen alias ever matches it.<br/>
        /// Example: als_9f3a1c2b-4d5e-6f70-8192-a3b4c5d6e7f8_00aa
        /// </param>
        /// <param name="sessionTtiMinutes">
        /// How long a session created through this widget may sit idle before it is closed, in minutes.<br/>
        /// Applied to every session created through this widget's alias, anonymous or signed-in.<br/>
        /// Set to 0 for sessions that never expire.<br/>
        /// Omit to use the platform default of 30 days.<br/>
        /// Default Value: 43200
        /// </param>
        /// <param name="revealedOutputTypes">
        /// Agent output types included in the widget's end-user event projection; the final response is always visible.<br/>
        /// Applies to every session created through this widget's alias, anonymous or signed-in.<br/>
        /// Omitted or empty reveals none.<br/>
        /// Default Value: []<br/>
        /// Example: [tool_calls]
        /// </param>
        /// <param name="sessionMetadata">
        /// Written as the `metadata` of every session created through this widget's alias, anonymous or signed-in.<br/>
        /// Readable wherever session metadata is readable: instruction templates, `run_condition`, `session_enrichment` references, alias routing rules, and tool `argument_override` expressions.<br/>
        /// Not served by the widget bootstrap endpoint and not returned on the end-user session object, though values reach the agent's context and may surface in its replies.<br/>
        /// Omitted or empty writes no session metadata.<br/>
        /// Default Value: {}<br/>
        /// Example: {"instance":"conversational-ai"}
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
            global::Vectara.WidgetPresentation presentation,
            string? aliasKey,
            int? sessionTtiMinutes,
            global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? revealedOutputTypes,
            object? sessionMetadata,
            global::Vectara.WidgetSignIn? endUserSignIn)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AliasKey = aliasKey;
            this.Presentation = presentation ?? throw new global::System.ArgumentNullException(nameof(presentation));
            this.SessionTtiMinutes = sessionTtiMinutes;
            this.RevealedOutputTypes = revealedOutputTypes;
            this.SessionMetadata = sessionMetadata;
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