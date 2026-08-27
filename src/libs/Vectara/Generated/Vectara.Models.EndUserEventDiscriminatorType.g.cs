
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum EndUserEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AgentOutput,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        InputMessage,
        /// <summary>
        ///
        /// </summary>
        StructuredOutput,
        /// <summary>
        ///
        /// </summary>
        Thinking,
        /// <summary>
        ///
        /// </summary>
        ToolInput,
        /// <summary>
        ///
        /// </summary>
        ToolOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndUserEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserEventDiscriminatorType value)
        {
            return value switch
            {
                EndUserEventDiscriminatorType.AgentOutput => "agent_output",
                EndUserEventDiscriminatorType.Error => "error",
                EndUserEventDiscriminatorType.InputMessage => "input_message",
                EndUserEventDiscriminatorType.StructuredOutput => "structured_output",
                EndUserEventDiscriminatorType.Thinking => "thinking",
                EndUserEventDiscriminatorType.ToolInput => "tool_input",
                EndUserEventDiscriminatorType.ToolOutput => "tool_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_output" => EndUserEventDiscriminatorType.AgentOutput,
                "error" => EndUserEventDiscriminatorType.Error,
                "input_message" => EndUserEventDiscriminatorType.InputMessage,
                "structured_output" => EndUserEventDiscriminatorType.StructuredOutput,
                "thinking" => EndUserEventDiscriminatorType.Thinking,
                "tool_input" => EndUserEventDiscriminatorType.ToolInput,
                "tool_output" => EndUserEventDiscriminatorType.ToolOutput,
                _ => null,
            };
        }
    }
}