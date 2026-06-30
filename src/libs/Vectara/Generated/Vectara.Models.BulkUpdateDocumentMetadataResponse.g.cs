#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response for a bulk metadata update. Discriminated on `type`: `async` (HTTP 202) when `async=true`; `success` (HTTP 200) when `async=false` and the update completes within the request timeout.<br/>
    /// Selection is best-effort. When `document_ids` is supplied, exactly the listed documents are updated. When `metadata_filter` is supplied, the filter is evaluated against the search index and a `cutoff_at` is captured when the operation starts; only documents created or updated before `cutoff_at` are eligible, so documents added after the operation began are not included. Re-run the operation, or supply `document_ids`, to cover any documents the filter misses.
    /// </summary>
    public readonly partial struct BulkUpdateDocumentMetadataResponse : global::System.IEquatable<BulkUpdateDocumentMetadataResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// Response when async=true. Operation queued, returns immediately (HTTP 202).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? Async { get; init; }
#else
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? Async { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Async))]
#endif
        public bool IsAsync => Async != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAsync(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? value)
        {
            value = Async;
            return IsAsync;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponse PickAsync() => IsAsync
            ? Async!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Async' but the value was {ToString()}.");

        /// <summary>
        /// Response when async=false and operation completes successfully (HTTP 200).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? Success { get; init; }
#else
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? Success { get; }
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
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse PickSuccess() => IsSuccess
            ? Success!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkUpdateDocumentMetadataResponse(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse value) => new BulkUpdateDocumentMetadataResponse((global::Vectara.BulkUpdateDocumentMetadataAsyncResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkUpdateDocumentMetadataAsyncResponse?(BulkUpdateDocumentMetadataResponse @this) => @this.Async;

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataResponse(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? value)
        {
            Async = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BulkUpdateDocumentMetadataResponse FromAsync(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? value) => new BulkUpdateDocumentMetadataResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkUpdateDocumentMetadataResponse(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse value) => new BulkUpdateDocumentMetadataResponse((global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse?(BulkUpdateDocumentMetadataResponse @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataResponse(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BulkUpdateDocumentMetadataResponse FromSuccess(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? value) => new BulkUpdateDocumentMetadataResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataResponse(
            global::Vectara.BulkUpdateDocumentMetadataResponseDiscriminatorType? type,
            global::Vectara.BulkUpdateDocumentMetadataAsyncResponse? async,
            global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse? success
            )
        {
            Type = type;

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
            global::System.Func<global::Vectara.BulkUpdateDocumentMetadataAsyncResponse?, TResult>? async = null,
            global::System.Func<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse?, TResult>? success = null,
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
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataAsyncResponse?>? async = null,

            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse?>? success = null,
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
        public void Switch(
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataAsyncResponse?>? async = null,
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse?>? success = null,
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
                typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponse),
                Success,
                typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse),
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
        public bool Equals(BulkUpdateDocumentMetadataResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkUpdateDocumentMetadataAsyncResponse?>.Default.Equals(Async, other.Async) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponse?>.Default.Equals(Success, other.Success) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BulkUpdateDocumentMetadataResponse obj1, BulkUpdateDocumentMetadataResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BulkUpdateDocumentMetadataResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BulkUpdateDocumentMetadataResponse obj1, BulkUpdateDocumentMetadataResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BulkUpdateDocumentMetadataResponse o && Equals(o);
        }
    }
}
