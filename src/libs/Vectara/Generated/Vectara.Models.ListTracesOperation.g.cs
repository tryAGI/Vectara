
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTracesOperation
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
    public static class ListTracesOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTracesOperation value)
        {
            return value switch
            {
                ListTracesOperation.Chat => "chat",
                ListTracesOperation.Compaction => "compaction",
                ListTracesOperation.ExecuteTool => "execute_tool",
                ListTracesOperation.Guardrail => "guardrail",
                ListTracesOperation.ImageRead => "image_read",
                ListTracesOperation.InvokeAgent => "invoke_agent",
                ListTracesOperation.Output => "output",
                ListTracesOperation.StepTransition => "step_transition",
                ListTracesOperation.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTracesOperation? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ListTracesOperation.Chat,
                "compaction" => ListTracesOperation.Compaction,
                "execute_tool" => ListTracesOperation.ExecuteTool,
                "guardrail" => ListTracesOperation.Guardrail,
                "image_read" => ListTracesOperation.ImageRead,
                "invoke_agent" => ListTracesOperation.InvokeAgent,
                "output" => ListTracesOperation.Output,
                "step_transition" => ListTracesOperation.StepTransition,
                "thinking" => ListTracesOperation.Thinking,
                _ => null,
            };
        }
    }
}