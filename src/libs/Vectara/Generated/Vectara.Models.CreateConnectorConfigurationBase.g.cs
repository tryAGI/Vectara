
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Properties shared by every connector configuration write view.
    /// </summary>
    public sealed partial class CreateConnectorConfigurationBase
    {
        /// <summary>
        /// Agent output types omitted from the connector's channel; the final response is always posted.<br/>
        /// Default Value: []<br/>
        /// Example: [tool_calls]
        /// </summary>
        /// <example>[tool_calls]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden_output_types")]
        public global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? HiddenOutputTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorConfigurationBase" /> class.
        /// </summary>
        /// <param name="hiddenOutputTypes">
        /// Agent output types omitted from the connector's channel; the final response is always posted.<br/>
        /// Default Value: []<br/>
        /// Example: [tool_calls]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorConfigurationBase(
            global::System.Collections.Generic.IList<global::Vectara.AgentOutputType>? hiddenOutputTypes)
        {
            this.HiddenOutputTypes = hiddenOutputTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorConfigurationBase" /> class.
        /// </summary>
        public CreateConnectorConfigurationBase()
        {
        }

    }
}