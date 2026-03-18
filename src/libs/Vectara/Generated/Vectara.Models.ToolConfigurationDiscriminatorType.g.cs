
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolConfigurationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        DynamicVectara,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        CorporaSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        StructuredIndexing,
        /// <summary>
        /// 
        /// </summary>
        SubAgent,
        /// <summary>
        /// 
        /// </summary>
        ArtifactRead,
        /// <summary>
        /// 
        /// </summary>
        ArtifactGrep,
        /// <summary>
        /// 
        /// </summary>
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        DocumentConversion,
        /// <summary>
        /// 
        /// </summary>
        GetDocumentText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolConfigurationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolConfigurationDiscriminatorType value)
        {
            return value switch
            {
                ToolConfigurationDiscriminatorType.DynamicVectara => "dynamic_vectara",
                ToolConfigurationDiscriminatorType.Mcp => "mcp",
                ToolConfigurationDiscriminatorType.CorporaSearch => "corpora_search",
                ToolConfigurationDiscriminatorType.WebSearch => "web_search",
                ToolConfigurationDiscriminatorType.Lambda => "lambda",
                ToolConfigurationDiscriminatorType.StructuredIndexing => "structured_indexing",
                ToolConfigurationDiscriminatorType.SubAgent => "sub_agent",
                ToolConfigurationDiscriminatorType.ArtifactRead => "artifact_read",
                ToolConfigurationDiscriminatorType.ArtifactGrep => "artifact_grep",
                ToolConfigurationDiscriminatorType.ImageRead => "image_read",
                ToolConfigurationDiscriminatorType.DocumentConversion => "document_conversion",
                ToolConfigurationDiscriminatorType.GetDocumentText => "get_document_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolConfigurationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic_vectara" => ToolConfigurationDiscriminatorType.DynamicVectara,
                "mcp" => ToolConfigurationDiscriminatorType.Mcp,
                "corpora_search" => ToolConfigurationDiscriminatorType.CorporaSearch,
                "web_search" => ToolConfigurationDiscriminatorType.WebSearch,
                "lambda" => ToolConfigurationDiscriminatorType.Lambda,
                "structured_indexing" => ToolConfigurationDiscriminatorType.StructuredIndexing,
                "sub_agent" => ToolConfigurationDiscriminatorType.SubAgent,
                "artifact_read" => ToolConfigurationDiscriminatorType.ArtifactRead,
                "artifact_grep" => ToolConfigurationDiscriminatorType.ArtifactGrep,
                "image_read" => ToolConfigurationDiscriminatorType.ImageRead,
                "document_conversion" => ToolConfigurationDiscriminatorType.DocumentConversion,
                "get_document_text" => ToolConfigurationDiscriminatorType.GetDocumentText,
                _ => null,
            };
        }
    }
}