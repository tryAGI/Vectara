#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A series of counter values (monotonic count or sum).
    /// </summary>
    public readonly partial struct CounterMetricSeries : global::System.IEquatable<CounterMetricSeries>
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
        public global::Vectara.CounterMetricSeriesVariant2? CounterMetricSeriesVariant2 { get; init; }
#else
        public global::Vectara.CounterMetricSeriesVariant2? CounterMetricSeriesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CounterMetricSeriesVariant2))]
#endif
        public bool IsCounterMetricSeriesVariant2 => CounterMetricSeriesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCounterMetricSeriesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CounterMetricSeriesVariant2? value)
        {
            value = CounterMetricSeriesVariant2;
            return IsCounterMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CounterMetricSeriesVariant2 PickCounterMetricSeriesVariant2() => IsCounterMetricSeriesVariant2
            ? CounterMetricSeriesVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CounterMetricSeriesVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CounterMetricSeries(global::Vectara.MetricSeriesBase value) => new CounterMetricSeries((global::Vectara.MetricSeriesBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricSeriesBase?(CounterMetricSeries @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CounterMetricSeries(global::Vectara.MetricSeriesBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CounterMetricSeries FromBase(global::Vectara.MetricSeriesBase? value) => new CounterMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CounterMetricSeries(global::Vectara.CounterMetricSeriesVariant2 value) => new CounterMetricSeries((global::Vectara.CounterMetricSeriesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CounterMetricSeriesVariant2?(CounterMetricSeries @this) => @this.CounterMetricSeriesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CounterMetricSeries(global::Vectara.CounterMetricSeriesVariant2? value)
        {
            CounterMetricSeriesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CounterMetricSeries FromCounterMetricSeriesVariant2(global::Vectara.CounterMetricSeriesVariant2? value) => new CounterMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public CounterMetricSeries(
            global::Vectara.MetricSeriesBase? @base,
            global::Vectara.CounterMetricSeriesVariant2? counterMetricSeriesVariant2
            )
        {
            Base = @base;
            CounterMetricSeriesVariant2 = counterMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CounterMetricSeriesVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CounterMetricSeriesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCounterMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricSeriesBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CounterMetricSeriesVariant2, TResult>? counterMetricSeriesVariant2 = null,
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
            else if (IsCounterMetricSeriesVariant2 && counterMetricSeriesVariant2 != null)
            {
                return counterMetricSeriesVariant2(CounterMetricSeriesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,

            global::System.Action<global::Vectara.CounterMetricSeriesVariant2>? counterMetricSeriesVariant2 = null,
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
            else if (IsCounterMetricSeriesVariant2)
            {
                counterMetricSeriesVariant2?.Invoke(CounterMetricSeriesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,
            global::System.Action<global::Vectara.CounterMetricSeriesVariant2>? counterMetricSeriesVariant2 = null,
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
            else if (IsCounterMetricSeriesVariant2)
            {
                counterMetricSeriesVariant2?.Invoke(CounterMetricSeriesVariant2!);
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
                CounterMetricSeriesVariant2,
                typeof(global::Vectara.CounterMetricSeriesVariant2),
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
        public bool Equals(CounterMetricSeries other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricSeriesBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CounterMetricSeriesVariant2?>.Default.Equals(CounterMetricSeriesVariant2, other.CounterMetricSeriesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CounterMetricSeries obj1, CounterMetricSeries obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CounterMetricSeries>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CounterMetricSeries obj1, CounterMetricSeries obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CounterMetricSeries o && Equals(o);
        }
    }
}
