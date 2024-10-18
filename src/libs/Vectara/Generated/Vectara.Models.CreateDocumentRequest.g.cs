using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// Creating a document using this endpoint can take multiple forms depending on how much<br/>
    /// control of the resulting document parts you desire. You can create a document<br/>
    /// with natural structure, and Vectara will use it's proprietary strategy to create document parts.<br/>
    /// Otherwise, you can create a document with all the document parts explicitly specified.<br/>
    /// A document part is the a search result item in search and retrieval augmented generation endpoints.
    /// </summary>
    public readonly partial struct CreateDocumentRequest : global::System.IEquatable<CreateDocumentRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.CreateDocumentRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// The document structure that most closely corresponds to Vectara's internal document data model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.CoreDocument? Core { get; init; }
#else
        public global::Vectara.CoreDocument? Core { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Core))]
#endif
        public bool IsCore => Core != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateDocumentRequest(global::Vectara.CoreDocument value) => new CreateDocumentRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.CoreDocument?(CreateDocumentRequest @this) => @this.Core;

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentRequest(global::Vectara.CoreDocument? value)
        {
            Core = value;
        }

        /// <summary>
        /// A document with layout features.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.StructuredDocument? Structured { get; init; }
#else
        public global::Vectara.StructuredDocument? Structured { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Structured))]
#endif
        public bool IsStructured => Structured != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateDocumentRequest(global::Vectara.StructuredDocument value) => new CreateDocumentRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.StructuredDocument?(CreateDocumentRequest @this) => @this.Structured;

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentRequest(global::Vectara.StructuredDocument? value)
        {
            Structured = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateDocumentRequest(
            global::Vectara.CreateDocumentRequestDiscriminatorType? type,
            global::Vectara.CoreDocument? core,
            global::Vectara.StructuredDocument? structured
            )
        {
            Type = type;

            Core = core;
            Structured = structured;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Structured as object ??
            Core as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCore && !IsStructured || !IsCore && IsStructured;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.CoreDocument?, TResult>? core = null,
            global::System.Func<global::Vectara.StructuredDocument?, TResult>? structured = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCore && core != null)
            {
                return core(Core!);
            }
            else if (IsStructured && structured != null)
            {
                return structured(Structured!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.CoreDocument?>? core = null,
            global::System.Action<global::Vectara.StructuredDocument?>? structured = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCore)
            {
                core?.Invoke(Core!);
            }
            else if (IsStructured)
            {
                structured?.Invoke(Structured!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Core,
                typeof(global::Vectara.CoreDocument),
                Structured,
                typeof(global::Vectara.StructuredDocument),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CreateDocumentRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.CoreDocument?>.Default.Equals(Core, other.Core) &&
                global::System.Collections.Generic.EqualityComparer<global::Vectara.StructuredDocument?>.Default.Equals(Structured, other.Structured) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateDocumentRequest obj1, CreateDocumentRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateDocumentRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateDocumentRequest obj1, CreateDocumentRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateDocumentRequest o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Vectara.CreateDocumentRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Vectara.CreateDocumentRequest),
                jsonSerializerContext) as global::Vectara.CreateDocumentRequest?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Vectara.CreateDocumentRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Vectara.CreateDocumentRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}
