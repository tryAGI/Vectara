
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListPipelinesSourceType
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
    public static class ListPipelinesSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPipelinesSourceType value)
        {
            return value switch
            {
                ListPipelinesSourceType.Box => "box",
                ListPipelinesSourceType.Confluence => "confluence",
                ListPipelinesSourceType.GoogleDrive => "google_drive",
                ListPipelinesSourceType.S3 => "s3",
                ListPipelinesSourceType.Scim => "scim",
                ListPipelinesSourceType.Sharepoint => "sharepoint",
                ListPipelinesSourceType.Web => "web",
                ListPipelinesSourceType.WolkenForms => "wolken_forms",
                ListPipelinesSourceType.WolkenKb => "wolken_kb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPipelinesSourceType? ToEnum(string value)
        {
            return value switch
            {
                "box" => ListPipelinesSourceType.Box,
                "confluence" => ListPipelinesSourceType.Confluence,
                "google_drive" => ListPipelinesSourceType.GoogleDrive,
                "s3" => ListPipelinesSourceType.S3,
                "scim" => ListPipelinesSourceType.Scim,
                "sharepoint" => ListPipelinesSourceType.Sharepoint,
                "web" => ListPipelinesSourceType.Web,
                "wolken_forms" => ListPipelinesSourceType.WolkenForms,
                "wolken_kb" => ListPipelinesSourceType.WolkenKb,
                _ => null,
            };
        }
    }
}