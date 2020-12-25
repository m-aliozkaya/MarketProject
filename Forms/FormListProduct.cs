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
        private List<Product> productList;

        public FormListProduct()
        {
            InitializeComponent();
        }

        private void FormListProduct_Load(object sender, EventArgs e)
        {
            productList = ProductManager.selectProducts();

            dataGridViewProduct.DataSource = productList;

        }

        
    }
}
