
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Identifies the organization providing the v1 agent.
    /// </summary>
    public sealed partial class A2aV1AgentProvider
    {
        /// <summary>
        /// URL of the provider's website or homepage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Name of the organization providing the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentProvider" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the provider's website or homepage.
        /// </param>
        /// <param name="organization">
        /// Name of the organization providing the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1AgentProvider(
            string url,
            string organization)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1AgentProvider" /> class.
        /// </summary>
        public A2aV1AgentProvider()
        {
        }

    }
}