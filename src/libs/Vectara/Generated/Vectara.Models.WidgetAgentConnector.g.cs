#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a web widget connector.
    /// </summary>
    public readonly partial struct WidgetAgentConnector : global::System.IEquatable<WidgetAgentConnector>
    {
        /// <summary>
        /// Properties shared by every connector read view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentConnectorBase? Base { get; init; }
#else
        public global::Vectara.AgentConnectorBase? Base { get; }
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
            out global::Vectara.AgentConnectorBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnectorBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WidgetAgentConnectorVariant2? WidgetAgentConnectorVariant2 { get; init; }
#else
        public global::Vectara.WidgetAgentConnectorVariant2? WidgetAgentConnectorVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WidgetAgentConnectorVariant2))]
#endif
        public bool IsWidgetAgentConnectorVariant2 => WidgetAgentConnectorVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWidgetAgentConnectorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WidgetAgentConnectorVariant2? value)
        {
            value = WidgetAgentConnectorVariant2;
            return IsWidgetAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetAgentConnectorVariant2 PickWidgetAgentConnectorVariant2() => IsWidgetAgentConnectorVariant2
            ? WidgetAgentConnectorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WidgetAgentConnectorVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WidgetAgentConnector(global::Vectara.AgentConnectorBase value) => new WidgetAgentConnector((global::Vectara.AgentConnectorBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.AgentConnectorBase?(WidgetAgentConnector @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public WidgetAgentConnector(global::Vectara.AgentConnectorBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WidgetAgentConnector FromBase(global::Vectara.AgentConnectorBase? value) => new WidgetAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WidgetAgentConnector(global::Vectara.WidgetAgentConnectorVariant2 value) => new WidgetAgentConnector((global::Vectara.WidgetAgentConnectorVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WidgetAgentConnectorVariant2?(WidgetAgentConnector @this) => @this.WidgetAgentConnectorVariant2;

        /// <summary>
        ///
        /// </summary>
        public WidgetAgentConnector(global::Vectara.WidgetAgentConnectorVariant2? value)
        {
            WidgetAgentConnectorVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WidgetAgentConnector FromWidgetAgentConnectorVariant2(global::Vectara.WidgetAgentConnectorVariant2? value) => new WidgetAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public WidgetAgentConnector(
            global::Vectara.AgentConnectorBase? @base,
            global::Vectara.WidgetAgentConnectorVariant2? widgetAgentConnectorVariant2
            )
        {
            Base = @base;
            WidgetAgentConnectorVariant2 = widgetAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WidgetAgentConnectorVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WidgetAgentConnectorVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWidgetAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentConnectorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.WidgetAgentConnectorVariant2, TResult>? widgetAgentConnectorVariant2 = null,
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
            else if (IsWidgetAgentConnectorVariant2 && widgetAgentConnectorVariant2 != null)
            {
                return widgetAgentConnectorVariant2(WidgetAgentConnectorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,

            global::System.Action<global::Vectara.WidgetAgentConnectorVariant2>? widgetAgentConnectorVariant2 = null,
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
            else if (IsWidgetAgentConnectorVariant2)
            {
                widgetAgentConnectorVariant2?.Invoke(WidgetAgentConnectorVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,
            global::System.Action<global::Vectara.WidgetAgentConnectorVariant2>? widgetAgentConnectorVariant2 = null,
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
            else if (IsWidgetAgentConnectorVariant2)
            {
                widgetAgentConnectorVariant2?.Invoke(WidgetAgentConnectorVariant2!);
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
                typeof(global::Vectara.AgentConnectorBase),
                WidgetAgentConnectorVariant2,
                typeof(global::Vectara.WidgetAgentConnectorVariant2),
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
        public bool Equals(WidgetAgentConnector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentConnectorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WidgetAgentConnectorVariant2?>.Default.Equals(WidgetAgentConnectorVariant2, other.WidgetAgentConnectorVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WidgetAgentConnector obj1, WidgetAgentConnector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WidgetAgentConnector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WidgetAgentConnector obj1, WidgetAgentConnector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WidgetAgentConnector o && Equals(o);
        }
    }
}
