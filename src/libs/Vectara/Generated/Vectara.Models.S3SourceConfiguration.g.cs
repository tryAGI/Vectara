
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting objects from an Amazon S3 bucket.
    /// </summary>
    public sealed partial class S3SourceConfiguration
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// Key prefix to scope ingestion to a subset of objects.<br/>
        /// Example: legal/contracts/
        /// </summary>
        /// <example>legal/contracts/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// AWS region where the bucket is located.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

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
        /// Initializes a new instance of the <see cref="S3SourceConfiguration" /> class.
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
        /// AWS region where the bucket is located.<br/>
        /// Example: us-east-1
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
        public S3SourceConfiguration(
            string type,
            string bucket,
            string region,
            string? prefix,
            string? accessKeyId,
            string? secretAccessKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Prefix = prefix;
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3SourceConfiguration" /> class.
        /// </summary>
        public S3SourceConfiguration()
        {
        }
    }
}