#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a connector's configuration as returned by GET and list<br/>
    /// endpoints. Contains the secrets supplied at create time alongside<br/>
    /// server-derived display fields: Slack exposes `webhook_path`, and gchat<br/>
    /// exposes `audience_url` and `client_email`.
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
        /// field `client_email` parsed out of the service account key and the audience<br/>
        /// URL used to verify inbound events. The service account key is never returned.
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
        public ConnectorConfiguration(
            global::Vectara.ConnectorConfigurationDiscriminatorType? type,
            global::Vectara.SlackConnectorConfiguration? slack,
            global::Vectara.GchatConnectorConfiguration? gchat
            )
        {
            Type = type;

            Slack = slack;
            Gchat = gchat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Gchat as object ??
            Slack as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Slack?.ToString() ??
            Gchat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSlack && !IsGchat || !IsSlack && IsGchat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SlackConnectorConfiguration?, TResult>? slack = null,
            global::System.Func<global::Vectara.GchatConnectorConfiguration?, TResult>? gchat = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SlackConnectorConfiguration?>? slack = null,

            global::System.Action<global::Vectara.GchatConnectorConfiguration?>? gchat = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SlackConnectorConfiguration?>? slack = null,
            global::System.Action<global::Vectara.GchatConnectorConfiguration?>? gchat = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GchatConnectorConfiguration?>.Default.Equals(Gchat, other.Gchat) 
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
