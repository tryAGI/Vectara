#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// A JSON Schema definition that describes a data structure. Covers the smallest subset of JSON Schema that all LLM providers support. Unknown keywords are kept and passed through to the provider.<br/>
    /// `properties`, `required`, and `additionalProperties` are valid only when `type` is `object`. `enum`, `format`, `items`, and `anyOf` are valid for every other `type`, and for an element with no `type`, such as one that only combines schemas with `anyOf`.
    /// </summary>
    public readonly partial struct JsonSchemaDefinition : global::System.IEquatable<JsonSchemaDefinition>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.JsonSchemaDefinitionDiscriminatorType? Type { get; }

        /// <summary>
        /// A JSON Schema element with type `object`. This is the only form that can have `properties`, `required`, and `additionalProperties`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.JsonSchemaObject? ObjectValue { get; init; }
#else
        public global::Vectara.JsonSchemaObject? ObjectValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.JsonSchemaObject? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.JsonSchemaObject PickObjectValue() => IsObjectValue
            ? ObjectValue!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");

        /// <summary>
        /// A JSON Schema element for any type except `object`. Also used for an element with no `type`, such as an `anyOf` union. This form cannot have object keywords like `properties` or `additionalProperties`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.JsonSchemaValue? Array { get; init; }
#else
        public global::Vectara.JsonSchemaValue? Array { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Array))]
#endif
        public bool IsArray => Array != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vectara.JsonSchemaValue? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.JsonSchemaValue PickArray() => IsArray
            ? Array!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonSchemaDefinition(global::Vectara.JsonSchemaObject value) => new JsonSchemaDefinition((global::Vectara.JsonSchemaObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.JsonSchemaObject?(JsonSchemaDefinition @this) => @this.ObjectValue;

        /// <summary>
        /// 
        /// </summary>
        public JsonSchemaDefinition(global::Vectara.JsonSchemaObject? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonSchemaDefinition FromObjectValue(global::Vectara.JsonSchemaObject? value) => new JsonSchemaDefinition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonSchemaDefinition(global::Vectara.JsonSchemaValue value) => new JsonSchemaDefinition((global::Vectara.JsonSchemaValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.JsonSchemaValue?(JsonSchemaDefinition @this) => @this.Array;

        /// <summary>
        /// 
        /// </summary>
        public JsonSchemaDefinition(global::Vectara.JsonSchemaValue? value)
        {
            Array = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static JsonSchemaDefinition FromArray(global::Vectara.JsonSchemaValue? value) => new JsonSchemaDefinition(value);

        /// <summary>
        /// 
        /// </summary>
        public JsonSchemaDefinition(
            global::Vectara.JsonSchemaDefinitionDiscriminatorType? type,
            global::Vectara.JsonSchemaObject? objectValue,
            global::Vectara.JsonSchemaValue? array
            )
        {
            Type = type;

            ObjectValue = objectValue;
            Array = array;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Array as object ??
            ObjectValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ObjectValue?.ToString() ??
            Array?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsObjectValue && !IsArray || !IsObjectValue && IsArray;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.JsonSchemaObject?, TResult>? objectValue = null,
            global::System.Func<global::Vectara.JsonSchemaValue?, TResult>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }
            else if (IsArray && array != null)
            {
                return array(Array!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.JsonSchemaObject?>? objectValue = null,

            global::System.Action<global::Vectara.JsonSchemaValue?>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vectara.JsonSchemaObject?>? objectValue = null,
            global::System.Action<global::Vectara.JsonSchemaValue?>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObjectValue,
                typeof(global::Vectara.JsonSchemaObject),
                Array,
                typeof(global::Vectara.JsonSchemaValue),
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
        public bool Equals(JsonSchemaDefinition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.JsonSchemaObject?>.Default.Equals(ObjectValue, other.ObjectValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.JsonSchemaValue?>.Default.Equals(Array, other.Array) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonSchemaDefinition obj1, JsonSchemaDefinition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonSchemaDefinition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonSchemaDefinition obj1, JsonSchemaDefinition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonSchemaDefinition o && Equals(o);
        }
    }
}
