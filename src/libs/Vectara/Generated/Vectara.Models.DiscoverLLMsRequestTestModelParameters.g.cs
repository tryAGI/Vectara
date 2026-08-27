
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Extra parameters passed to the live verification call (e.g. `max_tokens` for providers that require it).<br/>
    /// Example: {"max_tokens":512}
    /// </summary>
    public sealed partial class DiscoverLLMsRequestTestModelParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}