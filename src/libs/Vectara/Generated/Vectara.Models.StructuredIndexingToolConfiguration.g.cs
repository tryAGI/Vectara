#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A reusable configuration for a structured indexing tool that stores predefined indexing parameters for indexing documents into the Vectara platform.
    /// </summary>
    public readonly partial struct StructuredIndexingToolConfiguration : global::System.IEquatable<StructuredIndexingToolConfiguration>
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
        public global::Vectara.StructuredIndexingToolConfigurationVariant2? StructuredIndexingToolConfigurationVariant2 { get; init; }
#else
        public global::Vectara.StructuredIndexingToolConfigurationVariant2? StructuredIndexingToolConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StructuredIndexingToolConfigurationVariant2))]
#endif
        public bool IsStructuredIndexingToolConfigurationVariant2 => StructuredIndexingToolConfigurationVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StructuredIndexingToolConfiguration(global::Vectara.ToolConfigurationBase value) => new StructuredIndexingToolConfiguration((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(StructuredIndexingToolConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingToolConfiguration(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StructuredIndexingToolConfiguration(global::Vectara.StructuredIndexingToolConfigurationVariant2 value) => new StructuredIndexingToolConfiguration((global::Vectara.StructuredIndexingToolConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StructuredIndexingToolConfigurationVariant2?(StructuredIndexingToolConfiguration @this) => @this.StructuredIndexingToolConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingToolConfiguration(global::Vectara.StructuredIndexingToolConfigurationVariant2? value)
        {
            StructuredIndexingToolConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StructuredIndexingToolConfiguration(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.StructuredIndexingToolConfigurationVariant2? structuredIndexingToolConfigurationVariant2
            )
        {
            Base = @base;
            StructuredIndexingToolConfigurationVariant2 = structuredIndexingToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StructuredIndexingToolConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            StructuredIndexingToolConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsStructuredIndexingToolConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase?, TResult>? @base = null,
            global::System.Func<global::Vectara.StructuredIndexingToolConfigurationVariant2?, TResult>? structuredIndexingToolConfigurationVariant2 = null,
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
            else if (IsStructuredIndexingToolConfigurationVariant2 && structuredIndexingToolConfigurationVariant2 != null)
            {
                return structuredIndexingToolConfigurationVariant2(StructuredIndexingToolConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase?>? @base = null,
            global::System.Action<global::Vectara.StructuredIndexingToolConfigurationVariant2?>? structuredIndexingToolConfigurationVariant2 = null,
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
            else if (IsStructuredIndexingToolConfigurationVariant2)
            {
                structuredIndexingToolConfigurationVariant2?.Invoke(StructuredIndexingToolConfigurationVariant2!);
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
                StructuredIndexingToolConfigurationVariant2,
                typeof(global::Vectara.StructuredIndexingToolConfigurationVariant2),
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
        public bool Equals(StructuredIndexingToolConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredIndexingToolConfigurationVariant2?>.Default.Equals(StructuredIndexingToolConfigurationVariant2, other.StructuredIndexingToolConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StructuredIndexingToolConfiguration obj1, StructuredIndexingToolConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StructuredIndexingToolConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StructuredIndexingToolConfiguration obj1, StructuredIndexingToolConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StructuredIndexingToolConfiguration o && Equals(o);
        }
    }
}
