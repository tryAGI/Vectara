#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A successful client tool output to be returned to the agent.
    /// </summary>
    public readonly partial struct CreateToolOutputSuccess : global::System.IEquatable<CreateToolOutputSuccess>
    {
        /// <summary>
        /// Base properties shared by client tool output submissions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateToolOutputBase? Base { get; init; }
#else
        public global::Vectara.CreateToolOutputBase? Base { get; }
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
            out global::Vectara.CreateToolOutputBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateToolOutputBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateToolOutputSuccessVariant2? CreateToolOutputSuccessVariant2 { get; init; }
#else
        public global::Vectara.CreateToolOutputSuccessVariant2? CreateToolOutputSuccessVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateToolOutputSuccessVariant2))]
#endif
        public bool IsCreateToolOutputSuccessVariant2 => CreateToolOutputSuccessVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateToolOutputSuccessVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateToolOutputSuccessVariant2? value)
        {
            value = CreateToolOutputSuccessVariant2;
            return IsCreateToolOutputSuccessVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateToolOutputSuccessVariant2 PickCreateToolOutputSuccessVariant2() => IsCreateToolOutputSuccessVariant2
            ? CreateToolOutputSuccessVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateToolOutputSuccessVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolOutputSuccess(global::Vectara.CreateToolOutputBase value) => new CreateToolOutputSuccess((global::Vectara.CreateToolOutputBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateToolOutputBase?(CreateToolOutputSuccess @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputSuccess(global::Vectara.CreateToolOutputBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolOutputSuccess FromBase(global::Vectara.CreateToolOutputBase? value) => new CreateToolOutputSuccess(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolOutputSuccess(global::Vectara.CreateToolOutputSuccessVariant2 value) => new CreateToolOutputSuccess((global::Vectara.CreateToolOutputSuccessVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateToolOutputSuccessVariant2?(CreateToolOutputSuccess @this) => @this.CreateToolOutputSuccessVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputSuccess(global::Vectara.CreateToolOutputSuccessVariant2? value)
        {
            CreateToolOutputSuccessVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolOutputSuccess FromCreateToolOutputSuccessVariant2(global::Vectara.CreateToolOutputSuccessVariant2? value) => new CreateToolOutputSuccess(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputSuccess(
            global::Vectara.CreateToolOutputBase? @base,
            global::Vectara.CreateToolOutputSuccessVariant2? createToolOutputSuccessVariant2
            )
        {
            Base = @base;
            CreateToolOutputSuccessVariant2 = createToolOutputSuccessVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateToolOutputSuccessVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateToolOutputSuccessVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateToolOutputSuccessVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateToolOutputBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateToolOutputSuccessVariant2, TResult>? createToolOutputSuccessVariant2 = null,
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
            else if (IsCreateToolOutputSuccessVariant2 && createToolOutputSuccessVariant2 != null)
            {
                return createToolOutputSuccessVariant2(CreateToolOutputSuccessVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateToolOutputBase>? @base = null,

            global::System.Action<global::Vectara.CreateToolOutputSuccessVariant2>? createToolOutputSuccessVariant2 = null,
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
            else if (IsCreateToolOutputSuccessVariant2)
            {
                createToolOutputSuccessVariant2?.Invoke(CreateToolOutputSuccessVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateToolOutputBase>? @base = null,
            global::System.Action<global::Vectara.CreateToolOutputSuccessVariant2>? createToolOutputSuccessVariant2 = null,
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
            else if (IsCreateToolOutputSuccessVariant2)
            {
                createToolOutputSuccessVariant2?.Invoke(CreateToolOutputSuccessVariant2!);
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
                typeof(global::Vectara.CreateToolOutputBase),
                CreateToolOutputSuccessVariant2,
                typeof(global::Vectara.CreateToolOutputSuccessVariant2),
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
        public bool Equals(CreateToolOutputSuccess other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateToolOutputBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateToolOutputSuccessVariant2?>.Default.Equals(CreateToolOutputSuccessVariant2, other.CreateToolOutputSuccessVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateToolOutputSuccess obj1, CreateToolOutputSuccess obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateToolOutputSuccess>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateToolOutputSuccess obj1, CreateToolOutputSuccess obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateToolOutputSuccess o && Equals(o);
        }
    }
}
