
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Agent-specific role assignment.
    /// </summary>
    public sealed partial class AgentRole
    {
        /// <summary>
        /// The ID of the agent this role applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The role assigned for this specific agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AgentRoleRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.AgentRoleRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRole" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent this role applies to.
        /// </param>
        /// <param name="role">
        /// The role assigned for this specific agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRole(
            string agentId,
            global::Vectara.AgentRoleRole role)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRole" /> class.
        /// </summary>
        public AgentRole()
        {
        }
    }
}