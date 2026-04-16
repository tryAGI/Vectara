
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Run the pipeline on a cron schedule.
    /// </summary>
    public sealed partial class CronTriggerConfiguration
    {
        /// <summary>
        /// Default Value: cron<br/>
        /// Example: cron
        /// </summary>
        /// <default>"cron"</default>
        /// <example>cron</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "cron";

        /// <summary>
        /// A 5-field cron expression (minute, hour, day-of-month, month, day-of-week) in UTC.<br/>
        /// Example: 0 */6 * * *
        /// </summary>
        /// <example>0 */6 * * *</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CronTriggerConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: cron<br/>
        /// Example: cron
        /// </param>
        /// <param name="expression">
        /// A 5-field cron expression (minute, hour, day-of-month, month, day-of-week) in UTC.<br/>
        /// Example: 0 */6 * * *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CronTriggerConfiguration(
            string type,
            string expression)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CronTriggerConfiguration" /> class.
        /// </summary>
        public CronTriggerConfiguration()
        {
        }
    }
}