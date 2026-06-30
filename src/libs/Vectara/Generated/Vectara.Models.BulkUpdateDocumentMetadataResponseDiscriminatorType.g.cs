
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkUpdateDocumentMetadataResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkUpdateDocumentMetadataResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateDocumentMetadataResponseDiscriminatorType value)
        {
            return value switch
            {
                BulkUpdateDocumentMetadataResponseDiscriminatorType.Async => "async",
                BulkUpdateDocumentMetadataResponseDiscriminatorType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateDocumentMetadataResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "async" => BulkUpdateDocumentMetadataResponseDiscriminatorType.Async,
                "success" => BulkUpdateDocumentMetadataResponseDiscriminatorType.Success,
                _ => null,
            };
        }
    }
}