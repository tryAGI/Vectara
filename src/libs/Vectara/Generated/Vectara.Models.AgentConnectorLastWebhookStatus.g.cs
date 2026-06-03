
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Outcome of the most recently received inbound webhook. Absent until the<br/>
    /// first webhook arrives. Values: success when the webhook verified and the<br/>
    /// event was accepted, jwt_verification_failed when the bearer token was<br/>
    /// missing or could not be verified, audience_mismatch when the token was<br/>
    /// valid but its aud did not equal the connector's audience_url,<br/>
    /// event_parse_failed when the event body could not be parsed,<br/>
    /// internal_error when an unexpected error occurred after the connector was<br/>
    /// resolved, and unknown when the outcome could not be classified.<br/>
    /// Example: success
    /// </summary>
    public enum AgentConnectorLastWebhookStatus
    {
        /// <summary>
        /// 
        /// </summary>
        AudienceMismatch,
        /// <summary>
        /// 
        /// </summary>
        EventParseFailed,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        JwtVerificationFailed,
        /// <summary>
        /// success when the webhook verified and the
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConnectorLastWebhookStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConnectorLastWebhookStatus value)
        {
            return value switch
            {
                AgentConnectorLastWebhookStatus.AudienceMismatch => "audience_mismatch",
                AgentConnectorLastWebhookStatus.EventParseFailed => "event_parse_failed",
                AgentConnectorLastWebhookStatus.InternalError => "internal_error",
                AgentConnectorLastWebhookStatus.JwtVerificationFailed => "jwt_verification_failed",
                AgentConnectorLastWebhookStatus.Success => "success",
                AgentConnectorLastWebhookStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConnectorLastWebhookStatus? ToEnum(string value)
        {
            return value switch
            {
                "audience_mismatch" => AgentConnectorLastWebhookStatus.AudienceMismatch,
                "event_parse_failed" => AgentConnectorLastWebhookStatus.EventParseFailed,
                "internal_error" => AgentConnectorLastWebhookStatus.InternalError,
                "jwt_verification_failed" => AgentConnectorLastWebhookStatus.JwtVerificationFailed,
                "success" => AgentConnectorLastWebhookStatus.Success,
                "unknown" => AgentConnectorLastWebhookStatus.Unknown,
                _ => null,
            };
        }
    }
}