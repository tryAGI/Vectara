
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTraceSpansOperation
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
    public static class ListTraceSpansOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTraceSpansOperation value)
        {
            return value switch
            {
                ListTraceSpansOperation.Chat => "chat",
                ListTraceSpansOperation.Compaction => "compaction",
                ListTraceSpansOperation.ExecuteTool => "execute_tool",
                ListTraceSpansOperation.Guardrail => "guardrail",
                ListTraceSpansOperation.ImageRead => "image_read",
                ListTraceSpansOperation.InvokeAgent => "invoke_agent",
                ListTraceSpansOperation.Output => "output",
                ListTraceSpansOperation.StepTransition => "step_transition",
                ListTraceSpansOperation.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTraceSpansOperation? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ListTraceSpansOperation.Chat,
                "compaction" => ListTraceSpansOperation.Compaction,
                "execute_tool" => ListTraceSpansOperation.ExecuteTool,
                "guardrail" => ListTraceSpansOperation.Guardrail,
                "image_read" => ListTraceSpansOperation.ImageRead,
                "invoke_agent" => ListTraceSpansOperation.InvokeAgent,
                "output" => ListTraceSpansOperation.Output,
                "step_transition" => ListTraceSpansOperation.StepTransition,
                "thinking" => ListTraceSpansOperation.Thinking,
                _ => null,
            };
        }
    }
}