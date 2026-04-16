
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The status of a dead letter entry.
    /// </summary>
    public enum DeadLetterStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Retrying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeadLetterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeadLetterStatus value)
        {
            return value switch
            {
                DeadLetterStatus.Pending => "pending",
                DeadLetterStatus.Retrying => "retrying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeadLetterStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => DeadLetterStatus.Pending,
                "retrying" => DeadLetterStatus.Retrying,
                _ => null,
            };
        }
    }
}