
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reranker that uses user-defined functions to reorder search results.
    /// </summary>
    public sealed partial class UserFunctionReranker
    {
        /// <summary>
        /// When the type is `userfn`, you can define custom reranking functions using document-level metadata, part-level metadata, or scores generated from the request-level metadata.<br/>
        /// Default Value: userfn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The user defined function.<br/>
        /// Example: get('$.score') * get('$.document_metadata.boost')
        /// </summary>
        /// <example>get('$.score') * get('$.document_metadata.boost')</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_function")]
        public string? UserFunction { get; set; }

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
        /// Initializes a new instance of the <see cref="UserFunctionReranker" /> class.
        /// </summary>
        /// <param name="type">
        /// When the type is `userfn`, you can define custom reranking functions using document-level metadata, part-level metadata, or scores generated from the request-level metadata.<br/>
        /// Default Value: userfn
        /// </param>
        /// <param name="userFunction">
        /// The user defined function.<br/>
        /// Example: get('$.score') * get('$.document_metadata.boost')
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
        public UserFunctionReranker(
            string? type,
            string? userFunction,
            int? limit,
            float? cutoff)
        {
            this.Type = type;
            this.UserFunction = userFunction;
            this.Limit = limit;
            this.Cutoff = cutoff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFunctionReranker" /> class.
        /// </summary>
        public UserFunctionReranker()
        {
        }

    }
}