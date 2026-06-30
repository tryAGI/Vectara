#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response when async=false and operation completes successfully (HTTP 200).
    /// </summary>
    public readonly partial struct BulkUpdateDocumentMetadataSyncSuccessResponse : global::System.IEquatable<BulkUpdateDocumentMetadataSyncSuccessResponse>
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
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 { get; init; }
#else
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BulkUpdateDocumentMetadataSyncSuccessResponseVariant2))]
#endif
        public bool IsBulkUpdateDocumentMetadataSyncSuccessResponseVariant2 => BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBulkUpdateDocumentMetadataSyncSuccessResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? value)
        {
            value = BulkUpdateDocumentMetadataSyncSuccessResponseVariant2;
            return IsBulkUpdateDocumentMetadataSyncSuccessResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 PickBulkUpdateDocumentMetadataSyncSuccessResponseVariant2() => IsBulkUpdateDocumentMetadataSyncSuccessResponseVariant2
            ? BulkUpdateDocumentMetadataSyncSuccessResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BulkUpdateDocumentMetadataSyncSuccessResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkUpdateDocumentMetadataSyncSuccessResponse(global::Vectara.BulkUpdateDocumentMetadataResponseBase value) => new BulkUpdateDocumentMetadataSyncSuccessResponse((global::Vectara.BulkUpdateDocumentMetadataResponseBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkUpdateDocumentMetadataResponseBase?(BulkUpdateDocumentMetadataSyncSuccessResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataSyncSuccessResponse(global::Vectara.BulkUpdateDocumentMetadataResponseBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BulkUpdateDocumentMetadataSyncSuccessResponse FromBase(global::Vectara.BulkUpdateDocumentMetadataResponseBase? value) => new BulkUpdateDocumentMetadataSyncSuccessResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BulkUpdateDocumentMetadataSyncSuccessResponse(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 value) => new BulkUpdateDocumentMetadataSyncSuccessResponse((global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2?(BulkUpdateDocumentMetadataSyncSuccessResponse @this) => @this.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataSyncSuccessResponse(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? value)
        {
            BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BulkUpdateDocumentMetadataSyncSuccessResponse FromBulkUpdateDocumentMetadataSyncSuccessResponseVariant2(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? value) => new BulkUpdateDocumentMetadataSyncSuccessResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BulkUpdateDocumentMetadataSyncSuccessResponse(
            global::Vectara.BulkUpdateDocumentMetadataResponseBase? @base,
            global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2? bulkUpdateDocumentMetadataSyncSuccessResponseVariant2
            )
        {
            Base = @base;
            BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 = bulkUpdateDocumentMetadataSyncSuccessResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BulkUpdateDocumentMetadataSyncSuccessResponseVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            BulkUpdateDocumentMetadataSyncSuccessResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsBulkUpdateDocumentMetadataSyncSuccessResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BulkUpdateDocumentMetadataResponseBase, TResult>? @base = null,
            global::System.Func<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2, TResult>? bulkUpdateDocumentMetadataSyncSuccessResponseVariant2 = null,
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
            else if (IsBulkUpdateDocumentMetadataSyncSuccessResponseVariant2 && bulkUpdateDocumentMetadataSyncSuccessResponseVariant2 != null)
            {
                return bulkUpdateDocumentMetadataSyncSuccessResponseVariant2(BulkUpdateDocumentMetadataSyncSuccessResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataResponseBase>? @base = null,

            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2>? bulkUpdateDocumentMetadataSyncSuccessResponseVariant2 = null,
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
            else if (IsBulkUpdateDocumentMetadataSyncSuccessResponseVariant2)
            {
                bulkUpdateDocumentMetadataSyncSuccessResponseVariant2?.Invoke(BulkUpdateDocumentMetadataSyncSuccessResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataResponseBase>? @base = null,
            global::System.Action<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2>? bulkUpdateDocumentMetadataSyncSuccessResponseVariant2 = null,
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
            else if (IsBulkUpdateDocumentMetadataSyncSuccessResponseVariant2)
            {
                bulkUpdateDocumentMetadataSyncSuccessResponseVariant2?.Invoke(BulkUpdateDocumentMetadataSyncSuccessResponseVariant2!);
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
                BulkUpdateDocumentMetadataSyncSuccessResponseVariant2,
                typeof(global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2),
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
        public bool Equals(BulkUpdateDocumentMetadataSyncSuccessResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkUpdateDocumentMetadataResponseBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2?>.Default.Equals(BulkUpdateDocumentMetadataSyncSuccessResponseVariant2, other.BulkUpdateDocumentMetadataSyncSuccessResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BulkUpdateDocumentMetadataSyncSuccessResponse obj1, BulkUpdateDocumentMetadataSyncSuccessResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BulkUpdateDocumentMetadataSyncSuccessResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BulkUpdateDocumentMetadataSyncSuccessResponse obj1, BulkUpdateDocumentMetadataSyncSuccessResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BulkUpdateDocumentMetadataSyncSuccessResponse o && Equals(o);
        }
    }
}
