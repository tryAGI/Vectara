
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEndUserInputMessageRequestVariant2
    {
        /// <summary>
        /// Default Value: input_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of inputs that make up this message.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </summary>
        /// <example>[{"type":"text","content":"I need help with my widget installation"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentInput> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserInputMessageRequestVariant2" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of inputs that make up this message.<br/>
        /// Example: [{"type":"text","content":"I need help with my widget installation"}]
        /// </param>
        /// <param name="type">
        /// Default Value: input_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEndUserInputMessageRequestVariant2(
            global::System.Collections.Generic.IList<global::Vectara.AgentInput> messages,
            string? type)
        {
            this.Type = type;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserInputMessageRequestVariant2" /> class.
        /// </summary>
        public CreateEndUserInputMessageRequestVariant2()
        {
        }

    }
}