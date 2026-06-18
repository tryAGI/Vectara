#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a Lambda tool that executes user-defined functions in a sandboxed environment.
    /// </summary>
    public readonly partial struct LambdaToolConfiguration : global::System.IEquatable<LambdaToolConfiguration>
    {
        /// <summary>
        /// Base properties shared by all tool configuration types.<br/>
        /// The identity properties (`key`, `name`, `description`, `enabled`, `metadata`) apply to reusable configurations managed via the `/v2/tool_configurations` endpoints; they are ignored when the configuration is defined inline in an agent's `tool_configurations` map, where the map key is the tool's name.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ToolConfigurationBase? Base { get; init; }
#else
        public global::Vectara.ToolConfigurationBase? Base { get; }
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
            out global::Vectara.ToolConfigurationBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolConfigurationBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.LambdaToolConfigurationVariant2? LambdaToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.LambdaToolConfigurationVariant2? LambdaToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LambdaToolConfigurationVariant2))]
#endif
        public bool IsLambdaToolConfigurationVariant2 => LambdaToolConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLambdaToolConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.LambdaToolConfigurationVariant2? value)
        {
            value = LambdaToolConfigurationVariant2;
            return IsLambdaToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.LambdaToolConfigurationVariant2 PickLambdaToolConfigurationVariant2() => IsLambdaToolConfigurationVariant2
            ? LambdaToolConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LambdaToolConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LambdaToolConfiguration(global::Vectara.ToolConfigurationBase value) => new LambdaToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(LambdaToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public LambdaToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LambdaToolConfiguration FromBase(global::Vectara.ToolConfigurationBase? value) => new LambdaToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LambdaToolConfiguration(global::Vectara.LambdaToolConfigurationVariant2 value) => new LambdaToolConfiguration((global::Vectara.LambdaToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.LambdaToolConfigurationVariant2?(LambdaToolConfiguration @this) => @this.LambdaToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public LambdaToolConfiguration(global::Vectara.LambdaToolConfigurationVariant2? value)
        {
            LambdaToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LambdaToolConfiguration FromLambdaToolConfigurationVariant2(global::Vectara.LambdaToolConfigurationVariant2? value) => new LambdaToolConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public LambdaToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.LambdaToolConfigurationVariant2? lambdaToolConfigurationVariant2
            )
        {
            Base = @base;
            LambdaToolConfigurationVariant2 = lambdaToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LambdaToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            LambdaToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsLambdaToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.LambdaToolConfigurationVariant2, TResult>? lambdaToolConfigurationVariant2 = null,
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
            else if (IsLambdaToolConfigurationVariant2 && lambdaToolConfigurationVariant2 != null)
            {
                return lambdaToolConfigurationVariant2(LambdaToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.LambdaToolConfigurationVariant2>? lambdaToolConfigurationVariant2 = null,
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
            else if (IsLambdaToolConfigurationVariant2)
            {
                lambdaToolConfigurationVariant2?.Invoke(LambdaToolConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.LambdaToolConfigurationVariant2>? lambdaToolConfigurationVariant2 = null,
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
            else if (IsLambdaToolConfigurationVariant2)
            {
                lambdaToolConfigurationVariant2?.Invoke(LambdaToolConfigurationVariant2!);
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
                typeof(global::Vectara.ToolConfigurationBase),
                LambdaToolConfigurationVariant2,
                typeof(global::Vectara.LambdaToolConfigurationVariant2),
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
        public bool Equals(LambdaToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.LambdaToolConfigurationVariant2?>.Default.Equals(LambdaToolConfigurationVariant2, other.LambdaToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LambdaToolConfiguration obj1, LambdaToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LambdaToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LambdaToolConfiguration obj1, LambdaToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LambdaToolConfiguration o && Equals(o);
        }
    }
}
