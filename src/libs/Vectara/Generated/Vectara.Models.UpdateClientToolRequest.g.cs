
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to update an existing client tool.
    /// </summary>
    public sealed partial class UpdateClientToolRequest
    {
        /// <summary>
        /// This should always be `client`.<br/>
        /// Default Value: client<br/>
        /// Example: client
        /// </summary>
        /// <default>"client"</default>
        /// <example>client</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "client";

        /// <summary>
        /// Whether the tool should be enabled or disabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Updated human-readable title of the tool.<br/>
        /// Example: Collect Customer Signature
        /// </summary>
        /// <example>Collect Customer Signature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Updated description of what the tool does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Updated JSON Schema for the arguments the LLM produces when invoking this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public global::Vectara.JsonSchemaDefinition? InputSchema { get; set; }

        /// <summary>
        /// Updated JSON Schema for the structure the client must submit as the tool output. Pass an empty object to clear the schema and accept any output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public global::Vectara.JsonSchemaDefinition? OutputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientToolRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `client`.<br/>
        /// Default Value: client<br/>
        /// Example: client
        /// </param>
        /// <param name="enabled">
        /// Whether the tool should be enabled or disabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Updated human-readable title of the tool.<br/>
        /// Example: Collect Customer Signature
        /// </param>
        /// <param name="description">
        /// Updated description of what the tool does.
        /// </param>
        /// <param name="inputSchema">
        /// Updated JSON Schema for the arguments the LLM produces when invoking this tool.
        /// </param>
        /// <param name="outputSchema">
        /// Updated JSON Schema for the structure the client must submit as the tool output. Pass an empty object to clear the schema and accept any output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateClientToolRequest(
            string type,
            bool? enabled,
            string? title,
            string? description,
            global::Vectara.JsonSchemaDefinition? inputSchema,
            global::Vectara.JsonSchemaDefinition? outputSchema)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Enabled = enabled;
            this.Title = title;
            this.Description = description;
            this.InputSchema = inputSchema;
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientToolRequest" /> class.
        /// </summary>
        public UpdateClientToolRequest()
        {
        }

    }
}