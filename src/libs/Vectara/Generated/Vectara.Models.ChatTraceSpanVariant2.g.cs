
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTraceSpanVariant2
    {
        /// <summary>
        /// The operation type for this span.<br/>
        /// Default Value: chat<br/>
        /// Example: chat
        /// </summary>
        /// <default>"chat"</default>
        /// <example>chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; } = "chat";

        /// <summary>
        /// Attributes for a chat (LLM completion) span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::Vectara.ChatSpanAttributes? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTraceSpanVariant2" /> class.
        /// </summary>
        /// <param name="operation">
        /// The operation type for this span.<br/>
        /// Default Value: chat<br/>
        /// Example: chat
        /// </param>
        /// <param name="attributes">
        /// Attributes for a chat (LLM completion) span.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTraceSpanVariant2(
            string operation,
            global::Vectara.ChatSpanAttributes? attributes)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTraceSpanVariant2" /> class.
        /// </summary>
        public ChatTraceSpanVariant2()
        {
        }
    }
}