using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject.Managers
{
    class SupplierManager
    {
        private static string tableName = "Supplier";
        private static string nameColumn = "supplierName";
        private static string idColumn = "supplierID";
        private static string adresColumn = "supplierAdress";


        public static BindingList<Supplier> getSuppliers()
        {
            BindingList<Supplier> supplierList = new BindingList<Supplier>();

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"SELECT * from {tableName} ";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())

                    {
                        while (dr.Read())
                        {
                            Supplier supplier = new Supplier(
                                (int)dr["supplierId"]
                                , (string)dr["supplierName"]
                                , (string)dr["supplierAdress"]
                                );
                            supplierList.Add(supplier);
                        }

                    }

                    return supplierList;

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

        public static void addSupplier(Supplier supplier)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"INSERT into {tableName}({nameColumn}, {adresColumn}) Values('{supplier.supplierName}' , '{supplier.supplierAdress}') ";
              
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

        public static void deleteSupplier(int supplierID)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"Delete from {tableName} where {idColumn} = {supplierID}";
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

        public static void updateSupplier(Supplier supplier)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"UPDATE {tableName} SET {nameColumn} = '{supplier.supplierName}', {adresColumn} = '{supplier.supplierAdress}' where {idColumn} = {supplier.supplierID}";
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
