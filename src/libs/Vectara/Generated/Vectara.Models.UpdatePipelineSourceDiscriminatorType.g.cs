
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
        GoogleDrive,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        Web,
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
                UpdatePipelineSourceDiscriminatorType.GoogleDrive => "google_drive",
                UpdatePipelineSourceDiscriminatorType.S3 => "s3",
                UpdatePipelineSourceDiscriminatorType.Web => "web",
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
                "google_drive" => UpdatePipelineSourceDiscriminatorType.GoogleDrive,
                "s3" => UpdatePipelineSourceDiscriminatorType.S3,
                "web" => UpdatePipelineSourceDiscriminatorType.Web,
                _ => null,
            };
        }
    }
}