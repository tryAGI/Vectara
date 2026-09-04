#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An individual event sent with Server-sent Events (SSE) when a test of a Lambda tool that has not been created yet is streamed. The stream carries zero or more `heartbeat` events followed by exactly one terminal `result` event; `result` is the end of the stream. A platform failure after the stream has started closes the connection without a `result`.
    /// </summary>
    public readonly partial struct TestLambdaToolStreamedResponse : global::System.IEquatable<TestLambdaToolStreamedResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolStreamedResponseDiscriminatorType? Type { get; }

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
        /// The terminal event of a streamed test of a Lambda tool that has not been created yet, carrying the same result the non-streaming response returns.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.TestLambdaToolResultEvent? Result { get; init; }
#else
        public global::Vectara.TestLambdaToolResultEvent? Result { get; }
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
            out global::Vectara.TestLambdaToolResultEvent? value)
        {
            value = Result;
            return IsResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.TestLambdaToolResultEvent PickResult() => IsResult
            ? Result!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Result' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestLambdaToolStreamedResponse(global::Vectara.TestToolHeartbeatEvent value) => new TestLambdaToolStreamedResponse((global::Vectara.TestToolHeartbeatEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.TestToolHeartbeatEvent?(TestLambdaToolStreamedResponse @this) => @this.Heartbeat;

        /// <summary>
        ///
        /// </summary>
        public TestLambdaToolStreamedResponse(global::Vectara.TestToolHeartbeatEvent? value)
        {
            Heartbeat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestLambdaToolStreamedResponse FromHeartbeat(global::Vectara.TestToolHeartbeatEvent? value) => new TestLambdaToolStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TestLambdaToolStreamedResponse(global::Vectara.TestLambdaToolResultEvent value) => new TestLambdaToolStreamedResponse((global::Vectara.TestLambdaToolResultEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.TestLambdaToolResultEvent?(TestLambdaToolStreamedResponse @this) => @this.Result;

        /// <summary>
        ///
        /// </summary>
        public TestLambdaToolStreamedResponse(global::Vectara.TestLambdaToolResultEvent? value)
        {
            Result = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TestLambdaToolStreamedResponse FromResult(global::Vectara.TestLambdaToolResultEvent? value) => new TestLambdaToolStreamedResponse(value);

        /// <summary>
        ///
        /// </summary>
        public TestLambdaToolStreamedResponse(
            global::Vectara.TestLambdaToolStreamedResponseDiscriminatorType? type,
            global::Vectara.TestToolHeartbeatEvent? heartbeat,
            global::Vectara.TestLambdaToolResultEvent? result
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
            global::System.Func<global::Vectara.TestLambdaToolResultEvent, TResult>? result = null,
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

            global::System.Action<global::Vectara.TestLambdaToolResultEvent>? result = null,
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
            global::System.Action<global::Vectara.TestLambdaToolResultEvent>? result = null,
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
                typeof(global::Vectara.TestLambdaToolResultEvent),
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
        public bool Equals(TestLambdaToolStreamedResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TestToolHeartbeatEvent?>.Default.Equals(Heartbeat, other.Heartbeat) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TestLambdaToolResultEvent?>.Default.Equals(Result, other.Result)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TestLambdaToolStreamedResponse obj1, TestLambdaToolStreamedResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestLambdaToolStreamedResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TestLambdaToolStreamedResponse obj1, TestLambdaToolStreamedResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestLambdaToolStreamedResponse o && Equals(o);
        }
    }
}
