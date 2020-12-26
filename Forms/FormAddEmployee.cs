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
    public partial class FormAddEmployee : Form
    {
        private List<Market> marketList;
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            marketList = MarketManager.GetMarkets();

            foreach (Market market in marketList)
            {
                cmbMarket.Items.Add(market);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           string employeeName = txtName.Text;
           string employeeAdress = txtAdres.Text;
           double employeeSalary = Convert.ToDouble(txtSalary.Text);


           EmployeeManager.addEmployee(
               new Employee(employeeName, employeeAdress, employeeSalary, marketList[cmbMarket.SelectedIndex]) 
               ); 
        }
    }
}
