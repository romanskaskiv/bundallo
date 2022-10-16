using System;
using Npgsql;

namespace bundallo
{
    internal class Program
    {
        const string connectionString = "Host=localhost;" +
                                        "Username=postgres;" +
                                        "Password=postgres;" +
                                        "Database=BundalloDB";

        private const string query = "SELECT * FROM users";
        
        static void Main(string[] args)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            var command = new NpgsqlCommand(query, connection);
            
            var dr = command.ExecuteReader();

            Console.WriteLine(dr);
            connection.Close();
            
            
        }
    }
}