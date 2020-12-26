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
        List<Supplier> supplierList = new List<Supplier>();
        public FormListSupplier()
        {
            InitializeComponent();
        }

        private void FormListSupplier_Load(object sender, EventArgs e)
        {
            supplierList = SupplierManager.getSuppliers();

            dataSupplier.DataSource = supplierList;
        }
    }
}
