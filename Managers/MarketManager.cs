using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace MarketProject
{
    // Market database operations
    class MarketManager
    {
       private static string tableName = "Market";
       private static string nameColumn = "marketName";
       private static  string adresColumn = "marketAdres";
       private static  string idColumn = "marketID";

        public static BindingList<Market> getMarkets()
        {
            BindingList<Market> marketList = new BindingList<Market>();

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"SELECT * from {tableName}";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())

                    {
                        while (dr.Read())
                        {
                            Market market = new Market(
                               (int)dr["marketId"]
                                , (string)dr["marketName"]
                                , (string)dr["marketAdres"]
                                );
                            marketList.Add(market);
                        }
                    }

                    return marketList;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

       public static int addMarket(Market market)
        {
      
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"INSERT into {tableName}({nameColumn}, {adresColumn}) VALUES('{market.marketName}', '{market.marketAdress}'); SELECT SCOPE_IDENTITY()";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }

            }

        }

        public static void deleteMarket(int marketId)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"Delete from {tableName} where {idColumn} = {marketId}";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public static void updateMarket(Market market)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"UPDATE {tableName} SET {nameColumn} = '{market.marketName}', {adresColumn} = '{market.marketAdress}' where {idColumn} = {market.marketID}";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }


    }
}
