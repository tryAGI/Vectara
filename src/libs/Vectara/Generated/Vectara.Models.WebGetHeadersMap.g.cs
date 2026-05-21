
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A map of HTTP header names to their values for the web_get tool. Each value may be a<br/>
    /// literal string or an EagerReference for per-header secret resolution.
    /// </summary>
    public sealed partial class WebGetHeadersMap
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}