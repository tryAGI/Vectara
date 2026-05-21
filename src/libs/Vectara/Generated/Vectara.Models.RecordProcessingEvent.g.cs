#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A single source record progressed through a processing lifecycle stage. `status` is `started`<br/>
    /// when processing begins, `completed` when the record was successfully processed (or skipped),<br/>
    /// and `failed` when processing failed. In a normal run, a `failed` record is also written to the<br/>
    /// dead letter queue; in a retry run, the existing dead letter is marked still-failing.
    /// </summary>
    public readonly partial struct RecordProcessingEvent : global::System.IEquatable<RecordProcessingEvent>
    {
        /// <summary>
        /// Common fields shared by all pipeline run events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.PipelineRunEventBase? PipelineRunBase { get; init; }
#else
        public global::Vectara.PipelineRunEventBase? PipelineRunBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PipelineRunBase))]
#endif
        public bool IsPipelineRunBase => PipelineRunBase != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPipelineRunBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.PipelineRunEventBase? value)
        {
            value = PipelineRunBase;
            return IsPipelineRunBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PipelineRunEventBase PickPipelineRunBase() => IsPipelineRunBase
            ? PipelineRunBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PipelineRunBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RecordProcessingEventVariant2? RecordProcessingEventVariant2 { get; init; }
#else
        public global::Vectara.RecordProcessingEventVariant2? RecordProcessingEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecordProcessingEventVariant2))]
#endif
        public bool IsRecordProcessingEventVariant2 => RecordProcessingEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRecordProcessingEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.RecordProcessingEventVariant2? value)
        {
            value = RecordProcessingEventVariant2;
            return IsRecordProcessingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RecordProcessingEventVariant2 PickRecordProcessingEventVariant2() => IsRecordProcessingEventVariant2
            ? RecordProcessingEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RecordProcessingEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordProcessingEvent(global::Vectara.PipelineRunEventBase value) => new RecordProcessingEvent((global::Vectara.PipelineRunEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PipelineRunEventBase?(RecordProcessingEvent @this) => @this.PipelineRunBase;

        /// <summary>
        /// 
        /// </summary>
        public RecordProcessingEvent(global::Vectara.PipelineRunEventBase? value)
        {
            PipelineRunBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecordProcessingEvent FromPipelineRunBase(global::Vectara.PipelineRunEventBase? value) => new RecordProcessingEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordProcessingEvent(global::Vectara.RecordProcessingEventVariant2 value) => new RecordProcessingEvent((global::Vectara.RecordProcessingEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RecordProcessingEventVariant2?(RecordProcessingEvent @this) => @this.RecordProcessingEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RecordProcessingEvent(global::Vectara.RecordProcessingEventVariant2? value)
        {
            RecordProcessingEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RecordProcessingEvent FromRecordProcessingEventVariant2(global::Vectara.RecordProcessingEventVariant2? value) => new RecordProcessingEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public RecordProcessingEvent(
            global::Vectara.PipelineRunEventBase? pipelineRunBase,
            global::Vectara.RecordProcessingEventVariant2? recordProcessingEventVariant2
            )
        {
            PipelineRunBase = pipelineRunBase;
            RecordProcessingEventVariant2 = recordProcessingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RecordProcessingEventVariant2 as object ??
            PipelineRunBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PipelineRunBase?.ToString() ??
            RecordProcessingEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPipelineRunBase && IsRecordProcessingEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.PipelineRunEventBase, TResult>? pipelineRunBase = null,
            global::System.Func<global::Vectara.RecordProcessingEventVariant2, TResult>? recordProcessingEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPipelineRunBase && pipelineRunBase != null)
            {
                return pipelineRunBase(PipelineRunBase!);
            }
            else if (IsRecordProcessingEventVariant2 && recordProcessingEventVariant2 != null)
            {
                return recordProcessingEventVariant2(RecordProcessingEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineRunBase = null,

            global::System.Action<global::Vectara.RecordProcessingEventVariant2>? recordProcessingEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPipelineRunBase)
            {
                pipelineRunBase?.Invoke(PipelineRunBase!);
            }
            else if (IsRecordProcessingEventVariant2)
            {
                recordProcessingEventVariant2?.Invoke(RecordProcessingEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineRunBase = null,
            global::System.Action<global::Vectara.RecordProcessingEventVariant2>? recordProcessingEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPipelineRunBase)
            {
                pipelineRunBase?.Invoke(PipelineRunBase!);
            }
            else if (IsRecordProcessingEventVariant2)
            {
                recordProcessingEventVariant2?.Invoke(RecordProcessingEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PipelineRunBase,
                typeof(global::Vectara.PipelineRunEventBase),
                RecordProcessingEventVariant2,
                typeof(global::Vectara.RecordProcessingEventVariant2),
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
        public bool Equals(RecordProcessingEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PipelineRunEventBase?>.Default.Equals(PipelineRunBase, other.PipelineRunBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RecordProcessingEventVariant2?>.Default.Equals(RecordProcessingEventVariant2, other.RecordProcessingEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecordProcessingEvent obj1, RecordProcessingEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecordProcessingEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecordProcessingEvent obj1, RecordProcessingEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecordProcessingEvent o && Equals(o);
        }
    }
}
