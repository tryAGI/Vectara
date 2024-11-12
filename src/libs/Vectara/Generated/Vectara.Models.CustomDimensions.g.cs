
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The custom dimensions as additional weights.
    /// </summary>
    public sealed partial class CustomDimensions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDimensions" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomDimensions(
 )
        {
        }
    }
}