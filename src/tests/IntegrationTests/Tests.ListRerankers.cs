namespace Vectara.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListRerankers()
    {
        using var client = GetAuthenticatedClient();

        ListRerankersResponse response = await client.Rerankers.ListRerankersAsync();
        
        foreach (var reranker in response.Rerankers ?? [])
        {
            Console.WriteLine(reranker.Name);
        }
        
        response.Should().NotBeNull();
        response.Rerankers.Should().NotBeNull();
        response.Rerankers.Should().NotBeNullOrEmpty();
    }
}
