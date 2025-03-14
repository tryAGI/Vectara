#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// (Optional) Choose how to split documents into chunks during indexing. If you do not set a chunking strategy,<br/>
    /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
    /// </summary>
    public readonly partial struct ChunkingStrategy : global::System.IEquatable<ChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// Sets a chunking strategy that limits the number of maximum characters per chunk.<br/>
        /// The chunks do not cross section boundaries.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.MaxCharsChunkingStrategy? MaxCharsChunkingStrategy { get; init; }
#else
        public global::Vectara.MaxCharsChunkingStrategy? MaxCharsChunkingStrategy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxCharsChunkingStrategy))]
#endif
        public bool IsMaxCharsChunkingStrategy => MaxCharsChunkingStrategy != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategy(global::Vectara.MaxCharsChunkingStrategy value) => new ChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MaxCharsChunkingStrategy?(ChunkingStrategy @this) => @this.MaxCharsChunkingStrategy;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategy(global::Vectara.MaxCharsChunkingStrategy? value)
        {
            MaxCharsChunkingStrategy = value;
        }

        /// <summary>
        /// Sets a chunking strategy that creates one chunk per sentence.<br/>
        /// This is the default strategy used when no chunking strategy is specified.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SentenceChunkingStrategy? SentenceChunkingStrategy { get; init; }
#else
        public global::Vectara.SentenceChunkingStrategy? SentenceChunkingStrategy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SentenceChunkingStrategy))]
#endif
        public bool IsSentenceChunkingStrategy => SentenceChunkingStrategy != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategy(global::Vectara.SentenceChunkingStrategy value) => new ChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SentenceChunkingStrategy?(ChunkingStrategy @this) => @this.SentenceChunkingStrategy;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategy(global::Vectara.SentenceChunkingStrategy? value)
        {
            SentenceChunkingStrategy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategy(
            global::Vectara.ChunkingStrategyDiscriminatorType? type,
            global::Vectara.MaxCharsChunkingStrategy? maxCharsChunkingStrategy,
            global::Vectara.SentenceChunkingStrategy? sentenceChunkingStrategy
            )
        {
            Type = type;

            MaxCharsChunkingStrategy = maxCharsChunkingStrategy;
            SentenceChunkingStrategy = sentenceChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SentenceChunkingStrategy as object ??
            MaxCharsChunkingStrategy as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMaxCharsChunkingStrategy && !IsSentenceChunkingStrategy || !IsMaxCharsChunkingStrategy && IsSentenceChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MaxCharsChunkingStrategy?, TResult>? maxCharsChunkingStrategy = null,
            global::System.Func<global::Vectara.SentenceChunkingStrategy?, TResult>? sentenceChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaxCharsChunkingStrategy && maxCharsChunkingStrategy != null)
            {
                return maxCharsChunkingStrategy(MaxCharsChunkingStrategy!);
            }
            else if (IsSentenceChunkingStrategy && sentenceChunkingStrategy != null)
            {
                return sentenceChunkingStrategy(SentenceChunkingStrategy!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MaxCharsChunkingStrategy?>? maxCharsChunkingStrategy = null,
            global::System.Action<global::Vectara.SentenceChunkingStrategy?>? sentenceChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaxCharsChunkingStrategy)
            {
                maxCharsChunkingStrategy?.Invoke(MaxCharsChunkingStrategy!);
            }
            else if (IsSentenceChunkingStrategy)
            {
                sentenceChunkingStrategy?.Invoke(SentenceChunkingStrategy!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MaxCharsChunkingStrategy,
                typeof(global::Vectara.MaxCharsChunkingStrategy),
                SentenceChunkingStrategy,
                typeof(global::Vectara.SentenceChunkingStrategy),
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
        public bool Equals(ChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MaxCharsChunkingStrategy?>.Default.Equals(MaxCharsChunkingStrategy, other.MaxCharsChunkingStrategy) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SentenceChunkingStrategy?>.Default.Equals(SentenceChunkingStrategy, other.SentenceChunkingStrategy) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunkingStrategy obj1, ChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunkingStrategy obj1, ChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunkingStrategy o && Equals(o);
        }
    }
}
