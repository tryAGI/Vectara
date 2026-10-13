
#nullable enable

namespace Vectara
{
    /// <summary>
    /// An artifact in an agent session, to share into the session that receives the input.
    /// </summary>
    public sealed partial class SessionArtifactReference
    {
        /// <summary>
        /// The agent of the session that holds the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// The session that holds the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionKey { get; set; }

        /// <summary>
        /// The artifact to share.<br/>
        /// Example: art_diff_txt_91c3
        /// </summary>
        /// <example>art_diff_txt_91c3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtifactId { get; set; }

        /// <summary>
        /// Why the artifact is being shared. The agent sees it alongside the artifact.<br/>
        /// Example: The diff to review
        /// </summary>
        /// <example>The diff to review</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionArtifactReference" /> class.
        /// </summary>
        /// <param name="agentKey">
        /// The agent of the session that holds the artifact.
        /// </param>
        /// <param name="sessionKey">
        /// The session that holds the artifact.
        /// </param>
        /// <param name="artifactId">
        /// The artifact to share.<br/>
        /// Example: art_diff_txt_91c3
        /// </param>
        /// <param name="purpose">
        /// Why the artifact is being shared. The agent sees it alongside the artifact.<br/>
        /// Example: The diff to review
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionArtifactReference(
            string agentKey,
            string sessionKey,
            string artifactId,
            string? purpose)
        {
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.SessionKey = sessionKey ?? throw new global::System.ArgumentNullException(nameof(sessionKey));
            this.ArtifactId = artifactId ?? throw new global::System.ArgumentNullException(nameof(artifactId));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionArtifactReference" /> class.
        /// </summary>
        public SessionArtifactReference()
        {
        }

    }
}