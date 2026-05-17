
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Static bearer token authentication. Adds `Authorization: Bearer &lt;token&gt;`.
    /// </summary>
    public sealed partial class WebGetBearerAuth
    {
        /// <summary>
        /// Default Value: bearer<br/>
        /// Example: bearer
        /// </summary>
        /// <default>"bearer"</default>
        /// <example>bearer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "bearer";

        /// <summary>
        /// The bearer token. May be an EagerReference to an agent secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetBearerAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: bearer<br/>
        /// Example: bearer
        /// </param>
        /// <param name="token">
        /// The bearer token. May be an EagerReference to an agent secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetBearerAuth(
            string type,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> token)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetBearerAuth" /> class.
        /// </summary>
        public WebGetBearerAuth()
        {
        }

    }
}