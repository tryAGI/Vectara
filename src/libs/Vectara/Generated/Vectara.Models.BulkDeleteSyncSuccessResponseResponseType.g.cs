
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Deprecated alias for `type`; identical value. Use `type`.
    /// </summary>
    public enum BulkDeleteSyncSuccessResponseResponseType
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
    public static class BulkDeleteSyncSuccessResponseResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkDeleteSyncSuccessResponseResponseType value)
        {
            return value switch
            {
                BulkDeleteSyncSuccessResponseResponseType.Async => "async",
                BulkDeleteSyncSuccessResponseResponseType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkDeleteSyncSuccessResponseResponseType? ToEnum(string value)
        {
            return value switch
            {
                "async" => BulkDeleteSyncSuccessResponseResponseType.Async,
                "success" => BulkDeleteSyncSuccessResponseResponseType.Success,
                _ => null,
            };
        }
    }
}