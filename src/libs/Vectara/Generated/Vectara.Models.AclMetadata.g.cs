
#nullable enable

namespace Vectara
{
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
    public sealed partial class AclMetadata
    {
        /// <summary>
        /// User identifiers that own the record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owners")]
        public global::System.Collections.Generic.IList<string>? Owners { get; set; }

        /// <summary>
        /// User identifiers granted edit access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editors")]
        public global::System.Collections.Generic.IList<string>? Editors { get; set; }

        /// <summary>
        /// User identifiers granted comment access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commenters")]
        public global::System.Collections.Generic.IList<string>? Commenters { get; set; }

        /// <summary>
        /// User identifiers granted read access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readers")]
        public global::System.Collections.Generic.IList<string>? Readers { get; set; }

        /// <summary>
        /// Group identifiers granted edit access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_editors")]
        public global::System.Collections.Generic.IList<string>? GroupEditors { get; set; }

        /// <summary>
        /// Group identifiers granted comment access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_commenters")]
        public global::System.Collections.Generic.IList<string>? GroupCommenters { get; set; }

        /// <summary>
        /// Group identifiers granted read access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_readers")]
        public global::System.Collections.Generic.IList<string>? GroupReaders { get; set; }

        /// <summary>
        /// Access level a grant confers on a record. `none` means the access concept applies to the record but<br/>
        /// no grant was made. New levels may be added over time; clients should treat unknown values as opaque.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AclAccessLevelJsonConverter))]
        public global::Vectara.AclAccessLevel? PublicAccess { get; set; }

        /// <summary>
        /// Access level a grant confers on a record. `none` means the access concept applies to the record but<br/>
        /// no grant was made. New levels may be added over time; clients should treat unknown values as opaque.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_wide_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.AclAccessLevelJsonConverter))]
        public global::Vectara.AclAccessLevel? OrgWideAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AclMetadata" /> class.
        /// </summary>
        /// <param name="owners">
        /// User identifiers that own the record.
        /// </param>
        /// <param name="editors">
        /// User identifiers granted edit access.
        /// </param>
        /// <param name="commenters">
        /// User identifiers granted comment access.
        /// </param>
        /// <param name="readers">
        /// User identifiers granted read access.
        /// </param>
        /// <param name="groupEditors">
        /// Group identifiers granted edit access.
        /// </param>
        /// <param name="groupCommenters">
        /// Group identifiers granted comment access.
        /// </param>
        /// <param name="groupReaders">
        /// Group identifiers granted read access.
        /// </param>
        /// <param name="publicAccess">
        /// Access level a grant confers on a record. `none` means the access concept applies to the record but<br/>
        /// no grant was made. New levels may be added over time; clients should treat unknown values as opaque.
        /// </param>
        /// <param name="orgWideAccess">
        /// Access level a grant confers on a record. `none` means the access concept applies to the record but<br/>
        /// no grant was made. New levels may be added over time; clients should treat unknown values as opaque.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AclMetadata(
            global::System.Collections.Generic.IList<string>? owners,
            global::System.Collections.Generic.IList<string>? editors,
            global::System.Collections.Generic.IList<string>? commenters,
            global::System.Collections.Generic.IList<string>? readers,
            global::System.Collections.Generic.IList<string>? groupEditors,
            global::System.Collections.Generic.IList<string>? groupCommenters,
            global::System.Collections.Generic.IList<string>? groupReaders,
            global::Vectara.AclAccessLevel? publicAccess,
            global::Vectara.AclAccessLevel? orgWideAccess)
        {
            this.Owners = owners;
            this.Editors = editors;
            this.Commenters = commenters;
            this.Readers = readers;
            this.GroupEditors = groupEditors;
            this.GroupCommenters = groupCommenters;
            this.GroupReaders = groupReaders;
            this.PublicAccess = publicAccess;
            this.OrgWideAccess = orgWideAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AclMetadata" /> class.
        /// </summary>
        public AclMetadata()
        {
        }

    }
}