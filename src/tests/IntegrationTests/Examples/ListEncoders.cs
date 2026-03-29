/*
order: 40
title: List Encoders
slug: list-encoders
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Retrieve the list of text encoders available in Vectara for embedding documents.

    [TestMethod]
    public async Task Example_ListEncoders()
    {
        using var client = GetAuthenticatedClient();

        ListEncodersResponse response = await client.Encoders.ListEncodersAsync();

        response.Should().NotBeNull();
        response.Encoders.Should().NotBeNull();
        response.Encoders.Should().NotBeNullOrEmpty();

        foreach (var encoder in response.Encoders ?? [])
        {
            Console.WriteLine($"Encoder: {encoder.Name} (ID: {encoder.Id})");
            Console.WriteLine($"  Description: {encoder.Description}");
            Console.WriteLine();
        }
    }
}
