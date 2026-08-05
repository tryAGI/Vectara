
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response that contains the job ID for the replacement of filter attributes.
    /// </summary>
    public sealed partial class ReplaceFilterAttributesResponse
    {
        /// <summary>
        /// The ID of the job that replaces the filter attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceFilterAttributesResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job that replaces the filter attributes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceFilterAttributesResponse(
            string jobId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceFilterAttributesResponse" /> class.
        /// </summary>
        public ReplaceFilterAttributesResponse()
        {
        }

    }
}