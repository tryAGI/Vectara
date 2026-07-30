
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Authentication details the agent uses when calling the v1 push-notification URL.
    /// </summary>
    public sealed partial class A2aV1AuthenticationInfo
    {
        /// <summary>
        /// The authentication scheme name the agent uses for the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scheme { get; set; }

        /// <summary>
        /// Optional credentials passed to the webhook for the scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public string? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AuthenticationInfo" /> class.
        /// </summary>
        /// <param name="scheme">
        /// The authentication scheme name the agent uses for the webhook.
        /// </param>
        /// <param name="credentials">
        /// Optional credentials passed to the webhook for the scheme.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AuthenticationInfo(
            string scheme,
            string? credentials)
        {
            this.Scheme = scheme ?? throw new global::System.ArgumentNullException(nameof(scheme));
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AuthenticationInfo" /> class.
        /// </summary>
        public A2aV1AuthenticationInfo()
        {
        }

    }
}