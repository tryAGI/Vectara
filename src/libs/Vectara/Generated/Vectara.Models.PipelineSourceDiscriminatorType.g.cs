
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
        Documentum,
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
    public static class PipelineSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineSourceDiscriminatorType value)
        {
            return value switch
            {
                PipelineSourceDiscriminatorType.Documentum => "documentum",
                PipelineSourceDiscriminatorType.S3 => "s3",
                PipelineSourceDiscriminatorType.Sharepoint => "sharepoint",
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
                "documentum" => PipelineSourceDiscriminatorType.Documentum,
                "s3" => PipelineSourceDiscriminatorType.S3,
                "sharepoint" => PipelineSourceDiscriminatorType.Sharepoint,
                _ => null,
            };
        }
    }
}