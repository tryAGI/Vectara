
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum StepToolCallOnFailureDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Continue,
        /// <summary>
        ///
        /// </summary>
        EndTurn,
        /// <summary>
        ///
        /// </summary>
        NextStep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepToolCallOnFailureDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepToolCallOnFailureDiscriminatorType value)
        {
            return value switch
            {
                StepToolCallOnFailureDiscriminatorType.Continue => "continue",
                StepToolCallOnFailureDiscriminatorType.EndTurn => "end_turn",
                StepToolCallOnFailureDiscriminatorType.NextStep => "next_step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepToolCallOnFailureDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "continue" => StepToolCallOnFailureDiscriminatorType.Continue,
                "end_turn" => StepToolCallOnFailureDiscriminatorType.EndTurn,
                "next_step" => StepToolCallOnFailureDiscriminatorType.NextStep,
                _ => null,
            };
        }
    }
}