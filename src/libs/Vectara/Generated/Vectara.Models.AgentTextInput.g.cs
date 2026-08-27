
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A text input for an agent message.
    /// </summary>
    public sealed partial class AgentTextInput
    {
        /// <summary>
        /// The type of input.<br/>
        /// Default Value: text<br/>
        /// Example: text
        /// </summary>
        /// <default>"text"</default>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "text";

        /// <summary>
        /// The text content of the input.<br/>
        /// Example: I need help with my widget installation
        /// </summary>
        /// <example>I need help with my widget installation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The submitter's own identifier for this input, e.g. a Slack message timestamp. Opaque to Vectara, and unique within the session: submitting an input whose `external_id` the session already holds adds nothing and returns no error. An input without an `external_id` is always added. Returned on the input's event in `InputMessageEvent.messages`.<br/>
        /// Example: 1787105665.831929
        /// </summary>
        /// <example>1787105665.831929</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTextInput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input.<br/>
        /// Default Value: text<br/>
        /// Example: text
        /// </param>
        /// <param name="content">
        /// The text content of the input.<br/>
        /// Example: I need help with my widget installation
        /// </param>
        /// <param name="externalId">
        /// The submitter's own identifier for this input, e.g. a Slack message timestamp. Opaque to Vectara, and unique within the session: submitting an input whose `external_id` the session already holds adds nothing and returns no error. An input without an `external_id` is always added. Returned on the input's event in `InputMessageEvent.messages`.<br/>
        /// Example: 1787105665.831929
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTextInput(
            string type,
            string content,
            string? externalId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTextInput" /> class.
        /// </summary>
        public AgentTextInput()
        {
        }

    }
}