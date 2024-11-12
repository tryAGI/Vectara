#nullable enable

namespace Vectara
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// List turns in a chat<br/>
        /// List all turns in a chat to see all message and response pairs that make up the dialog.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListChatTurnsResponse> ListChatTurnsAsync(
            string chatId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}