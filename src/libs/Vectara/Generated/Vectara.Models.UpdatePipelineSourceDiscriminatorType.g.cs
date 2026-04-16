
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePipelineSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePipelineSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePipelineSourceDiscriminatorType value)
        {
            return value switch
            {
                UpdatePipelineSourceDiscriminatorType.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePipelineSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "s3" => UpdatePipelineSourceDiscriminatorType.S3,
                _ => null,
            };
        }
    }
}