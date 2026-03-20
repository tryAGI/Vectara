# List LLMs



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

ListLLMsResponse response = await client.LargeLanguageModels.ListLLMsAsync();

foreach (var llm in response.Llms ?? [])
{
    Console.WriteLine($"LLM: {llm.Name} (ID: {llm.Id})");
    Console.WriteLine($"  Description: {llm.Description}");
    Console.WriteLine();
}
```