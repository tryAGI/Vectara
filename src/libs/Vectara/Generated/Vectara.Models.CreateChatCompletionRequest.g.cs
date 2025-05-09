
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The request object for creating a chat completion with an OpenAI-compatible interface. This object is compatible with OpenAI's chat completion schema and supports customizable parameters for response generation.
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// The ID of the model to use. This field is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// An ordered array of messages that represent the full context of the conversation to date. Each message includes a `role` and `content`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.ChatCompletionRequestMessage> Messages { get; set; }

        /// <summary>
        /// Optional. When set to `true`, the API streams partial message deltas as they become available, similar to ChatGPT's streaming mode.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The ID of the model to use. This field is required.
        /// </param>
        /// <param name="messages">
        /// An ordered array of messages that represent the full context of the conversation to date. Each message includes a `role` and `content`.
        /// </param>
        /// <param name="stream">
        /// Optional. When set to `true`, the API streams partial message deltas as they become available, similar to ChatGPT's streaming mode.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::Vectara.ChatCompletionRequestMessage> messages,
            bool? stream)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }
    }
}