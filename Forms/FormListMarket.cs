using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject
{
    public partial class FormListMarket : Form
    {
        private List<Market> marketList;

        public FormListMarket()
        {
            InitializeComponent();
        }

        private void FormListMarket_Load(object sender, EventArgs e)
        {
           marketList = MarketManager.GetMarkets();

            foreach (Market market in marketList)
            {
                cmbBoxMarkets.Items.Add(market);
            }

            cmbBoxMarkets.SelectedIndex = 0;

        }


        private void cmbBoxMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {

            Market selectedMarket = marketList[cmbBoxMarkets.SelectedIndex];

            selectedMarket.productList = ProductManager.selectProducts(selectedMarket);
            selectedMarket.employeeList = EmployeeManager.selectEmployees(selectedMarket);

            dataProduct.DataSource = selectedMarket.productList;
            dataProduct.Columns["supplier"].Visible = false;
            dataProduct.Columns["market"].Visible = false;

            dataEmployee.DataSource = selectedMarket.employeeList;
            dataEmployee.Columns["employeeID"].Visible = false;
/*            dataEmployee.Columns[""].Visible = false;
*/        }
    }
}
