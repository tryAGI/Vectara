
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Ingestion of page attachments as their own records. No type filter is applied: every attachment is<br/>
    /// ingested unless `pos_regex`, `neg_regex`, or `max_bytes` excludes it. An attachment whose type the<br/>
    /// pipeline's transform cannot convert is still downloaded and counted as processed, but nothing is indexed<br/>
    /// for it.
    /// </summary>
    public sealed partial class ConfluenceAttachmentsConfiguration
    {
        /// <summary>
        /// Whether attachments are ingested.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Java regular expressions matched against the attachment's file name. When non-empty, an attachment is<br/>
        /// ingested only if its name fully matches at least one pattern. An empty list applies no positive<br/>
        /// filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pos_regex")]
        public global::System.Collections.Generic.IList<string>? PosRegex { get; set; }

        /// <summary>
        /// Java regular expressions matched against the attachment's file name. An attachment whose name fully<br/>
        /// matches any pattern is skipped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neg_regex")]
        public global::System.Collections.Generic.IList<string>? NegRegex { get; set; }

        /// <summary>
        /// Maximum attachment size in bytes; larger attachments are not ingested. Between 1 KiB and 100 MiB.<br/>
        /// Default Value: 26214400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_bytes")]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfluenceAttachmentsConfiguration" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether attachments are ingested.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="posRegex">
        /// Java regular expressions matched against the attachment's file name. When non-empty, an attachment is<br/>
        /// ingested only if its name fully matches at least one pattern. An empty list applies no positive<br/>
        /// filter.
        /// </param>
        /// <param name="negRegex">
        /// Java regular expressions matched against the attachment's file name. An attachment whose name fully<br/>
        /// matches any pattern is skipped.
        /// </param>
        /// <param name="maxBytes">
        /// Maximum attachment size in bytes; larger attachments are not ingested. Between 1 KiB and 100 MiB.<br/>
        /// Default Value: 26214400
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfluenceAttachmentsConfiguration(
            bool? enabled,
            global::System.Collections.Generic.IList<string>? posRegex,
            global::System.Collections.Generic.IList<string>? negRegex,
            long? maxBytes)
        {
            this.Enabled = enabled;
            this.PosRegex = posRegex;
            this.NegRegex = negRegex;
            this.MaxBytes = maxBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfluenceAttachmentsConfiguration" /> class.
        /// </summary>
        public ConfluenceAttachmentsConfiguration()
        {
        }

    }
}