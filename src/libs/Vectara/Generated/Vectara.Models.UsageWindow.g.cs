
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The period `amount` is counted over, which starts again at `resets_at`. Absent for a total that is measured rather than counted, such as storage. New windows may be added.<br/>
    /// Example: day
    /// </summary>
    public enum UsageWindow
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Hour,
        /// <summary>
        ///
        /// </summary>
        Minute,
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Second,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageWindow value)
        {
            return value switch
            {
                UsageWindow.Day => "day",
                UsageWindow.Hour => "hour",
                UsageWindow.Minute => "minute",
                UsageWindow.Month => "month",
                UsageWindow.Second => "second",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageWindow? ToEnum(string value)
        {
            return value switch
            {
                "day" => UsageWindow.Day,
                "hour" => UsageWindow.Hour,
                "minute" => UsageWindow.Minute,
                "month" => UsageWindow.Month,
                "second" => UsageWindow.Second,
                _ => null,
            };
        }
    }
}