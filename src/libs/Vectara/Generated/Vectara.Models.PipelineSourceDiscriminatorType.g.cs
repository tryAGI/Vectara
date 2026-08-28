
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
        /// <summary>
        ///
        /// </summary>
        WolkenTickets,
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
                PipelineSourceDiscriminatorType.Docebo => "docebo",
                PipelineSourceDiscriminatorType.Fluidtopics => "fluidtopics",
                PipelineSourceDiscriminatorType.GoogleDrive => "google_drive",
                PipelineSourceDiscriminatorType.S3 => "s3",
                PipelineSourceDiscriminatorType.Scim => "scim",
                PipelineSourceDiscriminatorType.Sharepoint => "sharepoint",
                PipelineSourceDiscriminatorType.Web => "web",
                PipelineSourceDiscriminatorType.WolkenForms => "wolken_forms",
                PipelineSourceDiscriminatorType.WolkenKb => "wolken_kb",
                PipelineSourceDiscriminatorType.WolkenTickets => "wolken_tickets",
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
                "docebo" => PipelineSourceDiscriminatorType.Docebo,
                "fluidtopics" => PipelineSourceDiscriminatorType.Fluidtopics,
                "google_drive" => PipelineSourceDiscriminatorType.GoogleDrive,
                "s3" => PipelineSourceDiscriminatorType.S3,
                "scim" => PipelineSourceDiscriminatorType.Scim,
                "sharepoint" => PipelineSourceDiscriminatorType.Sharepoint,
                "web" => PipelineSourceDiscriminatorType.Web,
                "wolken_forms" => PipelineSourceDiscriminatorType.WolkenForms,
                "wolken_kb" => PipelineSourceDiscriminatorType.WolkenKb,
                "wolken_tickets" => PipelineSourceDiscriminatorType.WolkenTickets,
                _ => null,
            };
        }
    }
}