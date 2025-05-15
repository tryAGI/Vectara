#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Rerank results of the search. Rerankers are very powerful tools to improve the order of search results. By default the search will use the most powerful reranker available to the customer's plan. To disable reranking, set the reranker `type` to `"none"`.
    /// </summary>
    public readonly partial struct SearchReranker : global::System.IEquatable<SearchReranker>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SearchRerankerDiscriminatorType? Type { get; }

        /// <summary>
        /// Reranker that is specific to the customer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CustomerSpecificReranker? CustomerReranker { get; init; }
#else
        public global::Vectara.CustomerSpecificReranker? CustomerReranker { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerReranker))]
#endif
        public bool IsCustomerReranker => CustomerReranker != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.CustomerSpecificReranker value) => new SearchReranker((global::Vectara.CustomerSpecificReranker?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CustomerSpecificReranker?(SearchReranker @this) => @this.CustomerReranker;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.CustomerSpecificReranker? value)
        {
            CustomerReranker = value;
        }

        /// <summary>
        /// A reranker that uses user-defined functions to reorder search results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UserFunctionReranker? Userfn { get; init; }
#else
        public global::Vectara.UserFunctionReranker? Userfn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Userfn))]
#endif
        public bool IsUserfn => Userfn != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.UserFunctionReranker value) => new SearchReranker((global::Vectara.UserFunctionReranker?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.UserFunctionReranker?(SearchReranker @this) => @this.Userfn;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.UserFunctionReranker? value)
        {
            Userfn = value;
        }

        /// <summary>
        /// A reranker that uses Maximal Marginal Relevance to balance relevance and diversity in search results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.MMRReranker? Mmr { get; init; }
#else
        public global::Vectara.MMRReranker? Mmr { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mmr))]
#endif
        public bool IsMmr => Mmr != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.MMRReranker value) => new SearchReranker((global::Vectara.MMRReranker?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MMRReranker?(SearchReranker @this) => @this.Mmr;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.MMRReranker? value)
        {
            Mmr = value;
        }

        /// <summary>
        /// A reranker that applies multiple rerankers in sequence to produce the final search results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ChainReranker? Chain { get; init; }
#else
        public global::Vectara.ChainReranker? Chain { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chain))]
#endif
        public bool IsChain => Chain != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.ChainReranker value) => new SearchReranker((global::Vectara.ChainReranker?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ChainReranker?(SearchReranker @this) => @this.Chain;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.ChainReranker? value)
        {
            Chain = value;
        }

        /// <summary>
        /// A placeholder reranker that does not modify the original search results ordering.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.NoneReranker? None { get; init; }
#else
        public global::Vectara.NoneReranker? None { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::Vectara.NoneReranker value) => new SearchReranker((global::Vectara.NoneReranker?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.NoneReranker?(SearchReranker @this) => @this.None;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::Vectara.NoneReranker? value)
        {
            None = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(
            global::Vectara.SearchRerankerDiscriminatorType? type,
            global::Vectara.CustomerSpecificReranker? customerReranker,
            global::Vectara.UserFunctionReranker? userfn,
            global::Vectara.MMRReranker? mmr,
            global::Vectara.ChainReranker? chain,
            global::Vectara.NoneReranker? none
            )
        {
            Type = type;

            CustomerReranker = customerReranker;
            Userfn = userfn;
            Mmr = mmr;
            Chain = chain;
            None = none;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            None as object ??
            Chain as object ??
            Mmr as object ??
            Userfn as object ??
            CustomerReranker as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomerReranker?.ToString() ??
            Userfn?.ToString() ??
            Mmr?.ToString() ??
            Chain?.ToString() ??
            None?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomerReranker && !IsUserfn && !IsMmr && !IsChain && !IsNone || !IsCustomerReranker && IsUserfn && !IsMmr && !IsChain && !IsNone || !IsCustomerReranker && !IsUserfn && IsMmr && !IsChain && !IsNone || !IsCustomerReranker && !IsUserfn && !IsMmr && IsChain && !IsNone || !IsCustomerReranker && !IsUserfn && !IsMmr && !IsChain && IsNone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CustomerSpecificReranker?, TResult>? customerReranker = null,
            global::System.Func<global::Vectara.UserFunctionReranker?, TResult>? userfn = null,
            global::System.Func<global::Vectara.MMRReranker?, TResult>? mmr = null,
            global::System.Func<global::Vectara.ChainReranker?, TResult>? chain = null,
            global::System.Func<global::Vectara.NoneReranker?, TResult>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerReranker && customerReranker != null)
            {
                return customerReranker(CustomerReranker!);
            }
            else if (IsUserfn && userfn != null)
            {
                return userfn(Userfn!);
            }
            else if (IsMmr && mmr != null)
            {
                return mmr(Mmr!);
            }
            else if (IsChain && chain != null)
            {
                return chain(Chain!);
            }
            else if (IsNone && none != null)
            {
                return none(None!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CustomerSpecificReranker?>? customerReranker = null,
            global::System.Action<global::Vectara.UserFunctionReranker?>? userfn = null,
            global::System.Action<global::Vectara.MMRReranker?>? mmr = null,
            global::System.Action<global::Vectara.ChainReranker?>? chain = null,
            global::System.Action<global::Vectara.NoneReranker?>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerReranker)
            {
                customerReranker?.Invoke(CustomerReranker!);
            }
            else if (IsUserfn)
            {
                userfn?.Invoke(Userfn!);
            }
            else if (IsMmr)
            {
                mmr?.Invoke(Mmr!);
            }
            else if (IsChain)
            {
                chain?.Invoke(Chain!);
            }
            else if (IsNone)
            {
                none?.Invoke(None!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerReranker,
                typeof(global::Vectara.CustomerSpecificReranker),
                Userfn,
                typeof(global::Vectara.UserFunctionReranker),
                Mmr,
                typeof(global::Vectara.MMRReranker),
                Chain,
                typeof(global::Vectara.ChainReranker),
                None,
                typeof(global::Vectara.NoneReranker),
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
        public bool Equals(SearchReranker other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CustomerSpecificReranker?>.Default.Equals(CustomerReranker, other.CustomerReranker) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UserFunctionReranker?>.Default.Equals(Userfn, other.Userfn) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MMRReranker?>.Default.Equals(Mmr, other.Mmr) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ChainReranker?>.Default.Equals(Chain, other.Chain) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.NoneReranker?>.Default.Equals(None, other.None) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchReranker obj1, SearchReranker obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchReranker>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchReranker obj1, SearchReranker obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchReranker o && Equals(o);
        }
    }
}
