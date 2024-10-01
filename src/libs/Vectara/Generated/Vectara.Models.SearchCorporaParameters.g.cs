using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The parameters to search one or more corpora.
    /// </summary>
    public readonly partial struct SearchCorporaParameters : global::System.IEquatable<SearchCorporaParameters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SearchCorporaParametersVariant1? Value1 { get; init; }
#else
        public global::Vectara.SearchCorporaParametersVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchCorporaParameters(global::Vectara.SearchCorporaParametersVariant1 value) => new SearchCorporaParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SearchCorporaParametersVariant1?(SearchCorporaParameters @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(global::Vectara.SearchCorporaParametersVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Search parameters to retrieve knowledge for the query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SearchParameters? Value2 { get; init; }
#else
        public global::Vectara.SearchParameters? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchCorporaParameters(global::Vectara.SearchParameters value) => new SearchCorporaParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SearchParameters?(SearchCorporaParameters @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(global::Vectara.SearchParameters? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(
            global::Vectara.SearchCorporaParametersVariant1? value1,
            global::Vectara.SearchParameters? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SearchCorporaParametersVariant1?, TResult>? value1 = null,
            global::System.Func<global::Vectara.SearchParameters?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SearchCorporaParametersVariant1?>? value1 = null,
            global::System.Action<global::Vectara.SearchParameters?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Vectara.SearchCorporaParametersVariant1),
                Value2,
                typeof(global::Vectara.SearchParameters),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(SearchCorporaParameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SearchCorporaParametersVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SearchParameters?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchCorporaParameters obj1, SearchCorporaParameters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchCorporaParameters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchCorporaParameters obj1, SearchCorporaParameters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchCorporaParameters o && Equals(o);
        }
    }
}