#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Read view of a web widget connector's configuration.<br/>
    /// Every field is served to anonymous visitors by the unauthenticated widget bootstrap endpoint.<br/>
    /// Includes the platform-derived `bootstrap_path` the embed snippet calls.<br/>
    /// Widget connectors ignore the base `hidden_output_types`; end-user event visibility is controlled by `revealed_output_types`.
    /// </summary>
    public readonly partial struct WidgetConnectorConfiguration : global::System.IEquatable<WidgetConnectorConfiguration>
    {
        /// <summary>
        /// Properties shared by every connector configuration read view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.ConnectorConfigurationBase? Base { get; init; }
#else
        public global::Vectara.ConnectorConfigurationBase? Base { get; }
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
            out global::Vectara.ConnectorConfigurationBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.ConnectorConfigurationBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.WidgetConnectorConfigurationVariant2? WidgetConnectorConfigurationVariant2 { get; init; }
#else
        public global::Vectara.WidgetConnectorConfigurationVariant2? WidgetConnectorConfigurationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WidgetConnectorConfigurationVariant2))]
#endif
        public bool IsWidgetConnectorConfigurationVariant2 => WidgetConnectorConfigurationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWidgetConnectorConfigurationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.WidgetConnectorConfigurationVariant2? value)
        {
            value = WidgetConnectorConfigurationVariant2;
            return IsWidgetConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.WidgetConnectorConfigurationVariant2 PickWidgetConnectorConfigurationVariant2() => IsWidgetConnectorConfigurationVariant2
            ? WidgetConnectorConfigurationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WidgetConnectorConfigurationVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WidgetConnectorConfiguration(global::Vectara.ConnectorConfigurationBase value) => new WidgetConnectorConfiguration((global::Vectara.ConnectorConfigurationBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.ConnectorConfigurationBase?(WidgetConnectorConfiguration @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public WidgetConnectorConfiguration(global::Vectara.ConnectorConfigurationBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WidgetConnectorConfiguration FromBase(global::Vectara.ConnectorConfigurationBase? value) => new WidgetConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WidgetConnectorConfiguration(global::Vectara.WidgetConnectorConfigurationVariant2 value) => new WidgetConnectorConfiguration((global::Vectara.WidgetConnectorConfigurationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.WidgetConnectorConfigurationVariant2?(WidgetConnectorConfiguration @this) => @this.WidgetConnectorConfigurationVariant2;

        /// <summary>
        ///
        /// </summary>
        public WidgetConnectorConfiguration(global::Vectara.WidgetConnectorConfigurationVariant2? value)
        {
            WidgetConnectorConfigurationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WidgetConnectorConfiguration FromWidgetConnectorConfigurationVariant2(global::Vectara.WidgetConnectorConfigurationVariant2? value) => new WidgetConnectorConfiguration(value);

        /// <summary>
        ///
        /// </summary>
        public WidgetConnectorConfiguration(
            global::Vectara.ConnectorConfigurationBase? @base,
            global::Vectara.WidgetConnectorConfigurationVariant2? widgetConnectorConfigurationVariant2
            )
        {
            Base = @base;
            WidgetConnectorConfigurationVariant2 = widgetConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WidgetConnectorConfigurationVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            WidgetConnectorConfigurationVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsWidgetConnectorConfigurationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.ConnectorConfigurationBase, TResult>? @base = null,
            global::System.Func<global::Vectara.WidgetConnectorConfigurationVariant2, TResult>? widgetConnectorConfigurationVariant2 = null,
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
            else if (IsWidgetConnectorConfigurationVariant2 && widgetConnectorConfigurationVariant2 != null)
            {
                return widgetConnectorConfigurationVariant2(WidgetConnectorConfigurationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,

            global::System.Action<global::Vectara.WidgetConnectorConfigurationVariant2>? widgetConnectorConfigurationVariant2 = null,
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
            else if (IsWidgetConnectorConfigurationVariant2)
            {
                widgetConnectorConfigurationVariant2?.Invoke(WidgetConnectorConfigurationVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.ConnectorConfigurationBase>? @base = null,
            global::System.Action<global::Vectara.WidgetConnectorConfigurationVariant2>? widgetConnectorConfigurationVariant2 = null,
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
            else if (IsWidgetConnectorConfigurationVariant2)
            {
                widgetConnectorConfigurationVariant2?.Invoke(WidgetConnectorConfigurationVariant2!);
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
                typeof(global::Vectara.ConnectorConfigurationBase),
                WidgetConnectorConfigurationVariant2,
                typeof(global::Vectara.WidgetConnectorConfigurationVariant2),
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
        public bool Equals(WidgetConnectorConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.ConnectorConfigurationBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.WidgetConnectorConfigurationVariant2?>.Default.Equals(WidgetConnectorConfigurationVariant2, other.WidgetConnectorConfigurationVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WidgetConnectorConfiguration obj1, WidgetConnectorConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WidgetConnectorConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WidgetConnectorConfiguration obj1, WidgetConnectorConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WidgetConnectorConfiguration o && Equals(o);
        }
    }
}
