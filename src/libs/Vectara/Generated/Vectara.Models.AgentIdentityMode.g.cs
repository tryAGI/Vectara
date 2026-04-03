
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The role management mode of the agent's identity.<br/>
    /// - `auto`: The platform keeps roles in sync with the agent's tool configuration. When tools change, roles are automatically recomputed.<br/>
    /// - `manual`: Roles are user-managed. The platform will not modify roles when the agent is updated.<br/>
    /// Example: auto
    /// </summary>
    public enum AgentIdentityMode
    {
        /// <summary>
        /// The platform keeps roles in sync with the agent's tool configuration. When tools change, roles are automatically recomputed.
        /// </summary>
        Auto,
        /// <summary>
        /// Roles are user-managed. The platform will not modify roles when the agent is updated.
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentIdentityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentIdentityMode value)
        {
            return value switch
            {
                AgentIdentityMode.Auto => "auto",
                AgentIdentityMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentIdentityMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AgentIdentityMode.Auto,
                "manual" => AgentIdentityMode.Manual,
                _ => null,
            };
        }
    }
}