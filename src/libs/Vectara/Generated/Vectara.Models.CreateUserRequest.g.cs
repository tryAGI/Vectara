
#nullable enable

namespace Vectara
{
    /// <summary>
    /// Request to create a new user account in the system.
    /// </summary>
    public sealed partial class CreateUserRequest
    {
        /// <summary>
        /// The email address for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// The username for the user. The value defaults to the email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The description of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The role names assigned to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::Vectara.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// The email address for the user.
        /// </param>
        /// <param name="username">
        /// The username for the user. The value defaults to the email.
        /// </param>
        /// <param name="description">
        /// The description of the user.
        /// </param>
        /// <param name="apiRoles">
        /// The role names assigned to the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUserRequest(
            string email,
            string? username,
            string? description,
            global::System.Collections.Generic.IList<global::Vectara.ApiRole>? apiRoles)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username;
            this.Description = description;
            this.ApiRoles = apiRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        public CreateUserRequest()
        {
        }
    }
}