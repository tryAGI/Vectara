#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// An error reported by the client for a tool call. Surfaced to the agent as a tool execution error.
    /// </summary>
    public readonly partial struct CreateToolOutputError : global::System.IEquatable<CreateToolOutputError>
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
        public global::Vectara.CreateToolOutputErrorVariant2? CreateToolOutputErrorVariant2 { get; init; }
#else
        public global::Vectara.CreateToolOutputErrorVariant2? CreateToolOutputErrorVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateToolOutputErrorVariant2))]
#endif
        public bool IsCreateToolOutputErrorVariant2 => CreateToolOutputErrorVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateToolOutputErrorVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateToolOutputErrorVariant2? value)
        {
            value = CreateToolOutputErrorVariant2;
            return IsCreateToolOutputErrorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateToolOutputErrorVariant2 PickCreateToolOutputErrorVariant2() => IsCreateToolOutputErrorVariant2
            ? CreateToolOutputErrorVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateToolOutputErrorVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolOutputError(global::Vectara.CreateToolOutputBase value) => new CreateToolOutputError((global::Vectara.CreateToolOutputBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateToolOutputBase?(CreateToolOutputError @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputError(global::Vectara.CreateToolOutputBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolOutputError FromBase(global::Vectara.CreateToolOutputBase? value) => new CreateToolOutputError(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolOutputError(global::Vectara.CreateToolOutputErrorVariant2 value) => new CreateToolOutputError((global::Vectara.CreateToolOutputErrorVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateToolOutputErrorVariant2?(CreateToolOutputError @this) => @this.CreateToolOutputErrorVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputError(global::Vectara.CreateToolOutputErrorVariant2? value)
        {
            CreateToolOutputErrorVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolOutputError FromCreateToolOutputErrorVariant2(global::Vectara.CreateToolOutputErrorVariant2? value) => new CreateToolOutputError(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateToolOutputError(
            global::Vectara.CreateToolOutputBase? @base,
            global::Vectara.CreateToolOutputErrorVariant2? createToolOutputErrorVariant2
            )
        {
            Base = @base;
            CreateToolOutputErrorVariant2 = createToolOutputErrorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateToolOutputErrorVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateToolOutputErrorVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateToolOutputErrorVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateToolOutputBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateToolOutputErrorVariant2, TResult>? createToolOutputErrorVariant2 = null,
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
            else if (IsCreateToolOutputErrorVariant2 && createToolOutputErrorVariant2 != null)
            {
                return createToolOutputErrorVariant2(CreateToolOutputErrorVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateToolOutputBase>? @base = null,

            global::System.Action<global::Vectara.CreateToolOutputErrorVariant2>? createToolOutputErrorVariant2 = null,
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
            else if (IsCreateToolOutputErrorVariant2)
            {
                createToolOutputErrorVariant2?.Invoke(CreateToolOutputErrorVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateToolOutputBase>? @base = null,
            global::System.Action<global::Vectara.CreateToolOutputErrorVariant2>? createToolOutputErrorVariant2 = null,
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
            else if (IsCreateToolOutputErrorVariant2)
            {
                createToolOutputErrorVariant2?.Invoke(CreateToolOutputErrorVariant2!);
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
                CreateToolOutputErrorVariant2,
                typeof(global::Vectara.CreateToolOutputErrorVariant2),
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
        public bool Equals(CreateToolOutputError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateToolOutputBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateToolOutputErrorVariant2?>.Default.Equals(CreateToolOutputErrorVariant2, other.CreateToolOutputErrorVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateToolOutputError obj1, CreateToolOutputError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateToolOutputError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateToolOutputError obj1, CreateToolOutputError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateToolOutputError o && Equals(o);
        }
    }
}
