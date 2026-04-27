#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing an image being loaded into conversation context.
    /// </summary>
    public readonly partial struct ImageReadTraceSpan : global::System.IEquatable<ImageReadTraceSpan>
    {
        /// <summary>
        /// Common properties shared by all agent trace span types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentTraceSpanBase? AgentBase { get; init; }
#else
        public global::Vectara.AgentTraceSpanBase? AgentBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentBase))]
#endif
        public bool IsAgentBase => AgentBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ImageReadTraceSpanVariant2? ImageReadTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.ImageReadTraceSpanVariant2? ImageReadTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageReadTraceSpanVariant2))]
#endif
        public bool IsImageReadTraceSpanVariant2 => ImageReadTraceSpanVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadTraceSpan(global::Vectara.AgentTraceSpanBase value) => new ImageReadTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(ImageReadTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadTraceSpan(global::Vectara.ImageReadTraceSpanVariant2 value) => new ImageReadTraceSpan((global::Vectara.ImageReadTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadTraceSpanVariant2?(ImageReadTraceSpan @this) => @this.ImageReadTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTraceSpan(global::Vectara.ImageReadTraceSpanVariant2? value)
        {
            ImageReadTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.ImageReadTraceSpanVariant2? imageReadTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            ImageReadTraceSpanVariant2 = imageReadTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageReadTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ImageReadTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsImageReadTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ImageReadTraceSpanVariant2?, TResult>? imageReadTraceSpanVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase && agentBase != null)
            {
                return agentBase(AgentBase!);
            }
            else if (IsImageReadTraceSpanVariant2 && imageReadTraceSpanVariant2 != null)
            {
                return imageReadTraceSpanVariant2(ImageReadTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase?>? agentBase = null,
            global::System.Action<global::Vectara.ImageReadTraceSpanVariant2?>? imageReadTraceSpanVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase)
            {
                agentBase?.Invoke(AgentBase!);
            }
            else if (IsImageReadTraceSpanVariant2)
            {
                imageReadTraceSpanVariant2?.Invoke(ImageReadTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentBase,
                typeof(global::Vectara.AgentTraceSpanBase),
                ImageReadTraceSpanVariant2,
                typeof(global::Vectara.ImageReadTraceSpanVariant2),
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
        public bool Equals(ImageReadTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadTraceSpanVariant2?>.Default.Equals(ImageReadTraceSpanVariant2, other.ImageReadTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageReadTraceSpan obj1, ImageReadTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageReadTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageReadTraceSpan obj1, ImageReadTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageReadTraceSpan o && Equals(o);
        }
    }
}
