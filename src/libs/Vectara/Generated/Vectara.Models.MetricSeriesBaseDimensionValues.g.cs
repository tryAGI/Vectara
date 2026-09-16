
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The dimension values identifying this series, keyed by dimension name. Echoes the `dimensions` filter supplied in the request. A dimension absent from the map was not filtered, so the series merges every value of it.
    /// </summary>
    public sealed partial class MetricSeriesBaseDimensionValues
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}