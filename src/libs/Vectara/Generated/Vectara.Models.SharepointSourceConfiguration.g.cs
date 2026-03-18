
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting documents from a SharePoint site.
    /// </summary>
    public sealed partial class SharepointSourceConfiguration
    {
        /// <summary>
        /// Default Value: sharepoint<br/>
        /// Example: sharepoint
        /// </summary>
        /// <default>"sharepoint"</default>
        /// <example>sharepoint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "sharepoint";

        /// <summary>
        /// The full URL of the SharePoint site.<br/>
        /// Example: https://contoso.sharepoint.com/sites/legal
        /// </summary>
        /// <example>https://contoso.sharepoint.com/sites/legal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SiteUrl { get; set; }

        /// <summary>
        /// Azure AD tenant ID.<br/>
        /// Example: 72f988bf-86f1-41af-91ab-2d7cd011db47
        /// </summary>
        /// <example>72f988bf-86f1-41af-91ab-2d7cd011db47</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// Azure AD application (client) ID for OAuth.<br/>
        /// Example: 0a1b2c3d-4e5f-6789-abcd-ef0123456789
        /// </summary>
        /// <example>0a1b2c3d-4e5f-6789-abcd-ef0123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Azure AD client secret. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The ID of a specific document library. If omitted, the default document library is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive_id")]
        public string? DriveId { get; set; }

        /// <summary>
        /// Optional folder path to scope ingestion to a subdirectory.<br/>
        /// Example: /Contracts/2026
        /// </summary>
        /// <example>/Contracts/2026</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_path")]
        public string? FolderPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: sharepoint<br/>
        /// Example: sharepoint
        /// </param>
        /// <param name="siteUrl">
        /// The full URL of the SharePoint site.<br/>
        /// Example: https://contoso.sharepoint.com/sites/legal
        /// </param>
        /// <param name="tenantId">
        /// Azure AD tenant ID.<br/>
        /// Example: 72f988bf-86f1-41af-91ab-2d7cd011db47
        /// </param>
        /// <param name="clientId">
        /// Azure AD application (client) ID for OAuth.<br/>
        /// Example: 0a1b2c3d-4e5f-6789-abcd-ef0123456789
        /// </param>
        /// <param name="clientSecret">
        /// Azure AD client secret. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="driveId">
        /// The ID of a specific document library. If omitted, the default document library is used.
        /// </param>
        /// <param name="folderPath">
        /// Optional folder path to scope ingestion to a subdirectory.<br/>
        /// Example: /Contracts/2026
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharepointSourceConfiguration(
            string type,
            string siteUrl,
            string tenantId,
            string clientId,
            string? clientSecret,
            string? driveId,
            string? folderPath)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SiteUrl = siteUrl ?? throw new global::System.ArgumentNullException(nameof(siteUrl));
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.DriveId = driveId;
            this.FolderPath = folderPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointSourceConfiguration" /> class.
        /// </summary>
        public SharepointSourceConfiguration()
        {
        }
    }
}