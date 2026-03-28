
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
        ArtifactGrep,
        /// <summary>
        /// 
        /// </summary>
        ArtifactRead,
        /// <summary>
        /// 
        /// </summary>
        CorporaSearch,
        /// <summary>
        /// 
        /// </summary>
        DocumentConversion,
        /// <summary>
        /// 
        /// </summary>
        DynamicVectara,
        /// <summary>
        /// 
        /// </summary>
        GetDocumentText,
        /// <summary>
        /// 
        /// </summary>
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
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
        WebSearch,
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
                ToolConfigurationDiscriminatorType.ArtifactGrep => "artifact_grep",
                ToolConfigurationDiscriminatorType.ArtifactRead => "artifact_read",
                ToolConfigurationDiscriminatorType.CorporaSearch => "corpora_search",
                ToolConfigurationDiscriminatorType.DocumentConversion => "document_conversion",
                ToolConfigurationDiscriminatorType.DynamicVectara => "dynamic_vectara",
                ToolConfigurationDiscriminatorType.GetDocumentText => "get_document_text",
                ToolConfigurationDiscriminatorType.ImageRead => "image_read",
                ToolConfigurationDiscriminatorType.Lambda => "lambda",
                ToolConfigurationDiscriminatorType.Mcp => "mcp",
                ToolConfigurationDiscriminatorType.StructuredIndexing => "structured_indexing",
                ToolConfigurationDiscriminatorType.SubAgent => "sub_agent",
                ToolConfigurationDiscriminatorType.WebSearch => "web_search",
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
                "artifact_grep" => ToolConfigurationDiscriminatorType.ArtifactGrep,
                "artifact_read" => ToolConfigurationDiscriminatorType.ArtifactRead,
                "corpora_search" => ToolConfigurationDiscriminatorType.CorporaSearch,
                "document_conversion" => ToolConfigurationDiscriminatorType.DocumentConversion,
                "dynamic_vectara" => ToolConfigurationDiscriminatorType.DynamicVectara,
                "get_document_text" => ToolConfigurationDiscriminatorType.GetDocumentText,
                "image_read" => ToolConfigurationDiscriminatorType.ImageRead,
                "lambda" => ToolConfigurationDiscriminatorType.Lambda,
                "mcp" => ToolConfigurationDiscriminatorType.Mcp,
                "structured_indexing" => ToolConfigurationDiscriminatorType.StructuredIndexing,
                "sub_agent" => ToolConfigurationDiscriminatorType.SubAgent,
                "web_search" => ToolConfigurationDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}