#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a sub-agent tool that invokes specialized agents for complex tasks.
    /// </summary>
    public readonly partial struct SubAgentToolConfiguration : global::System.IEquatable<SubAgentToolConfiguration>
    {
        /// <summary>
        /// Base properties shared by all tool configuration types.
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
#if NET6_0_OR_GREATER
        public global::Vectara.SubAgentToolConfigurationVariant2? SubAgentToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.SubAgentToolConfigurationVariant2? SubAgentToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubAgentToolConfigurationVariant2))]
#endif
        public bool IsSubAgentToolConfigurationVariant2 => SubAgentToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentToolConfiguration(global::Vectara.ToolConfigurationBase value) => new SubAgentToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(SubAgentToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubAgentToolConfiguration(global::Vectara.SubAgentToolConfigurationVariant2 value) => new SubAgentToolConfiguration((global::Vectara.SubAgentToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.SubAgentToolConfigurationVariant2?(SubAgentToolConfiguration @this) => @this.SubAgentToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SubAgentToolConfiguration(global::Vectara.SubAgentToolConfigurationVariant2? value)
        {
            SubAgentToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SubAgentToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.SubAgentToolConfigurationVariant2? subAgentToolConfigurationVariant2
            )
        {
            Base = @base;
            SubAgentToolConfigurationVariant2 = subAgentToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SubAgentToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            SubAgentToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsSubAgentToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.SubAgentToolConfigurationVariant2?, TResult>? subAgentToolConfigurationVariant2 = null,
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
            else if (IsSubAgentToolConfigurationVariant2 && subAgentToolConfigurationVariant2 != null)
            {
                return subAgentToolConfigurationVariant2(SubAgentToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? @base = null,
            global::System.Action<global::Vectara.SubAgentToolConfigurationVariant2?>? subAgentToolConfigurationVariant2 = null,
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
            else if (IsSubAgentToolConfigurationVariant2)
            {
                subAgentToolConfigurationVariant2?.Invoke(SubAgentToolConfigurationVariant2!);
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
                SubAgentToolConfigurationVariant2,
                typeof(global::Vectara.SubAgentToolConfigurationVariant2),
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
        public bool Equals(SubAgentToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.SubAgentToolConfigurationVariant2?>.Default.Equals(SubAgentToolConfigurationVariant2, other.SubAgentToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SubAgentToolConfiguration obj1, SubAgentToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SubAgentToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SubAgentToolConfiguration obj1, SubAgentToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubAgentToolConfiguration o && Equals(o);
        }
    }
}
