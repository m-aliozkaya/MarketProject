using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MarketProject
{
    // Product database operations
    class ProductManager
    {
        private static string tableName = "Product";
        private static string nameColumn = "productName";
        private static string priceColumn = "productPrice";
        private static string marketColumn = "marketID";

        public static List<Product> selectProducts(Market selectedMarket)
        {
            List<Product> productList = new List<Product>();

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"SELECT * from {tableName} where marketID = {selectedMarket.marketID}";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())

                    {
                        while (dr.Read())
                        {
                            Product product = new Product(
                               (int)dr["productID"]
                                , (string)dr["productName"]
                                , (double)dr["productPrice"]
                                );
                            productList.Add(product);
                        }

                    }

                    return productList;

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

        public static List<Product> selectProducts()
        {
            List<Product> productList = new List<Product>();

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
                            Product product = new Product(
                               (int)dr["productID"]
                                , (string)dr["productName"]
                                , (double)dr["productPrice"]
                                );
                            productList.Add(product);
                        }

                    }

                    return productList;

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

        public static void addProduct(Product product, Market market)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"INSERT into {tableName}({nameColumn}, {priceColumn}, {marketColumn}) Values('{product.productName}', {product.productPrice}, {market.marketID})";
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
