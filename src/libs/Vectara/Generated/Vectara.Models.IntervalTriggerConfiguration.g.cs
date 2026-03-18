
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Run the pipeline at a fixed interval.
    /// </summary>
    public sealed partial class IntervalTriggerConfiguration
    {
        /// <summary>
        /// Default Value: interval<br/>
        /// Example: interval
        /// </summary>
        /// <default>"interval"</default>
        /// <example>interval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "interval";

        /// <summary>
        /// An ISO-8601 duration specifying the interval between runs.<br/>
        /// Example: PT1H
        /// </summary>
        /// <example>PT1H</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalTriggerConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: interval<br/>
        /// Example: interval
        /// </param>
        /// <param name="duration">
        /// An ISO-8601 duration specifying the interval between runs.<br/>
        /// Example: PT1H
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntervalTriggerConfiguration(
            string type,
            string duration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalTriggerConfiguration" /> class.
        /// </summary>
        public IntervalTriggerConfiguration()
        {
        }
    }
}