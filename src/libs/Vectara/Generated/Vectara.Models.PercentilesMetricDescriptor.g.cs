#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Descriptor for a percentiles metric. Carries the ordered list of percentile labels this metric emits.
    /// </summary>
    public readonly partial struct PercentilesMetricDescriptor : global::System.IEquatable<PercentilesMetricDescriptor>
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
        public global::Vectara.PercentilesMetricDescriptorVariant2? PercentilesMetricDescriptorVariant2 { get; init; }
#else
        public global::Vectara.PercentilesMetricDescriptorVariant2? PercentilesMetricDescriptorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PercentilesMetricDescriptorVariant2))]
#endif
        public bool IsPercentilesMetricDescriptorVariant2 => PercentilesMetricDescriptorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPercentilesMetricDescriptorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.PercentilesMetricDescriptorVariant2? value)
        {
            value = PercentilesMetricDescriptorVariant2;
            return IsPercentilesMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PercentilesMetricDescriptorVariant2 PickPercentilesMetricDescriptorVariant2() => IsPercentilesMetricDescriptorVariant2
            ? PercentilesMetricDescriptorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PercentilesMetricDescriptorVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PercentilesMetricDescriptor(global::Vectara.MetricDescriptorBase value) => new PercentilesMetricDescriptor((global::Vectara.MetricDescriptorBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MetricDescriptorBase?(PercentilesMetricDescriptor @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public PercentilesMetricDescriptor(global::Vectara.MetricDescriptorBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PercentilesMetricDescriptor FromBase(global::Vectara.MetricDescriptorBase? value) => new PercentilesMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PercentilesMetricDescriptor(global::Vectara.PercentilesMetricDescriptorVariant2 value) => new PercentilesMetricDescriptor((global::Vectara.PercentilesMetricDescriptorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PercentilesMetricDescriptorVariant2?(PercentilesMetricDescriptor @this) => @this.PercentilesMetricDescriptorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PercentilesMetricDescriptor(global::Vectara.PercentilesMetricDescriptorVariant2? value)
        {
            PercentilesMetricDescriptorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PercentilesMetricDescriptor FromPercentilesMetricDescriptorVariant2(global::Vectara.PercentilesMetricDescriptorVariant2? value) => new PercentilesMetricDescriptor(value);

        /// <summary>
        /// 
        /// </summary>
        public PercentilesMetricDescriptor(
            global::Vectara.MetricDescriptorBase? @base,
            global::Vectara.PercentilesMetricDescriptorVariant2? percentilesMetricDescriptorVariant2
            )
        {
            Base = @base;
            PercentilesMetricDescriptorVariant2 = percentilesMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PercentilesMetricDescriptorVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            PercentilesMetricDescriptorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsPercentilesMetricDescriptorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MetricDescriptorBase, TResult>? @base = null,
            global::System.Func<global::Vectara.PercentilesMetricDescriptorVariant2, TResult>? percentilesMetricDescriptorVariant2 = null,
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
            else if (IsPercentilesMetricDescriptorVariant2 && percentilesMetricDescriptorVariant2 != null)
            {
                return percentilesMetricDescriptorVariant2(PercentilesMetricDescriptorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,

            global::System.Action<global::Vectara.PercentilesMetricDescriptorVariant2>? percentilesMetricDescriptorVariant2 = null,
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
            else if (IsPercentilesMetricDescriptorVariant2)
            {
                percentilesMetricDescriptorVariant2?.Invoke(PercentilesMetricDescriptorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.MetricDescriptorBase>? @base = null,
            global::System.Action<global::Vectara.PercentilesMetricDescriptorVariant2>? percentilesMetricDescriptorVariant2 = null,
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
            else if (IsPercentilesMetricDescriptorVariant2)
            {
                percentilesMetricDescriptorVariant2?.Invoke(PercentilesMetricDescriptorVariant2!);
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
                PercentilesMetricDescriptorVariant2,
                typeof(global::Vectara.PercentilesMetricDescriptorVariant2),
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
        public bool Equals(PercentilesMetricDescriptor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MetricDescriptorBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PercentilesMetricDescriptorVariant2?>.Default.Equals(PercentilesMetricDescriptorVariant2, other.PercentilesMetricDescriptorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PercentilesMetricDescriptor obj1, PercentilesMetricDescriptor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PercentilesMetricDescriptor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PercentilesMetricDescriptor obj1, PercentilesMetricDescriptor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PercentilesMetricDescriptor o && Equals(o);
        }
    }
}
