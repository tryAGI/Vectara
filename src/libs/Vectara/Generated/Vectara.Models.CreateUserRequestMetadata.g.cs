
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arbitrary metadata associated with the user. The JSON serialization must not exceed 65535 bytes; larger payloads are rejected with a `400` response.<br/>
    /// Default Value: {}<br/>
    /// Example: {"console_mode":"business"}
    /// </summary>
    public sealed partial class CreateUserRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}