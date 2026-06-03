
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Evaluates ordered rules against the session context. The first rule whose `match` expression evaluates to true is selected. The selected rule's `targets` shape determines what runs: `single` routes directly to one agent, `weighted` picks one of several agents by hashing the rule's `partition_by` expression. A rule with no `match` always matches (catch-all). It must be the last rule; any rule placed after it is rejected as unreachable.<br/>
    /// This single shape covers direct routing (one rule, single target), weighted/canary rollouts (one rule, weighted targets), conditional routing (multiple rules with matches), and conditional+canary combinations (multiple rules, each independently single or weighted).
    /// </summary>
    public sealed partial class RoutedAliasPolicy
    {
        /// <summary>
        /// Default Value: routed
        /// </summary>
        /// <default>"routed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "routed";

        /// <summary>
        /// Ordered routing rules. Evaluated top-to-bottom; the first rule whose match expression evaluates to true is selected. At least one rule with no `match` (a catch-all) is recommended to guarantee a fallback target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.AliasRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutedAliasPolicy" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: routed
        /// </param>
        /// <param name="rules">
        /// Ordered routing rules. Evaluated top-to-bottom; the first rule whose match expression evaluates to true is selected. At least one rule with no `match` (a catch-all) is recommended to guarantee a fallback target.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutedAliasPolicy(
            string type,
            global::System.Collections.Generic.IList<global::Vectara.AliasRule> rules)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutedAliasPolicy" /> class.
        /// </summary>
        public RoutedAliasPolicy()
        {
        }

    }
}