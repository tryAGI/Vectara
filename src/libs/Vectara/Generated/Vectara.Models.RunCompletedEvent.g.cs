#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The pipeline run reached a terminal state. `status` distinguishes a successful completion<br/>
    /// from a failure, cancellation, or timeout.
    /// </summary>
    public readonly partial struct RunCompletedEvent : global::System.IEquatable<RunCompletedEvent>
    {
        /// <summary>
        /// Common fields shared by all pipeline run events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.PipelineRunEventBase? PipelineBase { get; init; }
#else
        public global::Vectara.PipelineRunEventBase? PipelineBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PipelineBase))]
#endif
        public bool IsPipelineBase => PipelineBase != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPipelineBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.PipelineRunEventBase? value)
        {
            value = PipelineBase;
            return IsPipelineBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.PipelineRunEventBase PickPipelineBase() => IsPipelineBase
            ? PipelineBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PipelineBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.RunCompletedEventVariant2? RunCompletedEventVariant2 { get; init; }
#else
        public global::Vectara.RunCompletedEventVariant2? RunCompletedEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunCompletedEventVariant2))]
#endif
        public bool IsRunCompletedEventVariant2 => RunCompletedEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunCompletedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.RunCompletedEventVariant2? value)
        {
            value = RunCompletedEventVariant2;
            return IsRunCompletedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RunCompletedEventVariant2 PickRunCompletedEventVariant2() => IsRunCompletedEventVariant2
            ? RunCompletedEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunCompletedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunCompletedEvent(global::Vectara.PipelineRunEventBase value) => new RunCompletedEvent((global::Vectara.PipelineRunEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PipelineRunEventBase?(RunCompletedEvent @this) => @this.PipelineBase;

        /// <summary>
        /// 
        /// </summary>
        public RunCompletedEvent(global::Vectara.PipelineRunEventBase? value)
        {
            PipelineBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RunCompletedEvent FromPipelineBase(global::Vectara.PipelineRunEventBase? value) => new RunCompletedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunCompletedEvent(global::Vectara.RunCompletedEventVariant2 value) => new RunCompletedEvent((global::Vectara.RunCompletedEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RunCompletedEventVariant2?(RunCompletedEvent @this) => @this.RunCompletedEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RunCompletedEvent(global::Vectara.RunCompletedEventVariant2? value)
        {
            RunCompletedEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RunCompletedEvent FromRunCompletedEventVariant2(global::Vectara.RunCompletedEventVariant2? value) => new RunCompletedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public RunCompletedEvent(
            global::Vectara.PipelineRunEventBase? pipelineBase,
            global::Vectara.RunCompletedEventVariant2? runCompletedEventVariant2
            )
        {
            PipelineBase = pipelineBase;
            RunCompletedEventVariant2 = runCompletedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunCompletedEventVariant2 as object ??
            PipelineBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PipelineBase?.ToString() ??
            RunCompletedEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPipelineBase && IsRunCompletedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.PipelineRunEventBase, TResult>? pipelineBase = null,
            global::System.Func<global::Vectara.RunCompletedEventVariant2, TResult>? runCompletedEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPipelineBase && pipelineBase != null)
            {
                return pipelineBase(PipelineBase!);
            }
            else if (IsRunCompletedEventVariant2 && runCompletedEventVariant2 != null)
            {
                return runCompletedEventVariant2(RunCompletedEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineBase = null,

            global::System.Action<global::Vectara.RunCompletedEventVariant2>? runCompletedEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPipelineBase)
            {
                pipelineBase?.Invoke(PipelineBase!);
            }
            else if (IsRunCompletedEventVariant2)
            {
                runCompletedEventVariant2?.Invoke(RunCompletedEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineBase = null,
            global::System.Action<global::Vectara.RunCompletedEventVariant2>? runCompletedEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPipelineBase)
            {
                pipelineBase?.Invoke(PipelineBase!);
            }
            else if (IsRunCompletedEventVariant2)
            {
                runCompletedEventVariant2?.Invoke(RunCompletedEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PipelineBase,
                typeof(global::Vectara.PipelineRunEventBase),
                RunCompletedEventVariant2,
                typeof(global::Vectara.RunCompletedEventVariant2),
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
        public bool Equals(RunCompletedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PipelineRunEventBase?>.Default.Equals(PipelineBase, other.PipelineBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RunCompletedEventVariant2?>.Default.Equals(RunCompletedEventVariant2, other.RunCompletedEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunCompletedEvent obj1, RunCompletedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunCompletedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunCompletedEvent obj1, RunCompletedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunCompletedEvent o && Equals(o);
        }
    }
}
