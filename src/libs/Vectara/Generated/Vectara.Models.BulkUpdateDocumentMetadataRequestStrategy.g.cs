
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How to apply the supplied `metadata` to each matched document.<br/>
    /// - `merge` (default): adds or overwrites only the supplied fields, leaving other existing fields intact.<br/>
    /// - `replace`: replaces the entire existing metadata with the supplied object.<br/>
    /// Default Value: merge
    /// </summary>
    public enum BulkUpdateDocumentMetadataRequestStrategy
    {
        /// <summary>
        /// adds or overwrites only the supplied fields, leaving other existing fields intact.
        /// </summary>
        Merge,
        /// <summary>
        /// replaces the entire existing metadata with the supplied object.
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkUpdateDocumentMetadataRequestStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateDocumentMetadataRequestStrategy value)
        {
            return value switch
            {
                BulkUpdateDocumentMetadataRequestStrategy.Merge => "merge",
                BulkUpdateDocumentMetadataRequestStrategy.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateDocumentMetadataRequestStrategy? ToEnum(string value)
        {
            return value switch
            {
                "merge" => BulkUpdateDocumentMetadataRequestStrategy.Merge,
                "replace" => BulkUpdateDocumentMetadataRequestStrategy.Replace,
                _ => null,
            };
        }
    }
}