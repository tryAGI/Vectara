
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A map of terms to their expanded forms. Keys are terms (1–200 characters);<br/>
    /// values are expansions (1–1000 characters).<br/>
    /// Example: {"k8s":"Kubernetes","tf":"Terraform"}
    /// </summary>
    public sealed partial class UpsertGlossaryEntriesRequestEntries
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}