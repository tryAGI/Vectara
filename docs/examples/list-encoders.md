# List Encoders



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

ListEncodersResponse response = await client.Encoders.ListEncodersAsync();

foreach (var encoder in response.Encoders ?? [])
{
    Console.WriteLine($"Encoder: {encoder.Name} (ID: {encoder.Id})");
    Console.WriteLine($"  Description: {encoder.Description}");
    Console.WriteLine();
}
```