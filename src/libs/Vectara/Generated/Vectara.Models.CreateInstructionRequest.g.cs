#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create an instruction. Currently only initial instructions are supported.
    /// </summary>
    public readonly partial struct CreateInstructionRequest : global::System.IEquatable<CreateInstructionRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateInstructionRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// Request object for creating a new initial instruction.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateInitialInstructionRequest? Initial { get; init; }
#else
        public global::Vectara.CreateInitialInstructionRequest? Initial { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Initial))]
#endif
        public bool IsInitial => Initial != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInstructionRequest(global::Vectara.CreateInitialInstructionRequest value) => new CreateInstructionRequest((global::Vectara.CreateInitialInstructionRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateInitialInstructionRequest?(CreateInstructionRequest @this) => @this.Initial;

        /// <summary>
        /// 
        /// </summary>
        public CreateInstructionRequest(global::Vectara.CreateInitialInstructionRequest? value)
        {
            Initial = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateInstructionRequest(
            global::Vectara.CreateInstructionRequestDiscriminatorType? type,
            global::Vectara.CreateInitialInstructionRequest? initial
            )
        {
            Type = type;

            Initial = initial;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Initial as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Initial?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInitial;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateInitialInstructionRequest?, TResult>? initial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitial && initial != null)
            {
                return initial(Initial!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateInitialInstructionRequest?>? initial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitial)
            {
                initial?.Invoke(Initial!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Initial,
                typeof(global::Vectara.CreateInitialInstructionRequest),
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
        public bool Equals(CreateInstructionRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateInitialInstructionRequest?>.Default.Equals(Initial, other.Initial) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateInstructionRequest obj1, CreateInstructionRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateInstructionRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateInstructionRequest obj1, CreateInstructionRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateInstructionRequest o && Equals(o);
        }
    }
}
