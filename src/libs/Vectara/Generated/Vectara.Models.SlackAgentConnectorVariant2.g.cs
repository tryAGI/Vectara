
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SlackAgentConnectorVariant2
    {
        /// <summary>
        /// The type of connector.<br/>
        /// Default Value: slack<br/>
        /// Example: slack
        /// </summary>
        /// <default>"slack"</default>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "slack";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAgentConnectorVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of connector.<br/>
        /// Default Value: slack<br/>
        /// Example: slack
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackAgentConnectorVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAgentConnectorVariant2" /> class.
        /// </summary>
        public SlackAgentConnectorVariant2()
        {
        }

    }
}