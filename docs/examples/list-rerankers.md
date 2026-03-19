# List Rerankers



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

ListRerankersResponse response = await client.Rerankers.ListRerankersAsync();

foreach (var reranker in response.Rerankers ?? [])
{
    Console.WriteLine(reranker.Name);
}
```