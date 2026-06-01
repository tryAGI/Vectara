#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Delivers the result of a client tool call identified by its `tool_input` event ID.
    /// </summary>
    public readonly partial struct CreateToolOutputRequest : global::System.IEquatable<CreateToolOutputRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateToolOutputRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// A successful client tool output to be returned to the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateToolOutputSuccess? Success { get; init; }
#else
        public global::Vectara.CreateToolOutputSuccess? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateToolOutputSuccess? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateToolOutputSuccess PickSuccess() => IsSuccess
            ? Success!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

        /// <summary>
        /// An error reported by the client for a tool call. Surfaced to the agent as a tool execution error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateToolOutputError? Error { get; init; }
#else
        public global::Vectara.CreateToolOutputError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateToolOutputError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateToolOutputError PickError() => IsError
            ? Error!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolOutputRequest(global::Vectara.CreateToolOutputSuccess value) => new CreateToolOutputRequest((global::Vectara.CreateToolOutputSuccess?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateToolOutputSuccess?(CreateToolOutputRequest @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputRequest(global::Vectara.CreateToolOutputSuccess? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolOutputRequest FromSuccess(global::Vectara.CreateToolOutputSuccess? value) => new CreateToolOutputRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolOutputRequest(global::Vectara.CreateToolOutputError value) => new CreateToolOutputRequest((global::Vectara.CreateToolOutputError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateToolOutputError?(CreateToolOutputRequest @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputRequest(global::Vectara.CreateToolOutputError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolOutputRequest FromError(global::Vectara.CreateToolOutputError? value) => new CreateToolOutputRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputRequest(
            global::Vectara.CreateToolOutputRequestDiscriminatorType? type,
            global::Vectara.CreateToolOutputSuccess? success,
            global::Vectara.CreateToolOutputError? error
            )
        {
            Type = type;

            Success = success;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsError || !IsSuccess && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateToolOutputSuccess?, TResult>? success = null,
            global::System.Func<global::Vectara.CreateToolOutputError?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateToolOutputSuccess?>? success = null,

            global::System.Action<global::Vectara.CreateToolOutputError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateToolOutputSuccess?>? success = null,
            global::System.Action<global::Vectara.CreateToolOutputError?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::Vectara.CreateToolOutputSuccess),
                Error,
                typeof(global::Vectara.CreateToolOutputError),
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
        public bool Equals(CreateToolOutputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateToolOutputSuccess?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateToolOutputError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateToolOutputRequest obj1, CreateToolOutputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateToolOutputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateToolOutputRequest obj1, CreateToolOutputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateToolOutputRequest o && Equals(o);
        }
    }
}
