
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
                ListPipelinesSourceType.GoogleDrive => "google_drive",
                ListPipelinesSourceType.S3 => "s3",
                ListPipelinesSourceType.Sharepoint => "sharepoint",
                ListPipelinesSourceType.Web => "web",
                ListPipelinesSourceType.Wolken => "wolken",
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
                "google_drive" => ListPipelinesSourceType.GoogleDrive,
                "s3" => ListPipelinesSourceType.S3,
                "sharepoint" => ListPipelinesSourceType.Sharepoint,
                "web" => ListPipelinesSourceType.Web,
                "wolken" => ListPipelinesSourceType.Wolken,
                _ => null,
            };
        }
    }
}