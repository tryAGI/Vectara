
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTracesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTracesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTracesStatus value)
        {
            return value switch
            {
                ListTracesStatus.Error => "error",
                ListTracesStatus.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTracesStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTracesStatus.Error,
                "ok" => ListTracesStatus.Ok,
                _ => null,
            };
        }
    }
}