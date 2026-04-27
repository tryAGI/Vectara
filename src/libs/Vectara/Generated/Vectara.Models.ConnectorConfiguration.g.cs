#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for different types of connectors.
    /// </summary>
    public readonly partial struct ConnectorConfiguration : global::System.IEquatable<ConnectorConfiguration>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ConnectorConfigurationDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration for Slack connectors.
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
        public ConnectorConfiguration(
            global::Vectara.ConnectorConfigurationDiscriminatorType? type,
            global::Vectara.SlackConnectorConfiguration? slack
            )
        {
            Type = type;

            Slack = slack;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Slack as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Slack?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSlack;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SlackConnectorConfiguration?, TResult>? slack = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SlackConnectorConfiguration?>? slack = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SlackConnectorConfiguration?>.Default.Equals(Slack, other.Slack) 
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
