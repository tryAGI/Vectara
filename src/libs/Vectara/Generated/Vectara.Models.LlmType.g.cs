
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The provider type. It determines which authentication and configuration apply. Responses always include this field. If a stored LLM cannot be mapped to one of these values, the request fails with HTTP 500.
    /// </summary>
    public enum LlmType
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
    public static class LlmTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmType value)
        {
            return value switch
            {
                LlmType.Anthropic => "anthropic",
                LlmType.OpenaiCompatible => "openai-compatible",
                LlmType.OpenaiResponses => "openai-responses",
                LlmType.VertexAi => "vertex-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => LlmType.Anthropic,
                "openai-compatible" => LlmType.OpenaiCompatible,
                "openai-responses" => LlmType.OpenaiResponses,
                "vertex-ai" => LlmType.VertexAi,
                _ => null,
            };
        }
    }
}