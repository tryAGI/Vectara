
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Arbitrary object of document level metadata. Properties of this object<br/>
    /// can be used by document filters if defined as a corpus filter attribute.
    /// </summary>
    public sealed partial class CoreDocumentMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDocumentMetadata" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CoreDocumentMetadata(
 )
        {
        }
    }
}