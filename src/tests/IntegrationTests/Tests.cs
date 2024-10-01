namespace Vectara.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static VectaraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("VECTARA_API_KEY") ??
            throw new AssertInconclusiveException("VECTARA_API_KEY environment variable is not found.");

        var client = new VectaraClient(apiKey);
        
        return client;
    }
}
