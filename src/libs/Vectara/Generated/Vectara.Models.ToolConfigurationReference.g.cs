#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// References a reusable tool configuration by its key. The configuration is managed independently via<br/>
    /// the Tool Configurations API and can be shared across agents. The agent-facing tool name is the key<br/>
    /// of this entry in the agent's `tool_configurations` map, which may differ from the configuration's own name.
    /// </summary>
    public readonly partial struct ToolConfigurationReference : global::System.IEquatable<ToolConfigurationReference>
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
        public global::Vectara.ToolConfigurationReferenceVariant2? ToolConfigurationReferenceVariant2 { get; init; }
#else
        public global::Vectara.ToolConfigurationReferenceVariant2? ToolConfigurationReferenceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolConfigurationReferenceVariant2))]
#endif
        public bool IsToolConfigurationReferenceVariant2 => ToolConfigurationReferenceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolConfigurationReferenceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.ToolConfigurationReferenceVariant2? value)
        {
            value = ToolConfigurationReferenceVariant2;
            return IsToolConfigurationReferenceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ToolConfigurationReferenceVariant2 PickToolConfigurationReferenceVariant2() => IsToolConfigurationReferenceVariant2
            ? ToolConfigurationReferenceVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolConfigurationReferenceVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfigurationReference(global::Vectara.ToolConfigurationBase value) => new ToolConfigurationReference((global::Vectara.ToolConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationBase?(ToolConfigurationReference @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfigurationReference(global::Vectara.ToolConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolConfigurationReference FromBase(global::Vectara.ToolConfigurationBase? value) => new ToolConfigurationReference(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfigurationReference(global::Vectara.ToolConfigurationReferenceVariant2 value) => new ToolConfigurationReference((global::Vectara.ToolConfigurationReferenceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.ToolConfigurationReferenceVariant2?(ToolConfigurationReference @this) => @this.ToolConfigurationReferenceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfigurationReference(global::Vectara.ToolConfigurationReferenceVariant2? value)
        {
            ToolConfigurationReferenceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolConfigurationReference FromToolConfigurationReferenceVariant2(global::Vectara.ToolConfigurationReferenceVariant2? value) => new ToolConfigurationReference(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolConfigurationReference(
            global::Vectara.ToolConfigurationBase? @base,
            global::Vectara.ToolConfigurationReferenceVariant2? toolConfigurationReferenceVariant2
            )
        {
            Base = @base;
            ToolConfigurationReferenceVariant2 = toolConfigurationReferenceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolConfigurationReferenceVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ToolConfigurationReferenceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsToolConfigurationReferenceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ToolConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.ToolConfigurationReferenceVariant2, TResult>? toolConfigurationReferenceVariant2 = null,
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
            else if (IsToolConfigurationReferenceVariant2 && toolConfigurationReferenceVariant2 != null)
            {
                return toolConfigurationReferenceVariant2(ToolConfigurationReferenceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.ToolConfigurationReferenceVariant2>? toolConfigurationReferenceVariant2 = null,
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
            else if (IsToolConfigurationReferenceVariant2)
            {
                toolConfigurationReferenceVariant2?.Invoke(ToolConfigurationReferenceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ToolConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.ToolConfigurationReferenceVariant2>? toolConfigurationReferenceVariant2 = null,
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
            else if (IsToolConfigurationReferenceVariant2)
            {
                toolConfigurationReferenceVariant2?.Invoke(ToolConfigurationReferenceVariant2!);
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
                ToolConfigurationReferenceVariant2,
                typeof(global::Vectara.ToolConfigurationReferenceVariant2),
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
        public bool Equals(ToolConfigurationReference other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ToolConfigurationReferenceVariant2?>.Default.Equals(ToolConfigurationReferenceVariant2, other.ToolConfigurationReferenceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolConfigurationReference obj1, ToolConfigurationReference obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolConfigurationReference>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolConfigurationReference obj1, ToolConfigurationReference obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolConfigurationReference o && Equals(o);
        }
    }
}
