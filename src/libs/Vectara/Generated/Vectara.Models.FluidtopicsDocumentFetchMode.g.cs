
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How a Fluid Topics document body is fetched.<br/>
    /// - `extracted_text`: the Fluid Topics plain-text extraction of the body.<br/>
    /// - `original_file`: the original file, converted by the platform, which preserves document<br/>
    ///   structure such as tables, headings, and figures.<br/>
    /// - `metadata_only`: no body download; the record is indexed from its title, description, and<br/>
    ///   metadata alone.
    /// </summary>
    public enum FluidtopicsDocumentFetchMode
    {
        /// <summary>
        /// the Fluid Topics plain-text extraction of the body.
        /// </summary>
        ExtractedText,
        /// <summary>
        /// no body download; the record is indexed from its title, description, and
        /// </summary>
        MetadataOnly,
        /// <summary>
        /// the original file, converted by the platform, which preserves document
        /// </summary>
        OriginalFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FluidtopicsDocumentFetchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FluidtopicsDocumentFetchMode value)
        {
            return value switch
            {
                FluidtopicsDocumentFetchMode.ExtractedText => "extracted_text",
                FluidtopicsDocumentFetchMode.MetadataOnly => "metadata_only",
                FluidtopicsDocumentFetchMode.OriginalFile => "original_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FluidtopicsDocumentFetchMode? ToEnum(string value)
        {
            return value switch
            {
                "extracted_text" => FluidtopicsDocumentFetchMode.ExtractedText,
                "metadata_only" => FluidtopicsDocumentFetchMode.MetadataOnly,
                "original_file" => FluidtopicsDocumentFetchMode.OriginalFile,
                _ => null,
            };
        }
    }
}