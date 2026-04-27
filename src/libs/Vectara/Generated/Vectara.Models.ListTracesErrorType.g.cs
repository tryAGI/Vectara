
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTracesErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ActionsLimitReached,
        /// <summary>
        /// 
        /// </summary>
        ContextLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        LlmGenerationError,
        /// <summary>
        /// 
        /// </summary>
        StepTransitionLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        StreamError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTracesErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTracesErrorType value)
        {
            return value switch
            {
                ListTracesErrorType.ActionsLimitReached => "actions_limit_reached",
                ListTracesErrorType.ContextLimitExceeded => "context_limit_exceeded",
                ListTracesErrorType.Internal => "internal",
                ListTracesErrorType.LlmGenerationError => "llm_generation_error",
                ListTracesErrorType.StepTransitionLimitExceeded => "step_transition_limit_exceeded",
                ListTracesErrorType.StreamError => "stream_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTracesErrorType? ToEnum(string value)
        {
            return value switch
            {
                "actions_limit_reached" => ListTracesErrorType.ActionsLimitReached,
                "context_limit_exceeded" => ListTracesErrorType.ContextLimitExceeded,
                "internal" => ListTracesErrorType.Internal,
                "llm_generation_error" => ListTracesErrorType.LlmGenerationError,
                "step_transition_limit_exceeded" => ListTracesErrorType.StepTransitionLimitExceeded,
                "stream_error" => ListTracesErrorType.StreamError,
                _ => null,
            };
        }
    }
}