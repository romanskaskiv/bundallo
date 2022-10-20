using System;
using System.Collections.Generic;
using Npgsql;

namespace bundallo
{
    
    class Program
    {
        const string connectionString = "Host=localhost;" +
                                        "Username=postgres;" +
                                        "Password=postgres;" +
                                        "Database=BundalloDB";

        private const string query1 = "SELECT * FROM public.users LIMIT 2";

        private static void InsertData()
        {
            //var query2 = "INSERT INTO ";
        }
        
        
        static void Main(string[] args)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var cmd = new NpgsqlCommand(query1, connection);

            var users = new List<User>();
            var schedules = new List<Schedule>();
            var bookings = new List<Booking>();
            using (var reader = cmd.ExecuteReader())
            {
                var i = 0;
                while (reader.Read())
                {
                    var user = new User(
                        reader.GetString(reader.GetOrdinal("nickname")),
                        reader.GetBoolean(reader.GetOrdinal("is_admin")),
                        reader.GetString(reader.GetOrdinal("firstname")),
                        reader.GetString(reader.GetOrdinal("lastname")),
                        reader.GetString(reader.GetOrdinal("password"))
                    );

                    users.Add(user);
                    i++;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Nickname
                              + " " + user.IsAdmin
                              + " " + user.FirstName
                              + " " + user.LastName
                              + " " + user.Password);
            }
        }
    }
}