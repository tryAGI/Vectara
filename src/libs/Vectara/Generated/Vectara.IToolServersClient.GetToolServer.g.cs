#nullable enable

namespace Vectara
{
    public partial interface IToolServersClient
    {
        /// <summary>
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.IToolServersClient.GetToolServer.g.cs
        /// Get tool Server<br/>
        /// Retrieve details about a specific tool server by its Id.
========
        /// Synchronize tool server<br/>
        /// Trigger a synchronization of the tool server to ensure it is up-to-date with the latest tools.
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.IToolServersClient.SyncToolServer.g.cs
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="toolServerId">
        /// Example: tsr_rag_search
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.IToolServersClient.GetToolServer.g.cs
        global::System.Threading.Tasks.Task<global::Vectara.ToolServer> GetToolServerAsync(
========
        global::System.Threading.Tasks.Task SyncToolServerAsync(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.IToolServersClient.SyncToolServer.g.cs
            string toolServerId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}