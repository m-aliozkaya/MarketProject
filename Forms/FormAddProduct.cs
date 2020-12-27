using MarketProject.Managers;
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
        private BindingList<Supplier> supplierList;

        public FormAddProduct()
        {
            InitializeComponent();
        }


        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            supplierList = SupplierManager.getSuppliers();

            foreach (Supplier supplier in supplierList)
            {
                cmbBoxSupplier.Items.Add(supplier.supplierName);
            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           
            string productName = txtproductName.Text;
            double productPrice = Convert.ToDouble(txtproductPrice.Text);
            Supplier supplier = supplierList[cmbBoxSupplier.SelectedIndex];

            // kraicim ID yi halleder
            Product product = new Product(productName,productPrice, supplier);

            ProductManager.addProduct(product);

        }

        private void cmbBoxMarket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtproductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
