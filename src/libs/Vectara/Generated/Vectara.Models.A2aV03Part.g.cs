
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v0.3 message or artifact content part. Exactly one of `text`, `file`, or `data` is populated. There is no `kind` discriminator field — the populated oneof field selects the variant.
    /// </summary>
    public sealed partial class A2aV03Part
    {
        /// <summary>
        /// Plain-text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A v0.3 file attachment. Exactly one of `fileWithUri` or `fileWithBytes` is populated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::Vectara.A2aV03FilePart? File { get; set; }

        /// <summary>
        /// A v0.3 structured-data part. The `data` field is an arbitrary JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Vectara.A2aV03DataPart? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03Part" /> class.
        /// </summary>
        /// <param name="text">
        /// Plain-text content.
        /// </param>
        /// <param name="file">
        /// A v0.3 file attachment. Exactly one of `fileWithUri` or `fileWithBytes` is populated.
        /// </param>
        /// <param name="data">
        /// A v0.3 structured-data part. The `data` field is an arbitrary JSON object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03Part(
            string? text,
            global::Vectara.A2aV03FilePart? file,
            global::Vectara.A2aV03DataPart? data)
        {
            this.Text = text;
            this.File = file;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03Part" /> class.
        /// </summary>
        public A2aV03Part()
        {
        }

    }
}