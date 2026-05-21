#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The pipeline run started executing.
    /// </summary>
    public readonly partial struct RunStartedEvent : global::System.IEquatable<RunStartedEvent>
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
        public global::Vectara.RunStartedEventVariant2? RunStartedEventVariant2 { get; init; }
#else
        public global::Vectara.RunStartedEventVariant2? RunStartedEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStartedEventVariant2))]
#endif
        public bool IsRunStartedEventVariant2 => RunStartedEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunStartedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.RunStartedEventVariant2? value)
        {
            value = RunStartedEventVariant2;
            return IsRunStartedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.RunStartedEventVariant2 PickRunStartedEventVariant2() => IsRunStartedEventVariant2
            ? RunStartedEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunStartedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStartedEvent(global::Vectara.PipelineRunEventBase value) => new RunStartedEvent((global::Vectara.PipelineRunEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PipelineRunEventBase?(RunStartedEvent @this) => @this.PipelineBase;

        /// <summary>
        /// 
        /// </summary>
        public RunStartedEvent(global::Vectara.PipelineRunEventBase? value)
        {
            PipelineBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RunStartedEvent FromPipelineBase(global::Vectara.PipelineRunEventBase? value) => new RunStartedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunStartedEvent(global::Vectara.RunStartedEventVariant2 value) => new RunStartedEvent((global::Vectara.RunStartedEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.RunStartedEventVariant2?(RunStartedEvent @this) => @this.RunStartedEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RunStartedEvent(global::Vectara.RunStartedEventVariant2? value)
        {
            RunStartedEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RunStartedEvent FromRunStartedEventVariant2(global::Vectara.RunStartedEventVariant2? value) => new RunStartedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public RunStartedEvent(
            global::Vectara.PipelineRunEventBase? pipelineBase,
            global::Vectara.RunStartedEventVariant2? runStartedEventVariant2
            )
        {
            PipelineBase = pipelineBase;
            RunStartedEventVariant2 = runStartedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunStartedEventVariant2 as object ??
            PipelineBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PipelineBase?.ToString() ??
            RunStartedEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPipelineBase && IsRunStartedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.PipelineRunEventBase, TResult>? pipelineBase = null,
            global::System.Func<global::Vectara.RunStartedEventVariant2, TResult>? runStartedEventVariant2 = null,
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
            else if (IsRunStartedEventVariant2 && runStartedEventVariant2 != null)
            {
                return runStartedEventVariant2(RunStartedEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineBase = null,

            global::System.Action<global::Vectara.RunStartedEventVariant2>? runStartedEventVariant2 = null,
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
            else if (IsRunStartedEventVariant2)
            {
                runStartedEventVariant2?.Invoke(RunStartedEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineBase = null,
            global::System.Action<global::Vectara.RunStartedEventVariant2>? runStartedEventVariant2 = null,
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
            else if (IsRunStartedEventVariant2)
            {
                runStartedEventVariant2?.Invoke(RunStartedEventVariant2!);
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
                RunStartedEventVariant2,
                typeof(global::Vectara.RunStartedEventVariant2),
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
        public bool Equals(RunStartedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PipelineRunEventBase?>.Default.Equals(PipelineBase, other.PipelineBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.RunStartedEventVariant2?>.Default.Equals(RunStartedEventVariant2, other.RunStartedEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunStartedEvent obj1, RunStartedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStartedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunStartedEvent obj1, RunStartedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStartedEvent o && Equals(o);
        }
    }
}
