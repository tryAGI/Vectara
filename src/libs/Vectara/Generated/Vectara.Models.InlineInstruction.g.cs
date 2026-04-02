#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An instruction defined inline in the request.
    /// </summary>
    public readonly partial struct InlineInstruction : global::System.IEquatable<InlineInstruction>
    {
        /// <summary>
        /// Base properties for creating an instruction, without the type discriminator field.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InstructionRequestBase? RequestBase { get; init; }
#else
        public global::Vectara.InstructionRequestBase? RequestBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestBase))]
#endif
        public bool IsRequestBase => RequestBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.InlineInstructionVariant2? InlineInstructionVariant2 { get; init; }
#else
        public global::Vectara.InlineInstructionVariant2? InlineInstructionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineInstructionVariant2))]
#endif
        public bool IsInlineInstructionVariant2 => InlineInstructionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineInstruction(global::Vectara.InstructionRequestBase value) => new InlineInstruction((global::Vectara.InstructionRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InstructionRequestBase?(InlineInstruction @this) => @this.RequestBase;

        /// <summary>
        /// 
        /// </summary>
        public InlineInstruction(global::Vectara.InstructionRequestBase? value)
        {
            RequestBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InlineInstruction(global::Vectara.InlineInstructionVariant2 value) => new InlineInstruction((global::Vectara.InlineInstructionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.InlineInstructionVariant2?(InlineInstruction @this) => @this.InlineInstructionVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InlineInstruction(global::Vectara.InlineInstructionVariant2? value)
        {
            InlineInstructionVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InlineInstruction(
            global::Vectara.InstructionRequestBase? requestBase,
            global::Vectara.InlineInstructionVariant2? inlineInstructionVariant2
            )
        {
            RequestBase = requestBase;
            InlineInstructionVariant2 = inlineInstructionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InlineInstructionVariant2 as object ??
            RequestBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RequestBase?.ToString() ??
            InlineInstructionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRequestBase && IsInlineInstructionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.InstructionRequestBase?, TResult>? requestBase = null,
            global::System.Func<global::Vectara.InlineInstructionVariant2?, TResult>? inlineInstructionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestBase && requestBase != null)
            {
                return requestBase(RequestBase!);
            }
            else if (IsInlineInstructionVariant2 && inlineInstructionVariant2 != null)
            {
                return inlineInstructionVariant2(InlineInstructionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.InstructionRequestBase?>? requestBase = null,
            global::System.Action<global::Vectara.InlineInstructionVariant2?>? inlineInstructionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRequestBase)
            {
                requestBase?.Invoke(RequestBase!);
            }
            else if (IsInlineInstructionVariant2)
            {
                inlineInstructionVariant2?.Invoke(InlineInstructionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RequestBase,
                typeof(global::Vectara.InstructionRequestBase),
                InlineInstructionVariant2,
                typeof(global::Vectara.InlineInstructionVariant2),
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
        public bool Equals(InlineInstruction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InstructionRequestBase?>.Default.Equals(RequestBase, other.RequestBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.InlineInstructionVariant2?>.Default.Equals(InlineInstructionVariant2, other.InlineInstructionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InlineInstruction obj1, InlineInstruction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InlineInstruction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InlineInstruction obj1, InlineInstruction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InlineInstruction o && Equals(o);
        }
    }
}
