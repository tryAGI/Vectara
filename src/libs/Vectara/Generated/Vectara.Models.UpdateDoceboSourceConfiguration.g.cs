#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Partial update for Docebo source configuration. Only provided fields are merged.
    /// </summary>
    public readonly partial struct UpdateDoceboSourceConfiguration : global::System.IEquatable<UpdateDoceboSourceConfiguration>
    {
        /// <summary>
        /// Base Docebo source configuration. Ingests the course catalog of a Docebo LMS instance through the<br/>
        /// Learn REST API. Each course becomes one document carrying its description, skills, and<br/>
        /// instructors, with its category, language, and course type as document metadata for<br/>
        /// attribute-based filtering.<br/>
        /// Only courses are ingested; the contents of their training materials are not. Each course document<br/>
        /// includes a curriculum outline listing the title, type, and description of every training material.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseDoceboSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseDoceboSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseDoceboSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.BaseDoceboSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateDoceboSourceConfiguration(global::Vectara.BaseDoceboSourceConfiguration value) => new UpdateDoceboSourceConfiguration((global::Vectara.BaseDoceboSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.BaseDoceboSourceConfiguration?(UpdateDoceboSourceConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public UpdateDoceboSourceConfiguration(global::Vectara.BaseDoceboSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateDoceboSourceConfiguration FromBase(global::Vectara.BaseDoceboSourceConfiguration? value) => new UpdateDoceboSourceConfiguration(value);

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
            global::System.Func<global::Vectara.BaseDoceboSourceConfiguration, TResult>? @base = null,
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
            global::System.Action<global::Vectara.BaseDoceboSourceConfiguration>? @base = null,
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
            global::System.Action<global::Vectara.BaseDoceboSourceConfiguration>? @base = null,
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
                typeof(global::Vectara.BaseDoceboSourceConfiguration),
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
        public bool Equals(UpdateDoceboSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseDoceboSourceConfiguration?>.Default.Equals(Base, other.Base)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateDoceboSourceConfiguration obj1, UpdateDoceboSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateDoceboSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateDoceboSourceConfiguration obj1, UpdateDoceboSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateDoceboSourceConfiguration o && Equals(o);
        }
    }
}
