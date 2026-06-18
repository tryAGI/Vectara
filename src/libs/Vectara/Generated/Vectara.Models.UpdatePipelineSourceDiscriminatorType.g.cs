
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
        Box,
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
        Sharepoint,
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        Wolken,
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
                UpdatePipelineSourceDiscriminatorType.Box => "box",
                UpdatePipelineSourceDiscriminatorType.GoogleDrive => "google_drive",
                UpdatePipelineSourceDiscriminatorType.S3 => "s3",
                UpdatePipelineSourceDiscriminatorType.Sharepoint => "sharepoint",
                UpdatePipelineSourceDiscriminatorType.Web => "web",
                UpdatePipelineSourceDiscriminatorType.Wolken => "wolken",
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
                "box" => UpdatePipelineSourceDiscriminatorType.Box,
                "google_drive" => UpdatePipelineSourceDiscriminatorType.GoogleDrive,
                "s3" => UpdatePipelineSourceDiscriminatorType.S3,
                "sharepoint" => UpdatePipelineSourceDiscriminatorType.Sharepoint,
                "web" => UpdatePipelineSourceDiscriminatorType.Web,
                "wolken" => UpdatePipelineSourceDiscriminatorType.Wolken,
                _ => null,
            };
        }
    }
}