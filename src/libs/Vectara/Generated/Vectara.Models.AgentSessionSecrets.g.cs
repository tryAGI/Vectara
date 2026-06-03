
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Session-scoped secrets, with values masked as `"****"`. Plaintext is never returned on read;<br/>
    /// tools resolve the real value via `argument_override` with `{"$ref": "session.secrets.&lt;name&gt;"}`.<br/>
    /// Set or rotate via the session create or update request.<br/>
    /// Example: {"slack_user_token":"****"}
    /// </summary>
    public sealed partial class AgentSessionSecrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}