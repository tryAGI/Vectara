
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum RuleTargetsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Single,
        /// <summary>
        /// 
        /// </summary>
        Weighted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleTargetsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleTargetsDiscriminatorType value)
        {
            return value switch
            {
                RuleTargetsDiscriminatorType.Single => "single",
                RuleTargetsDiscriminatorType.Weighted => "weighted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleTargetsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "single" => RuleTargetsDiscriminatorType.Single,
                "weighted" => RuleTargetsDiscriminatorType.Weighted,
                _ => null,
            };
        }
    }
}