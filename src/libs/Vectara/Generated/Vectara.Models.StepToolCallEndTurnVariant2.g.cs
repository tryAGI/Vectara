
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StepToolCallEndTurnVariant2
    {
        /// <summary>
        /// The type of failure handling.<br/>
        /// Default Value: end_turn<br/>
        /// Example: end_turn
        /// </summary>
        /// <default>"end_turn"</default>
        /// <example>end_turn</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "end_turn";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallEndTurnVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of failure handling.<br/>
        /// Default Value: end_turn<br/>
        /// Example: end_turn
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepToolCallEndTurnVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallEndTurnVariant2" /> class.
        /// </summary>
        public StepToolCallEndTurnVariant2()
        {
        }

    }
}