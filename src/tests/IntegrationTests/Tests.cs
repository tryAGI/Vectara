namespace Vectara.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static VectaraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("VECTARA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("VECTARA_API_KEY environment variable is not found.");

        var client = new VectaraClient(apiKey);
        
        return client;
    }
}
