#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Write view of a Slack connector's configuration, supplied on create or update.
    /// </summary>
    public readonly partial struct CreateSlackConnectorConfiguration : global::System.IEquatable<CreateSlackConnectorConfiguration>
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
        public global::Vectara.CreateConnectorConfigurationBase PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CreateSlackConnectorConfigurationVariant2? CreateSlackConnectorConfigurationVariant2 { get; init; }
#else
        public global::Vectara.CreateSlackConnectorConfigurationVariant2? CreateSlackConnectorConfigurationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateSlackConnectorConfigurationVariant2))]
#endif
        public bool IsCreateSlackConnectorConfigurationVariant2 => CreateSlackConnectorConfigurationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateSlackConnectorConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateSlackConnectorConfigurationVariant2? value)
        {
            value = CreateSlackConnectorConfigurationVariant2;
            return IsCreateSlackConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.CreateSlackConnectorConfigurationVariant2 PickCreateSlackConnectorConfigurationVariant2() => CreateSlackConnectorConfigurationVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateSlackConnectorConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSlackConnectorConfiguration(global::Vectara.CreateConnectorConfigurationBase value) => new CreateSlackConnectorConfiguration((global::Vectara.CreateConnectorConfigurationBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateConnectorConfigurationBase?(CreateSlackConnectorConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public CreateSlackConnectorConfiguration(global::Vectara.CreateConnectorConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSlackConnectorConfiguration FromBase(global::Vectara.CreateConnectorConfigurationBase? value) => new CreateSlackConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateSlackConnectorConfiguration(global::Vectara.CreateSlackConnectorConfigurationVariant2 value) => new CreateSlackConnectorConfiguration((global::Vectara.CreateSlackConnectorConfigurationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.CreateSlackConnectorConfigurationVariant2?(CreateSlackConnectorConfiguration @this) => @this.CreateSlackConnectorConfigurationVariant2;

        /// <summary>
        ///
        /// </summary>
        public CreateSlackConnectorConfiguration(global::Vectara.CreateSlackConnectorConfigurationVariant2? value)
        {
            CreateSlackConnectorConfigurationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateSlackConnectorConfiguration FromCreateSlackConnectorConfigurationVariant2(global::Vectara.CreateSlackConnectorConfigurationVariant2? value) => new CreateSlackConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public CreateSlackConnectorConfiguration(
            global::Vectara.CreateConnectorConfigurationBase? @base,
            global::Vectara.CreateSlackConnectorConfigurationVariant2? createSlackConnectorConfigurationVariant2
            )
        {
            Base = @base;
            CreateSlackConnectorConfigurationVariant2 = createSlackConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateSlackConnectorConfigurationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateSlackConnectorConfigurationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateSlackConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateConnectorConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateSlackConnectorConfigurationVariant2, TResult>? createSlackConnectorConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (CreateSlackConnectorConfigurationVariant2 is { } __value1 && createSlackConnectorConfigurationVariant2 != null)
            {
                return createSlackConnectorConfigurationVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateConnectorConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.CreateSlackConnectorConfigurationVariant2>? createSlackConnectorConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (CreateSlackConnectorConfigurationVariant2 is { } __value1)
            {
                createSlackConnectorConfigurationVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateConnectorConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.CreateSlackConnectorConfigurationVariant2>? createSlackConnectorConfigurationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (CreateSlackConnectorConfigurationVariant2 is { } __value1)
            {
                createSlackConnectorConfigurationVariant2?.Invoke(__value1);
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
                CreateSlackConnectorConfigurationVariant2,
                typeof(global::Vectara.CreateSlackConnectorConfigurationVariant2),
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
        public bool Equals(CreateSlackConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateConnectorConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateSlackConnectorConfigurationVariant2?>.Default.Equals(CreateSlackConnectorConfigurationVariant2, other.CreateSlackConnectorConfigurationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateSlackConnectorConfiguration obj1, CreateSlackConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSlackConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateSlackConnectorConfiguration obj1, CreateSlackConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSlackConnectorConfiguration o && Equals(o);
        }
    }
}
