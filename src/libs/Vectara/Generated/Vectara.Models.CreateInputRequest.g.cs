
#nullable enable

namespace Vectara
{
    /// <summary>
    /// A request to create input for an agent session.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "type",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(Vectara.CreateInputMessageRequest), typeDiscriminator: "input_message")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(Vectara.CreateInterruptRequest), typeDiscriminator: "interrupt")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(Vectara.CreateCompactRequest), typeDiscriminator: "compact")]
    public partial class CreateInputRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}