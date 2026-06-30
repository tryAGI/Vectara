
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Deprecated alias for `type`; identical value. Use `type`.
    /// </summary>
    public enum BulkDeleteAsyncResponseResponseType
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
    public static class BulkDeleteAsyncResponseResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkDeleteAsyncResponseResponseType value)
        {
            return value switch
            {
                BulkDeleteAsyncResponseResponseType.Async => "async",
                BulkDeleteAsyncResponseResponseType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkDeleteAsyncResponseResponseType? ToEnum(string value)
        {
            return value switch
            {
                "async" => BulkDeleteAsyncResponseResponseType.Async,
                "success" => BulkDeleteAsyncResponseResponseType.Success,
                _ => null,
            };
        }
    }
}