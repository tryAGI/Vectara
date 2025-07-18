
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A part of a document. This section gets converted into an embedding and directly maps to a search result. Usually a sentence.
    /// </summary>
    public sealed partial class DocumentPart
    {
        /// <summary>
        /// The text of the document part.<br/>
        /// Example: This invoice includes customer billing history for Q1.
        /// </summary>
        /// <example>This invoice includes customer billing history for Q1.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The metadata for a document part. These may be used in metadata filters at query time if filter attributes are configured on the corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The context text for the document part.<br/>
        /// Example: Description of line items in the document part to provide additional context.
        /// </summary>
        /// <example>Description of line items in the document part to provide additional context.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPart" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the document part.<br/>
        /// Example: This invoice includes customer billing history for Q1.
        /// </param>
        /// <param name="metadata">
        /// The metadata for a document part. These may be used in metadata filters at query time if filter attributes are configured on the corpus.
        /// </param>
        /// <param name="context">
        /// The context text for the document part.<br/>
        /// Example: Description of line items in the document part to provide additional context.
        /// </param>
        /// <param name="customDimensions">
        /// The custom dimensions as additional weights.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentPart(
            string text,
            object? metadata,
            string? context,
            global::System.Collections.Generic.Dictionary<string, double>? customDimensions)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Metadata = metadata;
            this.Context = context;
            this.CustomDimensions = customDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPart" /> class.
        /// </summary>
        public DocumentPart()
        {
        }
    }
}