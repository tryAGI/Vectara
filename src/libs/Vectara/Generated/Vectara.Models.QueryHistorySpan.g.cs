#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Portion of the query history.
    /// </summary>
    public readonly partial struct QueryHistorySpan : global::System.IEquatable<QueryHistorySpan>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.QueryHistorySpanDiscriminatorType? Type { get; }

        /// <summary>
        /// During the query pipeline, the query may be rephrased to better suit the corpus.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RephraseSpan? Rephrase { get; init; }
#else
        public global::Vectara.RephraseSpan? Rephrase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rephrase))]
#endif
        public bool IsRephrase => Rephrase != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::Vectara.RephraseSpan value) => new QueryHistorySpan(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RephraseSpan?(QueryHistorySpan @this) => @this.Rephrase;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::Vectara.RephraseSpan? value)
        {
            Rephrase = value;
        }

        /// <summary>
        /// The search portion of the query pipeline. This occurs before any reranking span.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SearchSpan? Search { get; init; }
#else
        public global::Vectara.SearchSpan? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::Vectara.SearchSpan value) => new QueryHistorySpan(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SearchSpan?(QueryHistorySpan @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::Vectara.SearchSpan? value)
        {
            Search = value;
        }

        /// <summary>
        /// The reranking of the search result.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RerankSpan? Rerank { get; init; }
#else
        public global::Vectara.RerankSpan? Rerank { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rerank))]
#endif
        public bool IsRerank => Rerank != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::Vectara.RerankSpan value) => new QueryHistorySpan(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RerankSpan?(QueryHistorySpan @this) => @this.Rerank;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::Vectara.RerankSpan? value)
        {
            Rerank = value;
        }

        /// <summary>
        /// The generation by an LLM.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GenerationSpan? Generation { get; init; }
#else
        public global::Vectara.GenerationSpan? Generation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generation))]
#endif
        public bool IsGeneration => Generation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::Vectara.GenerationSpan value) => new QueryHistorySpan(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GenerationSpan?(QueryHistorySpan @this) => @this.Generation;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::Vectara.GenerationSpan? value)
        {
            Generation = value;
        }

        /// <summary>
        /// The factual consistency of the generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.FactualConsistencyScoreSpan? Fcs { get; init; }
#else
        public global::Vectara.FactualConsistencyScoreSpan? Fcs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fcs))]
#endif
        public bool IsFcs => Fcs != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::Vectara.FactualConsistencyScoreSpan value) => new QueryHistorySpan(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.FactualConsistencyScoreSpan?(QueryHistorySpan @this) => @this.Fcs;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::Vectara.FactualConsistencyScoreSpan? value)
        {
            Fcs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(
            global::Vectara.QueryHistorySpanDiscriminatorType? type,
            global::Vectara.RephraseSpan? rephrase,
            global::Vectara.SearchSpan? search,
            global::Vectara.RerankSpan? rerank,
            global::Vectara.GenerationSpan? generation,
            global::Vectara.FactualConsistencyScoreSpan? fcs
            )
        {
            Type = type;

            Rephrase = rephrase;
            Search = search;
            Rerank = rerank;
            Generation = generation;
            Fcs = fcs;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Fcs as object ??
            Generation as object ??
            Rerank as object ??
            Search as object ??
            Rephrase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRephrase && !IsSearch && !IsRerank && !IsGeneration && !IsFcs || !IsRephrase && IsSearch && !IsRerank && !IsGeneration && !IsFcs || !IsRephrase && !IsSearch && IsRerank && !IsGeneration && !IsFcs || !IsRephrase && !IsSearch && !IsRerank && IsGeneration && !IsFcs || !IsRephrase && !IsSearch && !IsRerank && !IsGeneration && IsFcs;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.RephraseSpan?, TResult>? rephrase = null,
            global::System.Func<global::Vectara.SearchSpan?, TResult>? search = null,
            global::System.Func<global::Vectara.RerankSpan?, TResult>? rerank = null,
            global::System.Func<global::Vectara.GenerationSpan?, TResult>? generation = null,
            global::System.Func<global::Vectara.FactualConsistencyScoreSpan?, TResult>? fcs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRephrase && rephrase != null)
            {
                return rephrase(Rephrase!);
            }
            else if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsRerank && rerank != null)
            {
                return rerank(Rerank!);
            }
            else if (IsGeneration && generation != null)
            {
                return generation(Generation!);
            }
            else if (IsFcs && fcs != null)
            {
                return fcs(Fcs!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.RephraseSpan?>? rephrase = null,
            global::System.Action<global::Vectara.SearchSpan?>? search = null,
            global::System.Action<global::Vectara.RerankSpan?>? rerank = null,
            global::System.Action<global::Vectara.GenerationSpan?>? generation = null,
            global::System.Action<global::Vectara.FactualConsistencyScoreSpan?>? fcs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRephrase)
            {
                rephrase?.Invoke(Rephrase!);
            }
            else if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsRerank)
            {
                rerank?.Invoke(Rerank!);
            }
            else if (IsGeneration)
            {
                generation?.Invoke(Generation!);
            }
            else if (IsFcs)
            {
                fcs?.Invoke(Fcs!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Rephrase,
                typeof(global::Vectara.RephraseSpan),
                Search,
                typeof(global::Vectara.SearchSpan),
                Rerank,
                typeof(global::Vectara.RerankSpan),
                Generation,
                typeof(global::Vectara.GenerationSpan),
                Fcs,
                typeof(global::Vectara.FactualConsistencyScoreSpan),
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
        public bool Equals(QueryHistorySpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RephraseSpan?>.Default.Equals(Rephrase, other.Rephrase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SearchSpan?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RerankSpan?>.Default.Equals(Rerank, other.Rerank) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GenerationSpan?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.FactualConsistencyScoreSpan?>.Default.Equals(Fcs, other.Fcs) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryHistorySpan obj1, QueryHistorySpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryHistorySpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryHistorySpan obj1, QueryHistorySpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryHistorySpan o && Equals(o);
        }
    }
}
