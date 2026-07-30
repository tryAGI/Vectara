
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Paged response of `GET /tasks`.
    /// </summary>
    public sealed partial class A2aV1ListTasksResponse
    {
        /// <summary>
        /// The tasks in this page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vectara.A2aV1Task> Tasks { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. Empty when there are no further pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextPageToken { get; set; }

        /// <summary>
        /// Number of tasks requested per page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        /// Total number of tasks matching the query across all pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1ListTasksResponse" /> class.
        /// </summary>
        /// <param name="tasks">
        /// The tasks in this page of results.
        /// </param>
        /// <param name="nextPageToken">
        /// Token to retrieve the next page of results. Empty when there are no further pages.
        /// </param>
        /// <param name="pageSize">
        /// Number of tasks requested per page.
        /// </param>
        /// <param name="totalSize">
        /// Total number of tasks matching the query across all pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public A2aV1ListTasksResponse(
            global::System.Collections.Generic.IList<global::Vectara.A2aV1Task> tasks,
            string nextPageToken,
            int pageSize,
            int totalSize)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.NextPageToken = nextPageToken ?? throw new global::System.ArgumentNullException(nameof(nextPageToken));
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A2aV1ListTasksResponse" /> class.
        /// </summary>
        public A2aV1ListTasksResponse()
        {
        }

    }
}