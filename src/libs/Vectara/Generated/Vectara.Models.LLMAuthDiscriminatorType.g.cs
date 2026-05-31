
#nullable enable

namespace Vectara
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        BedrockApiKey,
        /// <summary>
        /// 
        /// </summary>
        BedrockStaticIam,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        OauthClientCredentials,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        VertexAccessToken,
        /// <summary>
        /// 
        /// </summary>
        VertexServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMAuthDiscriminatorType value)
        {
            return value switch
            {
                LLMAuthDiscriminatorType.ApiKey => "api_key",
                LLMAuthDiscriminatorType.Bearer => "bearer",
                LLMAuthDiscriminatorType.BedrockApiKey => "bedrock_api_key",
                LLMAuthDiscriminatorType.BedrockStaticIam => "bedrock_static_iam",
                LLMAuthDiscriminatorType.Header => "header",
                LLMAuthDiscriminatorType.OauthClientCredentials => "oauth_client_credentials",
                LLMAuthDiscriminatorType.ServiceAccount => "service_account",
                LLMAuthDiscriminatorType.VertexAccessToken => "vertex_access_token",
                LLMAuthDiscriminatorType.VertexServiceAccount => "vertex_service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => LLMAuthDiscriminatorType.ApiKey,
                "bearer" => LLMAuthDiscriminatorType.Bearer,
                "bedrock_api_key" => LLMAuthDiscriminatorType.BedrockApiKey,
                "bedrock_static_iam" => LLMAuthDiscriminatorType.BedrockStaticIam,
                "header" => LLMAuthDiscriminatorType.Header,
                "oauth_client_credentials" => LLMAuthDiscriminatorType.OauthClientCredentials,
                "service_account" => LLMAuthDiscriminatorType.ServiceAccount,
                "vertex_access_token" => LLMAuthDiscriminatorType.VertexAccessToken,
                "vertex_service_account" => LLMAuthDiscriminatorType.VertexServiceAccount,
                _ => null,
            };
        }
    }
}