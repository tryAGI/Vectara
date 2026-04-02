#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Cancels the current agent operation.
    /// </summary>
    public readonly partial struct CreateInterruptRequest : global::System.IEquatable<CreateInterruptRequest>
    {
        /// <summary>
        /// Base properties shared by all input request types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateInputRequestBase? InputBase { get; init; }
#else
        public global::Vectara.CreateInputRequestBase? InputBase { get; }
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
#if NET6_0_OR_GREATER
        public global::Vectara.CreateInterruptRequestVariant2? CreateInterruptRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateInterruptRequestVariant2? CreateInterruptRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateInterruptRequestVariant2))]
#endif
        public bool IsCreateInterruptRequestVariant2 => CreateInterruptRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInterruptRequest(global::Vectara.CreateInputRequestBase value) => new CreateInterruptRequest((global::Vectara.CreateInputRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateInputRequestBase?(CreateInterruptRequest @this) => @this.InputBase;

        /// <summary>
        /// 
        /// </summary>
        public CreateInterruptRequest(global::Vectara.CreateInputRequestBase? value)
        {
            InputBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInterruptRequest(global::Vectara.CreateInterruptRequestVariant2 value) => new CreateInterruptRequest((global::Vectara.CreateInterruptRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateInterruptRequestVariant2?(CreateInterruptRequest @this) => @this.CreateInterruptRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateInterruptRequest(global::Vectara.CreateInterruptRequestVariant2? value)
        {
            CreateInterruptRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateInterruptRequest(
            global::Vectara.CreateInputRequestBase? inputBase,
            global::Vectara.CreateInterruptRequestVariant2? createInterruptRequestVariant2
            )
        {
            InputBase = inputBase;
            CreateInterruptRequestVariant2 = createInterruptRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateInterruptRequestVariant2 as object ??
            InputBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputBase?.ToString() ??
            CreateInterruptRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputBase && IsCreateInterruptRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateInputRequestBase?, TResult>? inputBase = null,
            global::System.Func<global::Vectara.CreateInterruptRequestVariant2?, TResult>? createInterruptRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputBase && inputBase != null)
            {
                return inputBase(InputBase!);
            }
            else if (IsCreateInterruptRequestVariant2 && createInterruptRequestVariant2 != null)
            {
                return createInterruptRequestVariant2(CreateInterruptRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateInputRequestBase?>? inputBase = null,
            global::System.Action<global::Vectara.CreateInterruptRequestVariant2?>? createInterruptRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputBase)
            {
                inputBase?.Invoke(InputBase!);
            }
            else if (IsCreateInterruptRequestVariant2)
            {
                createInterruptRequestVariant2?.Invoke(CreateInterruptRequestVariant2!);
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
                typeof(global::Vectara.CreateInputRequestBase),
                CreateInterruptRequestVariant2,
                typeof(global::Vectara.CreateInterruptRequestVariant2),
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
        public bool Equals(CreateInterruptRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateInputRequestBase?>.Default.Equals(InputBase, other.InputBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateInterruptRequestVariant2?>.Default.Equals(CreateInterruptRequestVariant2, other.CreateInterruptRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateInterruptRequest obj1, CreateInterruptRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateInterruptRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateInterruptRequest obj1, CreateInterruptRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateInterruptRequest o && Equals(o);
        }
    }
}
