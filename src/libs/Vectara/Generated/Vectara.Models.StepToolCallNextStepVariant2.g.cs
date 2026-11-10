
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StepToolCallNextStepVariant2
    {
        /// <summary>
        /// The type of failure handling.<br/>
        /// Default Value: next_step<br/>
        /// Example: next_step
        /// </summary>
        /// <default>"next_step"</default>
        /// <example>next_step</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "next_step";

        /// <summary>
        /// Name of the step to transition to. Must name one of the agent's steps, including the current step.<br/>
        /// Example: upload_failed
        /// </summary>
        /// <example>upload_failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallNextStepVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of failure handling.<br/>
        /// Default Value: next_step<br/>
        /// Example: next_step
        /// </param>
        /// <param name="stepName">
        /// Name of the step to transition to. Must name one of the agent's steps, including the current step.<br/>
        /// Example: upload_failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepToolCallNextStepVariant2(
            string type,
            string stepName)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.StepName = stepName ?? throw new global::System.ArgumentNullException(nameof(stepName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallNextStepVariant2" /> class.
        /// </summary>
        public StepToolCallNextStepVariant2()
        {
        }

    }
}