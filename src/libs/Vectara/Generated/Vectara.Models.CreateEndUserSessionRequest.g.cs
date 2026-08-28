
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a session as an end user. The owning principal comes from the caller's authenticated identity.<br/>
    /// The session binds to the addressed alias's widget connector — an alias has exactly one — which fixes the session's widget behavior for its lifetime:<br/>
    /// the widget's `session_tti_minutes` sets the idle lifetime, and event reads through the session use the widget's `revealed_output_types`. The widget must<br/>
    /// be enabled, or the request is rejected with `400`, as it is when the alias has no widget connector at all.
    /// </summary>
    public sealed partial class CreateEndUserSessionRequest
    {
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
            string? name,
            string? description)
        {
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