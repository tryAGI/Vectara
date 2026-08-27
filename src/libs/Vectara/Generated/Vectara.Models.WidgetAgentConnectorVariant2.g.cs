
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WidgetAgentConnectorVariant2
    {
        /// <summary>
        /// The type of connector.<br/>
        /// Default Value: widget<br/>
        /// Example: widget
        /// </summary>
        /// <default>"widget"</default>
        /// <example>widget</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "widget";

        /// <summary>
        /// Whether this connector admits anonymous visitors.<br/>
        /// Independent of `status`.<br/>
        /// While `false`, the widget bootstrap endpoint returns `404` for the connector and every previously minted visitor id is refused on the end-user session surface.<br/>
        /// Gates anonymous admission only; authenticated callers presenting this connector are governed by `enabled`.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PublicAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetAgentConnectorVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Default Value: widget<br/>
        /// Example: widget
        /// </param>
        /// <param name="publicAccess">
        /// Whether this connector admits anonymous visitors.<br/>
        /// Independent of `status`.<br/>
        /// While `false`, the widget bootstrap endpoint returns `404` for the connector and every previously minted visitor id is refused on the end-user session surface.<br/>
        /// Gates anonymous admission only; authenticated callers presenting this connector are governed by `enabled`.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetAgentConnectorVariant2(
            string type,
            bool publicAccess)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PublicAccess = publicAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetAgentConnectorVariant2" /> class.
        /// </summary>
        public WidgetAgentConnectorVariant2()
        {
        }

    }
}