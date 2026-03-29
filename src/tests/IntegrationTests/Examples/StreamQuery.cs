/*
order: 55
title: Stream Query
slug: stream-query
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Run a streaming RAG query that returns results incrementally.
    //// This is useful for showing real-time progress as search results
    //// arrive followed by generation chunks.

    [TestMethod]
    public async Task Example_StreamQuery()
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

        //// Execute a streaming query — results arrive as Server-Sent Events.
        var summaryBuilder = new System.Text.StringBuilder();
        var searchResultCount = 0;

        await foreach (var chunk in client.Queries.Query2AsStreamAsync(
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
            }))
        {
            //// Handle each event type in the stream.
            if (chunk.IsSearchResults)
            {
                searchResultCount = chunk.SearchResults?.SearchResults?.Count ?? 0;
                Console.WriteLine($"Received {searchResultCount} search results");
            }
            else if (chunk.IsGenerationChunk)
            {
                summaryBuilder.Append(chunk.GenerationChunk?.GenerationChunk);
            }
            else if (chunk.IsGenerationEnd)
            {
                Console.WriteLine($"Generation complete");
            }
            else if (chunk.IsFactualConsistencyScore)
            {
                Console.WriteLine($"Factual consistency: {chunk.FactualConsistencyScore?.FactualConsistencyScore1}");
            }
            else if (chunk.IsEnd)
            {
                Console.WriteLine("Stream ended");
            }
        }

        var summary = summaryBuilder.ToString();
        Console.WriteLine($"Summary: {summary}");
        Console.WriteLine($"Total search results: {searchResultCount}");
    }
}
