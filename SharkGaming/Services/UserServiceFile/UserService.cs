using SharkGaming.MockData;
using SharkGaming.Services.JsonServiceFile;
using SharkGaming.Users;

namespace SharkGaming.Services.UserServiceFile
{
    public class UserService
    {

        public List<User> _users { get; set; }

        //private JsonService JsonService { get; set; }

        public UserService()
        {
            _users = MockUser.GetMockUser();
        }

        //public UserService(JsonService jsonService)
        //{
        //    //_users = Json
        //}

    }
}
