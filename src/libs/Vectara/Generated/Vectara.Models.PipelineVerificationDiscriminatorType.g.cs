
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineVerificationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Condition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineVerificationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineVerificationDiscriminatorType value)
        {
            return value switch
            {
                PipelineVerificationDiscriminatorType.Agent => "agent",
                PipelineVerificationDiscriminatorType.Condition => "condition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineVerificationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PipelineVerificationDiscriminatorType.Agent,
                "condition" => PipelineVerificationDiscriminatorType.Condition,
                _ => null,
            };
        }
    }
}