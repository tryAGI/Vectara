
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How the subject token is sent to the exchange endpoint: authorization_bearer (in the `Authorization: Bearer` header) or body_param (an RFC 8693 `subject_token` form field).<br/>
    /// Default Value: authorization_bearer
    /// </summary>
    public enum WebGetOAuthTokenExchangeAuthSubjectPlacement
    {
        /// <summary>
        /// authorization_bearer (in the `Authorization: Bearer` header) or body_param (an RFC 8693 `subject_token` form field).
        /// </summary>
        AuthorizationBearer,
        /// <summary>
        /// authorization_bearer (in the `Authorization: Bearer` header) or body_param (an RFC 8693 `subject_token` form field).
        /// </summary>
        BodyParam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebGetOAuthTokenExchangeAuthSubjectPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebGetOAuthTokenExchangeAuthSubjectPlacement value)
        {
            return value switch
            {
                WebGetOAuthTokenExchangeAuthSubjectPlacement.AuthorizationBearer => "authorization_bearer",
                WebGetOAuthTokenExchangeAuthSubjectPlacement.BodyParam => "body_param",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebGetOAuthTokenExchangeAuthSubjectPlacement? ToEnum(string value)
        {
            return value switch
            {
                "authorization_bearer" => WebGetOAuthTokenExchangeAuthSubjectPlacement.AuthorizationBearer,
                "body_param" => WebGetOAuthTokenExchangeAuthSubjectPlacement.BodyParam,
                _ => null,
            };
        }
    }
}