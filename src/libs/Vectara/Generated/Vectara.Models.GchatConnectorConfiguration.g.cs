#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a Google Chat connector's configuration. Includes the display<br/>
    /// field `client_email` parsed out of the service account key and the audience<br/>
    /// URL used to verify inbound events. The service account key is never returned.
    /// </summary>
    public readonly partial struct GchatConnectorConfiguration : global::System.IEquatable<GchatConnectorConfiguration>
    {
        /// <summary>
        /// Properties shared by every connector configuration read view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ConnectorConfigurationBase? Base { get; init; }
#else
        public global::Vectara.ConnectorConfigurationBase? Base { get; }
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
            out global::Vectara.ConnectorConfigurationBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ConnectorConfigurationBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GchatConnectorConfigurationVariant2? GchatConnectorConfigurationVariant2 { get; init; }
#else
        public global::Vectara.GchatConnectorConfigurationVariant2? GchatConnectorConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GchatConnectorConfigurationVariant2))]
#endif
        public bool IsGchatConnectorConfigurationVariant2 => GchatConnectorConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGchatConnectorConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GchatConnectorConfigurationVariant2? value)
        {
            value = GchatConnectorConfigurationVariant2;
            return IsGchatConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GchatConnectorConfigurationVariant2 PickGchatConnectorConfigurationVariant2() => IsGchatConnectorConfigurationVariant2
            ? GchatConnectorConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GchatConnectorConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GchatConnectorConfiguration(global::Vectara.ConnectorConfigurationBase value) => new GchatConnectorConfiguration((global::Vectara.ConnectorConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ConnectorConfigurationBase?(GchatConnectorConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GchatConnectorConfiguration(global::Vectara.ConnectorConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GchatConnectorConfiguration FromBase(global::Vectara.ConnectorConfigurationBase? value) => new GchatConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GchatConnectorConfiguration(global::Vectara.GchatConnectorConfigurationVariant2 value) => new GchatConnectorConfiguration((global::Vectara.GchatConnectorConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GchatConnectorConfigurationVariant2?(GchatConnectorConfiguration @this) => @this.GchatConnectorConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GchatConnectorConfiguration(global::Vectara.GchatConnectorConfigurationVariant2? value)
        {
            GchatConnectorConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GchatConnectorConfiguration FromGchatConnectorConfigurationVariant2(global::Vectara.GchatConnectorConfigurationVariant2? value) => new GchatConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public GchatConnectorConfiguration(
            global::Vectara.ConnectorConfigurationBase? @base,
            global::Vectara.GchatConnectorConfigurationVariant2? gchatConnectorConfigurationVariant2
            )
        {
            Base = @base;
            GchatConnectorConfigurationVariant2 = gchatConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GchatConnectorConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GchatConnectorConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGchatConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ConnectorConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.GchatConnectorConfigurationVariant2, TResult>? gchatConnectorConfigurationVariant2 = null,
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
            else if (IsGchatConnectorConfigurationVariant2 && gchatConnectorConfigurationVariant2 != null)
            {
                return gchatConnectorConfigurationVariant2(GchatConnectorConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.GchatConnectorConfigurationVariant2>? gchatConnectorConfigurationVariant2 = null,
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
            else if (IsGchatConnectorConfigurationVariant2)
            {
                gchatConnectorConfigurationVariant2?.Invoke(GchatConnectorConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.GchatConnectorConfigurationVariant2>? gchatConnectorConfigurationVariant2 = null,
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
            else if (IsGchatConnectorConfigurationVariant2)
            {
                gchatConnectorConfigurationVariant2?.Invoke(GchatConnectorConfigurationVariant2!);
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
                typeof(global::Vectara.ConnectorConfigurationBase),
                GchatConnectorConfigurationVariant2,
                typeof(global::Vectara.GchatConnectorConfigurationVariant2),
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
        public bool Equals(GchatConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ConnectorConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GchatConnectorConfigurationVariant2?>.Default.Equals(GchatConnectorConfigurationVariant2, other.GchatConnectorConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GchatConnectorConfiguration obj1, GchatConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GchatConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GchatConnectorConfiguration obj1, GchatConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GchatConnectorConfiguration o && Equals(o);
        }
    }
}
