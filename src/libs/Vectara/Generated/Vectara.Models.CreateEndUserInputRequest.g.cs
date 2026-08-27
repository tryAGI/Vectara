#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A request to create input for a session as an end user.
    /// </summary>
    public readonly partial struct CreateEndUserInputRequest : global::System.IEquatable<CreateEndUserInputRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// A message from the end user, with optional file uploads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateEndUserInputMessageRequest? InputMessage { get; init; }
#else
        public global::Vectara.CreateEndUserInputMessageRequest? InputMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateEndUserInputMessageRequest? value)
        {
            value = InputMessage;
            return IsInputMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequest PickInputMessage() => IsInputMessage
            ? InputMessage!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputMessage' but the value was {ToString()}.");

        /// <summary>
        /// Cancels the caller's own current agent turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateEndUserInterruptRequest? Interrupt { get; init; }
#else
        public global::Vectara.CreateEndUserInterruptRequest? Interrupt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Interrupt))]
#endif
        public bool IsInterrupt => Interrupt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInterrupt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateEndUserInterruptRequest? value)
        {
            value = Interrupt;
            return IsInterrupt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequest PickInterrupt() => IsInterrupt
            ? Interrupt!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Interrupt' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEndUserInputRequest(global::Vectara.CreateEndUserInputMessageRequest value) => new CreateEndUserInputRequest((global::Vectara.CreateEndUserInputMessageRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserInputMessageRequest?(CreateEndUserInputRequest @this) => @this.InputMessage;

        /// <summary>
        ///
        /// </summary>
        public CreateEndUserInputRequest(global::Vectara.CreateEndUserInputMessageRequest? value)
        {
            InputMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEndUserInputRequest FromInputMessage(global::Vectara.CreateEndUserInputMessageRequest? value) => new CreateEndUserInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEndUserInputRequest(global::Vectara.CreateEndUserInterruptRequest value) => new CreateEndUserInputRequest((global::Vectara.CreateEndUserInterruptRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserInterruptRequest?(CreateEndUserInputRequest @this) => @this.Interrupt;

        /// <summary>
        ///
        /// </summary>
        public CreateEndUserInputRequest(global::Vectara.CreateEndUserInterruptRequest? value)
        {
            Interrupt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEndUserInputRequest FromInterrupt(global::Vectara.CreateEndUserInterruptRequest? value) => new CreateEndUserInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateEndUserInputRequest(
            global::Vectara.CreateEndUserInputRequestDiscriminatorType? type,
            global::Vectara.CreateEndUserInputMessageRequest? inputMessage,
            global::Vectara.CreateEndUserInterruptRequest? interrupt
            )
        {
            Type = type;

            InputMessage = inputMessage;
            Interrupt = interrupt;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Interrupt as object ??
            InputMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            Interrupt?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsInterrupt || !IsInputMessage && IsInterrupt;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateEndUserInputMessageRequest?, TResult>? inputMessage = null,
            global::System.Func<global::Vectara.CreateEndUserInterruptRequest?, TResult>? interrupt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage && inputMessage != null)
            {
                return inputMessage(InputMessage!);
            }
            else if (IsInterrupt && interrupt != null)
            {
                return interrupt(Interrupt!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateEndUserInputMessageRequest?>? inputMessage = null,

            global::System.Action<global::Vectara.CreateEndUserInterruptRequest?>? interrupt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsInterrupt)
            {
                interrupt?.Invoke(Interrupt!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateEndUserInputMessageRequest?>? inputMessage = null,
            global::System.Action<global::Vectara.CreateEndUserInterruptRequest?>? interrupt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputMessage)
            {
                inputMessage?.Invoke(InputMessage!);
            }
            else if (IsInterrupt)
            {
                interrupt?.Invoke(Interrupt!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessage,
                typeof(global::Vectara.CreateEndUserInputMessageRequest),
                Interrupt,
                typeof(global::Vectara.CreateEndUserInterruptRequest),
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
        public bool Equals(CreateEndUserInputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserInputMessageRequest?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserInterruptRequest?>.Default.Equals(Interrupt, other.Interrupt)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateEndUserInputRequest obj1, CreateEndUserInputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEndUserInputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateEndUserInputRequest obj1, CreateEndUserInputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEndUserInputRequest o && Equals(o);
        }
    }
}
