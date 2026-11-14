
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The bytes one corpus or agent stores, as of the latest hourly measurement. Absent until it has been measured.
    /// </summary>
    public sealed partial class MeasuredStorage
    {
        /// <summary>
        /// The start of the hour the bytes were measured in.<br/>
        /// Example: 2026-11-05T09:00:00Z
        /// </summary>
        /// <example>2026-11-05T09:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("measured_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime MeasuredAt { get; set; }

        /// <summary>
        /// The bytes of data given, including the search indexes built from it, before compression or copies.<br/>
        /// Example: 21402512903
        /// </summary>
        /// <example>21402512903</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentBytes { get; set; }

        /// <summary>
        /// The bytes the platform keeps, compressed and with every copy.<br/>
        /// Example: 40533402118
        /// </summary>
        /// <example>40533402118</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stored_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StoredBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasuredStorage" /> class.
        /// </summary>
        /// <param name="measuredAt">
        /// The start of the hour the bytes were measured in.<br/>
        /// Example: 2026-11-05T09:00:00Z
        /// </param>
        /// <param name="contentBytes">
        /// The bytes of data given, including the search indexes built from it, before compression or copies.<br/>
        /// Example: 21402512903
        /// </param>
        /// <param name="storedBytes">
        /// The bytes the platform keeps, compressed and with every copy.<br/>
        /// Example: 40533402118
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasuredStorage(
            global::System.DateTime measuredAt,
            long contentBytes,
            long storedBytes)
        {
            this.MeasuredAt = measuredAt;
            this.ContentBytes = contentBytes;
            this.StoredBytes = storedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasuredStorage" /> class.
        /// </summary>
        public MeasuredStorage()
        {
        }

    }
}