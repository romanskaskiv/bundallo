using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop.Classes
{
    public class Haircut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Haircut() { }
        public Haircut(int id, string name, int price) {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
