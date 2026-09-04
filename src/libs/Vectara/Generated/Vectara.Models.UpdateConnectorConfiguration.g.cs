#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Write view of a connector's configuration, supplied on update. Discriminated by `type`, which must equal the connector's stored type.<br/>
    /// Slack, Google Chat, and Zoom configurations are supplied in full and replace the stored configuration wholesale, exactly as on create; caller-omitted platform-generated fields (such as the Zoom `connector_token`) are preserved.<br/>
    /// A widget configuration is the exception: it updates partially, so a supplied field replaces the stored one while an omitted field keeps it — see `UpdateWidgetConnectorConfiguration`.
    /// </summary>
    public readonly partial struct UpdateConnectorConfiguration : global::System.IEquatable<UpdateConnectorConfiguration>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateConnectorConfigurationDiscriminatorType? Type { get; }

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
        /// Partial update view of a web widget connector's configuration. Omitted fields keep their stored value; nested objects such as `presentation` are replaced whole when supplied.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.UpdateWidgetConnectorConfiguration? Widget { get; init; }
#else
        public global::Vectara.UpdateWidgetConnectorConfiguration? Widget { get; }
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
            out global::Vectara.UpdateWidgetConnectorConfiguration? value)
        {
            value = Widget;
            return IsWidget;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.UpdateWidgetConnectorConfiguration PickWidget() => IsWidget
            ? Widget!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Widget' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateConnectorConfiguration(global::Vectara.CreateSlackConnectorConfiguration value) => new UpdateConnectorConfiguration((global::Vectara.CreateSlackConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateSlackConnectorConfiguration?(UpdateConnectorConfiguration @this) => @this.Slack;

        /// <summary>
        ///
        /// </summary>
        public UpdateConnectorConfiguration(global::Vectara.CreateSlackConnectorConfiguration? value)
        {
            Slack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateConnectorConfiguration FromSlack(global::Vectara.CreateSlackConnectorConfiguration? value) => new UpdateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateConnectorConfiguration(global::Vectara.CreateGchatConnectorConfiguration value) => new UpdateConnectorConfiguration((global::Vectara.CreateGchatConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateGchatConnectorConfiguration?(UpdateConnectorConfiguration @this) => @this.Gchat;

        /// <summary>
        ///
        /// </summary>
        public UpdateConnectorConfiguration(global::Vectara.CreateGchatConnectorConfiguration? value)
        {
            Gchat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateConnectorConfiguration FromGchat(global::Vectara.CreateGchatConnectorConfiguration? value) => new UpdateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateConnectorConfiguration(global::Vectara.CreateZoomConnectorConfiguration value) => new UpdateConnectorConfiguration((global::Vectara.CreateZoomConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateZoomConnectorConfiguration?(UpdateConnectorConfiguration @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public UpdateConnectorConfiguration(global::Vectara.CreateZoomConnectorConfiguration? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateConnectorConfiguration FromZoom(global::Vectara.CreateZoomConnectorConfiguration? value) => new UpdateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateConnectorConfiguration(global::Vectara.UpdateWidgetConnectorConfiguration value) => new UpdateConnectorConfiguration((global::Vectara.UpdateWidgetConnectorConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.UpdateWidgetConnectorConfiguration?(UpdateConnectorConfiguration @this) => @this.Widget;

        /// <summary>
        ///
        /// </summary>
        public UpdateConnectorConfiguration(global::Vectara.UpdateWidgetConnectorConfiguration? value)
        {
            Widget = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateConnectorConfiguration FromWidget(global::Vectara.UpdateWidgetConnectorConfiguration? value) => new UpdateConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateConnectorConfiguration(
            global::Vectara.UpdateConnectorConfigurationDiscriminatorType? type,
            global::Vectara.CreateSlackConnectorConfiguration? slack,
            global::Vectara.CreateGchatConnectorConfiguration? gchat,
            global::Vectara.CreateZoomConnectorConfiguration? zoom,
            global::Vectara.UpdateWidgetConnectorConfiguration? widget
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
            global::System.Func<global::Vectara.UpdateWidgetConnectorConfiguration, TResult>? widget = null,
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

            global::System.Action<global::Vectara.UpdateWidgetConnectorConfiguration>? widget = null,
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
            global::System.Action<global::Vectara.UpdateWidgetConnectorConfiguration>? widget = null,
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
                typeof(global::Vectara.UpdateWidgetConnectorConfiguration),
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
        public bool Equals(UpdateConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateSlackConnectorConfiguration?>.Default.Equals(Slack, other.Slack) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateGchatConnectorConfiguration?>.Default.Equals(Gchat, other.Gchat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateZoomConnectorConfiguration?>.Default.Equals(Zoom, other.Zoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.UpdateWidgetConnectorConfiguration?>.Default.Equals(Widget, other.Widget)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateConnectorConfiguration obj1, UpdateConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateConnectorConfiguration obj1, UpdateConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateConnectorConfiguration o && Equals(o);
        }
    }
}
