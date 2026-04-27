
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentTraceSpanDiscriminatorOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        ExecuteTool,
        /// <summary>
        /// 
        /// </summary>
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        InvokeAgent,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        StepTransition,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTraceSpanDiscriminatorOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTraceSpanDiscriminatorOperation value)
        {
            return value switch
            {
                AgentTraceSpanDiscriminatorOperation.Chat => "chat",
                AgentTraceSpanDiscriminatorOperation.Compaction => "compaction",
                AgentTraceSpanDiscriminatorOperation.ExecuteTool => "execute_tool",
                AgentTraceSpanDiscriminatorOperation.Guardrail => "guardrail",
                AgentTraceSpanDiscriminatorOperation.ImageRead => "image_read",
                AgentTraceSpanDiscriminatorOperation.InvokeAgent => "invoke_agent",
                AgentTraceSpanDiscriminatorOperation.Output => "output",
                AgentTraceSpanDiscriminatorOperation.StepTransition => "step_transition",
                AgentTraceSpanDiscriminatorOperation.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTraceSpanDiscriminatorOperation? ToEnum(string value)
        {
            return value switch
            {
                "chat" => AgentTraceSpanDiscriminatorOperation.Chat,
                "compaction" => AgentTraceSpanDiscriminatorOperation.Compaction,
                "execute_tool" => AgentTraceSpanDiscriminatorOperation.ExecuteTool,
                "guardrail" => AgentTraceSpanDiscriminatorOperation.Guardrail,
                "image_read" => AgentTraceSpanDiscriminatorOperation.ImageRead,
                "invoke_agent" => AgentTraceSpanDiscriminatorOperation.InvokeAgent,
                "output" => AgentTraceSpanDiscriminatorOperation.Output,
                "step_transition" => AgentTraceSpanDiscriminatorOperation.StepTransition,
                "thinking" => AgentTraceSpanDiscriminatorOperation.Thinking,
                _ => null,
            };
        }
    }
}