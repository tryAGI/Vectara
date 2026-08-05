
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplaceAgentRequestVariant2
    {
        /// <summary>
        /// Timestamp when the agent was created. Set by the platform; any value provided in the request body is ignored.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the agent was last updated. Set by the platform on every write; any value provided in the request body is ignored.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </summary>
        /// <example>2024-01-16T14:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAgentRequestVariant2" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Timestamp when the agent was created. Set by the platform; any value provided in the request body is ignored.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the agent was last updated. Set by the platform on every write; any value provided in the request body is ignored.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceAgentRequestVariant2(
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceAgentRequestVariant2" /> class.
        /// </summary>
        public ReplaceAgentRequestVariant2()
        {
        }

    }
}