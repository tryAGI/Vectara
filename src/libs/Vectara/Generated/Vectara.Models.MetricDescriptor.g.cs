#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Metadata about a registered metric. The concrete variant is selected by `type`.
    /// </summary>
    public readonly partial struct MetricDescriptor : global::System.IEquatable<MetricDescriptor>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.MetricDescriptorDiscriminatorType? Type { get; }

        /// <summary>
        /// Descriptor for a counter metric.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CounterMetricDescriptor? Counter { get; init; }
#else
        public global::Vectara.CounterMetricDescriptor? Counter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Counter))]
#endif
        public bool IsCounter => Counter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCounter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CounterMetricDescriptor? value)
        {
            value = Counter;
            return IsCounter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CounterMetricDescriptor PickCounter() => IsCounter
            ? Counter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Counter' but the value was {ToString()}.");

        /// <summary>
        /// Descriptor for a gauge metric.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GaugeMetricDescriptor? Gauge { get; init; }
#else
        public global::Vectara.GaugeMetricDescriptor? Gauge { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gauge))]
#endif
        public bool IsGauge => Gauge != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGauge(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GaugeMetricDescriptor? value)
        {
            value = Gauge;
            return IsGauge;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GaugeMetricDescriptor PickGauge() => IsGauge
            ? Gauge!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gauge' but the value was {ToString()}.");

        /// <summary>
        /// Descriptor for a percentiles metric. Carries the ordered list of percentile labels this metric emits.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.PercentilesMetricDescriptor? Percentiles { get; init; }
#else
        public global::Vectara.PercentilesMetricDescriptor? Percentiles { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Percentiles))]
#endif
        public bool IsPercentiles => Percentiles != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPercentiles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.PercentilesMetricDescriptor? value)
        {
            value = Percentiles;
            return IsPercentiles;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptor PickPercentiles() => IsPercentiles
            ? Percentiles!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Percentiles' but the value was {ToString()}.");

        /// <summary>
        /// Descriptor for a distribution metric. Carries the canonical bin list with numeric bounds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DistributionMetricDescriptor? Distribution { get; init; }
#else
        public global::Vectara.DistributionMetricDescriptor? Distribution { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Distribution))]
