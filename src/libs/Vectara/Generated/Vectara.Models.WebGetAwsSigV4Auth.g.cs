
#nullable enable

namespace Vectara
{
    /// <summary>
    /// AWS Signature Version 4 request signing, e.g. for reading an S3 bucket directly. The platform signs the final request (method, URL, query parameters, and body) with the supplied credentials. User-supplied headers ride along unsigned. The platform never follows redirects on signed requests. When `role_arn` is set, the platform first calls sts:AssumeRole with the static credentials and signs with the assumed-role credentials.
    /// </summary>
    public sealed partial class WebGetAwsSigV4Auth
    {
        /// <summary>
        /// Default Value: aws_sigv4<br/>
        /// Example: aws_sigv4
        /// </summary>
        /// <default>"aws_sigv4"</default>
        /// <example>aws_sigv4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "aws_sigv4";

        /// <summary>
        /// AWS access key id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> AccessKeyId { get; set; }

        /// <summary>
        /// AWS secret access key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_access_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vectara.OneOf<string, global::Vectara.EagerReference> SecretAccessKey { get; set; }

        /// <summary>
        /// Optional session token when the static credentials are temporary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_token")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vectara.JsonConverters.OneOfJsonConverter<string, global::Vectara.EagerReference>))]
        public global::Vectara.OneOf<string, global::Vectara.EagerReference>? SessionToken { get; set; }

        /// <summary>
        /// AWS region to sign for (e.g. `us-east-2`).<br/>
        /// Example: us-east-2
        /// </summary>
        /// <example>us-east-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// AWS service name to sign for.<br/>
        /// Default Value: s3<br/>
        /// Example: s3
        /// </summary>
        /// <example>s3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// Optional IAM role to assume (via sts:AssumeRole) from the static credentials before signing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// Session name for the assumed role. Defaults to `vectara-agent`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_session_name")]
        public string? RoleSessionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetAwsSigV4Auth" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: aws_sigv4<br/>
        /// Example: aws_sigv4
        /// </param>
        /// <param name="accessKeyId">
        /// AWS access key id.
        /// </param>
        /// <param name="secretAccessKey">
        /// AWS secret access key.
        /// </param>
        /// <param name="region">
        /// AWS region to sign for (e.g. `us-east-2`).<br/>
        /// Example: us-east-2
        /// </param>
        /// <param name="sessionToken">
        /// Optional session token when the static credentials are temporary.
        /// </param>
        /// <param name="service">
        /// AWS service name to sign for.<br/>
        /// Default Value: s3<br/>
        /// Example: s3
        /// </param>
        /// <param name="roleArn">
        /// Optional IAM role to assume (via sts:AssumeRole) from the static credentials before signing.
        /// </param>
        /// <param name="roleSessionName">
        /// Session name for the assumed role. Defaults to `vectara-agent`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebGetAwsSigV4Auth(
            string type,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> accessKeyId,
            global::Vectara.OneOf<string, global::Vectara.EagerReference> secretAccessKey,
            string region,
            global::Vectara.OneOf<string, global::Vectara.EagerReference>? sessionToken,
            string? service,
            string? roleArn,
            string? roleSessionName)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.SessionToken = sessionToken;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Service = service;
            this.RoleArn = roleArn;
            this.RoleSessionName = roleSessionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebGetAwsSigV4Auth" /> class.
        /// </summary>
        public WebGetAwsSigV4Auth()
        {
        }

    }
}