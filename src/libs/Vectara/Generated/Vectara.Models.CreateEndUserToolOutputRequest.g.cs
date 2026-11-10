#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Delivers the outputs of the client tool calls the session is waiting on, so the agent can continue. Submit one entry per call listed in the `client_tool_pending` event or by `GET /v2/agent_aliases/{alias_key}/end_user_sessions/{session_key}/outstanding_client_tool_calls`.
    /// </summary>
    public readonly partial struct CreateEndUserToolOutputRequest : global::System.IEquatable<CreateEndUserToolOutputRequest>
    {
        /// <summary>
        /// Base properties shared by all end-user input kinds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateEndUserInputRequestBase? InputBase { get; init; }
#else
        public global::Vectara.CreateEndUserInputRequestBase? InputBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputBase))]
#endif
        public bool IsInputBase => InputBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateEndUserInputRequestBase? value)
        {
            value = InputBase;
            return IsInputBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestBase PickInputBase() => InputBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateEndUserToolOutputRequestVariant2? CreateEndUserToolOutputRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateEndUserToolOutputRequestVariant2? CreateEndUserToolOutputRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateEndUserToolOutputRequestVariant2))]
#endif
        public bool IsCreateEndUserToolOutputRequestVariant2 => CreateEndUserToolOutputRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateEndUserToolOutputRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateEndUserToolOutputRequestVariant2? value)
        {
            value = CreateEndUserToolOutputRequestVariant2;
            return IsCreateEndUserToolOutputRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateEndUserToolOutputRequestVariant2 PickCreateEndUserToolOutputRequestVariant2() => CreateEndUserToolOutputRequestVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateEndUserToolOutputRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEndUserToolOutputRequest(global::Vectara.CreateEndUserInputRequestBase value) => new CreateEndUserToolOutputRequest((global::Vectara.CreateEndUserInputRequestBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserInputRequestBase?(CreateEndUserToolOutputRequest @this) => @this.InputBase;

        /// <summary>
        ///
        /// </summary>
        public CreateEndUserToolOutputRequest(global::Vectara.CreateEndUserInputRequestBase? value)
        {
            InputBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEndUserToolOutputRequest FromInputBase(global::Vectara.CreateEndUserInputRequestBase? value) => new CreateEndUserToolOutputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEndUserToolOutputRequest(global::Vectara.CreateEndUserToolOutputRequestVariant2 value) => new CreateEndUserToolOutputRequest((global::Vectara.CreateEndUserToolOutputRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserToolOutputRequestVariant2?(CreateEndUserToolOutputRequest @this) => @this.CreateEndUserToolOutputRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateEndUserToolOutputRequest(global::Vectara.CreateEndUserToolOutputRequestVariant2? value)
        {
            CreateEndUserToolOutputRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEndUserToolOutputRequest FromCreateEndUserToolOutputRequestVariant2(global::Vectara.CreateEndUserToolOutputRequestVariant2? value) => new CreateEndUserToolOutputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateEndUserToolOutputRequest(
            global::Vectara.CreateEndUserInputRequestBase? inputBase,
            global::Vectara.CreateEndUserToolOutputRequestVariant2? createEndUserToolOutputRequestVariant2
            )
        {
            InputBase = inputBase;
            CreateEndUserToolOutputRequestVariant2 = createEndUserToolOutputRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateEndUserToolOutputRequestVariant2 as object ??
            InputBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputBase?.ToString() ??
            CreateEndUserToolOutputRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputBase && IsCreateEndUserToolOutputRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateEndUserInputRequestBase, TResult>? inputBase = null,
            global::System.Func<global::Vectara.CreateEndUserToolOutputRequestVariant2, TResult>? createEndUserToolOutputRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputBase is { } __value0 && inputBase != null)
            {
                return inputBase(__value0);
            }
            else if (CreateEndUserToolOutputRequestVariant2 is { } __value1 && createEndUserToolOutputRequestVariant2 != null)
            {
                return createEndUserToolOutputRequestVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateEndUserInputRequestBase>? inputBase = null,

            global::System.Action<global::Vectara.CreateEndUserToolOutputRequestVariant2>? createEndUserToolOutputRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputBase is { } __value0)
            {
                inputBase?.Invoke(__value0);
            }
            else if (CreateEndUserToolOutputRequestVariant2 is { } __value1)
            {
                createEndUserToolOutputRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateEndUserInputRequestBase>? inputBase = null,
            global::System.Action<global::Vectara.CreateEndUserToolOutputRequestVariant2>? createEndUserToolOutputRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputBase is { } __value0)
            {
                inputBase?.Invoke(__value0);
            }
            else if (CreateEndUserToolOutputRequestVariant2 is { } __value1)
            {
                createEndUserToolOutputRequestVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputBase,
                typeof(global::Vectara.CreateEndUserInputRequestBase),
                CreateEndUserToolOutputRequestVariant2,
                typeof(global::Vectara.CreateEndUserToolOutputRequestVariant2),
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
        public bool Equals(CreateEndUserToolOutputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserInputRequestBase?>.Default.Equals(InputBase, other.InputBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserToolOutputRequestVariant2?>.Default.Equals(CreateEndUserToolOutputRequestVariant2, other.CreateEndUserToolOutputRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateEndUserToolOutputRequest obj1, CreateEndUserToolOutputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEndUserToolOutputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateEndUserToolOutputRequest obj1, CreateEndUserToolOutputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEndUserToolOutputRequest o && Equals(o);
        }
    }
}
