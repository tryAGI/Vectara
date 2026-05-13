#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The pipeline's persisted watermark moved forward at the end of the run.
    /// </summary>
    public readonly partial struct WatermarkAdvancedEvent : global::System.IEquatable<WatermarkAdvancedEvent>
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
        public global::Vectara.WatermarkAdvancedEventVariant2? WatermarkAdvancedEventVariant2 { get; init; }
#else
        public global::Vectara.WatermarkAdvancedEventVariant2? WatermarkAdvancedEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WatermarkAdvancedEventVariant2))]
#endif
        public bool IsWatermarkAdvancedEventVariant2 => WatermarkAdvancedEventVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWatermarkAdvancedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WatermarkAdvancedEventVariant2? value)
        {
            value = WatermarkAdvancedEventVariant2;
            return IsWatermarkAdvancedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.WatermarkAdvancedEventVariant2 PickWatermarkAdvancedEventVariant2() => IsWatermarkAdvancedEventVariant2
            ? WatermarkAdvancedEventVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WatermarkAdvancedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WatermarkAdvancedEvent(global::Vectara.PipelineRunEventBase value) => new WatermarkAdvancedEvent((global::Vectara.PipelineRunEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.PipelineRunEventBase?(WatermarkAdvancedEvent @this) => @this.PipelineRunBase;

        /// <summary>
        /// 
        /// </summary>
        public WatermarkAdvancedEvent(global::Vectara.PipelineRunEventBase? value)
        {
            PipelineRunBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WatermarkAdvancedEvent FromPipelineRunBase(global::Vectara.PipelineRunEventBase? value) => new WatermarkAdvancedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WatermarkAdvancedEvent(global::Vectara.WatermarkAdvancedEventVariant2 value) => new WatermarkAdvancedEvent((global::Vectara.WatermarkAdvancedEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.WatermarkAdvancedEventVariant2?(WatermarkAdvancedEvent @this) => @this.WatermarkAdvancedEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WatermarkAdvancedEvent(global::Vectara.WatermarkAdvancedEventVariant2? value)
        {
            WatermarkAdvancedEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WatermarkAdvancedEvent FromWatermarkAdvancedEventVariant2(global::Vectara.WatermarkAdvancedEventVariant2? value) => new WatermarkAdvancedEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public WatermarkAdvancedEvent(
            global::Vectara.PipelineRunEventBase? pipelineRunBase,
            global::Vectara.WatermarkAdvancedEventVariant2? watermarkAdvancedEventVariant2
            )
        {
            PipelineRunBase = pipelineRunBase;
            WatermarkAdvancedEventVariant2 = watermarkAdvancedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WatermarkAdvancedEventVariant2 as object ??
            PipelineRunBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PipelineRunBase?.ToString() ??
            WatermarkAdvancedEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPipelineRunBase && IsWatermarkAdvancedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.PipelineRunEventBase, TResult>? pipelineRunBase = null,
            global::System.Func<global::Vectara.WatermarkAdvancedEventVariant2, TResult>? watermarkAdvancedEventVariant2 = null,
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
            else if (IsWatermarkAdvancedEventVariant2 && watermarkAdvancedEventVariant2 != null)
            {
                return watermarkAdvancedEventVariant2(WatermarkAdvancedEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineRunBase = null,

            global::System.Action<global::Vectara.WatermarkAdvancedEventVariant2>? watermarkAdvancedEventVariant2 = null,
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
            else if (IsWatermarkAdvancedEventVariant2)
            {
                watermarkAdvancedEventVariant2?.Invoke(WatermarkAdvancedEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.PipelineRunEventBase>? pipelineRunBase = null,
            global::System.Action<global::Vectara.WatermarkAdvancedEventVariant2>? watermarkAdvancedEventVariant2 = null,
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
            else if (IsWatermarkAdvancedEventVariant2)
            {
                watermarkAdvancedEventVariant2?.Invoke(WatermarkAdvancedEventVariant2!);
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
                WatermarkAdvancedEventVariant2,
                typeof(global::Vectara.WatermarkAdvancedEventVariant2),
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
        public bool Equals(WatermarkAdvancedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.PipelineRunEventBase?>.Default.Equals(PipelineRunBase, other.PipelineRunBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WatermarkAdvancedEventVariant2?>.Default.Equals(WatermarkAdvancedEventVariant2, other.WatermarkAdvancedEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WatermarkAdvancedEvent obj1, WatermarkAdvancedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WatermarkAdvancedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WatermarkAdvancedEvent obj1, WatermarkAdvancedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WatermarkAdvancedEvent o && Equals(o);
        }
    }
}
