
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LambdaToolConfigurationVariant2
    {
        /// <summary>
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </summary>
        /// <default>"lambda"</default>
        /// <example>lambda</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "lambda";

        /// <summary>
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The LLM will not be able to change the parameters, nor know those values exist within the tool.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References are resolved at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
        /// Example: {"connection_string":"postgresql://prod-db:5432/analytics","max_retries":3}
        /// </summary>
        /// <example>{"connection_string":"postgresql://prod-db:5432/analytics","max_retries":3}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public object? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LambdaToolConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </param>
        /// <param name="argumentOverride">
        /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The LLM will not be able to change the parameters, nor know those values exist within the tool.<br/>
        /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
        /// - Static value: "fixed_value" or 123<br/>
        /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
        /// References are resolved at runtime from context:<br/>
        /// - session.metadata.* - Access session metadata fields<br/>
        /// - agent.metadata.* - Access agent metadata fields<br/>
        /// Example:<br/>
        ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
        /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
        /// Example: {"connection_string":"postgresql://prod-db:5432/analytics","max_retries":3}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LambdaToolConfigurationVariant2(
            string type,
            object? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LambdaToolConfigurationVariant2" /> class.
        /// </summary>
        public LambdaToolConfigurationVariant2()
        {
        }
    }
}