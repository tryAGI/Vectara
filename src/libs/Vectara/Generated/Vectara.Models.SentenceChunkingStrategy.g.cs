
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Sets a chunking strategy that creates one chunk per sentence. This is the default strategy used when no chunking strategy is specified.
    /// </summary>
    public sealed partial class SentenceChunkingStrategy
    {
        /// <summary>
        /// When setting the type to sentence_chunking_strategy, the platform creates one chunk per sentence.<br/>
        /// Default Value: sentence_chunking_strategy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Keeps markdown code blocks intact. Code blocks in the section text (fenced with ``` or ~~~, or indented by four spaces) become their own chunks. A code block longer than 4096 characters splits at line boundaries, preferring blank lines; a single line that does not fit together with the chunk's prefix and fence markers is split mid-line. Each code chunk is prefixed with the section title, and the first chunk of a block also with the paragraph that introduces it. Code chunks carry `"vectara": {"part_kind": "code"}` in their metadata, merged into any `vectara` object the section metadata already has. Text outside code blocks is chunked as usual by this strategy. Supported by `createCorpusDocument` for structured documents; `uploadFile` returns a 400 with a field error on `chunking_strategy` when this is `true`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_code_blocks")]
        public bool? PreserveCodeBlocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkingStrategy" /> class.
        /// </summary>
        /// <param name="type">
        /// When setting the type to sentence_chunking_strategy, the platform creates one chunk per sentence.<br/>
        /// Default Value: sentence_chunking_strategy
        /// </param>
        /// <param name="preserveCodeBlocks">
        /// Keeps markdown code blocks intact. Code blocks in the section text (fenced with ``` or ~~~, or indented by four spaces) become their own chunks. A code block longer than 4096 characters splits at line boundaries, preferring blank lines; a single line that does not fit together with the chunk's prefix and fence markers is split mid-line. Each code chunk is prefixed with the section title, and the first chunk of a block also with the paragraph that introduces it. Code chunks carry `"vectara": {"part_kind": "code"}` in their metadata, merged into any `vectara` object the section metadata already has. Text outside code blocks is chunked as usual by this strategy. Supported by `createCorpusDocument` for structured documents; `uploadFile` returns a 400 with a field error on `chunking_strategy` when this is `true`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentenceChunkingStrategy(
            string? type,
            bool? preserveCodeBlocks)
        {
            this.Type = type;
            this.PreserveCodeBlocks = preserveCodeBlocks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkingStrategy" /> class.
        /// </summary>
        public SentenceChunkingStrategy()
        {
        }

    }
}