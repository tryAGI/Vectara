
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Box,
        /// <summary>
        /// 
        /// </summary>
        Confluence,
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
        WolkenKb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineSourceDiscriminatorType value)
        {
            return value switch
            {
                PipelineSourceDiscriminatorType.Box => "box",
                PipelineSourceDiscriminatorType.Confluence => "confluence",
                PipelineSourceDiscriminatorType.GoogleDrive => "google_drive",
                PipelineSourceDiscriminatorType.S3 => "s3",
                PipelineSourceDiscriminatorType.Sharepoint => "sharepoint",
                PipelineSourceDiscriminatorType.Web => "web",
                PipelineSourceDiscriminatorType.WolkenKb => "wolken_kb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "box" => PipelineSourceDiscriminatorType.Box,
                "confluence" => PipelineSourceDiscriminatorType.Confluence,
                "google_drive" => PipelineSourceDiscriminatorType.GoogleDrive,
                "s3" => PipelineSourceDiscriminatorType.S3,
                "sharepoint" => PipelineSourceDiscriminatorType.Sharepoint,
                "web" => PipelineSourceDiscriminatorType.Web,
                "wolken_kb" => PipelineSourceDiscriminatorType.WolkenKb,
                _ => null,
            };
        }
    }
}