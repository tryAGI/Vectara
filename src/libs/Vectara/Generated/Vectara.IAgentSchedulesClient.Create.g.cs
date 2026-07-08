#nullable enable

namespace Vectara
{
    public partial interface IAgentSchedulesClient
    {
        /// <summary>
        /// Create agent schedule<br/>
        /// Create a new schedule for automatically executing an agent at specified intervals. Each execution creates a new session with the configured message and metadata.<br/>
        /// Schedules enable automated agent workflows such as daily reports, periodic monitoring, or regular data processing. The schedule will create sessions tagged with metadata to identify them as scheduled executions.<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/schedules \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \c<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "daily-report",<br/>
        ///   "name": "Daily Summary Report",<br/>
        ///   "message": [{"type": "text", "content": "Generate a summary of today's activities"}],<br/>
        ///   "schedule": {<br/>
        ///     "type": "interval",<br/>
        ///     "interval": "PT24H"<br/>
        ///   },<br/>
        ///   "session_metadata": {<br/>
        ///     "report_type": "daily"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique schedule key, configuration, and creation timestamp.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentSchedule> CreateAsync(
            string agentKey,

            global::Vectara.CreateAgentScheduleRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent schedule<br/>
        /// Create a new schedule for automatically executing an agent at specified intervals. Each execution creates a new session with the configured message and metadata.<br/>
        /// Schedules enable automated agent workflows such as daily reports, periodic monitoring, or regular data processing. The schedule will create sessions tagged with metadata to identify them as scheduled executions.<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/schedules \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \c<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "daily-report",<br/>
        ///   "name": "Daily Summary Report",<br/>
        ///   "message": [{"type": "text", "content": "Generate a summary of today's activities"}],<br/>
        ///   "schedule": {<br/>
        ///     "type": "interval",<br/>
        ///     "interval": "PT24H"<br/>
        ///   },<br/>
        ///   "session_metadata": {<br/>
        ///     "report_type": "daily"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique schedule key, configuration, and creation timestamp.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AutoSDKHttpResponse<global::Vectara.AgentSchedule>> CreateAsResponseAsync(
            string agentKey,

            global::Vectara.CreateAgentScheduleRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent schedule<br/>
        /// Create a new schedule for automatically executing an agent at specified intervals. Each execution creates a new session with the configured message and metadata.<br/>
        /// Schedules enable automated agent workflows such as daily reports, periodic monitoring, or regular data processing. The schedule will create sessions tagged with metadata to identify them as scheduled executions.<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/schedules \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \c<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "daily-report",<br/>
        ///   "name": "Daily Summary Report",<br/>
        ///   "message": [{"type": "text", "content": "Generate a summary of today's activities"}],<br/>
        ///   "schedule": {<br/>
        ///     "type": "interval",<br/>
        ///     "interval": "PT24H"<br/>
        ///   },<br/>
        ///   "session_metadata": {<br/>
        ///     "report_type": "daily"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique schedule key, configuration, and creation timestamp.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="key">
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="description">
        /// Optional detailed description of the schedule's purpose.
        /// </param>
        /// <param name="message">
        /// The input message to send to the agent on each scheduled execution.
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule should execute.
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule should be active upon creation.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sessionMetadata">
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="runCondition">
        /// A UserFn boolean expression that gates execution. On each scheduled execution the agent's enrichment runs first, then this expression is evaluated against the enriched session context. The scheduled session is created and the agent runs only when the expression evaluates to true. When it evaluates to false the execution is skipped and no session is created.<br/>
        /// The expression uses the `get()` function with JSONPath to read the enriched context:<br/>
        /// * `$.session.metadata.*` for values written by the agent's enrichment<br/>
        /// * `$.agent.metadata.*` for the owning agent's metadata<br/>
        /// An enrichment tool call's output is visible to the condition only when the call writes it to metadata via metadata_target_path. Missing paths return null, and comparing against null is falsy, so an unresolved path skips the execution. Use `get('$.path', default)` for an explicit fallback. Omit this field to run on every execution.<br/>
        /// See https://docs.vectara.com/docs/reference/userfn-language for the UserFn language reference.<br/>
        /// Example: get('$.session.metadata.open_incidents') &gt; 0
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Maximum number of past execution records to keep. Defaults to 10.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="stallTimeoutSeconds">
        /// Number of seconds a scheduled run may go without producing output (streamed tokens, tool calls,<br/>
        /// or other progress events) before it is considered stalled and retried. Set this above the longest<br/>
        /// silent operation the agent is expected to perform so an in-flight run is not retried mid-operation.<br/>
        /// Default Value: 3600<br/>
        /// Example: 1800
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.AgentSchedule> CreateAsync(
            string agentKey,
            string name,
            global::System.Collections.Generic.IList<global::Vectara.AgentInput> message,
            global::Vectara.ScheduleConfiguration schedule,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? description = default,
            bool? enabled = default,
            object? sessionMetadata = default,
            string? runCondition = default,
            int? maxExecutionsToKeep = default,
            int? stallTimeoutSeconds = default,
            global::Vectara.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}