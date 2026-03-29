/*
order: 70
title: List Generation Presets
slug: list-generation-presets
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Retrieve the list of available generation presets that control
    //// the behavior of AI-generated summaries in RAG queries.

    [TestMethod]
    public async Task Example_ListGenerationPresets()
    {
        using var client = GetAuthenticatedClient();

        ListGenerationPresetsResponse response = await client.GenerationPresets.ListGenerationPresetsAsync();

        response.Should().NotBeNull();
        response.GenerationPresets.Should().NotBeNull();

        foreach (var preset in response.GenerationPresets ?? [])
        {
            Console.WriteLine($"Preset: {preset.Name}");
            Console.WriteLine($"  Description: {preset.Description}");
            Console.WriteLine();
        }
    }
}
