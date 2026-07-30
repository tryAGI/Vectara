
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The sender role in an A2A v0.3 message.
    /// </summary>
    public enum A2aV03Role
    {
        /// <summary>
        /// 
        /// </summary>
        RoleAgent,
        /// <summary>
        /// 
        /// </summary>
        RoleUnspecified,
        /// <summary>
        /// 
        /// </summary>
        RoleUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class A2aV03RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this A2aV03Role value)
        {
            return value switch
            {
                A2aV03Role.RoleAgent => "ROLE_AGENT",
                A2aV03Role.RoleUnspecified => "ROLE_UNSPECIFIED",
                A2aV03Role.RoleUser => "ROLE_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static A2aV03Role? ToEnum(string value)
        {
            return value switch
            {
                "ROLE_AGENT" => A2aV03Role.RoleAgent,
                "ROLE_UNSPECIFIED" => A2aV03Role.RoleUnspecified,
                "ROLE_USER" => A2aV03Role.RoleUser,
                _ => null,
            };
        }
    }
}