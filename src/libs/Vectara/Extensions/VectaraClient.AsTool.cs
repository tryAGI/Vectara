#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace Vectara;

/// <summary>
/// Extensions for using VectaraClient as MEAI tools with any IChatClient.
/// </summary>
public static class VectaraToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that performs RAG (Retrieval-Augmented Generation)
    /// queries across specified corpora. Returns search results with an AI-generated summary.
    /// </summary>
    /// <param name="client">The Vectara client to use.</param>
    /// <param name="corpusKeys">Corpus keys to search. If empty, the caller must provide them.</param>
    /// <param name="maxResults">Maximum number of search results used for generation (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsSearchTool(
        this VectaraClient client,
        string[] corpusKeys,
        int maxResults = 5)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(corpusKeys);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.Queries.QueryAsync(
                    query: query,
                    search: new SearchCorporaParameters
                    {
                        Value1 = new SearchCorporaParametersVariant1
                        {
                            Corpora = corpusKeys.Select(key => new KeyedSearchCorpus
                            {
                                Value2 = new KeyedSearchCorpusVariant2
                                {
                                    CorpusKey = key,
                                },
                            }).ToList(),
                        },
                    },
                    generation: new GenerationParameters
                    {
                        MaxUsedSearchResults = maxResults,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatQueryResponse(response);
            },
            name: "SearchCorpora",
            description: "Searches Vectara corpora using RAG (Retrieval-Augmented Generation). Returns an AI-generated summary and ranked search results from the specified document collections.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available corpora (document collections)
    /// in the Vectara account.
    /// </summary>
    /// <param name="client">The Vectara client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListCorporaTool(this VectaraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Corpora.ListCorporaAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCorporaResponse(response);
            },
            name: "ListCorpora",
            description: "Lists available Vectara corpora (document collections). Returns corpus keys, names, and descriptions.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available large language models
    /// for use in RAG generation.
    /// </summary>
    /// <param name="client">The Vectara client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListLLMsTool(this VectaraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.LargeLanguageModels.ListLLMsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatLlmsResponse(response);
            },
            name: "ListLLMs",
            description: "Lists available large language models in Vectara for text summarization, chat, and other generation tasks.");
    }

    private static string FormatQueryResponse(QueryFullResponse response)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(response.Summary))
        {
            parts.Add($"Summary: {response.Summary}");
        }

        if (response.FactualConsistencyScore is { } score)
        {
            parts.Add($"Factual Consistency Score: {score:F2}");
        }

        if (response.SearchResults is { Count: > 0 })
        {
            parts.Add("Search Results:");
            foreach (var result in response.SearchResults)
            {
                var entry = $"- [Score: {result.Score:F3}]";
                if (!string.IsNullOrWhiteSpace(result.CorpusKey))
                {
                    entry += $" (Corpus: {result.CorpusKey})";
                }

                if (!string.IsNullOrWhiteSpace(result.Text))
                {
                    entry += $": {result.Text}";
                }

                parts.Add(entry);
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatCorporaResponse(ListCorporaResponse response)
    {
        var parts = new List<string>();

        if (response.Corpora is { Count: > 0 })
        {
            foreach (var corpus in response.Corpora)
            {
                var entry = $"- {corpus.Key}: {corpus.Name}";
                if (!string.IsNullOrWhiteSpace(corpus.Description))
                {
                    entry += $" — {corpus.Description}";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No corpora found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatLlmsResponse(ListLLMsResponse response)
    {
        var parts = new List<string>();

        if (response.Llms is { Count: > 0 })
        {
            foreach (var llm in response.Llms)
            {
                var entry = $"- {llm.Name}";
                if (!string.IsNullOrWhiteSpace(llm.Description))
                {
                    entry += $": {llm.Description}";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No LLMs found.");
        }

        return string.Join("\n", parts);
    }
}
