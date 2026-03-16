```csharp
using var client = new VectaraClient(apiKey);

ListRerankersResponse response = await client.Rerankers.ListRerankersAsync();

foreach (var reranker in response.Rerankers ?? [])
{
    Console.WriteLine(reranker.Name);
}
```