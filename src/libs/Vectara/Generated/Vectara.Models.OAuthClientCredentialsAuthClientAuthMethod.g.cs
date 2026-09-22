
#nullable enable

namespace Vectara
{
    /// <summary>
    /// How the platform presents the client ID and secret to the token endpoint, named after the OAuth `token_endpoint_auth_method` registry. `client_secret_basic` sends them in an HTTP Basic `Authorization` header. `client_secret_post` sends them as `client_id` and `client_secret` form fields in the request body. Set this to the method the client application is registered with at the identity provider.<br/>
    /// Default Value: client_secret_basic<br/>
    /// Example: client_secret_post
    /// </summary>
    public enum OAuthClientCredentialsAuthClientAuthMethod
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthClientCredentialsAuthClientAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthClientCredentialsAuthClientAuthMethod value)
        {
            return value switch
            {
                OAuthClientCredentialsAuthClientAuthMethod.ClientSecretBasic => "client_secret_basic",
                OAuthClientCredentialsAuthClientAuthMethod.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthClientCredentialsAuthClientAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => OAuthClientCredentialsAuthClientAuthMethod.ClientSecretBasic,
                "client_secret_post" => OAuthClientCredentialsAuthClientAuthMethod.ClientSecretPost,
                _ => null,
            };
        }
    }
}