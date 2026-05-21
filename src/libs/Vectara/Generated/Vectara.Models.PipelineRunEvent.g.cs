#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single event in a pipeline run's timeline. The shape of the event is<br/>
    /// determined by `type`.
    /// </summary>
    public readonly partial struct PipelineRunEvent : global::System.IEquatable<PipelineRunEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PipelineRunEventDiscriminatorType? Type { get; }

        /// <summary>
        /// The pipeline run started executing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RunStartedEvent? RunStarted { get; init; }
#else
        public global::Vectara.RunStartedEvent? RunStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStarted))]
#endif
        public bool IsRunStarted => RunStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.RunStartedEvent? value)
        {
            value = RunStarted;
            return IsRunStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RunStartedEvent PickRunStarted() => IsRunStarted
            ? RunStarted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunStarted' but the value was {ToString()}.");

        /// <summary>
        /// The pipeline run reached a terminal state. `status` distinguishes a successful completion<br/>
        /// from a failure, cancellation, or timeout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RunCompletedEvent? RunCompleted { get; init; }
#else
        public global::Vectara.RunCompletedEvent? RunCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunCompleted))]
#endif
        public bool IsRunCompleted => RunCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.RunCompletedEvent? value)
        {
            value = RunCompleted;
            return IsRunCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RunCompletedEvent PickRunCompleted() => IsRunCompleted
            ? RunCompleted!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunCompleted' but the value was {ToString()}.");

        /// <summary>
        /// A single source record progressed through a processing lifecycle stage. `status` is `started`<br/>
        /// when processing begins, `completed` when the record was successfully processed (or skipped),<br/>
        /// and `failed` when processing failed. In a normal run, a `failed` record is also written to the<br/>
        /// dead letter queue; in a retry run, the existing dead letter is marked still-failing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RecordProcessingEvent? RecordProcessing { get; init; }
#else
        public global::Vectara.RecordProcessingEvent? RecordProcessing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecordProcessing))]
#endif
        public bool IsRecordProcessing => RecordProcessing != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRecordProcessing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.RecordProcessingEvent? value)
        {
            value = RecordProcessing;
            return IsRecordProcessing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RecordProcessingEvent PickRecordProcessing() => IsRecordProcessing
            ? RecordProcessing!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RecordProcessing' but the value was {ToString()}.");

        /// <summary>
        /// The pipeline's persisted watermark moved forward at the end of the run.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WatermarkAdvancedEvent? WatermarkAdvanced { get; init; }
#else
        public global::Vectara.WatermarkAdvancedEvent? WatermarkAdvanced { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WatermarkAdvanced))]
