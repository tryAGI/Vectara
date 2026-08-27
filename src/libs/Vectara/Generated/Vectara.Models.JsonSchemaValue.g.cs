#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A JSON Schema element for any type except `object`. Also used for an element with no `type`, such as an `anyOf` union. This form cannot have object keywords like `properties` or `additionalProperties`.
    /// </summary>
    public readonly partial struct JsonSchemaValue : global::System.IEquatable<JsonSchemaValue>
    {
        /// <summary>
        /// Keywords shared by every JSON Schema element.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.JsonSchemaBase? Base { get; init; }
#else
        public global::Vectara.JsonSchemaBase? Base { get; }
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
            out global::Vectara.JsonSchemaBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.JsonSchemaValueVariant2? JsonSchemaValueVariant2 { get; init; }
#else
        public global::Vectara.JsonSchemaValueVariant2? JsonSchemaValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchemaValueVariant2))]
#endif
        public bool IsJsonSchemaValueVariant2 => JsonSchemaValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJsonSchemaValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.JsonSchemaValueVariant2? value)
        {
            value = JsonSchemaValueVariant2;
            return IsJsonSchemaValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vectara.JsonSchemaValueVariant2 PickJsonSchemaValueVariant2() => IsJsonSchemaValueVariant2
            ? JsonSchemaValueVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchemaValueVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonSchemaValue(global::Vectara.JsonSchemaBase value) => new JsonSchemaValue((global::Vectara.JsonSchemaBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.JsonSchemaBase?(JsonSchemaValue @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public JsonSchemaValue(global::Vectara.JsonSchemaBase? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonSchemaValue FromBase(global::Vectara.JsonSchemaBase? value) => new JsonSchemaValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator JsonSchemaValue(global::Vectara.JsonSchemaValueVariant2 value) => new JsonSchemaValue((global::Vectara.JsonSchemaValueVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vectara.JsonSchemaValueVariant2?(JsonSchemaValue @this) => @this.JsonSchemaValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public JsonSchemaValue(global::Vectara.JsonSchemaValueVariant2? value)
        {
            JsonSchemaValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JsonSchemaValue FromJsonSchemaValueVariant2(global::Vectara.JsonSchemaValueVariant2? value) => new JsonSchemaValue(value);

        /// <summary>
        ///
        /// </summary>
        public JsonSchemaValue(
            global::Vectara.JsonSchemaBase? @base,
            global::Vectara.JsonSchemaValueVariant2? jsonSchemaValueVariant2
            )
        {
            Base = @base;
            JsonSchemaValueVariant2 = jsonSchemaValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JsonSchemaValueVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            JsonSchemaValueVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsJsonSchemaValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.JsonSchemaBase, TResult>? @base = null,
            global::System.Func<global::Vectara.JsonSchemaValueVariant2, TResult>? jsonSchemaValueVariant2 = null,
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
            else if (IsJsonSchemaValueVariant2 && jsonSchemaValueVariant2 != null)
            {
                return jsonSchemaValueVariant2(JsonSchemaValueVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.JsonSchemaBase>? @base = null,

            global::System.Action<global::Vectara.JsonSchemaValueVariant2>? jsonSchemaValueVariant2 = null,
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
            else if (IsJsonSchemaValueVariant2)
            {
                jsonSchemaValueVariant2?.Invoke(JsonSchemaValueVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.JsonSchemaBase>? @base = null,
            global::System.Action<global::Vectara.JsonSchemaValueVariant2>? jsonSchemaValueVariant2 = null,
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
            else if (IsJsonSchemaValueVariant2)
            {
                jsonSchemaValueVariant2?.Invoke(JsonSchemaValueVariant2!);
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
                typeof(global::Vectara.JsonSchemaBase),
                JsonSchemaValueVariant2,
                typeof(global::Vectara.JsonSchemaValueVariant2),
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
        public bool Equals(JsonSchemaValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.JsonSchemaBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.JsonSchemaValueVariant2?>.Default.Equals(JsonSchemaValueVariant2, other.JsonSchemaValueVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(JsonSchemaValue obj1, JsonSchemaValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonSchemaValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(JsonSchemaValue obj1, JsonSchemaValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonSchemaValue o && Equals(o);
        }
    }
}
