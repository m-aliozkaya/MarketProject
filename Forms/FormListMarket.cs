using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject
{
    public partial class FormListMarket : Form
    {
        private List<Market> marketList = new List<Market>();

        public FormListMarket()
        {
            InitializeComponent();
        }

        private void FormListMarket_Load(object sender, EventArgs e)
        {

            string tableName = "Market";

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

            foreach (Market market in marketList)
            {
                comboBox1.Items.Add(market.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Market selectedMarket = marketList[comboBox1.SelectedIndex];
            List<Product> productList = new List<Product>();

            string tableName = "Product";

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

                        selectedMarket.productList = productList;
                    }

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

            dataGridView1.DataSource = selectedMarket.productList;
        }
    }
}
