
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single chat completion choice returned in the response
    /// </summary>
    public sealed partial class ChatCompletionResponseChoice
    {
        /// <summary>
        /// The index of the choice in the array of choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// A message in the chat completion response from the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ChatCompletionResponseMessage Message { get; set; }

        /// <summary>
        /// Why the model stopped. `stop` means the model finished, and `length` means it ran out of output tokens and the content is incomplete. A `json_schema` response that is cut off always reports `length`. Other values can appear.<br/>
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
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice in the array of choices.
        /// </param>
        /// <param name="message">
        /// A message in the chat completion response from the assistant.
        /// </param>
        /// <param name="finishReason">
        /// Why the model stopped. `stop` means the model finished, and `length` means it ran out of output tokens and the content is incomplete. A `json_schema` response that is cut off always reports `length`. Other values can appear.<br/>
        /// Example: stop
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseChoice(
            int index,
            global::Vectara.ChatCompletionResponseMessage message,
            string? finishReason)
        {
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseChoice" /> class.
        /// </summary>
        public ChatCompletionResponseChoice()
        {
        }

    }
}