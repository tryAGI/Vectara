#nullable enable

namespace Vectara
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Delete a chat<br/>
        /// Delete a chat and any turns it contains permanently.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="chatId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteChatAsync(
            string chatId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}