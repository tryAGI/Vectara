/*
order: 20
title: List Corpora
slug: list-corpora
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Retrieve a list of corpora (document collections) in your Vectara account.

    [TestMethod]
    public async Task Example_ListCorpora()
    {
        using var client = GetAuthenticatedClient();

        ListCorporaResponse response = await client.Corpora.ListAsync();

        response.Should().NotBeNull();
        response.Corpora.Should().NotBeNull();

        foreach (var corpus in response.Corpora ?? [])
        {
            Console.WriteLine($"Corpus: {corpus.Name} (Key: {corpus.Key})");
            Console.WriteLine($"  Description: {corpus.Description}");
            Console.WriteLine();
        }
    }
}
