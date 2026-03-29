# List Generation Presets



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

ListGenerationPresetsResponse response = await client.GenerationPresets.ListGenerationPresetsAsync();

foreach (var preset in response.GenerationPresets ?? [])
{
    Console.WriteLine($"Preset: {preset.Name}");
    Console.WriteLine($"  Description: {preset.Description}");
    Console.WriteLine();
}
```