#endif
        public bool IsDistribution => Distribution != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDistribution(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.DistributionMetricDescriptor? value)
        {
            value = Distribution;
            return IsDistribution;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DistributionMetricDescriptor PickDistribution() => IsDistribution
            ? Distribution!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Distribution' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricDescriptor(global::Vectara.CounterMetricDescriptor value) => new MetricDescriptor((global::Vectara.CounterMetricDescriptor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CounterMetricDescriptor?(MetricDescriptor @this) => @this.Counter;

        /// <summary>
        /// 
        /// </summary>
        public MetricDescriptor(global::Vectara.CounterMetricDescriptor? value)
        {
            Counter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricDescriptor FromCounter(global::Vectara.CounterMetricDescriptor? value) => new MetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricDescriptor(global::Vectara.GaugeMetricDescriptor value) => new MetricDescriptor((global::Vectara.GaugeMetricDescriptor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GaugeMetricDescriptor?(MetricDescriptor @this) => @this.Gauge;

        /// <summary>
        /// 
        /// </summary>
        public MetricDescriptor(global::Vectara.GaugeMetricDescriptor? value)
        {
            Gauge = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricDescriptor FromGauge(global::Vectara.GaugeMetricDescriptor? value) => new MetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricDescriptor(global::Vectara.PercentilesMetricDescriptor value) => new MetricDescriptor((global::Vectara.PercentilesMetricDescriptor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PercentilesMetricDescriptor?(MetricDescriptor @this) => @this.Percentiles;

        /// <summary>
        /// 
        /// </summary>
        public MetricDescriptor(global::Vectara.PercentilesMetricDescriptor? value)
        {
            Percentiles = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricDescriptor FromPercentiles(global::Vectara.PercentilesMetricDescriptor? value) => new MetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricDescriptor(global::Vectara.DistributionMetricDescriptor value) => new MetricDescriptor((global::Vectara.DistributionMetricDescriptor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DistributionMetricDescriptor?(MetricDescriptor @this) => @this.Distribution;

        /// <summary>
        /// 
        /// </summary>
        public MetricDescriptor(global::Vectara.DistributionMetricDescriptor? value)
        {
            Distribution = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricDescriptor FromDistribution(global::Vectara.DistributionMetricDescriptor? value) => new MetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public MetricDescriptor(
            global::Vectara.MetricDescriptorDiscriminatorType? type,
            global::Vectara.CounterMetricDescriptor? counter,
            global::Vectara.GaugeMetricDescriptor? gauge,
            global::Vectara.PercentilesMetricDescriptor? percentiles,
            global::Vectara.DistributionMetricDescriptor? distribution
            )
        {
            Type = type;

            Counter = counter;
            Gauge = gauge;
            Percentiles = percentiles;
            Distribution = distribution;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Distribution as object ??
            Percentiles as object ??
            Gauge as object ??
            Counter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Counter?.ToString() ??
            Gauge?.ToString() ??
            Percentiles?.ToString() ??
            Distribution?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCounter && !IsGauge && !IsPercentiles && !IsDistribution || !IsCounter && IsGauge && !IsPercentiles && !IsDistribution || !IsCounter && !IsGauge && IsPercentiles && !IsDistribution || !IsCounter && !IsGauge && !IsPercentiles && IsDistribution;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CounterMetricDescriptor?, TResult>? counter = null,
            global::System.Func<global::Vectara.GaugeMetricDescriptor?, TResult>? gauge = null,
            global::System.Func<global::Vectara.PercentilesMetricDescriptor?, TResult>? percentiles = null,
            global::System.Func<global::Vectara.DistributionMetricDescriptor?, TResult>? distribution = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCounter && counter != null)
            {
                return counter(Counter!);
            }
            else if (IsGauge && gauge != null)
            {
                return gauge(Gauge!);
            }
            else if (IsPercentiles && percentiles != null)
            {
                return percentiles(Percentiles!);
            }
            else if (IsDistribution && distribution != null)
            {
                return distribution(Distribution!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CounterMetricDescriptor?>? counter = null,

            global::System.Action<global::Vectara.GaugeMetricDescriptor?>? gauge = null,

            global::System.Action<global::Vectara.PercentilesMetricDescriptor?>? percentiles = null,

            global::System.Action<global::Vectara.DistributionMetricDescriptor?>? distribution = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCounter)
            {
                counter?.Invoke(Counter!);
            }
            else if (IsGauge)
            {
                gauge?.Invoke(Gauge!);
            }
            else if (IsPercentiles)
            {
                percentiles?.Invoke(Percentiles!);
            }
            else if (IsDistribution)
            {
                distribution?.Invoke(Distribution!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CounterMetricDescriptor?>? counter = null,
            global::System.Action<global::Vectara.GaugeMetricDescriptor?>? gauge = null,
            global::System.Action<global::Vectara.PercentilesMetricDescriptor?>? percentiles = null,
            global::System.Action<global::Vectara.DistributionMetricDescriptor?>? distribution = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCounter)
            {
                counter?.Invoke(Counter!);
            }
            else if (IsGauge)
            {
                gauge?.Invoke(Gauge!);
            }
            else if (IsPercentiles)
            {
                percentiles?.Invoke(Percentiles!);
            }
            else if (IsDistribution)
            {
                distribution?.Invoke(Distribution!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Counter,
                typeof(global::Vectara.CounterMetricDescriptor),
                Gauge,
                typeof(global::Vectara.GaugeMetricDescriptor),
                Percentiles,
                typeof(global::Vectara.PercentilesMetricDescriptor),
                Distribution,
                typeof(global::Vectara.DistributionMetricDescriptor),
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
        public bool Equals(MetricDescriptor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CounterMetricDescriptor?>.Default.Equals(Counter, other.Counter) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GaugeMetricDescriptor?>.Default.Equals(Gauge, other.Gauge) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PercentilesMetricDescriptor?>.Default.Equals(Percentiles, other.Percentiles) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DistributionMetricDescriptor?>.Default.Equals(Distribution, other.Distribution) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetricDescriptor obj1, MetricDescriptor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetricDescriptor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetricDescriptor obj1, MetricDescriptor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetricDescriptor o && Equals(o);
        }
    }
}
