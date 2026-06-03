#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The shape of a rule's targets. The `type` discriminator selects which fields apply:<br/>
    /// * `single` — a direct route to one agent. No weight, no partition function.<br/>
    /// * `weighted` — a weighted selection among several agents. Requires a `partition_by` userfn expression naming what to hash on; different rules can use different partition functions.
    /// </summary>
    public readonly partial struct RuleTargets : global::System.IEquatable<RuleTargets>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RuleTargetsDiscriminatorType? Type { get; }

        /// <summary>
        /// Direct route to a single agent. The `agent_key` must reference an existing agent owned by the same customer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.SingleRuleTargets? Single { get; init; }
#else
        public global::Vectara.SingleRuleTargets? Single { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Single))]
#endif
        public bool IsSingle => Single != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSingle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.SingleRuleTargets? value)
        {
            value = Single;
            return IsSingle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.SingleRuleTargets PickSingle() => IsSingle
            ? Single!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Single' but the value was {ToString()}.");

        /// <summary>
        /// Weighted selection among several agents. The `partition_by` userfn expression is evaluated and hashed; the result picks which `options` entry serves this session. Different rules in the same policy can declare different `partition_by` expressions (US rules canary by user_id, EU rules by tenant_id, etc.).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WeightedRuleTargets? Weighted { get; init; }
#else
        public global::Vectara.WeightedRuleTargets? Weighted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Weighted))]
#endif
        public bool IsWeighted => Weighted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWeighted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WeightedRuleTargets? value)
        {
            value = Weighted;
            return IsWeighted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WeightedRuleTargets PickWeighted() => IsWeighted
            ? Weighted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Weighted' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RuleTargets(global::Vectara.SingleRuleTargets value) => new RuleTargets((global::Vectara.SingleRuleTargets?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SingleRuleTargets?(RuleTargets @this) => @this.Single;

        /// <summary>
        /// 
        /// </summary>
        public RuleTargets(global::Vectara.SingleRuleTargets? value)
        {
            Single = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleTargets FromSingle(global::Vectara.SingleRuleTargets? value) => new RuleTargets(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RuleTargets(global::Vectara.WeightedRuleTargets value) => new RuleTargets((global::Vectara.WeightedRuleTargets?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WeightedRuleTargets?(RuleTargets @this) => @this.Weighted;

        /// <summary>
        /// 
        /// </summary>
        public RuleTargets(global::Vectara.WeightedRuleTargets? value)
        {
            Weighted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RuleTargets FromWeighted(global::Vectara.WeightedRuleTargets? value) => new RuleTargets(value);

        /// <summary>
        /// 
        /// </summary>
        public RuleTargets(
            global::Vectara.RuleTargetsDiscriminatorType? type,
            global::Vectara.SingleRuleTargets? single,
            global::Vectara.WeightedRuleTargets? weighted
            )
        {
            Type = type;

            Single = single;
            Weighted = weighted;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Weighted as object ??
            Single as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Single?.ToString() ??
            Weighted?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSingle && !IsWeighted || !IsSingle && IsWeighted;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.SingleRuleTargets, TResult>? single = null,
            global::System.Func<global::Vectara.WeightedRuleTargets, TResult>? weighted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingle && single != null)
            {
                return single(Single!);
            }
            else if (IsWeighted && weighted != null)
            {
                return weighted(Weighted!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.SingleRuleTargets>? single = null,

            global::System.Action<global::Vectara.WeightedRuleTargets>? weighted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingle)
            {
                single?.Invoke(Single!);
            }
            else if (IsWeighted)
            {
                weighted?.Invoke(Weighted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.SingleRuleTargets>? single = null,
            global::System.Action<global::Vectara.WeightedRuleTargets>? weighted = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingle)
            {
                single?.Invoke(Single!);
            }
            else if (IsWeighted)
            {
                weighted?.Invoke(Weighted!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Single,
                typeof(global::Vectara.SingleRuleTargets),
                Weighted,
                typeof(global::Vectara.WeightedRuleTargets),
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
        public bool Equals(RuleTargets other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SingleRuleTargets?>.Default.Equals(Single, other.Single) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WeightedRuleTargets?>.Default.Equals(Weighted, other.Weighted) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RuleTargets obj1, RuleTargets obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RuleTargets>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RuleTargets obj1, RuleTargets obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RuleTargets o && Equals(o);
        }
    }
}
