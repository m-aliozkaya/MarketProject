using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketProject
{
    // Product database operations
    class ProductManager
    {
        private static string tableNameStock = "ProductStock";
        private static string tableNameProduct = "Product";
        private static string tableNameSupplier = "Supplier";
        private static string supplierNameColumn = "supplierName";
        private static string nameColumn = "productName";
        private static string idColumn = "productID";
        private static string stockColumn = "stokDurumu";
        private static string priceColumn = "productPrice";
        private static string indirimColumn = "indirimYuzdesi";
        private static string marketColumn = "marketID";
        private static string supplierColumn = "supplierID";
        private static string dateColumn = "indirimTarihi";


        public static BindingList<Product> getProducts(Market selectedMarket)
        {
            BindingList<Product> productList = new BindingList<Product>();

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"SELECT {tableNameStock}.{stockColumn}" +
                    $", {tableNameProduct}.{nameColumn}" +
                    $", {tableNameProduct}.{priceColumn} " +
                    $", {tableNameProduct}.{idColumn} " +
                    $", {tableNameStock}.{indirimColumn} " +
                    $", {tableNameStock}.{stockColumn} " +
                    $", {tableNameStock}.{dateColumn} " +
                    $"from {tableNameStock} inner join {tableNameProduct} " +
                    $"on {tableNameProduct}.{idColumn} = {tableNameStock}.{idColumn} " +
                    $"where marketID = {selectedMarket.marketID}";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())

                    {
                        while (dr.Read())
                        {
                            DateTime date = DateTime.MinValue;

                            if (dr["indirimTarihi"] != DBNull.Value)
                            {
                                date = (DateTime)dr["indirimTarihi"];
                            }


                            Product product = new Product(
                                (int)dr["productID"],
                               (int)dr["stokDurumu"]
                                , (string)dr["productName"]
                                , (double)dr["productPrice"]
                                , (int)dr["indirimYuzdesi"]
                                , date
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

        public static BindingList<Product> getProducts()
        {
            BindingList<Product> productList = new BindingList<Product>();

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"SELECT " +
                  $" {tableNameProduct}.{nameColumn}" +
                  $", {tableNameProduct}.{priceColumn} " +
                  $", {tableNameProduct}.{idColumn} " +
                  $", {tableNameSupplier}.{supplierNameColumn} " +
                  $"from {tableNameProduct} " +
                  $"inner join {tableNameSupplier} " +
                  $"on {tableNameProduct}.{supplierColumn} = {tableNameSupplier}.{supplierColumn} ";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())

                    {
                        while (dr.Read())
                        {
                            Product product = new Product(
                                (int)dr["productID"],
                                (string)dr["productName"],
                                (double)dr["productPrice"],
                                new Supplier((string)dr["supplierName"])

                                ); ;
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

        public static void addProduct(Product product)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"INSERT into {tableNameProduct}({nameColumn}, {priceColumn}, {supplierColumn}) Values('{product.productName}', {product.productPrice}, {product.supplier.supplierID})";
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

        public static void addProductStock(Product product, Market market, int stok)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"INSERT into {tableNameStock}({idColumn}, {marketColumn}, {stockColumn}) Values('{product.productID}', {market.marketID}, {stok})";
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

        public static void deleteProduct(int productID)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"Delete from {tableNameProduct} where {idColumn} = {productID}";
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

        public static void updateProduct(Product product)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"UPDATE {tableNameProduct} SET " +
                    $"{nameColumn} = '{product.productName}'" +
                    $", {priceColumn} = '{product.productPrice}' " +
                    $"where {idColumn} = {product.productID}";
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

        public static void updateProductWithIndirim(Product product, Market market)
        {
            using (SqlConnection connection = Database.getConnection())
            {

                string query = $"UPDATE {tableNameStock} SET " +
                    $" {dateColumn} = '{DateTime.Now.Date.ToString("yyyy-MM-dd")}' " +
                    $", {indirimColumn} = '{product.indirimOrani}' " +
                    $"where {idColumn} = {product.productID} and {marketColumn}={market.marketID}";
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

        public static void updateProductStok(Product product, Market market)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"UPDATE {tableNameStock} SET " +
                    $"{stockColumn} = '{product.stokDurumu}'" +
                    $"where {idColumn} = {product.productID} and {marketColumn}={market.marketID}";
                
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
