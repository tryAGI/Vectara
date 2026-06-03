#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Write view of a connector's configuration. Used when creating a connector<br/>
    /// and reused when updating one. Carries the secrets and inputs the customer<br/>
    /// must supply. Server-derived display fields are not accepted here and instead<br/>
    /// appear in the read view: Slack returns `webhook_path`, and gchat returns<br/>
    /// `audience_url` and `client_email`.
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
            ? Slack!
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
            ? Gchat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gchat' but the value was {ToString()}.");
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
        public CreateConnectorConfiguration(
            global::Vectara.CreateConnectorConfigurationDiscriminatorType? type,
            global::Vectara.CreateSlackConnectorConfiguration? slack,
            global::Vectara.CreateGchatConnectorConfiguration? gchat
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
            global::System.Func<global::Vectara.CreateSlackConnectorConfiguration, TResult>? slack = null,
            global::System.Func<global::Vectara.CreateGchatConnectorConfiguration, TResult>? gchat = null,
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
            global::System.Action<global::Vectara.CreateSlackConnectorConfiguration>? slack = null,

            global::System.Action<global::Vectara.CreateGchatConnectorConfiguration>? gchat = null,
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
            global::System.Action<global::Vectara.CreateSlackConnectorConfiguration>? slack = null,
            global::System.Action<global::Vectara.CreateGchatConnectorConfiguration>? gchat = null,
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
                typeof(global::Vectara.CreateSlackConnectorConfiguration),
                Gchat,
                typeof(global::Vectara.CreateGchatConnectorConfiguration),
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateGchatConnectorConfiguration?>.Default.Equals(Gchat, other.Gchat) 
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
