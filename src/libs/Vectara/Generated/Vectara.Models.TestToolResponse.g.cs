#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Response from testing a Lambda tool. Uses type field to discriminate between success and error responses.
    /// </summary>
    public readonly partial struct TestToolResponse : global::System.IEquatable<TestToolResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.TestToolResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// Successful execution response from testing a Lambda tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.TestToolSuccessResponse? Success { get; init; }
#else
        public global::Vectara.TestToolSuccessResponse? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// Error response from testing a Lambda tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.TestToolErrorResponse? Error { get; init; }
#else
        public global::Vectara.TestToolErrorResponse? Error { get; }
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
        public static implicit operator TestToolResponse(global::Vectara.TestToolSuccessResponse value) => new TestToolResponse((global::Vectara.TestToolSuccessResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.TestToolSuccessResponse?(TestToolResponse @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public TestToolResponse(global::Vectara.TestToolSuccessResponse? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestToolResponse(global::Vectara.TestToolErrorResponse value) => new TestToolResponse((global::Vectara.TestToolErrorResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.TestToolErrorResponse?(TestToolResponse @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public TestToolResponse(global::Vectara.TestToolErrorResponse? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestToolResponse(
            global::Vectara.TestToolResponseDiscriminatorType? type,
            global::Vectara.TestToolSuccessResponse? success,
            global::Vectara.TestToolErrorResponse? error
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
            global::System.Func<global::Vectara.TestToolSuccessResponse?, TResult>? success = null,
            global::System.Func<global::Vectara.TestToolErrorResponse?, TResult>? error = null,
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
            global::System.Action<global::Vectara.TestToolSuccessResponse?>? success = null,
            global::System.Action<global::Vectara.TestToolErrorResponse?>? error = null,
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
                typeof(global::Vectara.TestToolSuccessResponse),
                Error,
                typeof(global::Vectara.TestToolErrorResponse),
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
        public bool Equals(TestToolResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TestToolSuccessResponse?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.TestToolErrorResponse?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestToolResponse obj1, TestToolResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestToolResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestToolResponse obj1, TestToolResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestToolResponse o && Equals(o);
        }
    }
}
