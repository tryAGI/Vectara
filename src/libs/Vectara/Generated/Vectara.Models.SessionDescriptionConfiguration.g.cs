
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Controls how this agent's sessions created without a description get one. Generation sends one additional request to the agent's model, using the text of the input message that triggers it (the first input message with text, or the next one after a failed request), and stores the result on the session. That request consumes tokens. When the response is streamed, the stream also carries a `session_description` event. A description supplied on session create or update is never replaced, and an empty description turns off generation for that session.
    /// </summary>
    public sealed partial class SessionDescriptionConfiguration
    {
        /// <summary>
        /// Whether the platform generates descriptions. When false, no request is made and those sessions keep no description. If a request fails, the next input message with text triggers another request.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether a turn stays open until the description request started during it has finished, for up to 30 seconds. When true, the `session_description` event arrives before the stream ends and a non-streamed response returns after the description is stored, unless the request fails, exceeds that limit, or the session is interrupted. When false, the turn can end first, and the event then arrives on a later turn's stream. The wait adds to the turn's duration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliver_before_turn_end")]
        public bool? DeliverBeforeTurnEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDescriptionConfiguration" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the platform generates descriptions. When false, no request is made and those sessions keep no description. If a request fails, the next input message with text triggers another request.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="deliverBeforeTurnEnd">
        /// Whether a turn stays open until the description request started during it has finished, for up to 30 seconds. When true, the `session_description` event arrives before the stream ends and a non-streamed response returns after the description is stored, unless the request fails, exceeds that limit, or the session is interrupted. When false, the turn can end first, and the event then arrives on a later turn's stream. The wait adds to the turn's duration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionDescriptionConfiguration(
            bool? enabled,
            bool? deliverBeforeTurnEnd)
        {
            this.Enabled = enabled;
            this.DeliverBeforeTurnEnd = deliverBeforeTurnEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDescriptionConfiguration" /> class.
        /// </summary>
        public SessionDescriptionConfiguration()
        {
        }

    }
}