
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The standard metadata in the response of a list operation.
    /// </summary>
    public sealed partial class ListMetadata
    {
        /// <summary>
        /// When requesting the next page of this list, this is needed as a query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_key")]
        public string? PageKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetadata" /> class.
        /// </summary>
        /// <param name="pageKey">
        /// When requesting the next page of this list, this is needed as a query parameter.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListMetadata(
            string? pageKey)
        {
            this.PageKey = pageKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMetadata" /> class.
        /// </summary>
        public ListMetadata()
        {
        }
    }
}