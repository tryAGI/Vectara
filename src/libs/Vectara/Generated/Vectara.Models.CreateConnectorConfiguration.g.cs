#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Write view of a connector's configuration. Used when creating a connector<br/>
    /// and reused when updating one. Carries the secrets and inputs the customer<br/>
    /// must supply. Platform-derived display fields are not accepted here and instead<br/>
    /// appear in the read view:<br/>
    /// - Slack returns `webhook_path`<br/>
    /// - gchat returns `audience_url` and `client_email`<br/>
    /// - zoom returns the generated `connector_token` and `webhook_path`<br/>
    /// - widget returns `bootstrap_path`
    /// </summary>
    public readonly partial struct CreateConnectorConfiguration : global::System.IEquatable<CreateConnectorConfiguration>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationDiscriminatorType? Type { get; }

        /// <summary>
        /// Write view of a Slack connector's configuration, supplied on create or update.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateSlackConnectorConfiguration? Slack { get; init; }
#else
        public global::Vectara.CreateSlackConnectorConfiguration? Slack { get; }
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
            out global::Vectara.CreateSlackConnectorConfiguration? value)
        {
            value = Slack;
            return IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfiguration PickSlack() => IsSlack
            ? Slack!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slack' but the value was {ToString()}.");

        /// <summary>
        /// Write view of a Google Chat connector's configuration. Supply the service<br/>
        /// account JSON key for the Chat app you have configured in the Google Cloud<br/>
        /// console. The Chat app's HTTP endpoint URL and Authentication audience must<br/>
        /// be set to the connector's audience_url (returned in the read view).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateGchatConnectorConfiguration? Gchat { get; init; }
#else
        public global::Vectara.CreateGchatConnectorConfiguration? Gchat { get; }
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
            out global::Vectara.CreateGchatConnectorConfiguration? value)
        {
            value = Gchat;
            return IsGchat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfiguration PickGchat() => IsGchat
            ? Gchat!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gchat' but the value was {ToString()}.");

        /// <summary>
        /// Write view of a Zoom Contact Center connector's configuration. Supply the<br/>
        /// Zoom-provided callback URL that agent replies are POSTed to. The platform<br/>
        /// generates the inbound `connector_token` and returns it in the read view.<br/>
        /// Configure it as the `x-zoom-connector-token` header on the Zoom Contact Center bot<br/>
        /// connector. Updating the configuration preserves the existing `connector_token`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateZoomConnectorConfiguration? Zoom { get; init; }
#else
        public global::Vectara.CreateZoomConnectorConfiguration? Zoom { get; }
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
            out global::Vectara.CreateZoomConnectorConfiguration? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomConnectorConfiguration PickZoom() => IsZoom
            ? Zoom!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");

        /// <summary>
        /// Write view of a web widget connector's configuration, supplied on create or update.<br/>
        /// On create, `alias_key` is not accepted and is rejected with `400`: the platform creates a new alias and binds the widget to it for the connector's lifetime — the alias is deleted with the connector.<br/>
        /// On update, `alias_key` is required and must be the widget's current alias: an operator-chosen or unknown alias is rejected with `400`, and another widget's alias with `409`.<br/>
        /// The unauthenticated widget bootstrap endpoint serves `alias_key`, `presentation`, and `end_user_sign_in` to anonymous visitors; `session_metadata` is never served to end users.<br/>
        /// The `bootstrap_path` is platform-derived and appears only in the read view.<br/>
        /// Widget connectors ignore the base `hidden_output_types`; end-user event visibility is controlled by `revealed_output_types`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateWidgetConnectorConfiguration? Widget { get; init; }
#else
        public global::Vectara.CreateWidgetConnectorConfiguration? Widget { get; }
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
            out global::Vectara.CreateWidgetConnectorConfiguration? value)
        {
            value = Widget;
            return IsWidget;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfiguration PickWidget() => IsWidget
            ? Widget!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Widget' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateConnectorConfiguration(global::Vectara.CreateSlackConnectorConfiguration value) => new CreateConnectorConfiguration((global::Vectara.CreateSlackConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateSlackConnectorConfiguration?(CreateConnectorConfiguration @this) => @this.Slack;

        /// <summary>
        ///
        /// </summary>
        public CreateConnectorConfiguration(global::Vectara.CreateSlackConnectorConfiguration? value)
        {
            Slack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateConnectorConfiguration FromSlack(global::Vectara.CreateSlackConnectorConfiguration? value) => new CreateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateConnectorConfiguration(global::Vectara.CreateGchatConnectorConfiguration value) => new CreateConnectorConfiguration((global::Vectara.CreateGchatConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateGchatConnectorConfiguration?(CreateConnectorConfiguration @this) => @this.Gchat;

        /// <summary>
        ///
        /// </summary>
        public CreateConnectorConfiguration(global::Vectara.CreateGchatConnectorConfiguration? value)
        {
            Gchat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateConnectorConfiguration FromGchat(global::Vectara.CreateGchatConnectorConfiguration? value) => new CreateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateConnectorConfiguration(global::Vectara.CreateZoomConnectorConfiguration value) => new CreateConnectorConfiguration((global::Vectara.CreateZoomConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateZoomConnectorConfiguration?(CreateConnectorConfiguration @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public CreateConnectorConfiguration(global::Vectara.CreateZoomConnectorConfiguration? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateConnectorConfiguration FromZoom(global::Vectara.CreateZoomConnectorConfiguration? value) => new CreateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateConnectorConfiguration(global::Vectara.CreateWidgetConnectorConfiguration value) => new CreateConnectorConfiguration((global::Vectara.CreateWidgetConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateWidgetConnectorConfiguration?(CreateConnectorConfiguration @this) => @this.Widget;

        /// <summary>
        ///
        /// </summary>
        public CreateConnectorConfiguration(global::Vectara.CreateWidgetConnectorConfiguration? value)
        {
            Widget = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateConnectorConfiguration FromWidget(global::Vectara.CreateWidgetConnectorConfiguration? value) => new CreateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public CreateConnectorConfiguration(
            global::Vectara.CreateConnectorConfigurationDiscriminatorType? type,
            global::Vectara.CreateSlackConnectorConfiguration? slack,
            global::Vectara.CreateGchatConnectorConfiguration? gchat,
            global::Vectara.CreateZoomConnectorConfiguration? zoom,
            global::Vectara.CreateWidgetConnectorConfiguration? widget
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
            global::System.Func<global::Vectara.CreateSlackConnectorConfiguration?, TResult>? slack = null,
            global::System.Func<global::Vectara.CreateGchatConnectorConfiguration?, TResult>? gchat = null,
            global::System.Func<global::Vectara.CreateZoomConnectorConfiguration?, TResult>? zoom = null,
            global::System.Func<global::Vectara.CreateWidgetConnectorConfiguration?, TResult>? widget = null,
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
            global::System.Action<global::Vectara.CreateSlackConnectorConfiguration?>? slack = null,

            global::System.Action<global::Vectara.CreateGchatConnectorConfiguration?>? gchat = null,

            global::System.Action<global::Vectara.CreateZoomConnectorConfiguration?>? zoom = null,

            global::System.Action<global::Vectara.CreateWidgetConnectorConfiguration?>? widget = null,
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
            global::System.Action<global::Vectara.CreateSlackConnectorConfiguration?>? slack = null,
            global::System.Action<global::Vectara.CreateGchatConnectorConfiguration?>? gchat = null,
            global::System.Action<global::Vectara.CreateZoomConnectorConfiguration?>? zoom = null,
            global::System.Action<global::Vectara.CreateWidgetConnectorConfiguration?>? widget = null,
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
                typeof(global::Vectara.CreateSlackConnectorConfiguration),
                Gchat,
                typeof(global::Vectara.CreateGchatConnectorConfiguration),
                Zoom,
                typeof(global::Vectara.CreateZoomConnectorConfiguration),
                Widget,
                typeof(global::Vectara.CreateWidgetConnectorConfiguration),
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
        public bool Equals(CreateConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateSlackConnectorConfiguration?>.Default.Equals(Slack, other.Slack) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateGchatConnectorConfiguration?>.Default.Equals(Gchat, other.Gchat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateZoomConnectorConfiguration?>.Default.Equals(Zoom, other.Zoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateWidgetConnectorConfiguration?>.Default.Equals(Widget, other.Widget)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateConnectorConfiguration obj1, CreateConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateConnectorConfiguration obj1, CreateConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateConnectorConfiguration o && Equals(o);
        }
    }
}
