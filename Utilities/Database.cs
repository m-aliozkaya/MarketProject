using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    class Database
    {
        private static string connectionString = "Data Source=localhost;Initial Catalog=MarketProject;Integrated Security=True";

        public static SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }

    }
}
