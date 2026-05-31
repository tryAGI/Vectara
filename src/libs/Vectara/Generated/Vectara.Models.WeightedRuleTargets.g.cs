
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Weighted selection among several agents. The `partition_by` userfn expression is evaluated and hashed; the result picks which `options` entry serves this session. Different rules in the same policy can declare different `partition_by` expressions (US rules canary by user_id, EU rules by tenant_id, etc.).
    /// </summary>
    public sealed partial class WeightedRuleTargets
    {
        /// <summary>
        /// Default Value: weighted
        /// </summary>
        /// <default>"weighted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "weighted";

        /// <summary>
        /// UserFn expression whose result is stringified and hashed to pick among `options`. Required: no implicit default.<br/>
        /// Uses the `get()` function with JSONPath to access the context.<br/>
        /// See https://docs.vectara.com/docs/search-and-retrieval/rerankers/user-defined-function-reranker for the UserFn language reference.<br/>
        /// Use `get('$.session.key')` for per-session canary, `get('$.session.metadata.user_id', '')` for per-user canary. If the expression evaluates to `null` at resolution time, the request is rejected with a 400; wrap optional fields with a default via `get('$.path', '')`.<br/>
        /// Example: get('$.session.metadata.user_id', '')
        /// </summary>
        /// <example>get('$.session.metadata.user_id', '')</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("partition_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartitionBy { get; set; }

        /// <summary>
        /// Weighted target options. One is selected by hashing the result of `partition_by`; weights are normalized at evaluation time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.WeightedTarget> Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightedRuleTargets" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: weighted
        /// </param>
        /// <param name="partitionBy">
        /// UserFn expression whose result is stringified and hashed to pick among `options`. Required: no implicit default.<br/>
        /// Uses the `get()` function with JSONPath to access the context.<br/>
        /// See https://docs.vectara.com/docs/search-and-retrieval/rerankers/user-defined-function-reranker for the UserFn language reference.<br/>
        /// Use `get('$.session.key')` for per-session canary, `get('$.session.metadata.user_id', '')` for per-user canary. If the expression evaluates to `null` at resolution time, the request is rejected with a 400; wrap optional fields with a default via `get('$.path', '')`.<br/>
        /// Example: get('$.session.metadata.user_id', '')
        /// </param>
        /// <param name="options">
        /// Weighted target options. One is selected by hashing the result of `partition_by`; weights are normalized at evaluation time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WeightedRuleTargets(
            string type,
            string partitionBy,
            global::System.Collections.Generic.IList<global::Vectara.WeightedTarget> options)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PartitionBy = partitionBy ?? throw new global::System.ArgumentNullException(nameof(partitionBy));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeightedRuleTargets" /> class.
        /// </summary>
        public WeightedRuleTargets()
        {
        }

    }
}