#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A series of histogram aggregates over a value-axis distribution table.
    /// </summary>
    public readonly partial struct DistributionMetricSeries : global::System.IEquatable<DistributionMetricSeries>
    {
        /// <summary>
        /// Common properties shared by all metric series kinds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.MetricSeriesBase? Base { get; init; }
#else
        public global::Vectara.MetricSeriesBase? Base { get; }
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
            out global::Vectara.MetricSeriesBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.MetricSeriesBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DistributionMetricSeriesVariant2? DistributionMetricSeriesVariant2 { get; init; }
#else
        public global::Vectara.DistributionMetricSeriesVariant2? DistributionMetricSeriesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistributionMetricSeriesVariant2))]
#endif
        public bool IsDistributionMetricSeriesVariant2 => DistributionMetricSeriesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDistributionMetricSeriesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DistributionMetricSeriesVariant2? value)
        {
            value = DistributionMetricSeriesVariant2;
            return IsDistributionMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DistributionMetricSeriesVariant2 PickDistributionMetricSeriesVariant2() => IsDistributionMetricSeriesVariant2
            ? DistributionMetricSeriesVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DistributionMetricSeriesVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DistributionMetricSeries(global::Vectara.MetricSeriesBase value) => new DistributionMetricSeries((global::Vectara.MetricSeriesBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricSeriesBase?(DistributionMetricSeries @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DistributionMetricSeries(global::Vectara.MetricSeriesBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DistributionMetricSeries FromBase(global::Vectara.MetricSeriesBase? value) => new DistributionMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DistributionMetricSeries(global::Vectara.DistributionMetricSeriesVariant2 value) => new DistributionMetricSeries((global::Vectara.DistributionMetricSeriesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DistributionMetricSeriesVariant2?(DistributionMetricSeries @this) => @this.DistributionMetricSeriesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DistributionMetricSeries(global::Vectara.DistributionMetricSeriesVariant2? value)
        {
            DistributionMetricSeriesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DistributionMetricSeries FromDistributionMetricSeriesVariant2(global::Vectara.DistributionMetricSeriesVariant2? value) => new DistributionMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public DistributionMetricSeries(
            global::Vectara.MetricSeriesBase? @base,
            global::Vectara.DistributionMetricSeriesVariant2? distributionMetricSeriesVariant2
            )
        {
            Base = @base;
            DistributionMetricSeriesVariant2 = distributionMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DistributionMetricSeriesVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DistributionMetricSeriesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDistributionMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricSeriesBase, TResult>? @base = null,
            global::System.Func<global::Vectara.DistributionMetricSeriesVariant2, TResult>? distributionMetricSeriesVariant2 = null,
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
            else if (IsDistributionMetricSeriesVariant2 && distributionMetricSeriesVariant2 != null)
            {
                return distributionMetricSeriesVariant2(DistributionMetricSeriesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,

            global::System.Action<global::Vectara.DistributionMetricSeriesVariant2>? distributionMetricSeriesVariant2 = null,
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
            else if (IsDistributionMetricSeriesVariant2)
            {
                distributionMetricSeriesVariant2?.Invoke(DistributionMetricSeriesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,
            global::System.Action<global::Vectara.DistributionMetricSeriesVariant2>? distributionMetricSeriesVariant2 = null,
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
            else if (IsDistributionMetricSeriesVariant2)
            {
                distributionMetricSeriesVariant2?.Invoke(DistributionMetricSeriesVariant2!);
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
                typeof(global::Vectara.MetricSeriesBase),
                DistributionMetricSeriesVariant2,
                typeof(global::Vectara.DistributionMetricSeriesVariant2),
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
        public bool Equals(DistributionMetricSeries other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricSeriesBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DistributionMetricSeriesVariant2?>.Default.Equals(DistributionMetricSeriesVariant2, other.DistributionMetricSeriesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DistributionMetricSeries obj1, DistributionMetricSeries obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DistributionMetricSeries>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DistributionMetricSeries obj1, DistributionMetricSeries obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DistributionMetricSeries o && Equals(o);
        }
    }
}
