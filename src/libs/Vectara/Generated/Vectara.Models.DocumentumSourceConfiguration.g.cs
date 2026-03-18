
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting documents from OpenText Documentum.
    /// </summary>
    public sealed partial class DocumentumSourceConfiguration
    {
        /// <summary>
        /// Default Value: documentum<br/>
        /// Example: documentum
        /// </summary>
        /// <default>"documentum"</default>
        /// <example>documentum</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "documentum";

        /// <summary>
        /// The Documentum REST API base URL.<br/>
        /// Example: https://documentum.example.com/dctm-rest
        /// </summary>
        /// <example>https://documentum.example.com/dctm-rest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// The Documentum repository name.<br/>
        /// Example: my_repo
        /// </summary>
        /// <example>my_repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repository { get; set; }

        /// <summary>
        /// Documentum username for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Documentum password. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Optional cabinet or folder path to scope ingestion.<br/>
        /// Example: /Legal/Contracts
        /// </summary>
        /// <example>/Legal/Contracts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cabinet_path")]
        public string? CabinetPath { get; set; }

        /// <summary>
        /// Optional DQL qualification to filter documents (e.g. type or date constraints).<br/>
        /// Example: r_modify_date &gt; DATE('2026-01-01','yyyy-mm-dd')
        /// </summary>
        /// <example>r_modify_date &gt; DATE('2026-01-01','yyyy-mm-dd')</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dql_filter")]
        public string? DqlFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentumSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: documentum<br/>
        /// Example: documentum
        /// </param>
        /// <param name="baseUrl">
        /// The Documentum REST API base URL.<br/>
        /// Example: https://documentum.example.com/dctm-rest
        /// </param>
        /// <param name="repository">
        /// The Documentum repository name.<br/>
        /// Example: my_repo
        /// </param>
        /// <param name="username">
        /// Documentum username for authentication.
        /// </param>
        /// <param name="password">
        /// Documentum password. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="cabinetPath">
        /// Optional cabinet or folder path to scope ingestion.<br/>
        /// Example: /Legal/Contracts
        /// </param>
        /// <param name="dqlFilter">
        /// Optional DQL qualification to filter documents (e.g. type or date constraints).<br/>
        /// Example: r_modify_date &gt; DATE('2026-01-01','yyyy-mm-dd')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentumSourceConfiguration(
            string type,
            string baseUrl,
            string repository,
            string username,
            string? password,
            string? cabinetPath,
            string? dqlFilter)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password;
            this.CabinetPath = cabinetPath;
            this.DqlFilter = dqlFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentumSourceConfiguration" /> class.
        /// </summary>
        public DocumentumSourceConfiguration()
        {
        }
    }
}