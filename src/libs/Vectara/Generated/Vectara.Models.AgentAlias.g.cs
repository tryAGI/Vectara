
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A routing primitive that maps a public name to one or more agents under a configurable policy. When a session is created through an alias (via `POST /v2/agent_aliases/{alias_key}/sessions`), the alias's policy selects the underlying agent that runs the session.<br/>
    /// Use aliases for:<br/>
    /// - Canary rollouts — weighted routing between two agents.<br/>
    /// - Tenant routing — different agents for different customers, based on your tenant metadata.<br/>
    /// - A stable handle in front of agents whose configuration evolves.<br/>
    /// The resolved agent's session_enrichment applies to sessions created through the alias, after routing resolves. Routing runs before enrichment. Routing rules therefore read the request metadata, not enriched values. The resolved agent's `run_condition` is evaluated last, after its enrichment. When it evaluates to false no session is created and the request returns 409.<br/>
    /// Routing rules use userfn expressions. See the `AliasRule.match` field for the context shape and example expressions.
    /// </summary>
    public sealed partial class AgentAlias
    {
        /// <summary>
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </summary>
        /// <example>support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// A human-readable name for the alias.<br/>
        /// Example: Customer Support
        /// </summary>
        /// <example>Customer Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A longer description of what this alias represents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A routing policy. The `type` discriminator determines which fields apply:<br/>
        /// * `routed` — evaluates ordered rules. The policy selects the first rule whose `match` expression evaluates to true. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). A rule with omitted `match` is a catch-all that always matches. It must be the last rule. The platform rejects any rule placed after a catch-all as unreachable.<br/>
        /// Most use cases (direct, weighted/canary, conditional, conditional+canary) collapse into `routed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.RoutedAliasPolicy Policy { get; set; }

        /// <summary>
        /// Whether this alias is currently invocable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Timestamp when the alias was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the alias was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAlias" /> class.
        /// </summary>
        /// <param name="key">
        /// The unique key that identifies an alias. Alias keys are independent of agent keys. The same string can exist as both an alias key and an agent key in the same customer account. Calls to `/v2/agent_aliases/{key}/...` target the alias. Calls to `/v2/agents/{key}/...` target the agent.<br/>
        /// Example: support
        /// </param>
        /// <param name="name">
        /// A human-readable name for the alias.<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="policy">
        /// A routing policy. The `type` discriminator determines which fields apply:<br/>
        /// * `routed` — evaluates ordered rules. The policy selects the first rule whose `match` expression evaluates to true. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). A rule with omitted `match` is a catch-all that always matches. It must be the last rule. The platform rejects any rule placed after a catch-all as unreachable.<br/>
        /// Most use cases (direct, weighted/canary, conditional, conditional+canary) collapse into `routed`.
        /// </param>
        /// <param name="enabled">
        /// Whether this alias is currently invocable.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the alias was created.
        /// </param>
        /// <param name="description">
        /// A longer description of what this alias represents.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the alias.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the alias was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAlias(
            string key,
            string name,
            global::Vectara.RoutedAliasPolicy policy,
            bool enabled,
            global::System.DateTime createdAt,
            string? description,
            object? metadata,
            global::System.DateTime? updatedAt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Policy = policy ?? throw new global::System.ArgumentNullException(nameof(policy));
            this.Enabled = enabled;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAlias" /> class.
        /// </summary>
        public AgentAlias()
        {
        }

    }
}