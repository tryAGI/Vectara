
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Emitted periodically while a streamed Lambda tool test is still running.
    /// </summary>
    public sealed partial class TestToolHeartbeatEvent
    {
        /// <summary>
        /// Event type indicator. Always `heartbeat`.<br/>
        /// Default Value: heartbeat<br/>
        /// Example: heartbeat
        /// </summary>
        /// <default>"heartbeat"</default>
        /// <example>heartbeat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "heartbeat";

        /// <summary>
        /// Time elapsed since the test started, in milliseconds.<br/>
        /// Example: 30000
        /// </summary>
        /// <example>30000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_ms")]
        public int? ElapsedMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolHeartbeatEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Event type indicator. Always `heartbeat`.<br/>
        /// Default Value: heartbeat<br/>
        /// Example: heartbeat
        /// </param>
        /// <param name="elapsedMs">
        /// Time elapsed since the test started, in milliseconds.<br/>
        /// Example: 30000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestToolHeartbeatEvent(
            string type,
            int? elapsedMs)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ElapsedMs = elapsedMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolHeartbeatEvent" /> class.
        /// </summary>
        public TestToolHeartbeatEvent()
        {
        }

    }
}