
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response containing a session's events, projected to the caller's end-user visibility.
    /// </summary>
    public sealed partial class ListEndUserEventsResponse
    {
        /// <summary>
        /// The session's visible events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.EndUserEvent> Events { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ListMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndUserEventsResponse" /> class.
        /// </summary>
        /// <param name="events">
        /// The session's visible events.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndUserEventsResponse(
            global::System.Collections.Generic.IList<global::Vectara.EndUserEvent> events,
            global::Vectara.ListMetadata metadata)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndUserEventsResponse" /> class.
        /// </summary>
        public ListEndUserEventsResponse()
        {
        }

    }
}