
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Outcome of the most recently received inbound webhook. Absent until the<br/>
    /// first webhook arrives. Values:<br/>
    /// - `success`: the webhook verified and the event was accepted.<br/>
    /// - `jwt_verification_failed`: the bearer token was missing or could not be verified.<br/>
    /// - `audience_mismatch`: the token was valid but its aud did not equal the connector's audience_url.<br/>
    /// - `auth_failed`: the inbound request lacked or did not match the connector's authentication secret.<br/>
    /// - `missing_signature`: the request lacked the signature needed for an asynchronous reply.<br/>
    /// - `missing_engagement`: the request lacked the engagement identifier needed to route the session.<br/>
    /// - `event_parse_failed`: the event body could not be parsed.<br/>
    /// - `internal_error`: an unexpected error occurred after the connector was resolved.<br/>
    /// - `unknown`: the outcome could not be classified.<br/>
    /// Example: success
    /// </summary>
    public enum ConnectorWebhookStatus
    {
        /// <summary>
        /// the token was valid but its aud did not equal the connector's audience_url.
        /// </summary>
        AudienceMismatch,
        /// <summary>
        /// the inbound request lacked or did not match the connector's authentication secret.
        /// </summary>
        AuthFailed,
        /// <summary>
        /// the event body could not be parsed.
        /// </summary>
        EventParseFailed,
        /// <summary>
        /// an unexpected error occurred after the connector was resolved.
        /// </summary>
        InternalError,
        /// <summary>
        /// the bearer token was missing or could not be verified.
        /// </summary>
        JwtVerificationFailed,
        /// <summary>
        /// the request lacked the engagement identifier needed to route the session.
        /// </summary>
        MissingEngagement,
        /// <summary>
        /// the request lacked the signature needed for an asynchronous reply.
        /// </summary>
        MissingSignature,
        /// <summary>
        /// the webhook verified and the event was accepted.
        /// </summary>
        Success,
        /// <summary>
        /// the outcome could not be classified.
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectorWebhookStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorWebhookStatus value)
        {
            return value switch
            {
                ConnectorWebhookStatus.AudienceMismatch => "audience_mismatch",
                ConnectorWebhookStatus.AuthFailed => "auth_failed",
                ConnectorWebhookStatus.EventParseFailed => "event_parse_failed",
                ConnectorWebhookStatus.InternalError => "internal_error",
                ConnectorWebhookStatus.JwtVerificationFailed => "jwt_verification_failed",
                ConnectorWebhookStatus.MissingEngagement => "missing_engagement",
                ConnectorWebhookStatus.MissingSignature => "missing_signature",
                ConnectorWebhookStatus.Success => "success",
                ConnectorWebhookStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectorWebhookStatus? ToEnum(string value)
        {
            return value switch
            {
                "audience_mismatch" => ConnectorWebhookStatus.AudienceMismatch,
                "auth_failed" => ConnectorWebhookStatus.AuthFailed,
                "event_parse_failed" => ConnectorWebhookStatus.EventParseFailed,
                "internal_error" => ConnectorWebhookStatus.InternalError,
                "jwt_verification_failed" => ConnectorWebhookStatus.JwtVerificationFailed,
                "missing_engagement" => ConnectorWebhookStatus.MissingEngagement,
                "missing_signature" => ConnectorWebhookStatus.MissingSignature,
                "success" => ConnectorWebhookStatus.Success,
                "unknown" => ConnectorWebhookStatus.Unknown,
                _ => null,
            };
        }
    }
}