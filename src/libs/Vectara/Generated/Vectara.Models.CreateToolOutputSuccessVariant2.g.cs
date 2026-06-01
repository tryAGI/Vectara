
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToolOutputSuccessVariant2
    {
        /// <summary>
        /// Always `success`. Indicates the client tool call succeeded.<br/>
        /// Default Value: success
        /// </summary>
        /// <default>"success"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "success";

        /// <summary>
        /// The tool's result. Validated against the tool's `output_schema` if one is defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolOutputSuccessVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `success`. Indicates the client tool call succeeded.<br/>
        /// Default Value: success
        /// </param>
        /// <param name="output">
        /// The tool's result. Validated against the tool's `output_schema` if one is defined.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolOutputSuccessVariant2(
            string type,
            object output)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolOutputSuccessVariant2" /> class.
        /// </summary>
        public CreateToolOutputSuccessVariant2()
        {
        }

    }
}