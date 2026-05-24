
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubAgentToolActivityEventVariant2
    {
        /// <summary>
        /// Discriminator for ToolActivityEvent subtypes.<br/>
        /// Default Value: sub_agent<br/>
        /// Example: sub_agent
        /// </summary>
        /// <default>"sub_agent"</default>
        /// <example>sub_agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActivityType { get; set; } = "sub_agent";

        /// <summary>
        /// An event in an agent session conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AgentEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentEvent AgentEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolActivityEventVariant2" /> class.
        /// </summary>
        /// <param name="activityType">
        /// Discriminator for ToolActivityEvent subtypes.<br/>
        /// Default Value: sub_agent<br/>
        /// Example: sub_agent
        /// </param>
        /// <param name="agentEvent">
        /// An event in an agent session conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubAgentToolActivityEventVariant2(
            string activityType,
            global::Vectara.AgentEvent agentEvent)
        {
            this.ActivityType = activityType ?? throw new global::System.ArgumentNullException(nameof(activityType));
            this.AgentEvent = agentEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolActivityEventVariant2" /> class.
        /// </summary>
        public SubAgentToolActivityEventVariant2()
        {
        }

    }
}