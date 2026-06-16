#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Write view of a Google Chat connector's configuration. Supply the service<br/>
    /// account JSON key for the Chat app you have configured in the Google Cloud<br/>
    /// console. The Chat app's HTTP endpoint URL and Authentication audience must<br/>
    /// be set to the connector's audience_url (returned in the read view).
    /// </summary>
    public readonly partial struct CreateGchatConnectorConfiguration : global::System.IEquatable<CreateGchatConnectorConfiguration>
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
        public global::Vectara.CreateGchatConnectorConfigurationVariant2? CreateGchatConnectorConfigurationVariant2 { get; init; }
#else
        public global::Vectara.CreateGchatConnectorConfigurationVariant2? CreateGchatConnectorConfigurationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateGchatConnectorConfigurationVariant2))]
#endif
        public bool IsCreateGchatConnectorConfigurationVariant2 => CreateGchatConnectorConfigurationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateGchatConnectorConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.CreateGchatConnectorConfigurationVariant2? value)
        {
            value = CreateGchatConnectorConfigurationVariant2;
            return IsCreateGchatConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateGchatConnectorConfigurationVariant2 PickCreateGchatConnectorConfigurationVariant2() => IsCreateGchatConnectorConfigurationVariant2
            ? CreateGchatConnectorConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateGchatConnectorConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGchatConnectorConfiguration(global::Vectara.CreateConnectorConfigurationBase value) => new CreateGchatConnectorConfiguration((global::Vectara.CreateConnectorConfigurationBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateConnectorConfigurationBase?(CreateGchatConnectorConfiguration @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateGchatConnectorConfiguration(global::Vectara.CreateConnectorConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGchatConnectorConfiguration FromBase(global::Vectara.CreateConnectorConfigurationBase? value) => new CreateGchatConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateGchatConnectorConfiguration(global::Vectara.CreateGchatConnectorConfigurationVariant2 value) => new CreateGchatConnectorConfiguration((global::Vectara.CreateGchatConnectorConfigurationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CreateGchatConnectorConfigurationVariant2?(CreateGchatConnectorConfiguration @this) => @this.CreateGchatConnectorConfigurationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateGchatConnectorConfiguration(global::Vectara.CreateGchatConnectorConfigurationVariant2? value)
        {
            CreateGchatConnectorConfigurationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateGchatConnectorConfiguration FromCreateGchatConnectorConfigurationVariant2(global::Vectara.CreateGchatConnectorConfigurationVariant2? value) => new CreateGchatConnectorConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateGchatConnectorConfiguration(
            global::Vectara.CreateConnectorConfigurationBase? @base,
            global::Vectara.CreateGchatConnectorConfigurationVariant2? createGchatConnectorConfigurationVariant2
            )
        {
            Base = @base;
            CreateGchatConnectorConfigurationVariant2 = createGchatConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateGchatConnectorConfigurationVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateGchatConnectorConfigurationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateGchatConnectorConfigurationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CreateConnectorConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.CreateGchatConnectorConfigurationVariant2, TResult>? createGchatConnectorConfigurationVariant2 = null,
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
            else if (IsCreateGchatConnectorConfigurationVariant2 && createGchatConnectorConfigurationVariant2 != null)
            {
                return createGchatConnectorConfigurationVariant2(CreateGchatConnectorConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CreateConnectorConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.CreateGchatConnectorConfigurationVariant2>? createGchatConnectorConfigurationVariant2 = null,
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
            else if (IsCreateGchatConnectorConfigurationVariant2)
            {
                createGchatConnectorConfigurationVariant2?.Invoke(CreateGchatConnectorConfigurationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.CreateConnectorConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.CreateGchatConnectorConfigurationVariant2>? createGchatConnectorConfigurationVariant2 = null,
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
            else if (IsCreateGchatConnectorConfigurationVariant2)
            {
                createGchatConnectorConfigurationVariant2?.Invoke(CreateGchatConnectorConfigurationVariant2!);
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
                CreateGchatConnectorConfigurationVariant2,
                typeof(global::Vectara.CreateGchatConnectorConfigurationVariant2),
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
        public bool Equals(CreateGchatConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateConnectorConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CreateGchatConnectorConfigurationVariant2?>.Default.Equals(CreateGchatConnectorConfigurationVariant2, other.CreateGchatConnectorConfigurationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateGchatConnectorConfiguration obj1, CreateGchatConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateGchatConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateGchatConnectorConfiguration obj1, CreateGchatConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateGchatConnectorConfiguration o && Equals(o);
        }
    }
}
