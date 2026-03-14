#nullable enable

namespace Vectara
{
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.Models.AgentSkills.Json.g.cs
    public sealed partial class AgentSkills
========
    public readonly partial struct AgentEvent
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.Models.AgentEvent.Json.g.cs
    {
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
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.Models.AgentSkills.Json.g.cs
        public static global::Vectara.AgentSkills? FromJson(
========
        public static global::Vectara.AgentEvent? FromJson(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.Models.AgentEvent.Json.g.cs
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.Models.AgentSkills.Json.g.cs
                typeof(global::Vectara.AgentSkills),
                jsonSerializerContext) as global::Vectara.AgentSkills;
========
                typeof(global::Vectara.AgentEvent),
                jsonSerializerContext) as global::Vectara.AgentEvent?;
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.Models.AgentEvent.Json.g.cs
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.Models.AgentSkills.Json.g.cs
        public static global::Vectara.AgentSkills? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Vectara.AgentSkills>(
========
        public static global::Vectara.AgentEvent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Vectara.AgentEvent>(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.Models.AgentEvent.Json.g.cs
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.Models.AgentSkills.Json.g.cs
        public static async global::System.Threading.Tasks.ValueTask<global::Vectara.AgentSkills?> FromJsonStreamAsync(
========
        public static async global::System.Threading.Tasks.ValueTask<global::Vectara.AgentEvent?> FromJsonStreamAsync(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.Models.AgentEvent.Json.g.cs
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.Models.AgentSkills.Json.g.cs
                typeof(global::Vectara.AgentSkills),
                jsonSerializerContext).ConfigureAwait(false)) as global::Vectara.AgentSkills;
========
                typeof(global::Vectara.AgentEvent),
                jsonSerializerContext).ConfigureAwait(false)) as global::Vectara.AgentEvent?;
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.Models.AgentEvent.Json.g.cs
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
<<<<<<<< HEAD:src/libs/Vectara/Generated/Vectara.Models.AgentSkills.Json.g.cs
        public static global::System.Threading.Tasks.ValueTask<global::Vectara.AgentSkills?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::Vectara.AgentSkills?>(
========
        public static global::System.Threading.Tasks.ValueTask<global::Vectara.AgentEvent?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::Vectara.AgentEvent?>(
>>>>>>>> 28f6600 (Remove FixOpenApiSpec and regenerate with AutoSDK 0.29.1-dev.32):src/libs/Vectara/Generated/Vectara.Models.AgentEvent.Json.g.cs
                jsonStream,
                jsonSerializerOptions);
        }
    }
}
