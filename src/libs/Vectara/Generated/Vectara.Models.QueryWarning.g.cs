
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Non-fatal warnings that occurred during query processing.<br/>
    ///  *  `exceeded_max_input_length_fcs`: The input to the Factual Consistency Score model exceeded the maximum allowed length, so no score is being returned<br/>
    ///  *  `intelligent_query_rewriting_failed`: Intelligent query rewriting failed due to an internal error
    /// </summary>
    public enum QueryWarning
    {
        /// <summary>
        /// The input to the Factual Consistency Score model exceeded the maximum allowed length, so no score is being returned
        /// </summary>
        ExceededMaxInputLengthFcs,
        /// <summary>
        /// Intelligent query rewriting failed due to an internal error
        /// </summary>
        IntelligentQueryRewritingFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryWarningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryWarning value)
        {
            return value switch
            {
                QueryWarning.ExceededMaxInputLengthFcs => "exceeded_max_input_length_fcs",
                QueryWarning.IntelligentQueryRewritingFailed => "intelligent_query_rewriting_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryWarning? ToEnum(string value)
        {
            return value switch
            {
                "exceeded_max_input_length_fcs" => QueryWarning.ExceededMaxInputLengthFcs,
                "intelligent_query_rewriting_failed" => QueryWarning.IntelligentQueryRewritingFailed,
                _ => null,
            };
        }
    }
}