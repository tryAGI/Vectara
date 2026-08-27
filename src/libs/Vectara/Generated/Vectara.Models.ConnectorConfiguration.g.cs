#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a connector's configuration, as returned by GET and list<br/>
    /// endpoints. Contains the secrets supplied at create time alongside<br/>
    /// platform-derived display fields:<br/>
    /// - Slack exposes `webhook_path`<br/>
    /// - gchat exposes `audience_url` and `client_email`<br/>
    /// - zoom exposes the generated `connector_token` and `webhook_path`<br/>
    /// - widget exposes `bootstrap_path`
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
        /// fields `client_email` and `project_id`, parsed out of the service account<br/>
        /// key. Also includes the audience URL used to verify inbound events. The<br/>
        /// service account key is never returned.
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
        /// platform-generated `connector_token` to configure as the<br/>
        /// `x-zoom-connector-token` header on the Zoom Contact Center bot connector.<br/>
        /// Also includes the `webhook_path` to configure as the bot endpoint URL. The<br/>
        /// agent's reply is always delivered asynchronously. The webhook returns a<br/>
        /// typing indicator and the reply is POSTed to `callback_url` when the agent<br/>
        /// finishes.
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
        /// Read view of a web widget connector's configuration.<br/>
        /// Every field is served to anonymous visitors by the unauthenticated widget bootstrap endpoint.<br/>
        /// Includes the platform-derived `bootstrap_path` the embed snippet calls.<br/>
        /// Widget connectors ignore the base `hidden_output_types`; end-user event visibility is controlled by `revealed_output_types`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WidgetConnectorConfiguration? Widget { get; init; }
#else
        public global::Vectara.WidgetConnectorConfiguration? Widget { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Widget))]
#endif
        public bool IsWidget => Widget != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWidget(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WidgetConnectorConfiguration? value)
        {
            value = Widget;
            return IsWidget;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfiguration PickWidget() => IsWidget
            ? Widget!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Widget' but the value was {ToString()}.");
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
        public static implicit operator ConnectorConfiguration(global::Vectara.WidgetConnectorConfiguration value) => new ConnectorConfiguration((global::Vectara.WidgetConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WidgetConnectorConfiguration?(ConnectorConfiguration @this) => @this.Widget;

        /// <summary>
        ///
        /// </summary>
        public ConnectorConfiguration(global::Vectara.WidgetConnectorConfiguration? value)
        {
            Widget = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectorConfiguration FromWidget(global::Vectara.WidgetConnectorConfiguration? value) => new ConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public ConnectorConfiguration(
            global::Vectara.ConnectorConfigurationDiscriminatorType? type,
            global::Vectara.SlackConnectorConfiguration? slack,
            global::Vectara.GchatConnectorConfiguration? gchat,
            global::Vectara.ZoomConnectorConfiguration? zoom,
            global::Vectara.WidgetConnectorConfiguration? widget
            )
        {
            Type = type;

            Slack = slack;
            Gchat = gchat;
            Zoom = zoom;
            Widget = widget;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Widget as object ??
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
            Zoom?.ToString() ??
            Widget?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSlack && !IsGchat && !IsZoom && !IsWidget || !IsSlack && IsGchat && !IsZoom && !IsWidget || !IsSlack && !IsGchat && IsZoom && !IsWidget || !IsSlack && !IsGchat && !IsZoom && IsWidget;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SlackConnectorConfiguration?, TResult>? slack = null,
            global::System.Func<global::Vectara.GchatConnectorConfiguration?, TResult>? gchat = null,
            global::System.Func<global::Vectara.ZoomConnectorConfiguration?, TResult>? zoom = null,
            global::System.Func<global::Vectara.WidgetConnectorConfiguration?, TResult>? widget = null,
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
            else if (IsWidget && widget != null)
            {
                return widget(Widget!);
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

            global::System.Action<global::Vectara.WidgetConnectorConfiguration?>? widget = null,
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
            else if (IsWidget)
            {
                widget?.Invoke(Widget!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SlackConnectorConfiguration?>? slack = null,
            global::System.Action<global::Vectara.GchatConnectorConfiguration?>? gchat = null,
            global::System.Action<global::Vectara.ZoomConnectorConfiguration?>? zoom = null,
            global::System.Action<global::Vectara.WidgetConnectorConfiguration?>? widget = null,
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
            else if (IsWidget)
            {
                widget?.Invoke(Widget!);
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
                Widget,
                typeof(global::Vectara.WidgetConnectorConfiguration),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ZoomConnectorConfiguration?>.Default.Equals(Zoom, other.Zoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WidgetConnectorConfiguration?>.Default.Equals(Widget, other.Widget)
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
