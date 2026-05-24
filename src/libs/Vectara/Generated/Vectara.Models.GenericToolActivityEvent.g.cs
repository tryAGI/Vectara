#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A free-form progress update from a tool. The only payload is a human-readable message.
    /// </summary>
    public readonly partial struct GenericToolActivityEvent : global::System.IEquatable<GenericToolActivityEvent>
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
        public global::Vectara.GenericToolActivityEventVariant2? GenericToolActivityEventVariant2 { get; init; }
#else
        public global::Vectara.GenericToolActivityEventVariant2? GenericToolActivityEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenericToolActivityEventVariant2))]
#endif
        public bool IsGenericToolActivityEventVariant2 => GenericToolActivityEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGenericToolActivityEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GenericToolActivityEventVariant2? value)
        {
            value = GenericToolActivityEventVariant2;
            return IsGenericToolActivityEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GenericToolActivityEventVariant2 PickGenericToolActivityEventVariant2() => IsGenericToolActivityEventVariant2
            ? GenericToolActivityEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GenericToolActivityEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenericToolActivityEvent(global::Vectara.ToolActivityEventBase value) => new GenericToolActivityEvent((global::Vectara.ToolActivityEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolActivityEventBase?(GenericToolActivityEvent @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GenericToolActivityEvent(global::Vectara.ToolActivityEventBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenericToolActivityEvent FromBase(global::Vectara.ToolActivityEventBase? value) => new GenericToolActivityEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenericToolActivityEvent(global::Vectara.GenericToolActivityEventVariant2 value) => new GenericToolActivityEvent((global::Vectara.GenericToolActivityEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GenericToolActivityEventVariant2?(GenericToolActivityEvent @this) => @this.GenericToolActivityEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GenericToolActivityEvent(global::Vectara.GenericToolActivityEventVariant2? value)
        {
            GenericToolActivityEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenericToolActivityEvent FromGenericToolActivityEventVariant2(global::Vectara.GenericToolActivityEventVariant2? value) => new GenericToolActivityEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public GenericToolActivityEvent(
            global::Vectara.ToolActivityEventBase? @base,
            global::Vectara.GenericToolActivityEventVariant2? genericToolActivityEventVariant2
            )
        {
            Base = @base;
            GenericToolActivityEventVariant2 = genericToolActivityEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenericToolActivityEventVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GenericToolActivityEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGenericToolActivityEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolActivityEventBase, TResult>? @base = null,
            global::System.Func<global::Vectara.GenericToolActivityEventVariant2, TResult>? genericToolActivityEventVariant2 = null,
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
            else if (IsGenericToolActivityEventVariant2 && genericToolActivityEventVariant2 != null)
            {
                return genericToolActivityEventVariant2(GenericToolActivityEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolActivityEventBase>? @base = null,

            global::System.Action<global::Vectara.GenericToolActivityEventVariant2>? genericToolActivityEventVariant2 = null,
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
            else if (IsGenericToolActivityEventVariant2)
            {
                genericToolActivityEventVariant2?.Invoke(GenericToolActivityEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolActivityEventBase>? @base = null,
            global::System.Action<global::Vectara.GenericToolActivityEventVariant2>? genericToolActivityEventVariant2 = null,
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
            else if (IsGenericToolActivityEventVariant2)
            {
                genericToolActivityEventVariant2?.Invoke(GenericToolActivityEventVariant2!);
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
                GenericToolActivityEventVariant2,
                typeof(global::Vectara.GenericToolActivityEventVariant2),
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
        public bool Equals(GenericToolActivityEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolActivityEventBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GenericToolActivityEventVariant2?>.Default.Equals(GenericToolActivityEventVariant2, other.GenericToolActivityEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenericToolActivityEvent obj1, GenericToolActivityEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenericToolActivityEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenericToolActivityEvent obj1, GenericToolActivityEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenericToolActivityEvent o && Equals(o);
        }
    }
}
