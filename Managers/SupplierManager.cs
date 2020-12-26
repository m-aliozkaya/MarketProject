using System;
using System.Collections.Generic;
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
        private static string adresColumn = "supplierAdress";


        public static List<Supplier> getSuppliers()
        {
            List<Supplier> supplierList = new List<Supplier>();

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
    }
}
