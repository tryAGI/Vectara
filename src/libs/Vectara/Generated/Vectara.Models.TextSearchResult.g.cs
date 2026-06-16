#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A text document part that matched a query.
    /// </summary>
    public readonly partial struct TextSearchResult : global::System.IEquatable<TextSearchResult>
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
        public global::Vectara.TextSearchResultVariant2? TextSearchResultVariant2 { get; init; }
#else
        public global::Vectara.TextSearchResultVariant2? TextSearchResultVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextSearchResultVariant2))]
#endif
        public bool IsTextSearchResultVariant2 => TextSearchResultVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextSearchResultVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.TextSearchResultVariant2? value)
        {
            value = TextSearchResultVariant2;
            return IsTextSearchResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.TextSearchResultVariant2 PickTextSearchResultVariant2() => IsTextSearchResultVariant2
            ? TextSearchResultVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextSearchResultVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextSearchResult(global::Vectara.SearchResultBase value) => new TextSearchResult((global::Vectara.SearchResultBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SearchResultBase?(TextSearchResult @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TextSearchResult(global::Vectara.SearchResultBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextSearchResult FromBase(global::Vectara.SearchResultBase? value) => new TextSearchResult(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextSearchResult(global::Vectara.TextSearchResultVariant2 value) => new TextSearchResult((global::Vectara.TextSearchResultVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.TextSearchResultVariant2?(TextSearchResult @this) => @this.TextSearchResultVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TextSearchResult(global::Vectara.TextSearchResultVariant2? value)
        {
            TextSearchResultVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextSearchResult FromTextSearchResultVariant2(global::Vectara.TextSearchResultVariant2? value) => new TextSearchResult(value);

        /// <summary>
        /// 
        /// </summary>
        public TextSearchResult(
            global::Vectara.SearchResultBase? @base,
            global::Vectara.TextSearchResultVariant2? textSearchResultVariant2
            )
        {
            Base = @base;
            TextSearchResultVariant2 = textSearchResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextSearchResultVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TextSearchResultVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTextSearchResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SearchResultBase, TResult>? @base = null,
            global::System.Func<global::Vectara.TextSearchResultVariant2, TResult>? textSearchResultVariant2 = null,
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
            else if (IsTextSearchResultVariant2 && textSearchResultVariant2 != null)
            {
                return textSearchResultVariant2(TextSearchResultVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SearchResultBase>? @base = null,

            global::System.Action<global::Vectara.TextSearchResultVariant2>? textSearchResultVariant2 = null,
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
            else if (IsTextSearchResultVariant2)
            {
                textSearchResultVariant2?.Invoke(TextSearchResultVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SearchResultBase>? @base = null,
            global::System.Action<global::Vectara.TextSearchResultVariant2>? textSearchResultVariant2 = null,
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
            else if (IsTextSearchResultVariant2)
            {
                textSearchResultVariant2?.Invoke(TextSearchResultVariant2!);
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
                TextSearchResultVariant2,
                typeof(global::Vectara.TextSearchResultVariant2),
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
        public bool Equals(TextSearchResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SearchResultBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TextSearchResultVariant2?>.Default.Equals(TextSearchResultVariant2, other.TextSearchResultVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextSearchResult obj1, TextSearchResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextSearchResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextSearchResult obj1, TextSearchResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextSearchResult o && Equals(o);
        }
    }
}
