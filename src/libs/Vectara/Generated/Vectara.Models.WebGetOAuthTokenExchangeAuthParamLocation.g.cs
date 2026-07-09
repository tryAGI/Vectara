
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Where the exchange `params` are sent: query or body (RFC 8693 uses body).<br/>
    /// Default Value: query
    /// </summary>
    public enum WebGetOAuthTokenExchangeAuthParamLocation
    {
        /// <summary>
        /// query or body (RFC 8693 uses body).
        /// </summary>
        Body,
        /// <summary>
        /// query or body (RFC 8693 uses body).
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebGetOAuthTokenExchangeAuthParamLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebGetOAuthTokenExchangeAuthParamLocation value)
        {
            return value switch
            {
                WebGetOAuthTokenExchangeAuthParamLocation.Body => "body",
                WebGetOAuthTokenExchangeAuthParamLocation.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebGetOAuthTokenExchangeAuthParamLocation? ToEnum(string value)
        {
            return value switch
            {
                "body" => WebGetOAuthTokenExchangeAuthParamLocation.Body,
                "query" => WebGetOAuthTokenExchangeAuthParamLocation.Query,
                _ => null,
            };
        }
    }
}