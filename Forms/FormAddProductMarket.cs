using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Forms
{
    public partial class FormAddProductMarket : Form
    {
        BindingList<Market> marketList = MarketManager.getMarkets();

        public FormAddProductMarket()
        {
            InitializeComponent();
        }

        private void FormEditMarket_Load(object sender, EventArgs e)
        {
            BindingList<Product> productList = ProductManager.getProducts();

            foreach (Product product in productList)
            {
                checkListProducts.Items.Add(product);
            }

            foreach (Market market in marketList)
            {
                cmbBoxMarkets.Items.Add(market);
            }

            cmbBoxMarkets.SelectedIndex = 0;
        }

        private void btnAddMarket_Click(object sender, EventArgs e)
        {
            string[] stoklar = richTextBox1.Lines;

            Market selectedMarket = marketList[cmbBoxMarkets.SelectedIndex];

            int i = 0;

            foreach (Product product in checkListProducts.CheckedItems)
            {
                ProductManager.addProductStock(product, selectedMarket, Convert.ToInt32(stoklar[i++]));
            }

        }
    }
}
