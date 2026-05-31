
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum AliasPolicyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Routed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AliasPolicyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AliasPolicyDiscriminatorType value)
        {
            return value switch
            {
                AliasPolicyDiscriminatorType.Routed => "routed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AliasPolicyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "routed" => AliasPolicyDiscriminatorType.Routed,
                _ => null,
            };
        }
    }
}