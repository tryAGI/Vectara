
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reranker that uses Maximal Marginal Relevance to balance relevance and diversity in search results.
    /// </summary>
    public sealed partial class MMRReranker
    {
        /// <summary>
        /// When the type is `mmr`, you can specify the `diversity_bias`. The search then uses the MMR reranker.<br/>
        /// Default Value: mmr
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The diversity bias. Higher values indicate more diversity.<br/>
        /// Example: 0.3
        /// </summary>
        /// <example>0.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("diversity_bias")]
        public float? DiversityBias { get; set; }

        /// <summary>
        /// The maximum number of results to return after the reranking process. <br/>
        /// When you apply a reranker, it performs these steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Sorts the reranked results by their new scores.<br/>
        /// 3. Returns the top N results, where N is the value of this limit.<br/>
        /// Note: This limit applies per reranking stage. In a chain of rerankers, each reranker can have its own limit. This can reduce the number of results at each stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The minimum score threshold for results to be included after the reranking process. When you apply a reranker with a cutoff, it performs these steps:<br/>
        /// 1. Reranks all input results according to its algorithm. 2. Removes any results with scores below the cutoff. 3. Returns the remaining results, sorted by their new scores.<br/>
        /// Note: This cutoff applies per reranking stage. In a chain of rerankers, each reranker can have its own cutoff. This can further reduce the number of results at each stage. If you specify both `limit` and `cutoff`, the cutoff applies first, then the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cutoff")]
        public float? Cutoff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MMRReranker" /> class.
        /// </summary>
        /// <param name="type">
        /// When the type is `mmr`, you can specify the `diversity_bias`. The search then uses the MMR reranker.<br/>
        /// Default Value: mmr
        /// </param>
        /// <param name="diversityBias">
        /// The diversity bias. Higher values indicate more diversity.<br/>
        /// Example: 0.3
        /// </param>
        /// <param name="limit">
        /// The maximum number of results to return after the reranking process. <br/>
        /// When you apply a reranker, it performs these steps:<br/>
        /// 1. Reranks all input results according to its algorithm.<br/>
        /// 2. Sorts the reranked results by their new scores.<br/>
        /// 3. Returns the top N results, where N is the value of this limit.<br/>
        /// Note: This limit applies per reranking stage. In a chain of rerankers, each reranker can have its own limit. This can reduce the number of results at each stage.
        /// </param>
        /// <param name="cutoff">
        /// The minimum score threshold for results to be included after the reranking process. When you apply a reranker with a cutoff, it performs these steps:<br/>
        /// 1. Reranks all input results according to its algorithm. 2. Removes any results with scores below the cutoff. 3. Returns the remaining results, sorted by their new scores.<br/>
        /// Note: This cutoff applies per reranking stage. In a chain of rerankers, each reranker can have its own cutoff. This can further reduce the number of results at each stage. If you specify both `limit` and `cutoff`, the cutoff applies first, then the limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MMRReranker(
            string? type,
            float? diversityBias,
            int? limit,
            float? cutoff)
        {
            this.Type = type;
            this.DiversityBias = diversityBias;
            this.Limit = limit;
            this.Cutoff = cutoff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MMRReranker" /> class.
        /// </summary>
        public MMRReranker()
        {
        }

    }
}