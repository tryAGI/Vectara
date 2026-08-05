
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for interval-based schedule execution.
    /// </summary>
    public sealed partial class IntervalScheduleConfiguration
    {
        /// <summary>
        /// The type of schedule.<br/>
        /// Example: interval
        /// </summary>
        /// <example>interval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.IntervalScheduleConfigurationTypeJsonConverter))]
        public global::Vectara.IntervalScheduleConfigurationType Type { get; set; }

        /// <summary>
        /// ISO-8601 duration string specifying the interval between executions.<br/>
        /// Minimum interval is 1 hour (PT1H).<br/>
        /// Format: P[n]DT[n]H[n]M[n]S<br/>
        /// - P: Period designator (required)<br/>
        /// - T: Time designator (separates the day and time components)<br/>
        /// Only day and time components are accepted. Month and year units, such as P1M, are rejected.<br/>
        /// Common examples:<br/>
        /// - PT1H: Every 1 hour<br/>
        /// - PT6H: Every 6 hours<br/>
        /// - PT24H or P1D: Every 24 hours (daily)<br/>
        /// - P7D: Every 7 days (weekly)<br/>
        /// - P30D: Every 30 days<br/>
        /// Reference: https://en.wikipedia.org/wiki/ISO_8601#Durations<br/>
        /// Example: PT24H
        /// </summary>
        /// <example>PT24H</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Interval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalScheduleConfiguration" /> class.
        /// </summary>
        /// <param name="interval">
        /// ISO-8601 duration string specifying the interval between executions.<br/>
        /// Minimum interval is 1 hour (PT1H).<br/>
        /// Format: P[n]DT[n]H[n]M[n]S<br/>
        /// - P: Period designator (required)<br/>
        /// - T: Time designator (separates the day and time components)<br/>
        /// Only day and time components are accepted. Month and year units, such as P1M, are rejected.<br/>
        /// Common examples:<br/>
        /// - PT1H: Every 1 hour<br/>
        /// - PT6H: Every 6 hours<br/>
        /// - PT24H or P1D: Every 24 hours (daily)<br/>
        /// - P7D: Every 7 days (weekly)<br/>
        /// - P30D: Every 30 days<br/>
        /// Reference: https://en.wikipedia.org/wiki/ISO_8601#Durations<br/>
        /// Example: PT24H
        /// </param>
        /// <param name="type">
        /// The type of schedule.<br/>
        /// Example: interval
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntervalScheduleConfiguration(
            string interval,
            global::Vectara.IntervalScheduleConfigurationType type)
        {
            this.Type = type;
            this.Interval = interval ?? throw new global::System.ArgumentNullException(nameof(interval));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervalScheduleConfiguration" /> class.
        /// </summary>
        public IntervalScheduleConfiguration()
        {
        }

    }
}