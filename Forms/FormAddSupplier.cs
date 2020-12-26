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
    public partial class FormAddSupplier : Form
    {
        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string supplierName = txtName.Text;
            string supplierAdress = txtAdres.Text;
            Supplier supplier = new Supplier(supplierName, supplierAdress);

            SupplierManager.addSupplier(supplier);
        }
    }
}
