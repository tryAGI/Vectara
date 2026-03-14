#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A request to create input for an agent session.
    /// </summary>
    public readonly partial struct CreateInputRequest : global::System.IEquatable<CreateInputRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateInputRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// A user input message with text or other content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateInputMessageRequest? InputMessage { get; init; }
#else
        public global::Vectara.CreateInputMessageRequest? InputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessage))]
#endif
        public bool IsInputMessage => InputMessage != null;

        /// <summary>
        /// Cancels the current agent operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateInterruptRequest? Interrupt { get; init; }
#else
        public global::Vectara.CreateInterruptRequest? Interrupt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Interrupt))]
#endif
        public bool IsInterrupt => Interrupt != null;

        /// <summary>
        /// Requests compaction of the session history. Can be sent while the session is processing<br/>
        /// (queued as a follow-up) or when idle.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateCompactRequest? Compact { get; init; }
#else
        public global::Vectara.CreateCompactRequest? Compact { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compact))]
#endif
        public bool IsCompact => Compact != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputRequest(global::Vectara.CreateInputMessageRequest value) => new CreateInputRequest((global::Vectara.CreateInputMessageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateInputMessageRequest?(CreateInputRequest @this) => @this.InputMessage;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(global::Vectara.CreateInputMessageRequest? value)
        {
            InputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputRequest(global::Vectara.CreateInterruptRequest value) => new CreateInputRequest((global::Vectara.CreateInterruptRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateInterruptRequest?(CreateInputRequest @this) => @this.Interrupt;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(global::Vectara.CreateInterruptRequest? value)
        {
            Interrupt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputRequest(global::Vectara.CreateCompactRequest value) => new CreateInputRequest((global::Vectara.CreateCompactRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateCompactRequest?(CreateInputRequest @this) => @this.Compact;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(global::Vectara.CreateCompactRequest? value)
        {
            Compact = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateInputRequest(
            global::Vectara.CreateInputRequestDiscriminatorType? type,
            global::Vectara.CreateInputMessageRequest? inputMessage,
            global::Vectara.CreateInterruptRequest? interrupt,
            global::Vectara.CreateCompactRequest? compact
            )
        {
            Type = type;

            InputMessage = inputMessage;
            Interrupt = interrupt;
            Compact = compact;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Compact as object ??
            Interrupt as object ??
            InputMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputMessage?.ToString() ??
            Interrupt?.ToString() ??
            Compact?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputMessage && !IsInterrupt && !IsCompact || !IsInputMessage && IsInterrupt && !IsCompact || !IsInputMessage && !IsInterrupt && IsCompact;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateInputMessageRequest?, TResult>? inputMessage = null,
            global::System.Func<global::Vectara.CreateInterruptRequest?, TResult>? interrupt = null,
            global::System.Func<global::Vectara.CreateCompactRequest?, TResult>? compact = null,
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
            else if (IsCompact && compact != null)
            {
                return compact(Compact!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateInputMessageRequest?>? inputMessage = null,
            global::System.Action<global::Vectara.CreateInterruptRequest?>? interrupt = null,
            global::System.Action<global::Vectara.CreateCompactRequest?>? compact = null,
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
            else if (IsCompact)
            {
                compact?.Invoke(Compact!);
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
                typeof(global::Vectara.CreateInputMessageRequest),
                Interrupt,
                typeof(global::Vectara.CreateInterruptRequest),
                Compact,
                typeof(global::Vectara.CreateCompactRequest),
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
        public bool Equals(CreateInputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateInputMessageRequest?>.Default.Equals(InputMessage, other.InputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateInterruptRequest?>.Default.Equals(Interrupt, other.Interrupt) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateCompactRequest?>.Default.Equals(Compact, other.Compact) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateInputRequest obj1, CreateInputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateInputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateInputRequest obj1, CreateInputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateInputRequest o && Equals(o);
        }
    }
}
