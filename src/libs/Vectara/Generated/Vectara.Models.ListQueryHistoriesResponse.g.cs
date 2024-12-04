
#nullable enable

namespace Vectara
{
    /// <summary>
    /// An array of query histories.
    /// </summary>
    public sealed partial class ListQueryHistoriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<global::Vectara.QueryHistorySummary>? Queries { get; set; }

        /// <summary>
        /// The metadata for the list of query histories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Vectara.ListQueryHistoriesResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListQueryHistoriesResponse" /> class.
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="metadata">
        /// The metadata for the list of query histories.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListQueryHistoriesResponse(
            global::System.Collections.Generic.IList<global::Vectara.QueryHistorySummary>? queries,
            global::Vectara.ListQueryHistoriesResponseMetadata? metadata)
        {
            this.Queries = queries;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListQueryHistoriesResponse" /> class.
        /// </summary>
        public ListQueryHistoriesResponse()
        {
        }
    }
}