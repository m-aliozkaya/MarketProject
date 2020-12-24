using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MarketProject
{
    // Employee database operations
    class EmployeeManager
    {
        private static string tableName = "Employee";

        public static List<Employee> selectEmployees(Market selectedMarket)
        {
            List<Employee> employeeList = new List<Employee>();

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
                            Employee employee = new Employee(
                                (string)dr["employeeName"]
                                , (string)dr["employeeAdres"]
                                , (double)dr["employeePrice"]
                                , (int)dr["yearlyHoliday"]
                                );
                            employeeList.Add(employee);
                        }

                    }

                    return employeeList;

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


    }
}
