#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An event representing an image being loaded into the conversation context for viewing and analysis.
    /// </summary>
    public readonly partial struct ImageReadEvent : global::System.IEquatable<ImageReadEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentEventBase? AgentBase { get; init; }
#else
        public global::Vectara.AgentEventBase? AgentBase { get; }
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
        public global::Vectara.ImageReadEventVariant2? ImageReadEventVariant2 { get; init; }
#else
        public global::Vectara.ImageReadEventVariant2? ImageReadEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageReadEventVariant2))]
#endif
        public bool IsImageReadEventVariant2 => ImageReadEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadEvent(global::Vectara.AgentEventBase value) => new ImageReadEvent((global::Vectara.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentEventBase?(ImageReadEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadEvent(global::Vectara.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadEvent(global::Vectara.ImageReadEventVariant2 value) => new ImageReadEvent((global::Vectara.ImageReadEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ImageReadEventVariant2?(ImageReadEvent @this) => @this.ImageReadEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadEvent(global::Vectara.ImageReadEventVariant2? value)
        {
            ImageReadEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageReadEvent(
            global::Vectara.AgentEventBase? agentBase,
            global::Vectara.ImageReadEventVariant2? imageReadEventVariant2
            )
        {
            AgentBase = agentBase;
            ImageReadEventVariant2 = imageReadEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageReadEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ImageReadEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsImageReadEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ImageReadEventVariant2?, TResult>? imageReadEventVariant2 = null,
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
            else if (IsImageReadEventVariant2 && imageReadEventVariant2 != null)
            {
                return imageReadEventVariant2(ImageReadEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentEventBase?>? agentBase = null,
            global::System.Action<global::Vectara.ImageReadEventVariant2?>? imageReadEventVariant2 = null,
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
            else if (IsImageReadEventVariant2)
            {
                imageReadEventVariant2?.Invoke(ImageReadEventVariant2!);
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
                typeof(global::Vectara.AgentEventBase),
                ImageReadEventVariant2,
                typeof(global::Vectara.ImageReadEventVariant2),
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
        public bool Equals(ImageReadEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ImageReadEventVariant2?>.Default.Equals(ImageReadEventVariant2, other.ImageReadEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageReadEvent obj1, ImageReadEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageReadEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageReadEvent obj1, ImageReadEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageReadEvent o && Equals(o);
        }
    }
}
