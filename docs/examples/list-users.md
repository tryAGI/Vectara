# List Users



This example assumes `using Vectara;` is in scope and `apiKey` contains your Vectara API key.

```csharp
using var client = new VectaraClient(apiKey);

ListUsersResponse response = await client.Users.ListUsersAsync();

foreach (var user in response.Users ?? [])
{
    Console.WriteLine($"User: {user.Email} (ID: {user.Id})");
}
```