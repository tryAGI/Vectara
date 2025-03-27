
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response containing a list of turns (message exchanges) within a chat conversation.
    /// </summary>
    public sealed partial class ListChatTurnsResponse
    {
        /// <summary>
        /// List of turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        public global::System.Collections.Generic.IList<global::Vectara.Turn>? Turns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatTurnsResponse" /> class.
        /// </summary>
        /// <param name="turns">
        /// List of turns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListChatTurnsResponse(
            global::System.Collections.Generic.IList<global::Vectara.Turn>? turns)
        {
            this.Turns = turns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatTurnsResponse" /> class.
        /// </summary>
        public ListChatTurnsResponse()
        {
        }
    }
}