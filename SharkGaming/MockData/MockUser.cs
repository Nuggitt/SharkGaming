using Microsoft.AspNetCore.Identity;
using SharkGaming.Users;

namespace SharkGaming.MockData
{
    public class MockUser
    {

        private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

        private static List<User> users = new List<User>() {
            new User("admin", passwordHasher.HashPassword(null, "1234")),
            new User("Phillip", passwordHasher.HashPassword(null, "123")),
            new User("mikkel", passwordHasher.HashPassword(null, "123")),
            new User("mille", passwordHasher.HashPassword(null, "123")),
            new User("canty", passwordHasher.HashPassword(null, "123"))
        };

        public static List<User> GetMockUser() { return users; }

    }
}
