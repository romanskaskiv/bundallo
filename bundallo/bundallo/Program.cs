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

        private const string query = "SELECT * FROM public.users LIMIT 2";
        
        static void Main(string[] args)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var nickname="";
            var cmd = new NpgsqlCommand(query, connection);

            var users = new List<User>();
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