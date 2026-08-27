#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a Google Chat connector.
    /// </summary>
    public readonly partial struct GchatAgentConnector : global::System.IEquatable<GchatAgentConnector>
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
        public global::Vectara.GchatAgentConnectorVariant2? GchatAgentConnectorVariant2 { get; init; }
#else
        public global::Vectara.GchatAgentConnectorVariant2? GchatAgentConnectorVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GchatAgentConnectorVariant2))]
#endif
        public bool IsGchatAgentConnectorVariant2 => GchatAgentConnectorVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGchatAgentConnectorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GchatAgentConnectorVariant2? value)
        {
            value = GchatAgentConnectorVariant2;
            return IsGchatAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatAgentConnectorVariant2 PickGchatAgentConnectorVariant2() => IsGchatAgentConnectorVariant2
            ? GchatAgentConnectorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GchatAgentConnectorVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GchatAgentConnector(global::Vectara.AgentConnectorBase value) => new GchatAgentConnector((global::Vectara.AgentConnectorBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.AgentConnectorBase?(GchatAgentConnector @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public GchatAgentConnector(global::Vectara.AgentConnectorBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GchatAgentConnector FromBase(global::Vectara.AgentConnectorBase? value) => new GchatAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GchatAgentConnector(global::Vectara.GchatAgentConnectorVariant2 value) => new GchatAgentConnector((global::Vectara.GchatAgentConnectorVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.GchatAgentConnectorVariant2?(GchatAgentConnector @this) => @this.GchatAgentConnectorVariant2;

        /// <summary>
        ///
        /// </summary>
        public GchatAgentConnector(global::Vectara.GchatAgentConnectorVariant2? value)
        {
            GchatAgentConnectorVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GchatAgentConnector FromGchatAgentConnectorVariant2(global::Vectara.GchatAgentConnectorVariant2? value) => new GchatAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public GchatAgentConnector(
            global::Vectara.AgentConnectorBase? @base,
            global::Vectara.GchatAgentConnectorVariant2? gchatAgentConnectorVariant2
            )
        {
            Base = @base;
            GchatAgentConnectorVariant2 = gchatAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GchatAgentConnectorVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GchatAgentConnectorVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGchatAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentConnectorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.GchatAgentConnectorVariant2, TResult>? gchatAgentConnectorVariant2 = null,
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
            else if (IsGchatAgentConnectorVariant2 && gchatAgentConnectorVariant2 != null)
            {
                return gchatAgentConnectorVariant2(GchatAgentConnectorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,

            global::System.Action<global::Vectara.GchatAgentConnectorVariant2>? gchatAgentConnectorVariant2 = null,
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
            else if (IsGchatAgentConnectorVariant2)
            {
                gchatAgentConnectorVariant2?.Invoke(GchatAgentConnectorVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,
            global::System.Action<global::Vectara.GchatAgentConnectorVariant2>? gchatAgentConnectorVariant2 = null,
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
            else if (IsGchatAgentConnectorVariant2)
            {
                gchatAgentConnectorVariant2?.Invoke(GchatAgentConnectorVariant2!);
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
                GchatAgentConnectorVariant2,
                typeof(global::Vectara.GchatAgentConnectorVariant2),
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
        public bool Equals(GchatAgentConnector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentConnectorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GchatAgentConnectorVariant2?>.Default.Equals(GchatAgentConnectorVariant2, other.GchatAgentConnectorVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GchatAgentConnector obj1, GchatAgentConnector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GchatAgentConnector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GchatAgentConnector obj1, GchatAgentConnector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GchatAgentConnector o && Equals(o);
        }
    }
}
