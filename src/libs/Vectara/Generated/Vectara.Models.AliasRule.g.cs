
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single routing rule consisting of an optional `match` expression and a `targets` shape. A rule with `match` omitted is a catch-all that always applies.
    /// </summary>
    public sealed partial class AliasRule
    {
        /// <summary>
        /// UserFn expression evaluating to boolean.<br/>
        /// Uses the `get()` function with JSONPath to access the context.<br/>
        /// See https://docs.vectara.com/docs/search-and-retrieval/rerankers/user-defined-function-reranker for the UserFn language reference.<br/>
        /// Omit for a catch-all rule.<br/>
        /// Missing paths return `null`; comparing against `null` is falsy, so the rule falls through to the next one in the policy. Use `get('$.path', default)` for an explicit fallback.<br/>
        /// Context shape — note that at resolution time the underlying agent has NOT been picked yet, so the `agent.*` fields reflect the *alias's* metadata (name, description, metadata), with the alias's URL key in `agent.key`. Use these for alias-level context (e.g. `$.agent.metadata.region`); use `session.*` for per-call routing inputs (tenant, user_id, etc.) which is what most rules dispatch on.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "agent":   { "name", "key", "description", "metadata": { ... } },   // alias's metadata at resolution time<br/>
        ///   "session": { "key", "name", "description", "metadata": { ... } },   // the session being created<br/>
        ///   "currentDate": "2026-01-15T10:35:00Z"<br/>
        /// }<br/>
        /// ```<br/>
        /// Examples:<br/>
        /// * `get('$.session.metadata.tenant') == 'us'`<br/>
        /// * `(get('$.session.metadata.tenant') == 'us') and (get('$.session.metadata.tier') == 'gold')`<br/>
        /// * `(get('$.session.metadata.region') == 'us-west') or (get('$.session.metadata.region') == 'us-east')`<br/>
        /// * `get('$.session.metadata.tier', 'free') != 'free'`<br/>
        /// Example: (get('$.session.metadata.tenant') == 'us') and (get('$.session.metadata.tier') == 'gold')
        /// </summary>
        /// <example>(get('$.session.metadata.tenant') == 'us') and (get('$.session.metadata.tier') == 'gold')</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public string? Match { get; set; }

        /// <summary>
        /// The shape of a rule's targets. The `type` discriminator selects which fields apply:<br/>
        /// * `single` — a direct route to one agent. No weight, no partition function.<br/>
        /// * `weighted` — a weighted selection among several agents. Requires a `partition_by` userfn expression naming what to hash on; different rules can use different partition functions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RuleTargetsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.RuleTargets Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasRule" /> class.
        /// </summary>
        /// <param name="targets">
        /// The shape of a rule's targets. The `type` discriminator selects which fields apply:<br/>
        /// * `single` — a direct route to one agent. No weight, no partition function.<br/>
        /// * `weighted` — a weighted selection among several agents. Requires a `partition_by` userfn expression naming what to hash on; different rules can use different partition functions.
        /// </param>
        /// <param name="match">
        /// UserFn expression evaluating to boolean.<br/>
        /// Uses the `get()` function with JSONPath to access the context.<br/>
        /// See https://docs.vectara.com/docs/search-and-retrieval/rerankers/user-defined-function-reranker for the UserFn language reference.<br/>
        /// Omit for a catch-all rule.<br/>
        /// Missing paths return `null`; comparing against `null` is falsy, so the rule falls through to the next one in the policy. Use `get('$.path', default)` for an explicit fallback.<br/>
        /// Context shape — note that at resolution time the underlying agent has NOT been picked yet, so the `agent.*` fields reflect the *alias's* metadata (name, description, metadata), with the alias's URL key in `agent.key`. Use these for alias-level context (e.g. `$.agent.metadata.region`); use `session.*` for per-call routing inputs (tenant, user_id, etc.) which is what most rules dispatch on.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "agent":   { "name", "key", "description", "metadata": { ... } },   // alias's metadata at resolution time<br/>
        ///   "session": { "key", "name", "description", "metadata": { ... } },   // the session being created<br/>
        ///   "currentDate": "2026-01-15T10:35:00Z"<br/>
        /// }<br/>
        /// ```<br/>
        /// Examples:<br/>
        /// * `get('$.session.metadata.tenant') == 'us'`<br/>
        /// * `(get('$.session.metadata.tenant') == 'us') and (get('$.session.metadata.tier') == 'gold')`<br/>
        /// * `(get('$.session.metadata.region') == 'us-west') or (get('$.session.metadata.region') == 'us-east')`<br/>
        /// * `get('$.session.metadata.tier', 'free') != 'free'`<br/>
        /// Example: (get('$.session.metadata.tenant') == 'us') and (get('$.session.metadata.tier') == 'gold')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasRule(
            global::Vectara.RuleTargets targets,
            string? match)
        {
            this.Match = match;
            this.Targets = targets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasRule" /> class.
        /// </summary>
        public AliasRule()
        {
        }

    }
}