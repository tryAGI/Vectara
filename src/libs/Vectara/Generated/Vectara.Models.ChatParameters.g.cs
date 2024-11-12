
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Parameters to control chat behavior.
    /// </summary>
    public sealed partial class ChatParameters
    {
        /// <summary>
        /// Indicates whether to store chat messages and response messages.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatParameters" /> class.
        /// </summary>
        /// <param name="store">
        /// Indicates whether to store chat messages and response messages.<br/>
        /// Default Value: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatParameters(
            bool? store)
        {
            this.Store = store;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatParameters" /> class.
        /// </summary>
        public ChatParameters()
        {
        }
    }
}