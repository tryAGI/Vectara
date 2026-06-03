
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Google Drive source configuration. The `scopes` list enumerates one or more starting<br/>
    /// points — each entry is either a shared drive (`shared`) or a single user's My Drive accessed<br/>
    /// via domain-wide delegation (`my_drive`). The service account configured here must have read<br/>
    /// access to every listed drive and be authorized for each impersonated user.
    /// </summary>
    public sealed partial class BaseGoogleDriveSourceConfiguration
    {
        /// <summary>
        /// Default Value: google_drive<br/>
        /// Example: google_drive
        /// </summary>
        /// <default>"google_drive"</default>
        /// <example>google_drive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "google_drive";

        /// <summary>
        /// Drive starting points to ingest under this pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<global::Vectara.GoogleDriveScope>? Scopes { get; set; }

        /// <summary>
        /// The Google Cloud service account's email address (the `client_email` field of<br/>
        /// the service account JSON key). For `shared` scopes, grant this email read access<br/>
        /// to each drive or folder you want to ingest.<br/>
        /// Example: drive-ingest@my-project.iam.gserviceaccount.com
        /// </summary>
        /// <example>drive-ingest@my-project.iam.gserviceaccount.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_email")]
        public string? ClientEmail { get; set; }

        /// <summary>
        /// The service account's PEM-formatted RSA private key (the `private_key` field<br/>
        /// of the service account JSON key, including the `-----BEGIN PRIVATE KEY-----`<br/>
        /// and `-----END PRIVATE KEY-----` markers and embedded newlines). Encrypted at<br/>
        /// rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_key")]
        public string? PrivateKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGoogleDriveSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: google_drive<br/>
        /// Example: google_drive
        /// </param>
        /// <param name="scopes">
        /// Drive starting points to ingest under this pipeline.
        /// </param>
        /// <param name="clientEmail">
        /// The Google Cloud service account's email address (the `client_email` field of<br/>
        /// the service account JSON key). For `shared` scopes, grant this email read access<br/>
        /// to each drive or folder you want to ingest.<br/>
        /// Example: drive-ingest@my-project.iam.gserviceaccount.com
        /// </param>
        /// <param name="privateKey">
        /// The service account's PEM-formatted RSA private key (the `private_key` field<br/>
        /// of the service account JSON key, including the `-----BEGIN PRIVATE KEY-----`<br/>
        /// and `-----END PRIVATE KEY-----` markers and embedded newlines). Encrypted at<br/>
        /// rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseGoogleDriveSourceConfiguration(
            string type,
            global::System.Collections.Generic.IList<global::Vectara.GoogleDriveScope>? scopes,
            string? clientEmail,
            string? privateKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Scopes = scopes;
            this.ClientEmail = clientEmail;
            this.PrivateKey = privateKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGoogleDriveSourceConfiguration" /> class.
        /// </summary>
        public BaseGoogleDriveSourceConfiguration()
        {
        }

    }
}