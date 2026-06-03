
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Additional HTTP headers configured for requests to the LLM API. Not applicable to `vertex-ai`.
    /// </summary>
    public sealed partial class LlmHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}