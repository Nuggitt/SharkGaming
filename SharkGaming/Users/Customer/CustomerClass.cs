namespace SharkGaming.Users.Customer
{
    public class CustomerClass : UserClass
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Postcode { get; set; }
        public string Country { get; set; }

        public CustomerClass()
        {

        }

        public CustomerClass(string phone, string email, string address, int postcode, string country, string username, string password) 
            : base(username, password)
        {
            Email = email;
            Address = address;
            Postcode = postcode;
            Country = country;
        }
    }
}
