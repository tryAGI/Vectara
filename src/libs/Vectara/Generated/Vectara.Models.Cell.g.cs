
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A cell in a table.
    /// </summary>
    public sealed partial class Cell
    {
        /// <summary>
        /// A text value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_value")]
        public string? TextValue { get; set; }

        /// <summary>
        /// A signed 64-bit integer value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("int_value")]
        public long? IntValue { get; set; }

        /// <summary>
        /// A floating-point value with double precision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float_value")]
        public double? FloatValue { get; set; }

        /// <summary>
        /// A boolean value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bool_value")]
        public bool? BoolValue { get; set; }

        /// <summary>
        /// (Optional) The number of columns the cell spans. Default is 1. Must be greater than 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colspan")]
        public int? Colspan { get; set; }

        /// <summary>
        /// (Optional) The number of rows the cell spans. Default is 1. Must be greater than 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowspan")]
        public int? Rowspan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="textValue">
        /// A text value.
        /// </param>
        /// <param name="intValue">
        /// A signed 64-bit integer value.
        /// </param>
        /// <param name="floatValue">
        /// A floating-point value with double precision.
        /// </param>
        /// <param name="boolValue">
        /// A boolean value.
        /// </param>
        /// <param name="colspan">
        /// (Optional) The number of columns the cell spans. Default is 1. Must be greater than 0.
        /// </param>
        /// <param name="rowspan">
        /// (Optional) The number of rows the cell spans. Default is 1. Must be greater than 0.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Cell(
            string? textValue,
            long? intValue,
            double? floatValue,
            bool? boolValue,
            int? colspan,
            int? rowspan)
        {
            this.TextValue = textValue;
            this.IntValue = intValue;
            this.FloatValue = floatValue;
            this.BoolValue = boolValue;
            this.Colspan = colspan;
            this.Rowspan = rowspan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        public Cell()
        {
        }
    }
}