/*
order: 80
title: AI Function Tools
slug: ai-function-tools
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Vectara provides MEAI AIFunction tools that can be used with any IChatClient.
    //// This enables AI agents to search your corpora, list document collections,
    //// and discover available LLMs.

    [TestMethod]
    public async Task Example_AiFunctionTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AI function tools from the Vectara client.
        //// These can be passed to any IChatClient's ChatOptions.Tools.

        //// First, get a corpus key to configure the search tool.
        ListCorporaResponse corporaResponse = await client.Corpora.ListAsync();

        corporaResponse.Should().NotBeNull();
        corporaResponse.Corpora.Should().NotBeNull();

        if (corporaResponse.Corpora is not { Count: > 0 })
        {
            Assert.Inconclusive("No corpora available.");
            return;
        }

        var corpusKeys = corporaResponse.Corpora
            .Select(c => c.Key!)
            .ToArray();

        //// The search tool performs RAG queries across your corpora.
        var searchTool = client.AsSearchTool(corpusKeys: corpusKeys, maxResults: 3);
        searchTool.Name.Should().Be("SearchCorpora");

        //// The list corpora tool discovers available document collections.
        var listCorporaTool = client.AsListCorporaTool();
        listCorporaTool.Name.Should().Be("ListCorpora");

        //// The list LLMs tool shows available models for generation.
        var listLlmsTool = client.AsListLLMsTool();
        listLlmsTool.Name.Should().Be("ListLLMs");

        Console.WriteLine($"Created {3} AI function tools:");
        Console.WriteLine($"  - {searchTool.Name}: {searchTool.Description}");
        Console.WriteLine($"  - {listCorporaTool.Name}: {listCorporaTool.Description}");
        Console.WriteLine($"  - {listLlmsTool.Name}: {listLlmsTool.Description}");
    }
}
