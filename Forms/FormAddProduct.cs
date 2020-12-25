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
    public partial class FormAddProduct : Form
    {
        private List<Market> marketList;

        public FormAddProduct()
        {
            InitializeComponent();
        }


        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            marketList = MarketManager.GetMarkets();

            foreach (Market market in marketList)
            {
                cmbBoxMarket.Items.Add(market.marketName);
            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           
            string productName = txtproductName.Text;
            double productPrice = Convert.ToDouble(txtproductPrice.Text);
            Market market = marketList[cmbBoxMarket.SelectedIndex];

            // kraicim ID yi halleder
            Product product = new Product(productName,productPrice, market);

            ProductManager.addProduct(product, market);
           
        }

        
    }
}
