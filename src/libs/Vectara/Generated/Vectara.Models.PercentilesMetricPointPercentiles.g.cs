
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Map of percentile label to value. Keys follow the `p&lt;N&gt;` convention (e.g. `p50`, `p99`, `p99_9` for the 99.9th percentile).
    /// </summary>
    public sealed partial class PercentilesMetricPointPercentiles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}