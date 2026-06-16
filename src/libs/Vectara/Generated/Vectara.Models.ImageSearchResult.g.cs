#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An image embedding that matched a query.
    /// </summary>
    public readonly partial struct ImageSearchResult : global::System.IEquatable<ImageSearchResult>
    {
        /// <summary>
        /// Common fields for all search result types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SearchResultBase? Base { get; init; }
#else
        public global::Vectara.SearchResultBase? Base { get; }
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
            out global::Vectara.SearchResultBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SearchResultBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ImageSearchResultVariant2? ImageSearchResultVariant2 { get; init; }
#else
        public global::Vectara.ImageSearchResultVariant2? ImageSearchResultVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageSearchResultVariant2))]
#endif
        public bool IsImageSearchResultVariant2 => ImageSearchResultVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageSearchResultVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ImageSearchResultVariant2? value)
        {
            value = ImageSearchResultVariant2;
            return IsImageSearchResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ImageSearchResultVariant2 PickImageSearchResultVariant2() => IsImageSearchResultVariant2
            ? ImageSearchResultVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageSearchResultVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageSearchResult(global::Vectara.SearchResultBase value) => new ImageSearchResult((global::Vectara.SearchResultBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SearchResultBase?(ImageSearchResult @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ImageSearchResult(global::Vectara.SearchResultBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageSearchResult FromBase(global::Vectara.SearchResultBase? value) => new ImageSearchResult(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageSearchResult(global::Vectara.ImageSearchResultVariant2 value) => new ImageSearchResult((global::Vectara.ImageSearchResultVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageSearchResultVariant2?(ImageSearchResult @this) => @this.ImageSearchResultVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageSearchResult(global::Vectara.ImageSearchResultVariant2? value)
        {
            ImageSearchResultVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageSearchResult FromImageSearchResultVariant2(global::Vectara.ImageSearchResultVariant2? value) => new ImageSearchResult(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageSearchResult(
            global::Vectara.SearchResultBase? @base,
            global::Vectara.ImageSearchResultVariant2? imageSearchResultVariant2
            )
        {
            Base = @base;
            ImageSearchResultVariant2 = imageSearchResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageSearchResultVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ImageSearchResultVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsImageSearchResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SearchResultBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ImageSearchResultVariant2, TResult>? imageSearchResultVariant2 = null,
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
            else if (IsImageSearchResultVariant2 && imageSearchResultVariant2 != null)
            {
                return imageSearchResultVariant2(ImageSearchResultVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SearchResultBase>? @base = null,

            global::System.Action<global::Vectara.ImageSearchResultVariant2>? imageSearchResultVariant2 = null,
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
            else if (IsImageSearchResultVariant2)
            {
                imageSearchResultVariant2?.Invoke(ImageSearchResultVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SearchResultBase>? @base = null,
            global::System.Action<global::Vectara.ImageSearchResultVariant2>? imageSearchResultVariant2 = null,
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
            else if (IsImageSearchResultVariant2)
            {
                imageSearchResultVariant2?.Invoke(ImageSearchResultVariant2!);
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
                typeof(global::Vectara.SearchResultBase),
                ImageSearchResultVariant2,
                typeof(global::Vectara.ImageSearchResultVariant2),
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
        public bool Equals(ImageSearchResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SearchResultBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageSearchResultVariant2?>.Default.Equals(ImageSearchResultVariant2, other.ImageSearchResultVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageSearchResult obj1, ImageSearchResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageSearchResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageSearchResult obj1, ImageSearchResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageSearchResult o && Equals(o);
        }
    }
}
