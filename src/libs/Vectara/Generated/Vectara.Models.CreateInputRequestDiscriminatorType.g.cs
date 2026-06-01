
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateInputRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Compact,
        /// <summary>
        /// 
        /// </summary>
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        Interrupt,
        /// <summary>
        /// 
        /// </summary>
        ToolOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateInputRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInputRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateInputRequestDiscriminatorType.Compact => "compact",
                CreateInputRequestDiscriminatorType.InputMessage => "input_message",
                CreateInputRequestDiscriminatorType.Interrupt => "interrupt",
                CreateInputRequestDiscriminatorType.ToolOutput => "tool_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInputRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "compact" => CreateInputRequestDiscriminatorType.Compact,
                "input_message" => CreateInputRequestDiscriminatorType.InputMessage,
                "interrupt" => CreateInputRequestDiscriminatorType.Interrupt,
                "tool_output" => CreateInputRequestDiscriminatorType.ToolOutput,
                _ => null,
            };
        }
    }
}