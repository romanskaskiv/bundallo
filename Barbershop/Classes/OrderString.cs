using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop.Classes
{
    public class OrderString
    {
        public string BarberName { get; set; }
        public TimeOnly Time { get; set; }
        public string HaircutName { get; set; }
        public int HaircutPrice { get; set; }
        public OrderString() { }
        public OrderString(string barberName, TimeOnly time, string haircutName, int haircutPrice) {
            BarberName = barberName;
            Time = time;
            HaircutName = haircutName;
            HaircutPrice = haircutPrice;
        }
    }
}
