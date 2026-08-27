
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The presentation configuration the widget client renders — branding, palette, welcome content, suggested prompts.<br/>
    /// Free-form apart from the required `version`; the platform stores it verbatim, serves it back uninterpreted, and caps its total size.<br/>
    /// Null-valued keys are accepted but are omitted from responses.<br/>
    /// Served to anonymous visitors by the unauthenticated widget bootstrap endpoint, so widget clients must treat every value as untrusted data.<br/>
    /// Schema validation of the payload lands with the first Altera release; `version` is what lets clients render older payloads once the shape evolves.
    /// </summary>
    public sealed partial class WidgetPresentation
    {
        /// <summary>
        /// The version of the presentation payload's shape, chosen by the writer and echoed verbatim on read.<br/>
        /// Until the first Altera release the only accepted value is `beta`, marking the payload as free-form; schema-validated numbered versions arrive with that release.<br/>
        /// Example: beta
        /// </summary>
        /// <example>beta</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetPresentation" /> class.
        /// </summary>
        /// <param name="version">
        /// The version of the presentation payload's shape, chosen by the writer and echoed verbatim on read.<br/>
        /// Until the first Altera release the only accepted value is `beta`, marking the payload as free-form; schema-validated numbered versions arrive with that release.<br/>
        /// Example: beta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetPresentation(
            string version)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetPresentation" /> class.
        /// </summary>
        public WidgetPresentation()
        {
        }

    }
}