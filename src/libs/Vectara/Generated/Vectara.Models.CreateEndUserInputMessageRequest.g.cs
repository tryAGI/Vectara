#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A message from the end user, with optional file uploads.
    /// </summary>
    public readonly partial struct CreateEndUserInputMessageRequest : global::System.IEquatable<CreateEndUserInputMessageRequest>
    {
        /// <summary>
        /// Base properties shared by all end-user input kinds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateEndUserInputRequestBase? Base { get; init; }
#else
        public global::Vectara.CreateEndUserInputRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateEndUserInputRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateEndUserInputRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateEndUserInputMessageRequestVariant2? CreateEndUserInputMessageRequestVariant2 { get; init; }
#else
        public global::Vectara.CreateEndUserInputMessageRequestVariant2? CreateEndUserInputMessageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateEndUserInputMessageRequestVariant2))]
#endif
        public bool IsCreateEndUserInputMessageRequestVariant2 => CreateEndUserInputMessageRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateEndUserInputMessageRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateEndUserInputMessageRequestVariant2? value)
        {
            value = CreateEndUserInputMessageRequestVariant2;
            return IsCreateEndUserInputMessageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateEndUserInputMessageRequestVariant2 PickCreateEndUserInputMessageRequestVariant2() => IsCreateEndUserInputMessageRequestVariant2
            ? CreateEndUserInputMessageRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateEndUserInputMessageRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEndUserInputMessageRequest(global::Vectara.CreateEndUserInputRequestBase value) => new CreateEndUserInputMessageRequest((global::Vectara.CreateEndUserInputRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserInputRequestBase?(CreateEndUserInputMessageRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateEndUserInputMessageRequest(global::Vectara.CreateEndUserInputRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateEndUserInputMessageRequest FromBase(global::Vectara.CreateEndUserInputRequestBase? value) => new CreateEndUserInputMessageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEndUserInputMessageRequest(global::Vectara.CreateEndUserInputMessageRequestVariant2 value) => new CreateEndUserInputMessageRequest((global::Vectara.CreateEndUserInputMessageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateEndUserInputMessageRequestVariant2?(CreateEndUserInputMessageRequest @this) => @this.CreateEndUserInputMessageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateEndUserInputMessageRequest(global::Vectara.CreateEndUserInputMessageRequestVariant2? value)
        {
            CreateEndUserInputMessageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateEndUserInputMessageRequest FromCreateEndUserInputMessageRequestVariant2(global::Vectara.CreateEndUserInputMessageRequestVariant2? value) => new CreateEndUserInputMessageRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateEndUserInputMessageRequest(
            global::Vectara.CreateEndUserInputRequestBase? @base,
            global::Vectara.CreateEndUserInputMessageRequestVariant2? createEndUserInputMessageRequestVariant2
            )
        {
            Base = @base;
            CreateEndUserInputMessageRequestVariant2 = createEndUserInputMessageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateEndUserInputMessageRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateEndUserInputMessageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateEndUserInputMessageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateEndUserInputRequestBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateEndUserInputMessageRequestVariant2, TResult>? createEndUserInputMessageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsCreateEndUserInputMessageRequestVariant2 && createEndUserInputMessageRequestVariant2 != null)
            {
                return createEndUserInputMessageRequestVariant2(CreateEndUserInputMessageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateEndUserInputRequestBase>? @base = null,

            global::System.Action<global::Vectara.CreateEndUserInputMessageRequestVariant2>? createEndUserInputMessageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCreateEndUserInputMessageRequestVariant2)
            {
                createEndUserInputMessageRequestVariant2?.Invoke(CreateEndUserInputMessageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateEndUserInputRequestBase>? @base = null,
            global::System.Action<global::Vectara.CreateEndUserInputMessageRequestVariant2>? createEndUserInputMessageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCreateEndUserInputMessageRequestVariant2)
            {
                createEndUserInputMessageRequestVariant2?.Invoke(CreateEndUserInputMessageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.CreateEndUserInputRequestBase),
                CreateEndUserInputMessageRequestVariant2,
                typeof(global::Vectara.CreateEndUserInputMessageRequestVariant2),
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
        public bool Equals(CreateEndUserInputMessageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserInputRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateEndUserInputMessageRequestVariant2?>.Default.Equals(CreateEndUserInputMessageRequestVariant2, other.CreateEndUserInputMessageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateEndUserInputMessageRequest obj1, CreateEndUserInputMessageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEndUserInputMessageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateEndUserInputMessageRequest obj1, CreateEndUserInputMessageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEndUserInputMessageRequest o && Equals(o);
        }
    }
}
