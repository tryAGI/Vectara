#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Once the step's calls finish, the failure ends the turn with an `error` event, and the step's next_steps are not evaluated. The session stays at the step, and its next input does not run the step's calls again.
    /// </summary>
    public readonly partial struct StepToolCallEndTurn : global::System.IEquatable<StepToolCallEndTurn>
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
        public global::Vectara.StepToolCallEndTurnVariant2? StepToolCallEndTurnVariant2 { get; init; }
#else
        public global::Vectara.StepToolCallEndTurnVariant2? StepToolCallEndTurnVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepToolCallEndTurnVariant2))]
#endif
        public bool IsStepToolCallEndTurnVariant2 => StepToolCallEndTurnVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepToolCallEndTurnVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepToolCallEndTurnVariant2? value)
        {
            value = StepToolCallEndTurnVariant2;
            return IsStepToolCallEndTurnVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallEndTurnVariant2 PickStepToolCallEndTurnVariant2() => StepToolCallEndTurnVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepToolCallEndTurnVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallEndTurn(global::Vectara.StepToolCallOnFailureBase value) => new StepToolCallEndTurn((global::Vectara.StepToolCallOnFailureBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallOnFailureBase?(StepToolCallEndTurn @this) => @this.OnFailureBase;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallEndTurn(global::Vectara.StepToolCallOnFailureBase? value)
        {
            OnFailureBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallEndTurn FromOnFailureBase(global::Vectara.StepToolCallOnFailureBase? value) => new StepToolCallEndTurn(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallEndTurn(global::Vectara.StepToolCallEndTurnVariant2 value) => new StepToolCallEndTurn((global::Vectara.StepToolCallEndTurnVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallEndTurnVariant2?(StepToolCallEndTurn @this) => @this.StepToolCallEndTurnVariant2;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallEndTurn(global::Vectara.StepToolCallEndTurnVariant2? value)
        {
            StepToolCallEndTurnVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallEndTurn FromStepToolCallEndTurnVariant2(global::Vectara.StepToolCallEndTurnVariant2? value) => new StepToolCallEndTurn(value);

        /// <summary>
        ///
        /// </summary>
        public StepToolCallEndTurn(
            global::Vectara.StepToolCallOnFailureBase? onFailureBase,
            global::Vectara.StepToolCallEndTurnVariant2? stepToolCallEndTurnVariant2
            )
        {
            OnFailureBase = onFailureBase;
            StepToolCallEndTurnVariant2 = stepToolCallEndTurnVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StepToolCallEndTurnVariant2 as object ??
            OnFailureBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OnFailureBase?.ToString() ??
            StepToolCallEndTurnVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOnFailureBase && IsStepToolCallEndTurnVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.StepToolCallOnFailureBase, TResult>? onFailureBase = null,
            global::System.Func<global::Vectara.StepToolCallEndTurnVariant2, TResult>? stepToolCallEndTurnVariant2 = null,
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
            else if (StepToolCallEndTurnVariant2 is { } __value1 && stepToolCallEndTurnVariant2 != null)
            {
                return stepToolCallEndTurnVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.StepToolCallOnFailureBase>? onFailureBase = null,

            global::System.Action<global::Vectara.StepToolCallEndTurnVariant2>? stepToolCallEndTurnVariant2 = null,
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
            else if (StepToolCallEndTurnVariant2 is { } __value1)
            {
                stepToolCallEndTurnVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.StepToolCallOnFailureBase>? onFailureBase = null,
            global::System.Action<global::Vectara.StepToolCallEndTurnVariant2>? stepToolCallEndTurnVariant2 = null,
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
            else if (StepToolCallEndTurnVariant2 is { } __value1)
            {
                stepToolCallEndTurnVariant2?.Invoke(__value1);
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
                StepToolCallEndTurnVariant2,
                typeof(global::Vectara.StepToolCallEndTurnVariant2),
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
        public bool Equals(StepToolCallEndTurn other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallOnFailureBase?>.Default.Equals(OnFailureBase, other.OnFailureBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallEndTurnVariant2?>.Default.Equals(StepToolCallEndTurnVariant2, other.StepToolCallEndTurnVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepToolCallEndTurn obj1, StepToolCallEndTurn obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepToolCallEndTurn>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepToolCallEndTurn obj1, StepToolCallEndTurn obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepToolCallEndTurn o && Equals(o);
        }
    }
}
