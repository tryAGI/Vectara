
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The requested output format of the agent invocation.
    /// </summary>
    public enum InvokeAgentSpanAttributesOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvokeAgentSpanAttributesOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvokeAgentSpanAttributesOutputType value)
        {
            return value switch
            {
                InvokeAgentSpanAttributesOutputType.Json => "json",
                InvokeAgentSpanAttributesOutputType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvokeAgentSpanAttributesOutputType? ToEnum(string value)
        {
            return value switch
            {
                "json" => InvokeAgentSpanAttributesOutputType.Json,
                "text" => InvokeAgentSpanAttributesOutputType.Text,
                _ => null,
            };
        }
    }
}