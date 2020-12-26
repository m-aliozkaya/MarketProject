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
    public partial class FormAddMarket : Form
    {
        public FormAddMarket()
        {
            InitializeComponent();
        }

        private void FormAddList_Load(object sender, EventArgs e)
        {
            List<Product> products = ProductManager.selectProducts();

            foreach (Product product in products)
            {
                checkListProducts.Items.Add(product);
            }

        }

        private void btnAddMarket_Click(object sender, EventArgs e)
        {
            string marketName = txtMarketName.Text;
            string marketAdress = txtMarketAdres.Text;

            Market market = new Market(marketName, marketAdress);

            market.marketID = MarketManager.addMarket(market);

            foreach (Product product in checkListProducts.CheckedItems)
            {
                ProductManager.addProduct(product, market);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
