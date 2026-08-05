
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A placeholder reranker that does not modify the original search results ordering.
    /// </summary>
    public sealed partial class NoneReranker
    {
        /// <summary>
        /// When the type is `none`, the search applies no reranking.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The maximum number of results to return after the reranking process. When you apply a reranker, it performs these steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Sorts the reranked results by their new scores.<br/>
        /// 3. Returns the top N results, where N is the value of this limit.<br/>
        /// Note: This limit applies per reranking stage. In a chain of rerankers, each reranker can have its own limit. This can reduce the number of results at each stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoneReranker" /> class.
        /// </summary>
        /// <param name="type">
        /// When the type is `none`, the search applies no reranking.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="limit">
        /// The maximum number of results to return after the reranking process. When you apply a reranker, it performs these steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Sorts the reranked results by their new scores.<br/>
        /// 3. Returns the top N results, where N is the value of this limit.<br/>
        /// Note: This limit applies per reranking stage. In a chain of rerankers, each reranker can have its own limit. This can reduce the number of results at each stage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoneReranker(
            string? type,
            int? limit)
        {
            this.Type = type;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoneReranker" /> class.
        /// </summary>
        public NoneReranker()
        {
        }

    }
}