/*
order: 50
title: Query
slug: query
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Run a RAG (Retrieval-Augmented Generation) query across your corpora.
    //// This searches for relevant documents and generates an AI-powered summary.

    [TestMethod]
    public async Task Example_Query()
    {
        using var client = GetAuthenticatedClient();

        //// First, list available corpora to get a corpus key.
        ListCorporaResponse corporaResponse = await client.Corpora.ListAsync();

        corporaResponse.Should().NotBeNull();
        corporaResponse.Corpora.Should().NotBeNull();

        if (corporaResponse.Corpora is not { Count: > 0 })
        {
            Assert.Inconclusive("No corpora available to query.");
            return;
        }

        var corpusKey = corporaResponse.Corpora[0].Key!;

        //// Execute a query with generation (RAG) against the corpus.
        QueryFullResponse response = await client.Queries.Query2Async(
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

        response.Should().NotBeNull();
        Console.WriteLine($"Summary: {response.Summary}");

        foreach (var result in response.SearchResults ?? [])
        {
            Console.WriteLine($"  Score: {result.Score}, Text: {result.Text?[..Math.Min(80, result.Text.Length)]}...");
        }
    }
}
