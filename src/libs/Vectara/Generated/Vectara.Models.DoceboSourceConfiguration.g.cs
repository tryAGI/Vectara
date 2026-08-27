#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting the course catalog of a Docebo LMS instance via the Learn REST API.
    /// </summary>
    public readonly partial struct DoceboSourceConfiguration : global::System.IEquatable<DoceboSourceConfiguration>
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
#if NET6_0_OR_GREATER
        public object? DoceboSourceConfigurationVariant2 { get; init; }
#else
        public object? DoceboSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DoceboSourceConfigurationVariant2))]
#endif
        public bool IsDoceboSourceConfigurationVariant2 => DoceboSourceConfigurationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDoceboSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = DoceboSourceConfigurationVariant2;
            return IsDoceboSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickDoceboSourceConfigurationVariant2() => IsDoceboSourceConfigurationVariant2
            ? DoceboSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoceboSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DoceboSourceConfiguration(global::Vectara.BaseDoceboSourceConfiguration value) => new DoceboSourceConfiguration((global::Vectara.BaseDoceboSourceConfiguration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.BaseDoceboSourceConfiguration?(DoceboSourceConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public DoceboSourceConfiguration(global::Vectara.BaseDoceboSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DoceboSourceConfiguration FromBase(global::Vectara.BaseDoceboSourceConfiguration? value) => new DoceboSourceConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public DoceboSourceConfiguration(
            global::Vectara.BaseDoceboSourceConfiguration? @base,
            object? doceboSourceConfigurationVariant2
            )
        {
            Base = @base;
            DoceboSourceConfigurationVariant2 = doceboSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DoceboSourceConfigurationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            DoceboSourceConfigurationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsDoceboSourceConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseDoceboSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? doceboSourceConfigurationVariant2 = null,
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
            else if (IsDoceboSourceConfigurationVariant2 && doceboSourceConfigurationVariant2 != null)
            {
                return doceboSourceConfigurationVariant2(DoceboSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseDoceboSourceConfiguration>? @base = null,

            global::System.Action<object>? doceboSourceConfigurationVariant2 = null,
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
            else if (IsDoceboSourceConfigurationVariant2)
            {
                doceboSourceConfigurationVariant2?.Invoke(DoceboSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseDoceboSourceConfiguration>? @base = null,
            global::System.Action<object>? doceboSourceConfigurationVariant2 = null,
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
            else if (IsDoceboSourceConfigurationVariant2)
            {
                doceboSourceConfigurationVariant2?.Invoke(DoceboSourceConfigurationVariant2!);
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
                DoceboSourceConfigurationVariant2,
                typeof(object),
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
        public bool Equals(DoceboSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseDoceboSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DoceboSourceConfigurationVariant2, other.DoceboSourceConfigurationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DoceboSourceConfiguration obj1, DoceboSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DoceboSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DoceboSourceConfiguration obj1, DoceboSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DoceboSourceConfiguration o && Equals(o);
        }
    }
}
