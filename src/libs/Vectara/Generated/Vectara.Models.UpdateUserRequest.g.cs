
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update an existing user's properties or permissions.
    /// </summary>
    public sealed partial class UpdateUserRequest
    {
        /// <summary>
        /// Indicates whether to enable or disable the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The new customer-level role names of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::Vectara.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// New corpus-specific role assignments for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_roles")]
        public global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? CorpusRoles { get; set; }

        /// <summary>
        /// New agent-specific role assignments for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_roles")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentRole>? AgentRoles { get; set; }

        /// <summary>
        /// The description of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the user. Replaces the stored metadata entirely; it is not merged. Omit the field to leave it unchanged, or set it to null to clear it. The JSON serialization must not exceed 65535 bytes; larger payloads are rejected with a `400` response.<br/>
        /// Example: {"console_mode":"business"}
        /// </summary>
        /// <example>{"console_mode":"business"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates whether to enable or disable the user.
        /// </param>
        /// <param name="apiRoles">
        /// The new customer-level role names of the user.
        /// </param>
        /// <param name="corpusRoles">
        /// New corpus-specific role assignments for the user.
        /// </param>
        /// <param name="agentRoles">
        /// New agent-specific role assignments for the user.
        /// </param>
        /// <param name="description">
        /// The description of the user.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the user. Replaces the stored metadata entirely; it is not merged. Omit the field to leave it unchanged, or set it to null to clear it. The JSON serialization must not exceed 65535 bytes; larger payloads are rejected with a `400` response.<br/>
        /// Example: {"console_mode":"business"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserRequest(
            bool? enabled,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole>? apiRoles,
            global::System.Collections.Generic.IList<global::Vectara.CorpusRole>? corpusRoles,
            global::System.Collections.Generic.IList<global::Vectara.AgentRole>? agentRoles,
            string? description,
            object? metadata)
        {
            this.Enabled = enabled;
            this.ApiRoles = apiRoles;
            this.CorpusRoles = corpusRoles;
            this.AgentRoles = agentRoles;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest" /> class.
        /// </summary>
        public UpdateUserRequest()
        {
        }

    }
}