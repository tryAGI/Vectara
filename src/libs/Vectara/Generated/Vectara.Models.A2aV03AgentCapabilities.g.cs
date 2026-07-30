
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Capabilities the v0.3 agent advertises.
    /// </summary>
    public sealed partial class A2aV03AgentCapabilities
    {
        /// <summary>
        /// True if the agent supports streaming responses via SSE.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// True if the agent supports out-of-band push notifications.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushNotifications")]
        public bool? PushNotifications { get; set; }

        /// <summary>
        /// Protocol extensions supported by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentExtension>? Extensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AgentCapabilities" /> class.
        /// </summary>
        /// <param name="streaming">
        /// True if the agent supports streaming responses via SSE.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pushNotifications">
        /// True if the agent supports out-of-band push notifications.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="extensions">
        /// Protocol extensions supported by the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03AgentCapabilities(
            bool? streaming,
            bool? pushNotifications,
            global::System.Collections.Generic.IList<global::Vectara.A2aV03AgentExtension>? extensions)
        {
            this.Streaming = streaming;
            this.PushNotifications = pushNotifications;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AgentCapabilities" /> class.
        /// </summary>
        public A2aV03AgentCapabilities()
        {
        }

    }
}