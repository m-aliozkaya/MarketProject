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
        public FormAddProduct()
        {
            InitializeComponent();
        }


        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            List<Product> products = ProductManager.selectProducts();

           
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           
            string productName = txtproductName.Text;
            double productPrice = Convert.ToDouble(txtproductPrice.Text);

            // kraicim ID yi halleder
            Product product = new Product(0,productName,productPrice);
        }
    }
}
