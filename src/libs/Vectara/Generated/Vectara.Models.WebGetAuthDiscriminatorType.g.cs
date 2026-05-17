
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebGetAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        OauthClientCredentials,
        /// <summary>
        /// 
        /// </summary>
        OauthRefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebGetAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebGetAuthDiscriminatorType value)
        {
            return value switch
            {
                WebGetAuthDiscriminatorType.Bearer => "bearer",
                WebGetAuthDiscriminatorType.Header => "header",
                WebGetAuthDiscriminatorType.None => "none",
                WebGetAuthDiscriminatorType.OauthClientCredentials => "oauth_client_credentials",
                WebGetAuthDiscriminatorType.OauthRefreshToken => "oauth_refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebGetAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => WebGetAuthDiscriminatorType.Bearer,
                "header" => WebGetAuthDiscriminatorType.Header,
                "none" => WebGetAuthDiscriminatorType.None,
                "oauth_client_credentials" => WebGetAuthDiscriminatorType.OauthClientCredentials,
                "oauth_refresh_token" => WebGetAuthDiscriminatorType.OauthRefreshToken,
                _ => null,
            };
        }
    }
}