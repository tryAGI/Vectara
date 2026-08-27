#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a Zoom Contact Center connector.
    /// </summary>
    public readonly partial struct ZoomAgentConnector : global::System.IEquatable<ZoomAgentConnector>
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
        public global::Vectara.ZoomAgentConnectorVariant2? ZoomAgentConnectorVariant2 { get; init; }
#else
        public global::Vectara.ZoomAgentConnectorVariant2? ZoomAgentConnectorVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ZoomAgentConnectorVariant2))]
#endif
        public bool IsZoomAgentConnectorVariant2 => ZoomAgentConnectorVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickZoomAgentConnectorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ZoomAgentConnectorVariant2? value)
        {
            value = ZoomAgentConnectorVariant2;
            return IsZoomAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomAgentConnectorVariant2 PickZoomAgentConnectorVariant2() => IsZoomAgentConnectorVariant2
            ? ZoomAgentConnectorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ZoomAgentConnectorVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ZoomAgentConnector(global::Vectara.AgentConnectorBase value) => new ZoomAgentConnector((global::Vectara.AgentConnectorBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.AgentConnectorBase?(ZoomAgentConnector @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ZoomAgentConnector(global::Vectara.AgentConnectorBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ZoomAgentConnector FromBase(global::Vectara.AgentConnectorBase? value) => new ZoomAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ZoomAgentConnector(global::Vectara.ZoomAgentConnectorVariant2 value) => new ZoomAgentConnector((global::Vectara.ZoomAgentConnectorVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ZoomAgentConnectorVariant2?(ZoomAgentConnector @this) => @this.ZoomAgentConnectorVariant2;

        /// <summary>
        ///
        /// </summary>
        public ZoomAgentConnector(global::Vectara.ZoomAgentConnectorVariant2? value)
        {
            ZoomAgentConnectorVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ZoomAgentConnector FromZoomAgentConnectorVariant2(global::Vectara.ZoomAgentConnectorVariant2? value) => new ZoomAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public ZoomAgentConnector(
            global::Vectara.AgentConnectorBase? @base,
            global::Vectara.ZoomAgentConnectorVariant2? zoomAgentConnectorVariant2
            )
        {
            Base = @base;
            ZoomAgentConnectorVariant2 = zoomAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ZoomAgentConnectorVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ZoomAgentConnectorVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsZoomAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentConnectorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ZoomAgentConnectorVariant2, TResult>? zoomAgentConnectorVariant2 = null,
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
            else if (IsZoomAgentConnectorVariant2 && zoomAgentConnectorVariant2 != null)
            {
                return zoomAgentConnectorVariant2(ZoomAgentConnectorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,

            global::System.Action<global::Vectara.ZoomAgentConnectorVariant2>? zoomAgentConnectorVariant2 = null,
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
            else if (IsZoomAgentConnectorVariant2)
            {
                zoomAgentConnectorVariant2?.Invoke(ZoomAgentConnectorVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,
            global::System.Action<global::Vectara.ZoomAgentConnectorVariant2>? zoomAgentConnectorVariant2 = null,
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
            else if (IsZoomAgentConnectorVariant2)
            {
                zoomAgentConnectorVariant2?.Invoke(ZoomAgentConnectorVariant2!);
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
                ZoomAgentConnectorVariant2,
                typeof(global::Vectara.ZoomAgentConnectorVariant2),
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
        public bool Equals(ZoomAgentConnector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentConnectorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ZoomAgentConnectorVariant2?>.Default.Equals(ZoomAgentConnectorVariant2, other.ZoomAgentConnectorVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ZoomAgentConnector obj1, ZoomAgentConnector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ZoomAgentConnector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ZoomAgentConnector obj1, ZoomAgentConnector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ZoomAgentConnector o && Equals(o);
        }
    }
}
