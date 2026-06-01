
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new client tool. When invoked, the platform emits a `tool_input` event; the client performs the work and submits a `tool_output` input via `createAgentInput`.
    /// </summary>
    public sealed partial class CreateClientToolRequest
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
        /// The unique name of the tool.<br/>
        /// Example: collect_signature
        /// </summary>
        /// <example>collect_signature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable title of the tool displayed in the UI.<br/>
        /// Example: Collect Customer Signature
        /// </summary>
        /// <example>Collect Customer Signature</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A detailed description of what the tool does, when the agent should invoke it, and what the expected output represents.<br/>
        /// Example: Prompts the user to e-sign a document. Returns the signed document URL once the user completes signing.
        /// </summary>
        /// <example>Prompts the user to e-sign a document. Returns the signed document URL once the user completes signing.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// JSON Schema describing the arguments the LLM should produce when invoking this tool. These arguments are forwarded verbatim to the client in the `tool_input` event.<br/>
        /// Example: {"type":"object","properties":{"document_url":{"type":"string","description":"URL of the document to be signed."}},"required":["document_url"]}
        /// </summary>
        /// <example>{"type":"object","properties":{"document_url":{"type":"string","description":"URL of the document to be signed."}},"required":["document_url"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public global::Vectara.JsonSchemaDefinition? InputSchema { get; set; }

        /// <summary>
        /// Optional JSON Schema describing the structure the client must submit as the tool output. When set, submitted outputs are validated against this schema before being returned to the agent.<br/>
        /// Example: {"type":"object","properties":{"signed_document_url":{"type":"string"}},"required":["signed_document_url"]}
        /// </summary>
        /// <example>{"type":"object","properties":{"signed_document_url":{"type":"string"}},"required":["signed_document_url"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public global::Vectara.JsonSchemaDefinition? OutputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientToolRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `client`.<br/>
        /// Default Value: client<br/>
        /// Example: client
        /// </param>
        /// <param name="name">
        /// The unique name of the tool.<br/>
        /// Example: collect_signature
        /// </param>
        /// <param name="description">
        /// A detailed description of what the tool does, when the agent should invoke it, and what the expected output represents.<br/>
        /// Example: Prompts the user to e-sign a document. Returns the signed document URL once the user completes signing.
        /// </param>
        /// <param name="title">
        /// Human-readable title of the tool displayed in the UI.<br/>
        /// Example: Collect Customer Signature
        /// </param>
        /// <param name="inputSchema">
        /// JSON Schema describing the arguments the LLM should produce when invoking this tool. These arguments are forwarded verbatim to the client in the `tool_input` event.<br/>
        /// Example: {"type":"object","properties":{"document_url":{"type":"string","description":"URL of the document to be signed."}},"required":["document_url"]}
        /// </param>
        /// <param name="outputSchema">
        /// Optional JSON Schema describing the structure the client must submit as the tool output. When set, submitted outputs are validated against this schema before being returned to the agent.<br/>
        /// Example: {"type":"object","properties":{"signed_document_url":{"type":"string"}},"required":["signed_document_url"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClientToolRequest(
            string type,
            string name,
            string description,
            string? title,
            global::Vectara.JsonSchemaDefinition? inputSchema,
            global::Vectara.JsonSchemaDefinition? outputSchema)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema;
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientToolRequest" /> class.
        /// </summary>
        public CreateClientToolRequest()
        {
        }

    }
}