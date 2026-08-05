
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEndUserInputRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        Interrupt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEndUserInputRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEndUserInputRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateEndUserInputRequestDiscriminatorType.InputMessage => "input_message",
                CreateEndUserInputRequestDiscriminatorType.Interrupt => "interrupt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEndUserInputRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_message" => CreateEndUserInputRequestDiscriminatorType.InputMessage,
                "interrupt" => CreateEndUserInputRequestDiscriminatorType.Interrupt,
                _ => null,
            };
        }
    }
}