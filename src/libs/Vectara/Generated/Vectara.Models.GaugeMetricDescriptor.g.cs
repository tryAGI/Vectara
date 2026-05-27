#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Descriptor for a gauge metric.
    /// </summary>
    public readonly partial struct GaugeMetricDescriptor : global::System.IEquatable<GaugeMetricDescriptor>
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
        public global::Vectara.GaugeMetricDescriptorVariant2? GaugeMetricDescriptorVariant2 { get; init; }
#else
        public global::Vectara.GaugeMetricDescriptorVariant2? GaugeMetricDescriptorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GaugeMetricDescriptorVariant2))]
#endif
        public bool IsGaugeMetricDescriptorVariant2 => GaugeMetricDescriptorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGaugeMetricDescriptorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.GaugeMetricDescriptorVariant2? value)
        {
            value = GaugeMetricDescriptorVariant2;
            return IsGaugeMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.GaugeMetricDescriptorVariant2 PickGaugeMetricDescriptorVariant2() => IsGaugeMetricDescriptorVariant2
            ? GaugeMetricDescriptorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GaugeMetricDescriptorVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GaugeMetricDescriptor(global::Vectara.MetricDescriptorBase value) => new GaugeMetricDescriptor((global::Vectara.MetricDescriptorBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricDescriptorBase?(GaugeMetricDescriptor @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public GaugeMetricDescriptor(global::Vectara.MetricDescriptorBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GaugeMetricDescriptor FromBase(global::Vectara.MetricDescriptorBase? value) => new GaugeMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GaugeMetricDescriptor(global::Vectara.GaugeMetricDescriptorVariant2 value) => new GaugeMetricDescriptor((global::Vectara.GaugeMetricDescriptorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.GaugeMetricDescriptorVariant2?(GaugeMetricDescriptor @this) => @this.GaugeMetricDescriptorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GaugeMetricDescriptor(global::Vectara.GaugeMetricDescriptorVariant2? value)
        {
            GaugeMetricDescriptorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GaugeMetricDescriptor FromGaugeMetricDescriptorVariant2(global::Vectara.GaugeMetricDescriptorVariant2? value) => new GaugeMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public GaugeMetricDescriptor(
            global::Vectara.MetricDescriptorBase? @base,
            global::Vectara.GaugeMetricDescriptorVariant2? gaugeMetricDescriptorVariant2
            )
        {
            Base = @base;
            GaugeMetricDescriptorVariant2 = gaugeMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GaugeMetricDescriptorVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            GaugeMetricDescriptorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsGaugeMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricDescriptorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.GaugeMetricDescriptorVariant2, TResult>? gaugeMetricDescriptorVariant2 = null,
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
            else if (IsGaugeMetricDescriptorVariant2 && gaugeMetricDescriptorVariant2 != null)
            {
                return gaugeMetricDescriptorVariant2(GaugeMetricDescriptorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,

            global::System.Action<global::Vectara.GaugeMetricDescriptorVariant2>? gaugeMetricDescriptorVariant2 = null,
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
            else if (IsGaugeMetricDescriptorVariant2)
            {
                gaugeMetricDescriptorVariant2?.Invoke(GaugeMetricDescriptorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,
            global::System.Action<global::Vectara.GaugeMetricDescriptorVariant2>? gaugeMetricDescriptorVariant2 = null,
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
            else if (IsGaugeMetricDescriptorVariant2)
            {
                gaugeMetricDescriptorVariant2?.Invoke(GaugeMetricDescriptorVariant2!);
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
                GaugeMetricDescriptorVariant2,
                typeof(global::Vectara.GaugeMetricDescriptorVariant2),
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
        public bool Equals(GaugeMetricDescriptor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricDescriptorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.GaugeMetricDescriptorVariant2?>.Default.Equals(GaugeMetricDescriptorVariant2, other.GaugeMetricDescriptorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GaugeMetricDescriptor obj1, GaugeMetricDescriptor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GaugeMetricDescriptor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GaugeMetricDescriptor obj1, GaugeMetricDescriptor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GaugeMetricDescriptor o && Equals(o);
        }
    }
}
