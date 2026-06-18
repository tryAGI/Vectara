#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A series of percentile aggregates over a t-digest state.
    /// </summary>
    public readonly partial struct PercentilesMetricSeries : global::System.IEquatable<PercentilesMetricSeries>
    {
        /// <summary>
        /// Common properties shared by all metric series types.
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
        public global::Vectara.PercentilesMetricSeriesVariant2? PercentilesMetricSeriesVariant2 { get; init; }
#else
        public global::Vectara.PercentilesMetricSeriesVariant2? PercentilesMetricSeriesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PercentilesMetricSeriesVariant2))]
#endif
        public bool IsPercentilesMetricSeriesVariant2 => PercentilesMetricSeriesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPercentilesMetricSeriesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.PercentilesMetricSeriesVariant2? value)
        {
            value = PercentilesMetricSeriesVariant2;
            return IsPercentilesMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PercentilesMetricSeriesVariant2 PickPercentilesMetricSeriesVariant2() => IsPercentilesMetricSeriesVariant2
            ? PercentilesMetricSeriesVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PercentilesMetricSeriesVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PercentilesMetricSeries(global::Vectara.MetricSeriesBase value) => new PercentilesMetricSeries((global::Vectara.MetricSeriesBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricSeriesBase?(PercentilesMetricSeries @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public PercentilesMetricSeries(global::Vectara.MetricSeriesBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PercentilesMetricSeries FromBase(global::Vectara.MetricSeriesBase? value) => new PercentilesMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PercentilesMetricSeries(global::Vectara.PercentilesMetricSeriesVariant2 value) => new PercentilesMetricSeries((global::Vectara.PercentilesMetricSeriesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PercentilesMetricSeriesVariant2?(PercentilesMetricSeries @this) => @this.PercentilesMetricSeriesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PercentilesMetricSeries(global::Vectara.PercentilesMetricSeriesVariant2? value)
        {
            PercentilesMetricSeriesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PercentilesMetricSeries FromPercentilesMetricSeriesVariant2(global::Vectara.PercentilesMetricSeriesVariant2? value) => new PercentilesMetricSeries(value);

        /// <summary>
        /// 
        /// </summary>
        public PercentilesMetricSeries(
            global::Vectara.MetricSeriesBase? @base,
            global::Vectara.PercentilesMetricSeriesVariant2? percentilesMetricSeriesVariant2
            )
        {
            Base = @base;
            PercentilesMetricSeriesVariant2 = percentilesMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PercentilesMetricSeriesVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            PercentilesMetricSeriesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsPercentilesMetricSeriesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricSeriesBase, TResult>? @base = null,
            global::System.Func<global::Vectara.PercentilesMetricSeriesVariant2, TResult>? percentilesMetricSeriesVariant2 = null,
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
            else if (IsPercentilesMetricSeriesVariant2 && percentilesMetricSeriesVariant2 != null)
            {
                return percentilesMetricSeriesVariant2(PercentilesMetricSeriesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,

            global::System.Action<global::Vectara.PercentilesMetricSeriesVariant2>? percentilesMetricSeriesVariant2 = null,
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
            else if (IsPercentilesMetricSeriesVariant2)
            {
                percentilesMetricSeriesVariant2?.Invoke(PercentilesMetricSeriesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricSeriesBase>? @base = null,
            global::System.Action<global::Vectara.PercentilesMetricSeriesVariant2>? percentilesMetricSeriesVariant2 = null,
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
            else if (IsPercentilesMetricSeriesVariant2)
            {
                percentilesMetricSeriesVariant2?.Invoke(PercentilesMetricSeriesVariant2!);
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
                PercentilesMetricSeriesVariant2,
                typeof(global::Vectara.PercentilesMetricSeriesVariant2),
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
        public bool Equals(PercentilesMetricSeries other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricSeriesBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PercentilesMetricSeriesVariant2?>.Default.Equals(PercentilesMetricSeriesVariant2, other.PercentilesMetricSeriesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PercentilesMetricSeries obj1, PercentilesMetricSeries obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PercentilesMetricSeries>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PercentilesMetricSeries obj1, PercentilesMetricSeries obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PercentilesMetricSeries o && Equals(o);
        }
    }
}
