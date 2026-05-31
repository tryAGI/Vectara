
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Ingest from a single user's My Drive via Google Workspace domain-wide delegation. Requires<br/>
    /// the Workspace admin to authorize the service account's client ID with the `drive.readonly`<br/>
    /// OAuth scope.
    /// </summary>
    public sealed partial class MyGoogleDriveScope
    {
        /// <summary>
        /// Default Value: my_drive<br/>
        /// Example: my_drive
        /// </summary>
        /// <default>"my_drive"</default>
        /// <example>my_drive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "my_drive";

        /// <summary>
        /// User email address whose My Drive the service account impersonates.<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectEmail { get; set; }

        /// <summary>
        /// Optional URL of a folder within the user's My Drive<br/>
        /// (`https://drive.google.com/drive/folders/&lt;folder_id&gt;`) to narrow ingestion to that<br/>
        /// subtree. The connector walks all descendant subfolders and indexes every file within.<br/>
        /// If omitted, every accessible file in the user's My Drive is enumerated.<br/>
        /// Example: https://drive.google.com/drive/folders/1A2B3C4D5E6F7G8H9I0J
        /// </summary>
        /// <example>https://drive.google.com/drive/folders/1A2B3C4D5E6F7G8H9I0J</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MyGoogleDriveScope" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: my_drive<br/>
        /// Example: my_drive
        /// </param>
        /// <param name="subjectEmail">
        /// User email address whose My Drive the service account impersonates.<br/>
        /// Example: user@example.com
        /// </param>
        /// <param name="url">
        /// Optional URL of a folder within the user's My Drive<br/>
        /// (`https://drive.google.com/drive/folders/&lt;folder_id&gt;`) to narrow ingestion to that<br/>
        /// subtree. The connector walks all descendant subfolders and indexes every file within.<br/>
        /// If omitted, every accessible file in the user's My Drive is enumerated.<br/>
        /// Example: https://drive.google.com/drive/folders/1A2B3C4D5E6F7G8H9I0J
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MyGoogleDriveScope(
            string type,
            string subjectEmail,
            string? url)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SubjectEmail = subjectEmail ?? throw new global::System.ArgumentNullException(nameof(subjectEmail));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyGoogleDriveScope" /> class.
        /// </summary>
        public MyGoogleDriveScope()
        {
        }

    }
}