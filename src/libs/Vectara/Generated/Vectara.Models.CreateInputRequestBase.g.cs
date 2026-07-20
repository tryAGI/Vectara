
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base properties shared by all input request types.
    /// </summary>
    public sealed partial class CreateInputRequestBase
    {
        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Identifies the surface submitting this input, such as a connector. The `(type, id)` pair identifies the surface within the session; repeat submissions from the same pair are treated as one surface. All fields are optional; a caller that omits `type` is treated as an `api` surface.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("surface_description")]
        public global::Vectara.SurfaceDescription? SurfaceDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputRequestBase" /> class.
        /// </summary>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="surfaceDescription">
        /// Identifies the surface submitting this input, such as a connector. The `(type, id)` pair identifies the surface within the session; repeat submissions from the same pair are treated as one surface. All fields are optional; a caller that omits `type` is treated as an `api` surface.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInputRequestBase(
            bool? streamResponse,
            global::Vectara.SurfaceDescription? surfaceDescription)
        {
            this.StreamResponse = streamResponse;
            this.SurfaceDescription = surfaceDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputRequestBase" /> class.
        /// </summary>
        public CreateInputRequestBase()
        {
        }

    }
}