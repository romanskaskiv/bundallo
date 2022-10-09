using System.Data.SqlClient;

namespace bundallo
{
    internal class Program
    {
        const string ConnectionString="Data Source=localhost;Initial Catalog=BundalloDB;User ID=postgres;Password=postgres";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select * from users";
            command.ExecuteReader();
        }
    }
}