#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A connector that surfaces an agent to end users through a channel — an external platform like Slack, Google Chat, or Zoom Contact Center, or the embeddable web widget.
    /// </summary>
    public readonly partial struct AgentConnector : global::System.IEquatable<AgentConnector>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnectorDiscriminatorType? Type { get; }

        /// <summary>
        /// Read view of a Slack connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SlackAgentConnector? Slack { get; init; }
#else
        public global::Vectara.SlackAgentConnector? Slack { get; }
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
            out global::Vectara.SlackAgentConnector? value)
        {
            value = Slack;
            return IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackAgentConnector PickSlack() => IsSlack
            ? Slack!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slack' but the value was {ToString()}.");

        /// <summary>
        /// Read view of a Google Chat connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GchatAgentConnector? Gchat { get; init; }
#else
        public global::Vectara.GchatAgentConnector? Gchat { get; }
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
            out global::Vectara.GchatAgentConnector? value)
        {
            value = Gchat;
            return IsGchat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.GchatAgentConnector PickGchat() => IsGchat
            ? Gchat!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gchat' but the value was {ToString()}.");

        /// <summary>
        /// Read view of a Zoom Contact Center connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ZoomAgentConnector? Zoom { get; init; }
#else
        public global::Vectara.ZoomAgentConnector? Zoom { get; }
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
            out global::Vectara.ZoomAgentConnector? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ZoomAgentConnector PickZoom() => IsZoom
            ? Zoom!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");

        /// <summary>
        /// Read view of a web widget connector.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WidgetAgentConnector? Widget { get; init; }
#else
        public global::Vectara.WidgetAgentConnector? Widget { get; }
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
            out global::Vectara.WidgetAgentConnector? value)
        {
            value = Widget;
            return IsWidget;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetAgentConnector PickWidget() => IsWidget
            ? Widget!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Widget' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConnector(global::Vectara.SlackAgentConnector value) => new AgentConnector((global::Vectara.SlackAgentConnector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.SlackAgentConnector?(AgentConnector @this) => @this.Slack;

        /// <summary>
        ///
        /// </summary>
        public AgentConnector(global::Vectara.SlackAgentConnector? value)
        {
            Slack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConnector FromSlack(global::Vectara.SlackAgentConnector? value) => new AgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConnector(global::Vectara.GchatAgentConnector value) => new AgentConnector((global::Vectara.GchatAgentConnector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.GchatAgentConnector?(AgentConnector @this) => @this.Gchat;

        /// <summary>
        ///
        /// </summary>
        public AgentConnector(global::Vectara.GchatAgentConnector? value)
        {
            Gchat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConnector FromGchat(global::Vectara.GchatAgentConnector? value) => new AgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConnector(global::Vectara.ZoomAgentConnector value) => new AgentConnector((global::Vectara.ZoomAgentConnector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ZoomAgentConnector?(AgentConnector @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public AgentConnector(global::Vectara.ZoomAgentConnector? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConnector FromZoom(global::Vectara.ZoomAgentConnector? value) => new AgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConnector(global::Vectara.WidgetAgentConnector value) => new AgentConnector((global::Vectara.WidgetAgentConnector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WidgetAgentConnector?(AgentConnector @this) => @this.Widget;

        /// <summary>
        ///
        /// </summary>
        public AgentConnector(global::Vectara.WidgetAgentConnector? value)
        {
            Widget = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConnector FromWidget(global::Vectara.WidgetAgentConnector? value) => new AgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public AgentConnector(
            global::Vectara.AgentConnectorDiscriminatorType? type,
            global::Vectara.SlackAgentConnector? slack,
            global::Vectara.GchatAgentConnector? gchat,
            global::Vectara.ZoomAgentConnector? zoom,
            global::Vectara.WidgetAgentConnector? widget
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
            global::System.Func<global::Vectara.SlackAgentConnector?, TResult>? slack = null,
            global::System.Func<global::Vectara.GchatAgentConnector?, TResult>? gchat = null,
            global::System.Func<global::Vectara.ZoomAgentConnector?, TResult>? zoom = null,
            global::System.Func<global::Vectara.WidgetAgentConnector?, TResult>? widget = null,
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
            global::System.Action<global::Vectara.SlackAgentConnector?>? slack = null,

            global::System.Action<global::Vectara.GchatAgentConnector?>? gchat = null,

            global::System.Action<global::Vectara.ZoomAgentConnector?>? zoom = null,

            global::System.Action<global::Vectara.WidgetAgentConnector?>? widget = null,
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
            global::System.Action<global::Vectara.SlackAgentConnector?>? slack = null,
            global::System.Action<global::Vectara.GchatAgentConnector?>? gchat = null,
            global::System.Action<global::Vectara.ZoomAgentConnector?>? zoom = null,
            global::System.Action<global::Vectara.WidgetAgentConnector?>? widget = null,
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
                typeof(global::Vectara.SlackAgentConnector),
                Gchat,
                typeof(global::Vectara.GchatAgentConnector),
                Zoom,
                typeof(global::Vectara.ZoomAgentConnector),
                Widget,
                typeof(global::Vectara.WidgetAgentConnector),
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
        public bool Equals(AgentConnector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SlackAgentConnector?>.Default.Equals(Slack, other.Slack) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GchatAgentConnector?>.Default.Equals(Gchat, other.Gchat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ZoomAgentConnector?>.Default.Equals(Zoom, other.Zoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WidgetAgentConnector?>.Default.Equals(Widget, other.Widget)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentConnector obj1, AgentConnector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentConnector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentConnector obj1, AgentConnector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentConnector o && Equals(o);
        }
    }
}
