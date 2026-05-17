#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A series of gauge values (point-in-time aggregates such as mean, max, distinct count).
    /// </summary>
    public readonly partial struct GaugeMetricSeries : global::System.IEquatable<GaugeMetricSeries>
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
        public global::Vectara.GaugeMetricSeriesVariant2? GaugeMetricSeriesVariant2 { get; init; }
#else
        public global::Vectara.GaugeMetricSeriesVariant2? GaugeMetricSeriesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GaugeMetricSeriesVariant2))]
#endif
        public bool IsGaugeMetricSeriesVariant2 => GaugeMetricSeriesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGaugeMetricSeriesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GaugeMetricSeriesVariant2? value)
        {
            value = GaugeMetricSeriesVariant2;
            return IsGaugeMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GaugeMetricSeriesVariant2 PickGaugeMetricSeriesVariant2() => IsGaugeMetricSeriesVariant2
            ? GaugeMetricSeriesVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GaugeMetricSeriesVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GaugeMetricSeries(global::Vectara.MetricSeriesBase value) => new GaugeMetricSeries((global::Vectara.MetricSeriesBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricSeriesBase?(GaugeMetricSeries @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GaugeMetricSeries(global::Vectara.MetricSeriesBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GaugeMetricSeries FromBase(global::Vectara.MetricSeriesBase? value) => new GaugeMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GaugeMetricSeries(global::Vectara.GaugeMetricSeriesVariant2 value) => new GaugeMetricSeries((global::Vectara.GaugeMetricSeriesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GaugeMetricSeriesVariant2?(GaugeMetricSeries @this) => @this.GaugeMetricSeriesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GaugeMetricSeries(global::Vectara.GaugeMetricSeriesVariant2? value)
        {
            GaugeMetricSeriesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GaugeMetricSeries FromGaugeMetricSeriesVariant2(global::Vectara.GaugeMetricSeriesVariant2? value) => new GaugeMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public GaugeMetricSeries(
            global::Vectara.MetricSeriesBase? @base,
            global::Vectara.GaugeMetricSeriesVariant2? gaugeMetricSeriesVariant2
            )
        {
            Base = @base;
            GaugeMetricSeriesVariant2 = gaugeMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GaugeMetricSeriesVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GaugeMetricSeriesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGaugeMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricSeriesBase, TResult>? @base = null,
            global::System.Func<global::Vectara.GaugeMetricSeriesVariant2, TResult>? gaugeMetricSeriesVariant2 = null,
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
            else if (IsGaugeMetricSeriesVariant2 && gaugeMetricSeriesVariant2 != null)
            {
                return gaugeMetricSeriesVariant2(GaugeMetricSeriesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,

            global::System.Action<global::Vectara.GaugeMetricSeriesVariant2>? gaugeMetricSeriesVariant2 = null,
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
            else if (IsGaugeMetricSeriesVariant2)
            {
                gaugeMetricSeriesVariant2?.Invoke(GaugeMetricSeriesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,
            global::System.Action<global::Vectara.GaugeMetricSeriesVariant2>? gaugeMetricSeriesVariant2 = null,
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
            else if (IsGaugeMetricSeriesVariant2)
            {
                gaugeMetricSeriesVariant2?.Invoke(GaugeMetricSeriesVariant2!);
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
                GaugeMetricSeriesVariant2,
                typeof(global::Vectara.GaugeMetricSeriesVariant2),
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
        public bool Equals(GaugeMetricSeries other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricSeriesBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GaugeMetricSeriesVariant2?>.Default.Equals(GaugeMetricSeriesVariant2, other.GaugeMetricSeriesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GaugeMetricSeries obj1, GaugeMetricSeries obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GaugeMetricSeries>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GaugeMetricSeries obj1, GaugeMetricSeries obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GaugeMetricSeries o && Equals(o);
        }
    }
}
