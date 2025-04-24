
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The response object for streaming chat completions in chunks.
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponse
    {
        /// <summary>
        /// The object type, which is always 'chat.completion.chunk' for streaming responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter))]
        public global::Vectara.CreateChatCompletionStreamResponseObject Object { get; set; }

        /// <summary>
        /// A list of chat completion chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.ChatCompletionStreamResponseChoice> Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always 'chat.completion.chunk' for streaming responses.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion chunks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionStreamResponse(
            global::System.Collections.Generic.IList<global::Vectara.ChatCompletionStreamResponseChoice> choices,
            global::Vectara.CreateChatCompletionStreamResponseObject @object)
        {
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponse" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponse()
        {
        }
    }
}