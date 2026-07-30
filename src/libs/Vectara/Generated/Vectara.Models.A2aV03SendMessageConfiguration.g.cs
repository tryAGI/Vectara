
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Optional knobs that influence how the agent processes and responds to a v0.3 message.
    /// </summary>
    public sealed partial class A2aV03SendMessageConfiguration
    {
        /// <summary>
        /// Media types the client accepts for the agent's output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptedOutputModes")]
        public global::System.Collections.Generic.IList<string>? AcceptedOutputModes { get; set; }

        /// <summary>
        /// Webhook configuration for receiving v0.3 task updates out-of-band.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushNotification")]
        public global::Vectara.A2aV03PushNotificationConfig? PushNotification { get; set; }

        /// <summary>
        /// Maximum number of recent history messages to include in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("historyLength")]
        public int? HistoryLength { get; set; }

        /// <summary>
        /// When true, the call blocks until the task reaches a terminal state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        public bool? Blocking { get; set; }

        /// <summary>
        /// Inverse-semantics alias for `blocking`. If both are provided, `blocking` wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnImmediately")]
        public bool? ReturnImmediately { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03SendMessageConfiguration" /> class.
        /// </summary>
        /// <param name="acceptedOutputModes">
        /// Media types the client accepts for the agent's output.
        /// </param>
        /// <param name="pushNotification">
        /// Webhook configuration for receiving v0.3 task updates out-of-band.
        /// </param>
        /// <param name="historyLength">
        /// Maximum number of recent history messages to include in the response.
        /// </param>
        /// <param name="blocking">
        /// When true, the call blocks until the task reaches a terminal state.
        /// </param>
        /// <param name="returnImmediately">
        /// Inverse-semantics alias for `blocking`. If both are provided, `blocking` wins.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03SendMessageConfiguration(
            global::System.Collections.Generic.IList<string>? acceptedOutputModes,
            global::Vectara.A2aV03PushNotificationConfig? pushNotification,
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
        /// Initializes a new instance of the <see cref="A2aV03SendMessageConfiguration" /> class.
        /// </summary>
        public A2aV03SendMessageConfiguration()
        {
        }

    }
}