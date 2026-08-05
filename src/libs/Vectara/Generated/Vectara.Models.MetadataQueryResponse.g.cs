
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Document search results with relevance scores.
    /// </summary>
    public sealed partial class MetadataQueryResponse
    {
        /// <summary>
        /// The matched documents, ordered by relevance score from highest to lowest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::Vectara.ScoredDocument>? Documents { get; set; }

        /// <summary>
        /// The total number of matching documents. Use this value for pagination.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataQueryResponse" /> class.
        /// </summary>
        /// <param name="documents">
        /// The matched documents, ordered by relevance score from highest to lowest.
        /// </param>
        /// <param name="totalCount">
        /// The total number of matching documents. Use this value for pagination.<br/>
        /// Example: 42
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataQueryResponse(
            global::System.Collections.Generic.IList<global::Vectara.ScoredDocument>? documents,
            int? totalCount)
        {
            this.Documents = documents;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataQueryResponse" /> class.
        /// </summary>
        public MetadataQueryResponse()
        {
        }

    }
}