
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Base S3 source configuration with all fields optional.
    /// </summary>
    public sealed partial class BaseS3SourceConfiguration
    {
        /// <summary>
        /// Default Value: s3<br/>
        /// Example: s3
        /// </summary>
        /// <default>"s3"</default>
        /// <example>s3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "s3";

        /// <summary>
        /// The S3 bucket name.<br/>
        /// Example: my-documents-bucket
        /// </summary>
        /// <example>my-documents-bucket</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Key prefix to scope ingestion to a subset of objects.<br/>
        /// Example: legal/contracts/
        /// </summary>
        /// <example>legal/contracts/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// The region of the S3-compatible service.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Custom endpoint URL for S3-compatible services. If omitted, defaults to AWS S3.<br/>
        /// Example: https://minio.example.com:9000
        /// </summary>
        /// <example>https://minio.example.com:9000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// AWS access key ID. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_key_id")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// AWS secret access key. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_access_key")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseS3SourceConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: s3<br/>
        /// Example: s3
        /// </param>
        /// <param name="bucket">
        /// The S3 bucket name.<br/>
        /// Example: my-documents-bucket
        /// </param>
        /// <param name="prefix">
        /// Key prefix to scope ingestion to a subset of objects.<br/>
        /// Example: legal/contracts/
        /// </param>
        /// <param name="region">
        /// The region of the S3-compatible service.<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="endpointUrl">
        /// Custom endpoint URL for S3-compatible services. If omitted, defaults to AWS S3.<br/>
        /// Example: https://minio.example.com:9000
        /// </param>
        /// <param name="accessKeyId">
        /// AWS access key ID. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="secretAccessKey">
        /// AWS secret access key. Encrypted at rest and not returned in responses.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseS3SourceConfiguration(
            string type,
            string? bucket,
            string? prefix,
            string? region,
            string? endpointUrl,
            string? accessKeyId,
            string? secretAccessKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Bucket = bucket;
            this.Prefix = prefix;
            this.Region = region;
            this.EndpointUrl = endpointUrl;
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseS3SourceConfiguration" /> class.
        /// </summary>
        public BaseS3SourceConfiguration()
        {
        }
    }
}