
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Properties shared by every kind of step tool call failure handling.
    /// </summary>
    public sealed partial class StepToolCallOnFailureBase
    {
        /// <summary>
        /// The type of failure handling. New values may be added; clients should ignore values they do not recognize.<br/>
        /// Example: end_turn
        /// </summary>
        /// <example>end_turn</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallOnFailureBase" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of failure handling. New values may be added; clients should ignore values they do not recognize.<br/>
        /// Example: end_turn
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepToolCallOnFailureBase(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallOnFailureBase" /> class.
        /// </summary>
        public StepToolCallOnFailureBase()
        {
        }

    }
}