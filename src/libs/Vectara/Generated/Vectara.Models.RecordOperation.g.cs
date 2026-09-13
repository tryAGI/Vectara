
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The operation the source performed on a record. `upsert` when the record was added or changed, `delete` when the source reported it deleted. New values may be added; treat unrecognized values as opaque.
    /// </summary>
    public enum RecordOperation
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Upsert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecordOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordOperation value)
        {
            return value switch
            {
                RecordOperation.Delete => "delete",
                RecordOperation.Upsert => "upsert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordOperation? ToEnum(string value)
        {
            return value switch
            {
                "delete" => RecordOperation.Delete,
                "upsert" => RecordOperation.Upsert,
                _ => null,
            };
        }
    }
}