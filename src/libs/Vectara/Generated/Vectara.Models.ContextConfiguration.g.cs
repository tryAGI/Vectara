
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for the presentation of each document part in the result set. Use either `characters_before`/`characters_after` or `sentences_before`/`sentences_after`; if both are set, `sentences_*` takes precedence. Setting `full_document_context: true` overrides both and returns the entire matching document as context.<br/>
    /// Example: {"sentences_before":2,"sentences_after":2,"start_tag":"\u003Cem\u003E","end_tag":"\u003C/em\u003E"}
    /// </summary>
    public sealed partial class ContextConfiguration
    {
        /// <summary>
        /// The number of characters to show before the matching document part. This shows the context of the part in the wider document. Ignored if `sentences_before` is set. The platform captures the full sentence that contains the captured characters, so a truncated word or sentence does not lose meaning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_before")]
        public int? CharactersBefore { get; set; }

        /// <summary>
        /// The number of characters to show after the matching document part. This shows the context of the part in the wider document. Ignored if `sentences_after` is set. The platform captures the full sentence that contains the captured characters, so a truncated word or sentence does not lose meaning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_after")]
        public int? CharactersAfter { get; set; }

        /// <summary>
        /// The number of sentences to show before the matching document part. This shows the context of the part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_before")]
        public int? SentencesBefore { get; set; }

        /// <summary>
        /// The number of sentences to show after the matching document part. This shows the context of the part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_after")]
        public int? SentencesAfter { get; set; }

        /// <summary>
        /// The tag that wraps the start of the document part. Use an HTML/XML tag or another delimiter. Your application can use the tag to highlight the part in your UI. The tag also marks where the preceding context ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </summary>
        /// <example>&lt;em&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_tag")]
        public string? StartTag { get; set; }

        /// <summary>
        /// The tag that wraps the end of the document part. Use an HTML/XML tag or another delimiter. Your application can use the tag to highlight the part in your UI. The tag also marks where the document part ends and the following context begins.<br/>
        /// Example: &lt;/em&gt;
        /// </summary>
        /// <example>&lt;/em&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_tag")]
        public string? EndTag { get; set; }

        /// <summary>
        /// When true, the platform returns the entire document that contains the matching part as context. `characters_before`/`characters_after` and `sentences_before`/`sentences_after` are ignored.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_document_context")]
        public bool? FullDocumentContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextConfiguration" /> class.
        /// </summary>
        /// <param name="charactersBefore">
        /// The number of characters to show before the matching document part. This shows the context of the part in the wider document. Ignored if `sentences_before` is set. The platform captures the full sentence that contains the captured characters, so a truncated word or sentence does not lose meaning.
        /// </param>
        /// <param name="charactersAfter">
        /// The number of characters to show after the matching document part. This shows the context of the part in the wider document. Ignored if `sentences_after` is set. The platform captures the full sentence that contains the captured characters, so a truncated word or sentence does not lose meaning.
        /// </param>
        /// <param name="sentencesBefore">
        /// The number of sentences to show before the matching document part. This shows the context of the part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="sentencesAfter">
        /// The number of sentences to show after the matching document part. This shows the context of the part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 2
        /// </param>
        /// <param name="startTag">
        /// The tag that wraps the start of the document part. Use an HTML/XML tag or another delimiter. Your application can use the tag to highlight the part in your UI. The tag also marks where the preceding context ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </param>
        /// <param name="endTag">
        /// The tag that wraps the end of the document part. Use an HTML/XML tag or another delimiter. Your application can use the tag to highlight the part in your UI. The tag also marks where the document part ends and the following context begins.<br/>
        /// Example: &lt;/em&gt;
        /// </param>
        /// <param name="fullDocumentContext">
        /// When true, the platform returns the entire document that contains the matching part as context. `characters_before`/`characters_after` and `sentences_before`/`sentences_after` are ignored.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextConfiguration(
            int? charactersBefore,
            int? charactersAfter,
            int? sentencesBefore,
            int? sentencesAfter,
            string? startTag,
            string? endTag,
            bool? fullDocumentContext)
        {
            this.CharactersBefore = charactersBefore;
            this.CharactersAfter = charactersAfter;
            this.SentencesBefore = sentencesBefore;
            this.SentencesAfter = sentencesAfter;
            this.StartTag = startTag;
            this.EndTag = endTag;
            this.FullDocumentContext = fullDocumentContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextConfiguration" /> class.
        /// </summary>
        public ContextConfiguration()
        {
        }

    }
}