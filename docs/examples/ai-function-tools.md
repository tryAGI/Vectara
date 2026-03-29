# AI Function Tools



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

// Create AI function tools from the Vectara client.
// These can be passed to any IChatClient's ChatOptions.Tools.

// First, get a corpus key to configure the search tool.
ListCorporaResponse corporaResponse = await client.Corpora.ListCorporaAsync();

if (corporaResponse.Corpora is not { Count: > 0 })
{
    return;
}

var corpusKeys = corporaResponse.Corpora
    .Select(c => c.Key!)
    .ToArray();

// The search tool performs RAG queries across your corpora.
var searchTool = client.AsSearchTool(corpusKeys: corpusKeys, maxResults: 3);

// The list corpora tool discovers available document collections.
var listCorporaTool = client.AsListCorporaTool();

// The list LLMs tool shows available models for generation.
var listLlmsTool = client.AsListLLMsTool();

Console.WriteLine($"Created {3} AI function tools:");
Console.WriteLine($"  - {searchTool.Name}: {searchTool.Description}");
Console.WriteLine($"  - {listCorporaTool.Name}: {listCorporaTool.Description}");
Console.WriteLine($"  - {listLlmsTool.Name}: {listLlmsTool.Description}");
```