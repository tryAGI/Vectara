
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Execution configuration for the function.
    /// </summary>
    public sealed partial class ExecutionConfiguration
    {
        /// <summary>
        /// Maximum execution time in seconds, up to 21600. When `execution_configuration` is omitted entirely, a lambda that declares `tool_configurations` resolves to 300 seconds and any other lambda resolves to 30. When `execution_configuration` is supplied without this field, the declared default of 30 applies. `max_execution_time_seconds` on the agent's tool-configuration entry takes precedence over this field.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_execution_time_seconds")]
        public int? MaxExecutionTimeSeconds { get; set; }

        /// <summary>
        /// Deprecated and ignored. Memory is fixed by the execution environment and cannot be configured per function.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_memory_mb")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxMemoryMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionConfiguration" /> class.
        /// </summary>
        /// <param name="maxExecutionTimeSeconds">
        /// Maximum execution time in seconds, up to 21600. When `execution_configuration` is omitted entirely, a lambda that declares `tool_configurations` resolves to 300 seconds and any other lambda resolves to 30. When `execution_configuration` is supplied without this field, the declared default of 30 applies. `max_execution_time_seconds` on the agent's tool-configuration entry takes precedence over this field.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionConfiguration(
            int? maxExecutionTimeSeconds)
        {
            this.MaxExecutionTimeSeconds = maxExecutionTimeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionConfiguration" /> class.
        /// </summary>
        public ExecutionConfiguration()
        {
        }

    }
}