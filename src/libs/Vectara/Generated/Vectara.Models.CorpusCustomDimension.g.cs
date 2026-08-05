
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A custom dimension attached to all document parts in a corpus. Custom dimensions allow arbitrary modification of the search score.
    /// </summary>
    public sealed partial class CorpusCustomDimension
    {
        /// <summary>
        /// The name of the custom dimension.<br/>
        /// Example: importance
        /// </summary>
        /// <example>importance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the custom dimension.<br/>
        /// Example: Product importance.
        /// </summary>
        /// <example>Product importance.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The default value of a custom dimension on a document part. This value applies when the custom dimension value is not specified at indexing time. A value of 0 means that the custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_default")]
        public double? IndexingDefault { get; set; }

        /// <summary>
        /// The default value of a custom dimension for a query. This value applies when the custom dimension value is not specified in the query. A value of 0 means that the custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("querying_default")]
        public double? QueryingDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusCustomDimension" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the custom dimension.<br/>
        /// Example: importance
        /// </param>
        /// <param name="description">
        /// Description of the custom dimension.<br/>
        /// Example: Product importance.
        /// </param>
        /// <param name="indexingDefault">
        /// The default value of a custom dimension on a document part. This value applies when the custom dimension value is not specified at indexing time. A value of 0 means that the custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="queryingDefault">
        /// The default value of a custom dimension for a query. This value applies when the custom dimension value is not specified in the query. A value of 0 means that the custom dimension is not considered.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorpusCustomDimension(
            string name,
            string? description,
            double? indexingDefault,
            double? queryingDefault)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IndexingDefault = indexingDefault;
            this.QueryingDefault = queryingDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusCustomDimension" /> class.
        /// </summary>
        public CorpusCustomDimension()
        {
        }

    }
}