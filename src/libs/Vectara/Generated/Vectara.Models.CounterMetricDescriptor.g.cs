#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Descriptor for a counter metric.
    /// </summary>
    public readonly partial struct CounterMetricDescriptor : global::System.IEquatable<CounterMetricDescriptor>
    {
        /// <summary>
        /// Common metadata fields shared by every metric descriptor regardless of type.
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
        public global::Vectara.CounterMetricDescriptorVariant2? CounterMetricDescriptorVariant2 { get; init; }
#else
        public global::Vectara.CounterMetricDescriptorVariant2? CounterMetricDescriptorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CounterMetricDescriptorVariant2))]
#endif
        public bool IsCounterMetricDescriptorVariant2 => CounterMetricDescriptorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCounterMetricDescriptorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CounterMetricDescriptorVariant2? value)
        {
            value = CounterMetricDescriptorVariant2;
            return IsCounterMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CounterMetricDescriptorVariant2 PickCounterMetricDescriptorVariant2() => IsCounterMetricDescriptorVariant2
            ? CounterMetricDescriptorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CounterMetricDescriptorVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CounterMetricDescriptor(global::Vectara.MetricDescriptorBase value) => new CounterMetricDescriptor((global::Vectara.MetricDescriptorBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricDescriptorBase?(CounterMetricDescriptor @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CounterMetricDescriptor(global::Vectara.MetricDescriptorBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CounterMetricDescriptor FromBase(global::Vectara.MetricDescriptorBase? value) => new CounterMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CounterMetricDescriptor(global::Vectara.CounterMetricDescriptorVariant2 value) => new CounterMetricDescriptor((global::Vectara.CounterMetricDescriptorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CounterMetricDescriptorVariant2?(CounterMetricDescriptor @this) => @this.CounterMetricDescriptorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CounterMetricDescriptor(global::Vectara.CounterMetricDescriptorVariant2? value)
        {
            CounterMetricDescriptorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CounterMetricDescriptor FromCounterMetricDescriptorVariant2(global::Vectara.CounterMetricDescriptorVariant2? value) => new CounterMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public CounterMetricDescriptor(
            global::Vectara.MetricDescriptorBase? @base,
            global::Vectara.CounterMetricDescriptorVariant2? counterMetricDescriptorVariant2
            )
        {
            Base = @base;
            CounterMetricDescriptorVariant2 = counterMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CounterMetricDescriptorVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CounterMetricDescriptorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCounterMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricDescriptorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CounterMetricDescriptorVariant2, TResult>? counterMetricDescriptorVariant2 = null,
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
            else if (IsCounterMetricDescriptorVariant2 && counterMetricDescriptorVariant2 != null)
            {
                return counterMetricDescriptorVariant2(CounterMetricDescriptorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,

            global::System.Action<global::Vectara.CounterMetricDescriptorVariant2>? counterMetricDescriptorVariant2 = null,
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
            else if (IsCounterMetricDescriptorVariant2)
            {
                counterMetricDescriptorVariant2?.Invoke(CounterMetricDescriptorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,
            global::System.Action<global::Vectara.CounterMetricDescriptorVariant2>? counterMetricDescriptorVariant2 = null,
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
            else if (IsCounterMetricDescriptorVariant2)
            {
                counterMetricDescriptorVariant2?.Invoke(CounterMetricDescriptorVariant2!);
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
                CounterMetricDescriptorVariant2,
                typeof(global::Vectara.CounterMetricDescriptorVariant2),
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
        public bool Equals(CounterMetricDescriptor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricDescriptorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CounterMetricDescriptorVariant2?>.Default.Equals(CounterMetricDescriptorVariant2, other.CounterMetricDescriptorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CounterMetricDescriptor obj1, CounterMetricDescriptor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CounterMetricDescriptor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CounterMetricDescriptor obj1, CounterMetricDescriptor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CounterMetricDescriptor o && Equals(o);
        }
    }
}
