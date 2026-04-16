
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How this dead letter was created.
    /// </summary>
    public enum DeadLetterOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Pipeline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeadLetterOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeadLetterOrigin value)
        {
            return value switch
            {
                DeadLetterOrigin.Manual => "manual",
                DeadLetterOrigin.Pipeline => "pipeline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeadLetterOrigin? ToEnum(string value)
        {
            return value switch
            {
                "manual" => DeadLetterOrigin.Manual,
                "pipeline" => DeadLetterOrigin.Pipeline,
                _ => null,
            };
        }
    }
}