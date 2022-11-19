using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bundallo
{
    public class User
    {
        [Key]
        [Column("nickname")]
        public string Nickname { get; set; }

        [Column("is_admin")]
        public bool IsAdmin { get; set; }
        
        [Column("firstname")]
        public string FirstName { get; set; }
        
        [Column("lastname")]
        public string LastName { get; set; }
        
        [Column("password")]
        public string Password { get; set; }
        
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