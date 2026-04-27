
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTracesToolErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        DependencyFailed,
        /// <summary>
        /// 
        /// </summary>
        ExecutionError,
        /// <summary>
        /// 
        /// </summary>
        InvalidConfiguration,
        /// <summary>
        /// 
        /// </summary>
        InvalidInput,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTracesToolErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTracesToolErrorType value)
        {
            return value switch
            {
                ListTracesToolErrorType.DependencyFailed => "dependency_failed",
                ListTracesToolErrorType.ExecutionError => "execution_error",
                ListTracesToolErrorType.InvalidConfiguration => "invalid_configuration",
                ListTracesToolErrorType.InvalidInput => "invalid_input",
                ListTracesToolErrorType.NotFound => "not_found",
                ListTracesToolErrorType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTracesToolErrorType? ToEnum(string value)
        {
            return value switch
            {
                "dependency_failed" => ListTracesToolErrorType.DependencyFailed,
                "execution_error" => ListTracesToolErrorType.ExecutionError,
                "invalid_configuration" => ListTracesToolErrorType.InvalidConfiguration,
                "invalid_input" => ListTracesToolErrorType.InvalidInput,
                "not_found" => ListTracesToolErrorType.NotFound,
                "timeout" => ListTracesToolErrorType.Timeout,
                _ => null,
            };
        }
    }
}