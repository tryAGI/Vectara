#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A relayed event from a sub-agent's inner execution stream, emitted by the sub_agent tool while it runs.
    /// </summary>
    public readonly partial struct SubAgentToolActivityEvent : global::System.IEquatable<SubAgentToolActivityEvent>
    {
        /// <summary>
        /// Base properties shared by all tool activity event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolActivityEventBase? Base { get; init; }
#else
        public global::Vectara.ToolActivityEventBase? Base { get; }
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
            out global::Vectara.ToolActivityEventBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolActivityEventBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SubAgentToolActivityEventVariant2? SubAgentToolActivityEventVariant2 { get; init; }
#else
        public global::Vectara.SubAgentToolActivityEventVariant2? SubAgentToolActivityEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgentToolActivityEventVariant2))]
#endif
        public bool IsSubAgentToolActivityEventVariant2 => SubAgentToolActivityEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubAgentToolActivityEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SubAgentToolActivityEventVariant2? value)
        {
            value = SubAgentToolActivityEventVariant2;
            return IsSubAgentToolActivityEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SubAgentToolActivityEventVariant2 PickSubAgentToolActivityEventVariant2() => IsSubAgentToolActivityEventVariant2
            ? SubAgentToolActivityEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubAgentToolActivityEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentToolActivityEvent(global::Vectara.ToolActivityEventBase value) => new SubAgentToolActivityEvent((global::Vectara.ToolActivityEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolActivityEventBase?(SubAgentToolActivityEvent @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentToolActivityEvent(global::Vectara.ToolActivityEventBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SubAgentToolActivityEvent FromBase(global::Vectara.ToolActivityEventBase? value) => new SubAgentToolActivityEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentToolActivityEvent(global::Vectara.SubAgentToolActivityEventVariant2 value) => new SubAgentToolActivityEvent((global::Vectara.SubAgentToolActivityEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SubAgentToolActivityEventVariant2?(SubAgentToolActivityEvent @this) => @this.SubAgentToolActivityEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentToolActivityEvent(global::Vectara.SubAgentToolActivityEventVariant2? value)
        {
            SubAgentToolActivityEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SubAgentToolActivityEvent FromSubAgentToolActivityEventVariant2(global::Vectara.SubAgentToolActivityEventVariant2? value) => new SubAgentToolActivityEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public SubAgentToolActivityEvent(
            global::Vectara.ToolActivityEventBase? @base,
            global::Vectara.SubAgentToolActivityEventVariant2? subAgentToolActivityEventVariant2
            )
        {
            Base = @base;
            SubAgentToolActivityEventVariant2 = subAgentToolActivityEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SubAgentToolActivityEventVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SubAgentToolActivityEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSubAgentToolActivityEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolActivityEventBase, TResult>? @base = null,
            global::System.Func<global::Vectara.SubAgentToolActivityEventVariant2, TResult>? subAgentToolActivityEventVariant2 = null,
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
            else if (IsSubAgentToolActivityEventVariant2 && subAgentToolActivityEventVariant2 != null)
            {
                return subAgentToolActivityEventVariant2(SubAgentToolActivityEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolActivityEventBase>? @base = null,

            global::System.Action<global::Vectara.SubAgentToolActivityEventVariant2>? subAgentToolActivityEventVariant2 = null,
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
            else if (IsSubAgentToolActivityEventVariant2)
            {
                subAgentToolActivityEventVariant2?.Invoke(SubAgentToolActivityEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolActivityEventBase>? @base = null,
            global::System.Action<global::Vectara.SubAgentToolActivityEventVariant2>? subAgentToolActivityEventVariant2 = null,
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
            else if (IsSubAgentToolActivityEventVariant2)
            {
                subAgentToolActivityEventVariant2?.Invoke(SubAgentToolActivityEventVariant2!);
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
                typeof(global::Vectara.ToolActivityEventBase),
                SubAgentToolActivityEventVariant2,
                typeof(global::Vectara.SubAgentToolActivityEventVariant2),
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
        public bool Equals(SubAgentToolActivityEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolActivityEventBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SubAgentToolActivityEventVariant2?>.Default.Equals(SubAgentToolActivityEventVariant2, other.SubAgentToolActivityEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SubAgentToolActivityEvent obj1, SubAgentToolActivityEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SubAgentToolActivityEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SubAgentToolActivityEvent obj1, SubAgentToolActivityEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubAgentToolActivityEvent o && Equals(o);
        }
    }
}
