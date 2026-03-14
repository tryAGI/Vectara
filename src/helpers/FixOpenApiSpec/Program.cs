using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("openapi: 3.1.0", "openapi: 3.0.1")
        .Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.1\"")
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

if (openApiDocument.Components?.Schemas is { } schemas)
{
    foreach (var schema in schemas.Values)
    {
        var discriminatorProperty = schema.Discriminator?.PropertyName;
        if (string.IsNullOrWhiteSpace(discriminatorProperty))
        {
            continue;
        }

        schema.Required ??= new HashSet<string>(StringComparer.Ordinal);
        if (!schema.Required.Contains(discriminatorProperty))
        {
            schema.Required.Add(discriminatorProperty);
        }

        // AutoSDK 0.29.1-dev.30 generates the correct union shape for these wrappers
        // only when the redundant top-level discriminator property is removed.
        if (schema.OneOf.Count > 0 &&
            schema.Extensions.ContainsKey("x-vectara-base-schema") &&
            schema.Properties.Count == 1 &&
            schema.Properties.ContainsKey(discriminatorProperty))
        {
            schema.Properties.Remove(discriminatorProperty);
        }
    }
}

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
