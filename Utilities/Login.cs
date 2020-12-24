using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    class Login
    {

        private static string tableName = "userTable";
        private static string userColumn = "userName";
        private static string passwordColumn = "userPassword";

        public static Boolean login(string userName, string password)
        {

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"SELECT * from {tableName} where {userColumn} = '{userName}' AND {passwordColumn} = '{password}'";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    command.Connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())

                    {
                        if (dr.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

    }
}

