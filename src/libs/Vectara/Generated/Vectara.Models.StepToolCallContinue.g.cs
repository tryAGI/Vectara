#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// The step carries on as if the call had succeeded. A later call that references this call's output uses the reference's `$default`, and fails if the reference has none.
    /// </summary>
    public readonly partial struct StepToolCallContinue : global::System.IEquatable<StepToolCallContinue>
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
        public global::Vectara.StepToolCallContinueVariant2? StepToolCallContinueVariant2 { get; init; }
#else
        public global::Vectara.StepToolCallContinueVariant2? StepToolCallContinueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepToolCallContinueVariant2))]
#endif
        public bool IsStepToolCallContinueVariant2 => StepToolCallContinueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepToolCallContinueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.StepToolCallContinueVariant2? value)
        {
            value = StepToolCallContinueVariant2;
            return IsStepToolCallContinueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.StepToolCallContinueVariant2 PickStepToolCallContinueVariant2() => StepToolCallContinueVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepToolCallContinueVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallContinue(global::Vectara.StepToolCallOnFailureBase value) => new StepToolCallContinue((global::Vectara.StepToolCallOnFailureBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallOnFailureBase?(StepToolCallContinue @this) => @this.OnFailureBase;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallContinue(global::Vectara.StepToolCallOnFailureBase? value)
        {
            OnFailureBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallContinue FromOnFailureBase(global::Vectara.StepToolCallOnFailureBase? value) => new StepToolCallContinue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepToolCallContinue(global::Vectara.StepToolCallContinueVariant2 value) => new StepToolCallContinue((global::Vectara.StepToolCallContinueVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.StepToolCallContinueVariant2?(StepToolCallContinue @this) => @this.StepToolCallContinueVariant2;

        /// <summary>
        ///
        /// </summary>
        public StepToolCallContinue(global::Vectara.StepToolCallContinueVariant2? value)
        {
            StepToolCallContinueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepToolCallContinue FromStepToolCallContinueVariant2(global::Vectara.StepToolCallContinueVariant2? value) => new StepToolCallContinue(value);

        /// <summary>
        ///
        /// </summary>
        public StepToolCallContinue(
            global::Vectara.StepToolCallOnFailureBase? onFailureBase,
            global::Vectara.StepToolCallContinueVariant2? stepToolCallContinueVariant2
            )
        {
            OnFailureBase = onFailureBase;
            StepToolCallContinueVariant2 = stepToolCallContinueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StepToolCallContinueVariant2 as object ??
            OnFailureBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OnFailureBase?.ToString() ??
            StepToolCallContinueVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOnFailureBase && IsStepToolCallContinueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.StepToolCallOnFailureBase, TResult>? onFailureBase = null,
            global::System.Func<global::Vectara.StepToolCallContinueVariant2, TResult>? stepToolCallContinueVariant2 = null,
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
            else if (StepToolCallContinueVariant2 is { } __value1 && stepToolCallContinueVariant2 != null)
            {
                return stepToolCallContinueVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.StepToolCallOnFailureBase>? onFailureBase = null,

            global::System.Action<global::Vectara.StepToolCallContinueVariant2>? stepToolCallContinueVariant2 = null,
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
            else if (StepToolCallContinueVariant2 is { } __value1)
            {
                stepToolCallContinueVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.StepToolCallOnFailureBase>? onFailureBase = null,
            global::System.Action<global::Vectara.StepToolCallContinueVariant2>? stepToolCallContinueVariant2 = null,
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
            else if (StepToolCallContinueVariant2 is { } __value1)
            {
                stepToolCallContinueVariant2?.Invoke(__value1);
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
                StepToolCallContinueVariant2,
                typeof(global::Vectara.StepToolCallContinueVariant2),
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
        public bool Equals(StepToolCallContinue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallOnFailureBase?>.Default.Equals(OnFailureBase, other.OnFailureBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StepToolCallContinueVariant2?>.Default.Equals(StepToolCallContinueVariant2, other.StepToolCallContinueVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepToolCallContinue obj1, StepToolCallContinue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepToolCallContinue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepToolCallContinue obj1, StepToolCallContinue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepToolCallContinue o && Equals(o);
        }
    }
}
