
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base SCIM source configuration. Ingests user records from a SCIM 2.0 service provider<br/>
    /// through the Users endpoint. Each user becomes one document carrying profile, group<br/>
    /// membership, and enterprise attributes as document metadata for attribute-based filtering.
    /// </summary>
    public sealed partial class BaseScimSourceConfiguration
    {
        /// <summary>
        /// Default Value: scim<br/>
        /// Example: scim
        /// </summary>
        /// <default>"scim"</default>
        /// <example>scim</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "scim";

        /// <summary>
        /// Base URL of the SCIM 2.0 service provider. The Users resource path is appended<br/>
        /// automatically and must not be included.<br/>
        /// Example: https://example.okta.com/scim/v2
        /// </summary>
        /// <example>https://example.okta.com/scim/v2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Authentication configuration for connecting to a remote service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.RemoteAuthJsonConverter))]
        public global::Vectara.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// SCIM filter expression applied to the user listing, restricting which users are<br/>
        /// ingested. Requires a service provider that supports the filter query parameter.<br/>
        /// When `incremental_strategy` is `last_modified_filter`, the change window is combined<br/>
        /// with this expression.<br/>
        /// Example: userType eq "Employee"
        /// </summary>
        /// <example>userType eq "Employee"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Attribute names to request from the service provider, passed as the SCIM attributes<br/>
        /// query parameter. The meta attribute is always requested so that incremental sync can<br/>
        /// read each user's meta.lastModified timestamp. When unset, the service provider<br/>
        /// returns its default attribute set. Returned attributes land in two places on each<br/>
        /// record. They are rendered into the user's profile document, which is what the agent<br/>
        /// converts and indexes, and they populate the record's source_record_metadata in the<br/>
        /// agent session metadata, where they are available for attribute based filtering and<br/>
        /// for tool argument overrides. Narrowing this list therefore narrows both what is<br/>
        /// indexed and what is available as metadata. An attribute the service provider marks<br/>
        /// as returned only on request is included only when named here.<br/>
        /// Example: [userName, name, emails, groups, active]
        /// </summary>
        /// <example>[userName, name, emails, groups, active]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<string>? Attributes { get; set; }

        /// <summary>
        /// How incremental syncs detect changed users. `last_modified_filter` pushes the change<br/>
        /// window into the SCIM filter query parameter as a `meta.lastModified` range.<br/>
        /// `client_side` enumerates every user on each run and evaluates the change window<br/>
        /// locally. Support for the filter query parameter is optional in the SCIM 2.0<br/>
        /// specification, so set `client_side` when the service provider does not support<br/>
        /// filtering on `meta.lastModified`.<br/>
        /// Default Value: last_modified_filter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incremental_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.BaseScimSourceConfigurationIncrementalStrategyJsonConverter))]
        public global::Vectara.BaseScimSourceConfigurationIncrementalStrategy? IncrementalStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseScimSourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: scim<br/>
        /// Example: scim
        /// </param>
        /// <param name="baseUrl">
        /// Base URL of the SCIM 2.0 service provider. The Users resource path is appended<br/>
        /// automatically and must not be included.<br/>
        /// Example: https://example.okta.com/scim/v2
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for connecting to a remote service.
        /// </param>
        /// <param name="filter">
        /// SCIM filter expression applied to the user listing, restricting which users are<br/>
        /// ingested. Requires a service provider that supports the filter query parameter.<br/>
        /// When `incremental_strategy` is `last_modified_filter`, the change window is combined<br/>
        /// with this expression.<br/>
        /// Example: userType eq "Employee"
        /// </param>
        /// <param name="attributes">
        /// Attribute names to request from the service provider, passed as the SCIM attributes<br/>
        /// query parameter. The meta attribute is always requested so that incremental sync can<br/>
        /// read each user's meta.lastModified timestamp. When unset, the service provider<br/>
        /// returns its default attribute set. Returned attributes land in two places on each<br/>
        /// record. They are rendered into the user's profile document, which is what the agent<br/>
        /// converts and indexes, and they populate the record's source_record_metadata in the<br/>
        /// agent session metadata, where they are available for attribute based filtering and<br/>
        /// for tool argument overrides. Narrowing this list therefore narrows both what is<br/>
        /// indexed and what is available as metadata. An attribute the service provider marks<br/>
        /// as returned only on request is included only when named here.<br/>
        /// Example: [userName, name, emails, groups, active]
        /// </param>
        /// <param name="incrementalStrategy">
        /// How incremental syncs detect changed users. `last_modified_filter` pushes the change<br/>
        /// window into the SCIM filter query parameter as a `meta.lastModified` range.<br/>
        /// `client_side` enumerates every user on each run and evaluates the change window<br/>
        /// locally. Support for the filter query parameter is optional in the SCIM 2.0<br/>
        /// specification, so set `client_side` when the service provider does not support<br/>
        /// filtering on `meta.lastModified`.<br/>
        /// Default Value: last_modified_filter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseScimSourceConfiguration(
            string type,
            string? baseUrl,
            global::Vectara.RemoteAuth? auth,
            string? filter,
            global::System.Collections.Generic.IList<string>? attributes,
            global::Vectara.BaseScimSourceConfigurationIncrementalStrategy? incrementalStrategy)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.BaseUrl = baseUrl;
            this.Auth = auth;
            this.Filter = filter;
            this.Attributes = attributes;
            this.IncrementalStrategy = incrementalStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseScimSourceConfiguration" /> class.
        /// </summary>
        public BaseScimSourceConfiguration()
        {
        }

    }
}