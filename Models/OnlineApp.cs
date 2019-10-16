using MySql.Data.MySqlClient;

namespace CallTheNurse.Models
{
    public class OnlineApp
    {
        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=CallTheNurse;user=root;password=root;port=3306";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            return con;
        }
    }
}