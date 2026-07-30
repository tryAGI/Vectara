
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v0.3 structured-data part. The `data` field is an arbitrary JSON object.
    /// </summary>
    public sealed partial class A2aV03DataPart
    {
        /// <summary>
        /// Arbitrary structured JSON object payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03DataPart" /> class.
        /// </summary>
        /// <param name="data">
        /// Arbitrary structured JSON object payload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV03DataPart(
            object data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV03DataPart" /> class.
        /// </summary>
        public A2aV03DataPart()
        {
        }

    }
}