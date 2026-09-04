
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update view of a web widget connector's configuration. Omitted fields keep their stored value; nested objects such as `presentation` are replaced whole when supplied.
    /// </summary>
    public sealed partial class UpdateWidgetConnectorConfiguration
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
        /// Whether the widget admits anonymous visitors. Omitted leaves the current value unchanged.<br/>
        /// Setting it to `false` refuses every previously minted visitor id; the change takes effect within a few seconds.<br/>
        /// Gates anonymous admission only; authenticated callers presenting this connector are governed by `enabled`.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_access")]
        public bool? PublicAccess { get; set; }

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
        public global::Vectara.WidgetPresentation? Presentation { get; set; }

        /// <summary>
        /// How long a session created through this widget may sit idle before it is closed, in minutes. Set to 0 for sessions that never expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_tti_minutes")]
        public int? SessionTtiMinutes { get; set; }

        /// <summary>
        /// Agent output types included in the widget's end-user event projection; the final response is always visible.<br/>
        /// Example: [tool_calls]
        /// </summary>
        /// <example>[tool_calls]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revealed_output_types")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? RevealedOutputTypes { get; set; }

        /// <summary>
        /// Written as the `metadata` of every session created through this widget's alias.<br/>
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
        /// Present on the read view for consistency with other connector types; widget connectors ignore it and control end-user visibility through `revealed_output_types`. Accepted on update so a read-modify-write round trip is not rejected.<br/>
        /// Example: [tool_calls]
        /// </summary>
        /// <example>[tool_calls]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden_output_types")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? HiddenOutputTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWidgetConnectorConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector configuration.<br/>
        /// Default Value: widget<br/>
        /// Example: widget
        /// </param>
        /// <param name="publicAccess">
        /// Whether the widget admits anonymous visitors. Omitted leaves the current value unchanged.<br/>
        /// Setting it to `false` refuses every previously minted visitor id; the change takes effect within a few seconds.<br/>
        /// Gates anonymous admission only; authenticated callers presenting this connector are governed by `enabled`.<br/>
        /// Example: false
        /// </param>
        /// <param name="aliasKey">
        /// The platform-generated key of the alias fronting a widget connector, as reported in the connector's `alias_key` and `bootstrap_path`. Always `als_`-prefixed; the prefix is reserved, so no operator-chosen alias ever matches it.<br/>
        /// Example: als_9f3a1c2b-4d5e-6f70-8192-a3b4c5d6e7f8_00aa
        /// </param>
        /// <param name="presentation">
        /// The presentation configuration the widget client renders — branding, palette, welcome content, suggested prompts.<br/>
        /// Free-form apart from the required `version`; the platform stores it verbatim, serves it back uninterpreted, and caps its total size.<br/>
        /// Null-valued keys are accepted but are omitted from responses.<br/>
        /// Served to anonymous visitors by the unauthenticated widget bootstrap endpoint, so widget clients must treat every value as untrusted data.<br/>
        /// Schema validation of the payload lands with the first Altera release; `version` is what lets clients render older payloads once the shape evolves.
        /// </param>
        /// <param name="sessionTtiMinutes">
        /// How long a session created through this widget may sit idle before it is closed, in minutes. Set to 0 for sessions that never expire.
        /// </param>
        /// <param name="revealedOutputTypes">
        /// Agent output types included in the widget's end-user event projection; the final response is always visible.<br/>
        /// Example: [tool_calls]
        /// </param>
        /// <param name="sessionMetadata">
        /// Written as the `metadata` of every session created through this widget's alias.<br/>
        /// Example: {"instance":"conversational-ai"}
        /// </param>
        /// <param name="endUserSignIn">
        /// Enables the widget's sign-in affordance and names the identity provider it authenticates users against.<br/>
        /// The host page supplies a token minted by the referenced trusted token issuer, and the widget presents it as the bearer credential on end-user session requests.<br/>
        /// The platform verifies the token by its `iss` claim against the globally-unique issuer registration — never against this connector — so the token stands on its own: it signs the caller in as an end user across the customer's aliases, not this widget's alone.<br/>
        /// The platform accepts the token when its signature verifies against the issuer's JWKS and it carries an `email` claim.<br/>
        /// The referenced registration must exist, or the connector write is rejected with `400`.
        /// </param>
        /// <param name="hiddenOutputTypes">
        /// Present on the read view for consistency with other connector types; widget connectors ignore it and control end-user visibility through `revealed_output_types`. Accepted on update so a read-modify-write round trip is not rejected.<br/>
        /// Example: [tool_calls]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWidgetConnectorConfiguration(
            string type,
            bool? publicAccess,
            string? aliasKey,
            global::Vectara.WidgetPresentation? presentation,
            int? sessionTtiMinutes,
            global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? revealedOutputTypes,
            object? sessionMetadata,
            global::Vectara.WidgetSignIn? endUserSignIn,
            global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? hiddenOutputTypes)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PublicAccess = publicAccess;
            this.AliasKey = aliasKey;
            this.Presentation = presentation;
            this.SessionTtiMinutes = sessionTtiMinutes;
            this.RevealedOutputTypes = revealedOutputTypes;
            this.SessionMetadata = sessionMetadata;
            this.EndUserSignIn = endUserSignIn;
            this.HiddenOutputTypes = hiddenOutputTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWidgetConnectorConfiguration" /> class.
        /// </summary>
        public UpdateWidgetConnectorConfiguration()
        {
        }

    }
}