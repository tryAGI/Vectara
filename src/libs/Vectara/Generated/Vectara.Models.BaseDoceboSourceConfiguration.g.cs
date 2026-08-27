
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base Docebo source configuration. Ingests the course catalog of a Docebo LMS instance through the<br/>
    /// Learn REST API. Each course becomes one document carrying its description, skills, and<br/>
    /// instructors, with its category, language, and course type as document metadata for<br/>
    /// attribute-based filtering.<br/>
    /// Only courses are ingested; the contents of their training materials are not. Each course document<br/>
    /// includes a curriculum outline listing the title, type, and description of every training material.
    /// </summary>
    public sealed partial class BaseDoceboSourceConfiguration
    {
        /// <summary>
        /// Default Value: docebo<br/>
        /// Example: docebo
        /// </summary>
        /// <default>"docebo"</default>
        /// <example>docebo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "docebo";

        /// <summary>
        /// Base URL of the Docebo instance. The Learn API paths are appended automatically and must not<br/>
        /// be included.<br/>
        /// Example: https://example.docebosaas.com
        /// </summary>
        /// <example>https://example.docebosaas.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Authentication configuration for connecting to a remote service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter))]
        public global::Vectara.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Restricts ingestion to published courses, skipping any course Docebo reports as unpublished.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_only")]
        public bool? PublishedOnly { get; set; }

        /// <summary>
        /// Docebo language codes to ingest, for example `english` or `japanese`, matched<br/>
        /// case-insensitively. A course in a language that is not listed is skipped. A Docebo catalog<br/>
        /// commonly carries the same course once per translation, so this selects which translations<br/>
        /// are ingested. Empty (the default) ingests every language.<br/>
        /// Example: [english]
        /// </summary>
        /// <example>[english]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_languages")]
        public global::System.Collections.Generic.IList<string>? IncludeLanguages { get; set; }

        /// <summary>
        /// Docebo language codes whose courses are excluded from ingestion, even when they also match<br/>
        /// `include_languages`. Empty (the default) excludes nothing.<br/>
        /// Example: [japanese]
        /// </summary>
        /// <example>[japanese]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_languages")]
        public global::System.Collections.Generic.IList<string>? ExcludeLanguages { get; set; }

        /// <summary>
        /// Docebo category names to ingest, matched case-insensitively. A course in a category that is<br/>
        /// not listed is skipped, as is a course with no category at all. Empty (the default) ingests<br/>
        /// every category, including courses with no category.<br/>
        /// Example: [Product training]
        /// </summary>
        /// <example>[Product training]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_categories")]
        public global::System.Collections.Generic.IList<string>? IncludeCategories { get; set; }

        /// <summary>
        /// Docebo category names whose courses are excluded from ingestion, even when they also match<br/>
        /// `include_categories`. Empty (the default) excludes nothing.<br/>
        /// Example: [Internal]
        /// </summary>
        /// <example>[Internal]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_categories")]
        public global::System.Collections.Generic.IList<string>? ExcludeCategories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDoceboSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: docebo<br/>
        /// Example: docebo
        /// </param>
        /// <param name="baseUrl">
        /// Base URL of the Docebo instance. The Learn API paths are appended automatically and must not<br/>
        /// be included.<br/>
        /// Example: https://example.docebosaas.com
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for connecting to a remote service.
        /// </param>
        /// <param name="publishedOnly">
        /// Restricts ingestion to published courses, skipping any course Docebo reports as unpublished.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeLanguages">
        /// Docebo language codes to ingest, for example `english` or `japanese`, matched<br/>
        /// case-insensitively. A course in a language that is not listed is skipped. A Docebo catalog<br/>
        /// commonly carries the same course once per translation, so this selects which translations<br/>
        /// are ingested. Empty (the default) ingests every language.<br/>
        /// Example: [english]
        /// </param>
        /// <param name="excludeLanguages">
        /// Docebo language codes whose courses are excluded from ingestion, even when they also match<br/>
        /// `include_languages`. Empty (the default) excludes nothing.<br/>
        /// Example: [japanese]
        /// </param>
        /// <param name="includeCategories">
        /// Docebo category names to ingest, matched case-insensitively. A course in a category that is<br/>
        /// not listed is skipped, as is a course with no category at all. Empty (the default) ingests<br/>
        /// every category, including courses with no category.<br/>
        /// Example: [Product training]
        /// </param>
        /// <param name="excludeCategories">
        /// Docebo category names whose courses are excluded from ingestion, even when they also match<br/>
        /// `include_categories`. Empty (the default) excludes nothing.<br/>
        /// Example: [Internal]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseDoceboSourceConfiguration(
            string type,
            string? baseUrl,
            global::Vectara.RemoteAuth? auth,
            bool? publishedOnly,
            global::System.Collections.Generic.IList<string>? includeLanguages,
            global::System.Collections.Generic.IList<string>? excludeLanguages,
            global::System.Collections.Generic.IList<string>? includeCategories,
            global::System.Collections.Generic.IList<string>? excludeCategories)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.BaseUrl = baseUrl;
            this.Auth = auth;
            this.PublishedOnly = publishedOnly;
            this.IncludeLanguages = includeLanguages;
            this.ExcludeLanguages = excludeLanguages;
            this.IncludeCategories = includeCategories;
            this.ExcludeCategories = excludeCategories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDoceboSourceConfiguration" /> class.
        /// </summary>
        public BaseDoceboSourceConfiguration()
        {
        }

    }
}