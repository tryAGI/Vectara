#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Cancels the caller's own current agent turn.
    /// </summary>
    public readonly partial struct CreateEndUserInterruptRequest : global::System.IEquatable<CreateEndUserInterruptRequest>
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
        public global::Vectara.CreateEndUserInputRequestBase PickInputBase() => IsInputBase
            ? InputBase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputBase' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateEndUserInterruptRequestVariant2? CreateEndUserInterruptRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateEndUserInterruptRequestVariant2? CreateEndUserInterruptRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateEndUserInterruptRequestVariant2))]
#endif
        public bool IsCreateEndUserInterruptRequestVariant2 => CreateEndUserInterruptRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateEndUserInterruptRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateEndUserInterruptRequestVariant2? value)
        {
            value = CreateEndUserInterruptRequestVariant2;
            return IsCreateEndUserInterruptRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateEndUserInterruptRequestVariant2 PickCreateEndUserInterruptRequestVariant2() => IsCreateEndUserInterruptRequestVariant2
            ? CreateEndUserInterruptRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateEndUserInterruptRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEndUserInterruptRequest(global::Vectara.CreateEndUserInputRequestBase value) => new CreateEndUserInterruptRequest((global::Vectara.CreateEndUserInputRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserInputRequestBase?(CreateEndUserInterruptRequest @this) => @this.InputBase;

        /// <summary>
        /// 
        /// </summary>
        public CreateEndUserInterruptRequest(global::Vectara.CreateEndUserInputRequestBase? value)
        {
            InputBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateEndUserInterruptRequest FromInputBase(global::Vectara.CreateEndUserInputRequestBase? value) => new CreateEndUserInterruptRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEndUserInterruptRequest(global::Vectara.CreateEndUserInterruptRequestVariant2 value) => new CreateEndUserInterruptRequest((global::Vectara.CreateEndUserInterruptRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserInterruptRequestVariant2?(CreateEndUserInterruptRequest @this) => @this.CreateEndUserInterruptRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateEndUserInterruptRequest(global::Vectara.CreateEndUserInterruptRequestVariant2? value)
        {
            CreateEndUserInterruptRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateEndUserInterruptRequest FromCreateEndUserInterruptRequestVariant2(global::Vectara.CreateEndUserInterruptRequestVariant2? value) => new CreateEndUserInterruptRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateEndUserInterruptRequest(
            global::Vectara.CreateEndUserInputRequestBase? inputBase,
            global::Vectara.CreateEndUserInterruptRequestVariant2? createEndUserInterruptRequestVariant2
            )
        {
            InputBase = inputBase;
            CreateEndUserInterruptRequestVariant2 = createEndUserInterruptRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateEndUserInterruptRequestVariant2 as object ??
            InputBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputBase?.ToString() ??
            CreateEndUserInterruptRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputBase && IsCreateEndUserInterruptRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateEndUserInputRequestBase, TResult>? inputBase = null,
            global::System.Func<global::Vectara.CreateEndUserInterruptRequestVariant2, TResult>? createEndUserInterruptRequestVariant2 = null,
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
            else if (IsCreateEndUserInterruptRequestVariant2 && createEndUserInterruptRequestVariant2 != null)
            {
                return createEndUserInterruptRequestVariant2(CreateEndUserInterruptRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateEndUserInputRequestBase>? inputBase = null,

            global::System.Action<global::Vectara.CreateEndUserInterruptRequestVariant2>? createEndUserInterruptRequestVariant2 = null,
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
            else if (IsCreateEndUserInterruptRequestVariant2)
            {
                createEndUserInterruptRequestVariant2?.Invoke(CreateEndUserInterruptRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateEndUserInputRequestBase>? inputBase = null,
            global::System.Action<global::Vectara.CreateEndUserInterruptRequestVariant2>? createEndUserInterruptRequestVariant2 = null,
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
            else if (IsCreateEndUserInterruptRequestVariant2)
            {
                createEndUserInterruptRequestVariant2?.Invoke(CreateEndUserInterruptRequestVariant2!);
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
                CreateEndUserInterruptRequestVariant2,
                typeof(global::Vectara.CreateEndUserInterruptRequestVariant2),
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
        public bool Equals(CreateEndUserInterruptRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserInputRequestBase?>.Default.Equals(InputBase, other.InputBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserInterruptRequestVariant2?>.Default.Equals(CreateEndUserInterruptRequestVariant2, other.CreateEndUserInterruptRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateEndUserInterruptRequest obj1, CreateEndUserInterruptRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEndUserInterruptRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateEndUserInterruptRequest obj1, CreateEndUserInterruptRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEndUserInterruptRequest o && Equals(o);
        }
    }
}
