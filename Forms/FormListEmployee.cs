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
    public partial class FormListEmployee : Form
    {
        private BindingList<Employee> employeeList;
        private BindingList<Market> marketList;

        public FormListEmployee()
        {
            InitializeComponent();
        }

        private void FormListEmployee_Load(object sender, EventArgs e)
        {
            employeeList = EmployeeManager.getEmployees();

            dataGridViewEmployee.DataSource = employeeList;
            dataGridViewEmployee.Columns["employeeID"].Visible = false;
            dataGridViewEmployee.Columns["totalWorkingTime"].ReadOnly = true;
            dataGridViewEmployee.Columns["market"].Visible = false;

            marketList = MarketManager.getMarkets();


            DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            dataGridViewComboBoxColumn.DefaultCellStyle.NullValue = employeeList[0].market.marketName;

            dataGridViewComboBoxColumn.HeaderText = "marketler";
            dataGridViewComboBoxColumn.Name = "marketler";
            dataGridViewComboBoxColumn.FlatStyle = FlatStyle.Popup;


         dataGridViewEmployee.Columns.Add(dataGridViewComboBoxColumn);


            foreach (Market market in marketList)
            {
                ((DataGridViewComboBoxColumn)dataGridViewEmployee.Columns["marketler"]).Items.Add(market.marketName);
            }



        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEmployee.SelectedRows)
            {
                EmployeeManager.deleteEmployee((int)row.Cells["employeeID"].Value);
                dataGridViewEmployee.Rows.Remove(row);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            BindingList<Employee> employeeDb = EmployeeManager.getEmployees();

            int i = 0;

            foreach (Employee employee in employeeList)
            {
                if (employee.employeeSalary < employeeDb[i].employeeSalary)
                {
                    MessageBox.Show("Çalışanın maaşı öncekinden küçük olamaz!");
                    employee.employeeSalary = employeeDb[i].employeeSalary;
                    employeeList.ResetBindings();
                }
                else
                {
                    EmployeeManager.updateEmployee(employee);
                }
            }
        }

        private void dataGridViewEmployee_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridViewEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridViewEmployee.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridViewEmployee.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ((ComboBox)sender).SelectedIndex;

            Employee employee = employeeList[dataGridViewEmployee.CurrentCell.RowIndex];
            employee.market = marketList[selectedIndex];
        }
    

        private void dataGridViewEmployee_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewEmployee.CurrentCell.ColumnIndex == 0)
            {
                // Check box column
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            }
        }
    }
}
