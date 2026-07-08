#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Configuration for ingesting content from a Fluid Topics tenant via the Knowledge Hub REST API.
    /// </summary>
    public readonly partial struct FluidtopicsSourceConfiguration : global::System.IEquatable<FluidtopicsSourceConfiguration>
    {
        /// <summary>
        /// Base Fluid Topics source configuration. Ingests content from a Fluid Topics tenant via the<br/>
        /// Knowledge Hub REST API. `content_scope` selects which layer to ingest — `documents` (standalone<br/>
        /// items) or `topics` (the sections inside publications, each carrying its parent map's identity and<br/>
        /// classification). Every record carries its full Fluid Topics metadata, including classification and<br/>
        /// entitlement fields, as document metadata for attribute-based filtering and access control. Requires<br/>
        /// a Fluid Topics API key with read access to the configured content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.BaseFluidtopicsSourceConfiguration? Base { get; init; }
#else
        public global::Vectara.BaseFluidtopicsSourceConfiguration? Base { get; }
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
            out global::Vectara.BaseFluidtopicsSourceConfiguration? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.BaseFluidtopicsSourceConfiguration PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FluidtopicsSourceConfigurationVariant2 { get; init; }
#else
        public object? FluidtopicsSourceConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FluidtopicsSourceConfigurationVariant2))]
#endif
        public bool IsFluidtopicsSourceConfigurationVariant2 => FluidtopicsSourceConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFluidtopicsSourceConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = FluidtopicsSourceConfigurationVariant2;
            return IsFluidtopicsSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickFluidtopicsSourceConfigurationVariant2() => IsFluidtopicsSourceConfigurationVariant2
            ? FluidtopicsSourceConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FluidtopicsSourceConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FluidtopicsSourceConfiguration(global::Vectara.BaseFluidtopicsSourceConfiguration value) => new FluidtopicsSourceConfiguration((global::Vectara.BaseFluidtopicsSourceConfiguration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.BaseFluidtopicsSourceConfiguration?(FluidtopicsSourceConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public FluidtopicsSourceConfiguration(global::Vectara.BaseFluidtopicsSourceConfiguration? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static FluidtopicsSourceConfiguration FromBase(global::Vectara.BaseFluidtopicsSourceConfiguration? value) => new FluidtopicsSourceConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public FluidtopicsSourceConfiguration(
            global::Vectara.BaseFluidtopicsSourceConfiguration? @base,
            object? fluidtopicsSourceConfigurationVariant2
            )
        {
            Base = @base;
            FluidtopicsSourceConfigurationVariant2 = fluidtopicsSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FluidtopicsSourceConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FluidtopicsSourceConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsFluidtopicsSourceConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.BaseFluidtopicsSourceConfiguration, TResult>? @base = null,
            global::System.Func<object, TResult>? fluidtopicsSourceConfigurationVariant2 = null,
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
            else if (IsFluidtopicsSourceConfigurationVariant2 && fluidtopicsSourceConfigurationVariant2 != null)
            {
                return fluidtopicsSourceConfigurationVariant2(FluidtopicsSourceConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.BaseFluidtopicsSourceConfiguration>? @base = null,

            global::System.Action<object>? fluidtopicsSourceConfigurationVariant2 = null,
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
            else if (IsFluidtopicsSourceConfigurationVariant2)
            {
                fluidtopicsSourceConfigurationVariant2?.Invoke(FluidtopicsSourceConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.BaseFluidtopicsSourceConfiguration>? @base = null,
            global::System.Action<object>? fluidtopicsSourceConfigurationVariant2 = null,
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
            else if (IsFluidtopicsSourceConfigurationVariant2)
            {
                fluidtopicsSourceConfigurationVariant2?.Invoke(FluidtopicsSourceConfigurationVariant2!);
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
                typeof(global::Vectara.BaseFluidtopicsSourceConfiguration),
                FluidtopicsSourceConfigurationVariant2,
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
        public bool Equals(FluidtopicsSourceConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.BaseFluidtopicsSourceConfiguration?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FluidtopicsSourceConfigurationVariant2, other.FluidtopicsSourceConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FluidtopicsSourceConfiguration obj1, FluidtopicsSourceConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FluidtopicsSourceConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FluidtopicsSourceConfiguration obj1, FluidtopicsSourceConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FluidtopicsSourceConfiguration o && Equals(o);
        }
    }
}
