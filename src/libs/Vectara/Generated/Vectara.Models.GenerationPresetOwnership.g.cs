
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Indicates whether the generation preset is provided by the platform or created by the customer. Platform presets are pre-configured and cannot be modified or deleted. Customer presets are created and managed by the customer.<br/>
    /// Example: platform
    /// </summary>
    public enum GenerationPresetOwnership
    {
        /// <summary>
        /// 
        /// </summary>
        Customer,
        /// <summary>
        /// 
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationPresetOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationPresetOwnership value)
        {
            return value switch
            {
                GenerationPresetOwnership.Customer => "customer",
                GenerationPresetOwnership.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationPresetOwnership? ToEnum(string value)
        {
            return value switch
            {
                "customer" => GenerationPresetOwnership.Customer,
                "platform" => GenerationPresetOwnership.Platform,
                _ => null,
            };
        }
    }
}