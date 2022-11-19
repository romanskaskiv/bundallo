using System;
using System.Linq;

namespace bundallo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Nickname} {u.FirstName} - {u.LastName}");
                }
            }
        }
    }
}