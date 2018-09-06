using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GradingSystem
{
    class Database
    {
        public Database()
        {
            SqlConnection connection = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            SqlDataReader dataReader;

            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from AdminInfo";
            connection.Close();
        }
    }
}
