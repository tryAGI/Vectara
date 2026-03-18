#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Defines when the pipeline runs.
    /// </summary>
    public readonly partial struct PipelineTrigger : global::System.IEquatable<PipelineTrigger>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PipelineTriggerDiscriminatorType? Type { get; }

        /// <summary>
        /// Run the pipeline on a cron schedule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CronTriggerConfiguration? Cron { get; init; }
#else
        public global::Vectara.CronTriggerConfiguration? Cron { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cron))]
#endif
        public bool IsCron => Cron != null;

        /// <summary>
        /// Run the pipeline at a fixed interval.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.IntervalTriggerConfiguration? Interval { get; init; }
#else
        public global::Vectara.IntervalTriggerConfiguration? Interval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Interval))]
#endif
        public bool IsInterval => Interval != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineTrigger(global::Vectara.CronTriggerConfiguration value) => new PipelineTrigger((global::Vectara.CronTriggerConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CronTriggerConfiguration?(PipelineTrigger @this) => @this.Cron;

        /// <summary>
        /// 
        /// </summary>
        public PipelineTrigger(global::Vectara.CronTriggerConfiguration? value)
        {
            Cron = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineTrigger(global::Vectara.IntervalTriggerConfiguration value) => new PipelineTrigger((global::Vectara.IntervalTriggerConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.IntervalTriggerConfiguration?(PipelineTrigger @this) => @this.Interval;

        /// <summary>
        /// 
        /// </summary>
        public PipelineTrigger(global::Vectara.IntervalTriggerConfiguration? value)
        {
            Interval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PipelineTrigger(
            global::Vectara.PipelineTriggerDiscriminatorType? type,
            global::Vectara.CronTriggerConfiguration? cron,
            global::Vectara.IntervalTriggerConfiguration? interval
            )
        {
            Type = type;

            Cron = cron;
            Interval = interval;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Interval as object ??
            Cron as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Cron?.ToString() ??
            Interval?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCron && !IsInterval || !IsCron && IsInterval;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CronTriggerConfiguration?, TResult>? cron = null,
            global::System.Func<global::Vectara.IntervalTriggerConfiguration?, TResult>? interval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCron && cron != null)
            {
                return cron(Cron!);
            }
            else if (IsInterval && interval != null)
            {
                return interval(Interval!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CronTriggerConfiguration?>? cron = null,
            global::System.Action<global::Vectara.IntervalTriggerConfiguration?>? interval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCron)
            {
                cron?.Invoke(Cron!);
            }
            else if (IsInterval)
            {
                interval?.Invoke(Interval!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Cron,
                typeof(global::Vectara.CronTriggerConfiguration),
                Interval,
                typeof(global::Vectara.IntervalTriggerConfiguration),
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
        public bool Equals(PipelineTrigger other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CronTriggerConfiguration?>.Default.Equals(Cron, other.Cron) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.IntervalTriggerConfiguration?>.Default.Equals(Interval, other.Interval) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PipelineTrigger obj1, PipelineTrigger obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PipelineTrigger>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PipelineTrigger obj1, PipelineTrigger obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PipelineTrigger o && Equals(o);
        }
    }
}
