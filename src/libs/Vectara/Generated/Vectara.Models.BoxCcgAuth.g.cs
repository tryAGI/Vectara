
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Box server-to-server authentication via the Client Credentials Grant. The app must be<br/>
    /// authorized for the enterprise in the Box Admin Console.
    /// </summary>
    public sealed partial class BoxCcgAuth
    {
        /// <summary>
        /// Default Value: ccg<br/>
        /// Example: ccg
        /// </summary>
        /// <default>"ccg"</default>
        /// <example>ccg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "ccg";

        /// <summary>
        /// Box app client ID.<br/>
        /// Example: n3xq8r2v9k5m1p7t4w6yj0zb3c5d7f9g
        /// </summary>
        /// <example>n3xq8r2v9k5m1p7t4w6yj0zb3c5d7f9g</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Box app client secret. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Box enterprise ID the app is authorized for.<br/>
        /// Example: 1234567
        /// </summary>
        /// <example>1234567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnterpriseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoxCcgAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: ccg<br/>
        /// Example: ccg
        /// </param>
        /// <param name="clientId">
        /// Box app client ID.<br/>
        /// Example: n3xq8r2v9k5m1p7t4w6yj0zb3c5d7f9g
        /// </param>
        /// <param name="enterpriseId">
        /// Box enterprise ID the app is authorized for.<br/>
        /// Example: 1234567
        /// </param>
        /// <param name="clientSecret">
        /// Box app client secret. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoxCcgAuth(
            string type,
            string clientId,
            string enterpriseId,
            string? clientSecret)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.EnterpriseId = enterpriseId ?? throw new global::System.ArgumentNullException(nameof(enterpriseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoxCcgAuth" /> class.
        /// </summary>
        public BoxCcgAuth()
        {
        }

    }
}