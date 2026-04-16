
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response containing a list of pipelines.
    /// </summary>
    public sealed partial class ListPipelinesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.Pipeline> Pipelines { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.ListMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelinesResponse" /> class.
        /// </summary>
        /// <param name="pipelines"></param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPipelinesResponse(
            global::System.Collections.Generic.IList<global::Vectara.Pipeline> pipelines,
            global::Vectara.ListMetadata metadata)
        {
            this.Pipelines = pipelines ?? throw new global::System.ArgumentNullException(nameof(pipelines));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelinesResponse" /> class.
        /// </summary>
        public ListPipelinesResponse()
        {
        }
    }
}