#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Descriptor for a distribution metric. Carries the canonical bin list with numeric bounds.
    /// </summary>
    public readonly partial struct DistributionMetricDescriptor : global::System.IEquatable<DistributionMetricDescriptor>
    {
        /// <summary>
        /// Common metadata fields shared by every metric descriptor regardless of kind.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.MetricDescriptorBase? Base { get; init; }
#else
        public global::Vectara.MetricDescriptorBase? Base { get; }
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
            out global::Vectara.MetricDescriptorBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.MetricDescriptorBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DistributionMetricDescriptorVariant2? DistributionMetricDescriptorVariant2 { get; init; }
#else
        public global::Vectara.DistributionMetricDescriptorVariant2? DistributionMetricDescriptorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistributionMetricDescriptorVariant2))]
#endif
        public bool IsDistributionMetricDescriptorVariant2 => DistributionMetricDescriptorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDistributionMetricDescriptorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DistributionMetricDescriptorVariant2? value)
        {
            value = DistributionMetricDescriptorVariant2;
            return IsDistributionMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DistributionMetricDescriptorVariant2 PickDistributionMetricDescriptorVariant2() => IsDistributionMetricDescriptorVariant2
            ? DistributionMetricDescriptorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DistributionMetricDescriptorVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DistributionMetricDescriptor(global::Vectara.MetricDescriptorBase value) => new DistributionMetricDescriptor((global::Vectara.MetricDescriptorBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricDescriptorBase?(DistributionMetricDescriptor @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DistributionMetricDescriptor(global::Vectara.MetricDescriptorBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DistributionMetricDescriptor FromBase(global::Vectara.MetricDescriptorBase? value) => new DistributionMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DistributionMetricDescriptor(global::Vectara.DistributionMetricDescriptorVariant2 value) => new DistributionMetricDescriptor((global::Vectara.DistributionMetricDescriptorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DistributionMetricDescriptorVariant2?(DistributionMetricDescriptor @this) => @this.DistributionMetricDescriptorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DistributionMetricDescriptor(global::Vectara.DistributionMetricDescriptorVariant2? value)
        {
            DistributionMetricDescriptorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DistributionMetricDescriptor FromDistributionMetricDescriptorVariant2(global::Vectara.DistributionMetricDescriptorVariant2? value) => new DistributionMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public DistributionMetricDescriptor(
            global::Vectara.MetricDescriptorBase? @base,
            global::Vectara.DistributionMetricDescriptorVariant2? distributionMetricDescriptorVariant2
            )
        {
            Base = @base;
            DistributionMetricDescriptorVariant2 = distributionMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DistributionMetricDescriptorVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DistributionMetricDescriptorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDistributionMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricDescriptorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.DistributionMetricDescriptorVariant2, TResult>? distributionMetricDescriptorVariant2 = null,
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
            else if (IsDistributionMetricDescriptorVariant2 && distributionMetricDescriptorVariant2 != null)
            {
                return distributionMetricDescriptorVariant2(DistributionMetricDescriptorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,

            global::System.Action<global::Vectara.DistributionMetricDescriptorVariant2>? distributionMetricDescriptorVariant2 = null,
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
            else if (IsDistributionMetricDescriptorVariant2)
            {
                distributionMetricDescriptorVariant2?.Invoke(DistributionMetricDescriptorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,
            global::System.Action<global::Vectara.DistributionMetricDescriptorVariant2>? distributionMetricDescriptorVariant2 = null,
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
            else if (IsDistributionMetricDescriptorVariant2)
            {
                distributionMetricDescriptorVariant2?.Invoke(DistributionMetricDescriptorVariant2!);
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
                typeof(global::Vectara.MetricDescriptorBase),
                DistributionMetricDescriptorVariant2,
                typeof(global::Vectara.DistributionMetricDescriptorVariant2),
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
        public bool Equals(DistributionMetricDescriptor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricDescriptorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DistributionMetricDescriptorVariant2?>.Default.Equals(DistributionMetricDescriptorVariant2, other.DistributionMetricDescriptorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DistributionMetricDescriptor obj1, DistributionMetricDescriptor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DistributionMetricDescriptor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DistributionMetricDescriptor obj1, DistributionMetricDescriptor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DistributionMetricDescriptor o && Equals(o);
        }
    }
}
