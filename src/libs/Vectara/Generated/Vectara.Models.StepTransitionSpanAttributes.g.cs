
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Attributes for a step_transition span.
    /// </summary>
    public sealed partial class StepTransitionSpanAttributes
    {
        /// <summary>
        /// The name of the step being transitioned from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_step")]
        public string? FromStep { get; set; }

        /// <summary>
        /// The name of the step being transitioned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_step")]
        public string? ToStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepTransitionSpanAttributes" /> class.
        /// </summary>
        /// <param name="fromStep">
        /// The name of the step being transitioned from.
        /// </param>
        /// <param name="toStep">
        /// The name of the step being transitioned to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepTransitionSpanAttributes(
            string? fromStep,
            string? toStep)
        {
            this.FromStep = fromStep;
            this.ToStep = toStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepTransitionSpanAttributes" /> class.
        /// </summary>
        public StepTransitionSpanAttributes()
        {
        }
    }
}