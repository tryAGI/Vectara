#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a Zoom Contact Center connector's configuration. Includes the<br/>
    /// server-generated `connector_token` to configure as the `x-zoom-connector-token` header on the<br/>
    /// Zoom Contact Center bot connector, and the `webhook_path` to configure as<br/>
    /// the bot endpoint URL. The agent's reply is always delivered asynchronously.<br/>
    /// The webhook returns a typing indicator and the reply is POSTed to<br/>
    /// `callback_url` when the agent finishes.
    /// </summary>
    public readonly partial struct ZoomConnectorConfiguration : global::System.IEquatable<ZoomConnectorConfiguration>
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
        public global::Vectara.ZoomConnectorConfigurationVariant2? ZoomConnectorConfigurationVariant2 { get; init; }
#else
        public global::Vectara.ZoomConnectorConfigurationVariant2? ZoomConnectorConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ZoomConnectorConfigurationVariant2))]
#endif
        public bool IsZoomConnectorConfigurationVariant2 => ZoomConnectorConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickZoomConnectorConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ZoomConnectorConfigurationVariant2? value)
        {
            value = ZoomConnectorConfigurationVariant2;
            return IsZoomConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ZoomConnectorConfigurationVariant2 PickZoomConnectorConfigurationVariant2() => IsZoomConnectorConfigurationVariant2
            ? ZoomConnectorConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ZoomConnectorConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ZoomConnectorConfiguration(global::Vectara.ConnectorConfigurationBase value) => new ZoomConnectorConfiguration((global::Vectara.ConnectorConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ConnectorConfigurationBase?(ZoomConnectorConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ZoomConnectorConfiguration(global::Vectara.ConnectorConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ZoomConnectorConfiguration FromBase(global::Vectara.ConnectorConfigurationBase? value) => new ZoomConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ZoomConnectorConfiguration(global::Vectara.ZoomConnectorConfigurationVariant2 value) => new ZoomConnectorConfiguration((global::Vectara.ZoomConnectorConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ZoomConnectorConfigurationVariant2?(ZoomConnectorConfiguration @this) => @this.ZoomConnectorConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ZoomConnectorConfiguration(global::Vectara.ZoomConnectorConfigurationVariant2? value)
        {
            ZoomConnectorConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ZoomConnectorConfiguration FromZoomConnectorConfigurationVariant2(global::Vectara.ZoomConnectorConfigurationVariant2? value) => new ZoomConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public ZoomConnectorConfiguration(
            global::Vectara.ConnectorConfigurationBase? @base,
            global::Vectara.ZoomConnectorConfigurationVariant2? zoomConnectorConfigurationVariant2
            )
        {
            Base = @base;
            ZoomConnectorConfigurationVariant2 = zoomConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ZoomConnectorConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ZoomConnectorConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsZoomConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ConnectorConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ZoomConnectorConfigurationVariant2, TResult>? zoomConnectorConfigurationVariant2 = null,
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
            else if (IsZoomConnectorConfigurationVariant2 && zoomConnectorConfigurationVariant2 != null)
            {
                return zoomConnectorConfigurationVariant2(ZoomConnectorConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.ZoomConnectorConfigurationVariant2>? zoomConnectorConfigurationVariant2 = null,
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
            else if (IsZoomConnectorConfigurationVariant2)
            {
                zoomConnectorConfigurationVariant2?.Invoke(ZoomConnectorConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.ZoomConnectorConfigurationVariant2>? zoomConnectorConfigurationVariant2 = null,
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
            else if (IsZoomConnectorConfigurationVariant2)
            {
                zoomConnectorConfigurationVariant2?.Invoke(ZoomConnectorConfigurationVariant2!);
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
                ZoomConnectorConfigurationVariant2,
                typeof(global::Vectara.ZoomConnectorConfigurationVariant2),
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
        public bool Equals(ZoomConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ConnectorConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ZoomConnectorConfigurationVariant2?>.Default.Equals(ZoomConnectorConfigurationVariant2, other.ZoomConnectorConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ZoomConnectorConfiguration obj1, ZoomConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ZoomConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ZoomConnectorConfiguration obj1, ZoomConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ZoomConnectorConfiguration o && Equals(o);
        }
    }
}
