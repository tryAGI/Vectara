#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing a single LLM chat completion call within an agent turn.
    /// </summary>
    public readonly partial struct ChatTraceSpan : global::System.IEquatable<ChatTraceSpan>
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
        public bool TryPickAgentBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.AgentTraceSpanBase? value)
        {
            value = AgentBase;
            return IsAgentBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AgentTraceSpanBase PickAgentBase() => IsAgentBase
            ? AgentBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ChatTraceSpanVariant2? ChatTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.ChatTraceSpanVariant2? ChatTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatTraceSpanVariant2))]
#endif
        public bool IsChatTraceSpanVariant2 => ChatTraceSpanVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChatTraceSpanVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ChatTraceSpanVariant2? value)
        {
            value = ChatTraceSpanVariant2;
            return IsChatTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ChatTraceSpanVariant2 PickChatTraceSpanVariant2() => IsChatTraceSpanVariant2
            ? ChatTraceSpanVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatTraceSpanVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatTraceSpan(global::Vectara.AgentTraceSpanBase value) => new ChatTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(ChatTraceSpan @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ChatTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatTraceSpan FromAgentBase(global::Vectara.AgentTraceSpanBase? value) => new ChatTraceSpan(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatTraceSpan(global::Vectara.ChatTraceSpanVariant2 value) => new ChatTraceSpan((global::Vectara.ChatTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ChatTraceSpanVariant2?(ChatTraceSpan @this) => @this.ChatTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ChatTraceSpan(global::Vectara.ChatTraceSpanVariant2? value)
        {
            ChatTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatTraceSpan FromChatTraceSpanVariant2(global::Vectara.ChatTraceSpanVariant2? value) => new ChatTraceSpan(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatTraceSpan(
            global::Vectara.AgentTraceSpanBase? agentBase,
            global::Vectara.ChatTraceSpanVariant2? chatTraceSpanVariant2
            )
        {
            AgentBase = agentBase;
            ChatTraceSpanVariant2 = chatTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatTraceSpanVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ChatTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsChatTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase, TResult>? agentBase = null,
            global::System.Func<global::Vectara.ChatTraceSpanVariant2, TResult>? chatTraceSpanVariant2 = null,
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
            else if (IsChatTraceSpanVariant2 && chatTraceSpanVariant2 != null)
            {
                return chatTraceSpanVariant2(ChatTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,

            global::System.Action<global::Vectara.ChatTraceSpanVariant2>? chatTraceSpanVariant2 = null,
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
            else if (IsChatTraceSpanVariant2)
            {
                chatTraceSpanVariant2?.Invoke(ChatTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? agentBase = null,
            global::System.Action<global::Vectara.ChatTraceSpanVariant2>? chatTraceSpanVariant2 = null,
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
            else if (IsChatTraceSpanVariant2)
            {
                chatTraceSpanVariant2?.Invoke(ChatTraceSpanVariant2!);
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
                ChatTraceSpanVariant2,
                typeof(global::Vectara.ChatTraceSpanVariant2),
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
        public bool Equals(ChatTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ChatTraceSpanVariant2?>.Default.Equals(ChatTraceSpanVariant2, other.ChatTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatTraceSpan obj1, ChatTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatTraceSpan obj1, ChatTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatTraceSpan o && Equals(o);
        }
    }
}
