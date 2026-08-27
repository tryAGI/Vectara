
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The LLM provider type, identifying which authentication and configuration apply. New values may be added as providers are onboarded; clients should ignore values they do not recognize rather than fail.<br/>
    /// Example: openai-compatible
    /// </summary>
    public enum LLMType
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        OpenaiCompatible,
        /// <summary>
        ///
        /// </summary>
        OpenaiResponses,
        /// <summary>
        ///
        /// </summary>
        VertexAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMType value)
        {
            return value switch
            {
                LLMType.Anthropic => "anthropic",
                LLMType.OpenaiCompatible => "openai-compatible",
                LLMType.OpenaiResponses => "openai-responses",
                LLMType.VertexAi => "vertex-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => LLMType.Anthropic,
                "openai-compatible" => LLMType.OpenaiCompatible,
                "openai-responses" => LLMType.OpenaiResponses,
                "vertex-ai" => LLMType.VertexAi,
                _ => null,
            };
        }
    }
}