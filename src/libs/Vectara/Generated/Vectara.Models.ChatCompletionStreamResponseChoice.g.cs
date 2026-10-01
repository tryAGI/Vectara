
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single chat completion chunk choice in a streaming response.
    /// </summary>
    public sealed partial class ChatCompletionStreamResponseChoice
    {
        /// <summary>
        /// The index of the choice in the array of choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// A partial message update to be merged with previous chunks in a streaming response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ChatCompletionStreamResponseDelta Delta { get; set; }

        /// <summary>
        /// Why the model stopped. Only the last chunk of a stream carries it. `stop` means the model finished, and `length` means it ran out of output tokens and the content is incomplete. A `json_schema` response that is cut off always reports `length`. Other values can appear.<br/>
        /// Example: stop
        /// </summary>
        /// <example>stop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice in the array of choices.
        /// </param>
        /// <param name="delta">
        /// A partial message update to be merged with previous chunks in a streaming response.
        /// </param>
        /// <param name="finishReason">
        /// Why the model stopped. Only the last chunk of a stream carries it. `stop` means the model finished, and `length` means it ran out of output tokens and the content is incomplete. A `json_schema` response that is cut off always reports `length`. Other values can appear.<br/>
        /// Example: stop
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionStreamResponseChoice(
            int index,
            global::Vectara.ChatCompletionStreamResponseDelta delta,
            string? finishReason)
        {
            this.Index = index;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        public ChatCompletionStreamResponseChoice()
        {
        }

    }
}