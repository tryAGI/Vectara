#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// What a failure of a step's tool call does. When several of a step's calls fail, the first failure recorded whose handling is not `continue` decides. New values of `type` may be added; clients should ignore values they do not recognize.
    /// </summary>
    public readonly partial struct StepToolCallOnFailure : global::System.IEquatable<StepToolCallOnFailure>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallOnFailureDiscriminatorType? Type { get; }

        /// <summary>
        /// Once the step's calls finish, the failure ends the turn with an `error` event, and the step's next_steps are not evaluated. The session stays at the step, and its next input does not run the step's calls again.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepToolCallEndTurn? EndTurn { get; init; }
#else
        public global::Vectara.StepToolCallEndTurn? EndTurn { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndTurn))]
#endif
        public bool IsEndTurn => EndTurn != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEndTurn(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepToolCallEndTurn? value)
        {
            value = EndTurn;
            return IsEndTurn;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallEndTurn PickEndTurn() => EndTurn is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndTurn' but the value was {ToString()}.");

        /// <summary>
        /// The step carries on as if the call had succeeded. A later call that references this call's output uses the reference's `$default`, and fails if the reference has none.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepToolCallContinue? Continue { get; init; }
#else
        public global::Vectara.StepToolCallContinue? Continue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Continue))]
#endif
        public bool IsContinue => Continue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContinue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepToolCallContinue? value)
        {
            value = Continue;
            return IsContinue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallContinue PickContinue() => Continue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Continue' but the value was {ToString()}.");

        /// <summary>
        /// Once the step's calls finish, the session transitions to the named step instead of evaluating next_steps, and that step runs in the same turn. The transition's content tells the LLM which call failed and why. Naming the current step enters it again, so all of its calls run again. Each transition counts toward the limit on step transitions per turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StepToolCallNextStep? NextStep { get; init; }
#else
        public global::Vectara.StepToolCallNextStep? NextStep { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NextStep))]
#endif
        public bool IsNextStep => NextStep != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNextStep(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepToolCallNextStep? value)
        {
            value = NextStep;
            return IsNextStep;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallNextStep PickNextStep() => NextStep is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NextStep' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallOnFailure(global::Vectara.StepToolCallEndTurn value) => new StepToolCallOnFailure((global::Vectara.StepToolCallEndTurn?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallEndTurn?(StepToolCallOnFailure @this) => @this.EndTurn;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallOnFailure(global::Vectara.StepToolCallEndTurn? value)
        {
            EndTurn = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallOnFailure FromEndTurn(global::Vectara.StepToolCallEndTurn? value) => new StepToolCallOnFailure(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallOnFailure(global::Vectara.StepToolCallContinue value) => new StepToolCallOnFailure((global::Vectara.StepToolCallContinue?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallContinue?(StepToolCallOnFailure @this) => @this.Continue;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallOnFailure(global::Vectara.StepToolCallContinue? value)
        {
            Continue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallOnFailure FromContinue(global::Vectara.StepToolCallContinue? value) => new StepToolCallOnFailure(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallOnFailure(global::Vectara.StepToolCallNextStep value) => new StepToolCallOnFailure((global::Vectara.StepToolCallNextStep?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallNextStep?(StepToolCallOnFailure @this) => @this.NextStep;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallOnFailure(global::Vectara.StepToolCallNextStep? value)
        {
            NextStep = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallOnFailure FromNextStep(global::Vectara.StepToolCallNextStep? value) => new StepToolCallOnFailure(value);

        /// <summary>
        ///
        /// </summary>
        public StepToolCallOnFailure(
            global::Vectara.StepToolCallOnFailureDiscriminatorType? type,
            global::Vectara.StepToolCallEndTurn? endTurn,
            global::Vectara.StepToolCallContinue? @continue,
            global::Vectara.StepToolCallNextStep? nextStep
            )
        {
            Type = type;

            EndTurn = endTurn;
            Continue = @continue;
            NextStep = nextStep;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            NextStep as object ??
            Continue as object ??
            EndTurn as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EndTurn?.ToString() ??
            Continue?.ToString() ??
            NextStep?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEndTurn && !IsContinue && !IsNextStep || !IsEndTurn && IsContinue && !IsNextStep || !IsEndTurn && !IsContinue && IsNextStep;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.StepToolCallEndTurn?, TResult>? endTurn = null,
            global::System.Func<global::Vectara.StepToolCallContinue?, TResult>? @continue = null,
            global::System.Func<global::Vectara.StepToolCallNextStep?, TResult>? nextStep = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EndTurn is { } __value0 && endTurn != null)
            {
                return endTurn(__value0);
            }
            else if (Continue is { } __value1 && @continue != null)
            {
                return @continue(__value1);
            }
            else if (NextStep is { } __value2 && nextStep != null)
            {
                return nextStep(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.StepToolCallEndTurn?>? endTurn = null,

            global::System.Action<global::Vectara.StepToolCallContinue?>? @continue = null,

            global::System.Action<global::Vectara.StepToolCallNextStep?>? nextStep = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EndTurn is { } __value0)
            {
                endTurn?.Invoke(__value0);
            }
            else if (Continue is { } __value1)
            {
                @continue?.Invoke(__value1);
            }
            else if (NextStep is { } __value2)
            {
                nextStep?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.StepToolCallEndTurn?>? endTurn = null,
            global::System.Action<global::Vectara.StepToolCallContinue?>? @continue = null,
            global::System.Action<global::Vectara.StepToolCallNextStep?>? nextStep = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EndTurn is { } __value0)
            {
                endTurn?.Invoke(__value0);
            }
            else if (Continue is { } __value1)
            {
                @continue?.Invoke(__value1);
            }
            else if (NextStep is { } __value2)
            {
                nextStep?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EndTurn,
                typeof(global::Vectara.StepToolCallEndTurn),
                Continue,
                typeof(global::Vectara.StepToolCallContinue),
                NextStep,
                typeof(global::Vectara.StepToolCallNextStep),
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
        public bool Equals(StepToolCallOnFailure other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallEndTurn?>.Default.Equals(EndTurn, other.EndTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallContinue?>.Default.Equals(Continue, other.Continue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallNextStep?>.Default.Equals(NextStep, other.NextStep)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepToolCallOnFailure obj1, StepToolCallOnFailure obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepToolCallOnFailure>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepToolCallOnFailure obj1, StepToolCallOnFailure obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepToolCallOnFailure o && Equals(o);
        }
    }
}
