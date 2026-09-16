
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a session as an end user. The owning principal comes from the caller's authenticated identity; ownership binds to the addressed alias.<br/>
    /// The session binds to the connector named by `connector_id`, which fixes the session's widget behavior for its lifetime:<br/>
    /// the widget's `session_tti_minutes` sets the idle lifetime, and event reads through the session use the widget's `revealed_output_types`.<br/>
    /// The named connector must be enabled, belong to the addressed alias, and front an end-user surface (a widget connector), or the request is rejected with `400`.<br/>
    /// For an anonymous caller, the named connector must admit anonymous visitors (`public_access`), or the request is rejected with `403`. The visitor id is customer-scoped, so it need not have been minted through the named connector:<br/>
    /// widget connectors on the same alias that admit anonymous visitors form one anonymous trust boundary, since naming any of them grants exactly what minting through it directly would grant.
    /// </summary>
    public sealed partial class CreateEndUserSessionRequest
    {
        /// <summary>
        /// The globally unique identifier of a connector.<br/>
        /// Example: con_support_9f3a1c2b4d5e6f708192a3b4c5d6e7f8
        /// </summary>
        /// <example>con_support_9f3a1c2b4d5e6f708192a3b4c5d6e7f8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// Human-readable name for the session. Platform-generated if omitted.<br/>
        /// Example: Customer Support Session
        /// </summary>
        /// <example>Customer Support Session</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A short description of the session's purpose. If omitted, the platform generates one after the agent produces events.<br/>
        /// Example: Helping customer troubleshoot widget installation issues
        /// </summary>
        /// <example>Helping customer troubleshoot widget installation issues</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserSessionRequest" /> class.
        /// </summary>
        /// <param name="connectorId">
        /// The globally unique identifier of a connector.<br/>
        /// Example: con_support_9f3a1c2b4d5e6f708192a3b4c5d6e7f8
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session. Platform-generated if omitted.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// A short description of the session's purpose. If omitted, the platform generates one after the agent produces events.<br/>
        /// Example: Helping customer troubleshoot widget installation issues
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEndUserSessionRequest(
            string connectorId,
            string? name,
            string? description)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserSessionRequest" /> class.
        /// </summary>
        public CreateEndUserSessionRequest()
        {
        }

    }
}