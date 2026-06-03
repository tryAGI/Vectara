
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request body for atomically replacing an alias's routing policy. The policy is replaced as a unit; partial updates aren't supported.
    /// </summary>
    public sealed partial class ReplaceAliasPolicyRequest
    {
        /// <summary>
        /// A routing policy. The `type` discriminator determines which fields apply:<br/>
        /// * `routed` — evaluate ordered rules; the first rule whose `match` expression evaluates to true is selected. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). Rules with omitted `match` are catch-all rules (typically last).<br/>
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
        /// * `routed` — evaluate ordered rules; the first rule whose `match` expression evaluates to true is selected. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). Rules with omitted `match` are catch-all rules (typically last).<br/>
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