
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTurnRequest
    {
        /// <summary>
        /// Indicates whether to disable a turn. It will disable this turn and all subsequent turns.<br/>
        /// Enabling a turn is not implemented.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}