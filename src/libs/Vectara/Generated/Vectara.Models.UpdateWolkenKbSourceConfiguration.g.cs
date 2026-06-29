#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for Wolken source configuration. Only provided fields are merged.
    /// </summary>
    public readonly partial struct UpdateWolkenKbSourceConfiguration : global::System.IEquatable<UpdateWolkenKbSourceConfiguration>
    {
        /// <summary>
        /// Base Wolken ServiceDesk knowledge-base source configuration. Ingests knowledge-base articles<br/>
        /// matching the configured filters, with each article's audience attributes carried as document<br/>
        /// metadata for attribute-based filtering. Requires Wolken data API credentials with read access<br/>
        /// to the knowledge-base listing and article-detail endpoints. Incremental sync additionally<br/>
        /// requires the listing to support update-time filters. Supported filters vary by Wolken<br/>
        /// deployment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseWolkenKbSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseWolkenKbSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseWolkenKbSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseWolkenKbSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateWolkenKbSourceConfiguration(global::Vectara.BaseWolkenKbSourceConfiguration value) => new UpdateWolkenKbSourceConfiguration((global::Vectara.BaseWolkenKbSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseWolkenKbSourceConfiguration?(UpdateWolkenKbSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public UpdateWolkenKbSourceConfiguration(global::Vectara.BaseWolkenKbSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateWolkenKbSourceConfiguration FromBase(global::Vectara.BaseWolkenKbSourceConfiguration? value) => new UpdateWolkenKbSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseWolkenKbSourceConfiguration, TResult>? @base = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseWolkenKbSourceConfiguration>? @base = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseWolkenKbSourceConfiguration>? @base = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Vectara.BaseWolkenKbSourceConfiguration),
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
        public bool Equals(UpdateWolkenKbSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseWolkenKbSourceConfiguration?>.Default.Equals(Base, other.Base) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateWolkenKbSourceConfiguration obj1, UpdateWolkenKbSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateWolkenKbSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateWolkenKbSourceConfiguration obj1, UpdateWolkenKbSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateWolkenKbSourceConfiguration o && Equals(o);
        }
    }
}
