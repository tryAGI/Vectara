
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Session-scoped secrets to store on the new session. Map of secret name to plaintext value.<br/>
    /// Encrypted at rest with the owning agent's encryption key. Referenced from tool `argument_override` via<br/>
    /// `{"$ref": "session.secrets.&lt;name&gt;"}`. Returned masked (`****`) on reads.<br/>
    /// Example: {"slack_user_token":"xoxp-your-token-here"}
    /// </summary>
    public sealed partial class CreateAgentSessionRequestSecrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}