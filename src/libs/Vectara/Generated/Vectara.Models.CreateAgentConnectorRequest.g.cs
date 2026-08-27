#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request object for creating a new agent connector, discriminated by the connector type.
    /// </summary>
    public readonly partial struct CreateAgentConnectorRequest : global::System.IEquatable<CreateAgentConnectorRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateAgentConnectorRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request object for creating a Slack connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateSlackAgentConnectorRequest? Slack { get; init; }
#else
        public global::Vectara.CreateSlackAgentConnectorRequest? Slack { get; }
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
            out global::Vectara.CreateSlackAgentConnectorRequest? value)
        {
            value = Slack;
            return IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackAgentConnectorRequest PickSlack() => IsSlack
            ? Slack!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slack' but the value was {ToString()}.");

        /// <summary>
        /// Request object for creating a Google Chat connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateGchatAgentConnectorRequest? Gchat { get; init; }
#else
        public global::Vectara.CreateGchatAgentConnectorRequest? Gchat { get; }
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
            out global::Vectara.CreateGchatAgentConnectorRequest? value)
        {
            value = Gchat;
            return IsGchat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateGchatAgentConnectorRequest PickGchat() => IsGchat
            ? Gchat!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gchat' but the value was {ToString()}.");

        /// <summary>
        /// Request object for creating a Zoom Contact Center connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateZoomAgentConnectorRequest? Zoom { get; init; }
#else
        public global::Vectara.CreateZoomAgentConnectorRequest? Zoom { get; }
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
            out global::Vectara.CreateZoomAgentConnectorRequest? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateZoomAgentConnectorRequest PickZoom() => IsZoom
            ? Zoom!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");

        /// <summary>
        /// Request object for creating a web widget connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateWidgetAgentConnectorRequest? Widget { get; init; }
#else
        public global::Vectara.CreateWidgetAgentConnectorRequest? Widget { get; }
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
            out global::Vectara.CreateWidgetAgentConnectorRequest? value)
        {
            value = Widget;
            return IsWidget;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetAgentConnectorRequest PickWidget() => IsWidget
            ? Widget!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Widget' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAgentConnectorRequest(global::Vectara.CreateSlackAgentConnectorRequest value) => new CreateAgentConnectorRequest((global::Vectara.CreateSlackAgentConnectorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateSlackAgentConnectorRequest?(CreateAgentConnectorRequest @this) => @this.Slack;

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(global::Vectara.CreateSlackAgentConnectorRequest? value)
        {
            Slack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAgentConnectorRequest FromSlack(global::Vectara.CreateSlackAgentConnectorRequest? value) => new CreateAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAgentConnectorRequest(global::Vectara.CreateGchatAgentConnectorRequest value) => new CreateAgentConnectorRequest((global::Vectara.CreateGchatAgentConnectorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateGchatAgentConnectorRequest?(CreateAgentConnectorRequest @this) => @this.Gchat;

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(global::Vectara.CreateGchatAgentConnectorRequest? value)
        {
            Gchat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAgentConnectorRequest FromGchat(global::Vectara.CreateGchatAgentConnectorRequest? value) => new CreateAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAgentConnectorRequest(global::Vectara.CreateZoomAgentConnectorRequest value) => new CreateAgentConnectorRequest((global::Vectara.CreateZoomAgentConnectorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateZoomAgentConnectorRequest?(CreateAgentConnectorRequest @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(global::Vectara.CreateZoomAgentConnectorRequest? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAgentConnectorRequest FromZoom(global::Vectara.CreateZoomAgentConnectorRequest? value) => new CreateAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateAgentConnectorRequest(global::Vectara.CreateWidgetAgentConnectorRequest value) => new CreateAgentConnectorRequest((global::Vectara.CreateWidgetAgentConnectorRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateWidgetAgentConnectorRequest?(CreateAgentConnectorRequest @this) => @this.Widget;

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(global::Vectara.CreateWidgetAgentConnectorRequest? value)
        {
            Widget = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateAgentConnectorRequest FromWidget(global::Vectara.CreateWidgetAgentConnectorRequest? value) => new CreateAgentConnectorRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateAgentConnectorRequest(
            global::Vectara.CreateAgentConnectorRequestDiscriminatorType? type,
            global::Vectara.CreateSlackAgentConnectorRequest? slack,
            global::Vectara.CreateGchatAgentConnectorRequest? gchat,
            global::Vectara.CreateZoomAgentConnectorRequest? zoom,
            global::Vectara.CreateWidgetAgentConnectorRequest? widget
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
            global::System.Func<global::Vectara.CreateSlackAgentConnectorRequest?, TResult>? slack = null,
            global::System.Func<global::Vectara.CreateGchatAgentConnectorRequest?, TResult>? gchat = null,
            global::System.Func<global::Vectara.CreateZoomAgentConnectorRequest?, TResult>? zoom = null,
            global::System.Func<global::Vectara.CreateWidgetAgentConnectorRequest?, TResult>? widget = null,
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
            global::System.Action<global::Vectara.CreateSlackAgentConnectorRequest?>? slack = null,

            global::System.Action<global::Vectara.CreateGchatAgentConnectorRequest?>? gchat = null,

            global::System.Action<global::Vectara.CreateZoomAgentConnectorRequest?>? zoom = null,

            global::System.Action<global::Vectara.CreateWidgetAgentConnectorRequest?>? widget = null,
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
            global::System.Action<global::Vectara.CreateSlackAgentConnectorRequest?>? slack = null,
            global::System.Action<global::Vectara.CreateGchatAgentConnectorRequest?>? gchat = null,
            global::System.Action<global::Vectara.CreateZoomAgentConnectorRequest?>? zoom = null,
            global::System.Action<global::Vectara.CreateWidgetAgentConnectorRequest?>? widget = null,
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
                typeof(global::Vectara.CreateSlackAgentConnectorRequest),
                Gchat,
                typeof(global::Vectara.CreateGchatAgentConnectorRequest),
                Zoom,
                typeof(global::Vectara.CreateZoomAgentConnectorRequest),
                Widget,
                typeof(global::Vectara.CreateWidgetAgentConnectorRequest),
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
        public bool Equals(CreateAgentConnectorRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateSlackAgentConnectorRequest?>.Default.Equals(Slack, other.Slack) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateGchatAgentConnectorRequest?>.Default.Equals(Gchat, other.Gchat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateZoomAgentConnectorRequest?>.Default.Equals(Zoom, other.Zoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateWidgetAgentConnectorRequest?>.Default.Equals(Widget, other.Widget)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateAgentConnectorRequest obj1, CreateAgentConnectorRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAgentConnectorRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateAgentConnectorRequest obj1, CreateAgentConnectorRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAgentConnectorRequest o && Equals(o);
        }
    }
}
