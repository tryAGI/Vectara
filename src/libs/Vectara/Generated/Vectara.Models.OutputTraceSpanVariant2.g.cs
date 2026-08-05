
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputTraceSpanVariant2
    {
        /// <summary>
        /// The operation type for this span.<br/>
        /// Default Value: output<br/>
        /// Example: output
        /// </summary>
        /// <default>"output"</default>
        /// <example>output</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; } = "output";

        /// <summary>
        /// The session event that produced this span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The span content. The response includes it only when the request sets include_content=true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Vectara.OutputSpanContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTraceSpanVariant2" /> class.
        /// </summary>
        /// <param name="operation">
        /// The operation type for this span.<br/>
        /// Default Value: output<br/>
        /// Example: output
        /// </param>
        /// <param name="eventId">
        /// The session event that produced this span.
        /// </param>
        /// <param name="content">
        /// The span content. The response includes it only when the request sets include_content=true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTraceSpanVariant2(
            string operation,
            string eventId,
            global::Vectara.OutputSpanContent? content)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTraceSpanVariant2" /> class.
        /// </summary>
        public OutputTraceSpanVariant2()
        {
        }

    }
}