
#nullable enable

namespace Vectara
{
    /// <summary>
    /// The terminal event of a streamed Lambda tool test, carrying the same result the non-streaming response returns.
    /// </summary>
    public sealed partial class TestToolResultEvent
    {
        /// <summary>
        /// Event type indicator. Always `result`.<br/>
        /// Default Value: result<br/>
        /// Example: result
        /// </summary>
        /// <default>"result"</default>
        /// <example>result</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "result";

        /// <summary>
        /// The completed test result, identical to the non-streaming response body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.TestToolResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.TestToolResponse Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolResultEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Event type indicator. Always `result`.<br/>
        /// Default Value: result<br/>
        /// Example: result
        /// </param>
        /// <param name="result">
        /// The completed test result, identical to the non-streaming response body.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestToolResultEvent(
            string type,
            global::Vectara.TestToolResponse result)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolResultEvent" /> class.
        /// </summary>
        public TestToolResultEvent()
        {
        }

    }
}