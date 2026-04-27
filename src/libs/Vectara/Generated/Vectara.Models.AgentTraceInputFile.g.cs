
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Metadata for a file uploaded alongside an agent input message.
    /// </summary>
    public sealed partial class AgentTraceInputFile
    {
        /// <summary>
        /// The original filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The file size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceInputFile" /> class.
        /// </summary>
        /// <param name="name">
        /// The original filename.
        /// </param>
        /// <param name="sizeBytes">
        /// The file size in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTraceInputFile(
            string name,
            long sizeBytes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceInputFile" /> class.
        /// </summary>
        public AgentTraceInputFile()
        {
        }
    }
}