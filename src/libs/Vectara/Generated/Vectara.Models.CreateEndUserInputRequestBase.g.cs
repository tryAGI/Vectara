
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all end-user input kinds.
    /// </summary>
    public sealed partial class CreateEndUserInputRequestBase
    {
        /// <summary>
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserInputRequestBase" /> class.
        /// </summary>
        /// <param name="streamResponse">
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEndUserInputRequestBase(
            bool? streamResponse)
        {
            this.StreamResponse = streamResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEndUserInputRequestBase" /> class.
        /// </summary>
        public CreateEndUserInputRequestBase()
        {
        }

    }
}