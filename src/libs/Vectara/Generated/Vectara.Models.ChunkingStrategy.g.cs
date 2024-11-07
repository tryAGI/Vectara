using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vectara
{
    /// <summary>
    /// (Optional) Choose how to split documents into chunks during indexing. If you do not set a chunking strategy,<br/>
    /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
    /// </summary>
    public readonly partial struct ChunkingStrategy : global::System.IEquatable<ChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vectara.ChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// Sets a chunking strategy that limits the number of maximum characters per chunk.<br/>
        /// The chunks do not cross section boundaries.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vectara.MaxCharsChunkingStrategy? MaxCharsChunkingStrategy { get; init; }
#else
        public global::Vectara.MaxCharsChunkingStrategy? MaxCharsChunkingStrategy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxCharsChunkingStrategy))]
#endif
        public bool IsMaxCharsChunkingStrategy => MaxCharsChunkingStrategy != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChunkingStrategy(global::Vectara.MaxCharsChunkingStrategy value) => new ChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vectara.MaxCharsChunkingStrategy?(ChunkingStrategy @this) => @this.MaxCharsChunkingStrategy;

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategy(global::Vectara.MaxCharsChunkingStrategy? value)
        {
            MaxCharsChunkingStrategy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChunkingStrategy(
            global::Vectara.ChunkingStrategyDiscriminatorType? type,
            global::Vectara.MaxCharsChunkingStrategy? maxCharsChunkingStrategy
            )
        {
            Type = type;

            MaxCharsChunkingStrategy = maxCharsChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MaxCharsChunkingStrategy as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMaxCharsChunkingStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vectara.MaxCharsChunkingStrategy?, TResult>? maxCharsChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaxCharsChunkingStrategy && maxCharsChunkingStrategy != null)
            {
                return maxCharsChunkingStrategy(MaxCharsChunkingStrategy!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vectara.MaxCharsChunkingStrategy?>? maxCharsChunkingStrategy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMaxCharsChunkingStrategy)
            {
                maxCharsChunkingStrategy?.Invoke(MaxCharsChunkingStrategy!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MaxCharsChunkingStrategy,
                typeof(global::Vectara.MaxCharsChunkingStrategy),
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
        public bool Equals(ChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vectara.MaxCharsChunkingStrategy?>.Default.Equals(MaxCharsChunkingStrategy, other.MaxCharsChunkingStrategy) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChunkingStrategy obj1, ChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChunkingStrategy obj1, ChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunkingStrategy o && Equals(o);
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
        public static global::Vectara.ChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Vectara.ChunkingStrategy),
                jsonSerializerContext) as global::Vectara.ChunkingStrategy?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Vectara.ChunkingStrategy? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Vectara.ChunkingStrategy>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::Vectara.ChunkingStrategy?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::Vectara.ChunkingStrategy),
                jsonSerializerContext).ConfigureAwait(false)) as global::Vectara.ChunkingStrategy?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::Vectara.ChunkingStrategy?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::Vectara.ChunkingStrategy?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
