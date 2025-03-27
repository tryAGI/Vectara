
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A complete record of a previously executed query, including the request parameters and response.
    /// </summary>
    public sealed partial class QueryHistory
    {
        /// <summary>
        /// The ID of the query history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Query one or more corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::Vectara.QueryRequest? Query { get; set; }

        /// <summary>
        /// The ID of the chat the query is a part of.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Time taken to complete the query, measured in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// ISO date time indicating when the query was first received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Parts of the query pipeline. Each span explains what happened during that stage of the query pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Vectara.QueryHistorySpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistory" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the query history.
        /// </param>
        /// <param name="query">
        /// Query one or more corpora.
        /// </param>
        /// <param name="chatId">
        /// The ID of the chat the query is a part of.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken to complete the query, measured in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// ISO date time indicating when the query was first received.
        /// </param>
        /// <param name="spans">
        /// Parts of the query pipeline. Each span explains what happened during that stage of the query pipeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryHistory(
            string? id,
            global::Vectara.QueryRequest? query,
            string? chatId,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            global::System.Collections.Generic.IList<global::Vectara.QueryHistorySpan>? spans)
        {
            this.Id = id;
            this.Query = query;
            this.ChatId = chatId;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryHistory" /> class.
        /// </summary>
        public QueryHistory()
        {
        }
    }
}