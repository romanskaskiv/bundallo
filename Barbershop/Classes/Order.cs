using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop.Classes
{
    public class Order
    {
        public int Id { get; set; }
        public string NicknameUser { get; set; }
        public string NicknameBarber { get; set; }
        public TimeOnly Time { get; set; }
        public int IdHaircut { get; set; }
        public Order(int id, string nicknameUser, string nicknameBarber, TimeOnly time, int idHaircut) {
            Id = id;
            NicknameUser = nicknameUser;
            NicknameBarber = nicknameBarber;
            Time = time;
            IdHaircut = idHaircut;
        }
        public Order() { }
    }
}

