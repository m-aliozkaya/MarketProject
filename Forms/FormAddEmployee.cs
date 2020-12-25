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
    public partial class FormAddEmployee : Form
    {
        List<Market> marketList;
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string employeeAdress = txtemployeeAdress.Text;
            string employeeName = txtemployeeName.Text;
            double employeeSalary = Convert.ToDouble(txtSalary.Text);
            Market market = marketList[cmbBoxMarket.SelectedIndex];

                
            Employee employee = new Employee(employeeName, employeeAdress, employeeSalary, market );

            EmployeeManager.addEmployee(employee);
        }



        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            marketList = MarketManager.GetMarkets();

            foreach (Market market in marketList)
            {
                cmbBoxMarket.Items.Add(market.marketName);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtemployeName(object sender, EventArgs e)
        {

        }
    }
}
