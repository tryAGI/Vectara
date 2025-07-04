
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A table in a document.
    /// </summary>
    public sealed partial class Table
    {
        /// <summary>
        /// The unique ID of the table within the document.<br/>
        /// Example: billing_table_111
        /// </summary>
        /// <example>billing_table_111</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The title of the table.<br/>
        /// Example: Carbon Reduction Metrics
        /// </summary>
        /// <example>Carbon Reduction Metrics</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The data of a table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Vectara.Data? Data { get; set; }

        /// <summary>
        /// The description of the table.<br/>
        /// Example: Summary of carbon reduction efforts by EU banks in 2023.
        /// </summary>
        /// <example>Summary of carbon reduction efforts by EU banks in 2023.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the table within the document.<br/>
        /// Example: billing_table_111
        /// </param>
        /// <param name="title">
        /// The title of the table.<br/>
        /// Example: Carbon Reduction Metrics
        /// </param>
        /// <param name="data">
        /// The data of a table.
        /// </param>
        /// <param name="description">
        /// The description of the table.<br/>
        /// Example: Summary of carbon reduction efforts by EU banks in 2023.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Table(
            string? id,
            string? title,
            global::Vectara.Data? data,
            string? description)
        {
            this.Id = id;
            this.Title = title;
            this.Data = data;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        public Table()
        {
        }
    }
}