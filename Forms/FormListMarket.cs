using MarketProject.Forms;
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
        private BindingList<Market> marketList;
        private Market selectedMarket;

        public FormListMarket()
        {
            InitializeComponent();
        }

        private void FormListMarket_Load(object sender, EventArgs e)
        {

            marketList = MarketManager.getMarkets();

            foreach (Market market in marketList)
            {
                cmbBoxMarkets.Items.Add(market);
            }

            cmbBoxMarkets.SelectedIndex = 0;

        }


        private void cmbBoxMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedMarket = marketList[cmbBoxMarkets.SelectedIndex];

            selectedMarket.productList = ProductManager.getProducts(selectedMarket);
            selectedMarket.employeeList = EmployeeManager.getEmployees(selectedMarket);

            dataProduct.DataSource = selectedMarket.productList;
            dataProduct.Columns["productID"].Visible = false;
            dataProduct.Columns["supplier"].Visible = false;
            dataProduct.Columns["productPrice"].ReadOnly = true;
            dataProduct.Columns["productName"].ReadOnly = true;



            dataEmployee.DataSource = selectedMarket.employeeList;
            dataEmployee.Columns["employeeID"].Visible = false;
            dataEmployee.Columns["market"].Visible = false;
            dataEmployee.Columns["totalWorkingTime"].ReadOnly = true;


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbBoxMarkets.SelectedIndex;

            if (selectedIndex != -1)
            {
                cmbBoxMarkets.Items.RemoveAt(selectedIndex);
                MarketManager.deleteMarket(marketList[selectedIndex].marketID);

            }
            else
            {
                MessageBox.Show("Lütfen bir market seçiniz");
            }
         

          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FormAddProductMarket formAddProductMarket = new FormAddProductMarket();
            formAddProductMarket.TopLevel = false;
            this.Controls.Add(formAddProductMarket);
            formAddProductMarket.Dock = DockStyle.Fill;
            formAddProductMarket.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Product product in selectedMarket.productList)
            {
                ProductManager.updateProductStok(product, selectedMarket);
            }

            BindingList<Employee> employeeDb = EmployeeManager.getEmployees();

            int i = 0;

            foreach (Employee employee in selectedMarket.employeeList)
            {
                if (employee.employeeSalary <employeeDb[i].employeeSalary)
                {
                    MessageBox.Show("Çalışanın maaşı öncekinden küçük olamaz!");
                    employee.employeeSalary = employeeDb[i].employeeSalary;
                    selectedMarket.employeeList.ResetBindings();
                } else
                {
                    EmployeeManager.updateEmployee(employee);
                }
            }
        }
    }
}
