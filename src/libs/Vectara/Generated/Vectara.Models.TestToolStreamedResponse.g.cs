#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when a Lambda tool test is streamed. The stream carries zero or more `heartbeat` events followed by exactly one terminal `result` event; `result` is the end of the stream. A platform failure after the stream has started closes the connection without a `result`.
    /// </summary>
    public readonly partial struct TestToolStreamedResponse : global::System.IEquatable<TestToolStreamedResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolStreamedResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// Emitted periodically while a streamed Lambda tool test is still running.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.TestToolHeartbeatEvent? Heartbeat { get; init; }
#else
        public global::Vectara.TestToolHeartbeatEvent? Heartbeat { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Heartbeat))]
#endif
        public bool IsHeartbeat => Heartbeat != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHeartbeat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.TestToolHeartbeatEvent? value)
        {
            value = Heartbeat;
            return IsHeartbeat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolHeartbeatEvent PickHeartbeat() => IsHeartbeat
            ? Heartbeat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Heartbeat' but the value was {ToString()}.");

        /// <summary>
        /// The terminal event of a streamed Lambda tool test, carrying the same result the non-streaming response returns.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.TestToolResultEvent? Result { get; init; }
#else
        public global::Vectara.TestToolResultEvent? Result { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Result))]
#endif
        public bool IsResult => Result != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.TestToolResultEvent? value)
        {
            value = Result;
            return IsResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestToolResultEvent PickResult() => IsResult
            ? Result!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Result' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestToolStreamedResponse(global::Vectara.TestToolHeartbeatEvent value) => new TestToolStreamedResponse((global::Vectara.TestToolHeartbeatEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.TestToolHeartbeatEvent?(TestToolStreamedResponse @this) => @this.Heartbeat;

        /// <summary>
        ///
        /// </summary>
        public TestToolStreamedResponse(global::Vectara.TestToolHeartbeatEvent? value)
        {
            Heartbeat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestToolStreamedResponse FromHeartbeat(global::Vectara.TestToolHeartbeatEvent? value) => new TestToolStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestToolStreamedResponse(global::Vectara.TestToolResultEvent value) => new TestToolStreamedResponse((global::Vectara.TestToolResultEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.TestToolResultEvent?(TestToolStreamedResponse @this) => @this.Result;

        /// <summary>
        ///
        /// </summary>
        public TestToolStreamedResponse(global::Vectara.TestToolResultEvent? value)
        {
            Result = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestToolStreamedResponse FromResult(global::Vectara.TestToolResultEvent? value) => new TestToolStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public TestToolStreamedResponse(
            global::Vectara.TestToolStreamedResponseDiscriminatorType? type,
            global::Vectara.TestToolHeartbeatEvent? heartbeat,
            global::Vectara.TestToolResultEvent? result
            )
        {
            Type = type;

            Heartbeat = heartbeat;
            Result = result;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Result as object ??
            Heartbeat as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Heartbeat?.ToString() ??
            Result?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsHeartbeat && !IsResult || !IsHeartbeat && IsResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.TestToolHeartbeatEvent, TResult>? heartbeat = null,
            global::System.Func<global::Vectara.TestToolResultEvent, TResult>? result = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHeartbeat && heartbeat != null)
            {
                return heartbeat(Heartbeat!);
            }
            else if (IsResult && result != null)
            {
                return result(Result!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.TestToolHeartbeatEvent>? heartbeat = null,

            global::System.Action<global::Vectara.TestToolResultEvent>? result = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHeartbeat)
            {
                heartbeat?.Invoke(Heartbeat!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.TestToolHeartbeatEvent>? heartbeat = null,
            global::System.Action<global::Vectara.TestToolResultEvent>? result = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHeartbeat)
            {
                heartbeat?.Invoke(Heartbeat!);
            }
            else if (IsResult)
            {
                result?.Invoke(Result!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Heartbeat,
                typeof(global::Vectara.TestToolHeartbeatEvent),
                Result,
                typeof(global::Vectara.TestToolResultEvent),
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
        public bool Equals(TestToolStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TestToolHeartbeatEvent?>.Default.Equals(Heartbeat, other.Heartbeat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TestToolResultEvent?>.Default.Equals(Result, other.Result)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestToolStreamedResponse obj1, TestToolStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestToolStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestToolStreamedResponse obj1, TestToolStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestToolStreamedResponse o && Equals(o);
        }
    }
}
