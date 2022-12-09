using SharkGaming.MockData;
using SharkGaming.Services.JsonServiceFile;
using SharkGaming.Users;

namespace SharkGaming.Services.UserServiceFile
{
    public class UserService
    {

        public List<User> Users { get; set; }

        private JsonService jsonService { get; set; }

        public UserService(JsonService jsonService)
        {
            Users = MockData.MockUser.GetMockUser();
        }

    }
}
