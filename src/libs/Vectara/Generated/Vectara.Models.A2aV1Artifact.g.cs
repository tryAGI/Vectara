
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A v1 task output artifact.
    /// </summary>
    public sealed partial class A2aV1Artifact
    {
        /// <summary>
        /// Unique identifier for this artifact, stable across appended updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifactId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtifactId { get; set; }

        /// <summary>
        /// Human-readable name of the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Human-readable description of the artifact's contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The content parts that make up this artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.A2aV1Part> Parts { get; set; }

        /// <summary>
        /// Arbitrary agent-supplied metadata for the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// URIs of A2A extensions associated with this artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::System.Collections.Generic.IList<string>? Extensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1Artifact" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// Unique identifier for this artifact, stable across appended updates.
        /// </param>
        /// <param name="parts">
        /// The content parts that make up this artifact.
        /// </param>
        /// <param name="name">
        /// Human-readable name of the artifact.
        /// </param>
        /// <param name="description">
        /// Human-readable description of the artifact's contents.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary agent-supplied metadata for the artifact.
        /// </param>
        /// <param name="extensions">
        /// URIs of A2A extensions associated with this artifact.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1Artifact(
            string artifactId,
            global::System.Collections.Generic.IList<global::Vectara.A2aV1Part> parts,
            string? name,
            string? description,
            object? metadata,
            global::System.Collections.Generic.IList<string>? extensions)
        {
            this.ArtifactId = artifactId ?? throw new global::System.ArgumentNullException(nameof(artifactId));
            this.Name = name;
            this.Description = description;
            this.Parts = parts ?? throw new global::System.ArgumentNullException(nameof(parts));
            this.Metadata = metadata;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1Artifact" /> class.
        /// </summary>
        public A2aV1Artifact()
        {
        }

    }
}