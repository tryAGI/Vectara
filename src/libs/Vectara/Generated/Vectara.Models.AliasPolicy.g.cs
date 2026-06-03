#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A routing policy. The `type` discriminator determines which fields apply:<br/>
    /// * `routed` — evaluate ordered rules; the first rule whose `match` expression evaluates to true is selected. The selected rule's `targets` are then used (one agent for `single`, hashed by `partition_by` for `weighted`). A rule with omitted `match` is a catch-all that always matches; it must be the last rule, and any rule placed after it is rejected as unreachable.<br/>
    /// Most use cases (direct, weighted/canary, conditional, conditional+canary) collapse into `routed`.
    /// </summary>
    public readonly partial struct AliasPolicy : global::System.IEquatable<AliasPolicy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.AliasPolicyDiscriminatorType? Type { get; }

        /// <summary>
        /// Evaluates ordered rules against the session context. The first rule whose `match` expression evaluates to true is selected. The selected rule's `targets` shape determines what runs: `single` routes directly to one agent, `weighted` picks one of several agents by hashing the rule's `partition_by` expression. A rule with no `match` always matches (catch-all). It must be the last rule; any rule placed after it is rejected as unreachable.<br/>
        /// This single shape covers direct routing (one rule, single target), weighted/canary rollouts (one rule, weighted targets), conditional routing (multiple rules with matches), and conditional+canary combinations (multiple rules, each independently single or weighted).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RoutedAliasPolicy? Routed { get; init; }
#else
        public global::Vectara.RoutedAliasPolicy? Routed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Routed))]
#endif
        public bool IsRouted => Routed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRouted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.RoutedAliasPolicy? value)
        {
            value = Routed;
            return IsRouted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RoutedAliasPolicy PickRouted() => IsRouted
            ? Routed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Routed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AliasPolicy(global::Vectara.RoutedAliasPolicy value) => new AliasPolicy((global::Vectara.RoutedAliasPolicy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RoutedAliasPolicy?(AliasPolicy @this) => @this.Routed;

        /// <summary>
        /// 
        /// </summary>
        public AliasPolicy(global::Vectara.RoutedAliasPolicy? value)
        {
            Routed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AliasPolicy FromRouted(global::Vectara.RoutedAliasPolicy? value) => new AliasPolicy(value);

        /// <summary>
        /// 
        /// </summary>
        public AliasPolicy(
            global::Vectara.AliasPolicyDiscriminatorType? type,
            global::Vectara.RoutedAliasPolicy? routed
            )
        {
            Type = type;

            Routed = routed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Routed as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Routed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRouted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.RoutedAliasPolicy, TResult>? routed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRouted && routed != null)
            {
                return routed(Routed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.RoutedAliasPolicy>? routed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRouted)
            {
                routed?.Invoke(Routed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.RoutedAliasPolicy>? routed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRouted)
            {
                routed?.Invoke(Routed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Routed,
                typeof(global::Vectara.RoutedAliasPolicy),
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
        public bool Equals(AliasPolicy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RoutedAliasPolicy?>.Default.Equals(Routed, other.Routed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AliasPolicy obj1, AliasPolicy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AliasPolicy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AliasPolicy obj1, AliasPolicy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AliasPolicy o && Equals(o);
        }
    }
}
