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
            BindingList<Product> products = ProductManager.getProducts();

            foreach (Product product in products)
            {
                checkListProducts.Items.Add(product);
            }

        }

        private void btnAddMarket_Click(object sender, EventArgs e)
        {
            string marketName = txtMarketName.Text;
            string marketAdress = txtMarketAdres.Text;
            string[] stoklar = richTextBox1.Lines;

            Market market = new Market(marketName, marketAdress);

            market.marketID = MarketManager.addMarket(market);
            int i = 0;

            foreach (Product product in checkListProducts.CheckedItems)
            {
                ProductManager.addProductStock(product, market, Convert.ToInt32(stoklar[i++]));
            }

       
        }


 
    }
}
