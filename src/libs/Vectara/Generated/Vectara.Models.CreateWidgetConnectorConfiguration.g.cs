#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Write view of a web widget connector's configuration, supplied on create or update.<br/>
    /// Every field is served to anonymous visitors by the unauthenticated widget bootstrap endpoint.<br/>
    /// The `bootstrap_path` is platform-derived and appears only in the read view.<br/>
    /// Widget connectors ignore the base `hidden_output_types`; end-user event visibility is controlled by `revealed_output_types`.
    /// </summary>
    public readonly partial struct CreateWidgetConnectorConfiguration : global::System.IEquatable<CreateWidgetConnectorConfiguration>
    {
        /// <summary>
        /// Properties shared by every connector configuration write view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateConnectorConfigurationBase? Base { get; init; }
#else
        public global::Vectara.CreateConnectorConfigurationBase? Base { get; }
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
            out global::Vectara.CreateConnectorConfigurationBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateConnectorConfigurationBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateWidgetConnectorConfigurationVariant2? CreateWidgetConnectorConfigurationVariant2 { get; init; }
#else
        public global::Vectara.CreateWidgetConnectorConfigurationVariant2? CreateWidgetConnectorConfigurationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateWidgetConnectorConfigurationVariant2))]
#endif
        public bool IsCreateWidgetConnectorConfigurationVariant2 => CreateWidgetConnectorConfigurationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateWidgetConnectorConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateWidgetConnectorConfigurationVariant2? value)
        {
            value = CreateWidgetConnectorConfigurationVariant2;
            return IsCreateWidgetConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateWidgetConnectorConfigurationVariant2 PickCreateWidgetConnectorConfigurationVariant2() => IsCreateWidgetConnectorConfigurationVariant2
            ? CreateWidgetConnectorConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateWidgetConnectorConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateWidgetConnectorConfiguration(global::Vectara.CreateConnectorConfigurationBase value) => new CreateWidgetConnectorConfiguration((global::Vectara.CreateConnectorConfigurationBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateConnectorConfigurationBase?(CreateWidgetConnectorConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CreateWidgetConnectorConfiguration(global::Vectara.CreateConnectorConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateWidgetConnectorConfiguration FromBase(global::Vectara.CreateConnectorConfigurationBase? value) => new CreateWidgetConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateWidgetConnectorConfiguration(global::Vectara.CreateWidgetConnectorConfigurationVariant2 value) => new CreateWidgetConnectorConfiguration((global::Vectara.CreateWidgetConnectorConfigurationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateWidgetConnectorConfigurationVariant2?(CreateWidgetConnectorConfiguration @this) => @this.CreateWidgetConnectorConfigurationVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateWidgetConnectorConfiguration(global::Vectara.CreateWidgetConnectorConfigurationVariant2? value)
        {
            CreateWidgetConnectorConfigurationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateWidgetConnectorConfiguration FromCreateWidgetConnectorConfigurationVariant2(global::Vectara.CreateWidgetConnectorConfigurationVariant2? value) => new CreateWidgetConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public CreateWidgetConnectorConfiguration(
            global::Vectara.CreateConnectorConfigurationBase? @base,
            global::Vectara.CreateWidgetConnectorConfigurationVariant2? createWidgetConnectorConfigurationVariant2
            )
        {
            Base = @base;
            CreateWidgetConnectorConfigurationVariant2 = createWidgetConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateWidgetConnectorConfigurationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateWidgetConnectorConfigurationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateWidgetConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateConnectorConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateWidgetConnectorConfigurationVariant2, TResult>? createWidgetConnectorConfigurationVariant2 = null,
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
            else if (IsCreateWidgetConnectorConfigurationVariant2 && createWidgetConnectorConfigurationVariant2 != null)
            {
                return createWidgetConnectorConfigurationVariant2(CreateWidgetConnectorConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateConnectorConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.CreateWidgetConnectorConfigurationVariant2>? createWidgetConnectorConfigurationVariant2 = null,
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
            else if (IsCreateWidgetConnectorConfigurationVariant2)
            {
                createWidgetConnectorConfigurationVariant2?.Invoke(CreateWidgetConnectorConfigurationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateConnectorConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.CreateWidgetConnectorConfigurationVariant2>? createWidgetConnectorConfigurationVariant2 = null,
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
            else if (IsCreateWidgetConnectorConfigurationVariant2)
            {
                createWidgetConnectorConfigurationVariant2?.Invoke(CreateWidgetConnectorConfigurationVariant2!);
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
                typeof(global::Vectara.CreateConnectorConfigurationBase),
                CreateWidgetConnectorConfigurationVariant2,
                typeof(global::Vectara.CreateWidgetConnectorConfigurationVariant2),
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
        public bool Equals(CreateWidgetConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateConnectorConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateWidgetConnectorConfigurationVariant2?>.Default.Equals(CreateWidgetConnectorConfigurationVariant2, other.CreateWidgetConnectorConfigurationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateWidgetConnectorConfiguration obj1, CreateWidgetConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateWidgetConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateWidgetConnectorConfiguration obj1, CreateWidgetConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateWidgetConnectorConfiguration o && Equals(o);
        }
    }
}
