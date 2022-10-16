namespace bundallo
{
    public class User
    {
        public string Nickname;
        public bool IsAdmin;
        public string FirstName;
        public string LastName;
        public string Password;
        
        public User()
        {
        }

        public User(string nickname, bool isAdmin, string firstName, string lastName, string password)
        {
            Nickname = nickname;
            IsAdmin = isAdmin;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }
    }
}