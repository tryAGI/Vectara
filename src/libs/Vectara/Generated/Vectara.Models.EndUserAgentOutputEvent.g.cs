#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Always visible. A complete agent response.
    /// </summary>
    public readonly partial struct EndUserAgentOutputEvent : global::System.IEquatable<EndUserAgentOutputEvent>
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
        public global::Vectara.EndUserAgentOutputEventVariant2? EndUserAgentOutputEventVariant2 { get; init; }
#else
        public global::Vectara.EndUserAgentOutputEventVariant2? EndUserAgentOutputEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndUserAgentOutputEventVariant2))]
#endif
        public bool IsEndUserAgentOutputEventVariant2 => EndUserAgentOutputEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEndUserAgentOutputEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.EndUserAgentOutputEventVariant2? value)
        {
            value = EndUserAgentOutputEventVariant2;
            return IsEndUserAgentOutputEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.EndUserAgentOutputEventVariant2 PickEndUserAgentOutputEventVariant2() => IsEndUserAgentOutputEventVariant2
            ? EndUserAgentOutputEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndUserAgentOutputEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentOutputEvent(global::Vectara.EndUserEventBase value) => new EndUserAgentOutputEvent((global::Vectara.EndUserEventBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.EndUserEventBase?(EndUserAgentOutputEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentOutputEvent(global::Vectara.EndUserEventBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentOutputEvent FromBase(global::Vectara.EndUserEventBase? value) => new EndUserAgentOutputEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EndUserAgentOutputEvent(global::Vectara.EndUserAgentOutputEventVariant2 value) => new EndUserAgentOutputEvent((global::Vectara.EndUserAgentOutputEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.EndUserAgentOutputEventVariant2?(EndUserAgentOutputEvent @this) => @this.EndUserAgentOutputEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentOutputEvent(global::Vectara.EndUserAgentOutputEventVariant2? value)
        {
            EndUserAgentOutputEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EndUserAgentOutputEvent FromEndUserAgentOutputEventVariant2(global::Vectara.EndUserAgentOutputEventVariant2? value) => new EndUserAgentOutputEvent(value);

        /// <summary>
        ///
        /// </summary>
        public EndUserAgentOutputEvent(
            global::Vectara.EndUserEventBase? @base,
            global::Vectara.EndUserAgentOutputEventVariant2? endUserAgentOutputEventVariant2
            )
        {
            Base = @base;
            EndUserAgentOutputEventVariant2 = endUserAgentOutputEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EndUserAgentOutputEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EndUserAgentOutputEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEndUserAgentOutputEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.EndUserEventBase, TResult>? @base = null,
            global::System.Func<global::Vectara.EndUserAgentOutputEventVariant2, TResult>? endUserAgentOutputEventVariant2 = null,
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
            else if (IsEndUserAgentOutputEventVariant2 && endUserAgentOutputEventVariant2 != null)
            {
                return endUserAgentOutputEventVariant2(EndUserAgentOutputEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.EndUserEventBase>? @base = null,

            global::System.Action<global::Vectara.EndUserAgentOutputEventVariant2>? endUserAgentOutputEventVariant2 = null,
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
            else if (IsEndUserAgentOutputEventVariant2)
            {
                endUserAgentOutputEventVariant2?.Invoke(EndUserAgentOutputEventVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.EndUserEventBase>? @base = null,
            global::System.Action<global::Vectara.EndUserAgentOutputEventVariant2>? endUserAgentOutputEventVariant2 = null,
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
            else if (IsEndUserAgentOutputEventVariant2)
            {
                endUserAgentOutputEventVariant2?.Invoke(EndUserAgentOutputEventVariant2!);
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
                EndUserAgentOutputEventVariant2,
                typeof(global::Vectara.EndUserAgentOutputEventVariant2),
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
        public bool Equals(EndUserAgentOutputEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserEventBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.EndUserAgentOutputEventVariant2?>.Default.Equals(EndUserAgentOutputEventVariant2, other.EndUserAgentOutputEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EndUserAgentOutputEvent obj1, EndUserAgentOutputEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EndUserAgentOutputEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EndUserAgentOutputEvent obj1, EndUserAgentOutputEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EndUserAgentOutputEvent o && Equals(o);
        }
    }
}
