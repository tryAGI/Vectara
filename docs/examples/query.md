# Query



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

// First, list available corpora to get a corpus key.
ListCorporaResponse corporaResponse = await client.Corpora.ListCorporaAsync();

if (corporaResponse.Corpora is not { Count: > 0 })
{
    return;
}

var corpusKey = corporaResponse.Corpora[0].Key!;

// Execute a query with generation (RAG) against the corpus.
QueryFullResponse response = await client.Queries.QueryAsync(
    query: "What is this about?",
    search: new SearchCorporaParameters
    {
        Value1 = new SearchCorporaParametersVariant1
        {
            Corpora =
            [
                new KeyedSearchCorpus
                {
                    Value2 = new KeyedSearchCorpusVariant2
                    {
                        CorpusKey = corpusKey,
                    },
                },
            ],
        },
    },
    generation: new GenerationParameters
    {
        MaxUsedSearchResults = 5,
    });

Console.WriteLine($"Summary: {response.Summary}");

foreach (var result in response.SearchResults ?? [])
{
    Console.WriteLine($"  Score: {result.Score}, Text: {result.Text?[..Math.Min(80, result.Text.Length)]}...");
}
```