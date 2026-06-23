#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a connector's configuration as returned by GET and list<br/>
    /// endpoints. Contains the secrets supplied at create time alongside<br/>
    /// server-derived display fields: Slack exposes `webhook_path`, gchat<br/>
    /// exposes `audience_url` and `client_email`, and zoom exposes the<br/>
    /// generated `connector_token` and `webhook_path`.
    /// </summary>
    public readonly partial struct ConnectorConfiguration : global::System.IEquatable<ConnectorConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminatorType? Type { get; }

        /// <summary>
        /// Read view of a Slack connector's configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SlackConnectorConfiguration? Slack { get; init; }
#else
        public global::Vectara.SlackConnectorConfiguration? Slack { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Slack))]
#endif
        public bool IsSlack => Slack != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSlack(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SlackConnectorConfiguration? value)
        {
            value = Slack;
            return IsSlack;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SlackConnectorConfiguration PickSlack() => IsSlack
            ? Slack!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slack' but the value was {ToString()}.");

        /// <summary>
        /// Read view of a Google Chat connector's configuration. Includes the display<br/>
        /// fields `client_email` and `project_id` parsed out of the service account key,<br/>
        /// and the audience URL used to verify inbound events. The service account key is<br/>
        /// never returned.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GchatConnectorConfiguration? Gchat { get; init; }
#else
        public global::Vectara.GchatConnectorConfiguration? Gchat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gchat))]
#endif
        public bool IsGchat => Gchat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGchat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GchatConnectorConfiguration? value)
        {
            value = Gchat;
            return IsGchat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GchatConnectorConfiguration PickGchat() => IsGchat
            ? Gchat!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gchat' but the value was {ToString()}.");

        /// <summary>
        /// Read view of a Zoom Contact Center connector's configuration. Includes the<br/>
        /// server-generated `connector_token` to configure as the `x-zoom-connector-token` header on the<br/>
        /// Zoom Contact Center bot connector, and the `webhook_path` to configure as<br/>
        /// the bot endpoint URL. The agent's reply is always delivered asynchronously.<br/>
        /// The webhook returns a typing indicator and the reply is POSTed to<br/>
        /// `callback_url` when the agent finishes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ZoomConnectorConfiguration? Zoom { get; init; }
#else
        public global::Vectara.ZoomConnectorConfiguration? Zoom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Zoom))]
#endif
        public bool IsZoom => Zoom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickZoom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ZoomConnectorConfiguration? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ZoomConnectorConfiguration PickZoom() => IsZoom
            ? Zoom!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConnectorConfiguration(global::Vectara.SlackConnectorConfiguration value) => new ConnectorConfiguration((global::Vectara.SlackConnectorConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SlackConnectorConfiguration?(ConnectorConfiguration @this) => @this.Slack;

        /// <summary>
        /// 
        /// </summary>
        public ConnectorConfiguration(global::Vectara.SlackConnectorConfiguration? value)
        {
            Slack = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConnectorConfiguration FromSlack(global::Vectara.SlackConnectorConfiguration? value) => new ConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConnectorConfiguration(global::Vectara.GchatConnectorConfiguration value) => new ConnectorConfiguration((global::Vectara.GchatConnectorConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GchatConnectorConfiguration?(ConnectorConfiguration @this) => @this.Gchat;

        /// <summary>
        /// 
        /// </summary>
        public ConnectorConfiguration(global::Vectara.GchatConnectorConfiguration? value)
        {
            Gchat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConnectorConfiguration FromGchat(global::Vectara.GchatConnectorConfiguration? value) => new ConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConnectorConfiguration(global::Vectara.ZoomConnectorConfiguration value) => new ConnectorConfiguration((global::Vectara.ZoomConnectorConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ZoomConnectorConfiguration?(ConnectorConfiguration @this) => @this.Zoom;

        /// <summary>
        /// 
        /// </summary>
        public ConnectorConfiguration(global::Vectara.ZoomConnectorConfiguration? value)
        {
            Zoom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ConnectorConfiguration FromZoom(global::Vectara.ZoomConnectorConfiguration? value) => new ConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public ConnectorConfiguration(
            global::Vectara.ConnectorConfigurationDiscriminatorType? type,
            global::Vectara.SlackConnectorConfiguration? slack,
            global::Vectara.GchatConnectorConfiguration? gchat,
            global::Vectara.ZoomConnectorConfiguration? zoom
            )
        {
            Type = type;

            Slack = slack;
            Gchat = gchat;
            Zoom = zoom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Zoom as object ??
            Gchat as object ??
            Slack as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Slack?.ToString() ??
            Gchat?.ToString() ??
            Zoom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSlack && !IsGchat && !IsZoom || !IsSlack && IsGchat && !IsZoom || !IsSlack && !IsGchat && IsZoom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SlackConnectorConfiguration?, TResult>? slack = null,
            global::System.Func<global::Vectara.GchatConnectorConfiguration?, TResult>? gchat = null,
            global::System.Func<global::Vectara.ZoomConnectorConfiguration?, TResult>? zoom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlack && slack != null)
            {
                return slack(Slack!);
            }
            else if (IsGchat && gchat != null)
            {
                return gchat(Gchat!);
            }
            else if (IsZoom && zoom != null)
            {
                return zoom(Zoom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SlackConnectorConfiguration?>? slack = null,

            global::System.Action<global::Vectara.GchatConnectorConfiguration?>? gchat = null,

            global::System.Action<global::Vectara.ZoomConnectorConfiguration?>? zoom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlack)
            {
                slack?.Invoke(Slack!);
            }
            else if (IsGchat)
            {
                gchat?.Invoke(Gchat!);
            }
            else if (IsZoom)
            {
                zoom?.Invoke(Zoom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SlackConnectorConfiguration?>? slack = null,
            global::System.Action<global::Vectara.GchatConnectorConfiguration?>? gchat = null,
            global::System.Action<global::Vectara.ZoomConnectorConfiguration?>? zoom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlack)
            {
                slack?.Invoke(Slack!);
            }
            else if (IsGchat)
            {
                gchat?.Invoke(Gchat!);
            }
            else if (IsZoom)
            {
                zoom?.Invoke(Zoom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Slack,
                typeof(global::Vectara.SlackConnectorConfiguration),
                Gchat,
                typeof(global::Vectara.GchatConnectorConfiguration),
                Zoom,
                typeof(global::Vectara.ZoomConnectorConfiguration),
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
        public bool Equals(ConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SlackConnectorConfiguration?>.Default.Equals(Slack, other.Slack) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GchatConnectorConfiguration?>.Default.Equals(Gchat, other.Gchat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ZoomConnectorConfiguration?>.Default.Equals(Zoom, other.Zoom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConnectorConfiguration obj1, ConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConnectorConfiguration obj1, ConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConnectorConfiguration o && Equals(o);
        }
    }
}
