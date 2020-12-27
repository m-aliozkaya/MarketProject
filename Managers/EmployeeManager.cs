using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarketProject
{
    // Employee database operations
    class EmployeeManager
    {
        private static string tableName = "Employee";
        private static string nameColumn = "employeeName";
        private static string idColumn = "employeeID";
        private static string adresColumn = "employeeAdres";
        private static string salaryColumn = "employeePrice";
        private static string positionColumn = "employeePosition";
        private static string dateColumn = "employeeTime";
        private static string priceColumn = "employeePrice";
        private static string holidayColumn = "dailyHoliday";
        private static string marketColumn = "marketID";
        

        public static BindingList<Employee> getEmployees(Market selectedMarket)
        {
            BindingList<Employee> employeeList = new BindingList<Employee>();

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
                            int totalWorkingTime = (int)(DateTime.Now.Date - (DateTime)dr["employeeTime"]).TotalDays;

                            Employee employee = new Employee(
                                (int)dr["employeeID"]
                                ,(string)dr["employeeName"]
                                ,(string)dr["employeeAdres"]
                                , (string)dr["employeePosition"]
                                , (double)dr["employeePrice"]
                                , (int)dr["yearlyHoliday"]
                                ,(string)dr["dailyHoliday"]
                                ,totalWorkingTime
                                );;
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

        public static BindingList<Employee> getEmployees()
        {
            BindingList<Employee> employeeList = new BindingList<Employee>();

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"SELECT * from {tableName} inner join Market on {tableName}.{marketColumn} = Market.{marketColumn}";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();

                    using (SqlDataReader dr = command.ExecuteReader())

                    {
                        while (dr.Read())
                        {
                            int totalWorkingTime = (int)(DateTime.Now.Date - (DateTime)dr["employeeTime"]).TotalDays;

                            Employee employee = new Employee(
                                (int)dr["employeeID"]
                                , (string)dr["employeeName"]
                                , (string)dr["employeeAdres"]
                                , (string)dr["employeePosition"]
                                , (double)dr["employeePrice"]
                                , (int)dr["yearlyHoliday"]
                                , (string)dr["dailyHoliday"]
                                , new Market((string)dr["marketName"])
                                , totalWorkingTime
                                ); ;
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

        public static void addEmployee(Employee employee)
        {

            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"INSERT into {tableName}({nameColumn}, {adresColumn}, {salaryColumn}, {marketColumn}, {dateColumn}, {positionColumn}, {holidayColumn}) " +
                    $"VALUES('{employee.employeeName}'" +
                    $", '{employee.employeeAdress}'" +
                    $", '{employee.employeeSalary}' " +
                    $", '{employee.market.marketID}'" +
                    $", '{DateTime.Now.Date.ToString("yyyy-MM-dd")}'" +
                    $", '{employee.position}'"+
                    $", '{employee.dailyHoliday}')";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public static void deleteEmployee(int employeeId)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"Delete from {tableName} where {idColumn} = {employeeId}";
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

        public static void updateEmployee(Employee employee)
        {
            using (SqlConnection connection = Database.getConnection())
            {
                string query = $"UPDATE {tableName} SET " +
                    $"{nameColumn} = '{employee.employeeName}'" +
                    $", {adresColumn} = '{employee.employeeAdress}'" +
                    $", {holidayColumn} = '{employee.dailyHoliday}'" +
                    $", {priceColumn} = '{employee.employeeSalary}'" +
                    $", {positionColumn} = '{employee.position}'" +
                    $", {marketColumn} = '{employee.market.marketID}'" +
                    $" where {idColumn} = {employee.employeeID}";


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
