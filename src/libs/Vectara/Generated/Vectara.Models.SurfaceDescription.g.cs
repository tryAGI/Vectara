
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Identifies the surface submitting this input, such as a connector. The `(type, id)` pair identifies the surface within the session; repeat submissions from the same pair are treated as one surface. All fields are optional; a caller that omits `type` is treated as an `api` surface.
    /// </summary>
    public sealed partial class SurfaceDescription
    {
        /// <summary>
        /// The kind of surface the input came from, so the agent knows where its reply will be seen and can shape it for that surface — a free-form label, not a fixed set. Connectors send "slack", "gchat", or "zoom"; API callers may send a label describing their own surface. Treated as "api" when omitted.<br/>
        /// Example: slack
        /// </summary>
        /// <example>slack</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// An identifier for this surface within its `type`, e.g. a connector id. Combined with `type` to identify the surface within the session.<br/>
        /// Example: con_slack_support
        /// </summary>
        /// <example>con_slack_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// When true, the agent is told which listeners — surfaces currently streaming this session — will see this turn's response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public bool? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceDescription" /> class.
        /// </summary>
        /// <param name="type">
        /// The kind of surface the input came from, so the agent knows where its reply will be seen and can shape it for that surface — a free-form label, not a fixed set. Connectors send "slack", "gchat", or "zoom"; API callers may send a label describing their own surface. Treated as "api" when omitted.<br/>
        /// Example: slack
        /// </param>
        /// <param name="id">
        /// An identifier for this surface within its `type`, e.g. a connector id. Combined with `type` to identify the surface within the session.<br/>
        /// Example: con_slack_support
        /// </param>
        /// <param name="include">
        /// When true, the agent is told which listeners — surfaces currently streaming this session — will see this turn's response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SurfaceDescription(
            string? type,
            string? id,
            bool? include)
        {
            this.Type = type;
            this.Id = id;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceDescription" /> class.
        /// </summary>
        public SurfaceDescription()
        {
        }

    }
}