
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The sender role in an A2A v1 message.
    /// </summary>
    public enum A2aV1Role
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
    public static class A2aV1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this A2aV1Role value)
        {
            return value switch
            {
                A2aV1Role.RoleAgent => "ROLE_AGENT",
                A2aV1Role.RoleUnspecified => "ROLE_UNSPECIFIED",
                A2aV1Role.RoleUser => "ROLE_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static A2aV1Role? ToEnum(string value)
        {
            return value switch
            {
                "ROLE_AGENT" => A2aV1Role.RoleAgent,
                "ROLE_UNSPECIFIED" => A2aV1Role.RoleUnspecified,
                "ROLE_USER" => A2aV1Role.RoleUser,
                _ => null,
            };
        }
    }
}