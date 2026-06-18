
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Box source configuration. Ingests files from a Box enterprise starting at `folder_id`,<br/>
    /// walking every descendant subfolder and inheriting each item's Box collaborations as<br/>
    /// document-level ACL.
    /// </summary>
    public sealed partial class BaseBoxSourceConfiguration
    {
        /// <summary>
        /// Default Value: box<br/>
        /// Example: box
        /// </summary>
        /// <default>"box"</default>
        /// <example>box</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "box";

        /// <summary>
        /// The Box folder ID to ingest from. A Box folder URL (`https://app.box.com/folder/&lt;id&gt;`)<br/>
        /// is also accepted, in which case the ID is taken from the URL. Defaults to the enterprise<br/>
        /// root (ID `"0"`).<br/>
        /// Default Value: 0<br/>
        /// Example: 323805611740
        /// </summary>
        /// <example>323805611740</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Credentials used to authenticate with the Box API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::Vectara.BoxCcgAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBoxSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: box<br/>
        /// Example: box
        /// </param>
        /// <param name="folderId">
        /// The Box folder ID to ingest from. A Box folder URL (`https://app.box.com/folder/&lt;id&gt;`)<br/>
        /// is also accepted, in which case the ID is taken from the URL. Defaults to the enterprise<br/>
        /// root (ID `"0"`).<br/>
        /// Default Value: 0<br/>
        /// Example: 323805611740
        /// </param>
        /// <param name="auth">
        /// Credentials used to authenticate with the Box API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseBoxSourceConfiguration(
            string type,
            string? folderId,
            global::Vectara.BoxCcgAuth? auth)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.FolderId = folderId;
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBoxSourceConfiguration" /> class.
        /// </summary>
        public BaseBoxSourceConfiguration()
        {
        }

    }
}