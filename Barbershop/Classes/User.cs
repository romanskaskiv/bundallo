using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop.Classes
{
    public class User {
        [Key]
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Password { get; set; }
        public int IsBarber { get; set; }
        public User() {

        }
        public User(string nickname, string firstName, string secondName, string password, int isBarber) {
            Nickname = nickname;
            FirstName = firstName;
            SecondName = secondName;
            Password = password;
            IsBarber = isBarber;
        }
    }
}
