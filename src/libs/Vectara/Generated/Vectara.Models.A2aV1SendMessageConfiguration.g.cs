
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Optional settings that control how the agent processes and responds to a v1 message.
    /// </summary>
    public sealed partial class A2aV1SendMessageConfiguration
    {
        /// <summary>
        /// Media types the client accepts for the agent's output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptedOutputModes")]
        public global::System.Collections.Generic.IList<string>? AcceptedOutputModes { get; set; }

        /// <summary>
        /// Push notification configuration for a v1 task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushNotification")]
        public global::Vectara.A2aV1TaskPushNotificationConfig? PushNotification { get; set; }

        /// <summary>
        /// Maximum number of recent history messages to include in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("historyLength")]
        public int? HistoryLength { get; set; }

        /// <summary>
        /// When true (the default), the call blocks until the task reaches a terminal or interrupted state. The response contains the resulting task. Set to false to return as soon as the task is accepted. Then poll `getTask` or subscribe to the task stream. `returnImmediately` is an inverse-semantics alias. If both are sent, `blocking` wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        public bool? Blocking { get; set; }

        /// <summary>
        /// Inverse-semantics alias for `blocking`. When `returnImmediately=true` the call returns as soon as the task is accepted (equivalent to `blocking=false`). If both are provided, `blocking` wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnImmediately")]
        public bool? ReturnImmediately { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1SendMessageConfiguration" /> class.
        /// </summary>
        /// <param name="acceptedOutputModes">
        /// Media types the client accepts for the agent's output.
        /// </param>
        /// <param name="pushNotification">
        /// Push notification configuration for a v1 task.
        /// </param>
        /// <param name="historyLength">
        /// Maximum number of recent history messages to include in the response.
        /// </param>
        /// <param name="blocking">
        /// When true (the default), the call blocks until the task reaches a terminal or interrupted state. The response contains the resulting task. Set to false to return as soon as the task is accepted. Then poll `getTask` or subscribe to the task stream. `returnImmediately` is an inverse-semantics alias. If both are sent, `blocking` wins.
        /// </param>
        /// <param name="returnImmediately">
        /// Inverse-semantics alias for `blocking`. When `returnImmediately=true` the call returns as soon as the task is accepted (equivalent to `blocking=false`). If both are provided, `blocking` wins.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1SendMessageConfiguration(
            global::System.Collections.Generic.IList<string>? acceptedOutputModes,
            global::Vectara.A2aV1TaskPushNotificationConfig? pushNotification,
            int? historyLength,
            bool? blocking,
            bool? returnImmediately)
        {
            this.AcceptedOutputModes = acceptedOutputModes;
            this.PushNotification = pushNotification;
            this.HistoryLength = historyLength;
            this.Blocking = blocking;
            this.ReturnImmediately = returnImmediately;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1SendMessageConfiguration" /> class.
        /// </summary>
        public A2aV1SendMessageConfiguration()
        {
        }

    }
}