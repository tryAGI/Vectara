
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Metadata recorded on each ingested record: source-system fields, owner-attached fields, and<br/>
    /// access-control grants. It is set as the `source_record_metadata` field in each record's session<br/>
    /// metadata, where the pipeline agent can access it. When supplied on a source configuration,<br/>
    /// user-provided values take precedence over connector-derived ones — `system_metadata` and<br/>
    /// `user_metadata` entries override derived entries key by key (derived keys not named are kept), and<br/>
    /// a provided `acl_metadata` replaces ACL extraction entirely.
    /// </summary>
    public sealed partial class SourceRecordMetadata
    {
        /// <summary>
        /// Metadata the source system manages, such as size, timestamps, or eTag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        public object? SystemMetadata { get; set; }

        /// <summary>
        /// Metadata the owner of the source object attached, such as S3 object tags or SharePoint custom columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// Access-control grants recorded on each ingested record — extracted from the source system or<br/>
        /// supplied via a source's `source_record_metadata.acl_metadata` (a supplied value always takes<br/>
        /// priority over extraction).<br/>
        /// Grants are independent and additive: the effective audience is the union of the user lists, the<br/>
        /// group lists, `public_access`, and `org_wide_access`. An omitted list means the source does not<br/>
        /// track that concept for the record; an empty list means it was tracked and nobody holds the grant.<br/>
        /// User and group identifiers are stored verbatim — use the identifier form your query-time access<br/>
        /// filter presents (e.g. email addresses for users), and supply the querying user's groups at query<br/>
        /// time since the platform does not expand group membership. Grants are recorded at ingestion;<br/>
        /// enforcing them at query time is up to the query's access filtering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acl_metadata")]
        public global::Vectara.AclMetadata? AclMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRecordMetadata" /> class.
        /// </summary>
        /// <param name="systemMetadata">
        /// Metadata the source system manages, such as size, timestamps, or eTag.
        /// </param>
        /// <param name="userMetadata">
        /// Metadata the owner of the source object attached, such as S3 object tags or SharePoint custom columns.
        /// </param>
        /// <param name="aclMetadata">
        /// Access-control grants recorded on each ingested record — extracted from the source system or<br/>
        /// supplied via a source's `source_record_metadata.acl_metadata` (a supplied value always takes<br/>
        /// priority over extraction).<br/>
        /// Grants are independent and additive: the effective audience is the union of the user lists, the<br/>
        /// group lists, `public_access`, and `org_wide_access`. An omitted list means the source does not<br/>
        /// track that concept for the record; an empty list means it was tracked and nobody holds the grant.<br/>
        /// User and group identifiers are stored verbatim — use the identifier form your query-time access<br/>
        /// filter presents (e.g. email addresses for users), and supply the querying user's groups at query<br/>
        /// time since the platform does not expand group membership. Grants are recorded at ingestion;<br/>
        /// enforcing them at query time is up to the query's access filtering.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceRecordMetadata(
            object? systemMetadata,
            object? userMetadata,
            global::Vectara.AclMetadata? aclMetadata)
        {
            this.SystemMetadata = systemMetadata;
            this.UserMetadata = userMetadata;
            this.AclMetadata = aclMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRecordMetadata" /> class.
        /// </summary>
        public SourceRecordMetadata()
        {
        }

    }
}