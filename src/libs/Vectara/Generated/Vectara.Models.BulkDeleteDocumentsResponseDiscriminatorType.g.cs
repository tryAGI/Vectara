
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum BulkDeleteDocumentsResponseDiscriminatorType
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
    public static class BulkDeleteDocumentsResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkDeleteDocumentsResponseDiscriminatorType value)
        {
            return value switch
            {
                BulkDeleteDocumentsResponseDiscriminatorType.Async => "async",
                BulkDeleteDocumentsResponseDiscriminatorType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkDeleteDocumentsResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "async" => BulkDeleteDocumentsResponseDiscriminatorType.Async,
                "success" => BulkDeleteDocumentsResponseDiscriminatorType.Success,
                _ => null,
            };
        }
    }
}