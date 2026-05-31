
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Patch the session's secrets. Names present in the map are added or replaced; names absent from the map are left unchanged.<br/>
    /// A name mapped to `null` is removed. Values are encrypted at rest with the owning agent's encryption key and returned masked on reads.<br/>
    /// Example: {"slack_user_token":"xoxp-rotated-token","old_token_to_remove":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
    /// </summary>
    public sealed partial class UpdateAgentSessionRequestSecrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}