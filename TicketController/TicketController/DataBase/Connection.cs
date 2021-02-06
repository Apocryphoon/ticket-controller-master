using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketController.DataBase
{
    public class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=162.241.203.130;database=stud1190_bravogrc;uid=stud1190_ricardo;pwd=Ricardo02180218";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
