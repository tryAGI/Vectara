# List Corpora



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

ListCorporaResponse response = await client.Corpora.ListCorporaAsync();

foreach (var corpus in response.Corpora ?? [])
{
    Console.WriteLine($"Corpus: {corpus.Name} (Key: {corpus.Key})");
    Console.WriteLine($"  Description: {corpus.Description}");
    Console.WriteLine();
}
```