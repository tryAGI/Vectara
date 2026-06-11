
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Collapses the result set so that at most one result is returned per document, keeping the highest-scoring part of each. Applied to the retrieved results before reranking and pagination, so the number of results returned may be smaller than `limit`.<br/>
    /// Example: doc.id
    /// </summary>
    public enum SearchParametersMaxBy
    {
        /// <summary>
        /// 
        /// </summary>
        DocId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchParametersMaxByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchParametersMaxBy value)
        {
            return value switch
            {
                SearchParametersMaxBy.DocId => "doc.id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchParametersMaxBy? ToEnum(string value)
        {
            return value switch
            {
                "doc.id" => SearchParametersMaxBy.DocId,
                _ => null,
            };
        }
    }
}