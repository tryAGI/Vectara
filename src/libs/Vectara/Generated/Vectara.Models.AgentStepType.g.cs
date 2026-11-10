
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How a step acts on its input. New values may be added; clients should ignore values they do not recognize.<br/>
    /// - `conversational`: the step runs its tool_calls, then the LLM acts on the input following the step's instructions.<br/>
    /// - `tool_calls`: the step runs its tool_calls and nothing else. The LLM is not called. The step must set instructions to an<br/>
    ///   empty list and use the default output_parser, and must not set reminders or allowed_skills.<br/>
    ///   A step with no tool_calls goes straight to its next_steps.<br/>
    /// Example: conversational
    /// </summary>
    public enum AgentStepType
    {
        /// <summary>
        /// the step runs its tool_calls, then the LLM acts on the input following the step's instructions.
        /// </summary>
        Conversational,
        /// <summary>
        /// the step runs its tool_calls, then the LLM acts on the input following the step's instructions.
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStepType value)
        {
            return value switch
            {
                AgentStepType.Conversational => "conversational",
                AgentStepType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStepType? ToEnum(string value)
        {
            return value switch
            {
                "conversational" => AgentStepType.Conversational,
                "tool_calls" => AgentStepType.ToolCalls,
                _ => null,
            };
        }
    }
}