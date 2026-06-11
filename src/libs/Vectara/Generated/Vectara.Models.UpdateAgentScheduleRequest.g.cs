
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for updating an existing agent schedule. All fields are optional for PATCH semantics.
    /// </summary>
    public sealed partial class UpdateAgentScheduleRequest
    {
        /// <summary>
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </summary>
        /// <example>Daily Summary Report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated description of the schedule's purpose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Updated input message to send to the agent on each scheduled execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentInput>? Message { get; set; }

        /// <summary>
        /// Configuration for when and how often the schedule should execute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ScheduleConfigurationJsonConverter))]
        public global::Vectara.ScheduleConfiguration? Schedule { get; set; }

        /// <summary>
        /// Updated enabled status for the schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Updated metadata to include in each session created by this schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_metadata")]
        public object? SessionMetadata { get; set; }

        /// <summary>
        /// Updated maximum number of past execution records to keep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_executions_to_keep")]
        public int? MaxExecutionsToKeep { get; set; }

        /// <summary>
        /// Updated number of seconds a scheduled run may go without producing output before it is<br/>
        /// considered stalled and retried. Omit to leave the current value unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stall_timeout_seconds")]
        public int? StallTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentScheduleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="description">
        /// Updated description of the schedule's purpose.
        /// </param>
        /// <param name="message">
        /// Updated input message to send to the agent on each scheduled execution.
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule should execute.
        /// </param>
        /// <param name="enabled">
        /// Updated enabled status for the schedule.
        /// </param>
        /// <param name="sessionMetadata">
        /// Updated metadata to include in each session created by this schedule.
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Updated maximum number of past execution records to keep.
        /// </param>
        /// <param name="stallTimeoutSeconds">
        /// Updated number of seconds a scheduled run may go without producing output before it is<br/>
        /// considered stalled and retried. Omit to leave the current value unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentScheduleRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::Vectara.AgentInput>? message,
            global::Vectara.ScheduleConfiguration? schedule,
            bool? enabled,
            object? sessionMetadata,
            int? maxExecutionsToKeep,
            int? stallTimeoutSeconds)
        {
            this.Name = name;
            this.Description = description;
            this.Message = message;
            this.Schedule = schedule;
            this.Enabled = enabled;
            this.SessionMetadata = sessionMetadata;
            this.MaxExecutionsToKeep = maxExecutionsToKeep;
            this.StallTimeoutSeconds = stallTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentScheduleRequest" /> class.
        /// </summary>
        public UpdateAgentScheduleRequest()
        {
        }

    }
}