
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndUserInputMessageEventVariant2
    {
        /// <summary>
        /// Default Value: input_message
        /// </summary>
        /// <default>"input_message"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "input_message";

        /// <summary>
        /// List of inputs that make up this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentInput> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserInputMessageEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: input_message
        /// </param>
        /// <param name="messages">
        /// List of inputs that make up this message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserInputMessageEventVariant2(
            string type,
            global::System.Collections.Generic.IList<global::Vectara.AgentInput> messages)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserInputMessageEventVariant2" /> class.
        /// </summary>
        public EndUserInputMessageEventVariant2()
        {
        }

    }
}