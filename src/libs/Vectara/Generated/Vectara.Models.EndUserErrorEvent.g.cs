#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Always visible. A turn-ending event emitted when the turn fails. `message` is a generic failure string and does not identify the<br/>
    /// underlying cause.
    /// </summary>
    public readonly partial struct EndUserErrorEvent : global::System.IEquatable<EndUserErrorEvent>
    {
        /// <summary>
        /// Base properties shared by all end-user event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.EndUserEventBase? Base { get; init; }
#else
        public global::Vectara.EndUserEventBase? Base { get; }
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
            out global::Vectara.EndUserEventBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EndUserEventBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.EndUserErrorEventVariant2? EndUserErrorEventVariant2 { get; init; }
#else
        public global::Vectara.EndUserErrorEventVariant2? EndUserErrorEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndUserErrorEventVariant2))]
#endif
        public bool IsEndUserErrorEventVariant2 => EndUserErrorEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEndUserErrorEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.EndUserErrorEventVariant2? value)
        {
            value = EndUserErrorEventVariant2;
            return IsEndUserErrorEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.EndUserErrorEventVariant2 PickEndUserErrorEventVariant2() => IsEndUserErrorEventVariant2
            ? EndUserErrorEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndUserErrorEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserErrorEvent(global::Vectara.EndUserEventBase value) => new EndUserErrorEvent((global::Vectara.EndUserEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserEventBase?(EndUserErrorEvent @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public EndUserErrorEvent(global::Vectara.EndUserEventBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserErrorEvent FromBase(global::Vectara.EndUserEventBase? value) => new EndUserErrorEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndUserErrorEvent(global::Vectara.EndUserErrorEventVariant2 value) => new EndUserErrorEvent((global::Vectara.EndUserErrorEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.EndUserErrorEventVariant2?(EndUserErrorEvent @this) => @this.EndUserErrorEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EndUserErrorEvent(global::Vectara.EndUserErrorEventVariant2? value)
        {
            EndUserErrorEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EndUserErrorEvent FromEndUserErrorEventVariant2(global::Vectara.EndUserErrorEventVariant2? value) => new EndUserErrorEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public EndUserErrorEvent(
            global::Vectara.EndUserEventBase? @base,
            global::Vectara.EndUserErrorEventVariant2? endUserErrorEventVariant2
            )
        {
            Base = @base;
            EndUserErrorEventVariant2 = endUserErrorEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EndUserErrorEventVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EndUserErrorEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEndUserErrorEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.EndUserEventBase, TResult>? @base = null,
            global::System.Func<global::Vectara.EndUserErrorEventVariant2, TResult>? endUserErrorEventVariant2 = null,
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
            else if (IsEndUserErrorEventVariant2 && endUserErrorEventVariant2 != null)
            {
                return endUserErrorEventVariant2(EndUserErrorEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.EndUserEventBase>? @base = null,

            global::System.Action<global::Vectara.EndUserErrorEventVariant2>? endUserErrorEventVariant2 = null,
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
            else if (IsEndUserErrorEventVariant2)
            {
                endUserErrorEventVariant2?.Invoke(EndUserErrorEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.EndUserEventBase>? @base = null,
            global::System.Action<global::Vectara.EndUserErrorEventVariant2>? endUserErrorEventVariant2 = null,
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
            else if (IsEndUserErrorEventVariant2)
            {
                endUserErrorEventVariant2?.Invoke(EndUserErrorEventVariant2!);
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
                typeof(global::Vectara.EndUserEventBase),
                EndUserErrorEventVariant2,
                typeof(global::Vectara.EndUserErrorEventVariant2),
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
        public bool Equals(EndUserErrorEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserEventBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserErrorEventVariant2?>.Default.Equals(EndUserErrorEventVariant2, other.EndUserErrorEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EndUserErrorEvent obj1, EndUserErrorEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EndUserErrorEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EndUserErrorEvent obj1, EndUserErrorEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EndUserErrorEvent o && Equals(o);
        }
    }
}
