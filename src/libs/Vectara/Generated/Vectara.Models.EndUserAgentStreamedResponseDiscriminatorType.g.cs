
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public enum EndUserAgentStreamedResponseDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AgentOutput,
        /// <summary>
        ///
        /// </summary>
        End,
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
        StreamingAgentOutput,
        /// <summary>
        ///
        /// </summary>
        StreamingAgentOutputEnd,
        /// <summary>
        ///
        /// </summary>
        StreamingThinking,
        /// <summary>
        ///
        /// </summary>
        StreamingThinkingEnd,
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
        ToolActivity,
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
    public static class EndUserAgentStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserAgentStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                EndUserAgentStreamedResponseDiscriminatorType.AgentOutput => "agent_output",
                EndUserAgentStreamedResponseDiscriminatorType.End => "end",
                EndUserAgentStreamedResponseDiscriminatorType.Error => "error",
                EndUserAgentStreamedResponseDiscriminatorType.InputMessage => "input_message",
                EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutput => "streaming_agent_output",
                EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd => "streaming_agent_output_end",
                EndUserAgentStreamedResponseDiscriminatorType.StreamingThinking => "streaming_thinking",
                EndUserAgentStreamedResponseDiscriminatorType.StreamingThinkingEnd => "streaming_thinking_end",
                EndUserAgentStreamedResponseDiscriminatorType.StructuredOutput => "structured_output",
                EndUserAgentStreamedResponseDiscriminatorType.Thinking => "thinking",
                EndUserAgentStreamedResponseDiscriminatorType.ToolActivity => "tool_activity",
                EndUserAgentStreamedResponseDiscriminatorType.ToolInput => "tool_input",
                EndUserAgentStreamedResponseDiscriminatorType.ToolOutput => "tool_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserAgentStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_output" => EndUserAgentStreamedResponseDiscriminatorType.AgentOutput,
                "end" => EndUserAgentStreamedResponseDiscriminatorType.End,
                "error" => EndUserAgentStreamedResponseDiscriminatorType.Error,
                "input_message" => EndUserAgentStreamedResponseDiscriminatorType.InputMessage,
                "streaming_agent_output" => EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutput,
                "streaming_agent_output_end" => EndUserAgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd,
                "streaming_thinking" => EndUserAgentStreamedResponseDiscriminatorType.StreamingThinking,
                "streaming_thinking_end" => EndUserAgentStreamedResponseDiscriminatorType.StreamingThinkingEnd,
                "structured_output" => EndUserAgentStreamedResponseDiscriminatorType.StructuredOutput,
                "thinking" => EndUserAgentStreamedResponseDiscriminatorType.Thinking,
                "tool_activity" => EndUserAgentStreamedResponseDiscriminatorType.ToolActivity,
                "tool_input" => EndUserAgentStreamedResponseDiscriminatorType.ToolInput,
                "tool_output" => EndUserAgentStreamedResponseDiscriminatorType.ToolOutput,
                _ => null,
            };
        }
    }
}