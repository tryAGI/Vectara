
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a new agent schedule.
    /// </summary>
    public sealed partial class CreateAgentScheduleRequest
    {
        /// <summary>
        /// A unique key that identifies an agent schedule.<br/>
        /// Example: daily-report
        /// </summary>
        /// <example>daily-report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </summary>
        /// <example>Daily Summary Report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional detailed description of the schedule's purpose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The input message to send to the agent on each scheduled execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AgentInput> Message { get; set; }

        /// <summary>
        /// Configuration for when and how often the schedule executes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.ScheduleConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ScheduleConfiguration Schedule { get; set; }

        /// <summary>
        /// Whether the schedule is active upon creation.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_metadata")]
        public object? SessionMetadata { get; set; }

        /// <summary>
        /// A UserFn boolean expression that gates execution. On each scheduled execution the agent's enrichment runs first. The schedule then evaluates this expression against the enriched session context. When the expression evaluates to true, the schedule creates the session and the agent runs. When it evaluates to false, the schedule skips the execution and creates no session.<br/>
        /// The expression uses the `get()` function with JSONPath to read the enriched context:<br/>
        /// * `$.session.metadata.*` for values written by the agent's enrichment<br/>
        /// * `$.agent.metadata.*` for the owning agent's metadata<br/>
        /// An enrichment tool call's output is visible to the condition only when the call writes it to metadata via metadata_target_path. Missing paths return null. Comparing against null is falsy, so an unresolved path skips the execution. Use `get('$.path', default)` for an explicit fallback. Omit this field to run on every execution.<br/>
        /// See https://docs.vectara.com/docs/reference/userfn-language for the UserFn language reference.<br/>
        /// Example: get('$.session.metadata.open_incidents') &gt; 0
        /// </summary>
        /// <example>get('$.session.metadata.open_incidents') &gt; 0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_condition")]
        public string? RunCondition { get; set; }

        /// <summary>
        /// Maximum number of past execution records to keep. Defaults to 10.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_executions_to_keep")]
        public int? MaxExecutionsToKeep { get; set; }

        /// <summary>
        /// The number of seconds a scheduled run may go without producing output (streamed tokens, tool calls,<br/>
        /// or other progress events). After this period, the run is considered stalled and is retried. Set this<br/>
        /// above the longest silent operation the agent performs, so an in-flight run is not retried mid-operation.<br/>
        /// Default Value: 3600<br/>
        /// Example: 1800
        /// </summary>
        /// <example>1800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stall_timeout_seconds")]
        public int? StallTimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentScheduleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="message">
        /// The input message to send to the agent on each scheduled execution.
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule executes.
        /// </param>
        /// <param name="key">
        /// A unique key that identifies an agent schedule.<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="description">
        /// Optional detailed description of the schedule's purpose.
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule is active upon creation.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sessionMetadata">
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="runCondition">
        /// A UserFn boolean expression that gates execution. On each scheduled execution the agent's enrichment runs first. The schedule then evaluates this expression against the enriched session context. When the expression evaluates to true, the schedule creates the session and the agent runs. When it evaluates to false, the schedule skips the execution and creates no session.<br/>
        /// The expression uses the `get()` function with JSONPath to read the enriched context:<br/>
        /// * `$.session.metadata.*` for values written by the agent's enrichment<br/>
        /// * `$.agent.metadata.*` for the owning agent's metadata<br/>
        /// An enrichment tool call's output is visible to the condition only when the call writes it to metadata via metadata_target_path. Missing paths return null. Comparing against null is falsy, so an unresolved path skips the execution. Use `get('$.path', default)` for an explicit fallback. Omit this field to run on every execution.<br/>
        /// See https://docs.vectara.com/docs/reference/userfn-language for the UserFn language reference.<br/>
        /// Example: get('$.session.metadata.open_incidents') &gt; 0
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Maximum number of past execution records to keep. Defaults to 10.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="stallTimeoutSeconds">
        /// The number of seconds a scheduled run may go without producing output (streamed tokens, tool calls,<br/>
        /// or other progress events). After this period, the run is considered stalled and is retried. Set this<br/>
        /// above the longest silent operation the agent performs, so an in-flight run is not retried mid-operation.<br/>
        /// Default Value: 3600<br/>
        /// Example: 1800
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentScheduleRequest(
            string name,
            global::System.Collections.Generic.IList<global::Vectara.AgentInput> message,
            global::Vectara.ScheduleConfiguration schedule,
            string? key,
            string? description,
            bool? enabled,
            object? sessionMetadata,
            string? runCondition,
            int? maxExecutionsToKeep,
            int? stallTimeoutSeconds)
        {
            this.Key = key;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Schedule = schedule;
            this.Enabled = enabled;
            this.SessionMetadata = sessionMetadata;
            this.RunCondition = runCondition;
            this.MaxExecutionsToKeep = maxExecutionsToKeep;
            this.StallTimeoutSeconds = stallTimeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentScheduleRequest" /> class.
        /// </summary>
        public CreateAgentScheduleRequest()
        {
        }

    }
}