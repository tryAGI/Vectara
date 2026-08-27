
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The role assigned for this specific agent.<br/>
    /// * `agent_administrator` - Full administrative access to the agent including deletion and configuration.<br/>
    /// * `agent_viewer` - Read-only access to view agent configuration, sessions, events, instructions, and tools.<br/>
    /// * `agent_developer` - Can modify agent configuration, create/manage sessions, update tools and instructions.<br/>
    /// * `agent_user` - Limited access to interact with the agent by creating sessions and sending inputs. Cannot view agent configuration or modify settings.<br/>
    /// * `agent_end_user` - Granted on an alias, lets a user create sessions and send messages through it. They see only their own sessions, and within them only their own messages and the agent's replies. This must be the only role the user holds. The platform rejects assigning it alongside any other role.
    /// </summary>
    public enum AgentRoleRole
    {
        /// <summary>
        ///
        /// </summary>
        AgentAdministrator,
        /// <summary>
        ///
        /// </summary>
        AgentDeveloper,
        /// <summary>
        ///
        /// </summary>
        AgentEndUser,
        /// <summary>
        ///
        /// </summary>
        AgentUser,
        /// <summary>
        ///
        /// </summary>
        AgentViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRoleRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRoleRole value)
        {
            return value switch
            {
                AgentRoleRole.AgentAdministrator => "agent_administrator",
                AgentRoleRole.AgentDeveloper => "agent_developer",
                AgentRoleRole.AgentEndUser => "agent_end_user",
                AgentRoleRole.AgentUser => "agent_user",
                AgentRoleRole.AgentViewer => "agent_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRoleRole? ToEnum(string value)
        {
            return value switch
            {
                "agent_administrator" => AgentRoleRole.AgentAdministrator,
                "agent_developer" => AgentRoleRole.AgentDeveloper,
                "agent_end_user" => AgentRoleRole.AgentEndUser,
                "agent_user" => AgentRoleRole.AgentUser,
                "agent_viewer" => AgentRoleRole.AgentViewer,
                _ => null,
            };
        }
    }
}