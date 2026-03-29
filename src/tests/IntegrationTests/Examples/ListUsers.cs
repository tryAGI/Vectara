/*
order: 60
title: List Users
slug: list-users
*/

namespace Vectara.IntegrationTests;

public partial class Tests
{
    //// Retrieve the list of users in your Vectara account.

    [TestMethod]
    public async Task Example_ListUsers()
    {
        using var client = GetAuthenticatedClient();

        ListUsersResponse response = await client.Users.ListAsync();

        response.Should().NotBeNull();
        response.Users.Should().NotBeNull();
        response.Users.Should().NotBeNullOrEmpty();

        foreach (var user in response.Users ?? [])
        {
            Console.WriteLine($"User: {user.Email} (ID: {user.Id})");
        }
    }
}
