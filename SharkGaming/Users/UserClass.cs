namespace SharkGaming.Users
{
    public class UserClass
    {
        private int nextId = 0;
        protected int Id { get; set; }
        protected string Username { get; set; }
        protected string Password { get; set; }

        public UserClass()
        {

        }

        public UserClass(string username, string password)
        {
            Id = nextId++;
            Username = username;
            Password = password;
        }
    }
}
