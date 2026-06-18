#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A time series of metric points. The shape of points varies by metric type.
    /// </summary>
    public readonly partial struct MetricSeries : global::System.IEquatable<MetricSeries>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.MetricSeriesDiscriminatorType? Type { get; }

        /// <summary>
        /// A series of counter values (monotonic count or sum).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CounterMetricSeries? Counter { get; init; }
#else
        public global::Vectara.CounterMetricSeries? Counter { get; }
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
            out global::Vectara.CounterMetricSeries? value)
        {
            value = Counter;
            return IsCounter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CounterMetricSeries PickCounter() => IsCounter
            ? Counter!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Counter' but the value was {ToString()}.");

        /// <summary>
        /// A series of gauge values (point-in-time aggregates such as mean, max, distinct count).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.GaugeMetricSeries? Gauge { get; init; }
#else
        public global::Vectara.GaugeMetricSeries? Gauge { get; }
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
            out global::Vectara.GaugeMetricSeries? value)
        {
            value = Gauge;
            return IsGauge;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GaugeMetricSeries PickGauge() => IsGauge
            ? Gauge!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gauge' but the value was {ToString()}.");

        /// <summary>
        /// A series of percentile aggregates over a t-digest state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.PercentilesMetricSeries? Percentiles { get; init; }
#else
        public global::Vectara.PercentilesMetricSeries? Percentiles { get; }
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
            out global::Vectara.PercentilesMetricSeries? value)
        {
            value = Percentiles;
            return IsPercentiles;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PercentilesMetricSeries PickPercentiles() => IsPercentiles
            ? Percentiles!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Percentiles' but the value was {ToString()}.");

        /// <summary>
        /// A series of distribution histograms.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.DistributionMetricSeries? Distribution { get; init; }
#else
        public global::Vectara.DistributionMetricSeries? Distribution { get; }
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
            out global::Vectara.DistributionMetricSeries? value)
        {
            value = Distribution;
            return IsDistribution;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.DistributionMetricSeries PickDistribution() => IsDistribution
            ? Distribution!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Distribution' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricSeries(global::Vectara.CounterMetricSeries value) => new MetricSeries((global::Vectara.CounterMetricSeries?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CounterMetricSeries?(MetricSeries @this) => @this.Counter;

        /// <summary>
        /// 
        /// </summary>
        public MetricSeries(global::Vectara.CounterMetricSeries? value)
        {
            Counter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricSeries FromCounter(global::Vectara.CounterMetricSeries? value) => new MetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricSeries(global::Vectara.GaugeMetricSeries value) => new MetricSeries((global::Vectara.GaugeMetricSeries?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GaugeMetricSeries?(MetricSeries @this) => @this.Gauge;

        /// <summary>
        /// 
        /// </summary>
        public MetricSeries(global::Vectara.GaugeMetricSeries? value)
        {
            Gauge = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricSeries FromGauge(global::Vectara.GaugeMetricSeries? value) => new MetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricSeries(global::Vectara.PercentilesMetricSeries value) => new MetricSeries((global::Vectara.PercentilesMetricSeries?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PercentilesMetricSeries?(MetricSeries @this) => @this.Percentiles;

        /// <summary>
        /// 
        /// </summary>
        public MetricSeries(global::Vectara.PercentilesMetricSeries? value)
        {
            Percentiles = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricSeries FromPercentiles(global::Vectara.PercentilesMetricSeries? value) => new MetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricSeries(global::Vectara.DistributionMetricSeries value) => new MetricSeries((global::Vectara.DistributionMetricSeries?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.DistributionMetricSeries?(MetricSeries @this) => @this.Distribution;

        /// <summary>
        /// 
        /// </summary>
        public MetricSeries(global::Vectara.DistributionMetricSeries? value)
        {
            Distribution = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetricSeries FromDistribution(global::Vectara.DistributionMetricSeries? value) => new MetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public MetricSeries(
            global::Vectara.MetricSeriesDiscriminatorType? type,
            global::Vectara.CounterMetricSeries? counter,
            global::Vectara.GaugeMetricSeries? gauge,
            global::Vectara.PercentilesMetricSeries? percentiles,
            global::Vectara.DistributionMetricSeries? distribution
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
            global::System.Func<global::Vectara.CounterMetricSeries?, TResult>? counter = null,
            global::System.Func<global::Vectara.GaugeMetricSeries?, TResult>? gauge = null,
            global::System.Func<global::Vectara.PercentilesMetricSeries?, TResult>? percentiles = null,
            global::System.Func<global::Vectara.DistributionMetricSeries?, TResult>? distribution = null,
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
            global::System.Action<global::Vectara.CounterMetricSeries?>? counter = null,

            global::System.Action<global::Vectara.GaugeMetricSeries?>? gauge = null,

            global::System.Action<global::Vectara.PercentilesMetricSeries?>? percentiles = null,

            global::System.Action<global::Vectara.DistributionMetricSeries?>? distribution = null,
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
            global::System.Action<global::Vectara.CounterMetricSeries?>? counter = null,
            global::System.Action<global::Vectara.GaugeMetricSeries?>? gauge = null,
            global::System.Action<global::Vectara.PercentilesMetricSeries?>? percentiles = null,
            global::System.Action<global::Vectara.DistributionMetricSeries?>? distribution = null,
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
                typeof(global::Vectara.CounterMetricSeries),
                Gauge,
                typeof(global::Vectara.GaugeMetricSeries),
                Percentiles,
                typeof(global::Vectara.PercentilesMetricSeries),
                Distribution,
                typeof(global::Vectara.DistributionMetricSeries),
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
        public bool Equals(MetricSeries other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CounterMetricSeries?>.Default.Equals(Counter, other.Counter) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GaugeMetricSeries?>.Default.Equals(Gauge, other.Gauge) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PercentilesMetricSeries?>.Default.Equals(Percentiles, other.Percentiles) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.DistributionMetricSeries?>.Default.Equals(Distribution, other.Distribution) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetricSeries obj1, MetricSeries obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetricSeries>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetricSeries obj1, MetricSeries obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetricSeries o && Equals(o);
        }
    }
}
