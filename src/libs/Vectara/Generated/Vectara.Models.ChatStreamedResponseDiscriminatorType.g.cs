
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatInfo,
        /// <summary>
        /// 
        /// </summary>
        End,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        FactualConsistencyScore,
        /// <summary>
        /// 
        /// </summary>
        GenerationChunk,
        /// <summary>
        /// 
        /// </summary>
        GenerationEnd,
        /// <summary>
        /// 
        /// </summary>
        GenerationInfo,
        /// <summary>
        /// 
        /// </summary>
        SearchResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                ChatStreamedResponseDiscriminatorType.ChatInfo => "chat_info",
                ChatStreamedResponseDiscriminatorType.End => "end",
                ChatStreamedResponseDiscriminatorType.Error => "error",
                ChatStreamedResponseDiscriminatorType.FactualConsistencyScore => "factual_consistency_score",
                ChatStreamedResponseDiscriminatorType.GenerationChunk => "generation_chunk",
                ChatStreamedResponseDiscriminatorType.GenerationEnd => "generation_end",
                ChatStreamedResponseDiscriminatorType.GenerationInfo => "generation_info",
                ChatStreamedResponseDiscriminatorType.SearchResults => "search_results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chat_info" => ChatStreamedResponseDiscriminatorType.ChatInfo,
                "end" => ChatStreamedResponseDiscriminatorType.End,
                "error" => ChatStreamedResponseDiscriminatorType.Error,
                "factual_consistency_score" => ChatStreamedResponseDiscriminatorType.FactualConsistencyScore,
                "generation_chunk" => ChatStreamedResponseDiscriminatorType.GenerationChunk,
                "generation_end" => ChatStreamedResponseDiscriminatorType.GenerationEnd,
                "generation_info" => ChatStreamedResponseDiscriminatorType.GenerationInfo,
                "search_results" => ChatStreamedResponseDiscriminatorType.SearchResults,
                _ => null,
            };
        }
    }
}