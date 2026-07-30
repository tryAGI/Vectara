
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Authentication parameters for the agent to use when pushing task updates to a webhook.
    /// </summary>
    public sealed partial class A2aV03AuthenticationInfo
    {
        /// <summary>
        /// Supported authentication scheme names the agent may use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemes { get; set; }

        /// <summary>
        /// Optional credentials passed to the webhook for the listed schemes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public string? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AuthenticationInfo" /> class.
        /// </summary>
        /// <param name="schemes">
        /// Supported authentication scheme names the agent may use.
        /// </param>
        /// <param name="credentials">
        /// Optional credentials passed to the webhook for the listed schemes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03AuthenticationInfo(
            global::System.Collections.Generic.IList<string> schemes,
            string? credentials)
        {
            this.Schemes = schemes ?? throw new global::System.ArgumentNullException(nameof(schemes));
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03AuthenticationInfo" /> class.
        /// </summary>
        public A2aV03AuthenticationInfo()
        {
        }

    }
}