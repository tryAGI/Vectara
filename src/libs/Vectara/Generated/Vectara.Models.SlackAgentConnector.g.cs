#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a Slack connector.
    /// </summary>
    public readonly partial struct SlackAgentConnector : global::System.IEquatable<SlackAgentConnector>
    {
        /// <summary>
        /// Properties shared by every connector read view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.AgentConnectorBase? Base { get; init; }
#else
        public global::Vectara.AgentConnectorBase? Base { get; }
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
            out global::Vectara.AgentConnectorBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.AgentConnectorBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SlackAgentConnectorVariant2? SlackAgentConnectorVariant2 { get; init; }
#else
        public global::Vectara.SlackAgentConnectorVariant2? SlackAgentConnectorVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackAgentConnectorVariant2))]
#endif
        public bool IsSlackAgentConnectorVariant2 => SlackAgentConnectorVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlackAgentConnectorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SlackAgentConnectorVariant2? value)
        {
            value = SlackAgentConnectorVariant2;
            return IsSlackAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.SlackAgentConnectorVariant2 PickSlackAgentConnectorVariant2() => IsSlackAgentConnectorVariant2
            ? SlackAgentConnectorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackAgentConnectorVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SlackAgentConnector(global::Vectara.AgentConnectorBase value) => new SlackAgentConnector((global::Vectara.AgentConnectorBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.AgentConnectorBase?(SlackAgentConnector @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public SlackAgentConnector(global::Vectara.AgentConnectorBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SlackAgentConnector FromBase(global::Vectara.AgentConnectorBase? value) => new SlackAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SlackAgentConnector(global::Vectara.SlackAgentConnectorVariant2 value) => new SlackAgentConnector((global::Vectara.SlackAgentConnectorVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.SlackAgentConnectorVariant2?(SlackAgentConnector @this) => @this.SlackAgentConnectorVariant2;

        /// <summary>
        ///
        /// </summary>
        public SlackAgentConnector(global::Vectara.SlackAgentConnectorVariant2? value)
        {
            SlackAgentConnectorVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SlackAgentConnector FromSlackAgentConnectorVariant2(global::Vectara.SlackAgentConnectorVariant2? value) => new SlackAgentConnector(value);

        /// <summary>
        ///
        /// </summary>
        public SlackAgentConnector(
            global::Vectara.AgentConnectorBase? @base,
            global::Vectara.SlackAgentConnectorVariant2? slackAgentConnectorVariant2
            )
        {
            Base = @base;
            SlackAgentConnectorVariant2 = slackAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SlackAgentConnectorVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SlackAgentConnectorVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSlackAgentConnectorVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.AgentConnectorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.SlackAgentConnectorVariant2, TResult>? slackAgentConnectorVariant2 = null,
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
            else if (IsSlackAgentConnectorVariant2 && slackAgentConnectorVariant2 != null)
            {
                return slackAgentConnectorVariant2(SlackAgentConnectorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,

            global::System.Action<global::Vectara.SlackAgentConnectorVariant2>? slackAgentConnectorVariant2 = null,
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
            else if (IsSlackAgentConnectorVariant2)
            {
                slackAgentConnectorVariant2?.Invoke(SlackAgentConnectorVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.AgentConnectorBase>? @base = null,
            global::System.Action<global::Vectara.SlackAgentConnectorVariant2>? slackAgentConnectorVariant2 = null,
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
            else if (IsSlackAgentConnectorVariant2)
            {
                slackAgentConnectorVariant2?.Invoke(SlackAgentConnectorVariant2!);
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
                typeof(global::Vectara.AgentConnectorBase),
                SlackAgentConnectorVariant2,
                typeof(global::Vectara.SlackAgentConnectorVariant2),
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
        public bool Equals(SlackAgentConnector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.AgentConnectorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SlackAgentConnectorVariant2?>.Default.Equals(SlackAgentConnectorVariant2, other.SlackAgentConnectorVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SlackAgentConnector obj1, SlackAgentConnector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SlackAgentConnector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SlackAgentConnector obj1, SlackAgentConnector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SlackAgentConnector o && Equals(o);
        }
    }
}
