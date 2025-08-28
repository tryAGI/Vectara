
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The role assigned for this specific agent.
    /// </summary>
    public enum AgentRoleRole
    {
        /// <summary>
        /// 
        /// </summary>
        AgentAdmin,
        /// <summary>
        /// 
        /// </summary>
        AgentViewer,
        /// <summary>
        /// 
        /// </summary>
        AgentDeveloper,
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
                AgentRoleRole.AgentAdmin => "agent_admin",
                AgentRoleRole.AgentViewer => "agent_viewer",
                AgentRoleRole.AgentDeveloper => "agent_developer",
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
                "agent_admin" => AgentRoleRole.AgentAdmin,
                "agent_viewer" => AgentRoleRole.AgentViewer,
                "agent_developer" => AgentRoleRole.AgentDeveloper,
                _ => null,
            };
        }
    }
}