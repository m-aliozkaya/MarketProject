using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject
{
    public partial class FormListMarket : Form
    {
        public FormListMarket()
        {
            InitializeComponent();
        }

        private void FormListMarket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketProjectDataSet.Market' table. You can move, or remove it, as needed.
            this.marketTableAdapter.Fill(this.marketProjectDataSet.Market);

        }
    }
}
