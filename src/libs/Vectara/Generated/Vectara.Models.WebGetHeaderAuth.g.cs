
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Static custom-header authentication, suitable for API keys.
    /// </summary>
    public sealed partial class WebGetHeaderAuth
    {
        /// <summary>
        /// Default Value: header<br/>
        /// Example: header
        /// </summary>
        /// <default>"header"</default>
        /// <example>header</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "header";

        /// <summary>
        /// The header name to set (e.g. `X-API-Key`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Header { get; set; }

        /// <summary>
        /// The header value. May be an EagerReference to an agent secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetHeaderAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: header<br/>
        /// Example: header
        /// </param>
        /// <param name="header">
        /// The header name to set (e.g. `X-API-Key`).
        /// </param>
        /// <param name="value">
        /// The header value. May be an EagerReference to an agent secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetHeaderAuth(
            string type,
            string header,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> value)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Header = header ?? throw new global::System.ArgumentNullException(nameof(header));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetHeaderAuth" /> class.
        /// </summary>
        public WebGetHeaderAuth()
        {
        }

    }
}