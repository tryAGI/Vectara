#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A span representing a top-level agent invocation.
    /// </summary>
    public readonly partial struct InvokeAgentTraceSpan : global::System.IEquatable<InvokeAgentTraceSpan>
    {
        /// <summary>
        /// Common properties shared by all agent trace span types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentTraceSpanBase? Base { get; init; }
#else
        public global::Vectara.AgentTraceSpanBase? Base { get; }
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
            out global::Vectara.AgentTraceSpanBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InvokeAgentTraceSpanVariant2? InvokeAgentTraceSpanVariant2 { get; init; }
#else
        public global::Vectara.InvokeAgentTraceSpanVariant2? InvokeAgentTraceSpanVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InvokeAgentTraceSpanVariant2))]
#endif
        public bool IsInvokeAgentTraceSpanVariant2 => InvokeAgentTraceSpanVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInvokeAgentTraceSpanVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.InvokeAgentTraceSpanVariant2? value)
        {
            value = InvokeAgentTraceSpanVariant2;
            return IsInvokeAgentTraceSpanVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvokeAgentTraceSpan(global::Vectara.AgentTraceSpanBase value) => new InvokeAgentTraceSpan((global::Vectara.AgentTraceSpanBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.AgentTraceSpanBase?(InvokeAgentTraceSpan @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public InvokeAgentTraceSpan(global::Vectara.AgentTraceSpanBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvokeAgentTraceSpan(global::Vectara.InvokeAgentTraceSpanVariant2 value) => new InvokeAgentTraceSpan((global::Vectara.InvokeAgentTraceSpanVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InvokeAgentTraceSpanVariant2?(InvokeAgentTraceSpan @this) => @this.InvokeAgentTraceSpanVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InvokeAgentTraceSpan(global::Vectara.InvokeAgentTraceSpanVariant2? value)
        {
            InvokeAgentTraceSpanVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InvokeAgentTraceSpan(
            global::Vectara.AgentTraceSpanBase? @base,
            global::Vectara.InvokeAgentTraceSpanVariant2? invokeAgentTraceSpanVariant2
            )
        {
            Base = @base;
            InvokeAgentTraceSpanVariant2 = invokeAgentTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InvokeAgentTraceSpanVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            InvokeAgentTraceSpanVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsInvokeAgentTraceSpanVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentTraceSpanBase, TResult>? @base = null,
            global::System.Func<global::Vectara.InvokeAgentTraceSpanVariant2, TResult>? invokeAgentTraceSpanVariant2 = null,
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
            else if (IsInvokeAgentTraceSpanVariant2 && invokeAgentTraceSpanVariant2 != null)
            {
                return invokeAgentTraceSpanVariant2(InvokeAgentTraceSpanVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? @base = null,

            global::System.Action<global::Vectara.InvokeAgentTraceSpanVariant2>? invokeAgentTraceSpanVariant2 = null,
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
            else if (IsInvokeAgentTraceSpanVariant2)
            {
                invokeAgentTraceSpanVariant2?.Invoke(InvokeAgentTraceSpanVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentTraceSpanBase>? @base = null,
            global::System.Action<global::Vectara.InvokeAgentTraceSpanVariant2>? invokeAgentTraceSpanVariant2 = null,
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
            else if (IsInvokeAgentTraceSpanVariant2)
            {
                invokeAgentTraceSpanVariant2?.Invoke(InvokeAgentTraceSpanVariant2!);
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
                typeof(global::Vectara.AgentTraceSpanBase),
                InvokeAgentTraceSpanVariant2,
                typeof(global::Vectara.InvokeAgentTraceSpanVariant2),
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
        public bool Equals(InvokeAgentTraceSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentTraceSpanBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InvokeAgentTraceSpanVariant2?>.Default.Equals(InvokeAgentTraceSpanVariant2, other.InvokeAgentTraceSpanVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InvokeAgentTraceSpan obj1, InvokeAgentTraceSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InvokeAgentTraceSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InvokeAgentTraceSpan obj1, InvokeAgentTraceSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InvokeAgentTraceSpan o && Equals(o);
        }
    }
}
