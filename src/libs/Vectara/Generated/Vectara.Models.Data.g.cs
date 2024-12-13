
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The data of a table.
    /// </summary>
    public sealed partial class Data
    {
        /// <summary>
        /// The headers of the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Vectara.Cell>>? Headers { get; set; }

        /// <summary>
        /// The rows in the data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Vectara.Cell>>? Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        /// <param name="headers">
        /// The headers of the table.
        /// </param>
        /// <param name="rows">
        /// The rows in the data.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Data(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Vectara.Cell>>? headers,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Vectara.Cell>>? rows)
        {
            this.Headers = headers;
            this.Rows = rows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        public Data()
        {
        }
    }
}