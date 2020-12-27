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
    public partial class FormListSupplier : Form
    {
        BindingList<Supplier> supplierList = new BindingList<Supplier>();
        public FormListSupplier()
        {
            InitializeComponent();
        }

        private void FormListSupplier_Load(object sender, EventArgs e)
        {
            supplierList = SupplierManager.getSuppliers();

            dataSupplier.DataSource = supplierList;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataSupplier.SelectedRows)
            {
                SupplierManager.deleteSupplier((int)row.Cells["supplierID"].Value);

                dataSupplier.Rows.Remove(row);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Supplier supplier in supplierList)
            {
                SupplierManager.updateSupplier(supplier);
            }
        }
    }
}
