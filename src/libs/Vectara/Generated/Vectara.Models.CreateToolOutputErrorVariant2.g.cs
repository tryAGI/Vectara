
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToolOutputErrorVariant2
    {
        /// <summary>
        /// Always `error`. Indicates the client tool call failed.<br/>
        /// Default Value: error
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "error";

        /// <summary>
        /// Error returned to the agent. May be a string message or a structured object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolOutputErrorVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `error`. Indicates the client tool call failed.<br/>
        /// Default Value: error
        /// </param>
        /// <param name="error">
        /// Error returned to the agent. May be a string message or a structured object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToolOutputErrorVariant2(
            string type,
            object error)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToolOutputErrorVariant2" /> class.
        /// </summary>
        public CreateToolOutputErrorVariant2()
        {
        }

    }
}