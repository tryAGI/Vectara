
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Operator used for the upper bound when filtering articles by when they were last updated.<br/>
    /// `lt` is strict less-than and `lte` is less-than-or-equal.<br/>
    /// Default Value: lte
    /// </summary>
    public enum BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseWolkenKbSourceConfigurationUpdateUpperBoundOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator value)
        {
            return value switch
            {
                BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator.Lt => "lt",
                BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator.Lte => "lte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator? ToEnum(string value)
        {
            return value switch
            {
                "lt" => BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator.Lt,
                "lte" => BaseWolkenKbSourceConfigurationUpdateUpperBoundOperator.Lte,
                _ => null,
            };
        }
    }
}