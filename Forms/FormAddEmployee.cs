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
        private BindingList<Market> marketList;
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            marketList = MarketManager.getMarkets();

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
           string employeePosition = cmbPozisyon.Text;
           string employeeHoliday = cmbBoxHoliday.Text;
           Market market = (Market) cmbMarket.SelectedItem;

           Employee employee = new Employee(
               employeeName
               ,employeeAdress
               ,employeeSalary
               ,market
               ,employeePosition
               ,employeeHoliday);

           EmployeeManager.addEmployee(employee);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
