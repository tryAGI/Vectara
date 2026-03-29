/*
order: 30
title: List LLMs
slug: list-llms
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Retrieve the list of large language models available in Vectara
    //// for use in RAG (Retrieval-Augmented Generation) queries.

    [TestMethod]
    public async Task Example_ListLLMs()
    {
        using var client = GetAuthenticatedClient();

        ListLLMsResponse response = await client.Llms.ListAsync();

        response.Should().NotBeNull();
        response.Llms.Should().NotBeNull();
        response.Llms.Should().NotBeNullOrEmpty();

        foreach (var llm in response.Llms ?? [])
        {
            Console.WriteLine($"LLM: {llm.Name} (ID: {llm.Id})");
            Console.WriteLine($"  Description: {llm.Description}");
            Console.WriteLine();
        }
    }
}
