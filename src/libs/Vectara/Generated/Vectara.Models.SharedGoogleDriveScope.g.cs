
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Ingest from a Google Workspace shared drive. The service account (`client_email`) must<br/>
    /// be added as a member of the shared drive — or of the linked folder — with at least Viewer<br/>
    /// access. No domain-wide delegation is required.
    /// </summary>
    public sealed partial class SharedGoogleDriveScope
    {
        /// <summary>
        /// Default Value: shared<br/>
        /// Example: shared
        /// </summary>
        /// <default>"shared"</default>
        /// <example>shared</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "shared";

        /// <summary>
        /// URL of the folder to ingest. Use a shared drive's root URL<br/>
        /// (`https://drive.google.com/drive/folders/&lt;drive_id&gt;`) to enumerate the entire drive,<br/>
        /// or any subfolder URL (`https://drive.google.com/drive/folders/&lt;folder_id&gt;`) to scope<br/>
        /// ingestion to that subtree. The connector walks every descendant subfolder beneath the<br/>
        /// linked target.<br/>
        /// Example: https://drive.google.com/drive/folders/0AHk_z9_Bcg-aUk9PVA
        /// </summary>
        /// <example>https://drive.google.com/drive/folders/0AHk_z9_Bcg-aUk9PVA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedGoogleDriveScope" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: shared<br/>
        /// Example: shared
        /// </param>
        /// <param name="url">
        /// URL of the folder to ingest. Use a shared drive's root URL<br/>
        /// (`https://drive.google.com/drive/folders/&lt;drive_id&gt;`) to enumerate the entire drive,<br/>
        /// or any subfolder URL (`https://drive.google.com/drive/folders/&lt;folder_id&gt;`) to scope<br/>
        /// ingestion to that subtree. The connector walks every descendant subfolder beneath the<br/>
        /// linked target.<br/>
        /// Example: https://drive.google.com/drive/folders/0AHk_z9_Bcg-aUk9PVA
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedGoogleDriveScope(
            string type,
            string url)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedGoogleDriveScope" /> class.
        /// </summary>
        public SharedGoogleDriveScope()
        {
        }

    }
}