#endif
        public bool IsWatermarkAdvanced => WatermarkAdvanced != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWatermarkAdvanced(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WatermarkAdvancedEvent? value)
        {
            value = WatermarkAdvanced;
            return IsWatermarkAdvanced;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WatermarkAdvancedEvent PickWatermarkAdvanced() => IsWatermarkAdvanced
            ? WatermarkAdvanced!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WatermarkAdvanced' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineRunEvent(global::Vectara.RunStartedEvent value) => new PipelineRunEvent((global::Vectara.RunStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RunStartedEvent?(PipelineRunEvent @this) => @this.RunStarted;

        /// <summary>
        /// 
        /// </summary>
        public PipelineRunEvent(global::Vectara.RunStartedEvent? value)
        {
            RunStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PipelineRunEvent FromRunStarted(global::Vectara.RunStartedEvent? value) => new PipelineRunEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineRunEvent(global::Vectara.RunCompletedEvent value) => new PipelineRunEvent((global::Vectara.RunCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RunCompletedEvent?(PipelineRunEvent @this) => @this.RunCompleted;

        /// <summary>
        /// 
        /// </summary>
        public PipelineRunEvent(global::Vectara.RunCompletedEvent? value)
        {
            RunCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PipelineRunEvent FromRunCompleted(global::Vectara.RunCompletedEvent? value) => new PipelineRunEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineRunEvent(global::Vectara.RecordProcessingEvent value) => new PipelineRunEvent((global::Vectara.RecordProcessingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RecordProcessingEvent?(PipelineRunEvent @this) => @this.RecordProcessing;

        /// <summary>
        /// 
        /// </summary>
        public PipelineRunEvent(global::Vectara.RecordProcessingEvent? value)
        {
            RecordProcessing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PipelineRunEvent FromRecordProcessing(global::Vectara.RecordProcessingEvent? value) => new PipelineRunEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PipelineRunEvent(global::Vectara.WatermarkAdvancedEvent value) => new PipelineRunEvent((global::Vectara.WatermarkAdvancedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WatermarkAdvancedEvent?(PipelineRunEvent @this) => @this.WatermarkAdvanced;

        /// <summary>
        /// 
        /// </summary>
        public PipelineRunEvent(global::Vectara.WatermarkAdvancedEvent? value)
        {
            WatermarkAdvanced = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PipelineRunEvent FromWatermarkAdvanced(global::Vectara.WatermarkAdvancedEvent? value) => new PipelineRunEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public PipelineRunEvent(
            global::Vectara.PipelineRunEventDiscriminatorType? type,
            global::Vectara.RunStartedEvent? runStarted,
            global::Vectara.RunCompletedEvent? runCompleted,
            global::Vectara.RecordProcessingEvent? recordProcessing,
            global::Vectara.WatermarkAdvancedEvent? watermarkAdvanced
            )
        {
            Type = type;

            RunStarted = runStarted;
            RunCompleted = runCompleted;
            RecordProcessing = recordProcessing;
            WatermarkAdvanced = watermarkAdvanced;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WatermarkAdvanced as object ??
            RecordProcessing as object ??
            RunCompleted as object ??
            RunStarted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RunStarted?.ToString() ??
            RunCompleted?.ToString() ??
            RecordProcessing?.ToString() ??
            WatermarkAdvanced?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRunStarted && !IsRunCompleted && !IsRecordProcessing && !IsWatermarkAdvanced || !IsRunStarted && IsRunCompleted && !IsRecordProcessing && !IsWatermarkAdvanced || !IsRunStarted && !IsRunCompleted && IsRecordProcessing && !IsWatermarkAdvanced || !IsRunStarted && !IsRunCompleted && !IsRecordProcessing && IsWatermarkAdvanced;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.RunStartedEvent?, TResult>? runStarted = null,
            global::System.Func<global::Vectara.RunCompletedEvent?, TResult>? runCompleted = null,
            global::System.Func<global::Vectara.RecordProcessingEvent?, TResult>? recordProcessing = null,
            global::System.Func<global::Vectara.WatermarkAdvancedEvent?, TResult>? watermarkAdvanced = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStarted && runStarted != null)
            {
                return runStarted(RunStarted!);
            }
            else if (IsRunCompleted && runCompleted != null)
            {
                return runCompleted(RunCompleted!);
            }
            else if (IsRecordProcessing && recordProcessing != null)
            {
                return recordProcessing(RecordProcessing!);
            }
            else if (IsWatermarkAdvanced && watermarkAdvanced != null)
            {
                return watermarkAdvanced(WatermarkAdvanced!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.RunStartedEvent?>? runStarted = null,

            global::System.Action<global::Vectara.RunCompletedEvent?>? runCompleted = null,

            global::System.Action<global::Vectara.RecordProcessingEvent?>? recordProcessing = null,

            global::System.Action<global::Vectara.WatermarkAdvancedEvent?>? watermarkAdvanced = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStarted)
            {
                runStarted?.Invoke(RunStarted!);
            }
            else if (IsRunCompleted)
            {
                runCompleted?.Invoke(RunCompleted!);
            }
            else if (IsRecordProcessing)
            {
                recordProcessing?.Invoke(RecordProcessing!);
            }
            else if (IsWatermarkAdvanced)
            {
                watermarkAdvanced?.Invoke(WatermarkAdvanced!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.RunStartedEvent?>? runStarted = null,
            global::System.Action<global::Vectara.RunCompletedEvent?>? runCompleted = null,
            global::System.Action<global::Vectara.RecordProcessingEvent?>? recordProcessing = null,
            global::System.Action<global::Vectara.WatermarkAdvancedEvent?>? watermarkAdvanced = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRunStarted)
            {
                runStarted?.Invoke(RunStarted!);
            }
            else if (IsRunCompleted)
            {
                runCompleted?.Invoke(RunCompleted!);
            }
            else if (IsRecordProcessing)
            {
                recordProcessing?.Invoke(RecordProcessing!);
            }
            else if (IsWatermarkAdvanced)
            {
                watermarkAdvanced?.Invoke(WatermarkAdvanced!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStarted,
                typeof(global::Vectara.RunStartedEvent),
                RunCompleted,
                typeof(global::Vectara.RunCompletedEvent),
                RecordProcessing,
                typeof(global::Vectara.RecordProcessingEvent),
                WatermarkAdvanced,
                typeof(global::Vectara.WatermarkAdvancedEvent),
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
        public bool Equals(PipelineRunEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RunStartedEvent?>.Default.Equals(RunStarted, other.RunStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RunCompletedEvent?>.Default.Equals(RunCompleted, other.RunCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RecordProcessingEvent?>.Default.Equals(RecordProcessing, other.RecordProcessing) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WatermarkAdvancedEvent?>.Default.Equals(WatermarkAdvanced, other.WatermarkAdvanced) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PipelineRunEvent obj1, PipelineRunEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PipelineRunEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PipelineRunEvent obj1, PipelineRunEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PipelineRunEvent o && Equals(o);
        }
    }
}
