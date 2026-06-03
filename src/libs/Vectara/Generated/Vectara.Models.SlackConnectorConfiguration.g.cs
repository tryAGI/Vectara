#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a Slack connector's configuration.
    /// </summary>
    public readonly partial struct SlackConnectorConfiguration : global::System.IEquatable<SlackConnectorConfiguration>
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
        public global::Vectara.SlackConnectorConfigurationVariant2? SlackConnectorConfigurationVariant2 { get; init; }
#else
        public global::Vectara.SlackConnectorConfigurationVariant2? SlackConnectorConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackConnectorConfigurationVariant2))]
#endif
        public bool IsSlackConnectorConfigurationVariant2 => SlackConnectorConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSlackConnectorConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SlackConnectorConfigurationVariant2? value)
        {
            value = SlackConnectorConfigurationVariant2;
            return IsSlackConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SlackConnectorConfigurationVariant2 PickSlackConnectorConfigurationVariant2() => IsSlackConnectorConfigurationVariant2
            ? SlackConnectorConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackConnectorConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SlackConnectorConfiguration(global::Vectara.ConnectorConfigurationBase value) => new SlackConnectorConfiguration((global::Vectara.ConnectorConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ConnectorConfigurationBase?(SlackConnectorConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SlackConnectorConfiguration(global::Vectara.ConnectorConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SlackConnectorConfiguration FromBase(global::Vectara.ConnectorConfigurationBase? value) => new SlackConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SlackConnectorConfiguration(global::Vectara.SlackConnectorConfigurationVariant2 value) => new SlackConnectorConfiguration((global::Vectara.SlackConnectorConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SlackConnectorConfigurationVariant2?(SlackConnectorConfiguration @this) => @this.SlackConnectorConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SlackConnectorConfiguration(global::Vectara.SlackConnectorConfigurationVariant2? value)
        {
            SlackConnectorConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SlackConnectorConfiguration FromSlackConnectorConfigurationVariant2(global::Vectara.SlackConnectorConfigurationVariant2? value) => new SlackConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public SlackConnectorConfiguration(
            global::Vectara.ConnectorConfigurationBase? @base,
            global::Vectara.SlackConnectorConfigurationVariant2? slackConnectorConfigurationVariant2
            )
        {
            Base = @base;
            SlackConnectorConfigurationVariant2 = slackConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SlackConnectorConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SlackConnectorConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSlackConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ConnectorConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.SlackConnectorConfigurationVariant2, TResult>? slackConnectorConfigurationVariant2 = null,
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
            else if (IsSlackConnectorConfigurationVariant2 && slackConnectorConfigurationVariant2 != null)
            {
                return slackConnectorConfigurationVariant2(SlackConnectorConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.SlackConnectorConfigurationVariant2>? slackConnectorConfigurationVariant2 = null,
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
            else if (IsSlackConnectorConfigurationVariant2)
            {
                slackConnectorConfigurationVariant2?.Invoke(SlackConnectorConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.SlackConnectorConfigurationVariant2>? slackConnectorConfigurationVariant2 = null,
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
            else if (IsSlackConnectorConfigurationVariant2)
            {
                slackConnectorConfigurationVariant2?.Invoke(SlackConnectorConfigurationVariant2!);
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
                SlackConnectorConfigurationVariant2,
                typeof(global::Vectara.SlackConnectorConfigurationVariant2),
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
        public bool Equals(SlackConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ConnectorConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SlackConnectorConfigurationVariant2?>.Default.Equals(SlackConnectorConfigurationVariant2, other.SlackConnectorConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SlackConnectorConfiguration obj1, SlackConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SlackConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SlackConnectorConfiguration obj1, SlackConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SlackConnectorConfiguration o && Equals(o);
        }
    }
}
