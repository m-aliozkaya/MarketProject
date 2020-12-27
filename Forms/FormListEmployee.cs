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
    }
}
