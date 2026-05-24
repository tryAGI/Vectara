
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolActivityEventDiscriminatorActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        Generic,
        /// <summary>
        /// 
        /// </summary>
        SubAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolActivityEventDiscriminatorActivityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolActivityEventDiscriminatorActivityType value)
        {
            return value switch
            {
                ToolActivityEventDiscriminatorActivityType.Generic => "generic",
                ToolActivityEventDiscriminatorActivityType.SubAgent => "sub_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolActivityEventDiscriminatorActivityType? ToEnum(string value)
        {
            return value switch
            {
                "generic" => ToolActivityEventDiscriminatorActivityType.Generic,
                "sub_agent" => ToolActivityEventDiscriminatorActivityType.SubAgent,
                _ => null,
            };
        }
    }
}