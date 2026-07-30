
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Optional capabilities the v1 agent supports, such as streaming and the extended agent card.
    /// </summary>
    public sealed partial class A2aV1AgentCapabilities
    {
        /// <summary>
        /// True if the agent supports streaming responses via SSE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// True if the agent supports out-of-band push notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushNotifications")]
        public bool? PushNotifications { get; set; }

        /// <summary>
        /// Protocol extensions supported by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentExtension>? Extensions { get; set; }

        /// <summary>
        /// True if the agent serves an extended card requiring authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extendedAgentCard")]
        public bool? ExtendedAgentCard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentCapabilities" /> class.
        /// </summary>
        /// <param name="streaming">
        /// True if the agent supports streaming responses via SSE.
        /// </param>
        /// <param name="pushNotifications">
        /// True if the agent supports out-of-band push notifications.
        /// </param>
        /// <param name="extensions">
        /// Protocol extensions supported by the agent.
        /// </param>
        /// <param name="extendedAgentCard">
        /// True if the agent serves an extended card requiring authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AgentCapabilities(
            bool? streaming,
            bool? pushNotifications,
            global::System.Collections.Generic.IList<global::Vectara.A2aV1AgentExtension>? extensions,
            bool? extendedAgentCard)
        {
            this.Streaming = streaming;
            this.PushNotifications = pushNotifications;
            this.Extensions = extensions;
            this.ExtendedAgentCard = extendedAgentCard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentCapabilities" /> class.
        /// </summary>
        public A2aV1AgentCapabilities()
        {
        }

    }
}