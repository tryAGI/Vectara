
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by client tool output submissions.
    /// </summary>
    public sealed partial class CreateToolOutputBase
    {
        /// <summary>
        /// The `tool_input` event this output responds to.<br/>
        /// Example: aev_3Kx9QpVn2mZr8YbLc5TdWe
        /// </summary>
        /// <example>aev_3Kx9QpVn2mZr8YbLc5TdWe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolOutputBase" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The `tool_input` event this output responds to.<br/>
        /// Example: aev_3Kx9QpVn2mZr8YbLc5TdWe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolOutputBase(
            string eventId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolOutputBase" /> class.
        /// </summary>
        public CreateToolOutputBase()
        {
        }

    }
}