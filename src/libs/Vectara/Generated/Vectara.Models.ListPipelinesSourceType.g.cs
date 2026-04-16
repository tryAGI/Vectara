
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
        S3,
        /// <summary>
        /// 
        /// </summary>
        Sharepoint,
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
                ListPipelinesSourceType.S3 => "s3",
                ListPipelinesSourceType.Sharepoint => "sharepoint",
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
                "s3" => ListPipelinesSourceType.S3,
                "sharepoint" => ListPipelinesSourceType.Sharepoint,
                _ => null,
            };
        }
    }
}