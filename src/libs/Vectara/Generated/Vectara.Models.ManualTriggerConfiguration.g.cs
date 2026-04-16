
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Pipeline is only triggered manually via the trigger endpoint. No automatic scheduling.
    /// </summary>
    public sealed partial class ManualTriggerConfiguration
    {
        /// <summary>
        /// Default Value: manual<br/>
        /// Example: manual
        /// </summary>
        /// <default>"manual"</default>
        /// <example>manual</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "manual";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTriggerConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: manual<br/>
        /// Example: manual
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManualTriggerConfiguration(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTriggerConfiguration" /> class.
        /// </summary>
        public ManualTriggerConfiguration()
        {
        }
    }
}