#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Always visible. An input message from the end user.
    /// </summary>
    public readonly partial struct EndUserInputMessageEvent : global::System.IEquatable<EndUserInputMessageEvent>
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
        public global::Vectara.EndUserInputMessageEventVariant2? EndUserInputMessageEventVariant2 { get; init; }
#else
        public global::Vectara.EndUserInputMessageEventVariant2? EndUserInputMessageEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndUserInputMessageEventVariant2))]
#endif
        public bool IsEndUserInputMessageEventVariant2 => EndUserInputMessageEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEndUserInputMessageEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.EndUserInputMessageEventVariant2? value)
        {
            value = EndUserInputMessageEventVariant2;
            return IsEndUserInputMessageEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserInputMessageEventVariant2 PickEndUserInputMessageEventVariant2() => IsEndUserInputMessageEventVariant2
            ? EndUserInputMessageEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndUserInputMessageEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserInputMessageEvent(global::Vectara.EndUserEventBase value) => new EndUserInputMessageEvent((global::Vectara.EndUserEventBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.EndUserEventBase?(EndUserInputMessageEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public EndUserInputMessageEvent(global::Vectara.EndUserEventBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserInputMessageEvent FromBase(global::Vectara.EndUserEventBase? value) => new EndUserInputMessageEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserInputMessageEvent(global::Vectara.EndUserInputMessageEventVariant2 value) => new EndUserInputMessageEvent((global::Vectara.EndUserInputMessageEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.EndUserInputMessageEventVariant2?(EndUserInputMessageEvent @this) => @this.EndUserInputMessageEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public EndUserInputMessageEvent(global::Vectara.EndUserInputMessageEventVariant2? value)
        {
            EndUserInputMessageEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserInputMessageEvent FromEndUserInputMessageEventVariant2(global::Vectara.EndUserInputMessageEventVariant2? value) => new EndUserInputMessageEvent(value);

        /// <summary>
        ///
        /// </summary>
        public EndUserInputMessageEvent(
            global::Vectara.EndUserEventBase? @base,
            global::Vectara.EndUserInputMessageEventVariant2? endUserInputMessageEventVariant2
            )
        {
            Base = @base;
            EndUserInputMessageEventVariant2 = endUserInputMessageEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EndUserInputMessageEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EndUserInputMessageEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEndUserInputMessageEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.EndUserEventBase, TResult>? @base = null,
            global::System.Func<global::Vectara.EndUserInputMessageEventVariant2, TResult>? endUserInputMessageEventVariant2 = null,
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
            else if (IsEndUserInputMessageEventVariant2 && endUserInputMessageEventVariant2 != null)
            {
                return endUserInputMessageEventVariant2(EndUserInputMessageEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.EndUserEventBase>? @base = null,

            global::System.Action<global::Vectara.EndUserInputMessageEventVariant2>? endUserInputMessageEventVariant2 = null,
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
            else if (IsEndUserInputMessageEventVariant2)
            {
                endUserInputMessageEventVariant2?.Invoke(EndUserInputMessageEventVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.EndUserEventBase>? @base = null,
            global::System.Action<global::Vectara.EndUserInputMessageEventVariant2>? endUserInputMessageEventVariant2 = null,
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
            else if (IsEndUserInputMessageEventVariant2)
            {
                endUserInputMessageEventVariant2?.Invoke(EndUserInputMessageEventVariant2!);
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
                EndUserInputMessageEventVariant2,
                typeof(global::Vectara.EndUserInputMessageEventVariant2),
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
        public bool Equals(EndUserInputMessageEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserEventBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserInputMessageEventVariant2?>.Default.Equals(EndUserInputMessageEventVariant2, other.EndUserInputMessageEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EndUserInputMessageEvent obj1, EndUserInputMessageEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EndUserInputMessageEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EndUserInputMessageEvent obj1, EndUserInputMessageEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EndUserInputMessageEvent o && Equals(o);
        }
    }
}
