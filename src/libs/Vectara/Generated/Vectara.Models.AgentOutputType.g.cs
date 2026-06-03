
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A category of intermediate agent output a connector can hide from its channel via `hidden_output_types`. `tool_calls` is the agent's tool-call activity, `thinking` is the model's reasoning output, and `structured_output` is structured (JSON) payloads emitted by the agent. The final response is never one of these and is always posted.<br/>
    /// Example: tool_calls
    /// </summary>
    public enum AgentOutputType
    {
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
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOutputType value)
        {
            return value switch
            {
                AgentOutputType.StructuredOutput => "structured_output",
                AgentOutputType.Thinking => "thinking",
                AgentOutputType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOutputType? ToEnum(string value)
        {
            return value switch
            {
                "structured_output" => AgentOutputType.StructuredOutput,
                "thinking" => AgentOutputType.Thinking,
                "tool_calls" => AgentOutputType.ToolCalls,
                _ => null,
            };
        }
    }
}