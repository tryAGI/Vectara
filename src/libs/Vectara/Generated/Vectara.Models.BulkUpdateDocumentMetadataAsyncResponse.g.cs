#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response when async=true. Operation queued, returns immediately (HTTP 202).
    /// </summary>
    public readonly partial struct BulkUpdateDocumentMetadataAsyncResponse : global::System.IEquatable<BulkUpdateDocumentMetadataAsyncResponse>
    {
        /// <summary>
        /// Fields common to every bulk metadata update response variant.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BulkUpdateDocumentMetadataResponseBase? Base { get; init; }
#else
        public global::Vectara.BulkUpdateDocumentMetadataResponseBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BulkUpdateDocumentMetadataResponseBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataResponseBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? BulkUpdateDocumentMetadataAsyncResponseVariant2 { get; init; }
#else
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? BulkUpdateDocumentMetadataAsyncResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BulkUpdateDocumentMetadataAsyncResponseVariant2))]
#endif
        public bool IsBulkUpdateDocumentMetadataAsyncResponseVariant2 => BulkUpdateDocumentMetadataAsyncResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBulkUpdateDocumentMetadataAsyncResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? value)
        {
            value = BulkUpdateDocumentMetadataAsyncResponseVariant2;
            return IsBulkUpdateDocumentMetadataAsyncResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2 PickBulkUpdateDocumentMetadataAsyncResponseVariant2() => IsBulkUpdateDocumentMetadataAsyncResponseVariant2
            ? BulkUpdateDocumentMetadataAsyncResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BulkUpdateDocumentMetadataAsyncResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkUpdateDocumentMetadataAsyncResponse(global::Vectara.BulkUpdateDocumentMetadataResponseBase value) => new BulkUpdateDocumentMetadataAsyncResponse((global::Vectara.BulkUpdateDocumentMetadataResponseBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkUpdateDocumentMetadataResponseBase?(BulkUpdateDocumentMetadataAsyncResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataAsyncResponse(global::Vectara.BulkUpdateDocumentMetadataResponseBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BulkUpdateDocumentMetadataAsyncResponse FromBase(global::Vectara.BulkUpdateDocumentMetadataResponseBase? value) => new BulkUpdateDocumentMetadataAsyncResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkUpdateDocumentMetadataAsyncResponse(global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2 value) => new BulkUpdateDocumentMetadataAsyncResponse((global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2?(BulkUpdateDocumentMetadataAsyncResponse @this) => @this.BulkUpdateDocumentMetadataAsyncResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataAsyncResponse(global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? value)
        {
            BulkUpdateDocumentMetadataAsyncResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BulkUpdateDocumentMetadataAsyncResponse FromBulkUpdateDocumentMetadataAsyncResponseVariant2(global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? value) => new BulkUpdateDocumentMetadataAsyncResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataAsyncResponse(
            global::Vectara.BulkUpdateDocumentMetadataResponseBase? @base,
            global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2? bulkUpdateDocumentMetadataAsyncResponseVariant2
            )
        {
            Base = @base;
            BulkUpdateDocumentMetadataAsyncResponseVariant2 = bulkUpdateDocumentMetadataAsyncResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BulkUpdateDocumentMetadataAsyncResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            BulkUpdateDocumentMetadataAsyncResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsBulkUpdateDocumentMetadataAsyncResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BulkUpdateDocumentMetadataResponseBase, TResult>? @base = null,
            global::System.Func<global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2, TResult>? bulkUpdateDocumentMetadataAsyncResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsBulkUpdateDocumentMetadataAsyncResponseVariant2 && bulkUpdateDocumentMetadataAsyncResponseVariant2 != null)
            {
                return bulkUpdateDocumentMetadataAsyncResponseVariant2(BulkUpdateDocumentMetadataAsyncResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataResponseBase>? @base = null,

            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2>? bulkUpdateDocumentMetadataAsyncResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsBulkUpdateDocumentMetadataAsyncResponseVariant2)
            {
                bulkUpdateDocumentMetadataAsyncResponseVariant2?.Invoke(BulkUpdateDocumentMetadataAsyncResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataResponseBase>? @base = null,
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2>? bulkUpdateDocumentMetadataAsyncResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsBulkUpdateDocumentMetadataAsyncResponseVariant2)
            {
                bulkUpdateDocumentMetadataAsyncResponseVariant2?.Invoke(BulkUpdateDocumentMetadataAsyncResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.BulkUpdateDocumentMetadataResponseBase),
                BulkUpdateDocumentMetadataAsyncResponseVariant2,
                typeof(global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2),
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
        public bool Equals(BulkUpdateDocumentMetadataAsyncResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkUpdateDocumentMetadataResponseBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkUpdateDocumentMetadataAsyncResponseVariant2?>.Default.Equals(BulkUpdateDocumentMetadataAsyncResponseVariant2, other.BulkUpdateDocumentMetadataAsyncResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BulkUpdateDocumentMetadataAsyncResponse obj1, BulkUpdateDocumentMetadataAsyncResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BulkUpdateDocumentMetadataAsyncResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BulkUpdateDocumentMetadataAsyncResponse obj1, BulkUpdateDocumentMetadataAsyncResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BulkUpdateDocumentMetadataAsyncResponse o && Equals(o);
        }
    }
}
