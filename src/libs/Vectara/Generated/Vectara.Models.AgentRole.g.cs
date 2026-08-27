
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Agent-specific role assignment.
    /// </summary>
    public sealed partial class AgentRole
    {
        /// <summary>
        /// The key of the agent this role applies to. For the `agent_end_user` role this is an agent alias key, which shares the same shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// The role assigned for this specific agent.<br/>
        /// * `agent_administrator` - Full administrative access to the agent including deletion and configuration.<br/>
        /// * `agent_viewer` - Read-only access to view agent configuration, sessions, events, instructions, and tools.<br/>
        /// * `agent_developer` - Can modify agent configuration, create/manage sessions, update tools and instructions.<br/>
        /// * `agent_user` - Limited access to interact with the agent by creating sessions and sending inputs. Cannot view agent configuration or modify settings.<br/>
        /// * `agent_end_user` - Granted on an alias, lets a user create sessions and send messages through it. They see only their own sessions, and within them only their own messages and the agent's replies. This must be the only role the user holds. The platform rejects assigning it alongside any other role.
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
        /// <param name="agentKey">
        /// The key of the agent this role applies to. For the `agent_end_user` role this is an agent alias key, which shares the same shape.
        /// </param>
        /// <param name="role">
        /// The role assigned for this specific agent.<br/>
        /// * `agent_administrator` - Full administrative access to the agent including deletion and configuration.<br/>
        /// * `agent_viewer` - Read-only access to view agent configuration, sessions, events, instructions, and tools.<br/>
        /// * `agent_developer` - Can modify agent configuration, create/manage sessions, update tools and instructions.<br/>
        /// * `agent_user` - Limited access to interact with the agent by creating sessions and sending inputs. Cannot view agent configuration or modify settings.<br/>
        /// * `agent_end_user` - Granted on an alias, lets a user create sessions and send messages through it. They see only their own sessions, and within them only their own messages and the agent's replies. This must be the only role the user holds. The platform rejects assigning it alongside any other role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRole(
            string agentKey,
            global::Vectara.AgentRoleRole role)
        {
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
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