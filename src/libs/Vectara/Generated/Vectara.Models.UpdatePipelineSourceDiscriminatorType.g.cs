
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
        Confluence,
        /// <summary>
        ///
        /// </summary>
        Docebo,
        /// <summary>
        ///
        /// </summary>
        Fluidtopics,
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
        Scim,
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
        WolkenForms,
        /// <summary>
        ///
        /// </summary>
        WolkenKb,
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
                UpdatePipelineSourceDiscriminatorType.Confluence => "confluence",
                UpdatePipelineSourceDiscriminatorType.Docebo => "docebo",
                UpdatePipelineSourceDiscriminatorType.Fluidtopics => "fluidtopics",
                UpdatePipelineSourceDiscriminatorType.GoogleDrive => "google_drive",
                UpdatePipelineSourceDiscriminatorType.S3 => "s3",
                UpdatePipelineSourceDiscriminatorType.Scim => "scim",
                UpdatePipelineSourceDiscriminatorType.Sharepoint => "sharepoint",
                UpdatePipelineSourceDiscriminatorType.Web => "web",
                UpdatePipelineSourceDiscriminatorType.WolkenForms => "wolken_forms",
                UpdatePipelineSourceDiscriminatorType.WolkenKb => "wolken_kb",
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
                "confluence" => UpdatePipelineSourceDiscriminatorType.Confluence,
                "docebo" => UpdatePipelineSourceDiscriminatorType.Docebo,
                "fluidtopics" => UpdatePipelineSourceDiscriminatorType.Fluidtopics,
                "google_drive" => UpdatePipelineSourceDiscriminatorType.GoogleDrive,
                "s3" => UpdatePipelineSourceDiscriminatorType.S3,
                "scim" => UpdatePipelineSourceDiscriminatorType.Scim,
                "sharepoint" => UpdatePipelineSourceDiscriminatorType.Sharepoint,
                "web" => UpdatePipelineSourceDiscriminatorType.Web,
                "wolken_forms" => UpdatePipelineSourceDiscriminatorType.WolkenForms,
                "wolken_kb" => UpdatePipelineSourceDiscriminatorType.WolkenKb,
                _ => null,
            };
        }
    }
}