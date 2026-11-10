#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Once the step's calls finish, the session transitions to the named step instead of evaluating next_steps, and that step runs in the same turn. The transition's content tells the LLM which call failed and why. Naming the current step enters it again, so all of its calls run again. Each transition counts toward the limit on step transitions per turn.
    /// </summary>
    public readonly partial struct StepToolCallNextStep : global::System.IEquatable<StepToolCallNextStep>
    {
        /// <summary>
        /// Properties shared by every kind of step tool call failure handling.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepToolCallOnFailureBase? OnFailureBase { get; init; }
#else
        public global::Vectara.StepToolCallOnFailureBase? OnFailureBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OnFailureBase))]
#endif
        public bool IsOnFailureBase => OnFailureBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOnFailureBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepToolCallOnFailureBase? value)
        {
            value = OnFailureBase;
            return IsOnFailureBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallOnFailureBase PickOnFailureBase() => OnFailureBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OnFailureBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepToolCallNextStepVariant2? StepToolCallNextStepVariant2 { get; init; }
#else
        public global::Vectara.StepToolCallNextStepVariant2? StepToolCallNextStepVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepToolCallNextStepVariant2))]
#endif
        public bool IsStepToolCallNextStepVariant2 => StepToolCallNextStepVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepToolCallNextStepVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepToolCallNextStepVariant2? value)
        {
            value = StepToolCallNextStepVariant2;
            return IsStepToolCallNextStepVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallNextStepVariant2 PickStepToolCallNextStepVariant2() => StepToolCallNextStepVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepToolCallNextStepVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallNextStep(global::Vectara.StepToolCallOnFailureBase value) => new StepToolCallNextStep((global::Vectara.StepToolCallOnFailureBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallOnFailureBase?(StepToolCallNextStep @this) => @this.OnFailureBase;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallNextStep(global::Vectara.StepToolCallOnFailureBase? value)
        {
            OnFailureBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallNextStep FromOnFailureBase(global::Vectara.StepToolCallOnFailureBase? value) => new StepToolCallNextStep(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallNextStep(global::Vectara.StepToolCallNextStepVariant2 value) => new StepToolCallNextStep((global::Vectara.StepToolCallNextStepVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallNextStepVariant2?(StepToolCallNextStep @this) => @this.StepToolCallNextStepVariant2;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallNextStep(global::Vectara.StepToolCallNextStepVariant2? value)
        {
            StepToolCallNextStepVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallNextStep FromStepToolCallNextStepVariant2(global::Vectara.StepToolCallNextStepVariant2? value) => new StepToolCallNextStep(value);

        /// <summary>
        ///
        /// </summary>
        public StepToolCallNextStep(
            global::Vectara.StepToolCallOnFailureBase? onFailureBase,
            global::Vectara.StepToolCallNextStepVariant2? stepToolCallNextStepVariant2
            )
        {
            OnFailureBase = onFailureBase;
            StepToolCallNextStepVariant2 = stepToolCallNextStepVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StepToolCallNextStepVariant2 as object ??
            OnFailureBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OnFailureBase?.ToString() ??
            StepToolCallNextStepVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOnFailureBase && IsStepToolCallNextStepVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.StepToolCallOnFailureBase, TResult>? onFailureBase = null,
            global::System.Func<global::Vectara.StepToolCallNextStepVariant2, TResult>? stepToolCallNextStepVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OnFailureBase is { } __value0 && onFailureBase != null)
            {
                return onFailureBase(__value0);
            }
            else if (StepToolCallNextStepVariant2 is { } __value1 && stepToolCallNextStepVariant2 != null)
            {
                return stepToolCallNextStepVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.StepToolCallOnFailureBase>? onFailureBase = null,

            global::System.Action<global::Vectara.StepToolCallNextStepVariant2>? stepToolCallNextStepVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OnFailureBase is { } __value0)
            {
                onFailureBase?.Invoke(__value0);
            }
            else if (StepToolCallNextStepVariant2 is { } __value1)
            {
                stepToolCallNextStepVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.StepToolCallOnFailureBase>? onFailureBase = null,
            global::System.Action<global::Vectara.StepToolCallNextStepVariant2>? stepToolCallNextStepVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OnFailureBase is { } __value0)
            {
                onFailureBase?.Invoke(__value0);
            }
            else if (StepToolCallNextStepVariant2 is { } __value1)
            {
                stepToolCallNextStepVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OnFailureBase,
                typeof(global::Vectara.StepToolCallOnFailureBase),
                StepToolCallNextStepVariant2,
                typeof(global::Vectara.StepToolCallNextStepVariant2),
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
        public bool Equals(StepToolCallNextStep other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallOnFailureBase?>.Default.Equals(OnFailureBase, other.OnFailureBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallNextStepVariant2?>.Default.Equals(StepToolCallNextStepVariant2, other.StepToolCallNextStepVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepToolCallNextStep obj1, StepToolCallNextStep obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepToolCallNextStep>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepToolCallNextStep obj1, StepToolCallNextStep obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepToolCallNextStep o && Equals(o);
        }
    }
}
