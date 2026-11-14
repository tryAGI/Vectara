
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The account's usage of everything the platform measures or counts for it.
    /// </summary>
    public sealed partial class ListUsagesResponse
    {
        /// <summary>
        /// One entry per thing measured or counted, and per window it is counted over. Entries may be added as the platform tracks more, so clients should show an entry of a `type` they do not know from its `unit`, `amount` and `allowance` alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.Usage> Usages { get; set; }

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
        /// Initializes a new instance of the <see cref="ListUsagesResponse" /> class.
        /// </summary>
        /// <param name="usages">
        /// One entry per thing measured or counted, and per window it is counted over. Entries may be added as the platform tracks more, so clients should show an entry of a `type` they do not know from its `unit`, `amount` and `allowance` alone.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListUsagesResponse(
            global::System.Collections.Generic.IList<global::Vectara.Usage> usages,
            global::Vectara.ListMetadata metadata)
        {
            this.Usages = usages ?? throw new global::System.ArgumentNullException(nameof(usages));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListUsagesResponse" /> class.
        /// </summary>
        public ListUsagesResponse()
        {
        }

    }
}