#nullable enable

namespace Vectara
{
    public partial interface ILLMChatCompletionsClient
    {
        /// <summary>
        /// Creates a model response for the given chat conversation<br/>
        /// OpenAI-compatible endpoint for chat completions. Creates a response for the given chat conversation. <br/>
        /// The chat completion API allows you to chat with Vectara's language models in a way that's compatible with OpenAI's specification. <br/>
        /// This makes it easy to integrate with applications already designed for OpenAI's API.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.CreateChatCompletionResponse> CreateChatCompletionAsync(
            global::Vectara.CreateChatCompletionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a model response for the given chat conversation<br/>
        /// OpenAI-compatible endpoint for chat completions. Creates a response for the given chat conversation. <br/>
        /// The chat completion API allows you to chat with Vectara's language models in a way that's compatible with OpenAI's specification. <br/>
        /// This makes it easy to integrate with applications already designed for OpenAI's API.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.CreateChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::Vectara.ChatCompletionRequestMessage> messages,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? stream = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}