#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response for bulk delete operations. Structure varies based on async/sync mode.<br/>
    /// **Async mode (async=true)**: Returns HTTP 202 immediately with job_id to track progress<br/>
    /// **Sync mode (async=false)**: Returns HTTP 200 after completion with deletion counts<br/>
    /// **Important: Best-Effort Operation**<br/>
    /// This is a best-effort deletion operation. The behavior differs based on which parameter you use:<br/>
    /// **Using `document_ids` (Recommended for precision)**<br/>
    /// - Deletes only the exact documents specified by ID<br/>
    /// - Most reliable option - documents are deleted from the primary storage directly<br/>
    /// - Use this when you know exactly which documents to delete<br/>
    /// **Using `metadata_filter` (Subject to indexing lag)**<br/>
    /// - Filters are applied against the search index, not the primary document store<br/>
    /// - Documents that have been recently indexed may not yet appear in search results due to indexing pipeline lag<br/>
    /// - This means recently added documents matching your filter may be missed<br/>
    /// - A timestamp cutoff is captured at operation start; only documents created/updated before this time are deleted<br/>
    /// - Due to distributed system timing, documents added very close to the operation start may still be deleted if timestamps are not perfectly synchronized<br/>
    /// For mission-critical deletions where completeness is required, use `document_ids` or run the filter-based deletion multiple times after indexing has caught up.
    /// </summary>
    public readonly partial struct BulkDeleteDocumentsResponse : global::System.IEquatable<BulkDeleteDocumentsResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BulkDeleteDocumentsResponseDiscriminatorResponseType? ResponseType { get; }

        /// <summary>
        /// Response when async=true. Operation queued, returns immediately (HTTP 202).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BulkDeleteAsyncResponse? Async { get; init; }
#else
        public global::Vectara.BulkDeleteAsyncResponse? Async { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Async))]
#endif
        public bool IsAsync => Async != null;

        /// <summary>
        /// Response when async=false and operation completes successfully (HTTP 200).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BulkDeleteSyncSuccessResponse? Success { get; init; }
#else
        public global::Vectara.BulkDeleteSyncSuccessResponse? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkDeleteDocumentsResponse(global::Vectara.BulkDeleteAsyncResponse value) => new BulkDeleteDocumentsResponse((global::Vectara.BulkDeleteAsyncResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkDeleteAsyncResponse?(BulkDeleteDocumentsResponse @this) => @this.Async;

        /// <summary>
        /// 
        /// </summary>
        public BulkDeleteDocumentsResponse(global::Vectara.BulkDeleteAsyncResponse? value)
        {
            Async = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkDeleteDocumentsResponse(global::Vectara.BulkDeleteSyncSuccessResponse value) => new BulkDeleteDocumentsResponse((global::Vectara.BulkDeleteSyncSuccessResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkDeleteSyncSuccessResponse?(BulkDeleteDocumentsResponse @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public BulkDeleteDocumentsResponse(global::Vectara.BulkDeleteSyncSuccessResponse? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BulkDeleteDocumentsResponse(
            global::Vectara.BulkDeleteDocumentsResponseDiscriminatorResponseType? responseType,
            global::Vectara.BulkDeleteAsyncResponse? async,
            global::Vectara.BulkDeleteSyncSuccessResponse? success
            )
        {
            ResponseType = responseType;

            Async = async;
            Success = success;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Success as object ??
            Async as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Async?.ToString() ??
            Success?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAsync && !IsSuccess || !IsAsync && IsSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BulkDeleteAsyncResponse?, TResult>? async = null,
            global::System.Func<global::Vectara.BulkDeleteSyncSuccessResponse?, TResult>? success = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAsync && async != null)
            {
                return async(Async!);
            }
            else if (IsSuccess && success != null)
            {
                return success(Success!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BulkDeleteAsyncResponse?>? async = null,
            global::System.Action<global::Vectara.BulkDeleteSyncSuccessResponse?>? success = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAsync)
            {
                async?.Invoke(Async!);
            }
            else if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Async,
                typeof(global::Vectara.BulkDeleteAsyncResponse),
                Success,
                typeof(global::Vectara.BulkDeleteSyncSuccessResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(BulkDeleteDocumentsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkDeleteAsyncResponse?>.Default.Equals(Async, other.Async) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkDeleteSyncSuccessResponse?>.Default.Equals(Success, other.Success) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BulkDeleteDocumentsResponse obj1, BulkDeleteDocumentsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BulkDeleteDocumentsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BulkDeleteDocumentsResponse obj1, BulkDeleteDocumentsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BulkDeleteDocumentsResponse o && Equals(o);
        }
    }
}
