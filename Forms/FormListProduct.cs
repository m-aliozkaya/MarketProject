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
    public partial class FormListProduct : Form
    {
        private BindingList<Product> productList;

        public FormListProduct()
        {
            InitializeComponent();
        }

        private void FormListProduct_Load(object sender, EventArgs e)
        {
            productList = ProductManager.getProducts();

            dataGridViewProduct.DataSource = productList;
            dataGridViewProduct.Columns["productID"].Visible = false;
            dataGridViewProduct.Columns["stokDurumu"].Visible = false;
            dataGridViewProduct.Columns["supplier"].ReadOnly = true;
            dataGridViewProduct.Columns["indirimOrani"].Visible = false;
            dataGridViewProduct.Columns["indirimTarihi"].Visible = false;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProduct.SelectedRows)
            {
                ProductManager.deleteProduct((int)row.Cells["productID"].Value);

                dataGridViewProduct.Rows.Remove(row);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Product product in productList)
            {
                
                    ProductManager.updateProduct(product);
                
            }
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
