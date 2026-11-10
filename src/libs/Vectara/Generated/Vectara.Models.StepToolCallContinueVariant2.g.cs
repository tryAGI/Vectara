
#nullable enable

namespace Vectara
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StepToolCallContinueVariant2
    {
        /// <summary>
        /// The type of failure handling.<br/>
        /// Default Value: continue<br/>
        /// Example: continue
        /// </summary>
        /// <default>"continue"</default>
        /// <example>continue</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "continue";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallContinueVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of failure handling.<br/>
        /// Default Value: continue<br/>
        /// Example: continue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepToolCallContinueVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepToolCallContinueVariant2" /> class.
        /// </summary>
        public StepToolCallContinueVariant2()
        {
        }

    }
}