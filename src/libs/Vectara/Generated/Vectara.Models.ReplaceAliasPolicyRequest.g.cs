
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request body for replacing an alias's routing policy in one atomic operation. The policy is replaced as a unit. Partial updates are not supported.
    /// </summary>
    public sealed partial class ReplaceAliasPolicyRequest
    {
        /// <summary>
        /// A routing policy. The `type` discriminator determines which fields apply:<br/>
        /// * `routed` — evaluates ordered rules. The policy selects the first rule whose `match` expression evaluates to true. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). A rule with omitted `match` is a catch-all that always matches. It must be the last rule. The platform rejects any rule placed after a catch-all as unreachable.<br/>
        /// Most use cases (direct, weighted/canary, conditional, conditional+canary) collapse into `routed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.RoutedAliasPolicy Policy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAliasPolicyRequest" /> class.
        /// </summary>
        /// <param name="policy">
        /// A routing policy. The `type` discriminator determines which fields apply:<br/>
        /// * `routed` — evaluates ordered rules. The policy selects the first rule whose `match` expression evaluates to true. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). A rule with omitted `match` is a catch-all that always matches. It must be the last rule. The platform rejects any rule placed after a catch-all as unreachable.<br/>
        /// Most use cases (direct, weighted/canary, conditional, conditional+canary) collapse into `routed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceAliasPolicyRequest(
            global::Vectara.RoutedAliasPolicy policy)
        {
            this.Policy = policy ?? throw new global::System.ArgumentNullException(nameof(policy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAliasPolicyRequest" /> class.
        /// </summary>
        public ReplaceAliasPolicyRequest()
        {
        }

    }
}