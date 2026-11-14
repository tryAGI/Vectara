
#nullable enable

namespace Vectara
{
    /// <summary>
    /// What `amount` counts. New units may be added.<br/>
    /// Example: bytes
    /// </summary>
    public enum UsageUnit
    {
        /// <summary>
        ///
        /// </summary>
        Bytes,
        /// <summary>
        ///
        /// </summary>
        Count,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageUnit value)
        {
            return value switch
            {
                UsageUnit.Bytes => "bytes",
                UsageUnit.Count => "count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageUnit? ToEnum(string value)
        {
            return value switch
            {
                "bytes" => UsageUnit.Bytes,
                "count" => UsageUnit.Count,
                _ => null,
            };
        }
    }
}