#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A JSON Schema element with type `object`. This is the only form that can have `properties`, `required`, and `additionalProperties`.
    /// </summary>
    public readonly partial struct JsonSchemaObject : global::System.IEquatable<JsonSchemaObject>
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
        public global::Vectara.JsonSchemaObjectVariant2? JsonSchemaObjectVariant2 { get; init; }
#else
        public global::Vectara.JsonSchemaObjectVariant2? JsonSchemaObjectVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchemaObjectVariant2))]
#endif
        public bool IsJsonSchemaObjectVariant2 => JsonSchemaObjectVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickJsonSchemaObjectVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.JsonSchemaObjectVariant2? value)
        {
            value = JsonSchemaObjectVariant2;
            return IsJsonSchemaObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.JsonSchemaObjectVariant2 PickJsonSchemaObjectVariant2() => IsJsonSchemaObjectVariant2
            ? JsonSchemaObjectVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonSchemaObjectVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonSchemaObject(global::Vectara.JsonSchemaBase value) => new JsonSchemaObject((global::Vectara.JsonSchemaBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.JsonSchemaBase?(JsonSchemaObject @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public JsonSchemaObject(global::Vectara.JsonSchemaBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonSchemaObject FromBase(global::Vectara.JsonSchemaBase? value) => new JsonSchemaObject(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonSchemaObject(global::Vectara.JsonSchemaObjectVariant2 value) => new JsonSchemaObject((global::Vectara.JsonSchemaObjectVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.JsonSchemaObjectVariant2?(JsonSchemaObject @this) => @this.JsonSchemaObjectVariant2;

        /// <summary>
        /// 
        /// </summary>
        public JsonSchemaObject(global::Vectara.JsonSchemaObjectVariant2? value)
        {
            JsonSchemaObjectVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonSchemaObject FromJsonSchemaObjectVariant2(global::Vectara.JsonSchemaObjectVariant2? value) => new JsonSchemaObject(value);

        /// <summary>
        /// 
        /// </summary>
        public JsonSchemaObject(
            global::Vectara.JsonSchemaBase? @base,
            global::Vectara.JsonSchemaObjectVariant2? jsonSchemaObjectVariant2
            )
        {
            Base = @base;
            JsonSchemaObjectVariant2 = jsonSchemaObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonSchemaObjectVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            JsonSchemaObjectVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsJsonSchemaObjectVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.JsonSchemaBase, TResult>? @base = null,
            global::System.Func<global::Vectara.JsonSchemaObjectVariant2, TResult>? jsonSchemaObjectVariant2 = null,
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
            else if (IsJsonSchemaObjectVariant2 && jsonSchemaObjectVariant2 != null)
            {
                return jsonSchemaObjectVariant2(JsonSchemaObjectVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.JsonSchemaBase>? @base = null,

            global::System.Action<global::Vectara.JsonSchemaObjectVariant2>? jsonSchemaObjectVariant2 = null,
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
            else if (IsJsonSchemaObjectVariant2)
            {
                jsonSchemaObjectVariant2?.Invoke(JsonSchemaObjectVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.JsonSchemaBase>? @base = null,
            global::System.Action<global::Vectara.JsonSchemaObjectVariant2>? jsonSchemaObjectVariant2 = null,
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
            else if (IsJsonSchemaObjectVariant2)
            {
                jsonSchemaObjectVariant2?.Invoke(JsonSchemaObjectVariant2!);
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
                JsonSchemaObjectVariant2,
                typeof(global::Vectara.JsonSchemaObjectVariant2),
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
        public bool Equals(JsonSchemaObject other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.JsonSchemaBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.JsonSchemaObjectVariant2?>.Default.Equals(JsonSchemaObjectVariant2, other.JsonSchemaObjectVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonSchemaObject obj1, JsonSchemaObject obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonSchemaObject>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonSchemaObject obj1, JsonSchemaObject obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonSchemaObject o && Equals(o);
        }
    }
}
